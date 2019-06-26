using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPS2
{
    class Triangulo : IGeometria
    {
        public double Base { get; set; }

        public double Altura { get; set; }

        public double Lado1 { get; set; }

        public double Lado2 { get; set; }

        public double Lado3 { get; set; }

        public double CalcularArea()
        {
            Console.WriteLine("Ingrese base de triángulo");
            Base = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese altura de triángulo");
            Altura = double.Parse(Console.ReadLine());
            return (Base * Altura) / 2;
           
        }

        public double CalcularPerimetro()
        {
            Console.WriteLine("Ingrese lado 1 de triángulo");
            Lado1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese lado 2 de triángulo");
            Lado2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese lado 3 de triángulo");
            Lado3 = double.Parse(Console.ReadLine());

            return Lado1 + Lado2 + Lado3;
        }
    }
}
