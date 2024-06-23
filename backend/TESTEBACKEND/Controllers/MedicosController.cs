using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;
using TESTEBACKEND.Models;

namespace TESTEBACKEND.Controllers
{
    public class MedicosController : Controller
    {
        private readonly AppDbContext _context;
      public MedicosController(AppDbContext context) 
        {
            _context = context;
        }

        public async Task<ActionResult> Index()
        {
            var dados = await _context.Medicos.ToListAsync();

            return View(dados);
        }

        public IActionResult Create() 
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Create(Medico medico) 
        {
            if (ModelState.IsValid) 
            {
                _context.Medicos.Add(medico);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            
            
            return View(medico);
        }


        public async Task<ActionResult> Edit(int? id) 
        {

            if(id == null)
                return NotFound();


            var dados = await _context.Medicos.FindAsync(id);

            if (dados == null)
                return NotFound();
            return View(dados);  
        }



        [HttpPost]
        public async Task<ActionResult> Edit(int id, Medico medico)
        {
            if (id != medico.Id)
                return NotFound();

            if (ModelState.IsValid)
            {
                _context.Medicos.Update(medico);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }


            return View();
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
                return NotFound();

            var dados = await _context.Medicos.FindAsync();

            if (dados == null)
                return NotFound();


            return View();
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
                return NotFound();

            var dados = await _context.Medicos.FindAsync();

            if (dados == null)
                return NotFound();


            return View();
        }


        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int? id)
        {
            if (id == null)
                return NotFound();

            var dados = await _context.Medicos.FindAsync();

            if (dados == null)
                return NotFound();

            _context.Medicos.Remove(dados);
            await _context.SaveChangesAsync();


            return RedirectToAction("Index");
        }
    }
}
