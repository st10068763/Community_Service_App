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
    public partial class JoiningForm : UserControl
    {
        public JoiningForm()
        {
            InitializeComponent();
        }

        /// <summary>
        ///  button click event that checks if the user has filled in all the fields
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string fullName = txtFullName.Text;
            string email = txtEmail.Text;
            string phone = txtPhoneNumber.Text;

          
            if (!string.IsNullOrEmpty(email) && !IsValidEmail(email))
            {
                MessageBox.Show("Please enter a valid email address");
                return;
            }

            if (string.IsNullOrEmpty(fullName))
            {
                MessageBox.Show("Please enter your full name");
                return;
            }

            if (phone.Length != 10)
            {
                MessageBox.Show("Please enter a valid phone number with 10 digits");
                return;
            }

            MessageBox.Show("Thank you for joining the event");

            // hides the form after the user has submitted their details
            this.Hide();
        }

        /// <summary>
        ///  Validates if the given email address is valid
        /// </summary>
        /// <param name="email">The email address to validate</param>
        /// <returns>True if the email address is valid, otherwise false</returns>
        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
    }
}
