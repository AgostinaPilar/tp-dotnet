using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP5
{
    class Materia
    {
        public string Nombre { get; set; }

        public int Año { get; set; }

        public int Cuatrimestre { get; set; }

        public List<Notas> Notas { get; set; }      
    }
}
