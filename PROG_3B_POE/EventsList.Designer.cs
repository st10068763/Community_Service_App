﻿namespace PROG_3B_POE
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
            this.lbEventCategory = new System.Windows.Forms.Label();
            this.lbEventName = new System.Windows.Forms.Label();
            this.lbEventDescription = new System.Windows.Forms.Label();
            this.lbLocation = new System.Windows.Forms.Label();
            this.lbEventDate = new System.Windows.Forms.Label();
            this.lbEventTime = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnJoin = new System.Windows.Forms.Button();
            this.eventImage = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lbEventCategory
            // 
            this.lbEventCategory.AutoEllipsis = true;
            this.lbEventCategory.AutoSize = true;
            this.lbEventCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEventCategory.ForeColor = System.Drawing.Color.White;
            this.lbEventCategory.Location = new System.Drawing.Point(74, 85);
            this.lbEventCategory.Name = "lbEventCategory";
            this.lbEventCategory.Size = new System.Drawing.Size(142, 25);
            this.lbEventCategory.TabIndex = 1;
            this.lbEventCategory.Text = "Event category";
            // 
            // lbEventName
            // 
            this.lbEventName.AutoEllipsis = true;
            this.lbEventName.AutoSize = true;
            this.lbEventName.Font = new System.Drawing.Font("Elephant", 25.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEventName.ForeColor = System.Drawing.Color.Gold;
            this.lbEventName.Location = new System.Drawing.Point(299, 16);
            this.lbEventName.Name = "lbEventName";
            this.lbEventName.Size = new System.Drawing.Size(281, 54);
            this.lbEventName.TabIndex = 2;
            this.lbEventName.Text = "Event Name";
            // 
            // lbEventDescription
            // 
            this.lbEventDescription.AutoEllipsis = true;
            this.lbEventDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEventDescription.ForeColor = System.Drawing.Color.White;
            this.lbEventDescription.Location = new System.Drawing.Point(74, 259);
            this.lbEventDescription.Name = "lbEventDescription";
            this.lbEventDescription.Size = new System.Drawing.Size(602, 58);
            this.lbEventDescription.TabIndex = 3;
            this.lbEventDescription.Text = "Description of the event";
            // 
            // lbLocation
            // 
            this.lbLocation.AutoEllipsis = true;
            this.lbLocation.AutoSize = true;
            this.lbLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLocation.ForeColor = System.Drawing.Color.White;
            this.lbLocation.Location = new System.Drawing.Point(74, 221);
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
            this.lbEventDate.ForeColor = System.Drawing.Color.White;
            this.lbEventDate.Location = new System.Drawing.Point(74, 133);
            this.lbEventDate.Name = "lbEventDate";
            this.lbEventDate.Size = new System.Drawing.Size(129, 25);
            this.lbEventDate.TabIndex = 5;
            this.lbEventDate.Text = "Date of Event";
            // 
            // lbEventTime
            // 
            this.lbEventTime.AutoEllipsis = true;
            this.lbEventTime.AutoSize = true;
            this.lbEventTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEventTime.ForeColor = System.Drawing.Color.White;
            this.lbEventTime.Location = new System.Drawing.Point(74, 178);
            this.lbEventTime.Name = "lbEventTime";
            this.lbEventTime.Size = new System.Drawing.Size(101, 25);
            this.lbEventTime.TabIndex = 6;
            this.lbEventTime.Text = "event time";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.btnJoin);
            this.panel1.Controls.Add(this.lbEventTime);
            this.panel1.Controls.Add(this.lbEventName);
            this.panel1.Controls.Add(this.lbEventCategory);
            this.panel1.Controls.Add(this.lbEventDescription);
            this.panel1.Controls.Add(this.lbLocation);
            this.panel1.Controls.Add(this.lbEventDate);
            this.panel1.Location = new System.Drawing.Point(354, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(945, 345);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.eventImage);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(357, 345);
            this.panel2.TabIndex = 7;
            // 
            // btnJoin
            // 
            this.btnJoin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJoin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnJoin.Location = new System.Drawing.Point(719, 265);
            this.btnJoin.Name = "btnJoin";
            this.btnJoin.Size = new System.Drawing.Size(114, 36);
            this.btnJoin.TabIndex = 7;
            this.btnJoin.Text = "Join";
            this.btnJoin.UseVisualStyleBackColor = true;
            // 
            // eventImage
            // 
            this.eventImage.Image = global::PROG_3B_POE.Properties.Resources.music_event;
            this.eventImage.Location = new System.Drawing.Point(0, 3);
            this.eventImage.Name = "eventImage";
            this.eventImage.Size = new System.Drawing.Size(348, 331);
            this.eventImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.eventImage.TabIndex = 0;
            this.eventImage.TabStop = false;
            // 
            // EventsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "EventsList";
            this.Size = new System.Drawing.Size(1299, 342);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.eventImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox eventImage;
        private System.Windows.Forms.Label lbEventCategory;
        private System.Windows.Forms.Label lbEventName;
        private System.Windows.Forms.Label lbEventDescription;
        private System.Windows.Forms.Label lbLocation;
        private System.Windows.Forms.Label lbEventDate;
        private System.Windows.Forms.Label lbEventTime;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnJoin;
    }
}
