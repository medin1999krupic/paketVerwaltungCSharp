using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms.VisualStyles;
using System.Drawing.Imaging;
using AForge.Video;
using AForge.Video.DirectShow;

namespace Paket_Verwaltung
{
    public partial class Form1 : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=NBSB-0018\\SQLEXPRESS;Initial Catalog=PaketVerwaltung; User ID=sa; Password=manusDB");
        SqlCommand command;
        string imgLoc = "";

        public Form1()
        {
            InitializeComponent();

            lblPflichtfeldTextTyp.Visible = false;
            lblPflichtfeldTextEmpfaenger.Visible = false;
            lblPflichtfeldTextZustellung.Visible = false;
            lblPflichtfeldTextAktuellerStatus.Visible = false;
            lblPflichtfeldTextBild.Visible = false;

            checkBoxAlle.Visible = true;
            checkBoxHeute.Visible = false;
            checkBoxWoche.Visible = false;
            checkBoxArchiv.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = NehmePaketListe();

        }

        private BindingSource NehmePaketListe()
        {
            DataTable dtPakete = new DataTable();
            BindingSource paketeSource = new BindingSource();

            string connString = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;

            using (SqlConnection con = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT PaketInformationen.Id, PaketInformationen.Typ, PaketInformationen.Lieferdienst, PaketInformationen.Empfaenger, PaketInformationen.Zugestellt_An, PaketInformationen.Gewicht, PaketInformationen.Datum, PaketInformationen.Bild, PaketInformationen.Trackingnummer, PaketInformationen.Aktueller_Status, PaketInformationen.Notiz, PaketInformationen.Archiv, PBenutzer.Benutzername FROM PaketInformationen inner Join PBenutzer on PaketInformationen.Empfaenger = PBenutzer.Vorname", con))
                {
                    con.Open();

                    SqlDataReader reader = cmd.ExecuteReader();

                    dtPakete.Load(reader);
                }
            }
            paketeSource.DataSource = dtPakete;
                return paketeSource;
        }

