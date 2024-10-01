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
*/
 
//Console.WriteLine(data.ToString("dd/MM/yyyy HH:mm"));
//Console.WriteLine(data.ToShortDateString());
//Console.WriteLine(data.ToShortTimeString());

// TRY-CATCH
/*
try
{
    string[] linhas = File.ReadAllLines("Arquivos/arquivoLeitura.txt");

    foreach (string linha in linhas)
    {
        Console.WriteLine(linha);
    }
} catch (FileNotFoundException ex)
{
    Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Arquivo não encontrado. {ex.Message}");
} catch (DirectoryNotFoundException ex)
{
    Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Caminho da pasta não encontrado. {ex.Message}");
}
catch (Exception ex)
{
    Console.WriteLine($"Ocorreu uma excerção genérica. {ex.Message}");
}
finally 
{
    Console.WriteLine($"Chegou até aqui");
}
*/

//new ExemploExcecao().Metodo1();

// Fila (FIFO)
/*
Queue<int> fila = new Queue<int>();

fila.Enqueue(2);
fila.Enqueue(4);
fila.Enqueue(6);
fila.Enqueue(8);

foreach (int item in fila)
{
    Console.WriteLine(item);
}

Console.WriteLine($"Removendo o elemento: {fila.Dequeue()}");
fila.Enqueue(10);

foreach (int item in fila)
{
    Console.WriteLine(item);
}
*/

// Pilha (LIFO)
/*
Stack<int> pilha = new Stack<int>();

pilha.Push(4);
pilha.Push(6);
pilha.Push(8);
pilha.Push(10);

foreach (int item in pilha)
{
    Console.WriteLine(item);
}

Console.WriteLine($"Removendo o elemento do topo: {pilha.Pop()}");
pilha.Push(20);

foreach (int item in pilha)
{
    Console.WriteLine(item);
}
*/

// Dicionario
Dictionary<string, string> estados = new Dictionary<string, string>();

estados.Add("SP", "São Paulo");
estados.Add("BA", "Bahia");
estados.Add("MG", "Minas Gerias");

foreach (var item in estados)
{
    Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
}

Console.WriteLine("-----------------------------------");

estados.Remove("BA");
estados["SP"] = "São Paulo - valor alterado";

foreach (var item in estados)
{
    Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
}

string chave = "BA";
Console.WriteLine($"Verificando o elemento: {chave}");
if (estados.ContainsKey(chave))
{
    System.Console.WriteLine($"Valor existente: {chave}");
}
else
{
    System.Console.WriteLine($"Valor não existe, é seguro adicionar a chave: {chave}");
}