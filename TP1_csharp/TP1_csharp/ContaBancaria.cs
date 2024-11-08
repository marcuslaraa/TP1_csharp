using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_csharp
{
    internal class ContaBancaria
    {
        public string Agencia { get; set; }
        public string Conta { get; set; }
        public double Saldo { get; set; } = 0;
        public string Titular { get; set; }

        public ContaBancaria()
        {
        }

        public ContaBancaria(string agencia, string conta, string titular)
        {
            Agencia = agencia;
            Conta = conta;
            Titular = titular;
        }

        public virtual void creditar(double valor)
        {
            Saldo += valor;
        }

        public virtual void debitar(double valor)
        {
            Saldo -= valor;
        }
    }
}