        private void btnSucheBild_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.Filter = "JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif|PNG Files (*.png)|*.png|SVG Files (*.svg)|*.svg|TXT Files (*.txt)|*.txt|All Filles (*.*)|*.*";
                //dlg.Filter = "Image files(*.jpg) | *.jpg; *.png";
                dlg.Title = "Pakel_Verwaltung";
                if(dlg.ShowDialog() == DialogResult.OK)
                {
                    imgLoc = dlg.FileName.ToString();
                    pBBildVorschau.ImageLocation = imgLoc;
                    lblImageNametxt.Text = Path.GetFileName(imgLoc);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSpeichern_Click(object sender, EventArgs e)
        {
            if(cBTyp.Text == "" || tBEmpfaenger.Text == "" || tBZustellung.Text == "" || cBAktuellerStatus.Text == "" || pBBildVorschau.Image == null)
            {

                MessageBox.Show("Positionen mit * und ein Bild sind erforderlich um Fortzufahren", "Informationsmangel");
                
            }
            else
            {

                try
                {
                    byte[] img = null;
                    FileStream fs = new FileStream(imgLoc, FileMode.Open, FileAccess.Read);
                    BinaryReader br = new BinaryReader(fs);
                    img = br.ReadBytes((int)fs.Length);
                    string sql = "INSERT INTO PaketInformationen(Typ, Lieferdienst, Empfaenger, Zugestellt_An, Gewicht, Bild, Trackingnummer, Aktueller_Status, Notiz)VALUES('" + cBTyp.Text + "','" + cBLieferdienst.Text + "','" + tBEmpfaenger.Text + "','" + tBZustellung.Text + "','" + tBGewicht.Text + "',@img,'" + tBTrackingNummer.Text + "','" + cBAktuellerStatus.Text + "','" + tBNotiz.Text + "')";
                    if (conn.State != ConnectionState.Open)
                        conn.Open();
                    command = new SqlCommand(sql, conn);
                    command.Parameters.Add(new SqlParameter("@img", img));
                    int x = command.ExecuteNonQuery();
                    
                    MessageBox.Show(x.ToString() + " records(s) saved.");

                }
                catch (Exception ex)
                {
                    
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    conn.Close();
                }

            }


        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dataGridView1.CurrentRow.Selected = true;
                cBTyp.Text = dataGridView1.Rows[e.RowIndex].Cells["Typ"].FormattedValue.ToString();
                cBLieferdienst.Text = dataGridView1.Rows[e.RowIndex].Cells["Lieferdienst"].FormattedValue.ToString();
                tBEmpfaenger.Text = dataGridView1.Rows[e.RowIndex].Cells["Empfaenger"].FormattedValue.ToString();
                tBZustellung.Text = dataGridView1.Rows[e.RowIndex].Cells["Zugestellt_An"].FormattedValue.ToString();
                tBGewicht.Text = dataGridView1.Rows[e.RowIndex].Cells["Gewicht"].FormattedValue.ToString();
                tBTrackingNummer.Text = dataGridView1.Rows[e.RowIndex].Cells["Trackingnummer"].FormattedValue.ToString();
                cBAktuellerStatus.Text = dataGridView1.Rows[e.RowIndex].Cells["Aktueller_Status"].FormattedValue.ToString();
                lblDatumZeit.Text = dataGridView1.Rows[e.RowIndex].Cells["Datum"].FormattedValue.ToString();
                tBNotiz.Text = dataGridView1.Rows[e.RowIndex].Cells["Notiz"].FormattedValue.ToString();
                //pBBildVorschau.Text = dataGridView1.Rows[e.RowIndex].Cells["Bild"].FormattedValue.ToString();

                //pBBildVorschau.Image = Image.FromFile(imgLoc);

                //byte[] imgData = (byte[])dataGridView1.CurrentRow.Cells[1].Value;
                //MemoryStream ms = new MemoryStream(imgData);
                //pBBildVorschau.Image = Image.FromStream(ms);

                var imageData = dataGridView1.CurrentRow.Cells["Bild"].Value as byte[];
                Bitmap bmp;
                using (var ms = new MemoryStream(imageData))
                {
                    bmp = new Bitmap(ms);
                }
                pBBildVorschau.Image =bmp ;


                //MemoryStream ms = new MemoryStream();
                //Bitmap img = (Bitmap)dataGridView1.CurrentRow.Cells["Bild"].Value;
                //img.Save(ms, ImageFormat.Jpeg);
                //pBBildVorschau.Image = Image.FromStream(ms);




            }
        }

        private void lblSternTyp_MouseHover(object sender, EventArgs e)
        {
            lblPflichtfeldTextTyp.Visible = true;
        }

        private void lblSternTyp_MouseLeave(object sender, EventArgs e)
        {
            lblPflichtfeldTextTyp.Visible = false;
        }

        private void lblSternEmpfaenger_MouseHover(object sender, EventArgs e)
        {
            lblPflichtfeldTextEmpfaenger.Visible = true;
        }

        private void lblSternEmpfaenger_MouseLeave(object sender, EventArgs e)
        {
            lblPflichtfeldTextEmpfaenger.Visible = false;
        }

        private void lblSternZustellungAn_MouseHover(object sender, EventArgs e)
        {
            lblPflichtfeldTextZustellung.Visible = true;
        }

        private void lblSternZustellungAn_MouseLeave(object sender, EventArgs e)
        {
            lblPflichtfeldTextZustellung.Visible = false;
        }

        private void lblSternAktuellerStatus_MouseHover(object sender, EventArgs e)
        {
            lblPflichtfeldTextAktuellerStatus.Visible = true;
        }

        private void lblSternAktuellerStatus_MouseLeave(object sender, EventArgs e)
        {
            lblPflichtfeldTextAktuellerStatus.Visible = false;
        }

        private void lblSternBild_MouseHover(object sender, EventArgs e)
        {
            lblPflichtfeldTextBild.Visible = true;
        }

