using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassePessoa.Models
{
    public class Curso
    {
        public string Nome { get; set; }
        public List<Pessoa> Alunos {get; set; }

        public void AdicionarAluno(Pessoa aluno) 
        {
            Alunos.add(aluno);
        }
    }
}