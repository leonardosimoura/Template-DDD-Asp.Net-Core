using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using AppTemplate.Domain.Interfaces.Service;
using AppTemplate.Domain.Entities;
using System.Threading;
using System.Security.Claims;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace AppTemplate.UI.MVC.Controllers
{
    public class BaseController : Controller
    {
        public Usuario UsuarioLogado
        {
            get
            {
                var userApp = User.Identities.FirstOrDefault(identity => identity.IsAuthenticated);

                if (userApp == null)
                {
                    return null;
                }
                Usuario retorno = Newtonsoft.Json.JsonConvert.DeserializeObject<Usuario>(userApp.Claims.First(c => c.ValueType == ClaimTypes.UserData).Value);
                return retorno;
            }
        }
    }
}
