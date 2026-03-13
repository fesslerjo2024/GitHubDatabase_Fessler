using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GitHubDatabase_Fessler.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
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
                    { 1, "This is what you're using right now! GitHub Portal is a data-driven web application built with ASP.NET Core MVC that allows users to manage a curated list of useful links.", "GitHub Database", "https://github.com/fesslerjo2024/GitHubDatabase_Fessler" },
                    { 2, "My personal portfolio website showcasing my projects, skills, resume, and contact information. Built with HTML, CSS, and JavaScript, the site is fully responsive and optimized for a smooth user experience.", "AWS Cloud Portfolio Website", "https://github.com/fesslerjo2024/AWSCloudPortfolioWebsite_Fessler" },
                    { 3, "MarketMates is a relational database system designed as a final project for Database Concepts, Design, and Application.", "MarketMates Database", "https://github.com/fesslerjo2024/MarketMates_Database" },
                    { 4, "Final Project for Java Class using Open-Meteo and Zippopotam.us APIs.", "Weather App Java", "https://github.com/fesslerjo2024/WeatherAppJava_Fessler" },
                    { 5, "This project was made in my Java class to demonstrate how to use an array as well as make objects.", "Game Interface", "https://github.com/fesslerjo2024/GameInterface_Fessler" },
                    { 6, "Assignment for my Java class to teach us how to use JavaFX to create random circles and color them when they overlap.", "JavaFX Circle Overlap", "https://github.com/fesslerjo2024/JavaFXCircleOverlap" }
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
