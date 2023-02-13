﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace malfatti.Models.ViewModels
{
    public class ProdutoVM
    {
        public ProdutoVM()
        {
        }
        public ProdutoVM(Produto row)
        {
            ProdutoId = row.ProdutoId;
            Nome = row.Nome;
            Preco = (float)row.Preco;
            Categoria = row.Categoria;
            CategoriaId = row.CategoriaId;

        }

        [DisplayName("Id")]
        public long? ProdutoId { get; set; }
        [StringLength(100, ErrorMessage = "O nome do produto precisa ter no mínimo 10 caracteres", MinimumLength = 10)]
        [Required(ErrorMessage = "Informe o nome do produto")]
        public string Nome { get; set; }
        [DisplayName("Preço")]
        [Range(1, Double.PositiveInfinity)]
        [Required(ErrorMessage = "O preço deve conter um valor válido")]
        public float Preco { get; set; }
        [DisplayName("Categoria")]
        public long? CategoriaId { get; set; }
        public Categoria Categoria { get; set; }
        public string NomeArquivo { get; set; }
        public IEnumerable<string> GalleryImages { get; set; }
        public string Slug { get; set; }

    }
}