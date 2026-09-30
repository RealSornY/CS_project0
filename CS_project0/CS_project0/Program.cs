using System;

namespace CS_project0
{
    class Program
    {
        static double Add(double x, double y)
        {
            return x + y;
        }
        static double Subtract(double x, double y)
        {
            return x - y;
        }
        static double Multiply(double x, double y)
        {
            return x * y;
        }
        static double Divide(double x, double y)
        {
            return x / y;
        }

        static void Main(string[] args)
        {
            double num0, num1;
            char op;

            num0 = Convert.ToDouble(Console.ReadLine());
            op = Convert.ToChar(Console.ReadLine());
            num1 = Convert.ToDouble(Console.ReadLine());

            switch (op)
            {
                case '+':
                    Console.WriteLine(Add(num0, num1));
                    break;

                case '-':
                    Console.WriteLine(Subtract(num0, num1));
                    break;

                case '*':
                    Console.WriteLine(Multiply(num0, num1));
                    break;

                case '/':
                    if (num1 == 0)
                    {
                        Console.WriteLine("CAN'T DIVIDE BY ZERO!");
                        break;
                    }
                    Console.WriteLine(Divide(num0, num1));
                    break;

                default:
                    Console.WriteLine("INVALID OPERATION!");
                    break;
            }
        }
    }
}