using GitHubPortal.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add MVC (not Razor Pages)
builder.Services.AddControllersWithViews();

// Register EF Core with SQL Server LocalDB
builder.Services.AddDbContext<PortalDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

// MVC conventional routing
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=PortalLinks}/{action=Index}/{id?}");

app.Run();