﻿namespace PROG_3B_POE
{
    partial class LocalEventsAnnouncementsForm
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAddNewEvent = new System.Windows.Forms.Button();
            this.eventsList1 = new PROG_3B_POE.EventsList();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.eventsList1);
            this.flowLayoutPanel1.Controls.Add(this.btnAddNewEvent);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1219, 755);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // btnAddNewEvent
            // 
            this.btnAddNewEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewEvent.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAddNewEvent.Location = new System.Drawing.Point(3, 184);
            this.btnAddNewEvent.Name = "btnAddNewEvent";
            this.btnAddNewEvent.Size = new System.Drawing.Size(157, 31);
            this.btnAddNewEvent.TabIndex = 1;
            this.btnAddNewEvent.Text = "Add new event";
            this.btnAddNewEvent.UseVisualStyleBackColor = true;
            // 
            // eventsList1
            // 
            this.eventsList1.Dock = System.Windows.Forms.DockStyle.Top;
            this.eventsList1.EventCategory = null;
            this.eventsList1.EventDate = new System.DateTime(((long)(0)));
            this.eventsList1.EventDescription = null;
            this.eventsList1.EventImage = null;
            this.eventsList1.EventLocation = null;
            this.eventsList1.EventName = null;
            this.eventsList1.Location = new System.Drawing.Point(3, 3);
            this.eventsList1.Name = "eventsList1";
            this.eventsList1.Size = new System.Drawing.Size(1212, 175);
            this.eventsList1.TabIndex = 2;
            // 
            // LocalEventsAnnouncementsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(41)))), ((int)(((byte)(95)))));
            this.ClientSize = new System.Drawing.Size(1219, 755);
            this.Controls.Add(this.flowLayoutPanel1);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LocalEventsAnnouncementsForm";
            this.Text = "LocalEventsAnnouncementsForm";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnAddNewEvent;
        private EventsList eventsList1;
    }
}