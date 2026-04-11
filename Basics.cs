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

      // You should always name your variable in a meaningful way
      
    }
  }
}
