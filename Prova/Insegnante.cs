using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova
{
    internal class Insegnante
    {
        public int IDInsegnante { get; set; }
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public string NomeClasse { get; set; }
        public string NomeMateria { get; set; }
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
