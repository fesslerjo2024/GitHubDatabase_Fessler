# GitHubDatabase_Fessler
### ASP.NET Core MVC — Portal Link Manager
**Author:** Jonathan Fessler | INFO 2400

---

## Project Description

GitHub Portal is a data-driven web application built with ASP.NET Core MVC that allows users to manage a curated list of useful links. Each portal link stores a name, description, and URL. Users can browse all saved links, add new ones, edit existing ones, and delete ones they no longer need.

The app uses Entity Framework Core with SQL Server LocalDB for data storage, Bootstrap 5 for a responsive dark-themed UI, and follows standard MVC conventions with controllers, Razor views, and model binding.

No login or authorization is required — the app is open-access by design for this stage of the project.

---

## How to Run

### Prerequisites
- Visual Studio 2022 or later
- .NET 8 SDK
- SQL Server LocalDB (included with Visual Studio)

### Steps

1. Clone or download the repository and open `GitHubDatabase_Fessler.sln` in Visual Studio
2. Restore NuGet packages — Visual Studio does this automatically, or right-click the solution → **Restore NuGet Packages**
3. Open the **Package Manager Console**: Tools → NuGet Package Manager → Package Manager Console
4. Run the migration to create the database: Update-Database
5. Press **F5** to run — the browser will open directly to the Portal Links page

---

### Connection String (appsettings.json)
"ConnectionStrings": {
"DefaultConnection": "Server=(localdb)\mssqllocaldb;Database=GitHubPortalDb;Trusted_Connection=True;MultipleActiveResultSets=true"
}

## Manual Test Cases

| # | Test Case | Steps | Expected Result |
|---|-----------|-------|-----------------|
| 1 | **List page loads from database** | Run the app and navigate to the home page | All 8 seeded portal links display as cards |
| 2 | **Add a new portal link** | Click "Add New Link" → fill in Name, Description, URL → click "Save Link" | Redirected to Index; new card appears in the list |
| 3 | **Edit an existing portal link** | Click the pencil icon on any card → change the Name → click "Save Changes" | Redirected to Index; card shows the updated name |
| 4 | **Delete a portal link** | Click the trash icon on any card → click "Yes, Delete It" | Link is removed from the list |
| 5 | **Search filters results** | Type "GitHub" in the search box → click Search | Only cards matching "GitHub" in name or description are shown |
| 6 | **Clear search restores full list** | After searching, click the X button | All portal links are shown again |
| 7 | **Visit link opens in new tab** | Click the "Visit" button on any card | The destination URL opens in a new browser tab |
| 8 | **Data persists across runs** | Add a new link → stop the app → restart | The new link still appears after restart |

## Debugging Notes

### 1. 'Index' Was Not Found
I was having a little bit of difficulty with the way that my project opened up. When started it would give me an exception that said: An unhandled exception occurred while processing the request.
InvalidOperationException: The view 'Index' was not found. The following locations were searched: /Views/PortalLinks/Index.cshtml /Views/Shared/Index.cshtml. After a bit of troubleshooting I realized that I had forgotten to rename the MapControllerRoute in Program.cs to the proper controller. After that it seemed to work fine.

### 2. Database Connection
Getting the database to connect has been a problem for a lot of my fellow classmates myself include. For the longest time we had been doing it wrong and when I worked on this project I had forgotten the way we were supposed to do it. I used ChatGPT to help me understand exactly what I had to do so that the database would be created properly.

---

## Technologies Used

- ASP.NET Core MVC (.NET 8)
- Entity Framework Core 8 (Code First + Migrations)
- SQL Server LocalDB
- Bootstrap 5.3
- Bootstrap Icons 1.11
- Razor Views with Tag Helpers
- TempData for post-redirect success messages
- ViewBag for search query passback
