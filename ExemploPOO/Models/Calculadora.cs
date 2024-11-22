using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExemploPOO.Interface;

namespace ExemploPOO.Models
{
    public class Calculadora : ICalculadora
    {
        public int multiplicar(int num1, int num2)
        {
            return num1 * num2 ;
        }

        public int somar(int num1, int num2)
        {
            return num1 + num2 ;
        }

        public int subtrair(int num1, int num2)
        {
            return num1 - num2 ;
        }
    }
}