using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AppTemplate.Domain.Interfaces.Service;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace AppTemplate.Presentation.MVC.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly IUserService _service;
        public UsuarioController(IUserService service)
        {
            _service = service;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            
            return View(_service.Query().Take(25).ToList());
        }
    }
}
