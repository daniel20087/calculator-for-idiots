using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = 0;
            double num2 = 0;
            double result;
            Console.WriteLine("enter the first number, if you were better at math you wouldn't be here");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter the second number, you failure");
            num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter the operator, you leach");

            switch (Console.ReadLine())
            {
                case "+":
                    result = num1 + num2;
                    Console.WriteLine("your result is " + result);
                    break;
                    case "-":
                    result = num1 - num2;
                    Console.WriteLine("your result is " + result);
                    break;
                case "*":
                    result = num1 * num2;
                    Console.WriteLine("your result is " + result);
                    break;
                case "/":
                    result = num1 / num2;
                    Console.WriteLine("your result is " + result);
                        break;
            }



            Console.ReadKey();
        }
    }
}
