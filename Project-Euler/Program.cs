using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Euler
{
    class Program
    {
        static int left, top, opcion, numMax;

        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            int sw = 0;
            Console.Write("Seleccione la opción que desea realizar: ");
            left = Console.CursorLeft;
            top = Console.CursorTop;
            Console.WriteLine("\n 1. Multiplos de 3 y 5");
            Console.WriteLine(" 2. Secuencia de Fibonacci");

            Console.SetCursorPosition(left, top);
            sw = int.Parse(Console.ReadLine());

            switch (sw)
            {
                case 1:
                    Console.Write("\n\nHasta que número quiere obtener: ");
                    numMax = int.Parse(Console.ReadLine());
                    MultiplosTresYCinco mtlp = new MultiplosTresYCinco(numMax);
                    mtlp.Multiplos();
                    break;
                case 2:
                    Console.Write("\n\nHasta que número quiere obtener: ");
                    numMax = int.Parse(Console.ReadLine());
                    Fibonacci fbn = new Fibonacci(numMax);
                    fbn.Fibon();
                    break;
            }

        }
    }
}
