using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

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
            dgvServiceRequests.DataSource = requestQueue.ToList();
        }

        // Custom comparer for sorting requests by priority
        public class RequestPriorityComparer : IComparer<ServiceRequest>
        {
            public int Compare(ServiceRequest x, ServiceRequest y)
            {
                int priorityComparison = String.Compare(y.Priority, x.Priority); // Compare strings
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

        private void dgvServiceRequests_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvServiceRequests.Columns[e.ColumnIndex].Name == "StatusColumn")
            {
                var selectedRequest = (ServiceRequest)dgvServiceRequests.Rows[e.RowIndex].DataBoundItem;
                string newStatus = dgvServiceRequests.Rows[e.RowIndex].Cells["StatusColumn"].Value.ToString();
                UpdateRequestStatus(selectedRequest.RequestId, newStatus);
            }
        }

        //----------------------------------Sorting
        private void SortRequests(string criteria)
        {
            List<ServiceRequest> sortedRequests = requestQueue.ToList();

            switch (criteria)
            {
                case "Priority":
                    sortedRequests = sortedRequests.OrderBy(r => r.Priority).ToList();
                    break;
                case "Request Date":
                    sortedRequests = sortedRequests.OrderBy(r => r.RequestDate).ToList();
                    break;
                case "Status":
                    sortedRequests = sortedRequests.OrderBy(r => r.Status).ToList();
                    break;
            }

            dgvServiceRequests.DataSource = null;
            dgvServiceRequests.DataSource = sortedRequests;
        }

        //--------------------------------Priority queues
        private void LoadIntoPriorityQueue()
        {
            // Clear the priority queue
            priorityQueue = new PriorityQueue<ServiceRequest, string>(); 

            foreach (var request in ReportIssueForm.issues.Select(ConvertIssueToRequest))
            {
                priorityQueue.Enqueue(request, request.Priority);
            }
        }

        private void DisplayPriorityQueue()
        {
            dgvServiceRequests.DataSource = priorityQueue.UnorderedItems
            .OrderBy(item => item.Priority) // Sort by priority for display
            .ToList();
        }

        //----------------------------------Chart
        /// <summary>
        /// Method to display the chart with the number of requests per category
        /// </summary>
        private void DisplayChart()
        {
            // Clear existing points
            ServiceChart.Series["Column"].Points.Clear(); 

            var requestGroups = ReportIssueForm.issues
                .GroupBy(issue => issue.Category)
                .Select(group => new { Category = group.Key, Count = group.Count() });

            foreach (var group in requestGroups)
            {
                ServiceChart.Series["Column"].Points.AddXY(group.Category, group.Count);
            }
        }


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
                selectedRequest.Status = "Resolved";
                UpdateRequestStatus(selectedRequest.RequestId, "Resolved");
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
        private void rdBtnPending_CheckedChanged(object sender, EventArgs e)
        {
            if (rdBtnPending.Checked)
            {
                SortRequests("Pending");
            }
        }

        private void rdBtnInProgress_CheckedChanged(object sender, EventArgs e)
        {
            if (rdBtnInProgress.Checked)
            {
                SortRequests("In Progress");
            }
        }

        private void rdBtnSolved_CheckedChanged(object sender, EventArgs e)
        {
            if (rdBtnSolved.Checked)
            {
                SortRequests("Resolved");
            }
        }

        private void cbCategorySorting_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCategorySorting.SelectedIndex != -1)
            {
                SortRequests(cbCategorySorting.SelectedItem.ToString());
            }
        }
    }

    //------------------------------------
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
