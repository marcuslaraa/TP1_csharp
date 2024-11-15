using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    internal class DVD : Produto
    {
        public DVD(String marca, String cor) : base()
        {
            this.Marca = marca;
            this.Cor = cor;
            this.Preco = 2000;

        }
        public override void reajustarPreco()
        {
           this.Preco *= 1.01;
        }
    }
}
