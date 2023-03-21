using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SistemaWebMvc.Data;
using SistemaWebMvc.Models;

namespace SistemaWebMvc.Controllers
{
    public class RegistrodeVendasController : Controller
    {
        private readonly SistemaWebMvcContext _context;

        public RegistrodeVendasController(SistemaWebMvcContext context)
        {
            _context = context;
        }

        // GET: RegistrodeVendas
        public async Task<IActionResult> Index()
        {
              return View(await _context.RegistrodeVenda.ToListAsync());
        }

        // GET: RegistrodeVendas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.RegistrodeVenda == null)
            {
                return NotFound();
            }

            var registrodeVenda = await _context.RegistrodeVenda
                .FirstOrDefaultAsync(m => m.Id == id);
            if (registrodeVenda == null)
            {
                return NotFound();
            }

            return View(registrodeVenda);
        }

        // GET: RegistrodeVendas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: RegistrodeVendas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Data,Valor,status")] RegistrodeVenda registrodeVenda)
        {
            if (ModelState.IsValid)
            {
                _context.Add(registrodeVenda);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(registrodeVenda);
        }

        // GET: RegistrodeVendas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.RegistrodeVenda == null)
            {
                return NotFound();
            }

            var registrodeVenda = await _context.RegistrodeVenda.FindAsync(id);
            if (registrodeVenda == null)
            {
                return NotFound();
            }
            return View(registrodeVenda);
        }

        // POST: RegistrodeVendas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Data,Valor,status")] RegistrodeVenda registrodeVenda)
        {
            if (id != registrodeVenda.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(registrodeVenda);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RegistrodeVendaExists(registrodeVenda.Id))
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
            return View(registrodeVenda);
        }

        // GET: RegistrodeVendas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.RegistrodeVenda == null)
            {
                return NotFound();
            }

            var registrodeVenda = await _context.RegistrodeVenda
                .FirstOrDefaultAsync(m => m.Id == id);
            if (registrodeVenda == null)
            {
                return NotFound();
            }

            return View(registrodeVenda);
        }

        // POST: RegistrodeVendas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.RegistrodeVenda == null)
            {
                return Problem("Entity set 'SistemaWebMvcContext.RegistrodeVenda'  is null.");
            }
            var registrodeVenda = await _context.RegistrodeVenda.FindAsync(id);
            if (registrodeVenda != null)
            {
                _context.RegistrodeVenda.Remove(registrodeVenda);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RegistrodeVendaExists(int id)
        {
          return _context.RegistrodeVenda.Any(e => e.Id == id);
        }
    }
}
