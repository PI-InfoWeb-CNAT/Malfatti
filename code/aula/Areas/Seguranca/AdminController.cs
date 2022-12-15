using Microsoft.AspNet.Identity.Owin;
using malfatti.Infraestrutura;
using System.Web.Mvc;
using System.Web;
using Microsoft.AspNet.Identity;
using malfatti.Areas.Seguranca.Models;
using malfatti;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using System.Net;
using Microsoft.AspNet.Identity;

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
    private void AddErrorsFromResult(IdentityResult result)
    {
        foreach (string error in result.Errors)
        {
            ModelState.AddModelError("", error);
        }
    }
    [HttpPost]
    public ActionResult Create(UsuarioViewModel model)
    {
        if (ModelState.IsValid)
        {
            Usuario user = new Usuario
            {
                UserName = model.Nome,
                Email = model.Email
            };
            IdentityResult result = GerenciadorUsuario.Create(user, model.Senha);
            if (result.Succeeded)
            { return RedirectToAction("Index"); }
            else
            {
                AddErrorsFromResult(result);
            }
        }
        return View(model);
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Usuario usuario = GerenciadorUsuario.FindById(id);
            if (usuario == null)
            {
                return HttpNotFound();
            }
            // inicia o objeto usuário para visão
            var uvm = new UsuarioViewModel();
            uvm.Id = usuario.Id;
            uvm.Nome = usuario.UserName;
            uvm.Email = usuario.Email;
            return View(uvm);
        }
    }
}