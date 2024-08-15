using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.models
{
    public class Pessoa
    {
        
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

        private string NomeCompleto => $"{_Nome} {_Sobrenome}".ToUpper();

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