using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassePessoa
{
    public class Pessoa
    {
        private string _nome;
        private int _idade;

        public string Nome { 
            get => _nome.ToUpper();
            
            set 
            {
                if(value == ""){
                    throw new ArgumentException("O nome não pode ser vazio");
                }

                _nome = value;
            }
            
            }
        public int Idade 
        { 
            get => _idade;
            set 
            {
                if(value < 0){
                    throw new ArgumentException("A idade nao pode ser menor que zero");
                }
                _idade =  value;
            }
         }

        public void Show(){
            Console.WriteLine($"Nome é {Nome}, idade é {Idade}");
        }
    }
}