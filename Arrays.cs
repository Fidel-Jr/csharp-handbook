using System;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Arrays

            string[] myArray; // Declaration - a variable that holds an array of strings

            /*
                To insert values to it, we can use an array literal 
                - place the values in a comma-separated list, inside curly braces
            */

            string[] animals = {"Dog", "Cat", "Fish", "Bird"};


            int[] myNum = { 10, 20, 30, 40 }; // To create an array of integers just write it like this

            
            Console.WriteLine(animals[0] + "\n"); // You access an array element by referring to the index number

            // To change the value of a specific element, still refer to the index number:
            // Example: Change the value of the first element in the animals array to "Monkey"
            animals[0] = "Monkey";
            Console.WriteLine(animals[0] + "\n");

            // To find out how many elements an array has, use the Length property:
            Console.WriteLine(animals.Length + "\n");


            // In C#, there are different ways to create an array

            // 1. Create an array that has four elements, and add values later
            string[] fruits = new string[4];

            // 2. Create an array that has four elements and add values right away 
            string[] fruits2 = new string[4] { "Mango", "Apple", "Banana", "Orange" };

            // 3. Create an array that has four elements without specifying the size 
            string[] fruits3 = new string[] { "Grapes", "Peach", "Rambutan", "Lasones" };

            // 4.Create an array that has four elements, omitting the new keyword, and without specifying the size
            string[] fruits4 = { "Watermelon", "Pineapple", "Strawberry", "Blueberry" };



            // Loop through an array

            for (int i = 0; i < fruits3.Length; i++)
            {
                Console.WriteLine(fruits3[i]);
            }

            Console.WriteLine();

            /* There is also a foreach loop that is used to loop through arrays and collections.
               It is more readable and easier to use than a for loop when you just want to iterate 
               through the elements of an array without needing to know the index.
            */

            foreach (string i in fruits4)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine();

            // Input data into an array using input from the user

            int[] numbers = new int[5]; // Instantiation - creating an instance of the array

            /* To input data into the array, we can use a for loop to iterate through the
               array and assign values to each element based on user input. 
            */

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write("Enter a number: ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"{numbers[i]} ");
            }

            Console.WriteLine();

        }
    }
}
