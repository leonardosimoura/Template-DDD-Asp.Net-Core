//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using Microsoft.AspNetCore.Mvc;

//// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

//namespace AppTemplate.Presentation.MVC.Controllers
//{
//    public class ContaController : Controller
//    {

//        private readonly UserManager<Usuario> _userManager;
//        private readonly SignInManager<ApplicationUser> _signInManager;
//        private readonly IEmailSender _emailSender;
//        private readonly ISmsSender _smsSender;
//        private static bool _databaseChecked;
//        private readonly ILogger _logger;

//        public ContaController(
//            UserManager<ApplicationUser> userManager,
//            SignInManager<ApplicationUser> signInManager,
//            IEmailSender emailSender,
//            ISmsSender smsSender,
//            ILoggerFactory loggerFactory)
//        {
//            _userManager = userManager;
//            _signInManager = signInManager;
//            _emailSender = emailSender;
//            _smsSender = smsSender;
//            _logger = loggerFactory.CreateLogger<AccountController>();
//        }

//        // GET: /<controller>/
//        public IActionResult Index()
//        {
//            return View();
//        }
//    }
//}
