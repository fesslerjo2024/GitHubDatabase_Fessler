using Microsoft.EntityFrameworkCore;

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

            // Seed data - 8 sample portal links (Extra Credit)
            modelBuilder.Entity<PortalLink>().HasData(
                new PortalLink { PortalLinkId = 1, Name = "GitHub", Description = "The world's leading platform for version control and collaborative software development.", Url = "https://github.com" },
                new PortalLink { PortalLinkId = 2, Name = "Stack Overflow", Description = "The largest Q&A community for developers to learn, share knowledge, and build careers.", Url = "https://stackoverflow.com" },
                new PortalLink { PortalLinkId = 3, Name = "Microsoft Docs", Description = "Official Microsoft documentation for .NET, ASP.NET Core, Azure, and all Microsoft technologies.", Url = "https://docs.microsoft.com" },
                new PortalLink { PortalLinkId = 4, Name = "MDN Web Docs", Description = "Mozilla's comprehensive reference for HTML, CSS, and JavaScript web development.", Url = "https://developer.mozilla.org" },
                new PortalLink { PortalLinkId = 5, Name = "NuGet Gallery", Description = "The package manager for .NET — browse and download open-source libraries for your projects.", Url = "https://www.nuget.org" },
                new PortalLink { PortalLinkId = 6, Name = "Bootstrap Docs", Description = "Official Bootstrap 5 documentation for building responsive, mobile-first websites.", Url = "https://getbootstrap.com/docs" },
                new PortalLink { PortalLinkId = 7, Name = "Entity Framework Docs", Description = "Microsoft's official EF Core documentation for database access in .NET applications.", Url = "https://learn.microsoft.com/en-us/ef/core/" },
                new PortalLink { PortalLinkId = 8, Name = "W3Schools", Description = "Beginner-friendly tutorials and references for HTML, CSS, JavaScript, SQL, and more.", Url = "https://www.w3schools.com" }
            );
        }
    }
}
