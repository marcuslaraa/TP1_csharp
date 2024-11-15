using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    internal class VideoGame : Produto
    {
        public VideoGame(String marca, String cor) : base()
        {
            this.Marca = marca;
            this.Cor = cor;
            this.Preco = 4000;

        }
        public override void reajustarPreco()
        {
          this.Preco *= 1.015;
        }
    }
}
