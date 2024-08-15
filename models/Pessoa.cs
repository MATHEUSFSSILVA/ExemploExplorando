using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.models
{
    public class Pessoa
    {
        // Construtor, tem o mesmo nome da classe e é o primeiro item da classe, por convenção fica logo abaixo da classe.
        public Pessoa()
        {
            // Este construtor não recebe nada, serve como valor padrão da classe.
        }

        public Pessoa(string nomeImputUsuario, string sobrenomeImputUsuario)
        {
            // Este construtor recebe nome e sobrenome imputados pelo usuário e agrega para as propriedades.
            Nome = nomeImputUsuario;
            Sobrenome = sobrenomeImputUsuario;
        }
        
        private string _Nome = "";
        private string _Sobrenome = "";
        private int _Idade = 0;

        public string Nome 
        {
            get => _Nome.ToUpper();

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("O nome não pode estar vazio");
                }

                if (string.IsNullOrWhiteSpace(value.Trim()))
                {
                    throw new ArgumentNullException("O nome não pode ter somente espaços");
                }
               
                _Nome = value;
            } 
        }

        public string Sobrenome 
        {
            get => _Sobrenome.ToUpper();

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("O nome não pode estar vazio");
                }

                if (string.IsNullOrWhiteSpace(value.Trim()))
                {
                    throw new ArgumentNullException("O nome não pode ter somente espaços");
                }
               
                _Sobrenome = value;
            } 
        }

        public string NomeCompleto => $"{_Nome} {_Sobrenome}".ToUpper();

        public int Idade
        {
            get => _Idade;

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("A idade não pode ser menor que zero");
                }

                _Idade = value;
            }
        }

        

        public void Apresentar()
        {
            Console.WriteLine($"Nome: {NomeCompleto}, Idade: {Idade}");
        }

    }
}