using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_csharp
{
    internal class ContaCorrente: ContaBancaria
    {
        public double taxaSaque = 5;
        public ContaCorrente(string agencia, string conta, string titular ) : base(agencia, conta, titular ) { }


        public override void creditar(double valor)
        {
    
            Saldo += taxaSaque + valor;
        }

        public override void debitar(double valor)
        {
            if (Saldo <= 0)
            {
                Console.WriteLine("Sem Saldo");
                return;
            }
            Saldo -= taxaSaque + valor;
        }

    }

    
}
