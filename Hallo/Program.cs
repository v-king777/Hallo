using System;

namespace Hallo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите своё имя:");
            string name = Console.ReadLine();
            Console.WriteLine("Привет, {0}!", name);
            Console.WriteLine("\nДля продолжения нажмите любую клавишу . . .");
            Console.ReadKey();
        }
    }
}
