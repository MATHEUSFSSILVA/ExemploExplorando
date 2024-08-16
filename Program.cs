using System.Globalization;
using ExemploExplorando.models;

Pessoa p1 = new Pessoa(nomeImputUsuario: "Matheus", sobrenomeImputUsuario: "Felipe");
Pessoa p2 = new Pessoa(nomeImputUsuario: "Lucas", sobrenomeImputUsuario: "Rafael");

// Para que o programa entenda um valor decimal(declarado na propriedade da classe em Cursos) é preciso colocar "M" após o valor.
Curso cursoDeIngles = new Curso("Inglês avançado I", 183.40M);
cursoDeIngles.Alunos = new List<Pessoa>();

Console.WriteLine("Lista dos alunos após adicionar");
cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.MostrarInformacoesAluno(p2);


// Exemplo de como trabalhar com valor monetário.
decimal valorMonetarioExemplo = 143.40M;
// Para definir a quantidade de casas decimais. No exemplo abaixo, duas casas decimais.
Console.WriteLine(valorMonetarioExemplo.ToString("C2"));

// Percentuais
double valorPercentual = .2345;
Console.WriteLine(valorPercentual.ToString("P"));

// Formatos personalizados
int valorPersonalizado = 20240815;
Console.WriteLine(valorPersonalizado.ToString("####-##-##"));

// Formatando datas
DateTime data = DateTime.Now;
// AddDays acrescenta dias e ToString() o formato da Data.
// O "H" do formato de hora está em maiúsculo para formatos até 24h, minúsculo seria até 12h.
Console.WriteLine(data.AddDays(-1).ToString("dd/MM/yyyy HH:mm"));

// Mostra somente a data. 
Console.WriteLine(data.ToShortDateString());

// Mostra somente a hora.
Console.WriteLine(data.ToShortTimeString());

// Converter uma data para DateTime
DateTime dataConvertida = DateTime.Parse("09/08/1995");
Console.WriteLine(dataConvertida);

// Tratamento de erro para conversão de datas com TryParse, caso dê erro retorna 01/01/0001 00:00:00
string dataParaConverter = "2022-09-45";

DateTime.TryParseExact(dataParaConverter, // Data a converter
                        "yyyy-MM-dd", // Formato que a data está
                        CultureInfo.InvariantCulture, // Desconsiderar cultura local
                        DateTimeStyles.None, // Desconsiderar estilo de Data
                        out DateTime dataConvertidaComTryParse); // Saída.

Console.WriteLine(dataConvertidaComTryParse);