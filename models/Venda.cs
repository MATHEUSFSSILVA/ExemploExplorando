using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.models
{
    public class Venda
    {
        public Venda (int id, string produto, decimal preco, DateTime data)
        {
            Id = id;
            Produto = produto;
            Preco = preco;
            Data = data;
        }

        public int Id { get; set; }
        public string Produto { get; set; }
        public decimal Preco { get; set; }
        public DateTime Data { get; set; }
    }
}