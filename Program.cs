using System.Collections;
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


// Ler Arquivo de texto e tratar exceções.
Console.WriteLine("Lendo arquivos");

string status = "Arquivo não lido";
try
{
    string[] arquivo = File.ReadAllLines("Arquivos/arquivoLeitura.txt");

    foreach (string linha in arquivo)
    {
        Console.WriteLine(linha);
    }

    status = "Arquivo lido com sucesso";
}
catch (FileNotFoundException ex)
{
    Console.WriteLine($"Arquivo não encontrado. {ex.Message}");
}
catch (DirectoryNotFoundException ex)
{
    Console.WriteLine($"Caminho inválido. {ex.Message}");
}
finally
{
    Console.WriteLine(status);
}

// Throw joga a exceção do programa para cima até achar um bloco que contenha o catch para tratá-la.
// throw new Exception ("Ocorreu uma exceção");

// Coleções - QUEUE (FILAS) - Obedece a regra FIFO, first in first out, primeiro que entra é o primeiro que sai.
// Cria uma fila inserindo os elementos e quando retiramos um elemento, o elemento removido sempre será o primeiro elemento inserido.
Queue<int> fila = new Queue<int>();

// inserindo elemento
fila.Enqueue(1);
fila.Enqueue(2);
fila.Enqueue(3);
fila.Enqueue(4);

foreach (int item in fila)
{
    Console.WriteLine (item);
}

// Removendo elemento
Console.WriteLine($"Removendo o elemento {fila.Dequeue()}");

foreach (int item in fila)
{
    Console.WriteLine (item);
}


Console.WriteLine("PILHAS");
// Coleções - Stack (PILHA) - Obedece a regra LIFO, last in first out, último que entra é o primeiro que sai.
// Lembrar de uma pilha de roupa, sempre retirar de cima.
Stack<int> pilha = new Stack<int>();

pilha.Push(1);
pilha.Push(2);
pilha.Push(3);
pilha.Push(4);

foreach (int item in pilha)
{
    Console.WriteLine(item);
}

Console.WriteLine($"Removendo o elemento {pilha.Pop()}");

foreach (int item in pilha)
{
    Console.WriteLine(item);
}

Console.WriteLine("Dicionários");
// Coleções - Dictionary - É uma coleção de chave e valor para armazenar valores únicos sem uma ordem específica.
// Declarado dois tipos, string string, uma para chave e outra para valor.
Dictionary<string, string> estados = new Dictionary<string, string>();

// Adicionar
estados.Add("SP", "São Paulo");
estados.Add("RJ", "Rio de Janeiro");
estados.Add("BA", "Bahia");

foreach (var item in estados)
{
    Console.WriteLine($"Chave: {item.Key} - Valor: {item.Value}");
}

Console.WriteLine("--------");

// Remover
estados.Remove("SP");

foreach (var item in estados)
{
    Console.WriteLine($"Chave: {item.Key} - Valor: {item.Value}");
}

Console.WriteLine("--------");

// Alterar valor
estados["BA"] = "Valor alterado";

foreach (var item in estados)
{
    Console.WriteLine($"Chave: {item.Key} - Valor: {item.Value}");
}
