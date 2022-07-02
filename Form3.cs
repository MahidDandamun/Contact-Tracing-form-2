using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace MyContactTracingApp
{
    public partial class FrmQrGenerator : Form
    {
        public FrmInfo originalform;
        public FrmQrGenerator()
        {
            InitializeComponent();
        }

        private void FrmQrGenerator_Load(object sender, EventArgs e)
        {
           
        }

        private void btnBackToFrmInfo_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmInfo frmInfo = new FrmInfo();
            frmInfo.ShowDialog();
        }

        private void btnGenerateQr_Click(object sender, EventArgs e)
        {
            if ((txtbxAddress.Text != "") && (txtbxFullName.Text != "") && (txtbxEmail.Text != "") && (cbAge.Text != "") &&
                (txtbxContact.Text != "") && (cbBodyTemp.Text != "") && (txtbxZip.Text != ""))
            {
                string info = ("Fullname:" + txtbxFullName.Text + "\n" + "Address: " + txtbxAddress.Text + "\n" + "Email: " + txtbxEmail.Text + "\n" + "Contact Number: " + txtbxContact.Text + "\n" + "Zip code: " + txtbxZip.Text + "\n" + "Age: " + cbAge.Text + "\n" + "Temperature: " + cbBodyTemp.Text);
                QRCoder.QRCodeGenerator QG = new QRCoder.QRCodeGenerator();
                var Mydata = QG.CreateQrCode(info, QRCoder.QRCodeGenerator.ECCLevel.H);
                var code = new QRCoder.QRCode(Mydata);
                pbxQrcode.Image = code.GetGraphic(50);
            }
            else
                MessageBox.Show("Please Fill in the fields properly");
        }
    }
}
