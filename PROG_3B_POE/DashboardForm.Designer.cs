namespace PROG_3B_POE
{
    partial class DashboardForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtpEventDate = new System.Windows.Forms.DateTimePicker();
            this.btnCreateEvent = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.eventsList1 = new PROG_3B_POE.EventsList();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSartTime = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Controls.Add(this.eventsList1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1128, 656);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Peru;
            this.panel1.Controls.Add(this.txtSartTime);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.dtpEventDate);
            this.panel1.Controls.Add(this.btnCreateEvent);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.txtDescription);
            this.panel1.Controls.Add(this.txtLocation);
            this.panel1.Controls.Add(this.cbCategory);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1128, 339);
            this.panel1.TabIndex = 1;
            // 
            // dtpEventDate
            // 
            this.dtpEventDate.Location = new System.Drawing.Point(128, 90);
            this.dtpEventDate.Name = "dtpEventDate";
            this.dtpEventDate.Size = new System.Drawing.Size(745, 22);
            this.dtpEventDate.TabIndex = 25;
            // 
            // btnCreateEvent
            // 
            this.btnCreateEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateEvent.ForeColor = System.Drawing.Color.LightSalmon;
            this.btnCreateEvent.Location = new System.Drawing.Point(435, 294);
            this.btnCreateEvent.Name = "btnCreateEvent";
            this.btnCreateEvent.Size = new System.Drawing.Size(156, 33);
            this.btnCreateEvent.TabIndex = 24;
            this.btnCreateEvent.Text = "Create New Event";
            this.btnCreateEvent.UseVisualStyleBackColor = true;
            this.btnCreateEvent.Click += new System.EventHandler(this.btnCreateEvent_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(890, 85);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(223, 162);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.LightSalmon;
            this.button1.Location = new System.Drawing.Point(924, 46);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 33);
            this.button1.TabIndex = 22;
            this.button1.Text = "Add event image";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(128, 242);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(745, 35);
            this.txtDescription.TabIndex = 21;
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(128, 206);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(745, 22);
            this.txtLocation.TabIndex = 20;
            // 
            // cbCategory
            // 
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Items.AddRange(new object[] {
            "Sport",
            "Community build",
            "Recreation",
            "Music",
            "Food",
            "Workshop",
            "Education",
            "Donation",
            "Awareness"});
            this.cbCategory.Location = new System.Drawing.Point(128, 167);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(745, 24);
            this.cbCategory.TabIndex = 18;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(128, 51);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(745, 22);
            this.txtName.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 25);
            this.label6.TabIndex = 16;
            this.label6.Text = "Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 25);
            this.label5.TabIndex = 15;
            this.label5.Text = "Category";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 25);
            this.label4.TabIndex = 14;
            this.label4.Text = "Location";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 25);
            this.label3.TabIndex = 13;
            this.label3.Text = "Description";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(428, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 39);
            this.label1.TabIndex = 11;
            this.label1.Text = "Create Event";
            // 
            // eventsList1
            // 
            this.eventsList1.EventDate = new System.DateTime(((long)(0)));
            this.eventsList1.EventDescription = null;
            this.eventsList1.EventImage = null;
            this.eventsList1.EventLocation = null;
            this.eventsList1.EventName = null;
            this.eventsList1.EventTime = new System.DateTime(((long)(0)));
            this.eventsList1.Location = new System.Drawing.Point(3, 348);
            this.eventsList1.Name = "eventsList1";
            this.eventsList1.Size = new System.Drawing.Size(1313, 195);
            this.eventsList1.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 129);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 25);
            this.label7.TabIndex = 26;
            this.label7.Text = "Start time";
            // 
            // txtSartTime
            // 
            this.txtSartTime.Location = new System.Drawing.Point(128, 133);
            this.txtSartTime.Name = "txtSartTime";
            this.txtSartTime.Size = new System.Drawing.Size(745, 22);
            this.txtSartTime.TabIndex = 27;
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(41)))), ((int)(((byte)(95)))));
            this.ClientSize = new System.Drawing.Size(1128, 656);
            this.Controls.Add(this.flowLayoutPanel1);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DashboardForm";
            this.Text = "DashboardForm";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCreateEvent;
        private System.Windows.Forms.DateTimePicker dtpEventDate;
        private System.Windows.Forms.TextBox txtSartTime;
        private System.Windows.Forms.Label label7;
        private EventsList eventsList1;
    }
}