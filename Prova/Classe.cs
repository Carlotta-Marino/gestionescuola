using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova
{
    internal class Classe
    {
        public int IDClasse { get; set; }
        public string NomeClasse { get; set; }

        public Classe(int id, string nome)
        {
            IDClasse = id;
            NomeClasse = nome;
            
        }
    }
}
