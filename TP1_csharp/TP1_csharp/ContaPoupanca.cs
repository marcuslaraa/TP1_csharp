using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace TP1_csharp
{
    internal class ContaPoupanca: ContaBancaria
    {
        public double taxaAdicional = 5;

        public ContaPoupanca(string agencia, string conta, string titular) : base(agencia, conta, titular) { }

        public override void debitar(double valor)
        {
            if (Saldo <= 0)
            {
                Console.WriteLine("Sem Saldo");
                return;
            }
            Saldo -= valor;
        }

        public override void creditar(double valor)
        {
            Saldo += valor + taxaAdicional;
        }
    }
}
