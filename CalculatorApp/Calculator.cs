using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp
{
    public class Calculator
    {
        public static List<String> calculations = new List<String>();

        public static (decimal Result, string Operation) Addition(decimal x, decimal y)
        {
            var result = x + y;
            var operation = $"{x} + {y} = {result}";
            return (result, operation);
        }

        public static (decimal Result, string Operation) Subtraction(decimal x, decimal y)
        {
            var result = x - y;
            var operation = $"{x} - {y} = {result}";
            return (result, operation);
        }

        public static (decimal Result, string Operation) Multiplication(decimal x, decimal y)
        {
            var result = x * y;
            var operation = $"{x} * {y} = {result}";
            return (result, operation);
        }

        public static (decimal Result, string Operation) Division(decimal x, decimal y)
        {
            var operation = "";
            if (y == 0)
            {
                operation = $"{x} / {y} = Cannot divide by zero.";
                Console.WriteLine("Cannot divide by zero.");
                return (0, operation);
            }
            var result = x / y;
            operation = $"{x} / {y} = {result}";
            return (result, operation);
        }

        public static void PerformOperation(Func<decimal, decimal, (decimal Result, string Operation)> operation, string operationName)
        {
            Console.WriteLine("Enter two decimal numbers:");
            decimal x = Input.DecimalInput();
            decimal y = Input.DecimalInput();
            var (result, operationDetails) = operation(x, y);
            Console.WriteLine($"The {operationName} is: {result}");
            calculations.Add(operationDetails);
            Console.ReadKey();
        }
    }
}
