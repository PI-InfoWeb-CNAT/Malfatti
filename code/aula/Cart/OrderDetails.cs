using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace aula.Cart
{
    public class OrderDetails
    {
        [Key]
        public long Id { get; set; }
        public int OrderId { get; set; }
        public string UserId { get; set; }
        public long? ProdutoId { get; set; }
        public int Quantidade { get; set; }

        [ForeignKey("OrderId")]
        public virtual Order Orders { get; set; }
        //[ForeignKey("UserId")]
        //public virtual UsuarioAdm Users { get; set; }
        [ForeignKey("ProdutoId")]
        public virtual Produto Produtos { get; set; }
    }
}