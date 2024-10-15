namespace PROG_3B_POE
{
    partial class ReportControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbCategory = new System.Windows.Forms.Label();
            this.lbLocation = new System.Windows.Forms.Label();
            this.lbDescription = new System.Windows.Forms.Label();
            this.lbFile = new System.Windows.Forms.Label();
            this.reportImage = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reportImage)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.reportImage);
            this.panel1.Location = new System.Drawing.Point(17, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(370, 311);
            this.panel1.TabIndex = 0;
            // 
            // lbCategory
            // 
            this.lbCategory.AutoSize = true;
            this.lbCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCategory.Location = new System.Drawing.Point(27, 350);
            this.lbCategory.Name = "lbCategory";
            this.lbCategory.Size = new System.Drawing.Size(115, 29);
            this.lbCategory.TabIndex = 1;
            this.lbCategory.Text = "Category";
            // 
            // lbLocation
            // 
            this.lbLocation.AutoSize = true;
            this.lbLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLocation.Location = new System.Drawing.Point(27, 405);
            this.lbLocation.Name = "lbLocation";
            this.lbLocation.Size = new System.Drawing.Size(109, 29);
            this.lbLocation.TabIndex = 2;
            this.lbLocation.Text = "Location";
            // 
            // lbDescription
            // 
            this.lbDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDescription.Location = new System.Drawing.Point(27, 458);
            this.lbDescription.Name = "lbDescription";
            this.lbDescription.Size = new System.Drawing.Size(345, 115);
            this.lbDescription.TabIndex = 3;
            this.lbDescription.Text = "Description";
            // 
            // lbFile
            // 
            this.lbFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFile.Location = new System.Drawing.Point(27, 587);
            this.lbFile.Name = "lbFile";
            this.lbFile.Size = new System.Drawing.Size(345, 91);
            this.lbFile.TabIndex = 4;
            this.lbFile.Text = "file";
            // 
            // reportImage
            // 
            this.reportImage.Image = global::PROG_3B_POE.Properties.Resources.logo;
            this.reportImage.Location = new System.Drawing.Point(3, 3);
            this.reportImage.Name = "reportImage";
            this.reportImage.Size = new System.Drawing.Size(364, 305);
            this.reportImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.reportImage.TabIndex = 0;
            this.reportImage.TabStop = false;
            // 
            // ReportControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Controls.Add(this.lbFile);
            this.Controls.Add(this.lbDescription);
            this.Controls.Add(this.lbLocation);
            this.Controls.Add(this.lbCategory);
            this.Controls.Add(this.panel1);
            this.Name = "ReportControl";
            this.Size = new System.Drawing.Size(407, 690);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.reportImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox reportImage;
        private System.Windows.Forms.Label lbCategory;
        private System.Windows.Forms.Label lbLocation;
        private System.Windows.Forms.Label lbDescription;
        private System.Windows.Forms.Label lbFile;
    }
}
