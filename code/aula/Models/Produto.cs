using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using aula.Models;

namespace malfatti.Models
{
    public class Produto
    {
        public long ProdutoId { get; set; }
        public string Nome { get; set; }
        [Range(1, Double.PositiveInfinity)]
        public Decimal Preco { get; set; }
        public String Descricao { get; set; }
        public bool Disponivel { get; set; }
        public long? CategoriaId { get; set; }
        public long? FabricanteId { get; set; }
        public Categoria Categoria { get; set; }
        public Fabricante Fabricante { get; set; }


        public virtual ICollection<ItemProduto> ItensProduto { get; set; }

        internal static object FirstOrDefault(Func<object, bool> p)
        {
            throw new NotImplementedException();
        }
    }
}