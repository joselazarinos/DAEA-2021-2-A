using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Raiz()
        {
            for (int i = 1; i <= 10; i++)
                Console.WriteLine("La raiz cuadrada de {0} es {1}", i, Math.Sqrt(i));
        }
        static void Main(string[] args)
        {
            Console.Title = "procedimientos y funciones";
            string opcion;
            do
            {


                Console.Clear();
                Console.WriteLine("[1] suma de dos numeros");
                Console.WriteLine("[2] suma de dos numeros");
                Console.WriteLine("[0] salir ");
                Console.WriteLine("Ingrese una opcion y de enter");
                opcion = Console.ReadLine();
                switch (opcion)
                {
                    case "1":
                        Console.WriteLine("Ingrese el primer numero");
                        int a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo numero");
                        int b = Convert.ToInt32(Console.ReadLine());
                        int suma = a + b;
                        Console.WriteLine("La suma de {0} y {1} es {2}", a, b, suma);
                        break;
                    case "2":
                        Console.WriteLine("calculando .....");
                        Raiz();
                        break;

                }
                Console.ReadKey();

            } while (!opcion.Equals("0"));
        }
    }
}
