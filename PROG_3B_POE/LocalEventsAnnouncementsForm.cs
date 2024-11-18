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
        /// <summary>
        /// Declare a stack to store the recently viewed events
        /// </summary>
        Stack<EventsList> recentViewedEvents = new Stack<EventsList>();
        /// <summary>
        /// Queue to store the upcoming events
        /// </summary>
        Queue<EventsList> upcomingEvents = new Queue<EventsList>();
        /// <summary>
        /// Using a SortedDictionary to store the priority events based on the event date
        /// </summary>
        SortedDictionary<DateTime, List<EventsList>> priorityEvents = new SortedDictionary<DateTime, List<EventsList>>();
        /// <summary>
        /// Using a Dictionary to store events with event name as the key
        /// </summary>
        Dictionary<string, EventsList> eventsDictionary = new Dictionary<string, EventsList>();
        /// <summary>
        /// List to store event categories the user has joined
        /// </summary>
        private List<string> joinedEventCategories = new List<string>();

        public LocalEventsAnnouncementsForm()
        {
            InitializeComponent();
            // Allows user to scroll through time
            dtpStartTime.ShowUpDown = true;
            DisplayPrioritizedEvents();
        }

        /// <summary>
        /// Method to track viewed events and display recommendations
        /// </summary>
        /// <param name="eventItem"></param>
        private void TrackViewedEvents(EventsList eventItem)
        {
            // will push the recently viewed event onto the stack
            recentViewedEvents.Push(eventItem);
            // removes the oldest viewed event from the stack and keeps the stack size to 5
            if (recentViewedEvents.Count > 5)
            {
                recentViewedEvents.Pop();
            }
        }

        //--------------------------------------------//
        /// <summary>
        /// Method to display the recommended events
        /// </summary>
        private void DisplayRecommendations()
        {
            var recommendedEvents = new List<EventsList>();

            // Check if user has joined any events
            if (joinedEventCategories.Any())
            {
                // Filter events by categories the user has joined and avoid recommending the same event they joined
                recommendedEvents = eventsList.Where(x =>
                    joinedEventCategories.Contains(x.EventCategory) &&
                    !recentViewedEvents.Any(e => e.EventName == x.EventName) // Avoid recommending events already joined
                ).ToList();
            }

            // Display the recommended events (you can use your existing method)
            DisplayFilteredEvents(recommendedEvents);

            // Check if there are recommended events
            if (recommendedEvents.Any())
            {
                // Get the first recommended event
                var joinedEvent = recommendedEvents.First();

                // Show a message confirming the user joined the event
                MessageBox.Show($"You have successfully joined the event: {joinedEvent.EventName} in the category: {joinedEvent.EventCategory}");
            }
        }

        /// <summary>
        /// Method to handle when a user joins an event
        /// </summary>
        private void JoinEvent(EventsList eventItem)
        {
            // Add the event category to the list of joined event categories if not already added
            if (!joinedEventCategories.Contains(eventItem.EventCategory))
            {
                joinedEventCategories.Add(eventItem.EventCategory);
            }

            // Optionally, display a message confirming the user joined the event
            MessageBox.Show($"You have successfully joined the event: {eventItem.EventName} in the category: {eventItem.EventCategory}");

            // Update recommendations after joining an event
            DisplayRecommendations();
        }

        /// <summary>
        /// Will display the upcoming events
        /// </summary>
        private void DisplayUpcomingEvents()
        {
            // Get the current date
            DateTime today = DateTime.Now;

            // Filter events that are 7 days or less from today
            var upcomingSoonEvents = eventsList
                .Where(e => (e.EventDate - today).TotalDays <= 7 && (e.EventDate - today).TotalDays >= 0)
                .ToList();

            if (upcomingSoonEvents.Count > 0)
            {
                // Display all the upcoming events within 7 days
                StringBuilder message = new StringBuilder();
                foreach (var eventItem in upcomingSoonEvents)
                {
                    message.AppendLine($"Upcoming Event: {eventItem.EventName}");
                    message.AppendLine($"Date: {eventItem.EventDate.ToShortDateString()}");
                    message.AppendLine($"Time: {eventItem.EventTime.ToShortTimeString()}");
                    message.AppendLine($"Location: {eventItem.EventLocation}");
                    message.AppendLine($"Description: {eventItem.EventDescription}");
                    message.AppendLine();
                }
                MessageBox.Show(message.ToString(), "Upcoming Events", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Show message if there are no events within the next 7 days
                MessageBox.Show("No upcoming events in the next 7 days.", "Upcoming Events", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Method to display prioritized events
        /// </summary>
        private void DisplayPrioritizedEvents()
        {
            // Clear existing controls in the flow layout
            flowLayoutPanel1.Controls.Clear();

            // Loop through the SortedDictionary to display events sorted by date
            foreach (var dateEntry in priorityEvents)
            {
                foreach (var eventItem in dateEntry.Value)
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

                    // Add click event for the event control
                    eventControl.Click += (s, e) =>
                    {
                        // Track the viewed event
                        TrackViewedEvents(eventItem);

                        // Display event details
                        MessageBox.Show($"Event: {eventItem.EventName}\n" +
                            $"Category: {eventItem.EventCategory}\n" +
                            $"Location: {eventItem.EventLocation}\n" +
                            $"Date: {eventItem.EventDate.ToShortDateString()}");

                        // Update recommendations
                        DisplayRecommendations();
                    };

                    // Add the event control to the flow layout panel
                    flowLayoutPanel1.Controls.Add(eventControl);
                }
            }
        }


        private void PrioritizeEvents()
        {
            priorityEvents.Clear();
            // Sort the events by date
            foreach (var eventItem in eventsList)
            {
                if (!priorityEvents.ContainsKey(eventItem.EventDate.Date))
                {
                    priorityEvents[eventItem.EventDate.Date] = new List<EventsList>();
                }

                priorityEvents[eventItem.EventDate.Date].Add(eventItem);
            }
        }

        private void AddEventsToDictionary()
        {
            foreach (var eventItem in eventsList)
            {
                if (!eventsDictionary.ContainsKey(eventItem.EventName))
                {
                    // Add the event to the dictionary with the event name as the key
                    eventsDictionary.Add(eventItem.EventName, eventItem);
                }
            }                       
        }

        private void SearchEventsInDictionary(string eventName)
        {
            if (eventsDictionary.ContainsKey(eventName))
            {
                var eventItem = eventsDictionary[eventName];
                MessageBox.Show($"Event Name: {eventItem.EventName}" +
                $"\nDate: {eventItem.EventDate.ToShortDateString()}" +
                $"\nTime: {eventItem.EventTime.ToShortTimeString()}" +
                $"\nLocation: {eventItem.EventLocation}" +
                $"\nDescription: {eventItem.EventDescription}" +
                $"", "Search Event", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Event not found.", "Search Event", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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

                // Add click event for the event control
                eventControl.Click += (s, e) =>
                {
                    // Track the viewed event
                    TrackViewedEvents(eventItem);

                    // You can also display event details when clicked
                    MessageBox.Show($"Event: {eventItem.EventName}\n" +
                        $"Category: {eventItem.EventCategory}\n" +
                        $"Location: {eventItem.EventLocation}\n" +
                        $"Date: {eventItem.EventDate.ToShortDateString()}");

                    // Optionally, update the recommendations
                    DisplayRecommendations();
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
            // Prioritize the events after loading
            PrioritizeEvents();

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
            // add event to the dictionary
            AddEventsToDictionary();
            // Display the events
            DisplayEvents();

            // Dialog box to confirm the event creation with event details
            DialogResult result = MessageBox.Show($"Event Name: {txtName.Text}\n" +
                                                   $"Event Image: {EventImage}\n" +
                                                   $"Event Date: {dtpEventDate.Value.Date}\n" + 
                                                   $"Event Category: {cbCategory.SelectedItem}\n" + 
                                                   $"Event Location: {txtLocation.Text}\n" +
                                                   $"Event Description: {txtDescription.Text}", 
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
        private void CategoryFilter()
        {
            // Get category selection and date selection
            string categoryInput = cbFilter.SelectedItem?.ToString().ToLower(); // Ensure case insensitivity for category

            // Filter the events based on the category selected
            var filteredEvents = eventsList.Where(x =>
                (string.IsNullOrEmpty(categoryInput) || x.EventCategory.ToLower() == categoryInput)).ToList();

            // Display the filtered events
            DisplayFilteredEvents(filteredEvents);
        }

        /// <summary>
        /// Method to filter the events by date
        /// </summary>
        private void DateFilter()
        {
            DateTime? selectedDate = dateFilter.Checked ? dateFilter.Value.Date : (DateTime?)null;

            var DateFilter = eventsList.Where(x =>
            (!selectedDate.HasValue || x.EventDate.Date == selectedDate.Value.Date)).ToList(); // Filter by date if selected
            // Displays the event happening for the selected date
            DisplayFilteredEvents(DateFilter);
        }
        //----------------------------------------------Search function -------------------------------------------------//
       
        /// <summary>
        /// Method to display the filtered events in the flow layout panel
        /// </summary>
        /// <param name="filteredEvents"></param>
        private void DisplayFilteredEvents(List<EventsList> filteredEvents)
        {
            // Clear the flow layout to avoid duplicates
            flowLayoutPanel1.Controls.Clear();

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
        }
        /// <summary>
        /// Button click event to search for events
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                // Search events when the button is clicked
                SearchEventsInDictionary(txtSearch.Text);
            }
        }
        /// <summary>
        /// Button to filter events based on the category
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            CategoryFilter();
        }
        /// <summary>
        /// Button to filter events based on the date
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dateFilter_ValueChanged(object sender, EventArgs e)
        {
            DateFilter();
        }
        //------------------------------------------------------------------------------------------------------------//
        private void btnRecommendations_Click(object sender, EventArgs e)
        {
            DisplayRecommendations();

            // Call the prioritize method when the user clicks a button
            PrioritizeEvents();
            // Optionally, refresh the display to show prioritized events
            //DisplayEvents();
        }

        private void btnUpcomingEvents_Click(object sender, EventArgs e)
        {
            DisplayUpcomingEvents();
        }


        private void ClearFilters()
        {
            // Reset search textbox
            txtSearch.Text = string.Empty;

            // Reset category combo box
            cbFilter.SelectedIndex = -1;

            // Reset date filter
            dateFilter.Checked = false;

            // Redisplay all events
            DisplayEvents();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ClearFilters();
        }
    }
}
