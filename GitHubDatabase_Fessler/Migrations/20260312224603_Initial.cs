using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GitHubDatabase_Fessler.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PortalLinks",
                columns: table => new
                {
                    PortalLinkId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PortalLinks", x => x.PortalLinkId);
                });

            migrationBuilder.InsertData(
                table: "PortalLinks",
                columns: new[] { "PortalLinkId", "Description", "Name", "Url" },
                values: new object[,]
                {
                    { 1, "The world's leading platform for version control and collaborative software development.", "GitHub", "https://github.com" },
                    { 2, "The largest Q&A community for developers to learn, share knowledge, and build careers.", "Stack Overflow", "https://stackoverflow.com" },
                    { 3, "Official Microsoft documentation for .NET, ASP.NET Core, Azure, and all Microsoft technologies.", "Microsoft Docs", "https://docs.microsoft.com" },
                    { 4, "Mozilla's comprehensive reference for HTML, CSS, and JavaScript web development.", "MDN Web Docs", "https://developer.mozilla.org" },
                    { 5, "The package manager for .NET — browse and download open-source libraries for your projects.", "NuGet Gallery", "https://www.nuget.org" },
                    { 6, "Official Bootstrap 5 documentation for building responsive, mobile-first websites.", "Bootstrap Docs", "https://getbootstrap.com/docs" },
                    { 7, "Microsoft's official EF Core documentation for database access in .NET applications.", "Entity Framework Docs", "https://learn.microsoft.com/en-us/ef/core/" },
                    { 8, "Beginner-friendly tutorials and references for HTML, CSS, JavaScript, SQL, and more.", "W3Schools", "https://www.w3schools.com" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PortalLinks");
        }
    }
}
