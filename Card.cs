using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise60
{
    public enum Suit { Spades = 1, Diamonds, Hearts, Clubs }
    public enum Rank { Ace = 1, Two, Three, Four, Five, Six, Seven, Eight, Nine, Ten, Jack, Queen, King }
    class Card
    {
        public Suit Suit { get; set; }
        public Rank Rank { get; set; }

        static List<Card> _deckOfCards = new List<Card>(52);

        public static void CreateDeck()
        {
            _deckOfCards = Enumerable.Range(1, 4)
                .SelectMany(s => Enumerable.Range(1, 13)
                    .Select(c => new Card()
                        {
                            Suit = (Suit)s,
                            Rank = (Rank)c
                        }
                    )
                )
                .ToList();

            _deckOfCards = _deckOfCards.OrderBy(c => Guid.NewGuid()).ToList();
        }

        public static Card DisplayCard()
        {

            var card = _deckOfCards.FirstOrDefault();
            _deckOfCards.Remove(card);

            return card;
        }

    }
}
