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
        public LocalEventsAnnouncementsForm()
        {
            InitializeComponent();
        }

        private void LocalEventsAnnouncementsForm_Load(object sender, EventArgs e)
        {
           
        }

        private void EventListItems()
        {
            // Clear any existing controls from the flow layout panel before adding new ones
            flowLayoutPanel1.Controls.Clear();

            // Create an array of 15 EventsList user controls
            EventsList[] listItems = new EventsList[15];

            // Loop through the listItems array to create and configure each unique event
            for (int i = 0; i < listItems.Length; i++)
            {
                // Create a new instance of the EventsList user control
                listItems[i] = new EventsList();

                // Set unique properties for each event
                listItems[i].EventName = "Event Name " + (i + 1);
                listItems[i].EventDate = DateTime.Now.AddDays(i); // Unique date for each event
                listItems[i].EventCategory = i % 2 == 0 ? "Music" : "Art"; // Alternate between two categories
                listItems[i].EventLocation = "Location " + (i + 1);
                listItems[i].EventDescription = "This is a unique description for event " + (i + 1) + ".";

                // Add the user control to the flow layout panel
                flowLayoutPanel1.Controls.Add(listItems[i]);
            }
        }

        private void LocalEventsAnnouncementsForm_Load_1(object sender, EventArgs e)
        {
            EventListItems();
        }
    }
}
