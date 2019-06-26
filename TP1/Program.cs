using System;
using System.Collections.Generic;
using System.Globalization;

namespace TP1
{
    class Program
    {
        static void Main(string[] args)
        {
            // TP 1

            //EJERCICIO 1 - Realizar un programa de consola que permita ingresar el nombre y apellido por separado, con estos datos debe imprimir un mensaje con el nombre completo.

            Console.WriteLine("Ingrese su Nombre");
            var nombre = Console.ReadLine();
            //se usa para poner mayúsculas en la primera letra.
            nombre = CultureInfo.InvariantCulture.TextInfo.ToTitleCase(nombre);

            Console.WriteLine("Ingrese su Apellido");
            var apellido = Console.ReadLine();
            apellido = CultureInfo.InvariantCulture.TextInfo.ToTitleCase(apellido);

            //se decide utilizar interpolación
            Console.WriteLine($"Nombre completo: {nombre} {apellido}");
            Console.ReadKey();

            //EJERCICIO 2 - Realizar un programa de consola que permita ingresar el nombre y la edad, con estos datos debe imprimir un mensaje diciendo si es mayor de edad o no.

            Console.WriteLine("Ingrese su nombre");
            var nombre2 = Console.ReadLine();

            Console.WriteLine("Ingrese su edad");
            var edad = int.Parse(Console.ReadLine());

            if (edad >= 18)
            {
                Console.WriteLine($"Hola, {nombre2}. Al tener {edad} años, usted es mayor de edad");
                Console.ReadKey();
            }
            else if (edad == 0)
            {
                Console.WriteLine($"Hola, {nombre2}. Al tener {edad} años, usted no nació aún");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine($"Hola, {nombre2}. Al tener {edad} años, usted es menor de edad");
                Console.ReadKey();
            }

            //EJERCICIO 3 - Realizar un programa de consola que permita ingresar un numero y calcule la suma de todos los numeros enteros anteriores

            Console.WriteLine("Ingrese un número");
            var num = int.Parse(Console.ReadLine());

            var suma = 0;

            for (int i = 0; i <= num; i++)
            {
                suma += i;
            }

            Console.WriteLine($"La suma de todos los números anteriores es {suma}");
            Console.ReadKey();



           // EJERCICIO 4 - Realizar un programa de consola que permita ingresar 2 valores y encuentr el maximo comun divisor

            Console.WriteLine("Ingrese el primer número");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo número");
            int b = int.Parse(Console.ReadLine());

            for (int i = a; i > 0; i--)
            {
                if (a % i == 0 && b % i == 0)
                {
                    Console.WriteLine("El divisor max es {0} ", i);
                    i = 0;
                }
            }

            Console.ReadKey();

            //EJERCICIO 5 - Realizar un programa de consola que permita ingresar numeros y que termine de pedir numeros cuando se ingresa 0 y calcule el promedio de todos los ingresados

            int num2 = 1;

            List<int> numeros = new List<int>();

            while (num2 != 0)
            {
                Console.WriteLine("Ingrese el primer número");
                num2 = int.Parse(Console.ReadLine());

                numeros.Add(num2);
            }

            int suma2 = 0;
            foreach (var item in numeros)
            {
                suma2 += item;
            }

            var promedio = suma2 / numeros.Count;

            Console.WriteLine($"El promedio es {promedio}");
            Console.ReadKey();
    }
    }
}
