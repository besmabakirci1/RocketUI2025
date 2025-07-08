using System;

namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.logo = new System.Windows.Forms.PictureBox();
            this.qoute = new System.Windows.Forms.TextBox();
            this.groundStation = new System.Windows.Forms.Button();
            this.testStation = new System.Windows.Forms.Button();
            this.payload = new System.Windows.Forms.Button();
            this.firstParachutePicture = new System.Windows.Forms.PictureBox();
            this.firstParachuteLabel = new System.Windows.Forms.Label();
            this.secondParachutePicture = new System.Windows.Forms.PictureBox();
            this.secondParachuteLabel = new System.Windows.Forms.Label();
            this.label_parachute1Pasif = new System.Windows.Forms.Label();
            this.label_parachute1Active = new System.Windows.Forms.Label();
            this.ApogeeDef = new System.Windows.Forms.Button();
            this.AnaParasutDef = new System.Windows.Forms.Button();
            this.label_parachute2Pasif = new System.Windows.Forms.Label();
            this.label_parachute2Active = new System.Windows.Forms.Label();
            this.gMap = new GMap.NET.WindowsForms.GMapControl();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.groupBoxReceiver = new System.Windows.Forms.GroupBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.rdoPort3Status = new System.Windows.Forms.Label();
            this.rdoPort2Status = new System.Windows.Forms.Label();
            this.rdoPort1Status = new System.Windows.Forms.Label();
            this.rdoPort3 = new System.Windows.Forms.RadioButton();
            this.rdoPort2 = new System.Windows.Forms.RadioButton();
            this.rdoPort1 = new System.Windows.Forms.RadioButton();
            this.groupBoxTransmitter = new System.Windows.Forms.GroupBox();
            this.btnAutoSend = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.rdoPort4 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstParachutePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondParachutePicture)).BeginInit();
            this.groupBoxReceiver.SuspendLayout();
            this.groupBoxTransmitter.SuspendLayout();
            this.SuspendLayout();
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.SystemColors.WindowText;
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(55, 20);
            this.logo.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(208, 182);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 1;
            this.logo.TabStop = false;
            this.logo.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // qoute
            // 
            this.qoute.BackColor = System.Drawing.SystemColors.MenuText;
            this.qoute.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.qoute.Font = new System.Drawing.Font("Gabriola", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qoute.ForeColor = System.Drawing.Color.White;
            this.qoute.Location = new System.Drawing.Point(4, 203);
            this.qoute.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.qoute.Multiline = true;
            this.qoute.Name = "qoute";
            this.qoute.Size = new System.Drawing.Size(330, 99);
            this.qoute.TabIndex = 2;
            this.qoute.Text = "Through precision and courage, \r\nwe reach beyond the skies.";
            this.qoute.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.qoute.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // groundStation
            // 
            this.groundStation.ForeColor = System.Drawing.Color.OrangeRed;
            this.groundStation.Location = new System.Drawing.Point(55, 314);
            this.groundStation.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.groundStation.Name = "groundStation";
            this.groundStation.Size = new System.Drawing.Size(208, 51);
            this.groundStation.TabIndex = 3;
            this.groundStation.Text = "Ground Station ";
            this.groundStation.UseVisualStyleBackColor = true;
            this.groundStation.Click += new System.EventHandler(this.button1_Click);
            // 
            // testStation
            // 
            this.testStation.ForeColor = System.Drawing.Color.OrangeRed;
            this.testStation.Location = new System.Drawing.Point(55, 386);
            this.testStation.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.testStation.Name = "testStation";
            this.testStation.Size = new System.Drawing.Size(208, 51);
            this.testStation.TabIndex = 4;
            this.testStation.Text = "Test Station";
            this.testStation.UseVisualStyleBackColor = true;
            this.testStation.Click += new System.EventHandler(this.button2_Click);
            // 
            // payload
            // 
            this.payload.ForeColor = System.Drawing.Color.OrangeRed;
            this.payload.Location = new System.Drawing.Point(55, 460);
            this.payload.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.payload.Name = "payload";
            this.payload.Size = new System.Drawing.Size(208, 51);
            this.payload.TabIndex = 5;
            this.payload.Text = "Payload";
            this.payload.UseVisualStyleBackColor = true;
            this.payload.Click += new System.EventHandler(this.button3_Click);
            // 
            // firstParachutePicture
            // 
            this.firstParachutePicture.Image = ((System.Drawing.Image)(resources.GetObject("firstParachutePicture.Image")));
            this.firstParachutePicture.Location = new System.Drawing.Point(469, 51);
            this.firstParachutePicture.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.firstParachutePicture.Name = "firstParachutePicture";
            this.firstParachutePicture.Size = new System.Drawing.Size(133, 134);
            this.firstParachutePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.firstParachutePicture.TabIndex = 6;
            this.firstParachutePicture.TabStop = false;
            this.firstParachutePicture.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // firstParachuteLabel
            // 
            this.firstParachuteLabel.AutoSize = true;
            this.firstParachuteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstParachuteLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.firstParachuteLabel.Location = new System.Drawing.Point(474, 23);
            this.firstParachuteLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.firstParachuteLabel.Name = "firstParachuteLabel";
            this.firstParachuteLabel.Size = new System.Drawing.Size(126, 20);
            this.firstParachuteLabel.TabIndex = 7;
            this.firstParachuteLabel.Text = "1st Parachute\r\n";
            this.firstParachuteLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // secondParachutePicture
            // 
            this.secondParachutePicture.Image = ((System.Drawing.Image)(resources.GetObject("secondParachutePicture.Image")));
            this.secondParachutePicture.Location = new System.Drawing.Point(741, 51);
            this.secondParachutePicture.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.secondParachutePicture.Name = "secondParachutePicture";
            this.secondParachutePicture.Size = new System.Drawing.Size(133, 134);
            this.secondParachutePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.secondParachutePicture.TabIndex = 8;
            this.secondParachutePicture.TabStop = false;
            this.secondParachutePicture.Click += new System.EventHandler(this.secondParachutePicture_Click);
            // 
            // secondParachuteLabel
            // 
            this.secondParachuteLabel.AutoSize = true;
            this.secondParachuteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondParachuteLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.secondParachuteLabel.Location = new System.Drawing.Point(744, 23);
            this.secondParachuteLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.secondParachuteLabel.Name = "secondParachuteLabel";
            this.secondParachuteLabel.Size = new System.Drawing.Size(130, 20);
            this.secondParachuteLabel.TabIndex = 9;
            this.secondParachuteLabel.Text = "2nd Parachute";
            // 
            // label_parachute1Pasif
            // 
            this.label_parachute1Pasif.AccessibleDescription = "label_parachute1Pasif";
            this.label_parachute1Pasif.AccessibleName = "label_parachute1Pasif";
            this.label_parachute1Pasif.AutoSize = true;
            this.label_parachute1Pasif.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_parachute1Pasif.ForeColor = System.Drawing.Color.Crimson;
            this.label_parachute1Pasif.Location = new System.Drawing.Point(512, 191);
            this.label_parachute1Pasif.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_parachute1Pasif.Name = "label_parachute1Pasif";
            this.label_parachute1Pasif.Size = new System.Drawing.Size(46, 18);
            this.label_parachute1Pasif.TabIndex = 10;
            this.label_parachute1Pasif.Text = "Pasif";
            this.label_parachute1Pasif.Click += new System.EventHandler(this.label_parachute1Pasif_Click);
            // 
            // label_parachute1Active
            // 
            this.label_parachute1Active.AccessibleDescription = "label_parachute1Active";
            this.label_parachute1Active.AccessibleName = "label_parachute1Active";
            this.label_parachute1Active.AutoSize = true;
            this.label_parachute1Active.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_parachute1Active.ForeColor = System.Drawing.Color.SpringGreen;
            this.label_parachute1Active.Location = new System.Drawing.Point(510, 191);
            this.label_parachute1Active.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_parachute1Active.Name = "label_parachute1Active";
            this.label_parachute1Active.Size = new System.Drawing.Size(53, 18);
            this.label_parachute1Active.TabIndex = 11;
            this.label_parachute1Active.Text = "Active";
            this.label_parachute1Active.Click += new System.EventHandler(this.label_parachute1Active_Click);
            // 
            // ApogeeDef
            // 
            this.ApogeeDef.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApogeeDef.Location = new System.Drawing.Point(470, 224);
            this.ApogeeDef.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ApogeeDef.Name = "ApogeeDef";
            this.ApogeeDef.Size = new System.Drawing.Size(129, 62);
            this.ApogeeDef.TabIndex = 12;
            this.ApogeeDef.Text = "apogee";
            this.ApogeeDef.UseVisualStyleBackColor = true;
            this.ApogeeDef.Click += new System.EventHandler(this.ApogeeDef_Click);
            // 
            // AnaParasutDef
            // 
            this.AnaParasutDef.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnaParasutDef.Location = new System.Drawing.Point(734, 225);
            this.AnaParasutDef.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.AnaParasutDef.Name = "AnaParasutDef";
            this.AnaParasutDef.Size = new System.Drawing.Size(151, 62);
            this.AnaParasutDef.TabIndex = 13;
            this.AnaParasutDef.Text = "Ana parasut\r\nyere 400-600m kala\r\n";
            this.AnaParasutDef.UseVisualStyleBackColor = true;
            this.AnaParasutDef.Click += new System.EventHandler(this.AnaParasutDef_Click);
            // 
            // label_parachute2Pasif
            // 
            this.label_parachute2Pasif.AccessibleDescription = "label_parachute2Pasif";
            this.label_parachute2Pasif.AccessibleName = "label_parachute2Pasif";
            this.label_parachute2Pasif.AutoSize = true;
            this.label_parachute2Pasif.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_parachute2Pasif.ForeColor = System.Drawing.Color.Crimson;
            this.label_parachute2Pasif.Location = new System.Drawing.Point(785, 194);
            this.label_parachute2Pasif.Name = "label_parachute2Pasif";
            this.label_parachute2Pasif.Size = new System.Drawing.Size(46, 18);
            this.label_parachute2Pasif.TabIndex = 15;
            this.label_parachute2Pasif.Text = "Pasif";
            this.label_parachute2Pasif.Click += new System.EventHandler(this.label_parachute2Pasif_Click);
            // 
            // label_parachute2Active
            // 
            this.label_parachute2Active.AccessibleDescription = "label_parachute2Active";
            this.label_parachute2Active.AccessibleName = "label_parachute2Active";
            this.label_parachute2Active.AutoSize = true;
            this.label_parachute2Active.ForeColor = System.Drawing.Color.SpringGreen;
            this.label_parachute2Active.Location = new System.Drawing.Point(782, 195);
            this.label_parachute2Active.Name = "label_parachute2Active";
            this.label_parachute2Active.Size = new System.Drawing.Size(53, 18);
            this.label_parachute2Active.TabIndex = 17;
            this.label_parachute2Active.Text = "Active";
            this.label_parachute2Active.Click += new System.EventHandler(this.label_parachute2Active_Click);
            // 
            // gMap
            // 
            this.gMap.Bearing = 0F;
            this.gMap.CanDragMap = true;
            this.gMap.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMap.GrayScaleMode = false;
            this.gMap.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMap.LevelsKeepInMemmory = 5;
            this.gMap.Location = new System.Drawing.Point(997, 20);
            this.gMap.MarkersEnabled = true;
            this.gMap.MaxZoom = 2;
            this.gMap.MinZoom = 2;
            this.gMap.MouseWheelZoomEnabled = true;
            this.gMap.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMap.Name = "gMap";
            this.gMap.NegativeMode = false;
            this.gMap.PolygonsEnabled = true;
            this.gMap.RetryLoadTile = 0;
            this.gMap.RoutesEnabled = true;
            this.gMap.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMap.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMap.ShowTileGridLines = false;
            this.gMap.Size = new System.Drawing.Size(486, 239);
            this.gMap.TabIndex = 19;
            this.gMap.Zoom = 0D;
            this.gMap.Load += new System.EventHandler(this.gMap_Load);
            // 
            // groupBoxReceiver
            // 
            this.groupBoxReceiver.AccessibleDescription = "groupBoxReceiver";
            this.groupBoxReceiver.AccessibleName = "groupBoxReceiver";
            this.groupBoxReceiver.BackColor = System.Drawing.Color.Black;
            this.groupBoxReceiver.Controls.Add(this.btnConnect);
            this.groupBoxReceiver.Controls.Add(this.rdoPort3Status);
            this.groupBoxReceiver.Controls.Add(this.rdoPort2Status);
            this.groupBoxReceiver.Controls.Add(this.rdoPort1Status);
            this.groupBoxReceiver.Controls.Add(this.rdoPort3);
            this.groupBoxReceiver.Controls.Add(this.rdoPort2);
            this.groupBoxReceiver.Controls.Add(this.rdoPort1);
            this.groupBoxReceiver.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxReceiver.ForeColor = System.Drawing.Color.White;
            this.groupBoxReceiver.Location = new System.Drawing.Point(415, 332);
            this.groupBoxReceiver.Name = "groupBoxReceiver";
            this.groupBoxReceiver.Size = new System.Drawing.Size(243, 234);
            this.groupBoxReceiver.TabIndex = 20;
            this.groupBoxReceiver.TabStop = false;
            this.groupBoxReceiver.Text = "Receiver";
            // 
            // btnConnect
            // 
            this.btnConnect.ForeColor = System.Drawing.Color.Black;
            this.btnConnect.Location = new System.Drawing.Point(36, 177);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(169, 36);
            this.btnConnect.TabIndex = 6;
            this.btnConnect.Text = "Bağlan";
            this.btnConnect.UseVisualStyleBackColor = true;
            // 
            // rdoPort3Status
            // 
            this.rdoPort3Status.AutoSize = true;
            this.rdoPort3Status.BackColor = System.Drawing.Color.Black;
            this.rdoPort3Status.ForeColor = System.Drawing.Color.Red;
            this.rdoPort3Status.Location = new System.Drawing.Point(122, 138);
            this.rdoPort3Status.Name = "rdoPort3Status";
            this.rdoPort3Status.Size = new System.Drawing.Size(106, 19);
            this.rdoPort3Status.TabIndex = 5;
            this.rdoPort3Status.Text = "Bağlantı Yok";
            this.rdoPort3Status.Click += new System.EventHandler(this.rdoPort3Status_Click);
            // 
            // rdoPort2Status
            // 
            this.rdoPort2Status.AutoSize = true;
            this.rdoPort2Status.BackColor = System.Drawing.Color.Black;
            this.rdoPort2Status.ForeColor = System.Drawing.Color.Red;
            this.rdoPort2Status.Location = new System.Drawing.Point(122, 97);
            this.rdoPort2Status.Name = "rdoPort2Status";
            this.rdoPort2Status.Size = new System.Drawing.Size(106, 19);
            this.rdoPort2Status.TabIndex = 4;
            this.rdoPort2Status.Text = "Bağlantı Yok";
            // 
            // rdoPort1Status
            // 
            this.rdoPort1Status.AutoSize = true;
            this.rdoPort1Status.BackColor = System.Drawing.Color.Black;
            this.rdoPort1Status.ForeColor = System.Drawing.Color.Red;
            this.rdoPort1Status.Location = new System.Drawing.Point(122, 54);
            this.rdoPort1Status.Name = "rdoPort1Status";
            this.rdoPort1Status.Size = new System.Drawing.Size(106, 19);
            this.rdoPort1Status.TabIndex = 3;
            this.rdoPort1Status.Text = "Bağlantı Yok";
            // 
            // rdoPort3
            // 
            this.rdoPort3.AutoSize = true;
            this.rdoPort3.ForeColor = System.Drawing.Color.White;
            this.rdoPort3.Location = new System.Drawing.Point(6, 135);
            this.rdoPort3.Name = "rdoPort3";
            this.rdoPort3.Size = new System.Drawing.Size(73, 23);
            this.rdoPort3.TabIndex = 2;
            this.rdoPort3.TabStop = true;
            this.rdoPort3.Text = "Port3";
            this.rdoPort3.UseVisualStyleBackColor = true;
            // 
            // rdoPort2
            // 
            this.rdoPort2.AutoSize = true;
            this.rdoPort2.ForeColor = System.Drawing.Color.White;
            this.rdoPort2.Location = new System.Drawing.Point(6, 97);
            this.rdoPort2.Name = "rdoPort2";
            this.rdoPort2.Size = new System.Drawing.Size(73, 23);
            this.rdoPort2.TabIndex = 1;
            this.rdoPort2.TabStop = true;
            this.rdoPort2.Text = "Port2";
            this.rdoPort2.UseVisualStyleBackColor = true;
            // 
            // rdoPort1
            // 
            this.rdoPort1.AutoSize = true;
            this.rdoPort1.ForeColor = System.Drawing.Color.White;
            this.rdoPort1.Location = new System.Drawing.Point(6, 50);
            this.rdoPort1.Name = "rdoPort1";
            this.rdoPort1.Size = new System.Drawing.Size(73, 23);
            this.rdoPort1.TabIndex = 0;
            this.rdoPort1.TabStop = true;
            this.rdoPort1.Text = "Port1";
            this.rdoPort1.UseVisualStyleBackColor = true;
            // 
            // groupBoxTransmitter
            // 
            this.groupBoxTransmitter.AccessibleDescription = "groupBoxTransmitter";
            this.groupBoxTransmitter.AccessibleName = "groupBoxTransmitter";
            this.groupBoxTransmitter.Controls.Add(this.btnAutoSend);
            this.groupBoxTransmitter.Controls.Add(this.btnSend);
            this.groupBoxTransmitter.Controls.Add(this.label4);
            this.groupBoxTransmitter.Controls.Add(this.rdoPort4);
            this.groupBoxTransmitter.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxTransmitter.ForeColor = System.Drawing.Color.White;
            this.groupBoxTransmitter.Location = new System.Drawing.Point(700, 332);
            this.groupBoxTransmitter.Name = "groupBoxTransmitter";
            this.groupBoxTransmitter.Size = new System.Drawing.Size(237, 234);
            this.groupBoxTransmitter.TabIndex = 21;
            this.groupBoxTransmitter.TabStop = false;
            this.groupBoxTransmitter.Text = "Transmitter";
            // 
            // btnAutoSend
            // 
            this.btnAutoSend.ForeColor = System.Drawing.Color.Black;
            this.btnAutoSend.Location = new System.Drawing.Point(33, 153);
            this.btnAutoSend.Name = "btnAutoSend";
            this.btnAutoSend.Size = new System.Drawing.Size(169, 60);
            this.btnAutoSend.TabIndex = 3;
            this.btnAutoSend.Text = "Otomatik Veri Gönder";
            this.btnAutoSend.UseVisualStyleBackColor = true;
            // 
            // btnSend
            // 
            this.btnSend.ForeColor = System.Drawing.Color.Black;
            this.btnSend.Location = new System.Drawing.Point(33, 97);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(169, 36);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "Veri Gönder";
            this.btnSend.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(122, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 19);
            this.label4.TabIndex = 1;
            this.label4.Text = "Bağlantı Yok";
            // 
            // rdoPort4
            // 
            this.rdoPort4.AutoSize = true;
            this.rdoPort4.Location = new System.Drawing.Point(6, 50);
            this.rdoPort4.Name = "rdoPort4";
            this.rdoPort4.Size = new System.Drawing.Size(73, 23);
            this.rdoPort4.TabIndex = 0;
            this.rdoPort4.TabStop = true;
            this.rdoPort4.Text = "Port4";
            this.rdoPort4.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(1023, 288);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 19);
            this.label1.TabIndex = 22;
            this.label1.Text = "Gyro X :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(1024, 332);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 19);
            this.label2.TabIndex = 23;
            this.label2.Text = "Gyro Y :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(1025, 373);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 19);
            this.label3.TabIndex = 24;
            this.label3.Text = "Gyro Z :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(1293, 288);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 19);
            this.label5.TabIndex = 25;
            this.label5.Text = "Acc X :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(1294, 331);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 19);
            this.label6.TabIndex = 26;
            this.label6.Text = "Acc Y :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(1295, 373);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 19);
            this.label7.TabIndex = 27;
            this.label7.Text = "Acc Z :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(1120, 290);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 18);
            this.label8.TabIndex = 28;
            this.label8.Text = "label8";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(1120, 331);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 18);
            this.label9.TabIndex = 29;
            this.label9.Text = "label9";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(1120, 373);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 18);
            this.label10.TabIndex = 30;
            this.label10.Text = "label10";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Transparent;
            this.label11.Location = new System.Drawing.Point(1395, 289);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 18);
            this.label11.TabIndex = 31;
            this.label11.Text = "label11";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Transparent;
            this.label12.Location = new System.Drawing.Point(1395, 331);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 18);
            this.label12.TabIndex = 32;
            this.label12.Text = "label12";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.Transparent;
            this.label13.Location = new System.Drawing.Point(1395, 374);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(61, 18);
            this.label13.TabIndex = 33;
            this.label13.Text = "label13";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1564, 636);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBoxTransmitter);
            this.Controls.Add(this.groupBoxReceiver);
            this.Controls.Add(this.gMap);
            this.Controls.Add(this.label_parachute2Pasif);
            this.Controls.Add(this.label_parachute2Active);
            this.Controls.Add(this.AnaParasutDef);
            this.Controls.Add(this.ApogeeDef);
            this.Controls.Add(this.label_parachute1Pasif);
            this.Controls.Add(this.secondParachuteLabel);
            this.Controls.Add(this.secondParachutePicture);
            this.Controls.Add(this.firstParachuteLabel);
            this.Controls.Add(this.firstParachutePicture);
            this.Controls.Add(this.payload);
            this.Controls.Add(this.testStation);
            this.Controls.Add(this.groundStation);
            this.Controls.Add(this.qoute);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.label_parachute1Active);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Acc";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstParachutePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondParachutePicture)).EndInit();
            this.groupBoxReceiver.ResumeLayout(false);
            this.groupBoxReceiver.PerformLayout();
            this.groupBoxTransmitter.ResumeLayout(false);
            this.groupBoxTransmitter.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

       

        #endregion
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.TextBox qoute;
        private System.Windows.Forms.Button groundStation;
        private System.Windows.Forms.Button payload;
        private System.Windows.Forms.PictureBox firstParachutePicture;
        private System.Windows.Forms.Label firstParachuteLabel;
        private System.Windows.Forms.PictureBox secondParachutePicture;
        private System.Windows.Forms.Label secondParachuteLabel;
        private System.Windows.Forms.Label label_parachute1Pasif;
        private System.Windows.Forms.Label label_parachute1Active;
        private System.Windows.Forms.Button ApogeeDef;
        private System.Windows.Forms.Button AnaParasutDef;
        private System.Windows.Forms.Button testStation;
        private System.Windows.Forms.Label label_parachute2Pasif;
        private System.Windows.Forms.Label label_parachute2Active;
        private GMap.NET.WindowsForms.GMapControl gMap;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.GroupBox groupBoxReceiver;
        private System.Windows.Forms.Label rdoPort2Status;
        private System.Windows.Forms.Label rdoPort1Status;
        private System.Windows.Forms.RadioButton rdoPort3;
        private System.Windows.Forms.RadioButton rdoPort2;
        private System.Windows.Forms.RadioButton rdoPort1;
        private System.Windows.Forms.GroupBox groupBoxTransmitter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rdoPort4;
        private System.Windows.Forms.Label rdoPort3Status;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnAutoSend;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
    }
}

