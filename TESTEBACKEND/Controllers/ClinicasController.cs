using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TESTEBACKEND.Models;

namespace TESTEBACKEND.Controllers
{
    public class ClinicasController : Controller
    {
        private readonly AppDbContext _context;
        public ClinicasController(AppDbContext context) 
        {
            _context = context;
        } 

        public async Task<IActionResult> Index() 
        {
            var dados = await _context.Clinicas.ToListAsync();

            return View(dados);
        }

        public IActionResult Create() 
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Clinica clinica)
        {
            if (ModelState.IsValid) 
            {
                _context.Clinicas.Add(clinica);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }




            return View();
        }

        public async Task<ActionResult> Edit(int? id)
        {

            if (id == null)
                return NotFound();


            var dados = await _context.Clinicas.FindAsync(id);

            if (dados == null)
                return NotFound();
            return View(dados);
        }



        [HttpPost]
        public async Task<ActionResult> Edit(int id, Clinica clinica)
        {
            if (id != clinica.Id)
                return NotFound();

            if (ModelState.IsValid)
            {
                _context.Clinicas.Update(clinica);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }


            return View();
        }

        public async Task<IActionResult> Details(int? id) 
        {
            if(id == null)
                return NotFound();
            
            var dados = await _context.Clinicas.FindAsync();

            if(dados == null)
                return NotFound();
            
            
            return View();
        }



        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
                return NotFound();

            var dados = await _context.Clinicas.FindAsync();

            if (dados == null)
                return NotFound();


            return View();
        }


        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int? id)
        {
            if (id == null)
                return NotFound();

            var dados = await _context.Clinicas.FindAsync();

            if (dados == null)
                return NotFound();

            _context.Clinicas.Remove(dados);
            await _context.SaveChangesAsync();


            return RedirectToAction("Index");
        }
    }
}
