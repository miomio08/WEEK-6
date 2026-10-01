using System;

namespace _6B
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your survivor name:");

            string survivorName = Console.ReadLine();

            Console.WriteLine("Survivor " + survivorName + ", the bunker is secure. Your next mission is waiting.");
        }
    }
}
