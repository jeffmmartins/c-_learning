﻿using ClassePessoa.Models;
using ClassePessoa;

Queue<int> fila = new Queue<int>(); // criando a fila
fila.Enqueue(2);
fila.Enqueue(3);
fila.Enqueue(5);
fila.Enqueue(6);

foreach (int item in fila)
{
    Console.WriteLine(item);
}
fila.Dequeue();
Console.WriteLine("Removendo elemento:" + fila.Dequeue());

foreach (int elementos in fila)
{
    Console.WriteLine(elementos);
}


/*new ExemploExcecao().Metodo1();*/

/*try
{
    string [] linhas = File.ReadAllLines("Arquivo/arquivo_Leitura.txt");

foreach (string linha in linhas)
{
    Console.WriteLine(linha);
}
}
catch (Exception ex)
{
    Console.WriteLine($"Messagem de erro generica {ex.Message} ");
}
finally
{
    Console.WriteLine("chegou ate aqui");
}
*/



/* DateTime data = DateTime.Now;
Console.WriteLine(data.ToString("dd/mm/yyyy  HH:mm"));

decimal valorMonetario = 82.50M;

Console.WriteLine($"{valorMonetario:c}");

Pessoa p1 = new Pessoa(nome:"Vera", sobrenome:"Martins");


Pessoa p2 = new Pessoa(nome:"Eduado", sobrenome:"Mendes");


Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Ingles";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.ListarAlunos();

*/






/*
p1.Nome = "vera";
p1.Idade = 36;
p1.Sobrenome = "martins";
p1.Show();
*/

