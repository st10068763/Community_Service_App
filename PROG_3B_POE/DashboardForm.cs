using PROG_3B_POE.Properties;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace PROG_3B_POE
{

    public partial class DashboardForm : Form
    {       
        public DashboardForm()
        {
            InitializeComponent();
            LoadDashboardData();
        }
        // Method to load data for the dashboard
        private void LoadDashboardData()
        {
            try
            {
                // Load chart data
                PopulateReportChart();

                // Load events
                LoadEvents();

                // Load recent reports
                LoadRecentReports();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading dashboard data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Method to populate the chart
        private void PopulateReportChart()
        {
            // Mock data for chart; replace with actual data fetching logic
            var reportData = new Dictionary<string, int>
            {
                { "Infrastructure", 12 },
                { "Sanitation", 8 },
                { "Water", 15 },
                { "Electricity", 5 }
            };

            chart1.Series.Clear();
            Series series = new Series("Reports")
            {
                ChartType = SeriesChartType.Bar,
                Color = Color.CornflowerBlue
            };

            foreach (var item in reportData)
            {
                series.Points.AddXY(item.Key, item.Value);
            }

            chart1.Series.Add(series);
            chart1.ChartAreas[0].AxisX.Title = "Categories";
            chart1.ChartAreas[0].AxisY.Title = "Number of Reports";
        }

        // Method to load events into EventsList
        private void LoadEvents()
        {
            // Replace with actual data fetching logic
            var events = new List<EventDetails>
            {
                new EventDetails
                {
                    EventName = "Music Festival",
                    EventDate = DateTime.Now.AddDays(2),
                    EventCategory = "Entertainment",
                    EventLocation = "Central Park",
                    EventDescription = "Enjoy live music performances",
                    EventImage = Resources.music_event  
                },
                // Add more events as needed
            };

            foreach (var ev in events)
            {
                var eventControl = new EventsList
                {
                    EventName = ev.EventName,
                    EventDate = ev.EventDate,
                    EventCategory = ev.EventCategory,
                    EventLocation = ev.EventLocation,
                    EventDescription = ev.EventDescription,
                    EventImage = ev.EventImage
                };

                flowLayoutPanel1.Controls.Add(eventControl);
            }
        }

        // Method to load recent reports
        private void LoadRecentReports()
        {
            // Replace with actual data fetching logic
            var reports = new List<ReportDetails>
            {
                new ReportDetails
                {
                    Description = "Broken water pipe on 5th Avenue",
                    EventCategory = "Water",
                    ReportImage = Resources.music_event
                },
                // Add more reports as needed
            };

            foreach (var report in reports.Take(5))
            {
                var reportControl = new ReportControl
                {
                    Description = report.Description,
                    EventCategory = report.EventCategory,
                    ReportImage = report.ReportImage
                };

                flowLayoutPanel1.Controls.Add(reportControl);
            }
        }
    }

    // Mock data classes for events and reports
    public class EventDetails
    {
        public string EventName { get; set; }
        public DateTime EventDate { get; set; }
        public string EventCategory { get; set; }
        public string EventLocation { get; set; }
        public string EventDescription { get; set; }
        public Image EventImage { get; set; }
    }

    public class ReportDetails
    {
        public string Description { get; set; }
        public string EventCategory { get; set; }
        public Image ReportImage { get; set; }
    }

}

