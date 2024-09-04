using C_Exemplos.Models;

//Pessoa pessoa1 = new Pessoa();

//pessoa1.Nome = "Buta";
//pessoa1.Idade = 26;
//pessoa1.Apresentar();

// string apresentacaoo = "Olá, seja bem vindo";
// int quantidade = 1;
// double altura = 1.80;
// decimal preco = 1.80M;
// bool condicao = true;

// DateTime dataAtual = DateTime.Now.AddDays(5);
// Console.WriteLine(dataAtual.ToString("dd/MM/yyyy HH:mm"));

// Cast - Casting
//int a = Convert.ToInt32("5");
//int a = int.Parse("5");

// Conversão para String
//int inteiro = 5;
//string a = inteiro.ToString();

//double a = 4/2+2;
//double a = 4/(2+2);
//Console.WriteLine(a);

/* IF aninhado
int quantidadeEmEstoque = 3;

int quantidadeCompra = 0;

bool possivelVenda = quantidadeCompra > 0 && quantidadeEmEstoque >= quantidadeCompra;

Console.WriteLine($"Quantidade em estoque: {quantidadeEmEstoque}");
Console.WriteLine($"Quantidade compra: {quantidadeCompra}");
Console.WriteLine($"É possivel realizar a venda? : {possivelVenda}");

if (quantidadeCompra == 0)
{
    Console.WriteLine("Venda inválida.");
}
else if (possivelVenda)
{
    Console.WriteLine("Venda realizada.");
}
else
{
    Console.WriteLine("Não temos a quantidade desejada em estoque.");
}
*/



// Switch Case
/*
Console.WriteLine("Digite uma letra: ");
string letra = Console.ReadLine();

switch (letra)
{
    case "a":
    case "e":
    case "i":
    case "o":
    case "u":
        Console.WriteLine("Vogal");
        break;

    default:
        System.Console.WriteLine("Não é uma Vogal");
        break;
}
*/

// Se fosse com IF
/*
if (letra == "a")
{
    Console.WriteLine("Vogal!");
}
else if (letra == "e")
{
    Console.WriteLine("Vogal!");
}
else if (letra == "i")
{
    Console.WriteLine("Vogal!");
}
else if (letra == "o")
{
    Console.WriteLine("Vogal!");
}
else if (letra == "u")
{
    Console.WriteLine("Vogal!");
}
else
{
    Console.WriteLine("Não é uma Vogal.");
}
*/



// OR ||
/*
bool maiorDeIdade = true;

bool autorizacaoResponsavel = false;

if (maiorDeIdade || autorizacaoResponsavel)
{
    Console.WriteLine("Entrada Liberada!");
}
else
{
    Console.WriteLine("Entrada Bloqueada!");
}
*/



// AND &&
/*
bool presencaMinima = true;
double media = 6.5;

if (presencaMinima && media >= 7)
{
    Console.WriteLine("Aprovado");
}
else
{
    Console.WriteLine("Reprovado");
}
*/



// NOT !
/*
bool choveu = false;
bool tarde = false;

if (!choveu && !tarde)
{
    Console.WriteLine("Vou pedalar!");
}
else
{
    Console.WriteLine("Vou pedalar outro dia.");
}
*/



// Calculadora

Calculadora calc = new Calculadora();
/*
calc.Somar(10, 30);
calc.Subtrair(10, 50);
calc.Multiplicar(15, 45);
calc.Dividir(2, 2);
calc.Potencia(3, 3);

calc.Seno(30);
calc.Coseno(30);
calc.Tangente(30);

calc.RaizQuadrada(9);
*/



// Incremento e Decremento
/*
int numeroIncremento = 10;
Console.WriteLine(numeroIncremento);
Console.WriteLine("Incrimentando o 10");
//numero = numero+1;
numeroIncremento++;
Console.WriteLine(numeroIncremento);

int numeroDecremento = 20;
Console.WriteLine("Decrementando o 20");
//numero = numero-1;
numeroDecremento--;
Console.WriteLine(numeroDecremento);
*/



// FOR

int numero = 5;

for (int contador = 0; contador <= 10; contador++)
{
    Console.WriteLine($"{numero} x {contador} = {numero*contador}");
}