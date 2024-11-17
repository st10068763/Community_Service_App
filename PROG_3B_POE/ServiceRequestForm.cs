using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Threading;

namespace PROG_3B_POE
{
    public partial class ServiceRequestForm : Form
    {
        public class ServiceRequest : IComparable<ServiceRequest>
        {
            public Guid RequestId { get; set; }
            public string Status { get; set; }
            public string Priority { get; set; }
            public string Description { get; set; }
            public string Category { get; set; }
            public DateTime RequestDate { get; set; }

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
            public class Node
            {
                public T Data;
                public Node Left, Right;

                public Node(T data) => Data = data;
            }

            public Node Root;

            public void Insert(T data) => Root = Insert(Root, data);

            private Node Insert(Node node, T data)
            {
                if (node == null) return new Node(data);

                if (data.CompareTo(node.Data) < 0)
                    node.Left = Insert(node.Left, data);
                else if (data.CompareTo(node.Data) > 0)
                    node.Right = Insert(node.Right, data);

                return node;
            }

            public T Search(T data) => Search(Root, data).Data;

            private Node Search(Node node, T data)
            {
                if (node == null || node.Data.CompareTo(data) == 0)
                    return node;

                return data.CompareTo(node.Data) < 0
                    ? Search(node.Left, data)
                    : Search(node.Right, data);
            }

            public List<T> InOrderTraversal()
            {
                var result = new List<T>();
                InOrderTraversal(Root, result);
                return result;
            }

            private void InOrderTraversal(Node node, List<T> result)
            {
                if (node == null) return;

                InOrderTraversal(node.Left, result);
                result.Add(node.Data);
                InOrderTraversal(node.Right, result);
            }
        }

        private BinarySearchTree<ServiceRequest> bst = new BinarySearchTree<ServiceRequest>();

        private static class Status
        {
            public const string Pending = "Pending";
            public const string InProgress = "In Progress";
            public const string Resolved = "Resolved";
        }

        private SortedSet<ServiceRequest> requestQueue;
        ReportIssueForm reportIssueForm = new ReportIssueForm();

        public ServiceRequestForm()
        {
            InitializeComponent();
            LoadIssues();
            DisplayTreeData();
        }

        private void LoadIssues()
        {
            foreach (var issue in ReportIssueForm.issues)
            {
                var request = ConvertIssueToRequest(issue);
                bst.Insert(request);
            }
        }

        private void DisplayTreeData()
        {
            dgvServiceRequests.DataSource = bst.InOrderTraversal();
        }
        
        // Custom comparer for sorting requests by priority
        public class RequestPriorityComparer : IComparer<ServiceRequest>
        {
            public int Compare(ServiceRequest x, ServiceRequest y)
            {
                int priorityComparison = String.Compare(y.Priority, x.Priority); 
                return priorityComparison == 0 ? x.RequestId.CompareTo(y.RequestId) : priorityComparison;
            }
        }

        // Convert an IssueReport to a ServiceRequest with priority determination
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
        /// <summary>
        /// Button to display the chart as a line graph
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLineGraph_CheckedChanged(object sender, EventArgs e)
        {
            if (btnLineGraph.Checked)
            {
                ServiceChart.Series[0].ChartType = SeriesChartType.Line;
            }
        }
        /// <summary>
        /// Button to display the chart as a bar graph
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStakedGraph_CheckedChanged(object sender, EventArgs e)
        {
            if (btnStakedGraph.Checked)
            {
                ServiceChart.Series[0].ChartType = SeriesChartType.StackedColumn;
            }
        }

        /// <summary>
        /// Method to display the chart with the number of requests per category
        /// </summary>
        private void DisplayChart()
        {
            ServiceChart.Series["Column"].Points.Clear();

            if (cbChartType.SelectedItem.ToString() == "Category")
            {
                var categoryGroups = bst.InOrderTraversal()
                    .GroupBy(r => r.Category)
                    .Select(g => new { g.Key, Count = g.Count() });

                foreach (var group in categoryGroups)
                {
                    ServiceChart.Series["Column"].Points.AddXY(group.Key, group.Count);
                }
            }
            else if (cbChartType.SelectedItem.ToString() == "Status")
            {
                var statusGroups = bst.InOrderTraversal()
                    .GroupBy(r => r.Status)
                    .Select(g => new { g.Key, Count = g.Count() });

                foreach (var group in statusGroups)
                {
                    ServiceChart.Series["Column"].Points.AddXY(group.Key, group.Count);
                }
            }
            else if (cbChartType.SelectedItem.ToString() == "Priority")
            {
                var priorityGroups = bst.InOrderTraversal()
                    .GroupBy(r => r.Priority)
                    .Select(g => new { g.Key, Count = g.Count() });

                foreach (var group in priorityGroups)
                {
                    ServiceChart.Series["Column"].Points.AddXY(group.Key, group.Count);
                }
            }        
        }

