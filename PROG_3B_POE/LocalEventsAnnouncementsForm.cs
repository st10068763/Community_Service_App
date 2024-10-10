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
        private List<EventsList> eventsList = new List<EventsList>();

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
                EventsList[i].EventLocation = "Cape Town";
                EventsList[i].EventDescription = "Cape town food event that will take place at the food market.";


                flowLayoutPanel1.Controls.Clear();
                // Add the event to the list of events
                flowLayoutPanel1.Controls.Add(EventsList[i]);
            }

            // Create and add mock event data
            EventsList mockEvent = new EventsList
            {
                EventName = "Food Event",
                EventImage = Resources.food_event,  
                EventDate = DateTime.Now.AddDays(10),
                EventLocation = "Cape Town",
                EventDescription = "Cape town food event that will take place at the food market."
            };

            eventsList.Add(mockEvent);
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
    }    
}
