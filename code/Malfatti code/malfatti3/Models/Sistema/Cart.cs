using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace Models.Sistema
{
    public class Cart
    {
        public long CartId { get; set; }
        public string UserId { get; set; }
        public UsuarioAdm Usuario { get; set; }
        public virtual ICollection<Produto> ProdutosCarrinho { get; set; }
    }
}
