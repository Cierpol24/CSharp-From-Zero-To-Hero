using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
              Console.Write("Enter your height (cm): ");

               double height = Convert.ToDouble(Console.ReadLine());
              //double height = Console.ReadLine();

            Console.WriteLine((height)+ " cm");

        }
    }
}
