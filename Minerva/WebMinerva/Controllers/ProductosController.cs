using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebMinerva.Models;

namespace WebMinerva.Controllers
{
    public class ProductosController : Controller
    {
        private readonly MinervaContext _context;

        public ProductosController(MinervaContext context)
        {
            _context = context;
        }

        // GET: Productos
        public async Task<IActionResult> Index()
        {
            var minervaContext = _context.Producto
                .Include(p => p.IdUnidadMedidaNavigation)
                .Where(p => p.Estado == 1)
                .OrderBy(p => p.Descripcion);
            return View(await minervaContext.ToListAsync());
        }

        // GET: Productos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var producto = await _context.Producto
                .Include(p => p.IdUnidadMedidaNavigation)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (producto == null)
            {
                return NotFound();
            }

            return View(producto);
        }

        // GET: Productos/Create
        public IActionResult Create()
        {
            ViewData["IdUnidadMedida"] = new SelectList(_context.UnidadMedida, "Id", "Descripcion");
            return View();
        }

        private bool validar(Producto producto)
        {
            return !string.IsNullOrWhiteSpace(producto.Codigo) ||
                !string.IsNullOrWhiteSpace(producto.Descripcion) ||
                producto.IdUnidadMedida == 0 || producto.PrecioVenta == 0;
        }

        // POST: Productos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Producto producto)
        {
            if (validar(producto))
            {
                producto.UsuarioRegistro = "admin";
                producto.FechaRegistro = DateTime.Now;
                producto.Estado = 1;
                _context.Add(producto);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdUnidadMedida"] = new SelectList(_context.UnidadMedida, "Id", "Descripcion", producto.IdUnidadMedida);
            return View(producto);
        }

        // GET: Productos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var producto = await _context.Producto.FindAsync(id);
            if (producto == null)
            {
                return NotFound();
            }
            ViewData["IdUnidadMedida"] = new SelectList(_context.UnidadMedida, "Id", "Descripcion", producto.IdUnidadMedida);
            return View(producto);
        }

        // POST: Productos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,IdUnidadMedida,Codigo,Descripcion,Saldo,PrecioVenta,UsuarioRegistro,FechaRegistro,Estado")] Producto producto)
        {
            if (id != producto.Id)
            {
                return NotFound();
            }

            if (validar(producto))
            {
                try
                {
                    _context.Update(producto);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductoExists(producto.Id))
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
            ViewData["IdUnidadMedida"] = new SelectList(_context.UnidadMedida, "Id", "Descripcion", producto.IdUnidadMedida);
            return View(producto);
        }

        // GET: Productos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var producto = await _context.Producto
                .Include(p => p.IdUnidadMedidaNavigation)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (producto == null)
            {
                return NotFound();
            }

            return View(producto);
        }

        // POST: Productos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var producto = await _context.Producto.FindAsync(id);
            if (producto != null)
            {
                producto.Estado = -1;
                _context.Update(producto);
                //_context.Producto.Remove(producto);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProductoExists(int id)
        {
            return _context.Producto.Any(e => e.Id == id);
        }
    }
}
