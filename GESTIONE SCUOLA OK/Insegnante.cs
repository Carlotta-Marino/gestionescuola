using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Gestione
{
    internal class Insegnante
    {
        [JsonProperty("IDInsegnante")]
        public int IDInsegnante { get; set; }

        [JsonProperty("Nome")]
        public string Nome { get; set; }

        [JsonProperty("Cognome")]
        public string Cognome { get; set; }

        [JsonProperty("NomeClasse")]
        public string NomeClasse { get; set; }

        [JsonProperty("NomeMateria")]
        public string NomeMateria { get; set; }

        [JsonProperty("IDMateria")]
        public int IDMateria { get; set; }

        public Insegnante(int id, string nome, string cognome, string nomeClasse, string nomeMateria, int idMateria)
        {
            IDInsegnante = id;
            Nome = nome;
            Cognome = cognome;
            NomeClasse = nomeClasse;
            NomeMateria = nomeMateria;
            IDMateria = idMateria;
        }
    }
}