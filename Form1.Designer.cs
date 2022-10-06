namespace Paket_Verwaltung
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cBTyp = new System.Windows.Forms.ComboBox();
            this.cBLieferdienst = new System.Windows.Forms.ComboBox();
            this.lblTyp = new System.Windows.Forms.Label();
            this.lblLieferdienst = new System.Windows.Forms.Label();
            this.lblEmpfaenger = new System.Windows.Forms.Label();
            this.lblZustellung = new System.Windows.Forms.Label();
            this.lblBildVorschau = new System.Windows.Forms.Label();
            this.lblImageName = new System.Windows.Forms.Label();
            this.lblImageNametxt = new System.Windows.Forms.Label();
            this.tBEmpfaenger = new System.Windows.Forms.TextBox();
            this.tBGewicht = new System.Windows.Forms.TextBox();
            this.lblGewicht = new System.Windows.Forms.Label();
            this.btnSpeichern = new System.Windows.Forms.Button();
            this.btnArchivieren = new System.Windows.Forms.Button();
            this.lblTrackingNummer = new System.Windows.Forms.Label();
            this.tBTrackingNummer = new System.Windows.Forms.TextBox();
            this.lblAktuellerStatus = new System.Windows.Forms.Label();
            this.cBAktuellerStatus = new System.Windows.Forms.ComboBox();
            this.lblNotiz = new System.Windows.Forms.Label();
            this.tBNotiz = new System.Windows.Forms.TextBox();
            this.lblDatumZeit = new System.Windows.Forms.Label();
            this.btnSucheBild = new System.Windows.Forms.Button();
            this.btnFelderLeeren = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tBZustellung = new System.Windows.Forms.TextBox();
            this.lblSternTyp = new System.Windows.Forms.Label();
            this.lblSternEmpfaenger = new System.Windows.Forms.Label();
            this.lblSternZustellungAn = new System.Windows.Forms.Label();
            this.lblSternAktuellerStatus = new System.Windows.Forms.Label();
            this.lblPflichtfeldTextTyp = new System.Windows.Forms.Label();
            this.lblPflichtfeldTextEmpfaenger = new System.Windows.Forms.Label();
            this.lblPflichtfeldTextZustellung = new System.Windows.Forms.Label();
            this.lblPflichtfeldTextAktuellerStatus = new System.Windows.Forms.Label();
            this.lblPflichtfeldTextBild = new System.Windows.Forms.Label();
            this.lblSternBild = new System.Windows.Forms.Label();
            this.btnTabelleAktualisieren = new System.Windows.Forms.Button();
            this.buttonKamera = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.checkBoxAlle = new System.Windows.Forms.CheckBox();
            this.checkBoxHeute = new System.Windows.Forms.CheckBox();
            this.checkBoxWoche = new System.Windows.Forms.CheckBox();
            this.checkBoxArchiv = new System.Windows.Forms.CheckBox();
            this.pictureBoxFilter = new System.Windows.Forms.PictureBox();
            this.pBBildVorschau = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFilter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBBildVorschau)).BeginInit();
            this.SuspendLayout();
            // 
            // cBTyp
            // 
            this.cBTyp.FormattingEnabled = true;
            this.cBTyp.Items.AddRange(new object[] {
            "Paket",
            "Brief"});
            this.cBTyp.Location = new System.Drawing.Point(167, 99);
            this.cBTyp.Name = "cBTyp";
            this.cBTyp.Size = new System.Drawing.Size(121, 21);
            this.cBTyp.TabIndex = 0;
            // 
            // cBLieferdienst
            // 
            this.cBLieferdienst.FormattingEnabled = true;
            this.cBLieferdienst.Items.AddRange(new object[] {
            "UPS",
            "DHL",
            "Amazon",
            "DPD",
            "Hermes",
            "GLS",
            "FedEx",
            "TNT",
            ""});
            this.cBLieferdienst.Location = new System.Drawing.Point(167, 136);
            this.cBLieferdienst.Name = "cBLieferdienst";
            this.cBLieferdienst.Size = new System.Drawing.Size(121, 21);
            this.cBLieferdienst.TabIndex = 1;
            // 
            // lblTyp
            // 
            this.lblTyp.AutoSize = true;
            this.lblTyp.Location = new System.Drawing.Point(61, 107);
            this.lblTyp.Name = "lblTyp";
            this.lblTyp.Size = new System.Drawing.Size(25, 13);
            this.lblTyp.TabIndex = 5;
            this.lblTyp.Text = "Typ";
            // 
            // lblLieferdienst
            // 
            this.lblLieferdienst.AutoSize = true;
            this.lblLieferdienst.Location = new System.Drawing.Point(61, 144);
            this.lblLieferdienst.Name = "lblLieferdienst";
            this.lblLieferdienst.Size = new System.Drawing.Size(61, 13);
            this.lblLieferdienst.TabIndex = 6;
            this.lblLieferdienst.Text = "Lieferdienst";
            // 
            // lblEmpfaenger
            // 
            this.lblEmpfaenger.AutoSize = true;
            this.lblEmpfaenger.Location = new System.Drawing.Point(61, 182);
            this.lblEmpfaenger.Name = "lblEmpfaenger";
            this.lblEmpfaenger.Size = new System.Drawing.Size(64, 13);
            this.lblEmpfaenger.TabIndex = 7;
            this.lblEmpfaenger.Text = "Empfaenger";
            // 
            // lblZustellung
            // 
            this.lblZustellung.AutoSize = true;
            this.lblZustellung.Location = new System.Drawing.Point(61, 221);
            this.lblZustellung.Name = "lblZustellung";
            this.lblZustellung.Size = new System.Drawing.Size(83, 13);
            this.lblZustellung.TabIndex = 8;
            this.lblZustellung.Text = "Zustellung an ...";
            // 
            // lblBildVorschau
            // 
            this.lblBildVorschau.AutoSize = true;
            this.lblBildVorschau.Location = new System.Drawing.Point(935, 82);
            this.lblBildVorschau.Name = "lblBildVorschau";
            this.lblBildVorschau.Size = new System.Drawing.Size(72, 13);
            this.lblBildVorschau.TabIndex = 9;
            this.lblBildVorschau.Text = "Bild Vorschau";
            // 
            // lblImageName
            // 
            this.lblImageName.AutoSize = true;
            this.lblImageName.Location = new System.Drawing.Point(939, 432);
            this.lblImageName.Name = "lblImageName";
            this.lblImageName.Size = new System.Drawing.Size(68, 13);
            this.lblImageName.TabIndex = 10;
            this.lblImageName.Text = "Image name:";
            // 
            // lblImageNametxt
            // 
            this.lblImageNametxt.AutoSize = true;
            this.lblImageNametxt.Location = new System.Drawing.Point(1022, 432);
            this.lblImageNametxt.Name = "lblImageNametxt";
            this.lblImageNametxt.Size = new System.Drawing.Size(0, 13);
            this.lblImageNametxt.TabIndex = 11;
            // 
            // tBEmpfaenger
            // 
            this.tBEmpfaenger.Location = new System.Drawing.Point(167, 175);
            this.tBEmpfaenger.Name = "tBEmpfaenger";
            this.tBEmpfaenger.Size = new System.Drawing.Size(121, 20);
            this.tBEmpfaenger.TabIndex = 12;
            // 
            // tBGewicht
            // 
            this.tBGewicht.Location = new System.Drawing.Point(167, 253);
            this.tBGewicht.Name = "tBGewicht";
            this.tBGewicht.Size = new System.Drawing.Size(121, 20);
            this.tBGewicht.TabIndex = 13;
            // 
            // lblGewicht
            // 
            this.lblGewicht.AutoSize = true;
            this.lblGewicht.Location = new System.Drawing.Point(61, 260);
            this.lblGewicht.Name = "lblGewicht";
            this.lblGewicht.Size = new System.Drawing.Size(61, 13);
            this.lblGewicht.TabIndex = 14;
            this.lblGewicht.Text = "Gewicht (g)";
            // 
            // btnSpeichern
            // 
            this.btnSpeichern.BackColor = System.Drawing.Color.SeaGreen;
            this.btnSpeichern.ForeColor = System.Drawing.Color.White;
            this.btnSpeichern.Location = new System.Drawing.Point(815, 350);
            this.btnSpeichern.Name = "btnSpeichern";
            this.btnSpeichern.Size = new System.Drawing.Size(117, 66);
            this.btnSpeichern.TabIndex = 15;
            this.btnSpeichern.Text = "Speichern";
            this.btnSpeichern.UseVisualStyleBackColor = false;
            this.btnSpeichern.Click += new System.EventHandler(this.btnSpeichern_Click);
            // 
            // btnArchivieren
            // 
            this.btnArchivieren.BackColor = System.Drawing.Color.Salmon;
            this.btnArchivieren.Location = new System.Drawing.Point(856, 99);
            this.btnArchivieren.Name = "btnArchivieren";
            this.btnArchivieren.Size = new System.Drawing.Size(76, 33);
            this.btnArchivieren.TabIndex = 16;
            this.btnArchivieren.Text = "Archivieren";
            this.btnArchivieren.UseVisualStyleBackColor = false;
            this.btnArchivieren.Click += new System.EventHandler(this.btnArchivieren_Click_1);
            // 
            // lblTrackingNummer
            // 
            this.lblTrackingNummer.AutoSize = true;
            this.lblTrackingNummer.Location = new System.Drawing.Point(61, 298);
            this.lblTrackingNummer.Name = "lblTrackingNummer";
            this.lblTrackingNummer.Size = new System.Drawing.Size(91, 13);
            this.lblTrackingNummer.TabIndex = 18;
            this.lblTrackingNummer.Text = "Tracking Nummer";
            // 
            // tBTrackingNummer
            // 
            this.tBTrackingNummer.Location = new System.Drawing.Point(167, 291);
            this.tBTrackingNummer.Name = "tBTrackingNummer";
            this.tBTrackingNummer.Size = new System.Drawing.Size(121, 20);
            this.tBTrackingNummer.TabIndex = 19;
            // 
            // lblAktuellerStatus
            // 
            this.lblAktuellerStatus.AutoSize = true;
            this.lblAktuellerStatus.Location = new System.Drawing.Point(61, 341);
            this.lblAktuellerStatus.Name = "lblAktuellerStatus";
            this.lblAktuellerStatus.Size = new System.Drawing.Size(81, 13);
            this.lblAktuellerStatus.TabIndex = 20;
            this.lblAktuellerStatus.Text = "Aktueller Status";
            // 
            // cBAktuellerStatus
            // 
            this.cBAktuellerStatus.FormattingEnabled = true;
            this.cBAktuellerStatus.Items.AddRange(new object[] {
            "Paket erhalten!",
            "Paket nicht erhalten!"});
            this.cBAktuellerStatus.Location = new System.Drawing.Point(167, 333);
            this.cBAktuellerStatus.Name = "cBAktuellerStatus";
            this.cBAktuellerStatus.Size = new System.Drawing.Size(121, 21);
            this.cBAktuellerStatus.TabIndex = 21;
            // 
            // lblNotiz
            // 
            this.lblNotiz.AutoSize = true;
            this.lblNotiz.Location = new System.Drawing.Point(61, 423);
            this.lblNotiz.Name = "lblNotiz";
            this.lblNotiz.Size = new System.Drawing.Size(31, 13);
            this.lblNotiz.TabIndex = 22;
            this.lblNotiz.Text = "Notiz";
            // 
            // tBNotiz
            // 
            this.tBNotiz.Location = new System.Drawing.Point(167, 420);
            this.tBNotiz.Multiline = true;
            this.tBNotiz.Name = "tBNotiz";
            this.tBNotiz.Size = new System.Drawing.Size(465, 153);
            this.tBNotiz.TabIndex = 23;
            // 
            // lblDatumZeit
            // 
            this.lblDatumZeit.AutoSize = true;
            this.lblDatumZeit.Location = new System.Drawing.Point(537, 404);
            this.lblDatumZeit.Name = "lblDatumZeit";
            this.lblDatumZeit.Size = new System.Drawing.Size(0, 13);
            this.lblDatumZeit.TabIndex = 26;
            // 
            // btnSucheBild
            // 
            this.btnSucheBild.Location = new System.Drawing.Point(834, 423);
            this.btnSucheBild.Name = "btnSucheBild";
            this.btnSucheBild.Size = new System.Drawing.Size(98, 31);
            this.btnSucheBild.TabIndex = 28;
            this.btnSucheBild.Text = "Suche Bild";
            this.btnSucheBild.UseVisualStyleBackColor = true;
            this.btnSucheBild.Click += new System.EventHandler(this.btnSucheBild_Click);
            // 
            // btnFelderLeeren
            // 
            this.btnFelderLeeren.BackColor = System.Drawing.Color.Khaki;
            this.btnFelderLeeren.Location = new System.Drawing.Point(834, 138);
            this.btnFelderLeeren.Name = "btnFelderLeeren";
            this.btnFelderLeeren.Size = new System.Drawing.Size(98, 33);
            this.btnFelderLeeren.TabIndex = 29;
            this.btnFelderLeeren.Text = "Felder leeren";
            this.btnFelderLeeren.UseVisualStyleBackColor = false;
            this.btnFelderLeeren.Click += new System.EventHandler(this.btnFelderLeeren_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(64, 638);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1134, 328);
            this.dataGridView1.TabIndex = 30;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            // 
            // tBZustellung
            // 
            this.tBZustellung.Location = new System.Drawing.Point(167, 214);
            this.tBZustellung.Name = "tBZustellung";
            this.tBZustellung.Size = new System.Drawing.Size(121, 20);
            this.tBZustellung.TabIndex = 31;
            // 
            // lblSternTyp
            // 
            this.lblSternTyp.AutoSize = true;
            this.lblSternTyp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F);
            this.lblSternTyp.Location = new System.Drawing.Point(294, 99);
            this.lblSternTyp.Name = "lblSternTyp";
            this.lblSternTyp.Size = new System.Drawing.Size(15, 20);
            this.lblSternTyp.TabIndex = 32;
            this.lblSternTyp.Text = "*";
            this.lblSternTyp.MouseLeave += new System.EventHandler(this.lblSternTyp_MouseLeave);
            this.lblSternTyp.MouseHover += new System.EventHandler(this.lblSternTyp_MouseHover);
            // 
            // lblSternEmpfaenger
            // 
            this.lblSternEmpfaenger.AutoSize = true;
            this.lblSternEmpfaenger.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F);
            this.lblSternEmpfaenger.Location = new System.Drawing.Point(294, 173);
            this.lblSternEmpfaenger.Name = "lblSternEmpfaenger";
            this.lblSternEmpfaenger.Size = new System.Drawing.Size(15, 20);
            this.lblSternEmpfaenger.TabIndex = 33;
            this.lblSternEmpfaenger.Text = "*";
            this.lblSternEmpfaenger.MouseLeave += new System.EventHandler(this.lblSternEmpfaenger_MouseLeave);
            this.lblSternEmpfaenger.MouseHover += new System.EventHandler(this.lblSternEmpfaenger_MouseHover);
            // 
            // lblSternZustellungAn
            // 
            this.lblSternZustellungAn.AutoSize = true;
            this.lblSternZustellungAn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F);
            this.lblSternZustellungAn.Location = new System.Drawing.Point(294, 212);
            this.lblSternZustellungAn.Name = "lblSternZustellungAn";
            this.lblSternZustellungAn.Size = new System.Drawing.Size(15, 20);
            this.lblSternZustellungAn.TabIndex = 34;
            this.lblSternZustellungAn.Text = "*";
            this.lblSternZustellungAn.MouseLeave += new System.EventHandler(this.lblSternZustellungAn_MouseLeave);
            this.lblSternZustellungAn.MouseHover += new System.EventHandler(this.lblSternZustellungAn_MouseHover);
            // 
            // lblSternAktuellerStatus
            // 
            this.lblSternAktuellerStatus.AutoSize = true;
            this.lblSternAktuellerStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F);
            this.lblSternAktuellerStatus.Location = new System.Drawing.Point(294, 333);
            this.lblSternAktuellerStatus.Name = "lblSternAktuellerStatus";
            this.lblSternAktuellerStatus.Size = new System.Drawing.Size(15, 20);
            this.lblSternAktuellerStatus.TabIndex = 35;
            this.lblSternAktuellerStatus.Text = "*";
            this.lblSternAktuellerStatus.MouseLeave += new System.EventHandler(this.lblSternAktuellerStatus_MouseLeave);
            this.lblSternAktuellerStatus.MouseHover += new System.EventHandler(this.lblSternAktuellerStatus_MouseHover);
            // 
            // lblPflichtfeldTextTyp
            // 
            this.lblPflichtfeldTextTyp.AutoSize = true;
            this.lblPflichtfeldTextTyp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPflichtfeldTextTyp.ForeColor = System.Drawing.Color.Red;
            this.lblPflichtfeldTextTyp.Location = new System.Drawing.Point(315, 99);
            this.lblPflichtfeldTextTyp.Name = "lblPflichtfeldTextTyp";
            this.lblPflichtfeldTextTyp.Size = new System.Drawing.Size(65, 16);
            this.lblPflichtfeldTextTyp.TabIndex = 36;
            this.lblPflichtfeldTextTyp.Text = "Pflichtfeld";
            // 
            // lblPflichtfeldTextEmpfaenger
            // 
            this.lblPflichtfeldTextEmpfaenger.AutoSize = true;
            this.lblPflichtfeldTextEmpfaenger.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPflichtfeldTextEmpfaenger.ForeColor = System.Drawing.Color.Red;
            this.lblPflichtfeldTextEmpfaenger.Location = new System.Drawing.Point(315, 173);
            this.lblPflichtfeldTextEmpfaenger.Name = "lblPflichtfeldTextEmpfaenger";
            this.lblPflichtfeldTextEmpfaenger.Size = new System.Drawing.Size(65, 16);
            this.lblPflichtfeldTextEmpfaenger.TabIndex = 37;
            this.lblPflichtfeldTextEmpfaenger.Text = "Pflichtfeld";
            // 
            // lblPflichtfeldTextZustellung
            // 
            this.lblPflichtfeldTextZustellung.AutoSize = true;
            this.lblPflichtfeldTextZustellung.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPflichtfeldTextZustellung.ForeColor = System.Drawing.Color.Red;
            this.lblPflichtfeldTextZustellung.Location = new System.Drawing.Point(315, 215);
            this.lblPflichtfeldTextZustellung.Name = "lblPflichtfeldTextZustellung";
            this.lblPflichtfeldTextZustellung.Size = new System.Drawing.Size(65, 16);
            this.lblPflichtfeldTextZustellung.TabIndex = 38;
            this.lblPflichtfeldTextZustellung.Text = "Pflichtfeld";
            // 
            // lblPflichtfeldTextAktuellerStatus
            // 
            this.lblPflichtfeldTextAktuellerStatus.AutoSize = true;
            this.lblPflichtfeldTextAktuellerStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPflichtfeldTextAktuellerStatus.ForeColor = System.Drawing.Color.Red;
            this.lblPflichtfeldTextAktuellerStatus.Location = new System.Drawing.Point(315, 334);
            this.lblPflichtfeldTextAktuellerStatus.Name = "lblPflichtfeldTextAktuellerStatus";
            this.lblPflichtfeldTextAktuellerStatus.Size = new System.Drawing.Size(65, 16);
            this.lblPflichtfeldTextAktuellerStatus.TabIndex = 39;
            this.lblPflichtfeldTextAktuellerStatus.Text = "Pflichtfeld";
            // 
            // lblPflichtfeldTextBild
            // 
            this.lblPflichtfeldTextBild.AutoSize = true;
            this.lblPflichtfeldTextBild.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPflichtfeldTextBild.ForeColor = System.Drawing.Color.Red;
            this.lblPflichtfeldTextBild.Location = new System.Drawing.Point(744, 429);
            this.lblPflichtfeldTextBild.Name = "lblPflichtfeldTextBild";
            this.lblPflichtfeldTextBild.Size = new System.Drawing.Size(65, 16);
            this.lblPflichtfeldTextBild.TabIndex = 40;
            this.lblPflichtfeldTextBild.Text = "Pflichtfeld";
            // 
            // lblSternBild
            // 
            this.lblSternBild.AutoSize = true;
            this.lblSternBild.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F);
            this.lblSternBild.Location = new System.Drawing.Point(815, 423);
            this.lblSternBild.Name = "lblSternBild";
            this.lblSternBild.Size = new System.Drawing.Size(15, 20);
            this.lblSternBild.TabIndex = 41;
            this.lblSternBild.Text = "*";
            this.lblSternBild.MouseLeave += new System.EventHandler(this.lblSternBild_MouseLeave);
            this.lblSternBild.MouseHover += new System.EventHandler(this.lblSternBild_MouseHover);
            // 
            // btnTabelleAktualisieren
            // 
            this.btnTabelleAktualisieren.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnTabelleAktualisieren.Location = new System.Drawing.Point(1090, 592);
            this.btnTabelleAktualisieren.Name = "btnTabelleAktualisieren";
            this.btnTabelleAktualisieren.Size = new System.Drawing.Size(108, 40);
            this.btnTabelleAktualisieren.TabIndex = 42;
            this.btnTabelleAktualisieren.Text = "Tabelle Aktualisieren";
            this.btnTabelleAktualisieren.UseVisualStyleBackColor = false;
            this.btnTabelleAktualisieren.Click += new System.EventHandler(this.btnTabelleAktualisieren_Click);
            // 
            // buttonKamera
            // 
            this.buttonKamera.Location = new System.Drawing.Point(594, 12);
            this.buttonKamera.Name = "buttonKamera";
            this.buttonKamera.Size = new System.Drawing.Size(113, 42);
            this.buttonKamera.TabIndex = 43;
            this.buttonKamera.Text = "Kamera";
            this.buttonKamera.UseVisualStyleBackColor = true;
            this.buttonKamera.Click += new System.EventHandler(this.buttonKamera_Click);
            // 
            // checkBoxAlle
            // 
            this.checkBoxAlle.AutoSize = true;
            this.checkBoxAlle.Location = new System.Drawing.Point(888, 615);
            this.checkBoxAlle.Name = "checkBoxAlle";
            this.checkBoxAlle.Size = new System.Drawing.Size(42, 17);
            this.checkBoxAlle.TabIndex = 47;
            this.checkBoxAlle.Text = "alle";
            this.checkBoxAlle.UseVisualStyleBackColor = true;
            this.checkBoxAlle.CheckedChanged += new System.EventHandler(this.checkBoxAlle_CheckedChanged);
            // 
            // checkBoxHeute
            // 
            this.checkBoxHeute.AutoSize = true;
            this.checkBoxHeute.Location = new System.Drawing.Point(888, 533);
            this.checkBoxHeute.Name = "checkBoxHeute";
            this.checkBoxHeute.Size = new System.Drawing.Size(53, 17);
            this.checkBoxHeute.TabIndex = 48;
            this.checkBoxHeute.Text = "heute";
            this.checkBoxHeute.UseVisualStyleBackColor = true;
            this.checkBoxHeute.CheckedChanged += new System.EventHandler(this.checkBoxHeute_CheckedChanged);
            // 
            // checkBoxWoche
            // 
            this.checkBoxWoche.AutoSize = true;
            this.checkBoxWoche.Location = new System.Drawing.Point(888, 556);
            this.checkBoxWoche.Name = "checkBoxWoche";
            this.checkBoxWoche.Size = new System.Drawing.Size(90, 17);
            this.checkBoxWoche.TabIndex = 49;
            this.checkBoxWoche.Text = "letzten 7 tage";
            this.checkBoxWoche.UseVisualStyleBackColor = true;
            this.checkBoxWoche.CheckedChanged += new System.EventHandler(this.checkBoxWoche_CheckedChanged);
            // 
            // checkBoxArchiv
            // 
            this.checkBoxArchiv.AutoSize = true;
            this.checkBoxArchiv.Location = new System.Drawing.Point(888, 592);
            this.checkBoxArchiv.Name = "checkBoxArchiv";
            this.checkBoxArchiv.Size = new System.Drawing.Size(56, 17);
            this.checkBoxArchiv.TabIndex = 50;
            this.checkBoxArchiv.Text = "Archiv";
            this.checkBoxArchiv.UseVisualStyleBackColor = true;
            this.checkBoxArchiv.CheckedChanged += new System.EventHandler(this.checkBoxArchiv_CheckedChanged);
            // 
            // pictureBoxFilter
            // 
            this.pictureBoxFilter.BackColor = System.Drawing.Color.SkyBlue;
            this.pictureBoxFilter.Image = global::Paket_Verwaltung.Properties.Resources._18860108731537184102_512;
            this.pictureBoxFilter.Location = new System.Drawing.Point(1015, 592);
            this.pictureBoxFilter.Name = "pictureBoxFilter";
            this.pictureBoxFilter.Size = new System.Drawing.Size(44, 40);
            this.pictureBoxFilter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFilter.TabIndex = 46;
            this.pictureBoxFilter.TabStop = false;
            this.pictureBoxFilter.Click += new System.EventHandler(this.pictureBoxFilter_Click);
            // 
            // pBBildVorschau
            // 
            this.pBBildVorschau.Location = new System.Drawing.Point(938, 99);
            this.pBBildVorschau.Name = "pBBildVorschau";
            this.pBBildVorschau.Size = new System.Drawing.Size(260, 317);
            this.pBBildVorschau.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBBildVorschau.TabIndex = 4;
            this.pBBildVorschau.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1295, 991);
            this.Controls.Add(this.checkBoxArchiv);
            this.Controls.Add(this.checkBoxWoche);
            this.Controls.Add(this.checkBoxHeute);
            this.Controls.Add(this.checkBoxAlle);
            this.Controls.Add(this.pictureBoxFilter);
            this.Controls.Add(this.buttonKamera);
            this.Controls.Add(this.btnTabelleAktualisieren);
            this.Controls.Add(this.lblSternBild);
            this.Controls.Add(this.lblPflichtfeldTextBild);
            this.Controls.Add(this.lblPflichtfeldTextAktuellerStatus);
            this.Controls.Add(this.lblPflichtfeldTextZustellung);
            this.Controls.Add(this.lblPflichtfeldTextEmpfaenger);
            this.Controls.Add(this.lblPflichtfeldTextTyp);
            this.Controls.Add(this.lblSternAktuellerStatus);
            this.Controls.Add(this.lblSternZustellungAn);
            this.Controls.Add(this.lblSternEmpfaenger);
            this.Controls.Add(this.lblSternTyp);
            this.Controls.Add(this.tBZustellung);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnFelderLeeren);
            this.Controls.Add(this.btnSucheBild);
            this.Controls.Add(this.lblDatumZeit);
            this.Controls.Add(this.tBNotiz);
            this.Controls.Add(this.lblNotiz);
            this.Controls.Add(this.cBAktuellerStatus);
            this.Controls.Add(this.lblAktuellerStatus);
            this.Controls.Add(this.tBTrackingNummer);
            this.Controls.Add(this.lblTrackingNummer);
            this.Controls.Add(this.btnArchivieren);
            this.Controls.Add(this.btnSpeichern);
            this.Controls.Add(this.lblGewicht);
            this.Controls.Add(this.tBGewicht);
            this.Controls.Add(this.tBEmpfaenger);
            this.Controls.Add(this.lblImageNametxt);
            this.Controls.Add(this.lblImageName);
            this.Controls.Add(this.lblBildVorschau);
            this.Controls.Add(this.lblZustellung);
            this.Controls.Add(this.lblEmpfaenger);
            this.Controls.Add(this.lblLieferdienst);
            this.Controls.Add(this.lblTyp);
            this.Controls.Add(this.pBBildVorschau);
            this.Controls.Add(this.cBLieferdienst);
            this.Controls.Add(this.cBTyp);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFilter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBBildVorschau)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cBTyp;
        private System.Windows.Forms.ComboBox cBLieferdienst;
        private System.Windows.Forms.PictureBox pBBildVorschau;
        private System.Windows.Forms.Label lblTyp;
        private System.Windows.Forms.Label lblLieferdienst;
        private System.Windows.Forms.Label lblEmpfaenger;
        private System.Windows.Forms.Label lblZustellung;
        private System.Windows.Forms.Label lblBildVorschau;
        private System.Windows.Forms.Label lblImageName;
        private System.Windows.Forms.Label lblImageNametxt;
        private System.Windows.Forms.TextBox tBEmpfaenger;
        private System.Windows.Forms.TextBox tBGewicht;
        private System.Windows.Forms.Label lblGewicht;
        private System.Windows.Forms.Button btnSpeichern;
        private System.Windows.Forms.Button btnArchivieren;
        private System.Windows.Forms.Label lblTrackingNummer;
        private System.Windows.Forms.TextBox tBTrackingNummer;
        private System.Windows.Forms.Label lblAktuellerStatus;
        private System.Windows.Forms.ComboBox cBAktuellerStatus;
        private System.Windows.Forms.Label lblNotiz;
        private System.Windows.Forms.TextBox tBNotiz;
        private System.Windows.Forms.Label lblDatumZeit;
        private System.Windows.Forms.Button btnSucheBild;
        private System.Windows.Forms.Button btnFelderLeeren;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox tBZustellung;
        private System.Windows.Forms.Label lblSternTyp;
        private System.Windows.Forms.Label lblSternEmpfaenger;
        private System.Windows.Forms.Label lblSternZustellungAn;
        private System.Windows.Forms.Label lblSternAktuellerStatus;
        private System.Windows.Forms.Label lblPflichtfeldTextTyp;
        private System.Windows.Forms.Label lblPflichtfeldTextEmpfaenger;
        private System.Windows.Forms.Label lblPflichtfeldTextZustellung;
        private System.Windows.Forms.Label lblPflichtfeldTextAktuellerStatus;
        private System.Windows.Forms.Label lblPflichtfeldTextBild;
        private System.Windows.Forms.Label lblSternBild;
        private System.Windows.Forms.Button btnTabelleAktualisieren;
        private System.Windows.Forms.Button buttonKamera;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox pictureBoxFilter;
        private System.Windows.Forms.CheckBox checkBoxAlle;
        private System.Windows.Forms.CheckBox checkBoxHeute;
        private System.Windows.Forms.CheckBox checkBoxWoche;
        private System.Windows.Forms.CheckBox checkBoxArchiv;
    }
}

