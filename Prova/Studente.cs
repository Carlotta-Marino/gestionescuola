using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova
{
    internal class Studente
    {
        public int IDStudente { get; set; }
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public DateOnly DataNascita { get; set; }
        public int AnnoCorso { get; set; }
        public string NomeClasse { get; set; }

        public Studente(int id, string nome, string cognome, DateOnly dataNascita, int annoCorso, string nomeClasse)
        {
            IDStudente = id;
            Nome = nome;
            Cognome = cognome;
            DataNascita = dataNascita;
            AnnoCorso = annoCorso;
            NomeClasse = nomeClasse;
        }
    }
}
