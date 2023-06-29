using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Gestione
{
    internal class Studente
    {
        [JsonProperty("IDStudente")]
        public int IDStudente { get; set; }

        [JsonProperty("Nome")]
        public string Nome { get; set; }

        [JsonProperty("Cognome")]
        public string Cognome { get; set; }

        [JsonProperty("DataNascita")]
        public DateOnly DataNascita { get; set; }

        [JsonProperty("AnnoCorso")]
        public int AnnoCorso { get; set; }

        [JsonProperty("NomeClasse")]
        public string NomeClasse { get; set; }

        [JsonProperty("ValutazioneMedia")]
        public float ValutazioneMedia { get; set; }

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