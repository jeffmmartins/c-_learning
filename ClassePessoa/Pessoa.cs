using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassePessoa
{
    public class Pessoa
    {
        private string _nome;

        public string Nome { 
            get 
            {
                return _nome.ToUpper();
            }
            set 
            {
                if(value == ""){
                    throw new ArgumentException("O nome não pode ser vazio");
                }

                _nome = value;
            }
            
            }
        public int Idade { get; set; }

        public void Show(){
            Console.WriteLine($"Nome é {Nome}, idade é {Idade}");
        }
    }
}