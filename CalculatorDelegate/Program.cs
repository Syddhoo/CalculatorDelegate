using CalculatorDelegate.Delegates;
using CalculatorDelegate.Services;

namespace CalculatorDelegate;

class Program
{
    static void Main(string[] args)
    {
        CalculatorService calculator = new CalculatorService();

        Console.WriteLine("================================");
        Console.WriteLine("       DELEGATE CALCULATOR      ");
        Console.WriteLine("================================");

        Console.Write("Enter first number: ");
        double firstNumber = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter second number: ");
        double secondNumber = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("\nSelect Operation:");
        Console.WriteLine("1. Addition");
        Console.WriteLine("2. Subtraction");
        Console.WriteLine("3. Multiplication");
        Console.WriteLine("4. Division");
        Console.WriteLine("5. Modulus");

        Console.Write("\nSelect the operation: ");
        string choice = Console.ReadLine() ?? string.Empty;

        CalculatorOperation? operation = choice switch
        {
            "1" => calculator.Add,
            "2" => calculator.Subtract,
            "3" => calculator.Multiply,
            "4" => calculator.Divide,
            "5" => calculator.Modulus,
            _ => null
        };

        if (operation == null)
        {
            Console.WriteLine("Invalid operation.");
            return;
        }

        try
        {
            double result = calculator.Calculate(
                firstNumber,
                secondNumber,
                operation);

            Console.WriteLine($"\nResult: {result}");
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}