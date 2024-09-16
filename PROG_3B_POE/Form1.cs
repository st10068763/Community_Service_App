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
        /// <summary>
        /// Declaring the forms that will be used in the application
        /// </summary>
        ReportIssueForm reportForm;
        LocalEventsAnnouncementsForm localEventsForm;
        ServiceRequestForm serviceRequestForm;
        DashboardForm dashboardForm;
        private int tourStep = 0;
        // Indicates whether the sidebar is expanded or not
        bool sidebarExpand = true;

        public Form1()
        {
            InitializeComponent();
            
        }
        //-----------------------------------METHODS TO LOAD THE FORMS-----------------------------------
        /// <summary>
        /// Method to load the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLocalEventsAndAnnouncements_Click(object sender, EventArgs e)
        {
            if (localEventsForm == null)
            {
                localEventsForm = new LocalEventsAnnouncementsForm();
                localEventsForm.FormClosed += LocalEventsForm_FormClosed;

                localEventsForm.MdiParent = this;

                localEventsForm.Dock = DockStyle.Fill;
                localEventsForm.Show();
            }
            else
            {
                localEventsForm.Activate();
            }
        }

        private void LocalEventsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            localEventsForm = null;
        }

        private void BtnDashboard_Click(object sender, EventArgs e)
        {
            if (dashboardForm == null)
            {
                dashboardForm = new DashboardForm();
                dashboardForm.FormClosed += DashboardForm_FormClosed;

                dashboardForm.MdiParent = this;

                dashboardForm.Dock = DockStyle.Fill;
                dashboardForm.Show();
            }
            else
            {
                dashboardForm.Activate();
            }
        }

        private void DashboardForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            dashboardForm = null;
        }

        private void BtnServiceRequestService_Click(object sender, EventArgs e)
        {
            if (serviceRequestForm == null)
            {
                serviceRequestForm = new ServiceRequestForm();
                serviceRequestForm.FormClosed += ServiceRequestForm_FormClosed;

                serviceRequestForm.MdiParent = this;

                serviceRequestForm.Dock = DockStyle.Fill;
                serviceRequestForm.Show();
            }
            else
            {
                serviceRequestForm.Activate();
            }
        }
        /// <summary>
        /// Method to close the service request form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ServiceRequestForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            serviceRequestForm = null;
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

        /// <summary>
        /// Close the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Method to handle the sidebar button click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnHambugerButton_Click(object sender, EventArgs e)
        {
            // Toggle the sidebar visibility by starting the timer
            sideBarTransiction.Start();           
        }

        //----------------------------------------------SIDE BAR TRANSITION-------------------------------------------------
        /// <summary>
        /// Method to handle the sidebar transition
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sideBarTransiction_Tick(object sender, EventArgs e)
        {
            // Check whether to expand or collapse the sidebar
            if (sidebarExpand)
            {
                sidebarContainer.Width -= 10; // Shrink the sidebar width

                if (sidebarContainer.Width <= 103) // Sidebar fully collapsed
                {
                    sidebarExpand = false; // Set to collapsed state
                    sideBarTransiction.Stop(); // Stop the timer once it's fully collapsed

                }
            }
            else
            {
                sidebarContainer.Width += 10; // Expand the sidebar width

                if (sidebarContainer.Width >= 303) // Sidebar fully expanded
                {
                    sidebarExpand = true; // Set to expanded state
                    sideBarTransiction.Stop(); // Stop the timer once it's fully expanded
                }
            }
        }
    }
}//-------------------------------------------------------------DingDong End of Code-------------------------------------------------------------//
