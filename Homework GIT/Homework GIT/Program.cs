using System;

namespace Homework_GIT
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите x : ");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите y : ");
            double y = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите операцию : ");
            char action = Convert.ToChar(Console.Read());


            switch (action)
            {
                case '*':
                    PrintResult(Multiply(x,y));
                    break;
                default:
                    Console.WriteLine("Введите корректный символ");
                    break;
            }

        }

        static void PrintResult(double res)
        {
            Console.WriteLine($"Результат : {res}");
        }

        static double Multiply(double x, double y)
        {
            return x * y;
        }
    }
}
