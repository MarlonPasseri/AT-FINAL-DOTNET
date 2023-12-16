using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AT_DE_JAVA.Data;
using AT_DE_JAVA.Models;

namespace AT_DE_JAVA.Controllers
{
    public class TalheresController : Controller
    {
        private readonly AT_DE_JAVAContext _context;

        public TalheresController(AT_DE_JAVAContext context)
        {
            _context = context;
        }

        // GET: Talheres
        public async Task<IActionResult> Index()
        {
              return _context.Talheres != null ? 
                          View(await _context.Talheres.ToListAsync()) :
                          Problem("Entity set 'AT_DE_JAVAContext.Talheres'  is null.");
        }

        // GET: Talheres/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Talheres == null)
            {
                return NotFound();
            }

            var talheres = await _context.Talheres
                .FirstOrDefaultAsync(m => m.id == id);
            if (talheres == null)
            {
                return NotFound();
            }

            return View(talheres);
        }

        // GET: Talheres/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Talheres/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,nome,preço")] Talheres talheres)
        {
            if (ModelState.IsValid)
            {
                _context.Add(talheres);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(talheres);
        }

        // GET: Talheres/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Talheres == null)
            {
                return NotFound();
            }

            var talheres = await _context.Talheres.FindAsync(id);
            if (talheres == null)
            {
                return NotFound();
            }
            return View(talheres);
        }

        // POST: Talheres/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,nome,preço")] Talheres talheres)
        {
            if (id != talheres.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(talheres);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TalheresExists(talheres.id))
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
            return View(talheres);
        }

        // GET: Talheres/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Talheres == null)
            {
                return NotFound();
            }

            var talheres = await _context.Talheres
                .FirstOrDefaultAsync(m => m.id == id);
            if (talheres == null)
            {
                return NotFound();
            }

            return View(talheres);
        }

        // POST: Talheres/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Talheres == null)
            {
                return Problem("Entity set 'AT_DE_JAVAContext.Talheres'  is null.");
            }
            var talheres = await _context.Talheres.FindAsync(id);
            if (talheres != null)
            {
                _context.Talheres.Remove(talheres);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TalheresExists(int id)
        {
          return (_context.Talheres?.Any(e => e.id == id)).GetValueOrDefault();
        }
    }
}
