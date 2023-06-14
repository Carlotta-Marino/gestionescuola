using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova
{
    internal class Valutazione
    {
        public int IDValutazione { get; set; }
        public float Voto { get; set; }
        public float Media { get; set; }
        public int IDMateria { get; set; }
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
