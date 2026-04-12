using System;

namespace SimpleConsoleCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /* Will run the calculator until the user decides to stop it.
               It will ask for two numbers and an operator, then it will calculate the result and display it to the user.
               After that, it will ask if the user wants to calculate something else.
               If the user enters 'y', it will continue, otherwise it will stop and display a thank you message.
            */
            
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

        /* This method reads an integer from the console and validates the input.
           It keeps prompting the user until a valid integer is entered.
        */
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

        /* This method prompts the user to select an operator for a calculation.
           It validates the input to ensure that it is a valid operator (either "+", "-", "*", or "/") and
           returns the selected operator as a string.
        */
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

        /* This method takes two integers and a string operator as input and performs the corresponding arithmetic operation
           based on the operator provided. It returns the result of the calculation.
        */
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

    }
}
