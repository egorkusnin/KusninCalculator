using System;

namespace KushninCalculatorLib
{
    public class Calculator
    {
        public double Add(double a, double b)
        {
            return a + b;
        }

        public double Subtract(double a, double b)
        {
            return a - b;
        }

        public double Multiply(double a, double b)
        {
            return a * b;
        }

        public double Divide(double a, double b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Деление на ноль невозможно");
            }
            return a / b;
        }

        public double Power(double baseNumber, double exponent)
        {
            return Math.Pow(baseNumber, exponent);
        }

        public double Calculate(double a, double b, string operation)
        {
            switch (operation)
            {
                case "+": return Add(a, b);
                case "-": return Subtract(a, b);
                case "*": return Multiply(a, b);
                case "/": return Divide(a, b);
                case "^": return Power(a, b);
                default: throw new ArgumentException("Неизвестная операция: " + operation);
            }
        }
    }
}