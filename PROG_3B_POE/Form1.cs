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
            //InitializeDashboard();
            MessageTimer.Start();
            MessageTimer = new Timer();
            MessageTimer.Interval = 10000; // Set to 10 seconds
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

        //private void InitializeDashboard()
        //{
          
        //        // Initialize the timer
        //        MessageTimer = new Timer();
        //        MessageTimer.Interval = 10000; // Set to 10 seconds
        //        MessageTimer.Start();
        //       // MessageTimer.Tick += new EventHandler(MessageTimer_Tick);
        //        MessageBox.Show("Welcome to the Service Request Management System\n" +
        //            "\nThis application is designed to help you manage your service requests\n" +
        //            "\nPlease use the buttons on the left to navigate through the application\n" +
        //            "\nHave a nice day", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        MessageTimer.Stop();
          
        //}
            
        private void MessageTimer_Tick(object sender, EventArgs e)
        {
            // Initialize the timer
            
            
            // MessageTimer.Tick += new EventHandler(MessageTimer_Tick);
            MessageBox.Show("Welcome to the Service Request Management System\n" +
                "\nThis application is designed to help you manage your service requests\n" +
                "\nPlease use the buttons on the left to navigate through the application\n" +
                "\nHave a nice day", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MessageTimer.Stop();

        }

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

        private void BtnLogout_Click(object sender, EventArgs e)
        {

        }

        bool sidebarExpand = true; // Indicates whether the sidebar is expanded or not

        private void btnHambugerButton_Click(object sender, EventArgs e)
        {
            // Toggle the sidebar visibility by starting the timer
            sideBarTransiction.Start();
        }

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

                if (sidebarContainer.Width <= 73) // Sidebar fully collapsed
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

                if (sidebarContainer.Width >= 283) // Sidebar fully expanded
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
