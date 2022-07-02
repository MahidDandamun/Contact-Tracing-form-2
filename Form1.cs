namespace MyContactTracingApp
{
    public partial class FrmInfo : Form
    {
       
        public FrmInfo()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if ((txtbxAddress.Text != "") && (txtbxFullname.Text != "") && (txtbxEmail.Text != "") && (cbAge.Text != "") &&
         (txtbxContact.Text != "") && (cbBodyTemp.Text != "") && (txtbxZip.Text != "") &&
         ((rdbtn1.Checked != false) || (rdbtn2.Checked != false)) &&
         ((rdbtn3.Checked != false) || (rdbtn4.Checked != false)) &&
         ((rdbtn5.Checked != false) || (rdbtn6.Checked != false)) &&
         ((rdbtn7.Checked != false) || (rdbtn8.Checked != false)) &&
         ((rdbtn9.Checked != false) || (rdbtn10.Checked != false)) &&
         ((rdbtn11.Checked != false) || (rdbtn12.Checked != false)) &&
         ((rdbtn13.Checked != false) || (rdbtn14.Checked != false)))
            {
                StreamWriter file = new StreamWriter(@"E:\Downloads\Contact persons.txt", true);
                file.WriteLine(txtbxFullname.Text);
                file.WriteLine(dtpDov.Value.ToString("o"));
                file.WriteLine("Fullname: " + txtbxFullname.Text);
                file.WriteLine("Address: " + txtbxAddress.Text);
                file.WriteLine("Time of visit: " + dtpTov.Text);
                file.WriteLine("Email: " + txtbxEmail.Text);
                file.WriteLine("Contact number: " + txtbxContact.Text);
                file.WriteLine("Date of visit: " + dtpDov.Text);
                file.WriteLine("Zip code: " + txtbxZip.Text);
                file.WriteLine("Age: " + cbAge.Text);
                file.WriteLine("Temperature: " + cbBodyTemp.Text);

                if (rdbtn1.Checked)
                {
                    file.WriteLine("Question1: This person have lost his sens of taste and smell");
                }
                else if (rdbtn2.Checked)
                {
                    file.WriteLine("Question1: NO");
                }
                if (rdbtn3.Checked)
                {
                    file.WriteLine("Question2: This person have sore throat");
                }
                else if (rdbtn4.Checked)
                {
                    file.WriteLine("Question2: NO");
                }
                if (rdbtn5.Checked)
                {
                    file.WriteLine("Question3: This person have fever");
                }
                else if (rdbtn6.Checked)
                {
                    file.WriteLine("Question3: NO");
                }
                if (rdbtn7.Checked)
                {
                    file.WriteLine("Question4: This person is experiencing difficulty in breathing");
                }
                else if (rdbtn8.Checked)
                {
                    file.WriteLine("Question4: NO");
                }
                if (rdbtn9.Checked)
                {
                    file.WriteLine("Question5: This person have been exposed to covid patient");
                }
                else if (rdbtn10.Checked)
                {
                    file.WriteLine("Question5: NO");
                }
                if (rdbtn11.Checked)
                {
                    file.WriteLine("Question6: This person have travelled outside the country ");
                }
                else if (rdbtn12.Checked)
                {
                    file.WriteLine("Question6: NO");
                }
                if (rdbtn13.Checked)
                {
                    file.WriteLine("Question7: This person have already received two doses of Covid-19 Vaccine");
                }
                else if (rdbtn14.Checked)
                {
                    file.WriteLine("Question7: This person is not fully Vaccinated");
                }
                file.WriteLine();
                file.Close();
                MessageBox.Show("Your response has been recorded");
         

                FrmSummary frmSummary = new FrmSummary();
                frmSummary.originalform = this;
                frmSummary.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Please fill in the fields properly");
        }

        private void btnCreateQrCode_Click(object sender, EventArgs e)
        {
         FrmQrGenerator frmQrGenerator = new FrmQrGenerator();  
            frmQrGenerator.originalform = this; 
            frmQrGenerator.Show();
            this.Hide();
        }
    }
}
