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
    public partial class LocalEventsAnnouncementsForm : Form
    {
        //-------------List of events
        //private List<EventsList> eventsList = new List<EventsList>();

        public LocalEventsAnnouncementsForm()
        {
            InitializeComponent();
        }

        private void LocalEventsAnnouncementsForm_Load(object sender, EventArgs e)
        {
            // shows the mock events
            AddMockEvents();

            // Displays the list of events
            EventListItems();
        }

        private void AddMockEvents()
        {
            EventsList[] EventsList = new EventsList[5];

            for(int i = 0; i < EventsList.Length; i++)
            {
                EventsList[i] = new EventsList();
                EventsList[i].EventName = "Food Event " + i;
                EventsList[i].EventImage = Resources.food_event;
                EventsList[i].EventDate = DateTime.Now.AddDays(i);
                EventsList[i].EventCategory = "Time out Food Market";
                EventsList[i].EventLocation = "Cape Town";
                EventsList[i].EventDescription = "Cape town food event that will take place at the food market.";


                flowLayoutPanel1.Controls.Clear();
                // Add the event to the list of events
                flowLayoutPanel1.Controls.Add(EventsList[i]);
            }

            //// Create and add mock event data
            //EventsList mockEvent = new EventsList
            //{
            //    EventName = "Food Event",
            //    EventImage = Resources.food_event,  // Ensure you have an image in Resources
            //    EventDate = DateTime.Now.AddDays(10),  // Mock future event date
            //    EventCategory = "Time out Food Market",
            //    EventLocation = "Cape Town",
            //    EventDescription = "Cape town food event that will take place at the food market."
            //};

           // eventsList.Add(mockEvent);
        }

        private void EventListItems()
        {
            // Clear any existing controls from the flow layout panel before adding new ones
            flowLayoutPanel1.Controls.Clear();

            // using a loop to loop through the list of events and add each event to the list
            foreach(var eventItem in eventsList)
            {
                flowLayoutPanel1.Controls.Add(eventItem);
            }

        }

        private void btnAddNewEvent_Click(object sender, EventArgs e)
        {
            // Open the CreateEventForm to allow the user to add a new event
            DashboardForm dashboardForm  = new DashboardForm();
            if (dashboardForm.ShowDialog() == DialogResult.OK)
            {
                // Create a new instance of EventsList and populate it with the data from CreateEventForm
                EventsList newEvent = new EventsList
                {
                    EventName = dashboardForm.EventName,
                    EventDate = dashboardForm.EventDate,
                    EventCategory = dashboardForm.EventCategory,
                    EventLocation = dashboardForm.EventLocation,
                    EventDescription = dashboardForm.EventDescription,
                    EventImage = dashboardForm.EventImage  // Use the image selected by the user
                };

                // Add the new event to the event list
                eventsList.Add(newEvent);

                // Refresh the event list display
                EventListItems();
            }
        }
    }
    
}
