using System.Drawing;
using System.Windows.Forms;

namespace PROG_3B_POE
{
    partial class DashboardForm
    {
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel pnlUpcomingEvents;
        private Panel pnlAnnouncements;
        private Panel pnlUserStats;
        private Panel pnlQuickActions;
        private Label lblUpcomingEvents;
        private Label lblAnnouncements;
        private Label lblUserStats;
        private Label lblQuickActions;
        private Button btnJoinEvent;

        private void InitializeComponent()
        {
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlUpcomingEvents = new System.Windows.Forms.Panel();
            this.lblUpcomingEvents = new System.Windows.Forms.Label();
            this.pnlAnnouncements = new System.Windows.Forms.Panel();
            this.lblAnnouncements = new System.Windows.Forms.Label();
            this.pnlUserStats = new System.Windows.Forms.Panel();
            this.lblUserStats = new System.Windows.Forms.Label();
            this.pnlQuickActions = new System.Windows.Forms.Panel();
            this.lblQuickActions = new System.Windows.Forms.Label();
            this.btnJoinEvent = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.pnlUpcomingEvents.SuspendLayout();
            this.pnlAnnouncements.SuspendLayout();
            this.pnlUserStats.SuspendLayout();
            this.pnlQuickActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Controls.Add(this.pnlUpcomingEvents);
            this.flowLayoutPanel1.Controls.Add(this.pnlAnnouncements);
            this.flowLayoutPanel1.Controls.Add(this.pnlUserStats);
            this.flowLayoutPanel1.Controls.Add(this.pnlQuickActions);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(20);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1260, 739);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // pnlUpcomingEvents
            // 
            this.pnlUpcomingEvents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.pnlUpcomingEvents.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlUpcomingEvents.Controls.Add(this.lblUpcomingEvents);
            this.pnlUpcomingEvents.Location = new System.Drawing.Point(23, 23);
            this.pnlUpcomingEvents.Name = "pnlUpcomingEvents";
            this.pnlUpcomingEvents.Padding = new System.Windows.Forms.Padding(15);
            this.pnlUpcomingEvents.Size = new System.Drawing.Size(350, 250);
            this.pnlUpcomingEvents.TabIndex = 0;
            // 
            // lblUpcomingEvents
            // 
            this.lblUpcomingEvents.AutoSize = true;
            this.lblUpcomingEvents.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblUpcomingEvents.ForeColor = System.Drawing.Color.White;
            this.lblUpcomingEvents.Location = new System.Drawing.Point(0, 0);
            this.lblUpcomingEvents.Name = "lblUpcomingEvents";
            this.lblUpcomingEvents.Size = new System.Drawing.Size(240, 37);
            this.lblUpcomingEvents.TabIndex = 0;
            this.lblUpcomingEvents.Text = "Upcoming Events";
            // 
            // pnlAnnouncements
            // 
            this.pnlAnnouncements.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.pnlAnnouncements.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAnnouncements.Controls.Add(this.lblAnnouncements);
            this.pnlAnnouncements.Location = new System.Drawing.Point(379, 23);
            this.pnlAnnouncements.Name = "pnlAnnouncements";
            this.pnlAnnouncements.Padding = new System.Windows.Forms.Padding(15);
            this.pnlAnnouncements.Size = new System.Drawing.Size(350, 250);
            this.pnlAnnouncements.TabIndex = 1;
            // 
            // lblAnnouncements
            // 
            this.lblAnnouncements.AutoSize = true;
            this.lblAnnouncements.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblAnnouncements.ForeColor = System.Drawing.Color.White;
            this.lblAnnouncements.Location = new System.Drawing.Point(0, 0);
            this.lblAnnouncements.Name = "lblAnnouncements";
            this.lblAnnouncements.Size = new System.Drawing.Size(318, 37);
            this.lblAnnouncements.TabIndex = 0;
            this.lblAnnouncements.Text = "Recent Announcements";
            // 
            // pnlUserStats
            // 
            this.pnlUserStats.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.pnlUserStats.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlUserStats.Controls.Add(this.lblUserStats);
            this.pnlUserStats.Location = new System.Drawing.Point(735, 23);
            this.pnlUserStats.Name = "pnlUserStats";
            this.pnlUserStats.Padding = new System.Windows.Forms.Padding(15);
            this.pnlUserStats.Size = new System.Drawing.Size(350, 250);
            this.pnlUserStats.TabIndex = 2;
            // 
            // lblUserStats
            // 
            this.lblUserStats.AutoSize = true;
            this.lblUserStats.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblUserStats.ForeColor = System.Drawing.Color.White;
            this.lblUserStats.Location = new System.Drawing.Point(0, 0);
            this.lblUserStats.Name = "lblUserStats";
            this.lblUserStats.Size = new System.Drawing.Size(197, 37);
            this.lblUserStats.TabIndex = 0;
            this.lblUserStats.Text = "Your Statistics";
            // 
            // pnlQuickActions
            // 
            this.pnlQuickActions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.pnlQuickActions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlQuickActions.Controls.Add(this.lblQuickActions);
            this.pnlQuickActions.Controls.Add(this.btnJoinEvent);
            this.pnlQuickActions.Location = new System.Drawing.Point(23, 279);
            this.pnlQuickActions.Name = "pnlQuickActions";
            this.pnlQuickActions.Padding = new System.Windows.Forms.Padding(15);
            this.pnlQuickActions.Size = new System.Drawing.Size(350, 250);
            this.pnlQuickActions.TabIndex = 3;
            // 
            // lblQuickActions
            // 
            this.lblQuickActions.AutoSize = true;
            this.lblQuickActions.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblQuickActions.ForeColor = System.Drawing.Color.White;
            this.lblQuickActions.Location = new System.Drawing.Point(0, 0);
            this.lblQuickActions.Name = "lblQuickActions";
            this.lblQuickActions.Size = new System.Drawing.Size(192, 37);
            this.lblQuickActions.TabIndex = 0;
            this.lblQuickActions.Text = "Quick Actions";
            // 
            // btnJoinEvent
            // 
            this.btnJoinEvent.BackColor = System.Drawing.Color.White;
            this.btnJoinEvent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJoinEvent.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnJoinEvent.ForeColor = System.Drawing.Color.Black;
            this.btnJoinEvent.Location = new System.Drawing.Point(15, 50);
            this.btnJoinEvent.Name = "btnJoinEvent";
            this.btnJoinEvent.Size = new System.Drawing.Size(150, 50);
            this.btnJoinEvent.TabIndex = 1;
            this.btnJoinEvent.Text = "Join Event";
            this.btnJoinEvent.UseVisualStyleBackColor = false;
            this.btnJoinEvent.Click += new System.EventHandler(this.btnJoinEvent_Click_1);
            // 
            // DashboardForm
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(41)))), ((int)(((byte)(95)))));
            this.ClientSize = new System.Drawing.Size(1260, 739);
            this.Controls.Add(this.flowLayoutPanel1);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DashboardForm";
            this.Text = "Dashboard";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.pnlUpcomingEvents.ResumeLayout(false);
            this.pnlUpcomingEvents.PerformLayout();
            this.pnlAnnouncements.ResumeLayout(false);
            this.pnlAnnouncements.PerformLayout();
            this.pnlUserStats.ResumeLayout(false);
            this.pnlUserStats.PerformLayout();
            this.pnlQuickActions.ResumeLayout(false);
            this.pnlQuickActions.PerformLayout();
            this.ResumeLayout(false);

        }
    }
}
