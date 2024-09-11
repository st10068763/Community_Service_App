namespace PROG_3B_POE
{
    partial class ReportIssueForm
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
            this.Report = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textLocation = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnSubmitReport = new System.Windows.Forms.Button();
            this.CategoryListBx = new System.Windows.Forms.ListBox();
            this.btnAddFile = new System.Windows.Forms.Button();
            this.AttachedPictureBox = new System.Windows.Forms.PictureBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.ReportDataGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.AttachedPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReportDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // Report
            // 
            this.Report.AutoSize = true;
            this.Report.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Report.ForeColor = System.Drawing.Color.White;
            this.Report.Location = new System.Drawing.Point(271, 56);
            this.Report.Name = "Report";
            this.Report.Size = new System.Drawing.Size(662, 48);
            this.Report.TabIndex = 0;
            this.Report.Text = "Municipal Issue Report Application";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(239, 375);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Location";
            // 
            // textLocation
            // 
            this.textLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textLocation.Location = new System.Drawing.Point(243, 403);
            this.textLocation.Multiline = true;
            this.textLocation.Name = "textLocation";
            this.textLocation.Size = new System.Drawing.Size(228, 36);
            this.textLocation.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(501, 372);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Category";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(239, 465);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Description";
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(244, 503);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(485, 60);
            this.txtDescription.TabIndex = 7;
            this.txtDescription.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(769, 375);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(227, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Attach Image/ Document";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnSubmitReport
            // 
            this.btnSubmitReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSubmitReport.BackColor = System.Drawing.Color.Teal;
            this.btnSubmitReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubmitReport.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(41)))), ((int)(((byte)(123)))));
            this.btnSubmitReport.FlatAppearance.BorderSize = 5;
            this.btnSubmitReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitReport.ForeColor = System.Drawing.Color.White;
            this.btnSubmitReport.Location = new System.Drawing.Point(207, 646);
            this.btnSubmitReport.Name = "btnSubmitReport";
            this.btnSubmitReport.Size = new System.Drawing.Size(784, 45);
            this.btnSubmitReport.TabIndex = 9;
            this.btnSubmitReport.Text = "Submit Report";
            this.btnSubmitReport.UseVisualStyleBackColor = false;
            this.btnSubmitReport.Click += new System.EventHandler(this.btnSubmitReport_Click);
            // 
            // CategoryListBx
            // 
            this.CategoryListBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryListBx.FormattingEnabled = true;
            this.CategoryListBx.ItemHeight = 31;
            this.CategoryListBx.Items.AddRange(new object[] {
            "Sanitation",
            "Roads ",
            "Weather",
            "Utilities",
            "Others"});
            this.CategoryListBx.Location = new System.Drawing.Point(506, 403);
            this.CategoryListBx.Name = "CategoryListBx";
            this.CategoryListBx.Size = new System.Drawing.Size(222, 35);
            this.CategoryListBx.TabIndex = 10;
            // 
            // btnAddFile
            // 
            this.btnAddFile.BackColor = System.Drawing.Color.Teal;
            this.btnAddFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddFile.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnAddFile.Location = new System.Drawing.Point(774, 558);
            this.btnAddFile.Name = "btnAddFile";
            this.btnAddFile.Size = new System.Drawing.Size(226, 38);
            this.btnAddFile.TabIndex = 11;
            this.btnAddFile.Text = "Add File";
            this.btnAddFile.UseVisualStyleBackColor = false;
            this.btnAddFile.Click += new System.EventHandler(this.btnAddFile_Click);
            // 
            // AttachedPictureBox
            // 
            this.AttachedPictureBox.Location = new System.Drawing.Point(774, 403);
            this.AttachedPictureBox.Name = "AttachedPictureBox";
            this.AttachedPictureBox.Size = new System.Drawing.Size(226, 140);
            this.AttachedPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AttachedPictureBox.TabIndex = 12;
            this.AttachedPictureBox.TabStop = false;
            this.AttachedPictureBox.Click += new System.EventHandler(this.AttachedPictureBox_Click);
            // 
            // progressBar
            // 
            this.progressBar.AccessibleRole = System.Windows.Forms.AccessibleRole.Application;
            this.progressBar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.progressBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.progressBar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.progressBar.Location = new System.Drawing.Point(0, 0);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(1232, 17);
            this.progressBar.TabIndex = 14;
            // 
            // ReportDataGrid
            // 
            this.ReportDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ReportDataGrid.Location = new System.Drawing.Point(279, 107);
            this.ReportDataGrid.Name = "ReportDataGrid";
            this.ReportDataGrid.RowHeadersWidth = 51;
            this.ReportDataGrid.RowTemplate.Height = 24;
            this.ReportDataGrid.Size = new System.Drawing.Size(654, 189);
            this.ReportDataGrid.TabIndex = 15;
            // 
            // ReportIssueForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(41)))), ((int)(((byte)(123)))));
            this.ClientSize = new System.Drawing.Size(1232, 703);
            this.Controls.Add(this.ReportDataGrid);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.AttachedPictureBox);
            this.Controls.Add(this.btnAddFile);
            this.Controls.Add(this.CategoryListBx);
            this.Controls.Add(this.btnSubmitReport);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textLocation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Report);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReportIssueForm";
            this.Text = "ReportIssueForm";
            this.Load += new System.EventHandler(this.ReportIssueForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AttachedPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReportDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Report;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textLocation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox txtDescription;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnSubmitReport;
        private System.Windows.Forms.ListBox CategoryListBx;
        private System.Windows.Forms.Button btnAddFile;
        private System.Windows.Forms.PictureBox AttachedPictureBox;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.DataGridView ReportDataGrid;
    }
}