﻿using System.Collections;
using System.Globalization;
using ExemploExplorando.models;
using Newtonsoft.Json;


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



Console.WriteLine("-------- TUPLAS --------");
// Tuplas, operador ternario e desconstrução de um objeto com C#.
// As tuplas podem guardar em uma única variável vários tipos de dados.

(int, string, decimal) tupla = (1, "Matheus", 1.67M);
(int Id, string Nome, decimal Altura) tulaNomeada = (1, "Matheus", 1.67M);
ValueTuple<int, string, decimal> outroExemplo = (1, "Matheus", 1.67M);

Console.WriteLine(tupla);
Console.WriteLine($"ID: {tupla.Item1}");
Console.WriteLine($"Nome: {tupla.Item2}");
Console.WriteLine($"Altura: {tupla.Item3}");


// Após criar uma classe para ler arquivo e retornar uma tupla.
Console.WriteLine("-------- RETORNO CLASSE TUPLAS --------");

LeituraArquivo arquivoLido = new LeituraArquivo();

var (sucesso, linhasArquivo, quantidadeLinhas) = arquivoLido.LerArquivo("Arquivos/arquivoLeitura.txt");

if (sucesso)
{
    Console.WriteLine($"O arquivo foi lido e tem {quantidadeLinhas} linhas.");

    foreach (string linha in linhasArquivo)
    {
        Console.WriteLine(linha);
    }
}
else
{
    Console.WriteLine("O arquivo não foi lido corretamente.");
}

// Para descartar uma informação que não iremos usar utilizamos o "_".
// var (sucesso, linhasArquivo, _) = arquivoLido.LerArquivo("Arquivos/arquivoLeitura.txt");


// DESCONSTRUTOR
Console.WriteLine("-------- DESCONSTRUTOR --------");


Pessoa p10 = new Pessoa("Matheus", "Felipe");

(string nome, string sobrenome) = p10;

Console.WriteLine($"{nome} {sobrenome}");


// IF CONVENCIONAL
Console.WriteLine("-------- IF CONVENCIONAL --------");

int numeroExemplo = 20;

if (numeroExemplo % 2 == 0)
{
    Console.WriteLine("O número é par.");
}
else
{
    Console.WriteLine("O número é impar.");
}


// IF TERNÁRIO
Console.WriteLine("-------- IF TERNÁRIO --------");
int numeroExemploTernario = 20;
bool ehPar = numeroExemploTernario % 2 == 0;

Console.WriteLine("O número é " + (ehPar ? "PAR": "ÍMPAR"));


// NUGET é um gerenciador de pacotes, permite que desenvolvedores compartilhem pacotes e bibliotecas.

// JASON - é um formato de texto que segue a sintaxe do JavaScript, muito usado para transmitir dados entre aplicações.

Console.WriteLine("-------- SERIALIZAÇÃO PARA JASON --------");

DateTime dataVenda = DateTime.Now;

List<Venda> listaVendas = new List<Venda>();    

Venda venda1 = new Venda (1, "Apontador de lápis", 10.53M, dataVenda);
Venda venda2 = new Venda (2, "Borracha", 12.32M, dataVenda);

listaVendas.Add(venda1);
listaVendas.Add(venda2);

// SERIALIZANDO EM JASON
string venda1Serializada = JsonConvert.SerializeObject(listaVendas, Formatting.Indented);

// Escrever e salvar.
File.WriteAllText("Arquivos/vendas.json", venda1Serializada);

Console.WriteLine(venda1Serializada);


Console.WriteLine("-------- DESERIALIZAÇÃO PARA JASON --------");
// Para deserializar é necessário criar uma classe e criar as propriedades que constam no arquivo Json.
// Para isso é preciso que as propriedades da classe estejam com o mesmo nome de atributos do arquivo Json. Caso não esteja, resolução na classe VendaDeserializada.

string arquivoJason = File.ReadAllText("Arquivos/vendas.json");

List<VendaDeserializada> listaVendaDeserializada = JsonConvert.DeserializeObject<List<VendaDeserializada>>(arquivoJason);

foreach (VendaDeserializada venda in listaVendaDeserializada)
{
    Console.WriteLine($"Id: {venda.Id}, Produto: {venda.Produto}, Preço: {venda.Preco:C}, Data: {venda.Data.ToString("dd/MM/yyyy HH:mm")}");    
}