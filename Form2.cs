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


namespace MyContactTracingApp
{
    public partial class FrmSummary : Form
    {
        public FrmInfo originalform;
        List<DateOnly> dates = new List<DateOnly>();
        List<ListViewItem> items = new List<ListViewItem>();
        List<string> datasummary = new List<string>();
        public FrmSummary()
        {
            InitializeComponent();
        }

        private void FrmSummary_Load(object sender, EventArgs e)
        {

        }

        private void FrmSummary_Shown(object sender, EventArgs e)
        {
            dates.Clear();
            datasummary.Clear();
            items.Clear();
            StreamReader file = new StreamReader(@"E:\Downloads\Contact persons.txt");

            while (file.EndOfStream == false)
            {             
                string Details = "";
                String FullName = file.ReadLine();
                DateTime Date;
                if (!DateTime.TryParse(file.ReadLine(), out Date))
                {
                    return;
                }
                string line = file.ReadLine();
                while (line != "")
                {
                    Details += line + "\n";
                    line = file.ReadLine();
                }
                datasummary.Add(Details);
                dates.Add(DateOnly.FromDateTime(Date));
                ListViewItem item = new ListViewItem(new String[] { FullName, Date.ToString() });
                item.Tag = items.Count;
                items.Add(item);
            }
            lvDatas.Items.Clear();
            lvDatas.Items.AddRange(items.ToArray());
        }

        private void lvDatas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvDatas.SelectedItems.Count > 0)
            {
                ListViewItem item = lvDatas.SelectedItems[0];
                int index = (int)item.Tag;
                lblDetails.Text = datasummary[index];
                
            }
                

        }
    }
}
