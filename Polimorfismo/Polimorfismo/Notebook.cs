using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    internal class Notebook : Produto
    {
        public Notebook(String marca, String cor) : base()
        {
            this.Marca = marca;
            this.Cor = cor;
            this.Preco = 5500;
        }
        public override void reajustarPreco()
        {
            this.Preco *= 1.02;
        }
    }
}
