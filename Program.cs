using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise60
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Card.CreateDeck();
                Card card = Card.DisplayCard();

                Console.WriteLine($"Shuffling...you drew a {card.Rank} of {card.Suit}.");

                Console.Write("Would you like to continue? (y/n): ");
            } while (Console.ReadLine().Equals("y", StringComparison.OrdinalIgnoreCase));

        }
    }
}
