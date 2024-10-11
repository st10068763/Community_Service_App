using System;
using System.ComponentModel;
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

        // Declaring the variables
        #region
        private string _eventName;
        private DateTime _eventDate;
        private string _eventLocation;
        private string _eventDescription;
        private Image _eventImage;
        private DateTime _eventTime;
        private string _eventCategory;

        //---------------------------Getters and Setters---------------------------//

        [Category("Custom Props")]
        public string EventName
        {
            get { return _eventName; }
            set { _eventName = value; lbEventName.Text = value; }
        }
        [Category("Custom Props")]
        public DateTime EventDate
        {
            get { return _eventDate; }
            set { _eventDate = value; lbEventDate.Text = value.ToString("d"); }
        }
        [Category("Custom Props")]
        public string EventLocation
        {
            get { return _eventLocation; }
            set { _eventLocation = value; lbLocation.Text = value; }
        }
        [Category("Custom Props")]
        public string EventDescription
        {
            get { return _eventDescription; }
            set { _eventDescription = value; lbEventDescription.Text = value; }
        }
        [Category("Custom Props")]
        public Image EventImage
        {
            get { return _eventImage; }
            set { _eventImage = value; eventImage.Image = value; }
        }
        [Category("Custom Props")]
        public DateTime EventTime
        {
            get { return _eventTime; }
            set { _eventTime = value; lbEventTime.Text = value.ToString("t"); }
        }
        [Category("Custom Props")]
        public string EventCategory
        {
            get { return _eventCategory; }
            set { _eventCategory = value; lbEventCategory.Text = value; }
        }
        #endregion
    }

}
