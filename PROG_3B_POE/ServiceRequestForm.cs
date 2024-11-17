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
        public class ServiceRequest
        {
            public Guid RequestId { get; set; }
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
                //RequestId = Guid.NewGuid(),
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
            // group by priority
            else if (cbChartType.SelectedItem.ToString() == "Priority")
            {
                var priorityGroups = ReportIssueForm.issues
                    .GroupBy(issue => DeterminePriority(issue.Category))
                    .Select(group => new { Priority = group.Key, Count = group.Count() });

                foreach (var group in priorityGroups)
                {
                    ServiceChart.Series["Column"].Points.AddXY(group.Priority, group.Count);
                }
            }
        }

        //private void ServiceChart_MouseClick(object sender, MouseEventArgs e)
        //{
        //    HitTestResult hit = ServiceChart.HitTest(e.X, e.Y);
        //    if (hit.ChartElementType == ChartElementType.DataPoint)
        //    {
        //        string filter = hit.Series.Points[hit.PointIndex].AxisLabel;
        //        var filteredRequests = requestQueue.Where(r => r.Category == filter).ToList();
        //    }
        //}
        //*************************************END OF CHART*******************************************

        private void btnTrackRequest_Click_1(object sender, EventArgs e)
        {
            if (Guid.TryParse(txtRequestID.Text, out Guid requestId))
            {
                var request = requestQueue.FirstOrDefault(r => r.RequestId == requestId);
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
            // Update status in requestQueue
            var request = requestQueue.FirstOrDefault(r => r.RequestId == requestId);
            if (request != null)
            {
                request.Status = newStatus;
            }

            // Update status in BindingList (ReportIssueForm.issues)
            var correspondingIssue = ReportIssueForm.issues.FirstOrDefault(issue => issue.Id == requestId);

            if (correspondingIssue != null)
            {
                correspondingIssue.Status = newStatus;
            }
            // Refresh DataGridView
            UpdateDisplay();
            // Update chart
            DisplayChart();
        }


        private void btnUpdateStatus_Click_1(object sender, EventArgs e)
        {
            if (dgvServiceRequests.SelectedRows.Count > 0)
            {
                var selectedRequest = (ServiceRequest)dgvServiceRequests.SelectedRows[0].DataBoundItem;

                // Get the new status from the DataGridView when the user clicks the button
                string newStatus = dgvServiceRequests.SelectedRows[0].Cells["ServiceStatus"].Value.ToString();

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
        //----------------------------Search method
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
            // Displays all requests in the DataGridView
            UpdateDisplay();
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
            dgvServiceRequests.DataSource = null;
            dgvServiceRequests.DataSource = sortedRequests;
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
        /// Button to show the in progress requests
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

                        // Refresh DataGridView and chart
                        UpdateDisplay();
                        DisplayChart();
                    }
                }
            }
        }

        private void HighlightTrackedRequest(Guid requestId)
        {
            foreach (DataGridViewRow row in dgvServiceRequests.Rows)
            {
                var request = row.DataBoundItem as ServiceRequest;
                if (request != null && request.RequestId == requestId)
                {
                    row.Selected = true;
                    dgvServiceRequests.FirstDisplayedScrollingRowIndex = row.Index;
                    break;
                }
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
