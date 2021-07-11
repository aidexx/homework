using System;

namespace Homework_GIT
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите x");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите y");
            double y = Convert.ToDouble(Console.ReadLine());

            char action = Convert.ToChar(Console.Read());


            switch (action)
            {
                default:
                    Console.WriteLine("Введите корректный символ");
                    break;
            }

        }

        static double Multiply(double x, double y)
        {
            return x * y;
        }
    }
}
