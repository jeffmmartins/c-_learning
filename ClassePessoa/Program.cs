using ClassePessoa.Models;
using ClassePessoa;

Pessoa p1 = new Pessoa("Vera", "Martins");


Pessoa p2 = new Pessoa("Eduado", "Mendes");


Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Ingles";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.ListarAlunos();








/*
p1.Nome = "vera";
p1.Idade = 36;
p1.Sobrenome = "martins";
p1.Show();
*/

