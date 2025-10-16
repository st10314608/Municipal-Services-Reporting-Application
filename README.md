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

           Part 2 with updated implemented features:

  Residents are now able to:
•	Report issues such as road damages or sanitation problems.
•	View local events and municipal announcements.
•	And later on, track the status of their service request that they have submitted.

How to Compile and Run this new and updated Application:
1.	Open Visual Studio.
2.	Go to File – Open – Project/Solution.
3.	Click on the File named: Municipal_Services_Reporting_Application.sIn
4.	Rebuild the project and then Run the application.

How to use the Application:
1.	MainMenu
•	The main menu contains three options:
•	Report Issues
•	Local Events and Announcements
•	Service Request Status
•	And Exit button to close the application. 

2.	Report Issues
•	Enter the location of the issues
•	Select a Category
•	Provide a detailed description of the issue
•	Attach any relevant images or documents
•	Click submit to report the issue
•	Click back to return to the Main Menu.

3.	Local Events and Announcements
•	Vie a list of upcoming municipal events.
•	Use the search bar to find events by keyword or category.
•	Events are stored using sorted dictionaries for efficient retrieval.
•	The system provides recommended events based on previous searches.

Data Structures Used:
-	CustonQueue<T> - Manages the issue submissions.
-	CustomStack<T> - Tracks recently viewed events.
-	CustomSet<T> - Stores unique event categories.
-	EventHashTable – Tracks search frequency for recommendations.
-	SortedDictionary<DateTime, Lost<EventItem>> - Organizes events by date. 

Project Contents:
-	MainMenuForm – Application entry point.
-	ReportIssuesForm – Issue submission form.
-	LocalEventsForm – Displays events and recommendations.
-	Models – Folder – Handles button logic and form interactions.

This project was developed as part of my PROG7312 Portfolio of Evidence to demonstrate my understanding of:
-	Event-driven programming.
-	Custom data structures.
-	GUI development using Windows Forms.
-	Applying algorithms for real-world problem solving in South African Municipalities. 

References

Hart, T.G.B., Chitiga-Mabugu, M.R. and Kibirige, D. (2019) ‘Innovation for development in South Africa: Experiences with basic service technologies in distressed municipalities’, Forum for Development Studies, 47 (1), pp. 23–47. Available at: https://doi.org/10.1080/08039410.2019.1609658
 (Accessed 20 February 2025).

Microsoft Corporation (2024) .NET Framework developer guide. Available at: https://learn.microsoft.com/en-us/dotnet/framework/
 (Accessed 16 October 2025).

Microsoft Corporation (2024) Windows Forms documentation. Available at: https://learn.microsoft.com/en-us/dotnet/desktop/winforms/
 (Accessed 16 October 2025).

OpenAI (2025) ChatGPT (GPT-5) [AI large language model]. San Francisco: OpenAI. Available at: https://chat.openai.com/
 (Accessed 16 October 2025).

Reynolds, F. (2025) Municipal Services Reporting Application – Part 1 and Part 2 (source code). GitHub repository. Available at: https://github.com/st10314608/Municipal-Services-Reporting-Application
 (Accessed 16 October 2025).

Stack Overflow Community (2024) Discussions on WinForms event handling and file locking errors. Available at: https://stackoverflow.com/
 (Accessed 16 October 2025).

