using CalculatorDelegate.Delegates;

namespace CalculatorDelegate.Services
{
    public class CalculatorService
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
                throw new DivideByZeroException("Cannot divide by zero.");

            return a / b;
        }

        public double Modulus(double a, double b)
        {
            if (b == 0)
                throw new DivideByZeroException("Cannot calculate modulus with zero.");

            return a % b;
        }

        // Demonstrating delegate as a method parameter
        public double Calculate(
            double a,
            double b,
            CalculatorOperation operation)
        {
            return operation(a, b);
        }
    }
}
