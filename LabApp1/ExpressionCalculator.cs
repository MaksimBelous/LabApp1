using System;

namespace LabApp1
{
    public class ExpressionCalculator
    {
        public double Calculate(double a, double b, double c, double d)
        {

            double numerator = a * b / 4 - 1;

            double valueUnderSquareRoot = 41 - d;
            if (valueUnderSquareRoot < 0)
            {
                throw new ArgumentException("Квадратного кореня з від'ємних чисел не існує");
            }

            double denominator = Math.Sqrt(valueUnderSquareRoot) - b * a + c;
            if (denominator.Equals(0))
            {
                throw new DivideByZeroException("Вираз з діленням на 0 не має сенсу");
            }

            return numerator / denominator;
        }
    }
}