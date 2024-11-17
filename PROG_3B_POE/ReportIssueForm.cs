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
    public partial class ReportIssueForm : Form
    {
        /// <summary>
        /// Using a binding list to store the issue reports
        /// </summary>
        public static BindingList<IssueReport> issues = new BindingList<IssueReport>();
         
        //Variable to track if it is the first time the form is loaded
        private bool firstTime = true;

        // Declare a public property to store the event details
        public Image Attachment { get; set; }
        public string Category { get; set; }
        public string Location { get; set; }
        public string Description { get; set; }

        public ReportIssueForm()
        {
            InitializeComponent();

            // initialize the timer
            Timer timer = new Timer();
            timer.Interval = 100; // 1 millisecond
            timer.Tick += new EventHandler(Timer_Tick);
            timer.Start();
            // Call the method to add mock reports
            AddMockEvents();
            // calls the method to show date and time
            ShowDateAndTime(this, EventArgs.Empty);
        }
        /// <summary>
        /// Class to store the issue details
        /// </summary>
        public class IssueReport
        {
            // Declare the properties of the IssueReport class
            public Guid Id { get; set; } = Guid.NewGuid();
            public string Location { get; set; }
            public string Category { get; set; }
            public string Description { get; set; }
            public Image Attachment { get; set; }
            // Default status of the reports is pending
            public string Status { get; set; } = "Pending";

        }
        /// <summary>
        /// Method to load the form and set the progress bar to 0
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ReportIssueForm_Load(object sender, EventArgs e)
        {
            progressBar.Value = 0;
            // Add event handlers for user input fields
            txtDescription.TextChanged += txtDescription_TextChanged;
            textLocation.TextChanged += textLocation_TextChanged;
            CategoryListBx.SelectedIndexChanged += CategoryListBx_SelectedIndexChanged;
        }
        //--------------------------------------ADD FILE BUTTON------------------------------------------
        /// <summary>
        /// Method to display date and time in the report
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ShowDateAndTime(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            lbDateAndTime.Text = dateTime.ToString();
        }

        // Event handler for the timer tick event
        private void Timer_Tick(object sender, EventArgs e)
        {
            // Call the ShowDateAndTime method to update the date and time display
            ShowDateAndTime(this, EventArgs.Empty);
        }

        //--------------------------------------USER INPUT TRACKER/ PROGRESS BAR------------------------------------------
        /// <summary>
        /// method to track user form field input
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtDescription_TextChanged(object sender, EventArgs e)
        {
            // Call the UpdateProgress method to update the progress bar
            UpdateProgress();
        }
        /// <summary>
        /// Event handler for the textLocation_TextChanged event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textLocation_TextChanged(object sender, EventArgs e)
        {
            // Call the UpdateProgress method to update the progress bar
            UpdateProgress();
        }
        /// <summary>
        /// Changes the progress bar value based on the selected category
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CategoryListBx_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateProgress();
        }
        //--------------------------------------PROGRESS BAR------------------------------------------
        /// <summary>
        ///  Method to calculate and update progress bar based on filled fields
        /// </summary>
        private void UpdateProgress()
        {
            // List of required fields to check
            var requiredFields = new List<bool>
            {
                // Check if each field is filled if it is not empty return true
                !string.IsNullOrEmpty(txtDescription.Text), 
                !string.IsNullOrEmpty(textLocation.Text),      
                !string.IsNullOrEmpty(CategoryListBx.Text),    
                AttachedPictureBox.Image != null               
            };

            // Calculate progress based on how many fields are filled
            int filledFieldsCount = requiredFields.Count(f => f); 
            // Total number of required fields
            int totalFields = requiredFields.Count;
            // Calculate progress percentage
            int progressPercentage = (filledFieldsCount * 100) / totalFields;
            // Update progress bar value
            progressBar.Value = progressPercentage;
        }
        //---------------------------------------REPORT ISSUE---------------------------------------
        /// <summary>
        /// Button to submit the report and display the report in the grid view
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSubmitReport_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Display rating form on first time submission
                if (firstTime)
                {
                    //creating a new instance of rating from 
                    RatingForm ratingForm = new RatingForm();
                    ratingForm.ShowDialog();
                    firstTime = false;
                }

                // Checking if all the fields are filled
                if (txtDescription.Text == "" || textLocation.Text == "" || CategoryListBx.Text == "")
                {
                    MessageBox.Show("Please fill in all the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Return early to prevent further execution
                }

                // Success message
                MessageBox.Show("Your " + CategoryListBx.Text + " issue has been reported.\n" +
                    " Thank you for your feedback.", "Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Create a new IssueReport object and populate it with user input
                IssueReport issue = new IssueReport
                {
                    Description = txtDescription.Text,
                    Location = textLocation.Text,
                    Category = CategoryListBx.Text,
                    Attachment = AttachedPictureBox.Image
                };
                // Add the report issue to the list of issues
                issues.Add(issue);
                // Create a new ReportControl and populate it with the issue details
                ReportControl reportControl = new ReportControl
                {
                    EventCategory = issue.Category,
                    Location = issue.Location,
                    Description = issue.Description,
                    ReportImage = issue.Attachment
                };
                // Add the reportControl to the form's panel (flowLayoutPanel1)
                flowLayoutPanel1.Controls.Add(reportControl);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // Clear the input fields after submission
            txtDescription.Text = "";
            textLocation.Text = "";
            CategoryListBx.SelectedIndex = -1; // Reset selection
            AttachedPictureBox.Image = null;
            // Reset the progress bar after submission
            progressBar.Value = 0;
        }
        //-----------------------------------------END OF REPORT ISSUE---------------------------------------
        /// <summary>
        /// Button to add a file to the report
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddFile_Click_1(object sender, EventArgs e)
        {
            /// using try catch block to handle exceptions
            try
            {
                // Configure the openFileDialog1 settings
                openFileDialog1.Filter = "Document Files|*.docx;*.pdf;*.txt|Image Files|*.jpg;*.jpeg;*.png|All Files|*.*";
                openFileDialog1.Title = "Select a Document or Image";

                // Show the dialog and check if a file was selected
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog1.FileName; // Get the file path

                    // Optionally handle different file types 
                    string fileExtension = System.IO.Path.GetExtension(filePath).ToLower();

                    // Handle text files
                    if (fileExtension == ".txt")
                    {
                        string readFile = System.IO.File.ReadAllText(filePath); // Read the text file
                        MessageBox.Show("File content: " + readFile, "Text File Content", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    // Handle document and image files (you can add more handling here as needed)
                    else if (fileExtension == ".jpg" || fileExtension == ".jpeg" || fileExtension == ".png")
                    {
                        // Display image in a PictureBox as a preview
                        AttachedPictureBox.Image = Image.FromFile(filePath);
                    }
                    // Update progress based on file being added
                    UpdateProgress();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Method that contains all the mock reports that are added to the list
        /// </summary>
        public void AddMockEvents()
        {
            List<IssueReport> mockEvents = new List<IssueReport>
            {
                new IssueReport
                {
                    Category = "Crime",
                    Attachment = Resources.logo,
                    Location = "Johannesburg",
                    Description = "Reported a theft incident in the civic area."
                },
                new IssueReport
                {
                    Category = "Electricity",
                    Attachment = Resources.logo,
                    Location = "Cape Town",
                    Description = "Power outage in several neighborhoods."
                },
                new IssueReport
                {
                    Category = "Others",
                    Attachment = Resources.logo,
                    Location = "Rosebank",
                    Description = "Noise complaints from a local park."
                },
                new IssueReport
                {
                    Category = "Road",
                    Attachment = Resources.logo,
                    Location = "Limpopo",
                    Description = "Road construction causing traffic congestion."
                },
                new IssueReport
                {
                    Category = "Safety",
                    Attachment = Resources.logo,
                    Location = "Newlands",
                    Description = "Unsafe pedestrian crossing near a primary school."
                },
                new IssueReport
                {
                    Category = "Sanitation",
                    Attachment = Resources.logo,
                    Location = "KZN",
                    Description = "Overflowing garbage bins in a residential area."
                },
                new IssueReport
                {
                    Category = "Utilities",
                    Attachment = Resources.logo,
                    Location = "Polokwane",
                    Description = "Water supply disruption in a suburb."
                },
                new IssueReport
                {
                    Category = "Weather",
                    Attachment = Resources.logo,
                    Location = "Pretoria",
                    Description = "Heavy rain causing flooding in low-lying areas."
                },
                new IssueReport
                {
                    Category = "Crime",
                    Attachment = Resources.logo,
                    Location = "New Castle",
                    Description = "Vandalism reported in a public park."
                },
                new IssueReport
                {
                    Category = "Electricity",
                    Attachment = Resources.logo,
                    Location = "Gauteng",
                    Description = "Transformer explosion causing power outage."
                },
                new IssueReport
                {
                    Category = "Others",
                    Attachment = Resources.logo,
                    Location = "Cavendish",
                    Description = "Illegal parking issue near a shopping mall."
                },
                new IssueReport
                {
                    Category = "Road",
                    Attachment = Resources.logo,
                    Location = "Mowbray",
                    Description = "Potholes causing damage to vehicles."
                },
                new IssueReport
                {
                    Category = "Safety",
                    Attachment = Resources.logo,
                    Location = "Cape Town City",
                    Description = "Broken streetlights in a residential area."
                },
                new IssueReport
                {
                    Category = "Sanitation",
                    Attachment = Resources.logo,
                    Location = "Rondebosch",
                    Description = "Sewage leak reported in a public park."
                },
                new IssueReport
                {
                    Category = "Utilities",
                    Attachment = Resources.logo,
                    Location = "Rondebosch",
                    Description = "Gas leak reported in a commercial building."
                },
                new IssueReport
                {
                    Category = "Weather",
                    Attachment = Resources.logo,
                    Location = "Kempton Park",
                    Description = "Sandstorm causing visibility issues on the roads."
                },

                new IssueReport
                {
                    Category = "Weather",
                    Attachment = Resources.logo,
                    Location = "Spartan",
                    Description = "Sandstorm causing visibility issues on the roads."
                }
            };
            
            // Add the mock events to the issues list and display them in the flowLayoutPanel
            foreach (var issue in mockEvents)
            {
                // Add the issue to the list
                issues.Add(issue);
                ReportControl reportControl = new ReportControl
                {
                    EventCategory = issue.Category,
                    Location = issue.Location,
                    Description = issue.Description,
                    ReportImage = issue.Attachment
                };
                // Add the reportControl to the form's panel.
                flowLayoutPanel1.Controls.Add(reportControl);
            }
        }
                
    }
}//-------------------------------------------------------------DingDong End of Code-------------------------------------------------------------//
