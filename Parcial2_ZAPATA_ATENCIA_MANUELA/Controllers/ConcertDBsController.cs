using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Parcial2_ZAPATA_ATENCIA_MANUELA.DAL;
using Parcial2_ZAPATA_ATENCIA_MANUELA.DAL.Entities;

namespace Parcial2_ZAPATA_ATENCIA_MANUELA.Controllers
{
    public class ConcertDBsController : Controller
    {
        private readonly DataBaseContext _context;

        public ConcertDBsController(DataBaseContext context)
        {
            _context = context;
        }

        // GET: ConcertDBs
        public async Task<IActionResult> Index()
        {
              return _context.ConcertsDBs != null ? 
                          View(await _context.ConcertsDBs.ToListAsync()) :
                          Problem("Entity set 'DataBaseContext.ConcertsDBs'  is null.");
        }

        // GET: ConcertDBs/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null || _context.ConcertsDBs == null)
            {
                return NotFound();
            }

            var concertDB = await _context.ConcertsDBs
                .FirstOrDefaultAsync(m => m.Id == id);
            if (concertDB == null)
            {
                return NotFound();
            }

            return View(concertDB);
        }

        // GET: ConcertDBs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ConcertDBs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create (ConcertDB concertDB)
        {
            if (ModelState.IsValid)
            {
                concertDB.Id = Guid.NewGuid();
                _context.Add(concertDB);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(concertDB);
        }

        // GET: ConcertDBs/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null || _context.ConcertsDBs == null)
            {
                return NotFound();
            }

            var concertDB = await _context.ConcertsDBs.FindAsync(id);
            if (concertDB == null)
            {
                return NotFound();
            }
            return View(concertDB);
        }

        // POST: ConcertDBs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, ConcertDB concertDB)
        {
            if (id != concertDB.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(concertDB);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ConcertDBExists(concertDB.Id))
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
            return View(concertDB);
        }

        // GET: ConcertDBs/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null || _context.ConcertsDBs == null)
            {
                return NotFound();
            }

            var concertDB = await _context.ConcertsDBs
                .FirstOrDefaultAsync(m => m.Id == id);
            if (concertDB == null)
            {
                return NotFound();
            }

            return View(concertDB);
        }

        // POST: ConcertDBs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            if (_context.ConcertsDBs == null)
            {
                return Problem("Entity set 'DataBaseContext.ConcertsDBs'  is null.");
            }
            var concertDB = await _context.ConcertsDBs.FindAsync(id);
            if (concertDB != null)
            {
                _context.ConcertsDBs.Remove(concertDB);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ConcertDBExists(Guid id)
        {
          return (_context.ConcertsDBs?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
