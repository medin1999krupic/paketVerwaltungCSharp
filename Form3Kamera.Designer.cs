namespace Paket_Verwaltung
{
    partial class Form3Kamera
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
            this.btnZurück = new System.Windows.Forms.Button();
            this.pictureBox1Kamera = new System.Windows.Forms.PictureBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblKamera = new System.Windows.Forms.Label();
            this.cBKamera = new System.Windows.Forms.ComboBox();
            this.btnFoto = new System.Windows.Forms.Button();
            this.pictureBox2Kamera = new System.Windows.Forms.PictureBox();
            this.btnFotoSpeichern = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1Kamera)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2Kamera)).BeginInit();
            this.SuspendLayout();
            // 
            // btnZurück
            // 
            this.btnZurück.Location = new System.Drawing.Point(29, 49);
            this.btnZurück.Name = "btnZurück";
            this.btnZurück.Size = new System.Drawing.Size(85, 42);
            this.btnZurück.TabIndex = 0;
            this.btnZurück.Text = "Zurück";
            this.btnZurück.UseVisualStyleBackColor = true;
            this.btnZurück.Click += new System.EventHandler(this.btnZurück_Click);
            // 
            // pictureBox1Kamera
            // 
            this.pictureBox1Kamera.Location = new System.Drawing.Point(245, 123);
            this.pictureBox1Kamera.Name = "pictureBox1Kamera";
            this.pictureBox1Kamera.Size = new System.Drawing.Size(601, 501);
            this.pictureBox1Kamera.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1Kamera.TabIndex = 1;
            this.pictureBox1Kamera.TabStop = false;
            this.pictureBox1Kamera.Click += new System.EventHandler(this.pictureBox1Kamera_Click);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Bisque;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(903, 123);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(111, 51);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblKamera
            // 
            this.lblKamera.AutoSize = true;
            this.lblKamera.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKamera.Location = new System.Drawing.Point(267, 38);
            this.lblKamera.Name = "lblKamera";
            this.lblKamera.Size = new System.Drawing.Size(60, 18);
            this.lblKamera.TabIndex = 3;
            this.lblKamera.Text = "Kamera";
            // 
            // cBKamera
            // 
            this.cBKamera.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBKamera.FormattingEnabled = true;
            this.cBKamera.Location = new System.Drawing.Point(347, 30);
            this.cBKamera.Name = "cBKamera";
            this.cBKamera.Size = new System.Drawing.Size(432, 26);
            this.cBKamera.TabIndex = 4;
            // 
            // btnFoto
            // 
            this.btnFoto.Location = new System.Drawing.Point(516, 581);
            this.btnFoto.Name = "btnFoto";
            this.btnFoto.Size = new System.Drawing.Size(55, 43);
            this.btnFoto.TabIndex = 5;
            this.btnFoto.Text = "Foto";
            this.btnFoto.UseVisualStyleBackColor = true;
            this.btnFoto.Click += new System.EventHandler(this.btnFoto_Click);
            // 
            // pictureBox2Kamera
            // 
            this.pictureBox2Kamera.Location = new System.Drawing.Point(852, 312);
            this.pictureBox2Kamera.Name = "pictureBox2Kamera";
            this.pictureBox2Kamera.Size = new System.Drawing.Size(279, 268);
            this.pictureBox2Kamera.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2Kamera.TabIndex = 6;
            this.pictureBox2Kamera.TabStop = false;
            // 
            // btnFotoSpeichern
            // 
            this.btnFotoSpeichern.Location = new System.Drawing.Point(852, 586);
            this.btnFotoSpeichern.Name = "btnFotoSpeichern";
            this.btnFotoSpeichern.Size = new System.Drawing.Size(279, 38);
            this.btnFotoSpeichern.TabIndex = 7;
            this.btnFotoSpeichern.Text = "Speichern";
            this.btnFotoSpeichern.UseVisualStyleBackColor = true;
            this.btnFotoSpeichern.Click += new System.EventHandler(this.btnFotoSpeichern_Click);
            // 
            // Form3Kamera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1230, 692);
            this.Controls.Add(this.btnFotoSpeichern);
            this.Controls.Add(this.pictureBox2Kamera);
            this.Controls.Add(this.btnFoto);
            this.Controls.Add(this.cBKamera);
            this.Controls.Add(this.lblKamera);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.pictureBox1Kamera);
            this.Controls.Add(this.btnZurück);
            this.Name = "Form3Kamera";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3Kamera";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form3Kamera_FormClosing);
            this.Load += new System.EventHandler(this.Form3Kamera_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1Kamera)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2Kamera)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnZurück;
        private System.Windows.Forms.PictureBox pictureBox1Kamera;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblKamera;
        private System.Windows.Forms.ComboBox cBKamera;
        private System.Windows.Forms.Button btnFoto;
        private System.Windows.Forms.PictureBox pictureBox2Kamera;
        private System.Windows.Forms.Button btnFotoSpeichern;
    }
}