using ExemploExplorando.models;

Pessoa p1 = new Pessoa(nomeImputUsuario: "Matheus", sobrenomeImputUsuario: "Felipe");
Pessoa p2 = new Pessoa(nomeImputUsuario: "Lucas", sobrenomeImputUsuario: "Rafael");

Curso cursoDeIngles = new Curso();
cursoDeIngles.NomeCurso = "Inglês avançado I";
cursoDeIngles.Alunos = new List<Pessoa>();

Console.WriteLine("Lista dos alunos após adicionar");
cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.ListarAlunos();

Console.WriteLine("Lista dos alunos após remover");
cursoDeIngles.RemoverAluno(p1);
cursoDeIngles.ListarAlunos();
