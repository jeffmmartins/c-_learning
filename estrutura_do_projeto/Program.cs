using estrutura_do_projeto.Models;

string a = "15-";
int b = 0;

int.TryParse(a, out b);

Console.WriteLine(b);


//int inteiro = 5;
//string a = inteiro.ToString();
//Console.WriteLine(a);

// cast - casting 
//int a = Convert.ToInt32("5");
//Console.WriteLine(a);

/*int a = 10;
int b = 20;
int c = a + b;

c += 5;

Console.WriteLine(c);

DateTime dataAtual = DateTime.Now.AddDays(5);

Console.WriteLine(dataAtual);


string apresentação = "olá seja bem vindo"; // variavel

int idade = 36;

double altura = 1.90;

decimal preco = 2.80M; 

bool condicao = true;

Console.WriteLine(apresentação);
Console.WriteLine("o valor da variavel idade: " + idade);
Console.WriteLine("o valor da variavel Altura: " + altura.ToString("0.00"));
Console.WriteLine("o valor da variavel preco: " + preco);
Console.WriteLine("o valor da variavel condição: " + condicao);


Pessoa p = new Pessoa();

p.Nome = "Jeff";
p.Idade = 36;
p.Apresentar();*/