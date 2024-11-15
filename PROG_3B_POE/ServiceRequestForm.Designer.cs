﻿namespace PROG_3B_POE
{
    partial class ServiceRequestForm
    {
        private System.ComponentModel.IContainer components = null;

        // UI Controls
        private System.Windows.Forms.DataGridView dgvServiceRequests;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblRequestDetails;
        private System.Windows.Forms.TextBox txtRequestID;
        private System.Windows.Forms.Label lblRequestID;
        private System.Windows.Forms.Button btnTrackRequest;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtSearch;  // New search box for requests
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnUpdateStatus;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTitle = new System.Windows.Forms.Label();
            this.dgvServiceRequests = new System.Windows.Forms.DataGridView();
            this.lblRequestDetails = new System.Windows.Forms.Label();
            this.txtRequestID = new System.Windows.Forms.TextBox();
            this.lblRequestID = new System.Windows.Forms.Label();
            this.btnTrackRequest = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnUpdateStatus = new System.Windows.Forms.Button();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.serviceRequestBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.cbCategorySorting = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rdBtnPending = new System.Windows.Forms.RadioButton();
            this.rdBtnInProgress = new System.Windows.Forms.RadioButton();
            this.rdBtnSolved = new System.Windows.Forms.RadioButton();
            this.btnReset = new System.Windows.Forms.Button();
            this.ServiceChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.rtbRequestStatus = new System.Windows.Forms.RichTextBox();
            this.Request_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServiceStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Priority = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Request_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServiceRequests)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceRequestBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ServiceChart)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(466, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(250, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Service Request Status";
            // 
            // dgvServiceRequests
            // 
            this.dgvServiceRequests.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvServiceRequests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServiceRequests.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Request_ID,
            this.ServiceStatus,
            this.Priority,
            this.Description,
            this.Request_Date});
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvServiceRequests.DefaultCellStyle = dataGridViewCellStyle12;
            this.dgvServiceRequests.ImeMode = System.Windows.Forms.ImeMode.AlphaFull;
            this.dgvServiceRequests.Location = new System.Drawing.Point(20, 70);
            this.dgvServiceRequests.Name = "dgvServiceRequests";
            this.dgvServiceRequests.RowHeadersWidth = 51;
            this.dgvServiceRequests.Size = new System.Drawing.Size(744, 279);
            this.dgvServiceRequests.TabIndex = 1;
            // 
            // lblRequestDetails
            // 
            this.lblRequestDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblRequestDetails.Location = new System.Drawing.Point(863, 100);
            this.lblRequestDetails.Name = "lblRequestDetails";
            this.lblRequestDetails.Size = new System.Drawing.Size(255, 25);
            this.lblRequestDetails.TabIndex = 2;
            this.lblRequestDetails.Text = "Track Specific Request";
            // 
            // txtRequestID
            // 
            this.txtRequestID.Location = new System.Drawing.Point(883, 136);
            this.txtRequestID.Name = "txtRequestID";
            this.txtRequestID.Size = new System.Drawing.Size(107, 22);
            this.txtRequestID.TabIndex = 9;
            // 
            // lblRequestID
            // 
            this.lblRequestID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblRequestID.Location = new System.Drawing.Point(777, 136);
            this.lblRequestID.Name = "lblRequestID";
            this.lblRequestID.Size = new System.Drawing.Size(100, 20);
            this.lblRequestID.TabIndex = 3;
            this.lblRequestID.Text = "Request ID:";
            // 
            // btnTrackRequest
            // 
            this.btnTrackRequest.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnTrackRequest.Location = new System.Drawing.Point(1027, 128);
            this.btnTrackRequest.Name = "btnTrackRequest";
            this.btnTrackRequest.Size = new System.Drawing.Size(100, 30);
            this.btnTrackRequest.TabIndex = 4;
            this.btnTrackRequest.Text = "Track";
            this.btnTrackRequest.UseVisualStyleBackColor = true;
            this.btnTrackRequest.Click += new System.EventHandler(this.btnTrackRequest_Click_1);
            // 
            // lblStatus
            // 
            this.lblStatus.Location = new System.Drawing.Point(0, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(100, 23);
            this.lblStatus.TabIndex = 10;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(0, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 11;
            // 
            // btnUpdateStatus
            // 
            this.btnUpdateStatus.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUpdateStatus.Location = new System.Drawing.Point(1018, 202);
            this.btnUpdateStatus.Name = "btnUpdateStatus";
            this.btnUpdateStatus.Size = new System.Drawing.Size(109, 30);
            this.btnUpdateStatus.TabIndex = 8;
            this.btnUpdateStatus.Text = "Update Status";
            this.btnUpdateStatus.UseVisualStyleBackColor = true;
            this.btnUpdateStatus.Click += new System.EventHandler(this.btnUpdateStatus_Click_1);
            // 
            // lblSearch
            // 
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblSearch.Location = new System.Drawing.Point(783, 171);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(100, 20);
            this.lblSearch.TabIndex = 10;
            this.lblSearch.Text = "Search:";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(883, 171);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(244, 22);
            this.txtSearch.TabIndex = 11;
            // 
            // btnSearch
            // 
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSearch.Location = new System.Drawing.Point(883, 202);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 30);
            this.btnSearch.TabIndex = 12;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click_1);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.BurlyWood;
            this.label1.Location = new System.Drawing.Point(13, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1164, 30);
            this.label1.TabIndex = 14;
            this.label1.Text = "Actions have been taken for all the submitted services, you may update the servic" +
    "e that is being done in your area here";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(910, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 30);
            this.label2.TabIndex = 15;
            this.label2.Text = "Sorting options";
            // 
            // cbCategorySorting
            // 
            this.cbCategorySorting.FormattingEnabled = true;
            this.cbCategorySorting.Items.AddRange(new object[] {
            "Crime",
            "Others",
            "Roads ",
            "Safety",
            "Sanitation",
            "Utilities",
            "Weather"});
            this.cbCategorySorting.Location = new System.Drawing.Point(912, 285);
            this.cbCategorySorting.Name = "cbCategorySorting";
            this.cbCategorySorting.Size = new System.Drawing.Size(215, 24);
            this.cbCategorySorting.TabIndex = 16;
            this.cbCategorySorting.SelectedIndexChanged += new System.EventHandler(this.cbCategorySorting_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(796, 285);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 25);
            this.label3.TabIndex = 17;
            this.label3.Text = "Category";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(800, 330);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 25);
            this.label4.TabIndex = 18;
            this.label4.Text = "Priority";
            // 
            // rdBtnPending
            // 
            this.rdBtnPending.AutoSize = true;
            this.rdBtnPending.Location = new System.Drawing.Point(905, 335);
            this.rdBtnPending.Name = "rdBtnPending";
            this.rdBtnPending.Size = new System.Drawing.Size(78, 20);
            this.rdBtnPending.TabIndex = 19;
            this.rdBtnPending.Text = "Pending";
            this.rdBtnPending.UseVisualStyleBackColor = true;
            this.rdBtnPending.CheckedChanged += new System.EventHandler(this.rdBtnPending_CheckedChanged);
            // 
            // rdBtnInProgress
            // 
            this.rdBtnInProgress.AutoSize = true;
            this.rdBtnInProgress.Location = new System.Drawing.Point(989, 335);
            this.rdBtnInProgress.Name = "rdBtnInProgress";
            this.rdBtnInProgress.Size = new System.Drawing.Size(96, 20);
            this.rdBtnInProgress.TabIndex = 20;
            this.rdBtnInProgress.Text = "In Progress";
            this.rdBtnInProgress.UseVisualStyleBackColor = true;
            this.rdBtnInProgress.CheckedChanged += new System.EventHandler(this.rdBtnInProgress_CheckedChanged);
            // 
            // rdBtnSolved
            // 
            this.rdBtnSolved.AutoSize = true;
            this.rdBtnSolved.Location = new System.Drawing.Point(1091, 335);
            this.rdBtnSolved.Name = "rdBtnSolved";
            this.rdBtnSolved.Size = new System.Drawing.Size(71, 20);
            this.rdBtnSolved.TabIndex = 21;
            this.rdBtnSolved.Text = "Solved";
            this.rdBtnSolved.UseVisualStyleBackColor = true;
            this.rdBtnSolved.CheckedChanged += new System.EventHandler(this.rdBtnSolved_CheckedChanged);
            // 
            // btnReset
            // 
            this.btnReset.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnReset.Location = new System.Drawing.Point(1027, 369);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(100, 30);
            this.btnReset.TabIndex = 22;
            this.btnReset.Text = "Reset sorting";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // ServiceChart
            // 
            chartArea2.Name = "ChartArea1";
            this.ServiceChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.ServiceChart.Legends.Add(legend2);
            this.ServiceChart.Location = new System.Drawing.Point(18, 389);
            this.ServiceChart.Name = "ServiceChart";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Column";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series4.Legend = "Legend1";
            series4.Name = "FastLine";
            this.ServiceChart.Series.Add(series3);
            this.ServiceChart.Series.Add(series4);
            this.ServiceChart.Size = new System.Drawing.Size(746, 300);
            this.ServiceChart.TabIndex = 23;
            this.ServiceChart.Text = "Service Chart";
            // 
            // rtbRequestStatus
            // 
            this.rtbRequestStatus.Location = new System.Drawing.Point(832, 425);
            this.rtbRequestStatus.Name = "rtbRequestStatus";
            this.rtbRequestStatus.Size = new System.Drawing.Size(295, 96);
            this.rtbRequestStatus.TabIndex = 24;
            this.rtbRequestStatus.Text = "";
            // 
            // Request_ID
            // 
            this.Request_ID.DataPropertyName = "RequestId";
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            this.Request_ID.DefaultCellStyle = dataGridViewCellStyle7;
            this.Request_ID.HeaderText = "Request ID";
            this.Request_ID.MinimumWidth = 6;
            this.Request_ID.Name = "Request_ID";
            this.Request_ID.ReadOnly = true;
            this.Request_ID.Width = 125;
            // 
            // ServiceStatus
            // 
            this.ServiceStatus.DataPropertyName = "Status";
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            this.ServiceStatus.DefaultCellStyle = dataGridViewCellStyle8;
            this.ServiceStatus.HeaderText = "Service Status";
            this.ServiceStatus.MinimumWidth = 6;
            this.ServiceStatus.Name = "ServiceStatus";
            this.ServiceStatus.ReadOnly = true;
            this.ServiceStatus.Width = 125;
            // 
            // Priority
            // 
            this.Priority.DataPropertyName = "Priority";
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            this.Priority.DefaultCellStyle = dataGridViewCellStyle9;
            this.Priority.HeaderText = "Priority";
            this.Priority.MinimumWidth = 6;
            this.Priority.Name = "Priority";
            this.Priority.ReadOnly = true;
            this.Priority.Width = 125;
            // 
            // Description
            // 
            this.Description.DataPropertyName = "Description";
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Description.DefaultCellStyle = dataGridViewCellStyle10;
            this.Description.HeaderText = "Description";
            this.Description.MinimumWidth = 6;
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            this.Description.Width = 125;
            // 
            // Request_Date
            // 
            this.Request_Date.DataPropertyName = "RequestDate";
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Request_Date.DefaultCellStyle = dataGridViewCellStyle11;
            this.Request_Date.HeaderText = "Request Date";
            this.Request_Date.MinimumWidth = 6;
            this.Request_Date.Name = "Request_Date";
            this.Request_Date.ReadOnly = true;
            this.Request_Date.Width = 125;
            // 
            // ServiceRequestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(1179, 712);
            this.Controls.Add(this.rtbRequestStatus);
            this.Controls.Add(this.ServiceChart);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.rdBtnSolved);
            this.Controls.Add(this.rdBtnInProgress);
            this.Controls.Add(this.rdBtnPending);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbCategorySorting);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUpdateStatus);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.dgvServiceRequests);
            this.Controls.Add(this.lblRequestDetails);
            this.Controls.Add(this.txtRequestID);
            this.Controls.Add(this.lblRequestID);
            this.Controls.Add(this.btnTrackRequest);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ServiceRequestForm";
            this.ShowIcon = false;
            this.Text = "ServiceRequestForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvServiceRequests)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceRequestBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ServiceChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource serviceRequestBindingSource;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbCategorySorting;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rdBtnPending;
        private System.Windows.Forms.RadioButton rdBtnInProgress;
        private System.Windows.Forms.RadioButton rdBtnSolved;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.DataVisualization.Charting.Chart ServiceChart;
        private System.Windows.Forms.RichTextBox rtbRequestStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn Request_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServiceStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn Priority;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Request_Date;
    }
}
