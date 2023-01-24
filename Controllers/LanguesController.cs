using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CameroonTradeInformationPortal.Data;
using CameroonTradeInformationPortal.Models;

namespace CameroonTradeInformationPortal.Controllers
{
    public class LanguesController : Controller
    {
        private readonly AppDbContext _context;

        public LanguesController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Langues
        public async Task<IActionResult> Index()
        {
            return View(await _context.Langues.ToListAsync());
        }

        // GET: Langues/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var langue = await _context.Langues
                .FirstOrDefaultAsync(m => m.Id == id);
            if (langue == null)
            {
                return NotFound();
            }

            return View(langue);
        }

        // GET: Langues/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Langues/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Titre,Code,Description")] Langue langue)
        {
            if (ModelState.IsValid)
            {
                _context.Add(langue);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(langue);
        }

        // GET: Langues/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var langue = await _context.Langues.FindAsync(id);
            if (langue == null)
            {
                return NotFound();
            }
            return View(langue);
        }

        // POST: Langues/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Titre,Code,Description")] Langue langue)
        {
            if (id != langue.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(langue);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LangueExists(langue.Id))
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
            return View(langue);
        }

        // GET: Langues/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var langue = await _context.Langues
                .FirstOrDefaultAsync(m => m.Id == id);
            if (langue == null)
            {
                return NotFound();
            }

            return View(langue);
        }

        // POST: Langues/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var langue = await _context.Langues.FindAsync(id);
            _context.Langues.Remove(langue);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LangueExists(int id)
        {
            return _context.Langues.Any(e => e.Id == id);
        }
    }
}
