namespace Paket_Verwaltung
{
    partial class Form2Login
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
            this.btnBenutzerAnmelden = new System.Windows.Forms.Button();
            this.lblBenutzername = new System.Windows.Forms.Label();
            this.lblBenutzerPasswort = new System.Windows.Forms.Label();
            this.tBBenutzerBenutzername = new System.Windows.Forms.TextBox();
            this.tBBenutzerPasswort = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnBenutzerAnmelden
            // 
            this.btnBenutzerAnmelden.Location = new System.Drawing.Point(260, 190);
            this.btnBenutzerAnmelden.Name = "btnBenutzerAnmelden";
            this.btnBenutzerAnmelden.Size = new System.Drawing.Size(117, 41);
            this.btnBenutzerAnmelden.TabIndex = 0;
            this.btnBenutzerAnmelden.Text = "Anmelden";
            this.btnBenutzerAnmelden.UseVisualStyleBackColor = true;
            this.btnBenutzerAnmelden.Click += new System.EventHandler(this.btnAnmelden_Click);
            // 
            // lblBenutzername
            // 
            this.lblBenutzername.AutoSize = true;
            this.lblBenutzername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBenutzername.Location = new System.Drawing.Point(49, 84);
            this.lblBenutzername.Name = "lblBenutzername";
            this.lblBenutzername.Size = new System.Drawing.Size(114, 20);
            this.lblBenutzername.TabIndex = 1;
            this.lblBenutzername.Text = "Benutzername";
            // 
            // lblBenutzerPasswort
            // 
            this.lblBenutzerPasswort.AutoSize = true;
            this.lblBenutzerPasswort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBenutzerPasswort.Location = new System.Drawing.Point(49, 144);
            this.lblBenutzerPasswort.Name = "lblBenutzerPasswort";
            this.lblBenutzerPasswort.Size = new System.Drawing.Size(74, 20);
            this.lblBenutzerPasswort.TabIndex = 2;
            this.lblBenutzerPasswort.Text = "Passwort";
            // 
            // tBBenutzerBenutzername
            // 
            this.tBBenutzerBenutzername.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBBenutzerBenutzername.Location = new System.Drawing.Point(185, 80);
            this.tBBenutzerBenutzername.Name = "tBBenutzerBenutzername";
            this.tBBenutzerBenutzername.Size = new System.Drawing.Size(192, 24);
            this.tBBenutzerBenutzername.TabIndex = 3;
            // 
            // tBBenutzerPasswort
            // 
            this.tBBenutzerPasswort.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBBenutzerPasswort.Location = new System.Drawing.Point(185, 140);
            this.tBBenutzerPasswort.Name = "tBBenutzerPasswort";
            this.tBBenutzerPasswort.Size = new System.Drawing.Size(192, 24);
            this.tBBenutzerPasswort.TabIndex = 4;
            // 
            // Form2Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 264);
            this.Controls.Add(this.tBBenutzerPasswort);
            this.Controls.Add(this.tBBenutzerBenutzername);
            this.Controls.Add(this.lblBenutzerPasswort);
            this.Controls.Add(this.lblBenutzername);
            this.Controls.Add(this.btnBenutzerAnmelden);
            this.Name = "Form2Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBenutzerAnmelden;
        private System.Windows.Forms.Label lblBenutzername;
        private System.Windows.Forms.Label lblBenutzerPasswort;
        private System.Windows.Forms.TextBox tBBenutzerBenutzername;
        private System.Windows.Forms.TextBox tBBenutzerPasswort;
    }
}