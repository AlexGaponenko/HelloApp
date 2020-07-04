using System;

namespace HelloApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write ("введите имя ");
            String Name = Console.ReadLine();
            Console.WriteLine($"Привет {Name}");
            Console.ReadKey();
        }
    }
}
