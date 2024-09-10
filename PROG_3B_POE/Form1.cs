using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROG_3B_POE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Declaring the forms that will be used in the application
        /// </summary>
        ReportIssueForm reportForm;
        LocalEventsAnnouncementsForm localEventsForm;
        ServiceRequestForm serviceRequestForm;
        DashboardForm dashboardForm;


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLocalEventsAndAnnouncements_Click(object sender, EventArgs e)
        {

        }

        private void BtnDashboard_Click(object sender, EventArgs e)
        {

        }

        private void BtnServiceRequestService_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Button to open the report issue form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnRepoertIssue_Click(object sender, EventArgs e)
        {
            if (reportForm == null)
            {
                reportForm = new ReportIssueForm();
                reportForm.FormClosed += ReportForm_FormClosed;
               
                reportForm.MdiParent = this;                
                
                reportForm.Dock = DockStyle.Fill;
                reportForm.Show();
            }
            else
            {
                reportForm.Activate();
            }

        }
        /// <summary>
        /// This method is used to close the report issue form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ReportForm_FormClosed(object sender, FormClosedEventArgs e)
       {
            reportForm = null;
       }

        private void BtnLogout_Click(object sender, EventArgs e)
        {

        }

        bool sidebarExpand = true; // Indicates whether the sidebar is expanded or not

        private void btnHambugerButton_Click(object sender, EventArgs e)
        {
            // Toggle the sidebar visibility by starting the timer
            sideBarTransiction.Start();
        }

        private void sideBarTransiction_Tick(object sender, EventArgs e)
        {
            // Check whether to expand or collapse the sidebar
            if (sidebarExpand)
            {
                sidebarContainer.Width -= 10; // Shrink the sidebar width

                if (sidebarContainer.Width <= 60) // Sidebar fully collapsed
                {
                    sidebarExpand = false; // Set to collapsed state
                    sideBarTransiction.Stop(); // Stop the timer once it's fully collapsed

                    // Adjust button widths to match the sidebar's new width
                    AdjustButtonWidths(sidebarContainer.Width);
                }
            }
            else
            {
                sidebarContainer.Width += 10; // Expand the sidebar width

                if (sidebarContainer.Width >= 251) // Sidebar fully expanded
                {
                    sidebarExpand = true; // Set to expanded state
                    sideBarTransiction.Stop(); // Stop the timer once it's fully expanded

                    // Adjust button widths to match the sidebar's new width
                    AdjustButtonWidths(sidebarContainer.Width);
                }
            }
        }

        private void AdjustButtonWidths(int width)
        {
            // Adjust the buttons' width based on the current width of the sidebar
            BtnDashboard.Width = width;
            btnLocalEventsAndAnnouncements.Width = width;
            BtnServiceRequestService.Width = width;
            BtnRepoertIssue.Width = width;
            BtnLogout.Width = width;
        }



    }
}
