using ExemploPOO.Models;

Aluno aluno1 = new Aluno();

aluno1.Nome = "Jeff";
aluno1.Idade = 26;
aluno1.Apresentar();

Professor p1 = new Professor();
p1.Nome = "Eduado";
p1.Salario = 1000;
p1.Idade = 34;
p1.Apresentar();





ContaCorrente conta = new ContaCorrente("123", 1000);

conta.ExibirSaldo();
conta.Sacar(100);
conta.ExibirSaldo();






/* 
Pessoa p1 = new Pessoa();

p1.Nome = "Jeff";
p1.Idade = 36;

p1.Apresentar();
*/