/*
 * Double-click the index file in the Help folder and click the Exercise8 link
 * in the pane on the left; this is the documentation for the Die class
 * I provided to you in the Exercise8 solution. 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise8
{
    /// <summary>
    /// Exercise 8 solution
    /// </summary>
    class Program
    {
        /// <summary>
        /// Demonstrates rolling and using two dice
        /// </summary>
        /// <param name="args">command-line arguments</param>
        static void Main(string[] args)
        {
            // initialize random number generator
            RandomNumberGenerator.Initialize();

            /*
             * Problem 1 - Create two dice.
             * Declare die1 and die2 variables and use the appropriate Die constructor
             * to put new six-sided Die objects into those variables.
             * Use the help documentation I provided to figure out which constructor to use.
             */

            Die die1, die2;
            int sumTopSides;

            die1 = new Die();
            die2 = new Die();


            /*
             * Problem 2 - Tell the dice to roll themselves.
             * 
             * Tell the die1 and die2 variables to roll themselves. Use the
             * help documentation I provided to figure out which method to use.
             * 
             * Side note: The solution I gave you includes a RandomNumberGenerator class
             * that's initialized in the Main method and used by the Die class when a die
             * rolls itself. It's pretty common to have a random number generator that's
             * used by the whole "game".
             */

            die1.Roll();
            die2.Roll();

            /*
             * Problem 3 - Print the top sides of the two dice and print their sum.
             * Print the top sides of the two dice. Use the help documentation
             * I provided to figure out which property to use.
             * Print the sum of the top sides of the two dice.
             * Hint: It's easiest to declare a variable that holds the sum of the
             * top sides of the two dice, then print that sum.
             */

            Console.WriteLine("Top side of 1st die: " + die1.TopSide);
            Console.WriteLine("Top side of 2nd die: " + die2.TopSide);

            sumTopSides = die1.TopSide + die2.TopSide;

            Console.WriteLine("Sum of the top sides of the dies: " + sumTopSides);

            Console.ReadLine();
        }
    }
}
