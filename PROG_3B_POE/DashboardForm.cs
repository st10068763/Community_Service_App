using PROG_3B_POE.Properties;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROG_3B_POE
{

    public partial class DashboardForm : Form
    {       
        public DashboardForm()
        {
            InitializeComponent();
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            LoadUserStatistics();
            LoadUpcomingEvents();
            LoadRecentAnnouncements();
        }       

        // method to load user statistics
        private void LoadUserStatistics()
        {
            // Simulated data for user statistics
            string stats = "Events Attended: 5\nIssues Reported: 3\nEvents Joined: 2";
            lblUserStats.Text = stats;
        }

        private void LoadUpcomingEvents()
        {
            // Simulated data for upcoming events
            string events = "Event 1: Tech Conference - 20 Oct 2024\nEvent 2: Music Festival - 25 Oct 2024";
            lblUpcomingEvents.Text = events;
        }
        private void LoadRecentAnnouncements()
        {
            // Simulated data for recent announcements
            string announcements = "Announcement 1: New policy updates\nAnnouncement 2: Office closure notice";
            lblAnnouncements.Text = announcements;
        }

        /// <summary>
        /// Handles the click event of the Join Event button.
        /// Opens the Join Event form where the user can enter their details to enroll in an event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnJoinEvent_Click(object sender, EventArgs e)
        {
           

        }

        /// <summary>
        /// Handles the click event of the Report Issue button.
        /// Opens the Report Issue form where the user can report any issues.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReportIssue_Click(object sender, EventArgs e)
        {
           
        }

        /// <summary>
        /// Handles the click event of the Create Event button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        /// <summary>
        /// Handles the click event of the Create Event button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreateEvent_Click(object sender, EventArgs e)
        {
          
        }

        private void btnJoinEvent_Click_1(object sender, EventArgs e)
        {
            // Create a new form to host the JoiningForm UserControl
            Form hostForm = new Form();

            // Create and initialize the JoiningForm UserControl
            JoiningForm joiningForm = new JoiningForm();
            // Set properties for the host form
            hostForm.Text = "Join Event";
            // Center the form on the screen
            hostForm.StartPosition = FormStartPosition.CenterScreen;
            // Set the size of the form 
            hostForm.Size = new Size(900, 300);
            // Added the JoiningForm to the host form
            hostForm.Controls.Add(joiningForm);

            // Show the host form as a modal dialog (centered on the screen)
            hostForm.ShowDialog();
        }

        //private void btnReportIssue_Click_1(object sender, EventArgs e)
        //{
        //    // Open the report issue form
        //    using (var reportForm = new ReportIssueForm())
        //    {
        //        if (reportForm.ShowDialog() == DialogResult.OK)
        //        {
        //            // Handle the form submission and report the issue
        //            string issueDetails = reportForm.Description;
        //            string location = reportForm.Location;

        //            MessageBox.Show($"Issue reported successfully:\nDetails: {issueDetails}\nLocation: {location}",
        //                            "Issue Reported",
        //                            MessageBoxButtons.OK,
        //                            MessageBoxIcon.Information);
        //        }
        //    }
        //}
    }
}
