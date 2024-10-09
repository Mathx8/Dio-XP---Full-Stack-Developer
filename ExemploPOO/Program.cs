using ExemploPOO.Interfaces;
using ExemploPOO.Models;

/*
Pessoa p1 = new Pessoa();
p1.Nome = "Leonardo";
p1.Idade = 20;

p1.Apresentar();
*/

/*
ContaCorrente c1 = new ContaCorrente(123, 1000);

c1.ExibirSaldo();
c1.Sacar(500);
c1.ExibirSaldo();
*/

/*
Aluno a1 = new Aluno();
a1.Nome = "Leonardo";
a1.Idade = 20;
a1.Nota = 10;
a1.Email = "teste@teste.com";
a1.Apresentar();

Professor p1 = new Professor();
p1.Nome = "Eduardo";
p1.Idade = 30;
p1.Salario = 1000;
p1.Apresentar();
*/

/*
Corrente c = new Corrente();
c.Creditar(500);
c.ExibirSaldo();
*/

/*
Pessoa p1 = new Pessoa("Leonardo");
Aluno a1 = new Aluno("Eduardo");

a1.Apresentar();

Computador c = new Computador();
Console.WriteLine(c.ToString());
*/

ICalculadora calc = new Calculadora();
Console.WriteLine(calc.Multiplicar(3, 9));