        //*************************************END OF CHART*******************************************

        private void btnTrackRequest_Click_1(object sender, EventArgs e)
        {
            if (Guid.TryParse(txtRequestID.Text, out Guid requestId))
            {
                // Search for the request in the binary search tree
                var request = bst.InOrderTraversal()
                    .FirstOrDefault(r => r.RequestId == requestId);

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
                else
                {
                    MessageBox.Show("Request not found.");
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid Request ID.");
            }
        }

        //-----------------------------------Update request methods
        private void UpdateRequestStatus(Guid requestId, string newStatus)
        {
            var request = bst.Search(new ServiceRequest { RequestId = requestId });
            if (request != null)
            {
                request.Status = newStatus;
                DisplayTreeData();
                DisplayChart();
            }
        }


        //----------------------------Search method
        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            if (bst == null || !bst.InOrderTraversal().Any())
            {
                MessageBox.Show("No service requests available to search.");
                return;
            }

            // Get user inputs
            string searchQuery = txtSearch.Text.Trim().ToLower(); // Convert to lowercase for case-insensitive search
            string selectedCategory = txtSearch.Text.Trim().ToLower();
            string selectedStatus = txtSearch.Text.Trim().ToLower(); // Selected status (if any)

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
                dgvServiceRequests.DataSource = results; // Bind results to DataGridView
            }
            else
            {
                MessageBox.Show("No matching service requests found.");
                dgvServiceRequests.DataSource = null; // Clear DataGridView if no results
            }
        }


        private void btnReset_Click(object sender, EventArgs e)
        {
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
            rdBtnInProgress.Checked = false;
            rdBtnPending.Checked = false;
            rdBtnSolved.Checked = false;

            // Reload all service requests into the DataGridView
            dgvServiceRequests.DataSource = bst.InOrderTraversal().ToList();
            MessageBox.Show("Filters reset. Displaying all service requests.");
        }


        //==========================================================================//
        //----------------------------------Sorting
        /// <summary>
        /// Method to sort requests based on the selected criteria such as pending, in progress, resolved, priority
        /// </summary>
        /// <param name="criteria"></param>
        private void SortRequests(string criteria)
        {
            var sortedRequests = ReportIssueForm.issues
                .Select(ConvertIssueToRequest) // Convert all issues to service requests
                .ToList();

            switch (criteria)
            {
                case "Priority":
                    sortedRequests = sortedRequests.OrderBy(r => r.Priority).ToList();
                    break;
                case "Request Date":
                    sortedRequests = sortedRequests.OrderBy(r => r.RequestDate).ToList();
                    break;
                case "Pending":
                    sortedRequests = sortedRequests.Where(r => r.Status == Status.Pending).ToList();
                    break;
                case "In Progress":
                    sortedRequests = sortedRequests.Where(r => r.Status == Status.InProgress).ToList();
                    break;
                case "Resolved":
                    sortedRequests = sortedRequests.Where(r => r.Status == Status.Resolved).ToList();
                    break;
                default:
                    MessageBox.Show("Invalid sorting criteria.", "Error");
                    return;
            }
            // Update the DataGridView
            // Reload all service requests into the DataGridView
            dgvServiceRequests.DataSource = bst.InOrderTraversal().ToList();
        }
        /// <summary>
        /// Button to show the pending requests
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdBtnPending_CheckedChanged(object sender, EventArgs e)
        {
            if (rdBtnPending.Checked)
            {
                SortRequests(Status.Pending);
            }
        }

        /// <summary>
        /// Button to show the in-progress requests
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdBtnInProgress_CheckedChanged(object sender, EventArgs e)
        {
            if (rdBtnInProgress.Checked)
            {
                SortRequests(Status.InProgress);
            }
        }

        /// <summary>
        /// Button to show the resolved requests
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdBtnSolved_CheckedChanged(object sender, EventArgs e)
        {
            if (rdBtnSolved.Checked)
            {
                SortRequests(Status.Resolved);
            }
        }

        /// <summary>
        /// Button to sort the requests by category
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbCategorySorting_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCategorySorting.SelectedIndex != -1)
            {
                string selectedCategory = cbCategorySorting.SelectedItem.ToString();

                var filteredRequests = ReportIssueForm.issues
                    .Where(issue => issue.Category == selectedCategory)
                    .Select(ConvertIssueToRequest)
                    .ToList();

                dgvServiceRequests.DataSource = null;
                dgvServiceRequests.DataSource = filteredRequests;
            }
        }

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

    }

}