        private void lblSternBild_MouseLeave(object sender, EventArgs e)
        {
            lblPflichtfeldTextBild.Visible = false;
        }

        private void btnFelderLeeren_Click(object sender, EventArgs e)
        {
            cBTyp.Text = "";
            cBLieferdienst.Text = "";
            tBEmpfaenger.Clear();
            tBZustellung.Clear();
            tBGewicht.Clear();
            tBTrackingNummer.Clear();
            cBAktuellerStatus.Text = "";
            lblDatumZeit.Text = "";
            tBNotiz.Clear();
            pBBildVorschau.Image = null;
            lblImageNametxt.Text = "";
        }

        private void btnTabelleAktualisieren_Click(object sender, EventArgs e)
        {
            string sqlstm = "SELECT PaketInformationen.Id, PaketInformationen.Typ, PaketInformationen.Lieferdienst, PaketInformationen.Empfaenger, PaketInformationen.Zugestellt_An, PaketInformationen.Gewicht, PaketInformationen.Datum, PaketInformationen.Bild, PaketInformationen.Trackingnummer, PaketInformationen.Aktueller_Status, PaketInformationen.Notiz, PaketInformationen.Archiv, PBenutzer.Benutzername FROM PaketInformationen inner Join PBenutzer on PaketInformationen.Empfaenger = PBenutzer.Vorname";
            SqlDataAdapter SDA = new SqlDataAdapter(sqlstm, conn);
            DataSet DS = new System.Data.DataSet();
            SDA.Fill(DS, "PaketInformationen");
            dataGridView1.DataSource = DS.Tables[0];
        }

        private void buttonKamera_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3Kamera form3Kamera = new Form3Kamera();
            form3Kamera.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        bool archivZustand = false;

