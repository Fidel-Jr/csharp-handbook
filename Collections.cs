using System;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            // Lists - a collection of items that can be accessed by index and can grow and shrink in size dynamically

            List<int> listNumbers = new List<int>(); // Declaration and Instantiation of a List of integers

            // To add values to a List, we can use the Add() method
            for (int i = 0; i < 3; i++)
            {
                Console.Write("Enter a number: ");
                listNumbers.Add(Convert.ToInt32(Console.ReadLine()));
            }

            // To access the elements of a List, we can use the index number just like an array
            for (int i = 0; i < listNumbers.Count; i++)
            {
                Console.Write($"{listNumbers[i]} ");
            }

            Console.WriteLine("\n");

            /* To remove an element from a List, we can use the RemoveAt()
               method and specify the index number of the element we want to remove
            */
            listNumbers.RemoveAt(0);
            Console.WriteLine("After removing the first element: ");
            foreach (var item in listNumbers)
            {
                Console.Write($"{item} ");
            }
          

            /* Dictionary - a collection of key-value pairs where each key is unique and maps to a specific value. 
               It allows for fast retrieval of values based on their associated keys.
            */
            
            Console.WriteLine("Dictionary Example: ");
            
            // To create a Dictionary, we need to specify the type of the key and the type of the value in angle brackets
            Dictionary<int, string> names = new Dictionary<int, string>()
            {
                //KeyValuePair
                { 1, "Aba" },
                { 2, "Test1" },
                { 3, "Test2" }
            };
            
            // To access the value associated with a specific key, we can use the indexer syntax
            for (int i = 0; i < names.Count; i++)
            {
                KeyValuePair<int, string> pair = names.ElementAt(i);
                Console.WriteLine($"{pair.Key} - {pair.Value}");
            }
            
            Console.WriteLine();
            
            // We can also use a foreach loop to iterate through the key-value pairs in the Dictionary
            foreach (KeyValuePair<int, string> item in names)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }
            
            Console.WriteLine();
            
            // To check if a specific key exists in the Dictionary, we can use the ContainsKey() method
            Dictionary<string, string> teachers = new Dictionary<string, string>()
            {
                { "Math", "Aba" },
                { "Programming 1", "Colins" }
            };
            
            // To retrieve the value associated with a specific key, we can use the TryGetValue() method
            if (teachers.TryGetValue("Math", out string teacher))
            {
                Console.WriteLine("Math teacher found!");
                Console.WriteLine(teacher);
            
                teachers["Math"] = "Joe";
            }
            else
            {
                Console.WriteLine("Math teacher not found!"); // If the key does not exist, the TryGetValue() method will return false and the out parameter will be set to the default value of the value type (null for reference types)
            }
            
            // To remove a key-value pair from the Dictionary, we can use the Remove() method and specify the key of the pair we want to remove
            if (teachers.ContainsKey("Math"))
            {
                teachers.Remove("Math");
            }
            else
            {
                Console.WriteLine("Math not found!");
            }

        }
    }
}
