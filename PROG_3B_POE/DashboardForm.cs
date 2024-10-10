using PROG_3B_POE.Properties;
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
        public DateTime EventTime { get; set; }
        public string EventCategory { get; set; }
        public string EventLocation { get; set; }
        public string EventDescription { get; set; }

        public DashboardForm()
        {
            InitializeComponent();
        }

        private void AddMockEvents()
        {
            // Clear the flow layout panel first, if it contains any controls
           // flowLayoutPanel1.Controls.Clear();

            // Create the first mock event
            EventsList event1 = new EventsList();
            event1.EventName = "Food Festival";
            event1.EventImage = Resources.food_event;  
            event1.EventDate = DateTime.Now.AddDays(3);
            event1.EventTime = DateTime.Now.AddHours(15);  
            event1.EventLocation = "Cape Town";
            event1.EventDescription = "Join us for a day filled with delicious food and drinks at the Cape Town Food Festival.";
            flowLayoutPanel1.Controls.Add(event1);

            // Create the second mock event
            EventsList event2 = new EventsList();
            event2.EventName = "Music Concert";
            event2.EventImage = Resources.music_event;  
            event2.EventDate = DateTime.Now.AddDays(7);
            event2.EventTime = DateTime.Now.AddHours(18);  
            event2.EventLocation = "Johannesburg";
            event2.EventDescription = "Experience live performances by top artists at the Johannesburg Music Concert.";
            flowLayoutPanel1.Controls.Add(event2);

            // Create the third mock event
            EventsList event3 = new EventsList();
            event3.EventName = "Rugby Match";
            event3.EventImage = Resources.sport_event;  
            event3.EventDate = DateTime.Now.AddDays(14);
            event3.EventTime = DateTime.Now.AddHours(10); 
            event3.EventLocation = "Durban";
            event3.EventDescription = "Join us for an exciting rugby match at the Durban Sports Arena.";
            flowLayoutPanel1.Controls.Add(event3);
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
            EventDate = dtpEventDate.Value.Date; // Only select the date
            EventTime = dtpStartTime.Value;
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

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            AddMockEvents();
        }
    }
}
