/*
Problem 4 – Calculating with integers
Create a new C# Console Application named Exercise4.

In the Main method, do the following:

  1. Prompt for and get the altitude for a location as an int.
  2. Prompt for and get the altitude for a second location as an int.
  3. Calculate and display the altitude change you'd experience moving from the first point to the second point.
 
Hint: The order of the subtraction matters, so make sure you're getting the correct sign on your answer.
*/
using System;
namespace Exercise4 {
    class Program {
        static void Main(string[] args) {
            int altitude1, altitude2;
            
            Console.Write("Enter first altitude: ");
            altitude1 = int.Parse(Console.ReadLine());

            Console.Write("Enter second altitude: ");
            altitude2 = int.Parse(Console.ReadLine());

            Console.WriteLine("The altitude change moving from the first point to the second one will be: "+(altitude2-altitude1));
        }
    }
}