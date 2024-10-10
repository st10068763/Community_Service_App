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
    public partial class DashboardForm : Form
    {
        // Declare a public property to store the event details
        public string EventName { get; set; }
        public Image EventImage { get; set; }
        public DateTime EventDate { get; set; }
        public string EventCategory { get; set; }
        public string EventLocation { get; set; }
        public string EventDescription { get; set; }

        public DashboardForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // open file dialog that will allow the user to select an image file
            OpenFileDialog openFileDialog = new OpenFileDialog()
            {
                Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp;)|*.jpg; *.jpeg; *.gif; *.bmp;",
                Title = "Select an Image"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // set the image property to the selected image
                EventImage = Image.FromFile(openFileDialog.FileName);
                // display the selected image in the picture box
                pictureBox1.Image = EventImage;
            }
        }

        /// <summary>
        /// Handles the click event of the Create Event button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreateEvent_Click(object sender, EventArgs e)
        {
            // Gets the event details from the textboxes and date time picker
            EventName = txtName.Text;
            EventDate = dtpEventDate.Value;
            EventCategory = cbCategory.SelectedItem.ToString();
            EventLocation = txtLocation.Text;
            EventDescription = txtDescription.Text;

            // input validation for all fields
            if (string.IsNullOrWhiteSpace(EventName))
            {
                MessageBox.Show("Please enter a name for the event.");
                return;
            }
            if (EventImage == null)
            {
                MessageBox.Show("Please select an image for the event.");
                return;
            }
            if (string.IsNullOrWhiteSpace(EventCategory))
            {
                MessageBox.Show("Please select a category for the event.");
                return;
            }
            if (string.IsNullOrWhiteSpace(EventLocation))
            {
                MessageBox.Show("Please enter a location for the event.");
                return;
            }
            if (string.IsNullOrWhiteSpace(EventDescription))
            {
                MessageBox.Show("Please enter a description for the event.");
                return;
            }
            // Dialog box to confirm the event creation with event details
            DialogResult result = MessageBox.Show($"Event Name: {EventName}\nEvent Date: {EventDate}\nEvent Category: {EventCategory}\nEvent Location: {EventLocation}\nEvent Description: {EventDescription}", "Create Event", MessageBoxButtons.OKCancel);
            //this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
