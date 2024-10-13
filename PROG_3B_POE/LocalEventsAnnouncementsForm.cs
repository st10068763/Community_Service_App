using PROG_3B_POE.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROG_3B_POE
{
    public partial class LocalEventsAnnouncementsForm : Form
    {
        // List to store the events
        public List<EventsList> eventsList = new List<EventsList>();
        // Declare a public property to store the event details
        public string EventName { get; set; }
        public Image EventImage { get; set; }
        public DateTime EventDate { get; set; }
        public DateTime EventTime { get; set; }
        public string EventCategory { get; set; }
        public string EventLocation { get; set; }
        public string EventDescription { get; set; }


        public LocalEventsAnnouncementsForm()
        {
            InitializeComponent();

            dtpStartTime.CustomFormat = "HH:mm"; // Shows hours and minutes only
            dtpStartTime.ShowUpDown = true; // Allows user to scroll through time
        }

        private void DisplayEvents()
        {
            // Clear the flow layout to avoid duplicates
           // flowLayoutPanel1.Controls.Clear();

            // Loop through the centralized events list and display them
            foreach (var eventItem in eventsList)
            {
                // Create an instance of the user control and assign event details
                EventsList eventControl = new EventsList
                {
                    EventName = eventItem.EventName,
                    EventImage = eventItem.EventImage,
                    EventDate = eventItem.EventDate,
                    EventTime = eventItem.EventTime,
                    EventLocation = eventItem.EventLocation,
                    EventDescription = eventItem.EventDescription
                };

                // Add the event control to the flow layout panel
                flowLayoutPanel1.Controls.Add(eventControl);
            }
        }

        /// <summary>
        /// created a method to add mock events to the flow layout panel in the dashboard form and local events form
        /// </summary>
        public void AddMockEvents()
        {
            // Create mock events list
            List<EventsList> mockEventsList = new List<EventsList>
            {
            new EventsList
            {
                EventName = "Food Festival",
                EventCategory = "Food",
                EventImage = Resources.food_event,
                EventDate = DateTime.Now.AddDays(3),
                EventTime = DateTime.Now.AddHours(15),
                EventLocation = "Cape Town",
                EventDescription = "Join us for a day filled with delicious food and drinks at the Cape Town Food Festival."
            },
            new EventsList
            {
                EventName = "Music Concert",
                EventCategory = "Music",
                EventImage = Resources.music_event,
                EventDate = DateTime.Now.AddDays(7),
                EventTime = DateTime.Now.AddHours(18),
                EventLocation = "Johannesburg",
                EventDescription = "Experience live performances by top artists at the Johannesburg Music Concert."
            },
            new EventsList
            {
                EventName = "Rugby Match",
                EventCategory = "Sport",
                EventImage = Resources.sport_event,
                EventDate = DateTime.Now.AddDays(14),
                EventTime = DateTime.Now.AddHours(10),
                EventLocation = "Durban",
                EventDescription = "Join us for an exciting rugby match at the Durban Sports Arena."
            }
            };
            // Add mock events to the centralized event list
            eventsList.AddRange(mockEventsList);
            //return mockEventsList;
        }

        private void LocalEventsAnnouncementsForm_Load(object sender, EventArgs e)
        {
            // Add mock events once when the form loads
            if (!eventsList.Any())
            {
                AddMockEvents();
            }

            // Display all events (including mock events)
            DisplayEvents();
        }

        private void btnCreateEvent_Click_1(object sender, EventArgs e)
        {
            //---------------------input validation for all fields
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Please enter a name for the event.");
                return;
            }
            if (EventImage == null)
            {
                MessageBox.Show("Please select an image for the event.");
                return;
            }
            if (cbCategory.SelectedItem == null)
            {
                MessageBox.Show("Please select a category for the event.");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtLocation.Text))
            {
                MessageBox.Show("Please enter a location for the event.");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtDescription.Text))
            {
                MessageBox.Show("Please enter a description for the event.");
                return;
            }
            //-----------------------------------------------------------------

            // Create new event
            EventsList newEvent = new EventsList
            {
                EventName = txtName.Text,
                EventImage = EventImage,
                EventDate = dtpEventDate.Value.Date,
                EventTime = dtpStartTime.Value,
                EventCategory = cbCategory.SelectedItem.ToString(),
                EventLocation = txtLocation.Text,
                EventDescription = txtDescription.Text
            };

            // Add the new event to the list and refresh the display
            eventsList.Add(newEvent);
            DisplayEvents();

            // Dialog box to confirm the event creation with event details
            DialogResult result = MessageBox.Show($"Event Name: {txtName.Text}\nEvent Image: {EventImage}\nEvent Date: {dtpEventDate}\nEvent Category: {cbCategory}\nEvent Location: {txtLocation}\nEvent Description: {txtDescription}", "Create Event", MessageBoxButtons.OKCancel);
        }

        private void btnAddImage_Click_1(object sender, EventArgs e)
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
    }    
}
