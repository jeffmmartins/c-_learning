using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    public class ContaCorrente
    {
        public ContaCorrente(string numeroConta, decimal saldoInicial)
        {
            NumeroConta = numeroConta;
            Saldo = saldoInicial;
        }

        public string NumeroConta { get; set; }
        private decimal Saldo;

        public void Sacar(decimal valor)
        {
            if (Saldo >= valor)
            {
                Saldo -= valor;
                Console.WriteLine("Saque Realizado com sucesso");
            }
            else 
            {
                Console.WriteLine("Valor desejado é maior que o disponivel");
            }
            
        }

        public void ExibirSaldo()
        {
            Console.WriteLine($"Valor disponivel na conta é {Saldo}");
        }
    }
}