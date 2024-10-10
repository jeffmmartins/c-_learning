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

        public void Potencia (int a, int b){
            double pot = Math.Pow(a, b);
            Console.WriteLine($"{a}^{b} = {pot}");
        }

        public void Seno (double angulo){
            double radiano = angulo * Math.PI / 180;
            double seno = Math.Sin(radiano);
            Console.WriteLine($"O valor do seno é: {seno}");
        }

        public void Coseno (double angulo){
            double radiano = angulo * Math.PI / 180;
            double coseno = Math.Cos(radiano);
            Console.WriteLine($"O valor do seno é: {Math.Round(coseno,4)}");
        }

        public void Tangete (double angulo){
            double radiano = angulo * Math.PI / 180;
            double tangete = Math.Tan(radiano);
            Console.WriteLine($"O valor do seno é: {tangete}");
        }

        public void RaizaQuadrada (double x){
            double raiz = Math.Sqrt(x);
            Console.WriteLine($"Raiz quadrada de {x} é: {raiz}");
        }
    
    }
}