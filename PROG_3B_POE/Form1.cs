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
        ReportIssueForm reportIssueForm = new ReportIssueForm();

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

        private void BtnRepoertIssue_Click(object sender, EventArgs e)
        {
            if (reportIssueForm == null)
            {
                reportIssueForm = new ReportIssueForm();
                reportIssueForm.FormClosed += ReportIssueForm_FormClosed;
                reportIssueForm.MdiParent = this;
                reportIssueForm.Show();
            }
            else
            {
                reportIssueForm.Activate();
            }

        }

        private void ReportIssueForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            reportIssueForm = null;
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {

        }

        bool sidebarExpand = true;

        private void sideBarTransiction_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebarContainer.Width -= 10;
                if (sidebarContainer.Width <= 60)
                {
                    sidebarExpand = false;
                    sideBarTransiction.Stop();
                    // this will make the buttons in the sidebar to be the same width as the sidebar
                    BtnDashboard.Width = sidebarContainer.Width;
                    btnLocalEventsAndAnnouncements.Width = sidebarContainer.Width;
                    BtnServiceRequestService.Width = sidebarContainer.Width;
                    BtnRepoertIssue.Width = sidebarContainer.Width;
                    BtnLogout.Width = sidebarContainer.Width;
                }
            }
            else
            {
                sidebarContainer.Width += 5;
                if (sidebarContainer.Width >= 251)
                {
                    sidebarExpand = true;
                    sideBarTransiction.Stop();
                    // this is to make the buttons in the sidebar to be the same width as the sidebar
                    BtnDashboard.Width = sidebarContainer.Width;
                    btnLocalEventsAndAnnouncements.Width = sidebarContainer.Width;
                    BtnServiceRequestService.Width = sidebarContainer.Width;
                    BtnRepoertIssue.Width = sidebarContainer.Width;
                    BtnLogout.Width = sidebarContainer.Width;
                }
            }
        }

        private void btnHambugerButton_Click(object sender, EventArgs e)
        {
           sideBarTransiction.Start();
        }
    }
}
