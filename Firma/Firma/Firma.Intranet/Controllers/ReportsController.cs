﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Firma.Data.Data;
using Firma.Data.Data.Sklep;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Firma.Intranet.Controllers
{
    public class ReportsController : Controller
    {
        private readonly FirmaContext _context;

        public ReportsController(FirmaContext context)
        {
            _context = context;
        }

        // GET: Reports
        public async Task<IActionResult> Index()
        {
            return View(await _context.Reports.ToListAsync());
        }

        // GET: Reports/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reports = await _context.Reports
                .FirstOrDefaultAsync(m => m.IdReports == id);
            if (reports == null)
            {
                return NotFound();
            }

            return View(reports);
        }

        // GET: Reports/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Reports/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdReports,Title,Description,Date,User,Product")] Reports reports)
        {
            if (ModelState.IsValid)
            {
                _context.Add(reports);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(reports);
        }

        // GET: Reports/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reports = await _context.Reports.FindAsync(id);
            if (reports == null)
            {
                return NotFound();
            }
            return View(reports);
        }

        // POST: Reports/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdReports,Title,Description,Date,User,Product")] Reports reports)
        {
            if (id != reports.IdReports)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(reports);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ReportsExists(reports.IdReports))
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
            return View(reports);
        }

        // GET: Reports/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reports = await _context.Reports
                .FirstOrDefaultAsync(m => m.IdReports == id);
            if (reports == null)
            {
                return NotFound();
            }

            return View(reports);
        }

        // POST: Reports/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var reports = await _context.Reports.FindAsync(id);
            if (reports != null)
            {
                _context.Reports.Remove(reports);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ReportsExists(int id)
        {
            return _context.Reports.Any(e => e.IdReports == id);
        }
    }
}
