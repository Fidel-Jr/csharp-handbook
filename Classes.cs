using System;

namespace Classes
{
    // This class represents a person with a name and age.
    class Person
    {
        public string Name { get; set; } // Class property for the name of the person.  With the get and set accessors, you can read and modify the name of the person.
        public int Age { get; set; } // Class property for the age of the person. With the get and set accessors, you can read and modify the age of the person.

        // Constructor that initializes the name and age of the person.
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        // Default constructor that lets you create a person without specifying a name or age.
        public Person()
        {

        }
        // Method to display the name and age of the person.
        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("John", 21); // Creating a new instance of the Person class with the name "Jon" and age 21.
            Person person2 = new Person("Dwayne", 30); // Creating another instance of the Person class with the name "Dwayne" and age 30.
            // Displaying the name and age of the first person.
            Console.WriteLine($"Person 1: Name - {person.Name} Age - {person.Age}");

            person.DisplayInfo(); // Calling the DisplayInfo method to display the name and age of the first person.
            
            // Displaying the name and age of the second person.
            Console.WriteLine($"Person 1: Name - {person2.Name} Age - {person2.Age}");

            Person person3 = new Person(); // Creating a new instance of the Person class using the default constructor.
            person3.Name = "Alice"; // Setting the name of person3 to "Alice".
            person3.Age = 25; // Setting the age of person3 to 25.
            // Displaying the name and age of person3.
            Console.WriteLine($"Person 3: Name - {person3.Name} Age - {person3.Age}");
          
        }
    }
}
