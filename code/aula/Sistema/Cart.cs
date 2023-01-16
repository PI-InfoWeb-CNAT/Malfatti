using malfatti.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace aula.Sistema
{
    public class Cart
    {
        public long CartId { get; set; }
        public string UserId { get; set; }
        public UsuarioAdm Usuario { get; set; }
        public virtual ICollection<Produto> ProdutosCarrinho { get; set; }
    }
}