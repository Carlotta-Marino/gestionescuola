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
        public int IDClasse { get; set; }
        public string NomeClasse { get; set; }

        public Classe(int idClasse, string nomeClasse)
        {
            IDClasse = idClasse;
            NomeClasse = nomeClasse;
        }
    }
}

