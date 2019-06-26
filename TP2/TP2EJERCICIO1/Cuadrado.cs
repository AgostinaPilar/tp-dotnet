using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPS2
{
    class Cuadrado : IGeometria
    {
        public double Base { get; set; }

        public double Altura { get; set; }

        public double Lado { get; set; }

        public double CalcularArea()
        {
            Console.WriteLine("Ingrese base de cuadrado");
            Base = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese altura de cuadrado");
            Altura = double.Parse(Console.ReadLine());

            return Base * Altura;
        }

        public double CalcularPerimetro()
        {
            Console.WriteLine("Ingrese lado de cuadrado");
            Lado = double.Parse(Console.ReadLine());
            return Lado * 4;
        }
    }
}
