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
            this.lvDatas = new System.Windows.Forms.ListView();
            this.btnSortlist = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // lvDatas
            // 
            this.lvDatas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvDatas.GridLines = true;
            this.lvDatas.Location = new System.Drawing.Point(28, 85);
            this.lvDatas.Name = "lvDatas";
            this.lvDatas.Size = new System.Drawing.Size(317, 273);
            this.lvDatas.TabIndex = 0;
            this.lvDatas.UseCompatibleStateImageBehavior = false;
            this.lvDatas.View = System.Windows.Forms.View.Details;
            // 
            // btnSortlist
            // 
            this.btnSortlist.Location = new System.Drawing.Point(132, 417);
            this.btnSortlist.Name = "btnSortlist";
            this.btnSortlist.Size = new System.Drawing.Size(100, 26);
            this.btnSortlist.TabIndex = 1;
            this.btnSortlist.Text = "Sort List";
            this.btnSortlist.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(132, 376);
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
            // FrmSummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(243)))), ((int)(((byte)(233)))));
            this.ClientSize = new System.Drawing.Size(675, 484);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnSortlist);
            this.Controls.Add(this.lvDatas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmSummary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);

        }

        #endregion

        private ListView lvDatas;
        private Button btnSortlist;
        private DateTimePicker dateTimePicker1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
    }
}