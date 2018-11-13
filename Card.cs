using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise60
{
    public enum Suit
    {
        Spades = 1,
        Diamonds,
        Hearts,
        Clubs
    }

    public enum Rank
    {
        Ace = 1,
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King
    }

    internal class Card
    {
        private static List<Card> _deckOfCards = new List<Card>(52);
        public Suit Suit { get; set; }
        public Rank Rank { get; set; }

        public static void CreateDeck()
        {
            _deckOfCards = Enumerable.Range(1, 4).SelectMany(s => Enumerable.Range(1, 13).Select(r => new Card {Suit = (Suit) s, Rank = (Rank) r})).ToList();


        }

        public static Card ShuffleCards()
        {
            _deckOfCards = _deckOfCards.OrderBy(c => Guid.NewGuid()).ToList();

            var card = _deckOfCards.FirstOrDefault();
            _deckOfCards.Remove(card);

            return card;
        }
    }
}