using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using malfatti.Infraestrutura;
using System.Security.Claims;
using System.Web;
using System;
using System.Web.Mvc;
using malfatti.Areas.Segurança.Models;
using System.Web.UI.WebControls;

namespace malfatti.Controllers
{
	[Authorize(Roles = "Administradores")]
	public class AccountController : Controller
	{
		public ActionResult Login(string returnUrl)
		{
			ViewBag.returnUrl = returnUrl;
			return View();
		}
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Login(Login details, string returnUrl)
		{
			if (ModelState.IsValid)
			{
				Usuario user = UserManager.Find(details.Nome, details.Senha);
				if (user == null)
				{
					ModelState.AddModelError("", "Nome	ou	senha inválido(s).");
				}
				else
				{
					ClaimsIdentity ident = UserManager.
									CreateIdentity(user,
									DefaultAuthenticationTypes.
									ApplicationCookie);
					AuthManager.SignOut();
					AuthManager.SignIn(new
									AuthenticationProperties
					{
						IsPersistent = false
					}, ident);
					if (returnUrl == null)
						returnUrl = "/Home";
					return Redirect(returnUrl);
				}
			}
			return View(details);
		}
		private IAuthenticationManager AuthManager
		{
			get
			{
				return HttpContext.GetOwinContext().
								Authentication;
			}
		}
		private GerenciadorUsuario UserManager
		{
			get
			{
				return HttpContext.GetOwinContext().GetUserManager
								<GerenciadorUsuario>();
			}
		}
		public ActionResult Logout()
		{
			AuthManager.SignOut();
			return RedirectToAction("Index", "Home", new { area = "" });
		}

	}
}