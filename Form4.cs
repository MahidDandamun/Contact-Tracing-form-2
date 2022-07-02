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
    public partial class FrmQrScanner : Form
    {
        public FrmInfo originalform;
        public FrmQrScanner()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmInfo frmInfo = new FrmInfo();
            frmInfo.ShowDialog();
        }  
    }
}
