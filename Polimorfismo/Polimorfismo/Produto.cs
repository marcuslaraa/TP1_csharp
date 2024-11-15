using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    internal abstract class Produto
    {
        public String Marca { get; set; } = "";
        public String Cor { get; set; } = "";
        public double Preco { get; set; }


        public abstract void reajustarPreco();
 
    }
}
