using System;

namespace Basics
{
  class Program
  {
    static void Main(string[] args)
    {

      // To output values or print text in C#, you can use the WriteLine() method
      Console.WriteLine("Hello World!");    
      Console.WriteLine("This is C#");

      // You can also output numbers then perform mathematical calculations
      Console.WriteLine(5 + 2);

      // There is also a Write() method, which is similar to WriteLine(). 
      // The only difference is that it does not insert a new line at the end of the output
      Console.Write("First Sentence! ");
      Console.Write("I will print on the same line.");

      // This is a Single-Line comment
    
      /* This is Multi-Line Commnet. Multi-line comments are used to enclose large blocks of text or multiple lines of code
         that you want the compiler to ignore during execution */

      
      // VARIABLES

      string name = "John";
      int myNum = 4;
      double salary = 5.99D; // You can use the letter D to indicate that the number is of type double
      char myLetter = 'F';
      bool isReal = true;

      // CONSTANTS
      
      //This will declare the variable as "constant", which means unchangeable and read-only
      const int myNum = 4;
      myNum = 20; // This will cause an error

      // To combine both text and a variable, use the + character
      string yourName = "Brad";
      Console.Writeline("Your name is " + yourName);
      
      string firstName = "John ";
      string lastName = "Doe";
      string fullName = firstName + lastName;
      Console.Writeline(fullName);

      // To declare more than one variable of the same type, just use a comma
      int x = 12, y = 34, z = 79;
      Console.WriteLine(x + y + z);
      // You can also assign the same value to multiple variables in one line
      int x, y, z;
      x = y = z = 10;
      Console.WriteLine(x + y + z); // 30

      // You should always give your variables meaningful names
      

      // User Input
      // Use Console.ReadLine() to get user input
      Console.Write("Enter your name:");
      string yourName = Console.ReadLine();
      Console.WriteLine("Your name is: " + yourName);
      
      // User Input and Numbers
      Console.Write("Enter your age: ");
      int age = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Your age is: " + age);

      // Concatenation and Interpolation
      // The + operator can be used between strings to combine them. This is called concatenation
      string firstName2 = "John ";
      string lastName2 = "Doe";
      string name = firstName2 + lastName2;
      Console.WriteLine(name);

      // String interpolation substitutes values of variables into placeholders in a string.
      string firstName3 = "John";
      string lastName3 = "Doe";
      string name2 = $"My full name is: {firstName2} {lastName2}";
      Console.WriteLine(name2);

      
      // If...Else
      if (23 > 15) 
      {
        Console.WriteLine("23 is greater than 15"); // If 20 is greater than 18, this line will run
      } else{
        Console.WriteLine("23 is less than 15"); // Else this line will run instead
      }

      // Else if
      // Use the else if statement to specify a new condition if the first condition is False
      int age = 22;
      if (time < 18) 
      {
        Console.WriteLine("You are not allowed.");
      } 
      else if (time < 21) 
      {
        Console.WriteLine("Allowed but with parents.");
      } 
      else 
      {
        Console.WriteLine("You are allowed.");
      }

      // Loops

      // While Loop
      // The while loop loops through a block of code as long as a specified condition is True
      int i = 0;
      while (i < 5) 
      {
        Console.Write(i); // 01234
        i++;
      }
      
      // For Loop
      // When you know exactly how many times you want to loop through a block of code, use the for loop instead of while loop
      for (int i = 0; i < 5; i++) 
      {
        Console.Write(i); // 01234
      }

      // Use the switch statement to select one of many code blocks to be executed.
      int dayToday = 5;
      switch (dayToday) 
      {
        case 1:
          Console.WriteLine("Monday");
          break; // When C# reaches a break keyword, it breaks out of the switch block.
        case 2:
          Console.WriteLine("Tuesday");
          break;
        case 3:
          Console.WriteLine("Wednesday");
          break;
        case 4:
          Console.WriteLine("Thursday");
          break;
        case 5:
          Console.WriteLine("Friday");
          break;
        case 6:
          Console.WriteLine("Saturday");
          break;
        case 7:
          Console.WriteLine("Sunday");
          break;
      }

      // The break statement can also be used to jump out of a loop
      // Example in a for loop
      for (int i = 0; i < 10; i++) 
      {
        if (i == 4) // if condition is met
        {
          break; // this line will run and stop the loop
        }
        Console.WriteLine(i);
      }

      /* The continue statement breaks one iteration in the loop, if some condition is met,
         then it continues with the next iteration in the loop */ 
      for (int i = 0; i < 10; i++) 
      {
        if (i == 4) // if condition is met
        {
          continue; // this line will run
        }
        Console.WriteLine(i); // then this skips the printing and continue to the next iteration
      }

      // Method / Function
      // A method is a block of code which only runs when it is called.
      MyMethod(); // Calling a method.

      // You can pass data, known as parameters, into a method.
      // Information can be passed to methods as parameter. Parameters act as variables inside the method
      MyMethodTwo("John"); // Calling a method with a parameter
      
      // Multiple parameters
      MyMethodThree("John", 21); // Calling a method with multiple parameters

      // Return Values
      // Void keyword indicates that the method should not return a value.
      /*
        If you want the method to return a value, you can use a primitive data type (such as int or double) instead of void, 
        and use the return keyword inside the method
      */
      Console.WriteLine(MyMethodFour(3)); // Calling the method that returns a value
      
    }
    
    // Methods
    static void MyMethod() 
    {
      Console.WriteLine("I just got executed!");
    }
    static void MyMethodTwo(string fname) 
    {
      Console.WriteLine(fname + " Refsnes");
    }
    static void MyMethodThree(string fname, int age) 
    {
      Console.WriteLine(fname + " is " + age);
    }

    // This returns an int value
    static int MyMethodFour(int x) 
    {
      return 5 + x;
    }
    
  }
}
