namespace PROG_3B_POE
{
    partial class EventsList
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbEventName = new System.Windows.Forms.Label();
            this.lbEventCategory = new System.Windows.Forms.Label();
            this.lbEventDate = new System.Windows.Forms.Label();
            this.lbEventDescription = new System.Windows.Forms.Label();
            this.lbEventLocation = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PROG_3B_POE.Properties.Resources.food_event;
            this.pictureBox1.Location = new System.Drawing.Point(3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(230, 168);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lbEventName
            // 
            this.lbEventName.AutoSize = true;
            this.lbEventName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEventName.Location = new System.Drawing.Point(13, 10);
            this.lbEventName.Name = "lbEventName";
            this.lbEventName.Size = new System.Drawing.Size(224, 29);
            this.lbEventName.TabIndex = 1;
            this.lbEventName.Text = "Name of the event";
            // 
            // lbEventCategory
            // 
            this.lbEventCategory.AutoSize = true;
            this.lbEventCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEventCategory.Location = new System.Drawing.Point(13, 39);
            this.lbEventCategory.Name = "lbEventCategory";
            this.lbEventCategory.Size = new System.Drawing.Size(156, 25);
            this.lbEventCategory.TabIndex = 2;
            this.lbEventCategory.Text = "Event category";
            // 
            // lbEventDate
            // 
            this.lbEventDate.AutoSize = true;
            this.lbEventDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEventDate.Location = new System.Drawing.Point(13, 90);
            this.lbEventDate.Name = "lbEventDate";
            this.lbEventDate.Size = new System.Drawing.Size(159, 25);
            this.lbEventDate.TabIndex = 3;
            this.lbEventDate.Text = "12 January 2024";
            // 
            // lbEventDescription
            // 
            this.lbEventDescription.AutoEllipsis = true;
            this.lbEventDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEventDescription.Location = new System.Drawing.Point(13, 115);
            this.lbEventDescription.Name = "lbEventDescription";
            this.lbEventDescription.Size = new System.Drawing.Size(712, 53);
            this.lbEventDescription.TabIndex = 4;
            this.lbEventDescription.Text = "The description of this event, all the user has to know about it ";
            // 
            // lbEventLocation
            // 
            this.lbEventLocation.AutoSize = true;
            this.lbEventLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEventLocation.Location = new System.Drawing.Point(13, 64);
            this.lbEventLocation.Name = "lbEventLocation";
            this.lbEventLocation.Size = new System.Drawing.Size(234, 26);
            this.lbEventLocation.TabIndex = 7;
            this.lbEventLocation.Text = "Location of the event";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(236, 175);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel2.Controls.Add(this.lbEventName);
            this.panel2.Controls.Add(this.lbEventCategory);
            this.panel2.Controls.Add(this.lbEventDescription);
            this.panel2.Controls.Add(this.lbEventLocation);
            this.panel2.Controls.Add(this.lbEventDate);
            this.panel2.Location = new System.Drawing.Point(239, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(973, 175);
            this.panel2.TabIndex = 9;
            // 
            // EventsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "EventsList";
            this.Size = new System.Drawing.Size(1212, 175);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbEventName;
        private System.Windows.Forms.Label lbEventCategory;
        private System.Windows.Forms.Label lbEventDate;
        private System.Windows.Forms.Label lbEventDescription;
        private System.Windows.Forms.Label lbEventLocation;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}
