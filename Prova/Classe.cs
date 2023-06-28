using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Gestione
{
    internal class Classe
    {
        [JsonProperty("IDClasse")]
        public int IDClasse { get; set; }

        [JsonProperty("NomeClasse")]
        public string NomeClasse { get; set; }

        public Classe(int id, string nome)
        {
            IDClasse = id;
            NomeClasse = nome;
        }
    }
}