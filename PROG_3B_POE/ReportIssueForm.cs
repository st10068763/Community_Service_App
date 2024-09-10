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
        public ReportIssueForm()
        {
            InitializeComponent();
        }

        private void ReportIssueForm_Load(object sender, EventArgs e)
        {
            progressBar.Value = 0;
            txtDescription.TextChanged += txtDescription_TextChanged;
            textLocation.TextChanged += textLocation_TextChanged;
            CategoryListBx.SelectedIndexChanged += CategoryListBx_SelectedIndexChanged;
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

        // Method to track user form field input
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

        /// <summary>
        /// Button to submit the report
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSubmitReport_Click(object sender, EventArgs e)
        {
            // checking if all the fields are filled
            if (txtDescription.Text == "" || textLocation.Text == "" || CategoryListBx.Text == "")
            {
                MessageBox.Show("Please fill in all the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Issue reported successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            // Clear all the fields
            txtDescription.Text = "";
            textLocation.Text = "";
            CategoryListBx.SelectedIndex = 0;
            AttachedPictureBox.Image = null;
        }

        private void AttachedPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void txtFilePath_Click(object sender, EventArgs e)
        {


        }
    }
}
