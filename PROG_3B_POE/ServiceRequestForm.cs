using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace PROG_3B_POE
{
    public partial class ServiceRequestForm : Form
    {
        public class ServiceRequest
        {
            public int RequestId { get; set; }
            public string Status { get; set; }
            public string Priority { get; set; } 
            public string Description { get; set; }
            public string Category { get; set; }
            public DateTime RequestDate { get; set; }
        }

        private static class Status
        {
            public const string Pending = "Pending";
            public const string InProgress = "In Progress";
            public const string Resolved = "Resolved";
        }

        private PriorityQueue<ServiceRequest, string> priorityQueue = new PriorityQueue<ServiceRequest, string>();

        private SortedSet<ServiceRequest> requestQueue;
        ReportIssueForm reportIssueForm = new ReportIssueForm();
        private static readonly Random random = new Random();

        public ServiceRequestForm()
        {
            InitializeComponent();
            requestQueue = new SortedSet<ServiceRequest>(new RequestPriorityComparer());
            InitializeChartTypeComboBox();
            LoadIssues(); // Load issues when the form opens
            // calls the method to display the chart
            DisplayChart();
        }

        // Method to add a request to the queue
        public void AddRequest(ServiceRequest request)
        {
            if (!requestQueue.Contains(request))
            {
                requestQueue.Add(request);
                UpdateDisplay();
            }
        }

        // Method to update the status of a specific request
        public void UpdateRequestStatus(int requestId, string newStatus)
        {
            var request = requestQueue.FirstOrDefault(r => r.RequestId == requestId);
            if (request != null)
            {
                request.Status = newStatus;
                UpdateDisplay();
            }
        }

        // Load initial issues into the DataGridView
        private void LoadIssues()
        {
            ReportIssueForm.issues.ListChanged += Issues_ListChanged;
            // Load the initial data
            var convertedRequests = ReportIssueForm.issues.Select(ConvertIssueToRequest).ToList();
            dgvServiceRequests.DataSource = convertedRequests;

            // Load into priority queue
            foreach (var request in convertedRequests)
            {
                priorityQueue.Enqueue(request, request.Priority);
            }
        }

        // Handle dynamic updates when issues change
        private void Issues_ListChanged(object sender, ListChangedEventArgs e)
        {
            // Rebind the DataGridView with updated issue data
            dgvServiceRequests.DataSource = null;
            dgvServiceRequests.DataSource = ReportIssueForm.issues.Select(ConvertIssueToRequest).ToList();
        }

        // Refresh the DataGridView display
        private void UpdateDisplay()
        {
            dgvServiceRequests.DataSource = null;
            dgvServiceRequests.DataSource = ReportIssueForm.issues.Select(ConvertIssueToRequest).ToList();
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
                RequestId = random.Next(1000, 9999),
                Status = issue.Status,
                Priority = DeterminePriority(issue.Category), 
                Description = issue.Description,
                RequestDate = DateTime.Now
            };
        }

        // Determine priority based on category (example logic)
        private string DeterminePriority(string category)
        {
            return category == "Road" ? "High Priority" :
                (category == "Electricity" ? "Medium Priority" : "Low Priority"); 
        }

        // Search method to filter requests in the DataGridView based on input
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.ToLower();
            var filteredRequests = requestQueue.Where(r =>
                r.RequestId.ToString().Contains(searchText) ||
                r.Status.ToLower().Contains(searchText) ||
                r.Description.ToLower().Contains(searchText)).ToList();

            dgvServiceRequests.DataSource = null;
            dgvServiceRequests.DataSource = filteredRequests;
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

        private void InitializeChartTypeComboBox()
        {
            cbChartType.SelectedIndex = 0;
            cbChartType.SelectedIndexChanged += cbChartType_SelectedIndexChanged;
            this.Controls.Add(cbChartType);
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
            // Clear existing points
            ServiceChart.Series["Column"].Points.Clear();

            if (cbChartType.SelectedItem.ToString() == "Category")
            {
                // Group by Category
                var categoryGroups = ReportIssueForm.issues
                    .GroupBy(issue => issue.Category)
                    .Select(group => new { Category = group.Key, Count = group.Count() });

                foreach (var group in categoryGroups)
                {
                    ServiceChart.Series["Column"].Points.AddXY(group.Category, group.Count);
                }
            }
            else if (cbChartType.SelectedItem.ToString() == "Status")
            {
                // Group by Status
                var statusGroups = ReportIssueForm.issues
                    .GroupBy(issue => issue.Status)
                    .Select(group => new { Status = group.Key, Count = group.Count() });

                foreach (var group in statusGroups)
                {
                    ServiceChart.Series["Column"].Points.AddXY(group.Status, group.Count);
                }
            }
        }
        //*************************************END OF CHART*******************************************

        private void btnTrackRequest_Click_1(object sender, EventArgs e)
        {
            if (int.TryParse(txtRequestID.Text, out int requestId))
            {
                var request = requestQueue.FirstOrDefault(r => r.RequestId == requestId);
                if (request != null)
                {
                    rtbRequestStatus.Text = $"Request ID: {request.RequestId}\n" +
                                            $"Status: {request.Status}\n" +
                                            $"Priority: {request.Priority}\n" +
                                            $"Description: {request.Description}\n" +
                                            $"Request Date: {request.RequestDate}";
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


        private void btnUpdateStatus_Click_1(object sender, EventArgs e)
        {
            if (dgvServiceRequests.SelectedRows.Count > 0)
            {
                var selectedRequest = (ServiceRequest)dgvServiceRequests.SelectedRows[0].DataBoundItem;

                // Get the new status from the DataGridView when the user clicks the button
                string newStatus = ServiceStatus.DataPropertyName?.ToString();

                if (!string.IsNullOrEmpty(newStatus))
                {
                    selectedRequest.Status = newStatus;
                    UpdateRequestStatus(selectedRequest.RequestId, newStatus);

                    // refresh the chart
                    DisplayChart();
                }
                else
                {
                    MessageBox.Show("Please select a valid status.", "Status Update Error");
                }
            }
        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.ToLower();
            var filteredRequests = requestQueue.Where(r =>
                r.RequestId.ToString().Contains(searchText) ||
                r.Status.ToLower().Contains(searchText) ||
                r.Description.ToLower().Contains(searchText)).ToList();

            if (filteredRequests.Any())
            {
                dgvServiceRequests.DataSource = null;
                dgvServiceRequests.DataSource = filteredRequests;
            }
            else
            {
                MessageBox.Show("No matching requests found.", "Search Results");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            // Resets the sorting options and displays all requests in the DataGridView and the chart
            rdBtnPending.Checked = false;
            rdBtnInProgress.Checked = false;
            rdBtnSolved.Checked = false;
            cbCategorySorting.SelectedIndex = -1;
            dgvServiceRequests.DataSource = requestQueue.ToList();
            DisplayChart();
        }

        //----------------------------------Sorting
        //==========================================================================//
        //----------------------------------Sorting
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
            dgvServiceRequests.DataSource = null;
            dgvServiceRequests.DataSource = sortedRequests;
        }

        private void rdBtnPending_CheckedChanged(object sender, EventArgs e)
        {
            if (rdBtnPending.Checked)
            {
                SortRequests(Status.Pending);
            }
        }

        private void rdBtnInProgress_CheckedChanged(object sender, EventArgs e)
        {
            if (rdBtnInProgress.Checked)
            {
                SortRequests(Status.InProgress);
            }
        }

        private void rdBtnSolved_CheckedChanged(object sender, EventArgs e)
        {
            if (rdBtnSolved.Checked)
            {
                SortRequests(Status.Resolved);
            }
        }

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
    }

    //------------------------------------Priority Queue---------------------------------------------------//
    public class PriorityQueue<TElement, TPriority> where TPriority : IComparable<TPriority>
    {
        private List<(TElement Element, TPriority Priority)> _elements = new List<(TElement, TPriority)>();

        public int Count => _elements.Count;

        public void Enqueue(TElement element, TPriority priority)
        {
            _elements.Add((element, priority));
            _elements = _elements.OrderBy(e => e.Priority).ToList();
        }

        public TElement Dequeue()
        {
            if (_elements.Count == 0)
            {
                throw new InvalidOperationException("The queue is empty.");
            }

            var element = _elements[0].Element;
            _elements.RemoveAt(0);
            return element;
        }

        public IEnumerable<TElement> UnorderedItems => _elements.Select(e => e.Element);
    }

}
