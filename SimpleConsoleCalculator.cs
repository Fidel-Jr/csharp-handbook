using System;

namespace SimpleConsoleCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool looping = true;
            Console.WriteLine("Welcome to my calculator.\n \n");
            do
            {
                int num1 = ReadInt("Enter your first number");

                Console.WriteLine();
                string operatorType = SelectOp("Enter your operator choice");
                Console.WriteLine();

                int num2 = ReadInt("Enter your second number");

                int result = Calculate(num1, num2, operatorType);
                Console.WriteLine(Environment.NewLine + $"The result of {num1} {operatorType} {num2} is {result}");

                Console.WriteLine();
                Console.Write("Do you want to calculate something else?: (y/n) ");
                string choice = Console.ReadLine();
                Console.WriteLine();
                if (choice.ToLower().Contains("y"))
                {
                    looping = true;
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Thank you for using my calculator!");
                    looping = false;
                }


            } while (looping);

        }

        static int ReadInt(string message)
        {
            Console.Write($"{message}: ");
            int result;
            while (!int.TryParse(Console.ReadLine(), out result))
            {
                Console.Write("Invalid input. Please enter a valid integer: ");
            }
            return result;
        }

        static int Calculate(int n1, int n2, string op)
        {
            int result = 0;

            if (op == "+")
            {
                result = n1 + n2;
            }
            else if (op == "-")
            {
                result = n1 - n2;
            }
            else if (op == "*")
            {
                result = n1 * n2;
            }
            else if (op == "/")
            {
                result = n1 / n2;
            }
            return result;
        }


        static string SelectOp(string message)
        {
            bool isValid = false;
            string operatorType = string.Empty;
            Console.WriteLine("Now choose your operator: \n1. plus (+) \n2. minus (-) \n3. multiply (*) \n4. divide (/)");
            do
            {
                Console.WriteLine();
                Console.Write($"{message}: ");
                operatorType = Console.ReadLine().ToLower().Trim();

                if (operatorType == "+" || operatorType == "-" || operatorType == "*" || operatorType == "/")
                {
                    isValid = true;
                }
                else if (operatorType == "1" || operatorType == "plus")
                {
                    operatorType = "+";
                    isValid = true;
                }
                else if (operatorType == "2" || operatorType == "minus")
                {
                    operatorType = "-";
                    isValid = true;
                }
                else if (operatorType == "3" || operatorType == "multiply")
                {
                    operatorType = "*";
                    isValid = true;
                }
                else if (operatorType == "4" || operatorType == "divide")
                {
                    operatorType = "/";
                    isValid = true;
                }
                else
                {
                    message = "Invalid input. Please enter a valid operator";
                    isValid = false;
                }

            } while (!isValid);

            return operatorType;
        }

    }
}
