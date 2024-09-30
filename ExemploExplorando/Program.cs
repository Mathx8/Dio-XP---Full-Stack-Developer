using ExemploExplorando.Models;

/*
Pessoa p1 = new Pessoa();
p1.Nome = "Leonardo";
p1.Sobrenome = "Buta";
p1.Idade = 20;
p1.Apresentar();
*/

Pessoa p1 = new Pessoa("Leonardo", "Buta");
Pessoa p2 = new Pessoa("Eduardo", "Neves Queiroz");

Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Inglês";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.ListarAlunos();