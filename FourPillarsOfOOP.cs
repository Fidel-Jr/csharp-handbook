using System;

namespace OOP
{

    /*
        1. Encapsulation (Data Hiding)

        Encapsulation means wrapping data and methods together in a class and restricting direct access to some data.
    */
    public class BankAccount // Encapsulation example
    {
        private double balance;   // hidden field

        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                balance += amount;
            }
        }

        public double GetBalance()
        {
            return balance;
        }
    };

    /*
        2. Inheritance (Reuse Code)

        Inheritance allows one class to reuse properties and methods of another class.
        It creates a parent-child relationship. 
    */
    public class Animal // Base class (parent class)
    {
        public void Eat()
        {
            Console.WriteLine("Animal is eating");
        }
    }

    public class Dog : Animal //  Child class (derived class) that inherits from the base class (parent class)
    {
        public void Bark()
        {
            Console.WriteLine("Dog is barking");
        }
    }

    /* 
        3. Abstraction(Hide Complexity) - Abstraction uses Inheritance but not all inheritance is abstraction.

        Abstraction means showing only necessary details and hiding internal implementation.
        Users only see what the object does, not how it does it.    
    */

    public abstract class Shape // Abstraction example
    {
        public abstract double CalculateArea();
    }

    public class Circle : Shape // Derived class that implements the abstract method from the base class
    {
        public double Radius { get; set; }

        public override double CalculateArea()
        {
            return 3.14 * Radius * Radius;
        }
    }


    /*
        4. Polymorphism (Many Forms)    
    
        Polymorphism means one method can behave differently depending on the object.

        There are two types:
        1️ Compile-time Polymorphism (Method Overloading) - Same method name but different parameters.
        2 Runtime Polymorphism (Method Overriding) - Child class changes behavior of parent method.

    */

    // Compile-time Polymorphism (Method Overloading) example
    public class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public double Add(double a, double b)
        {
            return a + b;
        }
    }

    // Runtime Polymorphism (Method Overriding) example
    public class AnimalTwo
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("Animal sound");
        }
    }

    public class Cat : AnimalTwo
    {
        public override void MakeSound()
        {
            Console.WriteLine("Cat meows");
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            // --- Encapsulation example
            Console.WriteLine(" ---- Encapsulation Example ----");
            BankAccount account = new BankAccount();
            account.Deposit(1000);

            Console.WriteLine(account.GetBalance());
            Console.WriteLine();

            // --- Inheritance example
            Console.WriteLine(" ---- Inheritance Example ----");
            Dog dog = new Dog();

            dog.Eat();   // inherited
            dog.Bark();  // own method
            Console.WriteLine();

            // --- Abstraction example
            Console.WriteLine(" ---- Abstraction Example ----");
            Circle circle = new Circle();
            circle.Radius = 5;

            Console.WriteLine(circle.CalculateArea()); // User only calls: CalculateArea(), not how it is implemented
            Console.WriteLine();

            // --- Polymorphism example
            Console.WriteLine(" ---- Polymorphism Example ----");

            // Compile-time Polymorphism (Method Overloading)
            Calculator calc = new Calculator();

            Console.WriteLine(calc.Add(5, 3));      // int version
            Console.WriteLine(calc.Add(2.5, 3.5));  // double version


            // Runtime Polymorphism (Method Overriding)
            AnimalTwo animal = new Cat(); // Even though type is Animal, the Cat implementation runs.
            animal.MakeSound(); // Calls the overridden method in Cat, not the base method in AnimalTwo

        }
    }

}
