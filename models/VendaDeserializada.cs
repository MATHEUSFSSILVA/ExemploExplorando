using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ExemploExplorando.models
{
    public class VendaDeserializada
    {
        public int Id { get; set; }

        // Utilizado para nomear a propriedade conforme o atributo do arquivo Json, pode-se nomear até mesmo classe.
        // [JsonProperty("Nome_Produto")]
        public string Produto { get; set;}
        public decimal Preco{ get; set;}
        public DateTime Data { get; set;}
    }
}