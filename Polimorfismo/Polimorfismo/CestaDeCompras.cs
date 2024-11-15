using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    internal class CestaDeCompras
    {
        public List<Produto> Produtos { get; set; } = new List<Produto>();

        public void adicionarProduto(Produto produto)
        {
            Produtos.Add(produto);
        }

        public void exibirCestaDeProdutos(List<Produto> cestaProdutos) 
        {
            foreach (Produto produto in cestaProdutos)
            {
                Console.WriteLine(produto.ToString());
            }
        }
    }
}
