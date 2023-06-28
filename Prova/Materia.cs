using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Gestione
{
    internal class Materia
    {
        [JsonProperty("IDMateria")]
        public int IDMateria { get; set; }

        [JsonProperty("NomeMateria")]
        public string NomeMateria { get; set; }
        
        public Materia(int id, string nome)
        {
            IDMateria = id;
            NomeMateria = nome;
        }
    }
}