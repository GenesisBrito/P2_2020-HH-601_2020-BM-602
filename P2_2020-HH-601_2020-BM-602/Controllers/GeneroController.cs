using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using P2_2020_HH_601_2020_BM_602.Models;

namespace P2_2020_HH_601_2020_BM_602.Controllers
{
    public class GeneroController : Controller
    {
        private readonly registroCovid _context;

        public GeneroController(registroCovid context)
        {
            _context = context;
        }

        // GET: genero
        public async Task<IActionResult> Index()
        {
            return _context.Generos != null ?
                        View(await _context.Generos.ToListAsync()) :
                        Problem("Entity set 'covidContext.genero'  is null.");
        }

        // GET: genero/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Generos == null)
            {
                return NotFound();
            }

            var genero = await _context.Generos
                .FirstOrDefaultAsync(m => m.Id_Genero == id);
            if (genero == null)
            {
                return NotFound();
            }

            return View(genero);
        }

        // GET: genero/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: genero/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id_genero,nombre_genero")] Genero genero)
        {
            if (ModelState.IsValid)
            {
                _context.Add(genero);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(genero);
        }

        // GET: genero/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Generos == null)
            {
                return NotFound();
            }

            var genero = await _context.Generos.FindAsync(id);
            if (genero == null)
            {
                return NotFound();
            }
            return View(genero);
        }

        // POST: genero/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id_genero,nombre_genero")] Genero genero)
        {
            if (id != genero.Id_Genero)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(genero);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!generoExists(genero.Id_Genero))
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
            return View(genero);
        }

        // GET: genero/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Generos == null)
            {
                return NotFound();
            }

            var genero = await _context.Generos
                .FirstOrDefaultAsync(m => m.Id_Genero == id);
            if (genero == null)
            {
                return NotFound();
            }

            return View(genero);
        }

        // POST: genero/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Generos == null)
            {
                return Problem("Entity set 'covidContext.genero'  is null.");
            }
            var genero = await _context.Generos.FindAsync(id);
            if (genero != null)
            {
                _context.Generos.Remove(genero);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool generoExists(int id)
        {
            return (_context.Generos?.Any(e => e.Id_Genero == id)).GetValueOrDefault();
        }
    }
}
