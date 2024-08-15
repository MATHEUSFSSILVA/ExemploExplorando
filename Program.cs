using ExemploExplorando.models;

Pessoa p1 = new Pessoa();
p1.Nome = "Matheus";
p1.Sobrenome = "Felipe dos Santos Silva"; 

Pessoa p2 = new Pessoa();
p2.Nome = "Lucas";
p2.Sobrenome = "Rafael dos Santos Silva";

Curso cursoDeIngles = new Curso();
cursoDeIngles.NomeCurso = "Inglês avançado I";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.ListarAlunos();

cursoDeIngles.RemoverAluno(p1);
cursoDeIngles.ListarAlunos();
