using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PruebaProgresoI.Data;
using PruebaProgresoI.Models;

namespace PruebaProgresoI.Controllers
{
    public class LCandoesController : Controller
    {
        
        private readonly PruebaProgresoIContext _context;

        public LCandoesController(PruebaProgresoIContext context)
        {
            _context = context;
        }

        // GET: LCandoes
        public async Task<IActionResult> Index()
        {
            return View(await _context.LCando.ToListAsync());
        }

        // GET: LCandoes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lCando = await _context.LCando
                .FirstOrDefaultAsync(m => m.Id == id);
            if (lCando == null)
            {
                return NotFound();
            }

            return View(lCando);
        }

        // GET: LCandoes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: LCandoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Precio,Nombre,EstaActivo,Fecha")] LCando lCando)
        {
            if (ModelState.IsValid)
            {
                _context.Add(lCando);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(lCando);
        }

        // GET: LCandoes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lCando = await _context.LCando.FindAsync(id);
            if (lCando == null)
            {
                return NotFound();
            }
            return View(lCando);
        }

        // POST: LCandoes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Precio,Nombre,EstaActivo,Fecha")] LCando lCando)
        {
            if (id != lCando.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(lCando);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LCandoExists(lCando.Id))
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
            return View(lCando);
        }

        // GET: LCandoes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lCando = await _context.LCando
                .FirstOrDefaultAsync(m => m.Id == id);
            if (lCando == null)
            {
                return NotFound();
            }

            return View(lCando);
        }

        // POST: LCandoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var lCando = await _context.LCando.FindAsync(id);
            if (lCando != null)
            {
                _context.LCando.Remove(lCando);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LCandoExists(int id)
        {
            return _context.LCando.Any(e => e.Id == id);
        }
    }
}
