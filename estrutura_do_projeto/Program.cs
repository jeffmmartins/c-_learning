using estrutura_do_projeto.Models;

int numero = 10;

Console.WriteLine("Incrementando numero");
numero++;

Console.WriteLine(numero);





Calculadora calc = new Calculadora();

calc.Somar(1,1);
calc.Divisão(2,2);
calc.Multiplicar(10,14);
calc.Subtrair(10, 5);
calc.Potencia(3,3);
calc.Seno(30);
calc.Coseno(30);
calc.Tangete(30);
calc.RaizaQuadrada(9);

/*bool presencaMinima = true;
double media = 6.0;

if(presencaMinima && media >= 7){
    Console.WriteLine("Aprovado");
}else {
    Console.WriteLine("Reprovado");
}*/



/* bool ehMaiorDeIdade = false;
bool possivelAutorizacaoResponsavel = false;

if(ehMaiorDeIdade || possivelAutorizacaoResponsavel) {
    Console.WriteLine("É maior de idade");
}else {
    Console.WriteLine("Não é maior de idade");
}
*/





/*Console.WriteLine("Digite uma letra: ");
string letra = Console.ReadLine();

switch (letra){
    case "a":
    case "e":
    case "i":
    case "o":
    case "u":
        Console.WriteLine("é uam vogal");
        break;
    default:
        Console.WriteLine("Não é uma vogal");
        break;
}
*/



/*int quantidadeEstoque = 3;
int quantidadeCompra = 0;
bool possivelVenda = quantidadeCompra > 0 && quantidadeEstoque >= quantidadeCompra;

Console.WriteLine($"Valor em estoque: {quantidadeEstoque}");
Console.WriteLine($"Qunatidade disponivel para compras: {quantidadeCompra}");
Console.WriteLine($"è possivel realizar a venda: {possivelVenda}");

if(quantidadeCompra == 0) {
    Console.WriteLine("Venda Invalida");
}else if(possivelVenda) {
    Console.WriteLine("Venda realizada com sucesso");
} else {
    Console.WriteLine("Não tem produto em estoque");
}*/


//string a = "15-";
//int b = 0;

//int.TryParse(a, out b);

//Console.WriteLine(b);


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