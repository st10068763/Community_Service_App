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
            this.SuspendLayout();
            // 
            // Report
            // 
            this.Report.AutoSize = true;
            this.Report.Location = new System.Drawing.Point(354, 179);
            this.Report.Name = "Report";
            this.Report.Size = new System.Drawing.Size(83, 16);
            this.Report.TabIndex = 0;
            this.Report.Text = "Report page";
            // 
            // ReportIssueForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Report);
            this.Name = "ReportIssueForm";
            this.Text = "ReportIssueForm";
            this.Load += new System.EventHandler(this.ReportIssueForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Report;
    }
}