using System;

namespace HelloApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write ("введите имя ");
            String Name1 = Console.ReadLine();
            Console.WriteLine($"Привет {Name1}");
            Console.ReadKey();
          
            int [ ] m = new int[] {10, 20, 30, 40}:
            foreach (int i in m) 
            {
                Console.WriteLine(i);
            }
                Console.WriteLine("Новая штука");
        }
    }
}
