using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassePessoa.Models
{
    public class LeituraDeAqruivo
    {
        public (bool Sucesso, string[] Linhas, int Qtde) LerArquivo(string caminho)
        {
            try
            {
                string[] linha = File.ReadAllLines(caminho);
                return(true, linha, linha.Count());
            }
            catch (Exception)
            {
                return(false, new string[0], 0);
                throw;
            }
            
        }
    }
}