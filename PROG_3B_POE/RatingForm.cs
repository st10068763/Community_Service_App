using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROG_3B_POE
{
    public partial class RatingForm : Form
    {
        public RatingForm()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Displays a message box with the rating if the user select a rating from 1 to 3 stars and 4 to 5 stars the user will get a different message
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRate_Click(object sender, EventArgs e)
        {
            int rating = 0;

            
            if (rb1.Checked)
            {
                rating = 1;
            }
            else if (rb2.Checked)
            {
                rating = 2;
            }
            else if (rb3.Checked)
            {
                rating = 3;
            }
            else if (rb4.Checked)
            {
                rating = 4;
            }
            else if (rb5.Checked)
            {
                rating = 5;
            }

            switch (rating)
            {
                case 1:
                case 2:
                case 3:
                    MessageBox.Show("Thank you for your rating! We're sorry your experience wasn't the best. We'll strive to do better.");
                break;

                case 4:
                case 5:
                    MessageBox.Show("Thank you for your rating! We're glad you had a great experience!");
                break;
                                   
            }

            // closes the form
            this.Close();

        }
    }
}
