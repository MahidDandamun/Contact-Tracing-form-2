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
            this.btnSortlist = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
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
            // 
            // btnSortlist
            // 
            this.btnSortlist.Location = new System.Drawing.Point(132, 445);
            this.btnSortlist.Name = "btnSortlist";
            this.btnSortlist.Size = new System.Drawing.Size(100, 26);
            this.btnSortlist.TabIndex = 1;
            this.btnSortlist.Text = "Sort List";
            this.btnSortlist.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(132, 404);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(110, 23);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Date";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Full Name";
            this.columnHeader2.Width = 100;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(106)))), ((int)(((byte)(78)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(679, 95);
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
            // FrmSummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(243)))), ((int)(((byte)(233)))));
            this.ClientSize = new System.Drawing.Size(675, 522);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnSortlist);
            this.Controls.Add(this.lvDatas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmSummary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmSummary_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ListView lvDatas;
        private Button btnSortlist;
        private DateTimePicker dateTimePicker1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
    }
}