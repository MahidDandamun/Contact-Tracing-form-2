namespace MyContactTracingApp
{
    partial class FrmQrGenerator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmQrGenerator));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtbxFullName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtbxAddress = new System.Windows.Forms.TextBox();
            this.txtbxContact = new System.Windows.Forms.TextBox();
            this.txtbxZip = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtbxEmail = new System.Windows.Forms.TextBox();
            this.cbAge = new System.Windows.Forms.ComboBox();
            this.cbBodyTemp = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(106)))), ((int)(((byte)(78)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-2, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(526, 95);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(35, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(106, 56);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(147, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(344, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "CONTACT TRACING FORM";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(202, 400);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 29);
            this.button1.TabIndex = 2;
            this.button1.Text = "Generate Qr Code";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txtbxFullName
            // 
            this.txtbxFullName.Location = new System.Drawing.Point(36, 178);
            this.txtbxFullName.Name = "txtbxFullName";
            this.txtbxFullName.Size = new System.Drawing.Size(224, 23);
            this.txtbxFullName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Full Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Complete Address:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 276);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Contact Number:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 325);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Zip Code:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(328, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "Age:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(328, 220);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 15);
            this.label7.TabIndex = 9;
            this.label7.Text = "Body Temperature:";
            // 
            // txtbxAddress
            // 
            this.txtbxAddress.Location = new System.Drawing.Point(35, 234);
            this.txtbxAddress.Name = "txtbxAddress";
            this.txtbxAddress.Size = new System.Drawing.Size(224, 23);
            this.txtbxAddress.TabIndex = 10;
            // 
            // txtbxContact
            // 
            this.txtbxContact.Location = new System.Drawing.Point(35, 289);
            this.txtbxContact.Name = "txtbxContact";
            this.txtbxContact.Size = new System.Drawing.Size(224, 23);
            this.txtbxContact.TabIndex = 11;
            // 
            // txtbxZip
            // 
            this.txtbxZip.Location = new System.Drawing.Point(35, 339);
            this.txtbxZip.Name = "txtbxZip";
            this.txtbxZip.Size = new System.Drawing.Size(122, 23);
            this.txtbxZip.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(328, 276);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 15);
            this.label8.TabIndex = 15;
            this.label8.Text = "Email:";
            // 
            // txtbxEmail
            // 
            this.txtbxEmail.Location = new System.Drawing.Point(328, 289);
            this.txtbxEmail.Name = "txtbxEmail";
            this.txtbxEmail.Size = new System.Drawing.Size(93, 23);
            this.txtbxEmail.TabIndex = 16;
            // 
            // cbAge
            // 
            this.cbAge.FormattingEnabled = true;
            this.cbAge.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            "60",
            "61",
            "62",
            "63",
            "64",
            "65",
            "66",
            "67",
            "68",
            "69",
            "70",
            "71",
            "72",
            "73",
            "74",
            "75",
            "76",
            "77",
            "78",
            "79",
            "80",
            "81",
            "82",
            "83",
            "84",
            "85",
            "86",
            "87",
            "88",
            "89",
            "90",
            "91",
            "92",
            "93",
            "94",
            "95",
            "96",
            "97",
            "98",
            "99",
            "100"});
            this.cbAge.Location = new System.Drawing.Point(331, 179);
            this.cbAge.Name = "cbAge";
            this.cbAge.Size = new System.Drawing.Size(53, 23);
            this.cbAge.TabIndex = 17;
            // 
            // cbBodyTemp
            // 
            this.cbBodyTemp.FormattingEnabled = true;
            this.cbBodyTemp.Items.AddRange(new object[] {
            "35°",
            "35.5°",
            "36°",
            "36.5°",
            "37°",
            "37.5°",
            "38°",
            "38.5°",
            "",
            ""});
            this.cbBodyTemp.Location = new System.Drawing.Point(331, 234);
            this.cbBodyTemp.Name = "cbBodyTemp";
            this.cbBodyTemp.Size = new System.Drawing.Size(53, 23);
            this.cbBodyTemp.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Bahnschrift Condensed", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label9.Location = new System.Drawing.Point(16, 112);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(328, 35);
            this.label9.TabIndex = 19;
            this.label9.Text = "FILL THE PERSONAL INFORMATION";
            // 
            // FrmQrGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(243)))), ((int)(((byte)(233)))));
            this.ClientSize = new System.Drawing.Size(523, 450);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbBodyTemp);
            this.Controls.Add(this.cbAge);
            this.Controls.Add(this.txtbxEmail);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtbxZip);
            this.Controls.Add(this.txtbxContact);
            this.Controls.Add(this.txtbxAddress);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtbxFullName);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmQrGenerator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Button button1;
        private TextBox txtbxFullName;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtbxAddress;
        private TextBox txtbxContact;
        private TextBox txtbxZip;
        private Label label8;
        private TextBox txtbxEmail;
        private ComboBox cbAge;
        private ComboBox cbBodyTemp;
        private Label label9;
    }
}