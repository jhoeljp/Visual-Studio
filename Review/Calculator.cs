using System;
namespace Hippo
{
    class Calculator
    {
        static void Main(string[] args)
        {
            //get number1
            Console.WriteLine("Enter a number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            //get operator
            Console.WriteLine("Operator: ");
            string op = Console.ReadLine();

            //get number2
            Console.WriteLine("Enter another number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            //perform logic
            if (op == "+") {
                Console.WriteLine(num1 + num2);
            }
            else if (op == "-")
            {
                Console.WriteLine(num1 - num2);
            }
            else if (op == "/")
            {
                Console.WriteLine(num1 / num2);
            }
            else if (op == "*")
            {
                Console.WriteLine(num1 * num2);
            }
            else
            {
                Console.WriteLine("Invalid operator");
            }
        }
    }
}
