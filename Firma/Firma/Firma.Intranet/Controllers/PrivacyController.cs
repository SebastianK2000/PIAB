using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Firma.Data.Data;
using Firma.Data.Data.Sklep;

namespace Firma.Intranet.Controllers
{
    public class PrivacyController : Controller
    {
        private readonly FirmaContext _context;

        public PrivacyController(FirmaContext context)
        {
            _context = context;
        }

        // GET: Privacy
        public async Task<IActionResult> Index()
        {
            return View(await _context.Privacy.ToListAsync());
        }

        // GET: Privacy/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var privacy = await _context.Privacy
                .FirstOrDefaultAsync(m => m.IdPrivacy == id);
            if (privacy == null)
            {
                return NotFound();
            }

            return View(privacy);
        }

        // GET: Privacy/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Privacy/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdPrivacy,PageName,Title,Introduction,InformationWeCollect,HowWeUseInformation,DataSecurity,Cookies,ThirdPartyDisclosure,YourConsent")] Privacy privacy)
        {
            if (ModelState.IsValid)
            {
                _context.Add(privacy);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(privacy);
        }

        // GET: Privacy/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var privacy = await _context.Privacy.FindAsync(id);
            if (privacy == null)
            {
                return NotFound();
            }
            return View(privacy);
        }

        // POST: Privacy/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdPrivacy,PageName,Title,Introduction,InformationWeCollect,HowWeUseInformation,DataSecurity,Cookies,ThirdPartyDisclosure,YourConsent")] Privacy privacy)
        {
            if (id != privacy.IdPrivacy)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(privacy);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PrivacyExists(privacy.IdPrivacy))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(privacy);
        }

        // GET: Privacy/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var privacy = await _context.Privacy
                .FirstOrDefaultAsync(m => m.IdPrivacy == id);
            if (privacy == null)
            {
                return NotFound();
            }

            return View(privacy);
        }

        // POST: Privacy/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var privacy = await _context.Privacy.FindAsync(id);
            if (privacy != null)
            {
                _context.Privacy.Remove(privacy);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PrivacyExists(int id)
        {
            return _context.Privacy.Any(e => e.IdPrivacy == id);
        }
    }
}
