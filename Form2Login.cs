using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Paket_Verwaltung
{
    public partial class Form2Login : Form
    {
        public Form2Login()
        {
            InitializeComponent();
        }

        private void btnAnmelden_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection(@"Data Source=NBSB-0018\SQLEXPRESS;Initial Catalog=PaketVerwaltung; User ID=sa; Password=manusDB");
            string query = "Select * from PBenutzer where Benutzername = '" + tBBenutzerBenutzername.Text.Trim() + "' and Passwort = '" + tBBenutzerPasswort.Text.Trim() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            if(dtbl.Rows.Count == 1)
            {
                Form1 objForm1 = new Form1();
                this.Hide();
                objForm1.Show();
            }
            else
            {
                MessageBox.Show("Überprüfe deinen Benutzernamen und Passwort.");
            }
            
        }
    }
}
