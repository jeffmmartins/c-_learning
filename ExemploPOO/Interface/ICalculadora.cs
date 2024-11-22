using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Interface
{
    public interface ICalculadora
    {
        int somar(int num1, int num2);
        int subtrair(int num1, int num2);
        int multiplicar(int num1, int num2);
    }
}