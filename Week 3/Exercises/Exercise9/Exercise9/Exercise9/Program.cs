/*
 * Download one of the zip files below based on the IDE you're using.
 * Unzip the file somewhere on your computer.
 * Double-click the index file in the Help folder and click the Exercise9 link in the pane on the
 * left; this is the documentation for the classes I provided to you in the Exercise9 solution.
 * Open the Exercise9 solution in your IDE.
 * 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise9
{    
    /// <summary>
    /// Exercise 9 solution 
    /// </summary>
    class Program
    {
        /// <summary>
        /// Demonstrates using custom classes
        /// </summary>
        /// <param name="args">command-line arguments</param>
        static void Main(string[] args)
        {
            /*
             * Problem 1 - Create a deck and tell it to print itself.
             * Declare a deck variable and use the Deck constructor to put a new Deck
             * object into the deck variable.
             * 
             * Tell the deck to print itself. Use the help documentation I provided to figure
             * out which method to use.
             * 
             * Note: The deck prints itself from bottom to top, so the last card listed is at the top of the deck.
             */

            Deck deck = new Deck();

            Console.WriteLine("ORDERED DECK:");
            Console.WriteLine("=============");
            deck.Print();

            Console.WriteLine("");

            /*
             * Problem 2 - Tell the deck to shuffle and print itself.
             * Tell the deck to shuffle itself and print itself. Use the help documentation
             * I provided to figure out which methods to use.
             */

            Console.WriteLine("SHUFFLED DECK:");
            Console.WriteLine("==============");

            deck.Shuffle();
            deck.Print();

            /*
             * Problem 3 - Take two cards from the deck and print their ranks and suits.
             * 
             * Take a card from the top of the deck and print its rank and suit. Use the help
             * documentation I provided to figure out which Deck method to use to get the top
             * card and which Card properties to use to print the rank and suit.
             * 
             * Take another card from the top of the deck and print its rank and suit.
             * 
             * Hint 1: The Card class doesn't expose a Print method, so you have to access
             * a card's properties to print the required information.
             * 
             * Hint 2: You haven't called a method that returns a value yet.
             * Here's a good way to do that for this exercise:
             * 
             * Card card0 = deck.TakeTopCard();
             * 
             * The DeckTakeTopCard method returns a Card object. You need to save that object
             * in a variable so you can access its properties.
             */

            Card card1 = deck.TakeTopCard();
            Console.WriteLine("\nCard 1:");
            Console.WriteLine("Rank: " + card1.Rank + ", Suit: " + card1.Suit);

            Card card2 = deck.TakeTopCard();
            Console.WriteLine("\nCard 2:");
            Console.WriteLine("Rank: " + card2.Rank + ", Suit: " + card2.Suit);

            Console.ReadLine();
        }
    }
}
