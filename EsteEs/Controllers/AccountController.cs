using EsteEs.Models;
using EsteEs.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EsteEs.Controllers
{
    public class AccountController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IglesiaDBContext _db;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signinManager;
        public AccountController(ILogger<HomeController> logger, IglesiaDBContext db, UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signinManager)
        {
            _logger = logger;
            _db = db;
            _userManager = userManager;
            _signinManager = signinManager;
        }

        public async Task<IActionResult> CerrarSesion()
        {
            await _signinManager.SignOutAsync();
            return RedirectToAction("Index");
        }
        public IActionResult Index()
        {
            if (User.Identity.IsAuthenticated)
            {
                ViewData["Sesion"] = "Si";
                return RedirectToAction("Lista", "");
            }
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(string nombre, string clave)
        {
            var resultado = await _signinManager.PasswordSignInAsync(nombre, clave, false, true);
            if (resultado.Succeeded)
            {

                return RedirectToAction("Lista", "Home");
            }
            return View();
        }


        public IActionResult Registro()
        {
          
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Registro(UsuariosViewModel users)
        {
            if (ModelState.IsValid)
            {

                var user = new IdentityUser { UserName = users.UsuarioN, Email = users.Correo };
                var result = await _userManager.CreateAsync(user, users.Clave);
                

                if (result.Succeeded)
                {
                    var resultado = await _signinManager.PasswordSignInAsync(users.UsuarioN, users.Clave, false, true);
                    if (resultado.Succeeded)
                    {

                        return RedirectToAction("Login", "Account");
                    }
                }
                return RedirectToAction("Lista", "Home");


            }
            return View();
        }
    }
}
