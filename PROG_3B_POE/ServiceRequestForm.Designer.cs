namespace PROG_3B_POE
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.lblTitle = new System.Windows.Forms.Label();
            this.dgvServiceRequests = new System.Windows.Forms.DataGridView();
            this.Request_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServiceStatus = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Priority = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Request_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.cbChartType = new System.Windows.Forms.ComboBox();
            this.btnLineGraph = new System.Windows.Forms.RadioButton();
            this.btnStakedGraph = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
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
            this.Category,
            this.Priority,
            this.Description,
            this.Request_Date});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvServiceRequests.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvServiceRequests.ImeMode = System.Windows.Forms.ImeMode.AlphaFull;
            this.dgvServiceRequests.Location = new System.Drawing.Point(20, 70);
            this.dgvServiceRequests.Name = "dgvServiceRequests";
            this.dgvServiceRequests.RowHeadersWidth = 51;
            this.dgvServiceRequests.Size = new System.Drawing.Size(744, 279);
            this.dgvServiceRequests.TabIndex = 1;
            this.dgvServiceRequests.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvServiceRequests_CellValueChanged_1);
            // 
            // Request_ID
            // 
            this.Request_ID.DataPropertyName = "RequestId";
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.Request_ID.DefaultCellStyle = dataGridViewCellStyle1;
            this.Request_ID.HeaderText = "Request ID";
            this.Request_ID.MinimumWidth = 6;
            this.Request_ID.Name = "Request_ID";
            this.Request_ID.ReadOnly = true;
            this.Request_ID.Width = 125;
            // 
            // ServiceStatus
            // 
            this.ServiceStatus.DataPropertyName = "Status";
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.ServiceStatus.DefaultCellStyle = dataGridViewCellStyle2;
            this.ServiceStatus.HeaderText = "Service Status";
            this.ServiceStatus.Items.AddRange(new object[] {
            "In progress",
            "Pending",
            "Solved"});
            this.ServiceStatus.MinimumWidth = 6;
            this.ServiceStatus.Name = "ServiceStatus";
            this.ServiceStatus.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ServiceStatus.Sorted = true;
            this.ServiceStatus.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ServiceStatus.Width = 125;
            // 
            // Category
            // 
            this.Category.HeaderText = "Category";
            this.Category.MinimumWidth = 6;
            this.Category.Name = "Category";
            this.Category.ReadOnly = true;
            this.Category.Width = 125;
            // 
            // Priority
            // 
            this.Priority.DataPropertyName = "Priority";
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            this.Priority.DefaultCellStyle = dataGridViewCellStyle3;
            this.Priority.HeaderText = "Priority";
            this.Priority.MinimumWidth = 6;
            this.Priority.Name = "Priority";
            this.Priority.ReadOnly = true;
            this.Priority.Width = 125;
            // 
            // Description
            // 
            this.Description.DataPropertyName = "Description";
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Description.DefaultCellStyle = dataGridViewCellStyle4;
            this.Description.HeaderText = "Description";
            this.Description.MinimumWidth = 6;
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            this.Description.Width = 125;
            // 
            // Request_Date
            // 
            this.Request_Date.DataPropertyName = "RequestDate";
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Request_Date.DefaultCellStyle = dataGridViewCellStyle5;
            this.Request_Date.HeaderText = "Request Date";
            this.Request_Date.MinimumWidth = 6;
            this.Request_Date.Name = "Request_Date";
            this.Request_Date.ReadOnly = true;
            this.Request_Date.Width = 125;
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
            this.lblRequestID.Location = new System.Drawing.Point(772, 136);
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
            this.lblSearch.Location = new System.Drawing.Point(779, 171);
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
            this.label2.ForeColor = System.Drawing.Color.Orange;
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
            "Road ",
            "Eletricity",
            "Safety",
            "Sanitation",
            "Utilities",
            "Weather",
            "Others"});
            this.cbCategorySorting.Location = new System.Drawing.Point(912, 285);
            this.cbCategorySorting.Name = "cbCategorySorting";
            this.cbCategorySorting.Size = new System.Drawing.Size(215, 24);
            this.cbCategorySorting.TabIndex = 16;
            this.cbCategorySorting.SelectedIndexChanged += new System.EventHandler(this.cbCategorySorting_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(776, 285);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 25);
            this.label3.TabIndex = 17;
            this.label3.Text = "Category";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(779, 330);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 25);
            this.label4.TabIndex = 18;
            this.label4.Text = "Priority";
            // 
            // rdBtnPending
            // 
            this.rdBtnPending.AutoSize = true;
            this.rdBtnPending.Location = new System.Drawing.Point(870, 335);
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
            this.rdBtnInProgress.Location = new System.Drawing.Point(954, 335);
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
            this.rdBtnSolved.Location = new System.Drawing.Point(1056, 335);
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
            this.btnReset.Location = new System.Drawing.Point(954, 372);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(100, 30);
            this.btnReset.TabIndex = 22;
            this.btnReset.Text = "Reset sorting";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // ServiceChart
            // 
            chartArea1.Name = "ChartArea1";
            this.ServiceChart.ChartAreas.Add(chartArea1);
            this.ServiceChart.Cursor = System.Windows.Forms.Cursors.Cross;
            legend1.Name = "Legend1";
            this.ServiceChart.Legends.Add(legend1);
            this.ServiceChart.Location = new System.Drawing.Point(18, 389);
            this.ServiceChart.Name = "ServiceChart";
            this.ServiceChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Column";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series2.Legend = "Legend1";
            series2.Name = "Line";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
            series3.Legend = "Legend1";
            series3.Name = "Staked";
            series3.YValuesPerPoint = 4;
            this.ServiceChart.Series.Add(series1);
            this.ServiceChart.Series.Add(series2);
            this.ServiceChart.Series.Add(series3);
            this.ServiceChart.Size = new System.Drawing.Size(746, 322);
            this.ServiceChart.TabIndex = 23;
            this.ServiceChart.Text = "Service Chart";
            // 
            // cbChartType
            // 
            this.cbChartType.FormattingEnabled = true;
            this.cbChartType.Items.AddRange(new object[] {
            "Category",
            "Status",
            "Priority"});
            this.cbChartType.Location = new System.Drawing.Point(929, 636);
            this.cbChartType.Name = "cbChartType";
            this.cbChartType.Size = new System.Drawing.Size(215, 24);
            this.cbChartType.TabIndex = 25;
            this.cbChartType.SelectedIndexChanged += new System.EventHandler(this.cbChartType_SelectedIndexChanged);
            // 
            // btnLineGraph
            // 
            this.btnLineGraph.AutoSize = true;
            this.btnLineGraph.Location = new System.Drawing.Point(925, 567);
            this.btnLineGraph.Name = "btnLineGraph";
            this.btnLineGraph.Size = new System.Drawing.Size(91, 20);
            this.btnLineGraph.TabIndex = 27;
            this.btnLineGraph.TabStop = true;
            this.btnLineGraph.Text = "Line graph";
            this.btnLineGraph.UseVisualStyleBackColor = true;
            this.btnLineGraph.CheckedChanged += new System.EventHandler(this.btnLineGraph_CheckedChanged);
            // 
            // btnStakedGraph
            // 
            this.btnStakedGraph.AutoSize = true;
            this.btnStakedGraph.Location = new System.Drawing.Point(926, 593);
            this.btnStakedGraph.Name = "btnStakedGraph";
            this.btnStakedGraph.Size = new System.Drawing.Size(73, 20);
            this.btnStakedGraph.TabIndex = 28;
            this.btnStakedGraph.TabStop = true;
            this.btnStakedGraph.Text = "Column";
            this.btnStakedGraph.UseVisualStyleBackColor = true;
            this.btnStakedGraph.CheckedChanged += new System.EventHandler(this.btnStakedGraph_CheckedChanged);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Orange;
            this.label5.Location = new System.Drawing.Point(907, 449);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(197, 30);
            this.label5.TabIndex = 29;
            this.label5.Text = "Graph options";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.BurlyWood;
            this.label6.Location = new System.Drawing.Point(770, 567);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 30);
            this.label6.TabIndex = 30;
            this.label6.Text = "Types of graph";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.BurlyWood;
            this.label7.Location = new System.Drawing.Point(777, 636);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 30);
            this.label7.TabIndex = 31;
            this.label7.Text = "View by";
            // 
            // ServiceRequestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(1179, 733);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnStakedGraph);
            this.Controls.Add(this.btnLineGraph);
            this.Controls.Add(this.cbChartType);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Request_ID;
        private System.Windows.Forms.DataGridViewComboBoxColumn ServiceStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn Priority;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Request_Date;
        private System.Windows.Forms.ComboBox cbChartType;
        private System.Windows.Forms.RadioButton btnLineGraph;
        private System.Windows.Forms.RadioButton btnStakedGraph;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}
