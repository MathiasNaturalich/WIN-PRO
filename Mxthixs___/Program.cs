using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mxthixs___
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("=== SISTEMA DE CONDICIONALES ===");

            Console.Write("\nIngresa tu edad: ");
            int edad = int.Parse(Console.ReadLine());

            if (edad >= 18)  // Condicional simple
            {
                Console.WriteLine("Eres mayor de edad.");
            }
            Console.Write("\nIngresa un número: ");
            int numero = int.Parse(Console.ReadLine());
        }
    }
}
