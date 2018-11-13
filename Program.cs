using System;
using static System.Console;

namespace Exercise60
{
    public class Program
    {
        private static void Main(string[] args)
        {
            do
            {
                Card.CreateDeck();
                var card = Card.ShuffleCards();

                WriteLine($"Shuffling...you drew a {card.Rank} of {card.Suit}.");

                Write("Would you like to continue? (y/n): ");
            } while (ReadLine().Equals("y", StringComparison.OrdinalIgnoreCase));
        }
    }
}