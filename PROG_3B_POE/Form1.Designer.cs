﻿namespace PROG_3B_POE
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHambugerButton = new System.Windows.Forms.PictureBox();
            this.sidebarContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.BtnServiceRequestService = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BtnRepoertIssue = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnLocalEventsAndAnnouncements = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.BtnLogout = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.BtnDashboard = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.sideBarTransiction = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHambugerButton)).BeginInit();
            this.sidebarContainer.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnHambugerButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1202, 67);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(106, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(444, 50);
            this.label1.TabIndex = 2;
            this.label1.Text = "Community Connection";
            // 
            // btnHambugerButton
            // 
            this.btnHambugerButton.Image = ((System.Drawing.Image)(resources.GetObject("btnHambugerButton.Image")));
            this.btnHambugerButton.Location = new System.Drawing.Point(-15, 0);
            this.btnHambugerButton.Name = "btnHambugerButton";
            this.btnHambugerButton.Size = new System.Drawing.Size(118, 63);
            this.btnHambugerButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnHambugerButton.TabIndex = 1;
            this.btnHambugerButton.TabStop = false;
            this.btnHambugerButton.Click += new System.EventHandler(this.btnHambugerButton_Click);
            // 
            // sidebarContainer
            // 
            this.sidebarContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.sidebarContainer.Controls.Add(this.flowLayoutPanel2);
            this.sidebarContainer.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebarContainer.Location = new System.Drawing.Point(0, 67);
            this.sidebarContainer.Name = "sidebarContainer";
            this.sidebarContainer.Size = new System.Drawing.Size(282, 634);
            this.sidebarContainer.TabIndex = 1;
            // 
            // BtnServiceRequestService
            // 
            this.BtnServiceRequestService.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.BtnServiceRequestService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnServiceRequestService.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnServiceRequestService.ForeColor = System.Drawing.Color.White;
            this.BtnServiceRequestService.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnServiceRequestService.Location = new System.Drawing.Point(0, 0);
            this.BtnServiceRequestService.Name = "BtnServiceRequestService";
            this.BtnServiceRequestService.Size = new System.Drawing.Size(264, 62);
            this.BtnServiceRequestService.TabIndex = 2;
            this.BtnServiceRequestService.Text = "Service Request";
            this.BtnServiceRequestService.UseVisualStyleBackColor = false;
            this.BtnServiceRequestService.Click += new System.EventHandler(this.BtnServiceRequestService_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.BtnServiceRequestService);
            this.panel2.Location = new System.Drawing.Point(3, 170);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.panel2.Size = new System.Drawing.Size(267, 63);
            this.panel2.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.BtnRepoertIssue);
            this.panel3.Location = new System.Drawing.Point(3, 239);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.panel3.Size = new System.Drawing.Size(270, 64);
            this.panel3.TabIndex = 4;
            // 
            // BtnRepoertIssue
            // 
            this.BtnRepoertIssue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.BtnRepoertIssue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRepoertIssue.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRepoertIssue.ForeColor = System.Drawing.Color.White;
            this.BtnRepoertIssue.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnRepoertIssue.Location = new System.Drawing.Point(-3, 0);
            this.BtnRepoertIssue.Name = "BtnRepoertIssue";
            this.BtnRepoertIssue.Size = new System.Drawing.Size(270, 62);
            this.BtnRepoertIssue.TabIndex = 2;
            this.BtnRepoertIssue.Text = "Report Issue";
            this.BtnRepoertIssue.UseVisualStyleBackColor = false;
            this.BtnRepoertIssue.Click += new System.EventHandler(this.BtnRepoertIssue_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnLocalEventsAndAnnouncements);
            this.panel4.Location = new System.Drawing.Point(3, 102);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.panel4.Size = new System.Drawing.Size(273, 62);
            this.panel4.TabIndex = 4;
            // 
            // btnLocalEventsAndAnnouncements
            // 
            this.btnLocalEventsAndAnnouncements.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.btnLocalEventsAndAnnouncements.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLocalEventsAndAnnouncements.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLocalEventsAndAnnouncements.ForeColor = System.Drawing.Color.White;
            this.btnLocalEventsAndAnnouncements.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLocalEventsAndAnnouncements.Location = new System.Drawing.Point(-1, 4);
            this.btnLocalEventsAndAnnouncements.Name = "btnLocalEventsAndAnnouncements";
            this.btnLocalEventsAndAnnouncements.Size = new System.Drawing.Size(270, 59);
            this.btnLocalEventsAndAnnouncements.TabIndex = 2;
            this.btnLocalEventsAndAnnouncements.Text = "Local Events and Announcements";
            this.btnLocalEventsAndAnnouncements.UseVisualStyleBackColor = false;
            this.btnLocalEventsAndAnnouncements.Click += new System.EventHandler(this.btnLocalEventsAndAnnouncements_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.BtnLogout);
            this.panel5.Location = new System.Drawing.Point(3, 309);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.panel5.Size = new System.Drawing.Size(270, 62);
            this.panel5.TabIndex = 5;
            // 
            // BtnLogout
            // 
            this.BtnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.BtnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLogout.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogout.ForeColor = System.Drawing.Color.White;
            this.BtnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnLogout.Location = new System.Drawing.Point(-3, 0);
            this.BtnLogout.Name = "BtnLogout";
            this.BtnLogout.Size = new System.Drawing.Size(273, 62);
            this.BtnLogout.TabIndex = 2;
            this.BtnLogout.Text = "Logout";
            this.BtnLogout.UseVisualStyleBackColor = false;
            this.BtnLogout.Click += new System.EventHandler(this.BtnLogout_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.BtnDashboard);
            this.panel6.Location = new System.Drawing.Point(3, 373);
            this.panel6.Name = "panel6";
            this.panel6.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.panel6.Size = new System.Drawing.Size(270, 62);
            this.panel6.TabIndex = 6;
            // 
            // BtnDashboard
            // 
            this.BtnDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.BtnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDashboard.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDashboard.ForeColor = System.Drawing.Color.White;
            this.BtnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnDashboard.Location = new System.Drawing.Point(-3, 0);
            this.BtnDashboard.Name = "BtnDashboard";
            this.BtnDashboard.Size = new System.Drawing.Size(273, 62);
            this.BtnDashboard.TabIndex = 2;
            this.BtnDashboard.Text = "Dashboard";
            this.BtnDashboard.UseVisualStyleBackColor = false;
            this.BtnDashboard.Click += new System.EventHandler(this.BtnDashboard_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.panel4);
            this.flowLayoutPanel2.Controls.Add(this.panel2);
            this.flowLayoutPanel2.Controls.Add(this.panel3);
            this.flowLayoutPanel2.Controls.Add(this.panel5);
            this.flowLayoutPanel2.Controls.Add(this.panel6);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(273, 634);
            this.flowLayoutPanel2.TabIndex = 4;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1202, 701);
            this.Controls.Add(this.sidebarContainer);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Municipal Services App";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHambugerButton)).EndInit();
            this.sidebarContainer.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btnHambugerButton;
        private System.Windows.Forms.FlowLayoutPanel sidebarContainer;
        private System.Windows.Forms.Button BtnServiceRequestService;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button BtnRepoertIssue;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnLocalEventsAndAnnouncements;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button BtnLogout;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button BtnDashboard;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Timer sideBarTransiction;
    }
}
