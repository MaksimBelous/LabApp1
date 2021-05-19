using System;

namespace LabApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            ExpressionCalculator expressionCalculator = new ExpressionCalculator();
            double[,] parameters = {{1, 2, 3, 42}, {2, 4, 2, 5}, {-1, 2, 9, 1}};

            for (int i = 0; i < 3; i++)
            {
                double a = parameters[i, 0];
                double b = parameters[i, 1];
                double c = parameters[i, 2];
                double d = parameters[i, 3];

                try
                {
                    double result = expressionCalculator.Calculate(a, b, c, d);
                    Console.WriteLine("Результат виразу {0}", result);
                }
                catch (ArgumentException e)
                {
                    Console.WriteLine("Опрацювання виняткової ситуації з аргументом {0}", e);
                }
                catch (DivideByZeroException e)
                {
                    Console.WriteLine("Опрацювання виняткової ситуації з діленням на нуль {0}", e);
                }
            }
        }
    }
}