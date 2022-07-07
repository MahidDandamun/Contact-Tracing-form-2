namespace MyContactTracingApp
{
    partial class FrmQrScanner
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmQrScanner));
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.lblCTF = new System.Windows.Forms.Label();
            this.pbScanner = new System.Windows.Forms.PictureBox();
            this.btnScan = new System.Windows.Forms.Button();
            this.lblDirections = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.cbxDevices = new System.Windows.Forms.ComboBox();
            this.lblCamera = new System.Windows.Forms.Label();
            this.tmr1 = new System.Windows.Forms.Timer(this.components);
            this.lb1 = new System.Windows.Forms.ListBox();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbScanner)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(106)))), ((int)(((byte)(78)))));
            this.pnlHeader.Controls.Add(this.pbLogo);
            this.pnlHeader.Controls.Add(this.lblCTF);
            this.pnlHeader.Location = new System.Drawing.Point(-1, -3);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(775, 90);
            this.pnlHeader.TabIndex = 2;
            // 
            // pbLogo
            // 
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.Location = new System.Drawing.Point(11, 15);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(81, 56);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 1;
            this.pbLogo.TabStop = false;
            // 
            // lblCTF
            // 
            this.lblCTF.AutoSize = true;
            this.lblCTF.Font = new System.Drawing.Font("Bahnschrift", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCTF.ForeColor = System.Drawing.Color.White;
            this.lblCTF.Location = new System.Drawing.Point(98, 24);
            this.lblCTF.Name = "lblCTF";
            this.lblCTF.Size = new System.Drawing.Size(344, 35);
            this.lblCTF.TabIndex = 0;
            this.lblCTF.Text = "CONTACT TRACING FORM";
            // 
            // pbScanner
            // 
            this.pbScanner.Location = new System.Drawing.Point(66, 146);
            this.pbScanner.Name = "pbScanner";
            this.pbScanner.Size = new System.Drawing.Size(337, 296);
            this.pbScanner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbScanner.TabIndex = 3;
            this.pbScanner.TabStop = false;
            // 
            // btnScan
            // 
            this.btnScan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(106)))), ((int)(((byte)(78)))));
            this.btnScan.FlatAppearance.BorderSize = 0;
            this.btnScan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnScan.ForeColor = System.Drawing.Color.White;
            this.btnScan.Location = new System.Drawing.Point(164, 481);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(139, 31);
            this.btnScan.TabIndex = 4;
            this.btnScan.Text = "&SCAN";
            this.btnScan.UseVisualStyleBackColor = false;
            this.btnScan.Click += new System.EventHandler(this.btnScan_Click);
            // 
            // lblDirections
            // 
            this.lblDirections.AutoSize = true;
            this.lblDirections.Location = new System.Drawing.Point(132, 445);
            this.lblDirections.Name = "lblDirections";
            this.lblDirections.Size = new System.Drawing.Size(199, 15);
            this.lblDirections.TabIndex = 5;
            this.lblDirections.Text = "Place the QrCode in front of Camera";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(106)))), ((int)(((byte)(78)))));
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(396, 481);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(70, 31);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // cbxDevices
            // 
            this.cbxDevices.BackColor = System.Drawing.Color.White;
            this.cbxDevices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxDevices.FormattingEnabled = true;
            this.cbxDevices.Location = new System.Drawing.Point(132, 117);
            this.cbxDevices.Name = "cbxDevices";
            this.cbxDevices.Size = new System.Drawing.Size(171, 23);
            this.cbxDevices.TabIndex = 7;
            // 
            // lblCamera
            // 
            this.lblCamera.AutoSize = true;
            this.lblCamera.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCamera.Location = new System.Drawing.Point(55, 115);
            this.lblCamera.Name = "lblCamera";
            this.lblCamera.Size = new System.Drawing.Size(71, 21);
            this.lblCamera.TabIndex = 8;
            this.lblCamera.Text = "Camera: ";
            // 
            // tmr1
            // 
            this.tmr1.Interval = 1000;
            //this.tmr1.Tick += new System.EventHandler(this.tmr1_Tick);
            // 
            // lb1
            // 
            this.lb1.FormattingEnabled = true;
            this.lb1.ItemHeight = 15;
            this.lb1.Location = new System.Drawing.Point(434, 146);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(330, 289);
            this.lb1.TabIndex = 9;
            // 
            // FrmQrScanner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(243)))), ((int)(((byte)(233)))));
            this.ClientSize = new System.Drawing.Size(776, 542);
            this.Controls.Add(this.lb1);
            this.Controls.Add(this.lblCamera);
            this.Controls.Add(this.cbxDevices);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblDirections);
            this.Controls.Add(this.btnScan);
            this.Controls.Add(this.pbScanner);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmQrScanner";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmQrScanner_FormClosing);
            this.Load += new System.EventHandler(this.FrmQrScanner_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbScanner)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel pnlHeader;
        private PictureBox pbLogo;
        private Label lblCTF;
        private PictureBox pbScanner;
        private Button btnScan;
        private Label lblDirections;
        private Button btnBack;
        private ComboBox cbxDevices;
        private Label lblCamera;
        private System.Windows.Forms.Timer tmr1;
        private ListBox lb1;
    }
}