using System.Globalization;
using ExemploExplorando.Models;

/*
Pessoa p1 = new Pessoa();
p1.Nome = "Leonardo";
p1.Sobrenome = "Buta";
p1.Idade = 20;
p1.Apresentar();
*/

/*
Pessoa p1 = new Pessoa("Leonardo", "Buta");
Pessoa p2 = new Pessoa("Eduardo", "Neves Queiroz");

Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Inglês";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.ListarAlunos();
*/

/*
string numero1 = "10";
string numero2 = "20";

string resultado = numero1+numero2;
Console.WriteLine(resultado);
*/

/*
decimal valorMonetario = 1582.40M;
Console.WriteLine(valorMonetario.ToString("C8"));
Console.WriteLine($"{valorMonetario:C}");

double porcentagem = .3421;
Console.WriteLine(porcentagem.ToString("P"));

int numero = 123456;
Console.WriteLine(numero.ToString("##-##-##"));
*/

string dataString = "2022-04-17 18:00";

bool sucesso = DateTime.TryParseExact(dataString, "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime data);
if (sucesso)
{
    Console.WriteLine($"Conversão com sucesso! Data: {data}");
}
else
{
    Console.WriteLine($"{dataString} não é uma data válida");
}

//Console.WriteLine(data.ToString("dd/MM/yyyy HH:mm"));
//Console.WriteLine(data.ToShortDateString());
//Console.WriteLine(data.ToShortTimeString());