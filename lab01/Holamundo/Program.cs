using System;

namespace Holamundo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola, como te llamas:");
            String nombre = Console.ReadLine();
            Console.WriteLine("mucho gusto en conocerte" + nombre);
        }
    }
}
