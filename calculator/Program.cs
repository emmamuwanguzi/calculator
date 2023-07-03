using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    class Program
    {
        string oper;
        double res = 0;

        static void Main(string[] args)
        {
            double res = 0;
            string value;
            do
            {
                Console.WriteLine("Input operation to perform");


                var inputParts = Console.ReadLine().Split(' ');
                double a = double.Parse(inputParts[0]);
                string c = inputParts[1]; // "inputpart1"
                double b = double.Parse(inputParts[2]);
                switch (c)
                {
                    case "+":
                        res = a + b;
                        Console.WriteLine("({0}) {1} ({2}) =({3})", a, c, b, res);
                        break;
                    case "-":
                        res = a - b;
                        Console.WriteLine("({0}) {1} ({2}) =({3})", a, c, b, res);
                        break;
                    case "*":
                        res = a * b;
                        Console.WriteLine("({0}) {1} ({2}) =({3})", a, c, b, res);
                        break;
                    case "/":
                        div(a, b);


                        break;
                    default:
                        Console.WriteLine("Invalid input");
                        break;
                }
                Console.BackgroundColor = ConsoleColor.Blue;
                
                Console.ReadLine();
                Console.Write("press ENTER to continue:\nPress Q to Quit");
                value = Console.ReadLine();
                if (value == "Q" || value == "q")
                    break;
                Console.BackgroundColor = ConsoleColor.Black;
            }
            while (value != "Q" || value != "q");
        }
        static void div(double a, double b)
        {

            if (b == 0)
            {
                Console.WriteLine("Division by zero...");
            }
            else
            {
                double c = a / b;
                //Console.WriteLine("({0})/({1}) = {2}", a, b, c);
                Console.WriteLine("({0}) / ({1}) =({2})", a, b, c);
            }
            Console.ReadLine();
        }
    }

    }
