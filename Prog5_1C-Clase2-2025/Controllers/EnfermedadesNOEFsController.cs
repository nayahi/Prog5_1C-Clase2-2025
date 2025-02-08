using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MVC2.Data;
using MVC2.Models;

namespace Prog5_1C_Clase2_2025.Controllers
{
    public class EnfermedadesNOEFsController : Controller
    {
        private readonly AppDbContext _context;

        public EnfermedadesNOEFsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: EnfermedadesNOEFs
        public async Task<IActionResult> Index()
        {
            return View(await _context.EnfermedadesNOEF.ToListAsync());
        }

        // GET: EnfermedadesNOEFs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var enfermedadesNOEF = await _context.EnfermedadesNOEF
                .FirstOrDefaultAsync(m => m.Id == id);
            if (enfermedadesNOEF == null)
            {
                return NotFound();
            }

            return View(enfermedadesNOEF);
        }

        // GET: EnfermedadesNOEFs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: EnfermedadesNOEFs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Enfermedad")] EnfermedadesNOEF enfermedadesNOEF)
        {
            if (ModelState.IsValid)
            {
                _context.Add(enfermedadesNOEF);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(enfermedadesNOEF);
        }

        // GET: EnfermedadesNOEFs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var enfermedadesNOEF = await _context.EnfermedadesNOEF.FindAsync(id);
            if (enfermedadesNOEF == null)
            {
                return NotFound();
            }
            return View(enfermedadesNOEF);
        }

        // POST: EnfermedadesNOEFs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Enfermedad")] EnfermedadesNOEF enfermedadesNOEF)
        {
            if (id != enfermedadesNOEF.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(enfermedadesNOEF);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EnfermedadesNOEFExists(enfermedadesNOEF.Id))
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
            return View(enfermedadesNOEF);
        }

        // GET: EnfermedadesNOEFs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var enfermedadesNOEF = await _context.EnfermedadesNOEF
                .FirstOrDefaultAsync(m => m.Id == id);
            if (enfermedadesNOEF == null)
            {
                return NotFound();
            }

            return View(enfermedadesNOEF);
        }

        // POST: EnfermedadesNOEFs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var enfermedadesNOEF = await _context.EnfermedadesNOEF.FindAsync(id);
            if (enfermedadesNOEF != null)
            {
                _context.EnfermedadesNOEF.Remove(enfermedadesNOEF);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EnfermedadesNOEFExists(int id)
        {
            return _context.EnfermedadesNOEF.Any(e => e.Id == id);
        }
    }
}
