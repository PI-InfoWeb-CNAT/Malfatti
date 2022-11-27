using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using aula.Models;
using malfatti.Context;

namespace aula.Controllers
{
    public class CarrinhosController : Controller
    {
        private EFContext context = new EFContext();
        // GET: Carrinho
        public ActionResult AdicionarCarrinho(int id)
        {
            // Ao invés de colocar uma lista de ítens de Design, vamos colocar
            // Um objeto da entidade Pedido, que já possui List<ItemDesign>.
            // List<ItemDesign> carrinho = Session["Carrinho"] != null ? (List<ItemDesign>)Session["Carrinho"] : new List<ItemDesign>();
            Pedido carrinho = Session["Carrinho"] != null ? (Pedido)Session["Carrinho"] : new Pedido();

            var produto = context.Produtos.Find(id);

            if (produto != null)
            {
                var itemProduto = new ItemProduto();
                itemProduto.Produto = produto;
                itemProduto.Qtd = 1;
                // Esta linha não precisa. O EF é espertinho e preenche pra você.
                // itemDesign.IdDesign = design.IdDesign;

                if (carrinho.ItensProduto.FirstOrDefault(x => x.ProdutoId == produto.ProdutoId) != null)
                {
                    carrinho.ItensProduto.FirstOrDefault(x => x.ProdutoId == produto.ProdutoId).Qtd += 1;
                }

                else
                {
                    carrinho.ItensProduto.Add(itemProduto);
                }

                // Aqui podemos fazer o cálculo do valor

                carrinho.ValorTotal = carrinho.ItensProduto.Select(i => i.Produto).Sum(d => d.Preco);

                Session["Carrinho"] = carrinho;
            }

            return RedirectToAction("Carrinho");
        }

        public ActionResult Carrinho()
        {
            Pedido carrinho = Session["Carrinho"] != null ? (Pedido)Session["Carrinho"] : new Pedido();

            return View(carrinho);
        }
    }
}