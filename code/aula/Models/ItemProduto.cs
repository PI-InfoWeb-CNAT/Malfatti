using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using malfatti.Models;

namespace aula.Models
{
    public class ItemProduto
    {
        [Key]
        public int ItemProdutoId { get; set; }
        public int ProdutoId { get; set; }
        public int PedidoId { get; set; }
        public int Qtd { get; set; }

        public virtual Produto Produto { get; set; }
        public virtual Pedido Pedido { get; set; }
    }
}