namespace PROG_3B_POE
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
            this.eventsList1 = new PROG_3B_POE.EventsList();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.eventsList1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1321, 755);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // eventsList1
            // 
            this.eventsList1.Dock = System.Windows.Forms.DockStyle.Top;
            this.eventsList1.EventDate = new System.DateTime(2024, 10, 10, 17, 38, 6, 0);
            this.eventsList1.EventDescription = "Something about the event";
            this.eventsList1.EventImage = global::PROG_3B_POE.Properties.Resources.sport_event;
            this.eventsList1.EventLocation = "Cape Town";
            this.eventsList1.EventName = "Rugby match";
            this.eventsList1.EventTime = new System.DateTime(2024, 10, 17, 0, 0, 0, 0);
            this.eventsList1.Location = new System.Drawing.Point(3, 3);
            this.eventsList1.Name = "eventsList1";
            this.eventsList1.Size = new System.Drawing.Size(1313, 195);
            this.eventsList1.TabIndex = 0;
            // 
            // LocalEventsAnnouncementsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(41)))), ((int)(((byte)(95)))));
            this.ClientSize = new System.Drawing.Size(1321, 755);
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
        private EventsList eventsList1;
    }
}