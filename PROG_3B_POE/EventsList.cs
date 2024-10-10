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
    public partial class EventsList : UserControl
    {
        public EventsList()
        {
            InitializeComponent();
        }

        // Local variables to store the event details
        private string _EventName;
        private Image _EventImage;
        private DateTime _EventDate;
        private string _EventCategory;
        private string _EventLocation;
        private string _EventDescription;
        //-----------------------GETTERS AND SETTERS-----------------------//
        [Category("Custom Props")]
        public string EventName
        {
            get { return _EventName; }
            set { _EventName = value; lbEventName.Text = value;}
        }
        [Category("Custom Props")]
        public Image EventImage
        {
            get { return _EventImage; }
            set { _EventImage = value; pictureBox1.Image = value; }
        }
        [Category("Custom Props")]
        public DateTime EventDate
        {
            get { return _EventDate; }
            set { _EventDate = value; lbEventDate.Text = value.ToShortDateString();}
        }
        [Category("Custom Props")]
        public string EventCategory
        {
            get { return _EventCategory; }
            set { _EventCategory = value; lbEventCategory.Text = value;}
        }
        [Category("Custom Props")]
        public string EventLocation
        {
            get { return _EventLocation; }
            set { _EventLocation = value; lbEventLocation.Text = value;}
        }
        [Category("Custom Props")]
        public string EventDescription
        {
            get { return _EventDescription; }
            set { _EventDescription = value; lbEventDescription.Text = value;}
        }
        //-----------------------GETTERS AND SETTERS-----------------------//
    }
}
