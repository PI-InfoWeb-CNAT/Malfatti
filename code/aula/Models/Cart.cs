﻿using malfatti.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Modelo.Cart
{
    public class Cart
    {
        public long? ProdutoId { get; set; }

        [Display(Name = "Nome do Produto")]
        public string ProdutoNome { get; set; }
        public int Quantidade { get; set; }
        public double Preco { get; set; }
        public double Total { get { return Quantidade * Preco; } }
        public Guid UserId { get; set; }
        public virtual ICollection<Produto> Produtos { get; set; }
    }
}