using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using GitHubPortal.Models;

namespace GitHubPortal.Controllers
{
    public class PortalLinksController : Controller
    {
        private readonly PortalDbContext _context;

        public PortalLinksController(PortalDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index(string searchQuery)
        {
            ViewBag.SearchQuery = searchQuery;

            var links = _context.PortalLinks.AsQueryable();

            if (!string.IsNullOrWhiteSpace(searchQuery))
            {
                links = links.Where(p =>
                    p.Name.Contains(searchQuery) ||
                    p.Description.Contains(searchQuery));
            }

            return View(await links.ToListAsync());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Name,Description,Url")] PortalLink portalLink)
        {
            _context.Add(portalLink);
            await _context.SaveChangesAsync();
            TempData["SuccessMessage"] = $"Portal link \"{portalLink.Name}\" was added successfully!";
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) return NotFound();

            var portalLink = await _context.PortalLinks.FindAsync(id);
            if (portalLink == null) return NotFound();

            return View(portalLink);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PortalLinkId,Name,Description,Url")] PortalLink portalLink)
        {
            if (id != portalLink.PortalLinkId) return NotFound();

            _context.Update(portalLink);
            await _context.SaveChangesAsync();
            TempData["SuccessMessage"] = $"Portal link \"{portalLink.Name}\" was updated successfully!";
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();

            var portalLink = await _context.PortalLinks
                .FirstOrDefaultAsync(m => m.PortalLinkId == id);
            if (portalLink == null) return NotFound();

            return View(portalLink);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var portalLink = await _context.PortalLinks.FindAsync(id);
            if (portalLink != null)
            {
                string name = portalLink.Name;
                _context.PortalLinks.Remove(portalLink);
                await _context.SaveChangesAsync();
                TempData["SuccessMessage"] = $"Portal link \"{name}\" was deleted.";
            }
            return RedirectToAction(nameof(Index));
        }
    }
}
