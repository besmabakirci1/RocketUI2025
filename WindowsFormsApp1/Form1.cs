using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET.MapProviders;
using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System.Globalization;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        
        private SerialPort _gpsPort;
        private GMapControl _gmapControl;
        private GMapOverlay _markersOverlay;

        private StringBuilder _dataBuffer = new StringBuilder();

        public Form1()
        {
            InitializeComponent();

            this.Load += Form1_Load;

            // Form ilk açılırken Paraşüt 1 Pasif, Paraşüt 2 Pasif olsun
            SetParachute1State(isActive: false);
            SetParachute2State(isActive: false);

        }

        private void SetParachute1State(bool isActive)
        {
            if (isActive)
            {
                label_parachute1Active.Visible = true;
                label_parachute1Pasif.Visible = false;
            }
            else
            {
                label_parachute1Active.Visible = false;
                label_parachute1Pasif.Visible = true;
            }
        }

        private void SetParachute2State(bool isActive)
        {
            if (isActive)
            {
                label_parachute2Active.Visible = true;
                label_parachute2Pasif.Visible = false;
            }
            else
            {
                label_parachute2Active.Visible = false;
                label_parachute2Pasif.Visible = true;
            }
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            // ===== Harita (gMap) Ayarları =====

            // 1. Harita sağlayıcısı: GoogleMap veya OpenStreetMap
            gMap.MapProvider = GMapProviders.GoogleMap;
            // Eğer Google API kısıtı varsa:
            // gMap.MapProvider = GMapProviders.OpenStreetMap;

            // 2. İnternetten harita parçalarını indir ve diske önbelleğe kaydet
            GMaps.Instance.Mode = AccessMode.ServerAndCache;

            // 3. Zoom sınırları
            gMap.MinZoom = 2;    // Dünyayı en uzak gösterme
            gMap.MaxZoom = 18;   // En çok bu kadar yakınlaşabilme

            // 4. Başlangıç zoom seviyesi
            gMap.Zoom = 5;

            // 5. Fare tekerleği ile yakınlaştırma-uzaklaştırma açık
            gMap.MouseWheelZoomEnabled = true;
            gMap.MouseWheelZoomType = MouseWheelZoomType.MousePositionAndCenter;

            // 6. Harita üzerinde sürükleme (pan) açık
            gMap.CanDragMap = true;
            gMap.DragButton = MouseButtons.Left;

            // 7. Başlangıç pozisyonu (örnek: Türkiye koordinatlarına yakın)
            double başlangıçLat = 39.96922983;
            double başlangıçLng = 32.74309033;
            gMap.Position = new PointLatLng(başlangıçLat, başlangıçLng);

            // 8. Ortadaki kırmızı center işaretçisini gizle (opsiyonel)
            gMap.ShowCenter = false;
            
            // ===== Overlay (Marker Katmanı) Oluşturma =====

            // Yeni bir overlay oluştur ve bu overlay’i gMap kontrolüne ekle
            _markersOverlay = new GMapOverlay("markers");
            gMap.Overlays.Add(_markersOverlay);

            // ===== İlk Bir Test Marker (Opsiyonel) =====

            // (Eğer sadece GPS geldiğinde marker görmek isterseniz, bu 3 satırı silebilirsiniz)
            var testMarker = new GMarkerGoogle(
                new PointLatLng(başlangıçLat, başlangıçLng),
                GMarkerGoogleType.blue_pushpin
            );
            _markersOverlay.Markers.Add(testMarker);

            _gpsPort = new SerialPort
            {
                PortName = "COM6",   // Kendi bilgisayarınızda görünen GPS portunu yazın
                BaudRate = 9600,     // GPS cihazınızın baud rate ayarı
                Parity = Parity.None,
                DataBits = 8,
                StopBits = StopBits.One,
                Handshake = Handshake.None
            };
            // b) DataReceived olayını bağla
            _gpsPort.DataReceived += GpsPort_DataReceived;
            // c) Seri portu açmaya çalış
            try
            {
                _gpsPort.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Seri port açılamadı: {ex.Message}",
                    "GPS Port Hatası",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }


            // 1. Paraşüt: Başlangıçta “Active” etiketini gizle, “Pasif” etiketini göster
            //label_parachute1Active.Visible = false;
            //label_parachute1Pasif.Visible = true;
            // 2. Paraşüt: Başlangıçta “Active” etiketini gizle, “Pasif” etiketini göster
            // label_parachute2Active.Visible = false;
            //label_parachute2Pasif.Visible = true;
        }
        // ---- 1. GpsPort_DataReceived: Seri Porttan Her Veri Geldiğinde Çalışır ----
        private void GpsPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                // A) Seri porttan gelen tüm metni oku
                string incoming = _gpsPort.ReadExisting();

                // B) Buffer’a ekle (birden fazla parça halinde gelebilir)
                _dataBuffer.Append(incoming);

                // C) Buffer’da satır-başı (\r\n) var mı kontrol et
                string content = _dataBuffer.ToString();
                int newlineIndex;

                // D) Birden fazla satır olabileceği için döngüyle işleyelim
                while ((newlineIndex = content.IndexOf("\r\n")) >= 0)
                {
                    // 1. Satırın tamamını ayıkla
                    string line = content.Substring(0, newlineIndex);

                    // 2. Buffer’dan bu satırı ve \r\n karakterlerini sil
                    _dataBuffer.Remove(0, newlineIndex + 2);

                    // 3. content’i güncelle (bir sonraki döngü kontrolü için)
                    content = _dataBuffer.ToString();

                    // 4. Eğer satır “$GPGGA” ile başlıyorsa parse et
                    if (line.StartsWith("$GPGGA"))
                    {
                        ParseGpggaAndUpdateMap(line);
                    }
                    // Eğer başka bir NMEA cümlesini (örneğin GPRMC) kullanmak isterseniz:
                    // else if (line.StartsWith("$GPRMC"))
                    // {
                    //     ParseGprmcAndUpdateMap(line);
                    // }
                }
            }
            catch (Exception ex)
            {
                // Hata durumunda konsola yazdırabilirsiniz; kullanıcıya gösterilmeyebilir
                Console.WriteLine($"GPS Data Received Hatası: {ex.Message}");
            }
        }

        // ---- 2. ParseGpggaAndUpdateMap: GPGGA Satırını Parçalar, Haritayı Günceller ----
        private void ParseGpggaAndUpdateMap(string gpggaSentence)
        {
            // Örnek GPGGA: "$GPGGA,125959,3954.1234,N,03248.5678,E,1,08,0.9,545.4,M,46.9,M,,*47"
            var parts = gpggaSentence.Split(',');
            // parts[2] = "3954.1234"  → enlem ddmm.mmmm
            // parts[3] = "N"          → Kuzey (N) veya Güney (S)
            // parts[4] = "03248.5678" → boylam dddmm.mmmm
            // parts[5] = "E"          → Doğu (E) veya Batı (W)

            if (parts.Length < 6)
                return; // Eksik veri geldiyse çık

            try
            {
                // A) Enlem ve boylamı ondalıklı dereceye çevir
                double latitude = ConvertNmeaToDecimal(parts[2], parts[3]);
                double longitude = ConvertNmeaToDecimal(parts[4], parts[5]);

                // B) UI thread’e dön ve UpdateMapWithGps’i çağır
                this.Invoke((MethodInvoker)delegate
                {
                    UpdateMapWithGps(latitude, longitude);
                });
            }
            catch
            {
                // Parse hatası olursa yoksay
            }
        }

        // ---- 3. ConvertNmeaToDecimal: ddmm.mmmm Formatını Ondalıklı Dereceye Çevirir ----
        private double ConvertNmeaToDecimal(string value, string hemisphere)
        {
            // Örnek: "3954.1234" → 39 derece, 54.1234 dakika = 39 + (54.1234/60) = 39.902056...
            double raw = double.Parse(value, CultureInfo.InvariantCulture);
            double degrees = Math.Floor(raw / 100);
            double minutes = raw - (degrees * 100);
            double decimalDegrees = degrees + (minutes / 60);

            // Eğer Güney (S) veya Batı (W) ise negatif yap
            if (hemisphere == "S" || hemisphere == "W")
                decimalDegrees = -decimalDegrees;

            return decimalDegrees;
        }

        // ---- 4. UpdateMapWithGps: Haritayı Güncelle ve Marker Ekle ----
        private void UpdateMapWithGps(double latitude, double longitude)
        {
            // A) Haritanın merkezini GPS koordinatına taşı
            gMap.Position = new PointLatLng(latitude, longitude);

            // B) Önceki marker’ı temizle (sadece tek bir nokta gösterilsin)
            _markersOverlay.Markers.Clear();

            // C) Yeni bir kırmızı nokta marker oluştur
            var gpsMarker = new GMarkerGoogle(
                new PointLatLng(latitude, longitude),
                GMarkerGoogleType.red_dot
            );

            // D) Marker’ı overlay’e ekle ve haritada gözüksün
            _markersOverlay.Markers.Add(gpsMarker);

            // E) Yakınlaştırma seviyesi (opsiyonel)
            gMap.Zoom = 15;
        }
        private void Chart1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        //Test istasyon butonu
        private void button2_Click(object sender, EventArgs e)
        {
            var tsForm = new TestStation();
            tsForm.Show();
        }
        // payload butonu
        private void button3_Click(object sender, EventArgs e)
        {
            var pForm = new Payload();
            pForm.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void label_parachute1Pasif_Click(object sender, EventArgs e)
        {

        }

        private void label_parachute1Active_Click(object sender, EventArgs e)
        {
            
        }

        private void label_parachute2Pasif_Click(object sender, EventArgs e)
        {
            
        }

    

        private void AnaParasutDef_Click(object sender, EventArgs e)
        {

        }

        private void ApogeeDef_Click(object sender, EventArgs e)
        {

        }

        private void secondParachutePicture_Click(object sender, EventArgs e)
        {

        }

        private void label_parachute2Active_Click(object sender, EventArgs e)
        {

        }

        private void gMap_Load(object sender, EventArgs e)
        {

        }

        private void rdoPort3Status_Click(object sender, EventArgs e)
        {

        }
    }
}
