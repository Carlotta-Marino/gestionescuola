using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Gestione
{
    internal class Valutazione
    {
        [JsonProperty("IDValutazione")]
        public int IDValutazione { get; set; }

        [JsonProperty("Voto")]
        public float Voto { get; set; }

        [JsonProperty("Media")]
        public float Media { get; set; }

        [JsonProperty("IDMateria")]
        public int IDMateria { get; set; }

        [JsonProperty("IDStudente")]
        public int IDStudente { get; set; }

        public Valutazione(int id, float voto, float media, int idMateria, int idStudente)
        {
            IDValutazione = id;
            Voto = voto;
            Media = media;
            IDMateria = idMateria;
            IDStudente = idStudente;
        }
    }
}