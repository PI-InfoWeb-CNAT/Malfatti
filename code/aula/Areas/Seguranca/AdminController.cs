using Microsoft.AspNet.Identity.Owin;
using malfatti.Infraestrutura;
using System.Web.Mvc;
using System.Web;

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