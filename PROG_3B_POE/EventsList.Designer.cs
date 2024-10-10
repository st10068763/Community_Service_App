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
            this.eventImage = new System.Windows.Forms.PictureBox();
            this.lbEventCategory = new System.Windows.Forms.Label();
            this.lbEventName = new System.Windows.Forms.Label();
            this.lbEventDescription = new System.Windows.Forms.Label();
            this.lbLocation = new System.Windows.Forms.Label();
            this.lbEventDate = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbEventTime = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.eventImage)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // eventImage
            // 
            this.eventImage.Image = global::PROG_3B_POE.Properties.Resources.music_event;
            this.eventImage.Location = new System.Drawing.Point(3, 3);
            this.eventImage.Name = "eventImage";
            this.eventImage.Size = new System.Drawing.Size(242, 189);
            this.eventImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.eventImage.TabIndex = 0;
            this.eventImage.TabStop = false;
            // 
            // lbEventCategory
            // 
            this.lbEventCategory.AutoEllipsis = true;
            this.lbEventCategory.AutoSize = true;
            this.lbEventCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEventCategory.Location = new System.Drawing.Point(129, 35);
            this.lbEventCategory.Name = "lbEventCategory";
            this.lbEventCategory.Size = new System.Drawing.Size(142, 25);
            this.lbEventCategory.TabIndex = 1;
            this.lbEventCategory.Text = "Event category";
            // 
            // lbEventName
            // 
            this.lbEventName.AutoEllipsis = true;
            this.lbEventName.AutoSize = true;
            this.lbEventName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEventName.Location = new System.Drawing.Point(127, 3);
            this.lbEventName.Name = "lbEventName";
            this.lbEventName.Size = new System.Drawing.Size(144, 29);
            this.lbEventName.TabIndex = 2;
            this.lbEventName.Text = "Event Name";
            // 
            // lbEventDescription
            // 
            this.lbEventDescription.AutoEllipsis = true;
            this.lbEventDescription.AutoSize = true;
            this.lbEventDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEventDescription.Location = new System.Drawing.Point(129, 157);
            this.lbEventDescription.Name = "lbEventDescription";
            this.lbEventDescription.Size = new System.Drawing.Size(215, 25);
            this.lbEventDescription.TabIndex = 3;
            this.lbEventDescription.Text = "Description of the event";
            // 
            // lbLocation
            // 
            this.lbLocation.AutoEllipsis = true;
            this.lbLocation.AutoSize = true;
            this.lbLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLocation.Location = new System.Drawing.Point(129, 125);
            this.lbLocation.Name = "lbLocation";
            this.lbLocation.Size = new System.Drawing.Size(86, 25);
            this.lbLocation.TabIndex = 4;
            this.lbLocation.Text = "Location";
            // 
            // lbEventDate
            // 
            this.lbEventDate.AutoEllipsis = true;
            this.lbEventDate.AutoSize = true;
            this.lbEventDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEventDate.Location = new System.Drawing.Point(127, 64);
            this.lbEventDate.Name = "lbEventDate";
            this.lbEventDate.Size = new System.Drawing.Size(129, 25);
            this.lbEventDate.TabIndex = 5;
            this.lbEventDate.Text = "Date of Event";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.lbEventTime);
            this.panel1.Controls.Add(this.lbEventName);
            this.panel1.Controls.Add(this.lbEventCategory);
            this.panel1.Controls.Add(this.lbEventDescription);
            this.panel1.Controls.Add(this.lbLocation);
            this.panel1.Controls.Add(this.lbEventDate);
            this.panel1.Location = new System.Drawing.Point(251, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1018, 195);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel2.Controls.Add(this.eventImage);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(248, 195);
            this.panel2.TabIndex = 7;
            // 
            // lbEventTime
            // 
            this.lbEventTime.AutoEllipsis = true;
            this.lbEventTime.AutoSize = true;
            this.lbEventTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEventTime.Location = new System.Drawing.Point(127, 95);
            this.lbEventTime.Name = "lbEventTime";
            this.lbEventTime.Size = new System.Drawing.Size(101, 25);
            this.lbEventTime.TabIndex = 6;
            this.lbEventTime.Text = "event time";
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Start time:";
            // 
            // label2
            // 
            this.label2.AutoEllipsis = true;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoEllipsis = true;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Category";
            // 
            // label4
            // 
            this.label4.AutoEllipsis = true;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(0, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Description:";
            // 
            // label5
            // 
            this.label5.AutoEllipsis = true;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Location:";
            // 
            // label6
            // 
            this.label6.AutoEllipsis = true;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "Date:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(118, 192);
            this.panel3.TabIndex = 13;
            // 
            // EventsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "EventsList";
            this.Size = new System.Drawing.Size(1257, 195);
            ((System.ComponentModel.ISupportInitialize)(this.eventImage)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox eventImage;
        private System.Windows.Forms.Label lbEventCategory;
        private System.Windows.Forms.Label lbEventName;
        private System.Windows.Forms.Label lbEventDescription;
        private System.Windows.Forms.Label lbLocation;
        private System.Windows.Forms.Label lbEventDate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbEventTime;
    }
}
