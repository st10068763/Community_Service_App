using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Threading;
using System.IO;

namespace PROG_3B_POE
{
    public partial class ServiceRequestForm : Form
    {
        /// <summary>
        /// Class to represent a service request
        /// </summary>
        public class ServiceRequest : IComparable<ServiceRequest>
        {
            public Guid RequestId { get; set; }
            public string Status { get; set; }
            public string Priority { get; set; }
            public string Description { get; set; }
            public string Category { get; set; }
            public DateTime RequestDate { get; set; }
            /// <summary>
            /// This method is used to compare two service requests by their RequestId
            /// </summary>
            /// <param name="other"></param>
            /// <returns></returns>
            public int CompareTo(ServiceRequest other)
            {
                return RequestId.CompareTo(other.RequestId);
            }
        }

        /// <summary>
        /// Binary Tree class to store service requests
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public class BinarySearchTree<T> where T : IComparable<T>
        {
            /// <summary>
            /// This class represents a node in the binary tree
            /// </summary>
            public class Node
            {
                public T Data;
                public Node Left, Right;

                public Node(T data) => Data = data;
            }
            /// <summary>
            /// the root node of the binary tree
            /// </summary>
            public Node Root;
            /// <summary>
            /// this method inserts a new node into the binary tree
            /// </summary>
            /// <param name="data"></param>
            public void Insert(T data) => Root = Insert(Root, data);
            /// <summary>
            /// This method inserts a new node into the binary tree
            /// </summary>
            /// <param name="node"></param>
            /// <param name="data"></param>
            /// <returns></returns>
            private Node Insert(Node node, T data)
            {
                // here we check if the node is null, if it is we create a new node with the data
                if (node == null) return new Node(data);

                if (data.CompareTo(node.Data) < 0)
                    node.Left = Insert(node.Left, data);
                else if (data.CompareTo(node.Data) > 0)
                    node.Right = Insert(node.Right, data);
                // if the data is equal to the node data we return the node
                return node;
            }
            /// <summary>
            /// the search method searches for a node in the binary tree
            /// </summary>
            /// <param name="data"></param>
            /// <returns></returns>
            public T Search(T data) => Search(Root, data).Data;
            /// <summary>
            /// This method searches for a node in the binary tree
            /// </summary>
            /// <param name="node"></param>
            /// <param name="data"></param>
            /// <returns></returns>
            private Node Search(Node node, T data)
            {
                // if the node is null or the data is equal to the node data we return the node
                if (node == null || node.Data.CompareTo(data) == 0)
                    return node;
                // if the data is less than the node data we search the left node
                return data.CompareTo(node.Data) < 0
                    ? Search(node.Left, data)
                    : Search(node.Right, data);
            }
            /// <summary>
            /// This method traverses the binary tree in order
            /// </summary>
            /// <returns></returns>
            public List<T> InOrderTraversal()
            {
                var result = new List<T>();
                InOrderTraversal(Root, result);
                return result;
            }
            /// <summary>
            /// used to traverse the binary tree in order
            /// </summary>
            /// <param name="node"></param>
            /// <param name="result"></param>
            private void InOrderTraversal(Node node, List<T> result)
            {
                // if the node is null we return
                if (node == null) return;
                // we traverse the left node, add the data to the result list, then traverse the right node
                InOrderTraversal(node.Left, result);
                result.Add(node.Data);
                InOrderTraversal(node.Right, result);
            }
        }

        /// <summary>
        /// Used to store the service requests
        /// </summary>
        private BinarySearchTree<ServiceRequest> bst = new BinarySearchTree<ServiceRequest>();
        /// <summary>
        /// Class to store the status of a service request
        /// </summary>
        private static class Status
        {
            public const string Pending = "Pending";
            public const string InProgress = "In Progress";
            public const string Resolved = "Resolved";
        }
        /// <summary>
        /// Used to store the categories of a service request
        /// </summary>
        private SortedSet<ServiceRequest> requestQueue;
        /// <summary>
        /// report issue form
        /// </summary>
        ReportIssueForm reportIssueForm = new ReportIssueForm();
        /// <summary>
        /// this method initializes the service request form
        /// </summary>
        public ServiceRequestForm()
        {
            // Initialize binary search tree and load data before initializing components
            bst = new BinarySearchTree<ServiceRequest>();
            LoadIssues();
            InitializeComponent();
            
            DisplayTreeData();
            DisplayChart();
        }
        /// <summary>
        /// Method to load the issues from the ReportIssueForm into the binary search tree
        /// </summary>
        private void LoadIssues()
        {
            foreach (var issue in ReportIssueForm.issues)
            {
                var request = ConvertIssueToRequest(issue);
                bst.Insert(request);
            }
        }
        /// <summary>
        /// Method to display the service requests in the DataGridView
        /// </summary>
        private void DisplayTreeData()
        {
            dgvServiceRequests.DataSource = bst.InOrderTraversal();
        }

