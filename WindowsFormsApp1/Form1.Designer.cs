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
            this.label_parachute2Pasif = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.apogee = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstParachutePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondParachutePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.SystemColors.WindowText;
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(12, 12);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(185, 141);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 1;
            this.logo.TabStop = false;
            this.logo.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // qoute
            // 
            this.qoute.BackColor = System.Drawing.SystemColors.MenuText;
            this.qoute.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.qoute.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qoute.ForeColor = System.Drawing.Color.White;
            this.qoute.Location = new System.Drawing.Point(-7, 159);
            this.qoute.Multiline = true;
            this.qoute.Name = "qoute";
            this.qoute.Size = new System.Drawing.Size(218, 79);
            this.qoute.TabIndex = 2;
            this.qoute.Text = "Through precision and courage, \r\nwe reach beyond the skies.";
            this.qoute.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.qoute.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // groundStation
            // 
            this.groundStation.Location = new System.Drawing.Point(12, 244);
            this.groundStation.Name = "groundStation";
            this.groundStation.Size = new System.Drawing.Size(90, 30);
            this.groundStation.TabIndex = 3;
            this.groundStation.Text = "Ground Station ";
            this.groundStation.UseVisualStyleBackColor = true;
            this.groundStation.Click += new System.EventHandler(this.button1_Click);
            // 
            // testStation
            // 
            this.testStation.Location = new System.Drawing.Point(108, 244);
            this.testStation.Name = "testStation";
            this.testStation.Size = new System.Drawing.Size(90, 30);
            this.testStation.TabIndex = 4;
            this.testStation.Text = "Test Station";
            this.testStation.UseVisualStyleBackColor = true;
            this.testStation.Click += new System.EventHandler(this.button2_Click);
            // 
            // payload
            // 
            this.payload.Location = new System.Drawing.Point(61, 293);
            this.payload.Name = "payload";
            this.payload.Size = new System.Drawing.Size(90, 30);
            this.payload.TabIndex = 5;
            this.payload.Text = "Payload";
            this.payload.UseVisualStyleBackColor = true;
            this.payload.Click += new System.EventHandler(this.button3_Click);
            // 
            // firstParachutePicture
            // 
            this.firstParachutePicture.Image = ((System.Drawing.Image)(resources.GetObject("firstParachutePicture.Image")));
            this.firstParachutePicture.Location = new System.Drawing.Point(618, 37);
            this.firstParachutePicture.Name = "firstParachutePicture";
            this.firstParachutePicture.Size = new System.Drawing.Size(69, 79);
            this.firstParachutePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.firstParachutePicture.TabIndex = 6;
            this.firstParachutePicture.TabStop = false;
            this.firstParachutePicture.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // firstParachuteLabel
            // 
            this.firstParachuteLabel.AutoSize = true;
            this.firstParachuteLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.firstParachuteLabel.Location = new System.Drawing.Point(615, 21);
            this.firstParachuteLabel.Name = "firstParachuteLabel";
            this.firstParachuteLabel.Size = new System.Drawing.Size(73, 13);
            this.firstParachuteLabel.TabIndex = 7;
            this.firstParachuteLabel.Text = "1st Parachute\r\n";
            this.firstParachuteLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // secondParachutePicture
            // 
            this.secondParachutePicture.Image = ((System.Drawing.Image)(resources.GetObject("secondParachutePicture.Image")));
            this.secondParachutePicture.Location = new System.Drawing.Point(707, 38);
            this.secondParachutePicture.Name = "secondParachutePicture";
            this.secondParachutePicture.Size = new System.Drawing.Size(70, 78);
            this.secondParachutePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.secondParachutePicture.TabIndex = 8;
            this.secondParachutePicture.TabStop = false;
            // 
            // secondParachuteLabel
            // 
            this.secondParachuteLabel.AutoSize = true;
            this.secondParachuteLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.secondParachuteLabel.Location = new System.Drawing.Point(704, 21);
            this.secondParachuteLabel.Name = "secondParachuteLabel";
            this.secondParachuteLabel.Size = new System.Drawing.Size(77, 13);
            this.secondParachuteLabel.TabIndex = 9;
            this.secondParachuteLabel.Text = "2nd Parachute";
            // 
            // label_parachute2Pasif
            // 
            this.label_parachute2Pasif.AutoSize = true;
            this.label_parachute2Pasif.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_parachute2Pasif.ForeColor = System.Drawing.Color.Crimson;
            this.label_parachute2Pasif.Location = new System.Drawing.Point(629, 119);
            this.label_parachute2Pasif.Name = "label_parachute2Pasif";
            this.label_parachute2Pasif.Size = new System.Drawing.Size(46, 18);
            this.label_parachute2Pasif.TabIndex = 10;
            this.label_parachute2Pasif.Text = "Pasif";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 9F);
            this.label3.ForeColor = System.Drawing.Color.SpringGreen;
            this.label3.Location = new System.Drawing.Point(716, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 18);
            this.label3.TabIndex = 11;
            this.label3.Text = "Active";
            // 
            // apogee
            // 
            this.apogee.Location = new System.Drawing.Point(617, 140);
            this.apogee.Name = "apogee";
            this.apogee.Size = new System.Drawing.Size(70, 47);
            this.apogee.TabIndex = 12;
            this.apogee.Text = "apogee";
            this.apogee.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(700, 140);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(88, 47);
            this.button5.TabIndex = 13;
            this.button5.Text = "Ana parasut\r\nyere 400-600m kala\r\n";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.apogee);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label_parachute2Pasif);
            this.Controls.Add(this.secondParachuteLabel);
            this.Controls.Add(this.secondParachutePicture);
            this.Controls.Add(this.firstParachuteLabel);
            this.Controls.Add(this.firstParachutePicture);
            this.Controls.Add(this.payload);
            this.Controls.Add(this.testStation);
            this.Controls.Add(this.groundStation);
            this.Controls.Add(this.qoute);
            this.Controls.Add(this.logo);
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstParachutePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondParachutePicture)).EndInit();
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
        private System.Windows.Forms.Label label_parachute2Pasif;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button apogee;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button testStation;
    }
}

