using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.models
{
    public class Curso
    {
        public Curso()
        {

        }

        public Curso(string nomeCursoImputUsuario, decimal valorCursoImputUsuario)
        {
            NomeCurso = nomeCursoImputUsuario;
            ValorCurso = valorCursoImputUsuario;
        }

        public string NomeCurso { get; set; }
        public List<Pessoa> Alunos { get; set; }
        public decimal ValorCurso { get; set; }


        public void AdicionarAluno(Pessoa alunos)
        {
            Alunos.Add(alunos);  
        }

        public int ObterQuantidadeDeAlunosMatriculados()
        {
            int quantidade = Alunos.Count;
            return quantidade;
        }

        public bool RemoverAluno(Pessoa aluno)
        {
            return Alunos.Remove(aluno);
        }

        public void ListarAlunos()
        {
            for (int contador = 0; contador < Alunos.Count; contador++)
            {      
                // Concatenação de string
                string texto1 = "Nº " + contador + " - " + Alunos[contador].NomeCompleto;

                // Interpolação de string
                string texto2 = $"Nº {contador+1} - {Alunos[contador].NomeCompleto}";

                Console.WriteLine(texto2);
            }
        }

        public void MostrarInformacoesAluno(Pessoa aluno)
        {
            for (int contador = 0; contador < Alunos.Count; contador++)
            {
                // Acrescentado :C em valor curso para que imprima automaticamente a informação da moeda local de acordo com o ambiente de trabalho.
                Console.WriteLine($"Nº {contador+1} - Nome: {Alunos[contador].NomeCompleto}, Curso: {NomeCurso}, Valor: {ValorCurso:C}");
            }
        }
    }
}