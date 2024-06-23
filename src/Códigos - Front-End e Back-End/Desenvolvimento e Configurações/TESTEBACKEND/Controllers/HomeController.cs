using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TESTEBACKEND.Models;

namespace TESTEBACKEND.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IEnumerable<Clinica> TodasAsClinicas;


        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            TodasAsClinicas = new Clinica().TodasAsClinicas();
        }

        public IActionResult Index()
        {
            var consultorios = TodasAsClinicas.ToList();
            var especialidade = TodasAsClinicas.Select(x => x.Especialidade).Distinct().ToList();
            ViewBag.Especialidade = especialidade;
            return View(consultorios);
        }

        public IActionResult mostrarEspecialidade(string especialidade)
        {
            var area = TodasAsClinicas.Where(x => x.Especialidade.ToLower() ==  especialidade.ToLower()).ToList();
            ViewBag.Area = area;
            return View(area);
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
