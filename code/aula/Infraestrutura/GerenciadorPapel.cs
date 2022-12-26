using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin;
using malfatti.Areas.Seguranca.Models;
using malfatti.DAL;
using System;
namespace malfatti.Areas.Seguranca.Models
{
	public class GerenciadorPapel : RoleManager<Papel>,
					IDisposable
	{
		public GerenciadorPapel(RoleStore<Papel> store) :
					base(store)
		{
		}
		public static GerenciadorPapel Create(IdentityFactoryOptions<GerenciadorPapel> options,
						IOwinContext context)
		{
			return new GerenciadorPapel(new RoleStore<Papel>
							(context.Get<IdentityDbContextAplicacao>()));
		}
	}
}
