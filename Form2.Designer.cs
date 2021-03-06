namespace MyContactTracingApp
{
    partial class FrmSummary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSummary));
            this.lvDatas = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.btnSortlist = new System.Windows.Forms.Button();
            this.dtpDateSearcher = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDetails = new System.Windows.Forms.Label();
            this.pnl2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lvDatas
            // 
            this.lvDatas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvDatas.GridLines = true;
            this.lvDatas.Location = new System.Drawing.Point(28, 114);
            this.lvDatas.Name = "lvDatas";
            this.lvDatas.Size = new System.Drawing.Size(317, 273);
            this.lvDatas.TabIndex = 0;
            this.lvDatas.UseCompatibleStateImageBehavior = false;
            this.lvDatas.View = System.Windows.Forms.View.Details;
            this.lvDatas.SelectedIndexChanged += new System.EventHandler(this.lvDatas_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Full Name";
            this.columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Date";
            this.columnHeader2.Width = 120;
            // 
            // btnSortlist
            // 
            this.btnSortlist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(106)))), ((int)(((byte)(78)))));
            this.btnSortlist.FlatAppearance.BorderSize = 0;
            this.btnSortlist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSortlist.ForeColor = System.Drawing.Color.White;
            this.btnSortlist.Location = new System.Drawing.Point(245, 417);
            this.btnSortlist.Name = "btnSortlist";
            this.btnSortlist.Size = new System.Drawing.Size(100, 26);
            this.btnSortlist.TabIndex = 1;
            this.btnSortlist.Text = "Sort List";
            this.btnSortlist.UseVisualStyleBackColor = false;
            this.btnSortlist.Click += new System.EventHandler(this.btnSortlist_Click);
            // 
            // dtpDateSearcher
            // 
            this.dtpDateSearcher.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateSearcher.Location = new System.Drawing.Point(94, 420);
            this.dtpDateSearcher.Name = "dtpDateSearcher";
            this.dtpDateSearcher.Size = new System.Drawing.Size(110, 23);
            this.dtpDateSearcher.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(106)))), ((int)(((byte)(78)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(785, 95);
            this.panel1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(28, 21);
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
            this.label1.Location = new System.Drawing.Point(140, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(344, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "CONTACT TRACING FORM";
            // 
            // lblDetails
            // 
            this.lblDetails.AutoSize = true;
            this.lblDetails.Location = new System.Drawing.Point(353, 121);
            this.lblDetails.Name = "lblDetails";
            this.lblDetails.Size = new System.Drawing.Size(0, 15);
            this.lblDetails.TabIndex = 4;
            // 
            // pnl2
            // 
            this.pnl2.Location = new System.Drawing.Point(352, 115);
            this.pnl2.Name = "pnl2";
            this.pnl2.Size = new System.Drawing.Size(419, 272);
            this.pnl2.TabIndex = 6;
            // 
            // FrmSummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(243)))), ((int)(((byte)(233)))));
            this.ClientSize = new System.Drawing.Size(783, 466);
            this.Controls.Add(this.lblDetails);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dtpDateSearcher);
            this.Controls.Add(this.btnSortlist);
            this.Controls.Add(this.lvDatas);
            this.Controls.Add(this.pnl2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmSummary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmSummary_Load);
            this.Shown += new System.EventHandler(this.FrmSummary_Shown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListView lvDatas;
        private Button btnSortlist;
        private DateTimePicker dtpDateSearcher;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Label lblDetails;
        private Panel pnl2;
    }
}