CityConnect - Municipal Service Application (.NET Windows Form)

Application Overview
CityConnect is a municipal services application that was built using .NET Windows Forms (C#)
The application allows for South African residents to:
- Report issues such as sanitation, roads and utilities.
- Recieve engagement feedback and notifications when submitting reports.
- View all submitted issues.
- (Modules to come) Access local events and track service request statuses.

  **Important:** A custom-built linked list data structures is used to store issues, as required.
  No built-in generic collections ('List<T>', arrays) are used for the main issue storage.

  Project Structure as follws:
  **Controllers**
  - HomeController.cs
  - IssuesController.cs
 
    **Models**
    - Issues.cs
    - IssueNode.cs
    - IssueLinkedList.cs
    - IssuesStore.cs
   
      **Views**
      -Home - Index.cshtml
      -Issues - Repprt.cshtml
      -Issues - List.cshtml

      Software Requirements
      - .NET Framework 4,7,2 or higher (works with .NET Windows Forms)
      - Visual Studio 2019 or later (Community Edition ot higher) for source code compilation
      - Windows OS
     
        How to Compile:
        1. Open the MunicipalServicesApp in Visual Studio
        2. Build the solution (Ctrl+Shift+B)
       
           How to Run the Application:
           1. Press F5 or select "Start Debugging"
           2. Main Menu appears with three options (Report Issues Enabled, others disabled.)
           3. Click "Report Issues" to submit a new issue.
          
              Usage:
              1. Enter location in the textbox.
              2. Select a category from the dropdown,
              3. Provide detailed description.
              4. Click "Attach" to add images/documents.
              5. Click "Submit" to save the report.
              6. Engagement feedback will appear, and the form will reset for another submission.
              7. Click "back" to return to the main menu.
             
                 Data Storage:
                 - Issues are stored in-memory using a List<Issue> for this version.
                 - Attachments are stored as file paths.

            Push Code to GitHub
