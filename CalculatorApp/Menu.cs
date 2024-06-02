using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp
{
    public class Menu
    {
        public static void MainMenu()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("===== Welcome to the calculator! =====" +
                    "\n\nWhat do you want to do?" +
                    "\n[1] Addition" +
                    "\n[2] Subtraction" +
                    "\n[3] Multiplication" +
                    "\n[4] Division" +
                    "\n[5] Previous calculations" +
                    "\n[6] Exit");

                var input = Input.StringInput();

                switch (input)
                {
                    case "1":
                        Calculator.PerformOperation(Calculator.Addition, "sum");
                        break;
                    case "2":
                        Calculator.PerformOperation(Calculator.Subtraction, "difference");
                        break;
                    case "3":
                        Calculator.PerformOperation(Calculator.Multiplication, "product");
                        break;
                    case "4":
                        Calculator.PerformOperation(Calculator.Division, "quotient");
                        break;
                    case "5":
                        ShowCalculations();
                        break;
                    case "6":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("You must choose 1-6");
                        Console.ReadKey();
                        break;
                }
            }
        }

        private static void ShowCalculations()
        {
            Console.WriteLine("Previous calculations:");
            foreach (var calc in Calculator.calculations)
            {
                Console.WriteLine(calc);
            }
            Console.ReadKey();
        }
    }
}
