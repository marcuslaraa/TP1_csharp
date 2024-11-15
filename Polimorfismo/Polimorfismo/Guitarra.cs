using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    internal class Guitarra : Produto
    {

        public Guitarra(String marca, String cor) : base()
        {
            this.Marca = marca;
            this.Cor = cor;
            this.Preco = 6000;

        }
        public override void reajustarPreco()
        {
          this.Preco *= 1.005;
        }
    }
}
