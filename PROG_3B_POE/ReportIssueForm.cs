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
            timer1.Start();
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

                // Display the file path in a label or textbox
                txtFilePath.Text = filePath; // Assuming you have a TextBox to show the file path

                // Optionally handle different file types (for example, reading text files)
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
                    // Display image in a PictureBox (if you have one)
                    AttachedPictureBox.Image = Image.FromFile(filePath); // Assuming you have a PictureBox named pictureBox1
                }
            }
        }

        private void ProgressTimer(object sender, EventArgs e)
        {
            if (progressBar1.Value < 100)
            {
                progressBar1.Value += 10;
            }
            else
            {
                timer1.Stop();
                MessageBox.Show("Issue reported successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
    }
}
