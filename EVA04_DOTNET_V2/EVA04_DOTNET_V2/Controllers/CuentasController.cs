using EVA04_DOTNET_V2.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace EVA04_DOTNET_V2.Controllers
{
    public class CuentasController : Controller
    {

        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;

        public CuentasController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;

        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<ActionResult> Registro()
        {
            Registro claseRegistro = new Registro();
            return View(claseRegistro);
        }

        [HttpPost]
        public async Task<ActionResult> Registro(Registro claseRegistro)
        {

            if (ModelState.IsValid)
            {
                var Usuario = new Usuario
                {
                    UserName = claseRegistro.Email,
                    Email = claseRegistro.Email,
                    Nombres = claseRegistro.Nombre,
                    Apellidos = claseRegistro.Apellido,
                };

                var resultado = await _userManager.CreateAsync(Usuario, claseRegistro.Password);
                await _signInManager.SignInAsync(Usuario, isPersistent: false);
                return RedirectToAction("Index", "Home");
            }
            return View(claseRegistro);
        }
    }
}
