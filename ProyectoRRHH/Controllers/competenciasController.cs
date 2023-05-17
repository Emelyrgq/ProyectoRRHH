﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProyectoRRHH.Models;

namespace ProyectoRRHH.Controllers
{
    public class competenciasController : Controller
    {
        private readonly rrhhContext _context;

        public competenciasController(rrhhContext context)
        {
            _context = context;
        }

        // GET: competencias
        public async Task<IActionResult> Index()
        {
              return _context.competencias != null ? 
                          View(await _context.competencias.ToListAsync()) :
                          Problem("Entity set 'rrhhContext.competencias'  is null.");
        }

        // GET: competencias/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.competencias == null)
            {
                return NotFound();
            }

            var competencia = await _context.competencias
                .FirstOrDefaultAsync(m => m.id == id);
            if (competencia == null)
            {
                return NotFound();
            }

            return View(competencia);
        }

        // GET: competencias/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: competencias/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,descripcion,estado")] competencia competencia)
        {
            if (ModelState.IsValid)
            {
                _context.Add(competencia);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(competencia);
        }

        // GET: competencias/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.competencias == null)
            {
                return NotFound();
            }

            var competencia = await _context.competencias.FindAsync(id);
            if (competencia == null)
            {
                return NotFound();
            }
            return View(competencia);
        }

        // POST: competencias/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,descripcion,estado")] competencia competencia)
        {
            if (id != competencia.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(competencia);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!competenciaExists(competencia.id))
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
            return View(competencia);
        }

        // GET: competencias/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.competencias == null)
            {
                return NotFound();
            }

            var competencia = await _context.competencias
                .FirstOrDefaultAsync(m => m.id == id);
            if (competencia == null)
            {
                return NotFound();
            }

            return View(competencia);
        }

        // POST: competencias/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.competencias == null)
            {
                return Problem("Entity set 'rrhhContext.competencias'  is null.");
            }
            var competencia = await _context.competencias.FindAsync(id);
            if (competencia != null)
            {
                _context.competencias.Remove(competencia);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool competenciaExists(int id)
        {
          return (_context.competencias?.Any(e => e.id == id)).GetValueOrDefault();
        }
    }
}
