using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1, number2;

            Console.WriteLine("Введiть перше число:");
            if (!int.TryParse(Console.ReadLine(), out number1))
            {
                Console.WriteLine("Некоректний формат числа!");
                return;
            }

            Console.WriteLine("Введiть друге число:");
            if (!int.TryParse(Console.ReadLine(), out number2))
            {
                Console.WriteLine("Некоректний формат числа!");
                return;
            }

            double sum = number1 + number2;
            Console.WriteLine($"Сума чисел {number1} та {number2} дорiвнює: {sum}");
        }
    }
}
