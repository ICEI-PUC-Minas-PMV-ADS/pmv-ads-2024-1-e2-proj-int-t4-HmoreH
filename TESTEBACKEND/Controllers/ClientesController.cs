using BCrypt.Net;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using System.Security.Claims;
using System.Threading.Tasks;
using TESTEBACKEND.Models;


namespace TESTEBACKEND.Controllers

{
    public class ClientesController : Controller
    {
        private readonly AppDbContext _context;

        public ClientesController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var dados = await _context.Clientes.ToListAsync();
            return View(dados);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                cliente.Senha = BCrypt.Net.BCrypt.HashPassword(cliente.Senha);
                _context.Clientes.Add(cliente);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(cliente);
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(Cliente cliente)
        {
            var dados = await _context.Clientes.FindAsync(cliente.CPF);

            if (dados == null)
            {
                ViewBag.Message = "Usuário e/ou senha inválidos!";
                return View();
            }

            bool SenhaOk = BCrypt.Net.BCrypt.Verify(cliente.Senha, dados.Senha);
            if (SenhaOk)
            {
                var Claims = new List<Claim>
                {
                    new Claim (ClaimTypes.Name, dados.Nome),
                    new Claim (ClaimTypes.NameIdentifier, dados.CPF.ToString())
					//new Claim("ClienteId", dados.CPF.ToString())
				};
                var clienteIndentity = new ClaimsIdentity(Claims, "login");
                ClaimsPrincipal principal = new ClaimsPrincipal(clienteIndentity);

                var props = new AuthenticationProperties
                {
                    AllowRefresh = true,
                    ExpiresUtc = DateTime.UtcNow.ToLocalTime().AddHours(8),
                    IsPersistent = true,
                };

                await HttpContext.SignInAsync(principal, props);

                return Redirect("/");
            }
            else
            {
                ViewBag.Message = "Usuário e/ou senha inválidos!";
            }

            return View();
        }

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return RedirectToAction("Login", "Clientes");
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dados = await _context.Clientes.FindAsync(id);
            if (dados == null)
            {
                return NotFound();
            }

            return View(dados);
        }

		public async Task<IActionResult> MeuPerfil()
		{
			var clienteIdClaim = User.FindFirst("ClienteId");
			if (clienteIdClaim == null)
			{
				return NotFound("ID do cliente não encontrado.");
			}

			var clienteId = int.Parse(clienteIdClaim.Value);
			var cliente = await _context.Clientes.FindAsync(clienteId);

			if (cliente == null)
			{
				return NotFound("Cliente não encontrado.");
			}

			return View(cliente);
		}

	}
}
