using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp
{
    public class Input
    {
        public static string StringInput()
        {
            var input = Console.ReadLine();
            return input;
        }

        public static decimal DecimalInput()
        {
            Console.Write("Enter a decimal number: ");
            var input = Convert.ToDecimal(Console.ReadLine());
            return input;
        }
    }
}
