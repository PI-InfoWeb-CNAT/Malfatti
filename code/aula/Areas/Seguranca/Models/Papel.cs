using Microsoft.AspNet.Identity.EntityFramework;

namespace malfatti.Areas.Seguranca.Models
{
	public class Papel : IdentityRole
	{
		public Papel() : base() { }
		public Papel(string name) : base(name) { }
	}
}
