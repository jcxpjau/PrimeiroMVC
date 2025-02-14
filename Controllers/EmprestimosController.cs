using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PrimeiroMVC.Models;

namespace PrimeiroMVC.Controllers
{
    public class EmprestimosController : Controller
    {
        private readonly Contexto _context;

        public EmprestimosController(Contexto context)
        {
            _context = context;
        }

        // GET: Emprestimos
        public async Task<IActionResult> Index()
        {
            var contexto = _context.Emprestimos
                .Include(e => e.Livros)
                .Include(e => e.Usuarios);
            return View( await contexto.ToListAsync() );
        }

        // GET: Emprestimos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Emprestimos == null)
            {
                return NotFound();
            }

            var emprestimos = await _context.Emprestimos
                .Include(e => e.Livros)
                .Include(e => e.Usuarios)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (emprestimos == null)
            {
                return NotFound();
            }

            return View(emprestimos);
        }

        // GET: Emprestimos/Create
        public IActionResult Create()
        {
            ViewData["LivrosId"] = new SelectList(_context.Livros, "Id", "Titulo");
            ViewData["UsuariosId"] = new SelectList(_context.Usuarios, "Id", "Nome");
            return View();
        }

        // POST: Emprestimos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,UsuariosId,LivrosId,DataEmprestimo,DataDevolucao")] Emprestimos emprestimos)
        {
            if (ModelState.IsValid)
            {
                _context.Add(emprestimos);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["LivrosId"] = new SelectList(_context.Livros, "Id", "Titulo", emprestimos.LivrosId);
            ViewData["UsuariosId"] = new SelectList(_context.Usuarios, "Id", "Nome", emprestimos.UsuariosId);
            return View(emprestimos);
        }

        // GET: Emprestimos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Emprestimos == null)
            {
                return NotFound();
            }

            var emprestimos = await _context.Emprestimos.FindAsync(id);
            if (emprestimos == null)
            {
                return NotFound();
            }
            ViewData["LivrosId"] = new SelectList(_context.Livros, "Id", "Titulo", emprestimos.LivrosId);
            ViewData["UsuariosId"] = new SelectList(_context.Usuarios, "Id", "Nome", emprestimos.UsuariosId);
            return View(emprestimos);
        }

        // POST: Emprestimos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,UsuariosId,LivrosId,DataEmprestimo,DataDevolucao")] Emprestimos emprestimos)
        {
            if (id != emprestimos.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(emprestimos);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EmprestimosExists(emprestimos.Id))
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
            ViewData["LivrosId"] = new SelectList(_context.Livros, "Id", "Titulo", emprestimos.LivrosId);
            ViewData["UsuariosId"] = new SelectList(_context.Usuarios, "Id", "Nome", emprestimos.UsuariosId);
            return View(emprestimos);
        }

        // GET: Emprestimos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Emprestimos == null)
            {
                return NotFound();
            }

            var emprestimos = await _context.Emprestimos
                .Include(e => e.Livros)
                .Include(e => e.Usuarios)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (emprestimos == null)
            {
                return NotFound();
            }

            return View(emprestimos);
        }

        // POST: Emprestimos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Emprestimos == null)
            {
                return Problem("Entity set 'Contexto.Emprestimos'  is null.");
            }
            var emprestimos = await _context.Emprestimos.FindAsync(id);
            if (emprestimos != null)
            {
                _context.Emprestimos.Remove(emprestimos);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EmprestimosExists(int id)
        {
          return (_context.Emprestimos?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
