# PROG_3B_POE
# Overview
The Municipal Services Application is a Windows Forms application created in C# to improve public participation with local governments. Citizens may use the app to report concerns, browse local events and news, request services, and receive updates on their requests. The program aims to enhance service delivery and make it easier for individuals to keep the community informed about local issues.

# Features
1. Report issue
    - Citizens can report concerns such as roadblocks, sanitation, or utilities by submitting         information such as location, issue type, description, and media assets.
    - Issues are shown in user control for practical tracking and better UX.
    - User are also able to create new reports by filling the report form.
      
2. Local events and announcements
   - View upcoming events and key notifications issued by the municipality.
   - Users are also able to create new events by filling the event form.
   - Includes:
      Event name, date, location, category, description, and an image.
   - A "Join" button to enroll for events and record preferences for future recommendations.
      Advanced filtering by:
         Name
         Category           
         Date
     
3. Service Request
      - Allows users to keep track of their submitted reports using unique identifiers and key            works to search for their reports.
         Includes a Service Request Status feature using advanced data structures:
         Trees: Organize requests hierarchically for fast lookup.
         Graphs: Track dependencies or related service tasks.
         Heaps: Prioritize urgent requests.
         Algorithms: Efficient traversal and status updates.

4. Dashboard
      -  Overview of all active issues, service requests, and latest announcements.
      -  The dashboard also has a bargraph that represents the total amount of different reports

5. Data Download
      - Users can export data from the Service Request section into a CSV file for offline             access.
      Saves data from the DataGridView with:
      Column headers.
      User-friendly file selection via SaveFileDialog.
      This can be achieved by the user by clicking on the export button on the service request         form below the data grid view.

6. App tour
         - A tooltip fature that will give tips or guidance to users when they houver the mouse            to the buttons of the application
   
7. Side bar
          - User can hide and expand the side bar by clicking on the hamburger icon.
    
8. Progress bar
      -  There is a progressbar that tracks the users progress when the user starts to filling          in the report issu form the bar processes based on the information provided by the user.
   
# ********************************** Usage Guide ******************************
  # Reporting an Issue
1. Navigate to the Report Issue section.
2. Enter the issue location, category, and a brief description of the problem.
3. Optionally, attach a file (e.g., an image of the issue).
4. Click Submit to save the issue. The issue will be displayed in the Issues List grid for tracking.
   
# Viewing Local Events and Announcements
1. Navigate to the Local Events and Announcements section.
2. View the list of upcoming events or important announcements made by the municipality.
3. Users can join the event by clicking on the join button in the user control form.
   
# Tracking a Service 🖲
1. Go to the Service Request section.
3. Select the service you wish to track and click Ctrl C and past on the track ID textbox  
4. Click on the track button to track the service selected.
   
# Downloading Service Request Data
1. Go to the Service Request section.
2. Click the Download Data button.
3. Choose a location and filename in the Save File Dialog to export the data in CSV format.

# Dashboard Overview
1. Navigate to the Dashboard section.
2. View:
      The Bar Chart for issue counts by category.
      Summaries of recent reports and upcoming events.
3. Charts and data are dynamically updated from service requests.

# How to compile
   *********** Prerequisites ***********
      Visual Studio 2022 or later.
      .NET Framework installed on your machine.
      
# How to Compile
Clone or download the repository:

https://github.com/st10068763/Community_Service_App/edit/master/

Once downloaded extratct it and open the .sln file with  Visual Studio 2022 or later.
