// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
using System;


namespace MyCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Basic Calculator");
            Console.WriteLine("Enter Your First Number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Valid Operator(+ , - , * /)");
            string operation = Console.ReadLine();
            Console.WriteLine("Enter Your Second Number");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int result = 0;
            switch (operation)
            {
                case "+":
                    result = num1 + num2;
                    break;

                case "-":
                    result = num1 - num2;
                    break;

                case "*":
                    result = num1 * num2;
                    break;

                case "/":
                    if (num1 > 0 && num2 > 0)
                    {
                        result = num1 / num2;
                    }
                    else
                    {
                        Console.WriteLine("Invalid Operator Or Invalid Number ");
                    }
                    break;
                default:
                    Console.WriteLine("Invalid Operator");
                    break;
            }

            Console.WriteLine($"{num1} {operation} {num2} = {result}");
        }
    }

}