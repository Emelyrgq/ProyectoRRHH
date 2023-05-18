using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProyectoRRHH.Models;

namespace ProyectoRRHH.Controllers
{
    public class EmpleadosController : Controller
    {
        private readonly rrhhContext _context;

        public EmpleadosController(rrhhContext context)
        {
            _context = context;
        }

        // GET: empleadoes
        public async Task<IActionResult> Index()
        {
            var rrhhContext = _context.empleados.Include(e => e.cedulaNavigation).Include(e => e.departamentoNavigation).Include(e => e.puestoNavigation);
            return View(await rrhhContext.ToListAsync());
        }

        // GET: empleadoes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.empleados == null)
            {
                return NotFound();
            }

            var empleado = await _context.empleados
                .Include(e => e.cedulaNavigation)
                .Include(e => e.departamentoNavigation)
                .Include(e => e.puestoNavigation)
                .FirstOrDefaultAsync(m => m.id == id);
            if (empleado == null)
            {
                return NotFound();
            }

            return View(empleado);
        }

        // GET: empleadoes/Create
        public IActionResult Create()
        {
            ViewData["cedula"] = new SelectList(_context.candidatos, "cedula", "cedula");
            ViewData["departamento"] = new SelectList(_context.departamentos, "departamento1", "departamento1");
            ViewData["puesto"] = new SelectList(_context.puestos, "nombre", "nombre");
            return View();
        }

        // POST: empleadoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,cedula,nombre,fechaingreso,departamento,puesto,salariomensual,estado")] empleado empleado)
        {
            if (ModelState.IsValid)
            {
                _context.Add(empleado);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["cedula"] = new SelectList(_context.candidatos, "cedula", "cedula", empleado.cedula);
            ViewData["departamento"] = new SelectList(_context.departamentos, "departamento1", "departamento1", empleado.departamento);
            ViewData["puesto"] = new SelectList(_context.puestos, "nombre", "nombre", empleado.puesto);
            return View(empleado);
        }

        // GET: empleadoes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.empleados == null)
            {
                return NotFound();
            }

            var empleado = await _context.empleados.FindAsync(id);
            if (empleado == null)
            {
                return NotFound();
            }
            ViewData["cedula"] = new SelectList(_context.candidatos, "cedula", "cedula", empleado.cedula);
            ViewData["departamento"] = new SelectList(_context.departamentos, "departamento1", "departamento1", empleado.departamento);
            ViewData["puesto"] = new SelectList(_context.puestos, "nombre", "nombre", empleado.puesto);
            return View(empleado);
        }

        // POST: empleadoes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,cedula,nombre,fechaingreso,departamento,puesto,salariomensual,estado")] empleado empleado)
        {
            if (id != empleado.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(empleado);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!empleadoExists(empleado.id))
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
            ViewData["cedula"] = new SelectList(_context.candidatos, "cedula", "cedula", empleado.cedula);
            ViewData["departamento"] = new SelectList(_context.departamentos, "departamento1", "departamento1", empleado.departamento);
            ViewData["puesto"] = new SelectList(_context.puestos, "nombre", "nombre", empleado.puesto);
            return View(empleado);
        }

        // GET: empleadoes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.empleados == null)
            {
                return NotFound();
            }

            var empleado = await _context.empleados
                .Include(e => e.cedulaNavigation)
                .Include(e => e.departamentoNavigation)
                .Include(e => e.puestoNavigation)
                .FirstOrDefaultAsync(m => m.id == id);
            if (empleado == null)
            {
                return NotFound();
            }

            return View(empleado);
        }

        // POST: empleadoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.empleados == null)
            {
                return Problem("Entity set 'rrhhContext.empleados'  is null.");
            }
            var empleado = await _context.empleados.FindAsync(id);
            if (empleado != null)
            {
                _context.empleados.Remove(empleado);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool empleadoExists(int id)
        {
          return (_context.empleados?.Any(e => e.id == id)).GetValueOrDefault();
        }
    }
}
