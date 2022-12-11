using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;
using malfatti.Areas.Seguranca.Models;

namespace malfatti.DAL
{
    public class IdentityDbContextAplicacao : IdentityDbContext<Usuario>
    {
        public IdentityDbContextAplicacao() : base("IdentityDb")
        { }
        static IdentityDbContextAplicacao()
        {
            Database.SetInitializer<IdentityDbContextAplicacao>(
            new IdentityDbInit());
        }
        public static IdentityDbContextAplicacao Create()
        {
            return new IdentityDbContextAplicacao();
        }

        public System.Data.Entity.DbSet<malfatti.Areas.Seguranca.Models.Usuario> Usuarios { get; set; }

        public System.Data.Entity.DbSet<malfatti.Areas.Seguranca.Models.UsuarioViewModel> UsuarioViewModels { get; set; }
    }
    public class IdentityDbInit :
        DropCreateDatabaseIfModelChanges
        <IdentityDbContextAplicacao>

    {
    }
}