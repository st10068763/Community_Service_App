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
        private bool firstTime = true;

        public ReportIssueForm()
        {
            InitializeComponent();
        }

        //List<IssueReport> issues = new List<IssueReport>();

        /// <summary>
        /// Using a binding list to store the issue reports
        /// </summary>
        BindingList<IssueReport> issues = new BindingList<IssueReport>();

        /// <summary>
        /// Class to store the issue details
        /// </summary>
        public class IssueReport
        {
            public string Location { get; set; }
            public string Category { get; set; }
            public string Description { get; set; }
            public Image Attachment { get; set; }
        }

        private void ReportIssueForm_Load(object sender, EventArgs e)
        {
            progressBar.Value = 0;
            // Add event handlers for user input fields
            txtDescription.TextChanged += txtDescription_TextChanged;
            textLocation.TextChanged += textLocation_TextChanged;
            CategoryListBx.SelectedIndexChanged += CategoryListBx_SelectedIndexChanged;

            // Bind the BindingList to the DataGridView
            ReportDataGrid.DataSource = issues;
        }

        private void btnAddFile_Click(object sender, EventArgs e)
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

        //--------------------------------------USER INPUT TRACKER/ PROGRESS BAR------------------------------------------
        /// <summary>
        /// method to track user form field input
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtDescription_TextChanged(object sender, EventArgs e)
        {
            UpdateProgress();
        }

        private void textLocation_TextChanged(object sender, EventArgs e)
        {
            UpdateProgress();
        }

        private void CategoryListBx_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateProgress();
        }           

        // Method to calculate and update progress bar based on filled fields
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
            int filledFieldsCount = requiredFields.Count(f => f);  // Count how many fields are filled
            int totalFields = requiredFields.Count;  // Total number of required fields

            // Calculate progress percentage
            int progressPercentage = (filledFieldsCount * 100) / totalFields;

            // Update progress bar value
            progressBar.Value = progressPercentage;
        }
        //----------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Button to submit the report and display the report in the grid view
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSubmitReport_Click(object sender, EventArgs e)
        {
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

            // Add the issue to the list of issues
            issues.Add(issue);

            //Passes the data to the grid view
            ReportDataGrid.DataSource = issues;

            // Clear the input fields after submission
            txtDescription.Text = "";
            textLocation.Text = "";
            CategoryListBx.SelectedIndex = -1; // Reset selection
            AttachedPictureBox.Image = null;

            // Reset the progress bar after submission
            progressBar.Value = 0;
        }

       
        private void AttachedPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void txtFilePath_Click(object sender, EventArgs e)
        {


        }
    }
}
