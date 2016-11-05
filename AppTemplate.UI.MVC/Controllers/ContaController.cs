using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AppTemplate.Domain.Interfaces.Service;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication.Cookies;
using AppTemplate.UI.MVC.Model.ContaViewModels;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace AppTemplate.UI.MVC.Controllers
{
    public class ContaController : Controller
    {
        private readonly IUsuarioService _UsuarioService;
        public ContaController(IUsuarioService usuarioService)
        {
            _UsuarioService = usuarioService;
        }

        public IActionResult Login()
        {            
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                if (!Request.HttpContext.User.Identities.Any(identity => identity.IsAuthenticated))
                {
                    var usuario = _UsuarioService.Autenticar(model.Email, model.Senha);

                    var userApp = new ClaimsPrincipal(new ClaimsIdentity(new[] { new Claim(ClaimTypes.Name, usuario.Nome) ,
             new Claim(ClaimTypes.UserData, Newtonsoft.Json.JsonConvert.SerializeObject(usuario))}, CookieAuthenticationDefaults.AuthenticationScheme));
                    await Request.HttpContext.Authentication.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, userApp);
                }
                return RedirectToAction("Index", "Home");
            }
            return View(model);
        }

        public async Task<IActionResult> LogOff()
        {
            await Request.HttpContext.Authentication.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);

            return View();
        }
    }
}