        /// <summary>
        /// Custom comparer to sort service requests by priority
        /// </summary>
        public class RequestPriorityComparer : IComparer<ServiceRequest>
        {
            public int Compare(ServiceRequest x, ServiceRequest y)
            {
                int priorityComparison = String.Compare(y.Priority, x.Priority); 
                return priorityComparison == 0 ? x.RequestId.CompareTo(y.RequestId) : priorityComparison;
            }
        }

        /// <summary>
        /// Convert an IssueReport to a ServiceRequest with priority determination
        /// </summary>
        /// <param name="issue"></param>
        /// <returns></returns>
        private ServiceRequest ConvertIssueToRequest(ReportIssueForm.IssueReport issue)
        {
            return new ServiceRequest
            {
                RequestId = issue.Id,
                Status = issue.Status,
                Priority = DeterminePriority(issue.Category), 
                Description = issue.Description,
                Category = issue.Category,
                RequestDate = DateTime.Now
            };
        }

        /// <summary>
        /// Determines the priority of a request based on the category
        /// </summary>
        /// <param name="category"></param>
        /// <returns></returns>
        private string DeterminePriority(string category)
        {
            switch (category)
            {
                case "Road":
                    return "High Priority";
                case "Electricity":
                    return "Medium Priority";
                default:
                    return "Low Priority";
            }
        }  

        /// <summary>
        /// Method to update the status of a request when the user changes the status in the DataGridView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvServiceRequests_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvServiceRequests.Columns[e.ColumnIndex].Name == "StatusColumn")
            {
                var selectedRequest = (ServiceRequest)dgvServiceRequests.Rows[e.RowIndex].DataBoundItem;
                string newStatus = dgvServiceRequests.Rows[e.RowIndex].Cells["StatusColumn"].Value.ToString();
                UpdateRequestStatus(selectedRequest.RequestId, newStatus);
                // Refresh the chart after the status has been updated
                DisplayChart();
            }
        }

