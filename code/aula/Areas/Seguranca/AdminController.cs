using Microsoft.AspNet.Identity.Owin;
using malfatti.Infraestrutura;
using System.Web.Mvc;
using System.Web;
using Microsoft.AspNet.Identity;
using malfatti.Areas.Seguranca.Models;
using malfatti;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace malfatti.Areas.Seguranca.Controllers
{
    public class AdminController : Controller
    {
        // Definição da Propriedade GerenciadorUsuario
        private GerenciadorUsuario GerenciadorUsuario
        {
            get
            {
                return HttpContext.GetOwinContext().
                GetUserManager<GerenciadorUsuario>();

            }
        }
        // GET: Seguranca/Admin
        public ActionResult Index()
        {
            return View(GerenciadorUsuario.Users);
        }

        public ActionResult Create()
        { return View(); }
    }
}