/*
Problem 3 – Declaring and using variables
Create a new C# Console Application named Exercise3.

 In the Main method, do the following:

   1. Declare a variable named age of type int.
   2. Store your age in this variable.
   3. Print the value of the variable to the user.
*/
using System;
namespace Exercise3 {
    class Program {
        static void Main(string[] args) {
            int age = 22;
            Console.WriteLine("My age is " + age + " years old.");
        }
    }
}