        //----------------------------------Chart
        //=========================================================================//
        private void cbChartType_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayChart();
        }

        //-------------------Changes the graph type based on the radio button selected
        private void btnLineGraph_CheckedChanged(object sender, EventArgs e)
        {
            if (btnLineGraph.Checked) DisplayChart();
        }
        /// <summary>
        /// This method is used to display the chart based on the radio button selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStakedGraph_CheckedChanged(object sender, EventArgs e)
        {
            if (btnStakedGraph.Checked) DisplayChart();
        }
        /// <summary>
        /// This method is used to display the chart based on the radio button selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStaked_CheckedChanged(object sender, EventArgs e)
        {
            if (btnStaked.Checked) DisplayChart();
        }

        /// <summary>
        /// Display the chart based on the selected chart type
        /// </summary>
        private void DisplayChart()
        {
            // Check if the chart type is selected
            if (cbChartType.SelectedItem == null)
            {
                cbChartType.SelectedIndex = 0;
            }           

            if (cbChartType.SelectedItem == null)
            {
                MessageBox.Show("Please select a chart type.");
                return;
            }

            if (bst == null || !bst.InOrderTraversal().Any())
            {
                MessageBox.Show("No data available for chart.");
                return;
            }

            // Clear previous series and add a new one
            ServiceChart.Series.Clear();
            var series = new Series("Service Requests")
            {
                ChartType = SeriesChartType.Column // Default chart type
            };

            // Determine the selected chart type, the chart type will changed based on the user choice
            if (btnLineGraph.Checked) series.ChartType = SeriesChartType.Spline;
            if (btnStakedGraph.Checked) series.ChartType = SeriesChartType.StackedColumn;
            if (btnStaked.Checked) series.ChartType = SeriesChartType.Area;
            // Add the series to the chart
            ServiceChart.Series.Add(series);

            // Populate data based on the selected type
            string chartType = cbChartType.SelectedItem.ToString();
            var data = bst.InOrderTraversal();
            // Populate the chart based on the selected chart type
            if (chartType == "Category")
            {
                var categoryGroups = data.GroupBy(r => r.Category ?? "Unknown")
                                          .Select(g => new { g.Key, Count = g.Count() });

                foreach (var group in categoryGroups)
                {
                    series.Points.AddXY(group.Key, group.Count);
                }
            }
            else if (chartType == "Status")
            {
                var statusGroups = data.GroupBy(r => r.Status ?? "Unknown")
                                        .Select(g => new { g.Key, Count = g.Count() });

                foreach (var group in statusGroups)
                {
                    series.Points.AddXY(group.Key, group.Count);
                }
            }
            else if (chartType == "Priority")
            {
                var priorityGroups = data.GroupBy(r => r.Priority ?? "Unknown")
                                          .Select(g => new { g.Key, Count = g.Count() });

                foreach (var group in priorityGroups)
                {
                    series.Points.AddXY(group.Key, group.Count);
                }
            }
        }

        //*************************************END OF CHART*******************************************
        /// <summary>
        /// button to track the request
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTrackRequest_Click_1(object sender, EventArgs e)
        {
            // Check if the user has entered a valid Request ID
            if (Guid.TryParse(txtRequestID.Text, out Guid requestId))
            {
                // Search for the request in the binary search tree
                var request = bst.InOrderTraversal()
                    .FirstOrDefault(r => r.RequestId == requestId);
                // Display the request details if found
                if (request != null)
                {
                    MessageBox.Show($"Request ID: {request.RequestId}\n" +
                                    $"Status: {request.Status}\n" +
                                    $"Priority: {request.Priority}\n" +
                                    $"Description: {request.Description}\n" +
                                    $"Request Date: {request.RequestDate}");
                    // Highlight the tracked request in the DataGridView
                    HighlightTrackedRequest(requestId);
                }
                // Display an error message if the request is not found
                else
                {
                    MessageBox.Show("Request not found.");
                }
            }
            // Display an error message if the user enters an invalid Request ID
            else
            {
                MessageBox.Show("Please enter a valid Request ID.");
            }
        }

        //-----------------------------------Update request methods
        /// <summary>
        /// Button to update the status of a request
        /// </summary>
        /// <param name="requestId"></param>
        /// <param name="newStatus"></param>
        private void UpdateRequestStatus(Guid requestId, string newStatus)
        {
            // Search for the request in the binary search tree
            var request = bst.Search(new ServiceRequest { RequestId = requestId });
            if (request != null)
            {
                // Update the status of the request
                request.Status = newStatus;
                DisplayTreeData();
                DisplayChart();
            }
        }

        //----------------------------Search method
        /// <summary>
        /// Button to search for service requests based on user inputs
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            // Check if there are any service requests to search
            if (bst == null || !bst.InOrderTraversal().Any())
            {
                MessageBox.Show("No service requests available to search.");
                return;
            }

            // Get user inputs
            string searchQuery = txtSearch.Text.Trim().ToLower(); 
            string selectedCategory = txtSearch.Text.Trim().ToLower();
            string selectedStatus = txtSearch.Text.Trim().ToLower(); 

            // Perform the search using LINQ
            var results = bst.InOrderTraversal().Where(request =>
                // Search by RequestId if input matches a GUID
                (Guid.TryParse(searchQuery, out Guid requestId) && request.RequestId == requestId) ||
                // Search by Category if one is selected
                (!string.IsNullOrEmpty(selectedCategory) && request.Category.ToLower().Contains(selectedCategory)) ||
                // Search by Status if one is selected
                (!string.IsNullOrEmpty(selectedStatus) && request.Status.ToLower().Contains(selectedStatus)) ||
                // Search by keywords in Description
                (!string.IsNullOrEmpty(searchQuery) && request.Description.ToLower().Contains(searchQuery))
            ).ToList();

            // Display the results
            if (results.Any())
            {
                dgvServiceRequests.DataSource = results; 
            }
            else
            {
                MessageBox.Show("No matching service requests found.");
                dgvServiceRequests.DataSource = null; 
            }
        }

        /// <summary>
        /// Button to reset all filters and display all service requests
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReset_Click(object sender, EventArgs e)
        {
            // Check if there are any service requests to reset
            if (bst == null || !bst.InOrderTraversal().Any())
            {
                MessageBox.Show("No service requests available to reset.");
                dgvServiceRequests.DataSource = null; // Clear DataGridView
                return;
            }

            // Clear any filters or search inputs
            txtSearch.Clear();
            // resets all the buttons to unchecked
            cbCategorySorting.SelectedIndex = -1; 
            rdBtnMediumPriority.Checked = false;
            rdBtnHighPriority.Checked = false;
            rdBtnLowPriority.Checked = false;
            // Reload all service requests into the DataGridView
            dgvServiceRequests.DataSource = bst.InOrderTraversal().ToList();
            MessageBox.Show("Filters reset. Displaying all service requests.");
        }

        //==========================================================================//
        //----------------------------------Sorting
        /// <summary>
        /// Filters the service requests by priority and updates the DataGridView.
        /// </summary>
        /// <param name="priority">The priority to filter by.</param>
        private void FilterByPriority(string priority)
        {
            // Check if there are any service requests to filter
            var filteredRequests = bst.InOrderTraversal()
                .Where(request => request.Priority == priority)
                .ToList();
            // Display the filtered requests
            if (filteredRequests.Any())
            {
                dgvServiceRequests.DataSource = filteredRequests;
            }
            else
            {
                MessageBox.Show($"No service requests found with priority: {priority}");
                // Clear if no matches found
                dgvServiceRequests.DataSource = null;
            }
        }       

        /// <summary>
        /// Button to sort the requests by category
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbCategorySorting_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Check if there are any service requests to sort
            if (cbCategorySorting.SelectedIndex != -1)
            {
                string selectedCategory = cbCategorySorting.SelectedItem.ToString();
                var filteredRequests = bst.InOrderTraversal()
                                          .Where(request => request.Category == selectedCategory)
                                          .ToList();

                if (filteredRequests.Any())
                {
                    dgvServiceRequests.DataSource = filteredRequests;
                }
                else
                {
                    MessageBox.Show("No requests found for the selected category.");
                    dgvServiceRequests.DataSource = null; // Clear if no results
                }
            }
        }
        /// <summary>
        /// This method is used to display the chart based on the radio button selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvServiceRequests_CellValueChanged_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvServiceRequests.Columns[e.ColumnIndex].Name == "StatusColumn")
            {
                var selectedRequest = dgvServiceRequests.Rows[e.RowIndex].DataBoundItem as ServiceRequest;
                if (selectedRequest != null)
                {
                    string newStatus = dgvServiceRequests.Rows[e.RowIndex].Cells["StatusColumn"].Value?.ToString();
                    if (!string.IsNullOrEmpty(newStatus))
                    {
                        UpdateRequestStatus(selectedRequest.RequestId, newStatus);

                        MessageBox.Show($"Status updated to '{newStatus}' for Request ID: {selectedRequest.RequestId}", "Status Updated");
                        //Refresh the chart after the status has been updated
                        DisplayChart();
                    }
                }
            }
        }
        /// <summary>
        /// Method to highlight the tracked request in the DataGridView
        /// </summary>
        /// <param name="requestId"></param>
        private void HighlightTrackedRequest(Guid requestId)
        {
            foreach (DataGridViewRow row in dgvServiceRequests.Rows)
            {
                if (row.DataBoundItem is ServiceRequest request && request.RequestId == requestId)
                {
                    row.Selected = true;
                    dgvServiceRequests.FirstDisplayedScrollingRowIndex = row.Index;
                    break;
                }
            }
        }
        /// <summary>
        /// button to filter the requests by priority, High Priority
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdBtnHighPriority_CheckedChanged(object sender, EventArgs e)
        {
            if (rdBtnHighPriority.Checked)
            {
                FilterByPriority("High Priority");
            }
        }
        /// <summary>
        /// Button to filter the requests by priority, Medium Priority
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdBtnMediumPriority_CheckedChanged(object sender, EventArgs e)
        {
            if (rdBtnMediumPriority.Checked)
            {
                FilterByPriority("Medium Priority");
            }
        }
        /// <summary>
        /// button to filter the requests by priority, Low Priority
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdBtnLowPriority_CheckedChanged(object sender, EventArgs e)
        {
            if (rdBtnLowPriority.Checked)
            {
                FilterByPriority("Low Priority");
            }
        }
        /// <summary>
        /// Button to export the service requests to a CSV file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExportData_Click(object sender, EventArgs e)
        {
            // Check if there is any data to export
            if (dgvServiceRequests.Rows.Count == 0)
            {
                MessageBox.Show("No data to export.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Open a SaveFileDialog to let the user specify the file path
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "CSV files (*.csv)|*.csv|Text files (*.txt)|*.txt|All files (*.*)|*.*"; 
                saveFileDialog.Title = "Save Service Requests";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Export the data
                        ExportDataGridViewToCSV(dgvServiceRequests, saveFileDialog.FileName);
                        MessageBox.Show("Data exported successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        /// <summary>
        /// Method to export the DataGridView to a CSV file
        /// </summary>
        /// <param name="dgv"></param>
        /// <param name="filePath"></param>
        private void ExportDataGridViewToCSV(DataGridView dgv, string filePath)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                // Write column headers
                for (int i = 0; i < dgv.Columns.Count; i++)
                {
                    writer.Write(dgv.Columns[i].HeaderText);
                    if (i < dgv.Columns.Count - 1)
                        writer.Write(","); // Separate with commas
                }
                writer.WriteLine();

                // Write rows
                foreach (DataGridViewRow row in dgv.Rows)
                {
                    if (!row.IsNewRow) // Skip the "new row" placeholder
                    {
                        for (int i = 0; i < dgv.Columns.Count; i++)
                        {
                            writer.Write(row.Cells[i].Value?.ToString());
                            if (i < dgv.Columns.Count - 1)
                                writer.Write(",");
                        }
                        writer.WriteLine();
                    }
                }
            }
        }

    }
}//-------------------------------------------------------------DingDong End of Code-------------------------------------------------------------//
