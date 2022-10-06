using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Windows.Forms.VisualStyles;
using System.Drawing.Imaging;
using AForge.Video;
using AForge.Video.DirectShow;

namespace Paket_Verwaltung
{
    public partial class Form3Kamera : Form
    {
        public Form3Kamera()
        {
            InitializeComponent();

        }

        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice videoCaptureDevice;

        private void Form3Kamera_Load(object sender, EventArgs e)
        {
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filterInfo in filterInfoCollection)
                cBKamera.Items.Add(filterInfo.Name);
            cBKamera.SelectedIndex = 0;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[cBKamera.SelectedIndex].MonikerString);
            videoCaptureDevice.NewFrame += VideoCaptureDevice_NewFrame;
            videoCaptureDevice.Start();
        }

        private void VideoCaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pictureBox1Kamera.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void Form3Kamera_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (videoCaptureDevice.IsRunning == true) {
                videoCaptureDevice.SignalToStop();
            }
        }

        private void btnZurück_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }

        private void btnFoto_Click(object sender, EventArgs e)
        {
            pictureBox2Kamera.Image = (Bitmap)pictureBox1Kamera.Image.Clone();
        }

        private void btnFotoSpeichern_Click(object sender, EventArgs e)
        {
            Helper.SaveImageCapture(pictureBox2Kamera.Image);
        }

        private void pictureBox1Kamera_Click(object sender, EventArgs e)
        {

        }
    }
}
