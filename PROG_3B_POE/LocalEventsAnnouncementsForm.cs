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
            dtpStartTime.ShowUpDown = true; // Allows user to scroll through time
        }

        /// <summary>
        /// Method to display events in the flow layout panel
        /// </summary>
        private void DisplayEvents()
        {
            // Clear the flow layout to avoid duplicates
            flowLayoutPanel1.Controls.Clear();

            // Loop through the centralized events list and display them
            foreach (var eventItem in eventsList)
            {
                // Create an instance of the user control and assign event details
                EventsList eventControl = new EventsList
                {
                    EventName = eventItem.EventName,
                    EventCategory = eventItem.EventCategory,
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

        /// <summary>
        /// Button to create a new event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreateEvent_Click_1(object sender, EventArgs e)
        {
            // Ensure the ComboBox has a valid selection
            if (cbCategory.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a valid event category.");
                return;
            }

            // Capture the selected category after validation
          //  string selectedCategory = cbCategory.SelectedItem.ToString();

            // Input validation for all fields
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
            DialogResult result = MessageBox.Show($"Event Name: {txtName.Text}\n" +
                                                   $"Event Image: {EventImage}\n" +
                                                   $"Event Date: {dtpEventDate.Value.Date}\n" + // Use .Date to get just the date
                                                   $"Event Category: {cbCategory.SelectedItem}\n" + // Show the selected category
                                                   $"Event Location: {txtLocation.Text}\n" + // Changed to .Text
                                                   $"Event Description: {txtDescription.Text}", // Changed to .Text
                                                   "Create Event",
                                                   MessageBoxButtons.OKCancel);
        }


        /// <summary>
        /// Button click event to add an image to the event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        //------------------------------Event filter methods---------------------------------//
        /// <summary>
        /// Method to filter events based on the search input, category, and date
        /// </summary>
        private void EventFilter()
        {
            // Get category selection and date selection
            string categoryInput = cbFilter.SelectedItem?.ToString().ToLower(); // Ensure case insensitivity for category
            DateTime? selectedDate = dateFilter.Checked ? dateFilter.Value.Date : (DateTime?)null;

            // Filter the events based on the category and date, even if the search box is empty
            var filteredEvents = eventsList.Where(x =>
                (string.IsNullOrEmpty(categoryInput) || x.EventCategory.ToLower() == categoryInput) && // Compare categories in lowercase
                (!selectedDate.HasValue || x.EventDate.Date == selectedDate.Value.Date) // Filter by date if selected
            ).ToList();

            // Display the filtered events
            DisplayFilteredEvents(filteredEvents);
        }

        private void SearchEvents()
        {
            // Get search input
            string searchInput = txtSearch.Text.ToLower().Trim();

            // If the user provided search input, filter events by event name
            if (!string.IsNullOrEmpty(searchInput))
            {
                var searchedEvents = eventsList.Where(x => x.EventName.ToLower().Contains(searchInput)).ToList();
                DisplayFilteredEvents(searchedEvents);
            }
            else
            {
                // Display all events if search input is empty
                DisplayEvents();
            }
        }

        /// <summary>
        /// Method to display the filtered events in the flow layout panel
        /// </summary>
        /// <param name="filteredEvents"></param>
        private void DisplayFilteredEvents(List<EventsList> filteredEvents)
        {
            // Clear the flow layout to avoid duplicates
            flowLayoutPanel1.Controls.Clear();

            // Loop through the filtered events and display them
            foreach (var eventItem in filteredEvents)
            {
                // Create an instance of the user control and assign event details
                EventsList eventControl = new EventsList
                {
                    EventName = eventItem.EventName,
                    EventCategory = eventItem.EventCategory,
                    EventImage = eventItem.EventImage,
                    EventDate = eventItem.EventDate,
                    EventTime = eventItem.EventTime,
                    EventLocation = eventItem.EventLocation,
                    EventDescription = eventItem.EventDescription
                };

                // Add the event control to the flow layout panel
                flowLayoutPanel1.Controls.Add(eventControl);
            }

            // If no events match the filter, display a message or handle it as needed
            if (!filteredEvents.Any())
            {
                MessageBox.Show("No events match your search criteria.");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // Check if the search textbox is empty
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                // Show a message if search is empty
                MessageBox.Show("Please enter something in the search box.");
            }
            else
            {
                SearchEvents();
            }
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            EventFilter();
        }

        private void dateFilter_ValueChanged(object sender, EventArgs e)
        {
            EventFilter();
        }
    }
}
