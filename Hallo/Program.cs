using System;

namespace Hallo
{
    class Program
    {
        static void Main(string[] args)
        {
            string MyName = "ЭВМ";
            Console.WriteLine("Привет, человек!");
            Console.WriteLine("Меня зовут {0}", MyName);
            Console.WriteLine("А как тебя зовут?\n");
            string YourName = Console.ReadLine();
            Console.WriteLine("\nРад знакомству, {0}!", YourName);

            Console.WriteLine("\nДля продолжения нажмите любую клавишу . . .");
            Console.ReadKey();
        }
    }
}
