using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GitHubPortal.Models
{
    public class PortalDbContext : DbContext
    {
        public PortalDbContext(DbContextOptions<PortalDbContext> options)
            : base(options)
        {
        }

        public DbSet<PortalLink> PortalLinks { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<PortalLink>().HasData(
                new PortalLink { PortalLinkId = 1, Name = "GitHub Database", Description = "This is what you're using right now! GitHub Portal is a data-driven web application built with ASP.NET Core MVC that allows users to manage a curated list of useful links.", Url = "https://github.com/fesslerjo2024/GitHubDatabase_Fessler" },
                new PortalLink { PortalLinkId = 2, Name = "AWS Cloud Portfolio Website", Description = "My personal portfolio website showcasing my projects, skills, resume, and contact information. Built with HTML, CSS, and JavaScript, the site is fully responsive and optimized for a smooth user experience.", Url = "https://github.com/fesslerjo2024/AWSCloudPortfolioWebsite_Fessler" },
                new PortalLink { PortalLinkId = 3, Name = "MarketMates Database", Description = "MarketMates is a relational database system designed as a final project for Database Concepts, Design, and Application.", Url = "https://github.com/fesslerjo2024/MarketMates_Database" },
                new PortalLink { PortalLinkId = 4, Name = "Weather App Java", Description = "Final Project for Java Class using Open-Meteo and Zippopotam.us APIs.", Url = "https://github.com/fesslerjo2024/WeatherAppJava_Fessler" },
                new PortalLink { PortalLinkId = 5, Name = "Game Interface", Description = "This project was made in my Java class to demonstrate how to use an array as well as make objects.", Url = "https://github.com/fesslerjo2024/GameInterface_Fessler" },
                new PortalLink { PortalLinkId = 6, Name = "JavaFX Circle Overlap", Description = "Assignment for my Java class to teach us how to use JavaFX to create random circles and color them when they overlap.", Url = "https://github.com/fesslerjo2024/JavaFXCircleOverlap" }
            );
        }
    }
}
