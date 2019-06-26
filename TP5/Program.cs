using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP5
{
    class Program
    {
        static void Main(string[] args)
        {

            Materia m1 = new Materia
            {
                Año = 2019,
                Cuatrimestre = 1,
                Nombre = "dotnet",
                Notas = new List<Notas> {
                    new Notas
                    { Fecha = DateTime.Now, Tipo = "TP", Valor = 5 },
                    new Notas
                    { Fecha = DateTime.Now, Tipo = "PARCIAL1", Valor = 7},
                    new Notas
                    {Fecha = DateTime.Now, Tipo ="PARCIAL2", Valor = 4 },
                    new Notas
                    {Fecha = DateTime.Now, Tipo="TP", Valor = 3 },
                    new Notas
                    {Fecha = DateTime.Now, Tipo = "PARCIAL1", Valor = 6 },
                    new Notas
                    {Fecha = DateTime.Now, Tipo = "PARCIAL2", Valor = 5}
                }
            };

            Materia m2 = new Materia
            {
                Año = 2019,
                Cuatrimestre = 1,
                Nombre = "java",
                Notas = new List<Notas> {
                    new Notas
                    { Fecha = DateTime.Now, Tipo = "TP", Valor = 8 },
                    new Notas
                    { Fecha = DateTime.Now, Tipo = "PARCIAL1", Valor = 2},
                    new Notas
                    {Fecha = DateTime.Now, Tipo ="PARCIAL2", Valor = 1 },
                    new Notas
                    {Fecha = DateTime.Now, Tipo="TP", Valor = 5 },
                    new Notas
                    {Fecha = DateTime.Now, Tipo = "PARCIAL1", Valor = 3 },
                    new Notas
                    {Fecha = DateTime.Now, Tipo = "PARCIAL2", Valor = 8}
                }
            };

            Materia m3 = new Materia
            {
                Año = 2017,
                Cuatrimestre = 1,
                Nombre = "ux",
                Notas = new List<Notas> {
                    new Notas
                    { Fecha = DateTime.Now, Tipo = "TP", Valor = 8 },
                    new Notas
                    { Fecha = DateTime.Now, Tipo = "PARCIAL1", Valor = 2},
                    new Notas
                    {Fecha = DateTime.Now, Tipo ="PARCIAL2", Valor = 1 },
                    new Notas
                    {Fecha = DateTime.Now, Tipo="TP", Valor = 5 },
                    new Notas
                    {Fecha = DateTime.Now, Tipo = "PARCIAL1", Valor = 3 },
                    new Notas
                    {Fecha = DateTime.Now, Tipo = "PARCIAL2", Valor = 8}
                }
            };

            var materias = new List<Materia>()
            {
                m1,
                m2,
                m3
            };

            var cuatri1 = 0;

            //Orden alfabético

            materias.OrderBy(x => x.Nombre).ToList();

            foreach (Materia m in materias)
            {
                if(m.Cuatrimestre == 1)
                { 
                    cuatri1++;
                }

                Console.WriteLine("materias: " +  m.Nombre.ToString() + " " + m.Año.ToString() + " "  + m.Cuatrimestre.ToString());
                // Promedio de una materia
                var average = m.Notas.Average(item => item.Valor);
          
                Console.WriteLine("el promedio de la materia " + m.Nombre + " es: " + average);

                //foreach para mostrar notas
                foreach (var n in m.Notas)
                {
                    if(n.Tipo == "TP")
                    {
                        Console.WriteLine("Notas POR ORDEN TP: " + n.Tipo.ToString() + " " + n.Fecha.ToString() + " " + n.Valor.ToString());
                    }                   
                }
            }

            Console.WriteLine("hay " + cuatri1 + " materias del primer cuatrimestre");
            Console.ReadLine();
    }
    }
}
