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
            this.components = new System.ComponentModel.Container();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.Report = new System.Windows.Forms.Label();
            this.lbDateAndTime = new System.Windows.Forms.Label();
            this.textLocation = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CategoryListBx = new System.Windows.Forms.ListBox();
            this.btnSubmitReport = new System.Windows.Forms.Button();
            this.btnAddFile = new System.Windows.Forms.Button();
            this.AttachedPictureBox = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AttachedPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1246, 763);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.progressBar);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Report);
            this.panel1.Controls.Add(this.lbDateAndTime);
            this.panel1.Controls.Add(this.textLocation);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.CategoryListBx);
            this.panel1.Controls.Add(this.btnSubmitReport);
            this.panel1.Controls.Add(this.btnAddFile);
            this.panel1.Controls.Add(this.AttachedPictureBox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtDescription);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1229, 432);
            this.panel1.TabIndex = 33;
            // 
            // progressBar
            // 
            this.progressBar.AccessibleRole = System.Windows.Forms.AccessibleRole.Application;
            this.progressBar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.progressBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.progressBar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.progressBar.Location = new System.Drawing.Point(0, 0);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(1229, 32);
            this.progressBar.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(183, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 25);
            this.label2.TabIndex = 19;
            this.label2.Text = "Location";
            // 
            // Report
            // 
            this.Report.AutoSize = true;
            this.Report.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Report.ForeColor = System.Drawing.Color.White;
            this.Report.Location = new System.Drawing.Point(301, 35);
            this.Report.Name = "Report";
            this.Report.Size = new System.Drawing.Size(471, 48);
            this.Report.TabIndex = 18;
            this.Report.Text = "Report Application Form";
            // 
            // lbDateAndTime
            // 
            this.lbDateAndTime.AutoSize = true;
            this.lbDateAndTime.Font = new System.Drawing.Font("Elephant", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDateAndTime.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbDateAndTime.Location = new System.Drawing.Point(913, 44);
            this.lbDateAndTime.Name = "lbDateAndTime";
            this.lbDateAndTime.Size = new System.Drawing.Size(190, 26);
            this.lbDateAndTime.TabIndex = 31;
            this.lbDateAndTime.Text = "lbDateAndTime";
            // 
            // textLocation
            // 
            this.textLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textLocation.Location = new System.Drawing.Point(287, 111);
            this.textLocation.Multiline = true;
            this.textLocation.Name = "textLocation";
            this.textLocation.Size = new System.Drawing.Size(248, 25);
            this.textLocation.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(585, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 25);
            this.label3.TabIndex = 21;
            this.label3.Text = "Category";
            // 
            // CategoryListBx
            // 
            this.CategoryListBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryListBx.FormattingEnabled = true;
            this.CategoryListBx.ItemHeight = 25;
            this.CategoryListBx.Items.AddRange(new object[] {
            "Crime",
            "Electricity ",
            "Others",
            "Road",
            "Safety",
            "Sanitation",
            "Utilities",
            "Weather"});
            this.CategoryListBx.Location = new System.Drawing.Point(706, 108);
            this.CategoryListBx.Name = "CategoryListBx";
            this.CategoryListBx.Size = new System.Drawing.Size(232, 29);
            this.CategoryListBx.Sorted = true;
            this.CategoryListBx.TabIndex = 26;
            // 
            // btnSubmitReport
            // 
            this.btnSubmitReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSubmitReport.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSubmitReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubmitReport.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(41)))), ((int)(((byte)(123)))));
            this.btnSubmitReport.FlatAppearance.BorderSize = 5;
            this.btnSubmitReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitReport.ForeColor = System.Drawing.Color.DimGray;
            this.btnSubmitReport.Location = new System.Drawing.Point(298, 334);
            this.btnSubmitReport.Name = "btnSubmitReport";
            this.btnSubmitReport.Size = new System.Drawing.Size(248, 45);
            this.btnSubmitReport.TabIndex = 25;
            this.btnSubmitReport.Text = "Submit Report";
            this.btnSubmitReport.UseVisualStyleBackColor = false;
            this.btnSubmitReport.Click += new System.EventHandler(this.btnSubmitReport_Click_1);
            // 
            // btnAddFile
            // 
            this.btnAddFile.BackColor = System.Drawing.Color.White;
            this.btnAddFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddFile.ForeColor = System.Drawing.Color.DimGray;
            this.btnAddFile.Location = new System.Drawing.Point(964, 341);
            this.btnAddFile.Name = "btnAddFile";
            this.btnAddFile.Size = new System.Drawing.Size(226, 38);
            this.btnAddFile.TabIndex = 27;
            this.btnAddFile.Text = "Add File";
            this.btnAddFile.UseVisualStyleBackColor = false;
            this.btnAddFile.Click += new System.EventHandler(this.btnAddFile_Click_1);
            // 
            // AttachedPictureBox
            // 
            this.AttachedPictureBox.Location = new System.Drawing.Point(944, 101);
            this.AttachedPictureBox.Name = "AttachedPictureBox";
            this.AttachedPictureBox.Size = new System.Drawing.Size(268, 192);
            this.AttachedPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AttachedPictureBox.TabIndex = 28;
            this.AttachedPictureBox.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(160, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 25);
            this.label4.TabIndex = 22;
            this.label4.Text = "Description";
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(287, 164);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(651, 60);
            this.txtDescription.TabIndex = 23;
            this.txtDescription.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(963, 296);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(227, 25);
            this.label5.TabIndex = 24;
            this.label5.Text = "Attach Image/ Document";
            // 
            // ReportIssueForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(41)))), ((int)(((byte)(123)))));
            this.ClientSize = new System.Drawing.Size(1246, 763);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReportIssueForm";
            this.Text = "ReportIssueForm";
            this.Load += new System.EventHandler(this.ReportIssueForm_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AttachedPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbDateAndTime;
        private System.Windows.Forms.TextBox textLocation;
        private System.Windows.Forms.Label Report;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox CategoryListBx;
        private System.Windows.Forms.Button btnSubmitReport;
        private System.Windows.Forms.Button btnAddFile;
        private System.Windows.Forms.PictureBox AttachedPictureBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox txtDescription;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ProgressBar progressBar;
    }
}