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

        bool sidebartoggle = true;
        bool menuExpand = false;


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
                }
            }
            else
            {
                sidebarContainer.Width += 10;
                if (sidebarContainer.Width >= 220)
                {
                    sidebarExpand = true;
                    sideBarTransiction.Stop();
                }
            }
        }

        private void btnHambugerButton_Click(object sender, EventArgs e)
        {
           sideBarTransiction.Start();
        }
    }
}
