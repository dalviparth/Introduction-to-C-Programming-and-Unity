/*
Problem – Trigonometry with floats
Create a new C# Console Application named Exercise6.

In the Main method, do the following:

  1. Prompt for and get an angle in degrees and store it in a float variable.
  2. Calculate and display the cosine and sine of the angle.

Hint 1: The Math class is very useful for this, so you should look at the documentation for that class; you can find that documentation at https://msdn.microsoft.com/en-us/library/system.math(v=vs.110).aspx
Hint 2: As you read the documentation for the methods that calculate cosine and sine, you'll discover that they expect you to provide an angle in radians, not degrees. To convert the angle from degrees to radians, you can simply multiply the angle by "(float)Math.PI/180". Because Math.PI is a double, we need a type cast for this conversion.

Suggested Test Case: If you enter 90 for the angle, the cosine should be approximately 0 and the sine should be approximately 1. These aren't exact because we get a little rounding error (because 2^b = n!)
*/
using System;
namespace Exercise6 {
    class Program {
        static void Main(string[] args) {
            float angle;

            Console.Write("Enter the angle: ");
            angle = float.Parse(Console.ReadLine());

            angle = angle*((float)Math.PI/180);

            Console.WriteLine("Its sine is: "+Math.Sin(angle));
            Console.WriteLine("Its cosine is: "+Math.Cos(angle));
        }
    }
}