using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPS2
{
    class Circulo : IGeometria
    {
        public double Radio { get; set; }
        public double Diametro { get; set; }

        public double CalcularArea()

        {
            Console.WriteLine("Ingrese radio de círculo");
            Radio = double.Parse(Console.ReadLine());

            return Radio * Radio * Math.PI;
        }

        public double CalcularPerimetro()
        {
            Console.WriteLine("Ingrese diámetro de círculo");
            Diametro = double.Parse(Console.ReadLine());

            return Math.PI * Diametro;
        }
    }
}
