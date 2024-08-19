using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calulator
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Calc Program");

            Calc();

            

            Console.ReadKey();
        }

        public static void Calc()
        {
            string continueOperation;
            int num1;
            int num2;

            Console.WriteLine("Enter first number: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second number: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter operation symbol: ");
            string operation = Console.ReadLine();

            switch (operation)
            {
                case "+":
                    Console.WriteLine("Result: " + (num1 + num2));
                    break;
                case "-":
                    Console.WriteLine("Result: " + (num1 - num2));
                    break;
                case "*":
                    Console.WriteLine("Result: " + (num1 * num2));
                    break;
                case "/":
                    Console.WriteLine("Result: " + (num1 / num2));
                    break;
                default:
                    Console.WriteLine("Invalid operation");
                    break;
            }

            Console.WriteLine("Keep going? y or n: ");
            continueOperation = Console.ReadLine();

            if (continueOperation == "y")
            {
                Calc();
            }
            else
            {
                Console.WriteLine("Terminating");
            }
        }
    }
}
