using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace estrutura_do_projeto.Models
{
    public class Calculadora
    {
        public void Somar (int a, int b){
            Console.WriteLine($"{a} + {b} = {a + b}");
        }

        public void Subtrair (int a, int b){
            Console.WriteLine($"{a} - {b} = {a - b}");
        }

        public void Multiplicar (int a, int b){
            Console.WriteLine($"{a} x {b} = {a * b}");
        }

        public void Divisão (int a, int b){
            Console.WriteLine($"{a} / {b} = {a / b}");
        }
    }
}