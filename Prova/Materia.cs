using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova
{
    internal class Materia
    {
        public int IDMateria { get; set; }
        public string NomeMateria { get; set; }

        public Materia(int id, string nome)
        {
            IDMateria = id;
            NomeMateria = nome;
        }
    }
}
