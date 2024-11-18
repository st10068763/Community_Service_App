using System.Drawing;
using System.Windows.Forms;

namespace PROG_3B_POE
{
    partial class DashboardForm
    {
        private FlowLayoutPanel flowLayoutPanel1;

        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.eventsList1 = new PROG_3B_POE.EventsList();
            this.reportControl1 = new PROG_3B_POE.ReportControl();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.DarkGray;
            this.flowLayoutPanel1.Controls.Add(this.chart1);
            this.flowLayoutPanel1.Controls.Add(this.eventsList1);
            this.flowLayoutPanel1.Controls.Add(this.reportControl1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(20);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1260, 739);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // eventsList1
            // 
            this.eventsList1.EventCategory = null;
            this.eventsList1.EventDate = new System.DateTime(((long)(0)));
            this.eventsList1.EventDescription = null;
            this.eventsList1.EventImage = null;
            this.eventsList1.EventLocation = null;
            this.eventsList1.EventName = null;
            this.eventsList1.EventTime = new System.DateTime(((long)(0)));
            this.eventsList1.Location = new System.Drawing.Point(23, 435);
            this.eventsList1.Name = "eventsList1";
            this.eventsList1.Size = new System.Drawing.Size(1479, 342);
            this.eventsList1.TabIndex = 4;
            // 
            // reportControl1
            // 
            this.reportControl1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.reportControl1.Description = null;
            this.reportControl1.EventCategory = null;
            this.reportControl1.File = null;
            this.reportControl1.Name = "reportControl1";
            this.reportControl1.ReportImage = null;
            this.reportControl1.Size = new System.Drawing.Size(407, 690);
            this.reportControl1.TabIndex = 5;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(23, 23);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(928, 406);
            this.chart1.TabIndex = 2;
            this.chart1.Text = "chart1";
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
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private EventsList eventsList1;
        private ReportControl reportControl1;
    }
}
