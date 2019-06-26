using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPS2
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo t = new Triangulo();
            Cuadrado c = new Cuadrado();
            Circulo cir = new Circulo();

            Console.WriteLine("Ingrese de qué figura quiere sacar el área o perímetro: \n t-triangulo \n c-circulo \n q-cuadrado");
            string operaciones = Console.ReadLine();

            switch (operaciones)
            {
                case "t":
                    Console.WriteLine("Ingrese si quiere calcular -a área \n -p perímetro");
                    string subop = Console.ReadLine();
                    switch (subop)
                    {
                        case "a":   
                            Console.WriteLine("El área del triángulo es "+ t.CalcularArea());
                            Console.ReadKey();
                            break;

                        case "p":
                            Console.WriteLine("El perímetro del triángulo es "+ t.CalcularPerimetro());
                            Console.ReadKey();
                            break;
                    }
                    break;

                case "c":
                    Console.WriteLine("Ingrese si quiere calcular -a área \n -p perímetro");
                    string subop1 = Console.ReadLine();
                    switch (subop1)
                    {
                        case "a":
                            
                            Console.WriteLine("El área del círculo es "+ cir.CalcularArea());
                            Console.ReadKey();
                            break;

                        case "p":
                            Console.WriteLine("El perímetro del círculo es "+ cir.CalcularPerimetro());
                            Console.ReadKey();
                            break;
                    }
                break;

                case "q":
                    Console.WriteLine("Ingrese si quiere calcular -a área \n -p perímetro");
                    string subop2 = Console.ReadLine();
                    switch (subop2)
                    {
                        case "a":
                           
                            Console.WriteLine("El área del cuadrado es "+ c.CalcularArea());
                            Console.ReadKey();
                            break;
                        case "p":
                           
                            Console.WriteLine("El perímetro del cuadrado es "+ c.CalcularPerimetro());
                            Console.ReadKey();
                            break;
                    }
                    break;

            }

        }
    }
}
