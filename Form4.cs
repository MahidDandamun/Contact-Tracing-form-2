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
using AForge;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;
using ZXing.Aztec;


namespace MyContactTracingApp
{
    public partial class FrmQrScanner : Form
    {
        public FrmInfo originalform;
        public FrmQrScanner()
        {
            InitializeComponent();
        }

        private FilterInfoCollection filterInfoCollection;
        private VideoCaptureDevice captureDevice;
        

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmInfo frmInfo = new FrmInfo();
            frmInfo.ShowDialog();
        }

        private void FrmQrScanner_Load(object sender, EventArgs e)
        {
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach(FilterInfo filter in filterInfoCollection)
                cbxDevices.Items.Add(filter.Name);
            cbxDevices.SelectedIndex = 0;
            captureDevice = new VideoCaptureDevice();
        }

        private void btnScan_Click(object sender, EventArgs e)
        {
           
            captureDevice = new VideoCaptureDevice(filterInfoCollection[cbxDevices.SelectedIndex].MonikerString);
            captureDevice.NewFrame += CaptureDevice_NewFrame;
            captureDevice.Start();
            tmr1.Start();
        }

        private void CaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
          pbScanner.Image=(Bitmap)eventArgs.Frame.Clone();
        }

        private void FrmQrScanner_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (captureDevice.IsRunning)
                captureDevice.Stop();
        }
       
        //private void tmr1_Tick(object sender, EventArgs e)
        //{
           
        //    if (pbScanner.Image!= null)
        //    {

        //        BarcodeReader reader = new BarcodeReader();
        //        Result result = BarcodeReader.decode(pbScanner.Image);
        //        if (result != null)
        //        {
        //            lb1.Text =  result.ToString();
        //            tmr1.Stop();
        //            if (captureDevice.IsRunning)
        //                captureDevice.Stop();
        //        }
        //    }
        //}
    }
}
