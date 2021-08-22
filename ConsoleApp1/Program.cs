using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static int Suma(int a, int b)
        {
            return a + b;
        }
        static int Resta(int c, int d)
        {
            return c - d;
        }
        static int Multi(int e, int f)
        {
            return e * f;
        }
        static int Division(int g, int h)
        {
            return g / h;
        }
        static void Raiz()
        {
            for (int i = 1; i <= 10; i++)
                Console.WriteLine("La raiz cuadrada de {0} es {1}", i, Math.Sqrt(i));
        }
        static void Primo()
        {
            int cont = 0;
            for (int l = 2; l <= 30; l++) {
                for (int k = 1; k <= l; k++) {
                    if (l % k == 0)
                    {
                        cont = cont + 1;
                    }
}
                if (cont <= 2)
                {
                    Console.WriteLine(l);
                }
                cont = 0;
            }
            Console.ReadKey();
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
                Console.WriteLine("[3] resta de dos numeros");
                Console.WriteLine("[4] multiplicasion de dos numeros");
                Console.WriteLine("[5] division de dos numeros");
                Console.WriteLine("[6] division de dos numeros");
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
                        int Suma = a + b;
                        Console.WriteLine("La suma de {0} y {1} es {2}", a, b, Suma);
                        break;
                    case "2":
                        Console.WriteLine("calculando .....");
                        Raiz();
                        break;
                    case "3":
                        Console.WriteLine("Ingrese el primer numero");
                        int c = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo numero");
                        int d = Convert.ToInt32(Console.ReadLine());
                        int Resta = c - d;
                        Console.WriteLine("La resta de {0} y {1} es {2}", c, d, Resta);
                        break;
                    case "4":
                        Console.WriteLine("Ingrese el primer numero");
                        int e = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo numero");
                        int f = Convert.ToInt32(Console.ReadLine());
                        int Multi = e * f;
                        Console.WriteLine("La resta de {0} y {1} es {2}", e, f, Multi);
                        break;
                    case "5":
                        Console.WriteLine("Ingrese el primer numero");
                        int g = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo numero");
                        int h = Convert.ToInt32(Console.ReadLine());
                        int Division = g / h;
                        Console.WriteLine("La resta de {0} y {1} es {2}", g, h, Division);
                        break;
                    case "6":
                        Console.WriteLine("calculando");
                        Primo();
                        break;
                }
                Console.ReadKey();

            } while (!opcion.Equals("0"));
        }
    }
}