        private void btnArchivieren_Click_1(object sender, EventArgs e)
        {
            DataRowView currentRow = dataGridView1.CurrentRow.DataBoundItem as DataRowView;

            if (archivZustand == false)
            {
                currentRow.Row["Archiv"] = true;
                archivZustand = true;
            }
            else {
                currentRow.Row["Archiv"] = false;
                archivZustand = false;
            }






            //conn.Open();
            //SqlCommand command = conn.CreateCommand();
            //command.CommandType = CommandType.Text;
            //command.CommandText = "UPDATE PaketInformationen set Archiv = 0";
            //command.ExecuteNonQuery();
            //conn.Close();
            //NehmePaketListe();
            //MessageBox.Show("record updated successfully");

        }

        

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            
        }


        bool checkBoxAlle_Checked = true;
        bool checkBoxHeute_Checked = false;
        bool checkBoxWoche_Checked = false;
        bool checkBoxArchiv_Checked = false;

        private void pictureBoxFilter_Click(object sender, EventArgs e)
        {
            checkBoxAlle.Visible = true;
            checkBoxHeute.Visible = true;
            checkBoxWoche.Visible = true;
            checkBoxArchiv.Visible = true;

            checkBoxAlle.Location = new Point(888, 555);
            checkBoxHeute.Location = new Point(888, 575);
            checkBoxWoche.Location = new Point(888, 595);
            checkBoxArchiv.Location = new Point(888, 615);
        }



        private void checkBoxAlle_CheckedChanged(object sender, EventArgs e)
        {
            
            if(checkBoxAlle_Checked == false) {
            
                string sqlstm = "SELECT PaketInformationen.Id, PaketInformationen.Typ, PaketInformationen.Lieferdienst, PaketInformationen.Empfaenger, PaketInformationen.Zugestellt_An, PaketInformationen.Gewicht, PaketInformationen.Datum, PaketInformationen.Bild, PaketInformationen.Trackingnummer, PaketInformationen.Aktueller_Status, PaketInformationen.Notiz, PaketInformationen.Archiv, PBenutzer.Benutzername FROM PaketInformationen inner Join PBenutzer on PaketInformationen.Empfaenger = PBenutzer.Vorname";
                SqlDataAdapter SDA = new SqlDataAdapter(sqlstm, conn);
                DataSet DS = new System.Data.DataSet();
                SDA.Fill(DS, "PaketInformationen");
                dataGridView1.DataSource = DS.Tables[0];

                checkBoxAlle_Checked = true;
                checkBoxHeute_Checked = false;
                checkBoxWoche_Checked = false;
                checkBoxArchiv_Checked = false;

            }
        }

        private void checkBoxHeute_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBoxHeute_Checked == false) {

                string sqlstm = "SELECT PaketInformationen.Id, PaketInformationen.Typ, PaketInformationen.Lieferdienst, PaketInformationen.Empfaenger, PaketInformationen.Zugestellt_An, PaketInformationen.Gewicht, PaketInformationen.Datum, PaketInformationen.Bild, PaketInformationen.Trackingnummer, PaketInformationen.Aktueller_Status, PaketInformationen.Notiz, PaketInformationen.Archiv, PBenutzer.Benutzername FROM PaketInformationen inner Join PBenutzer on PaketInformationen.Empfaenger = PBenutzer.Vorname where PaketInformationen.Datum = getdate()";
                SqlDataAdapter SDA = new SqlDataAdapter(sqlstm, conn);
                DataSet DS = new System.Data.DataSet();
                SDA.Fill(DS, "PaketInformationen");
                dataGridView1.DataSource = DS.Tables[0];

                checkBoxAlle_Checked = false;
                checkBoxHeute_Checked = true;
                checkBoxWoche_Checked = false;
                checkBoxArchiv_Checked = false;

            }
        }

        private void checkBoxWoche_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBoxWoche_Checked == false) {

                string sqlstm = "SELECT PaketInformationen.Id, PaketInformationen.Typ, PaketInformationen.Lieferdienst, PaketInformationen.Empfaenger, PaketInformationen.Zugestellt_An, PaketInformationen.Gewicht, PaketInformationen.Datum, PaketInformationen.Bild, PaketInformationen.Trackingnummer, PaketInformationen.Aktueller_Status, PaketInformationen.Notiz, PaketInformationen.Archiv, PBenutzer.Benutzername FROM PaketInformationen inner Join PBenutzer on PaketInformationen.Empfaenger = PBenutzer.Vorname where PaketInformationen.Datum between DATEADD(dd, -7, getdate()) and getdate()";
                SqlDataAdapter SDA = new SqlDataAdapter(sqlstm, conn);
                DataSet DS = new System.Data.DataSet();
                SDA.Fill(DS, "PaketInformationen");
                dataGridView1.DataSource = DS.Tables[0];

                checkBoxAlle_Checked = false;
                checkBoxHeute_Checked = false;
                checkBoxWoche_Checked = true;
                checkBoxArchiv_Checked = false;
            }
        }

        private void checkBoxArchiv_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBoxArchiv_Checked == false) {

                string sqlstm = "SELECT PaketInformationen.Id, PaketInformationen.Typ, PaketInformationen.Lieferdienst, PaketInformationen.Empfaenger, PaketInformationen.Zugestellt_An, PaketInformationen.Gewicht, PaketInformationen.Datum, PaketInformationen.Bild, PaketInformationen.Trackingnummer, PaketInformationen.Aktueller_Status, PaketInformationen.Notiz, PaketInformationen.Archiv, PBenutzer.Benutzername FROM PaketInformationen inner Join PBenutzer on PaketInformationen.Empfaenger = PBenutzer.Vorname where PaketInformationen.Archiv = 1";
                SqlDataAdapter SDA = new SqlDataAdapter(sqlstm, conn);
                DataSet DS = new System.Data.DataSet();
                SDA.Fill(DS, "PaketInformationen");
                dataGridView1.DataSource = DS.Tables[0];

                checkBoxAlle_Checked = false;
                checkBoxHeute_Checked = false;
                checkBoxWoche_Checked = false;
                checkBoxArchiv_Checked = true;
            }
        }

    }
    
}
