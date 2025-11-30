// DeckOfCards.cs
using System;

namespace CardDeckApp
{
    // Card class
    public class Card
    {
        public string Face { get; set; }
        public string Suit { get; set; }

        public Card(string face, string suit)
        {
            Face = face;
            Suit = suit;
        }

        public override string ToString() => $"{Face} of {Suit}";
    }

    // DeckOfCards class
    public class DeckOfCards
    {
        private static Random randomNumbers = new Random();
        private const int NumberOfCards = 52;
        private Card[] deck = new Card[NumberOfCards];
        private int currentCard = 0;

        // Constructor
        public DeckOfCards()
        {
            string[] faces = { "Ace", "Deuce", "Three", "Four", "Five", "Six",
                               "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King" };
            string[] suits = { "Hearts", "Diamonds", "Clubs", "Spades" };

            for (int count = 0; count < deck.Length; ++count)
            {
                deck[count] = new Card(faces[count % 13], suits[count / 13]);
            }
        }

        // Shuffle the deck
        public void Shuffle()
        {
            currentCard = 0; // reset dealing

            for (int first = 0; first < deck.Length; ++first)
            {
                int second = randomNumbers.Next(NumberOfCards);
                Card temp = deck[first];
                deck[first] = deck[second];
                deck[second] = temp;
            }
        }

        // Deal one card
        public Card DealCard()
        {
            if (currentCard < deck.Length)
            {
                return deck[currentCard++];
            }
            else
            {
                return null; // all cards dealt
            }
        }
    }

    // Test class
    class DeckOfCardsTest
    {
        static void Main()
        {
            DeckOfCards myDeck = new DeckOfCards();
            myDeck.Shuffle();

            for (int i = 0; i < 52; i++)
            {
                Card dealtCard = myDeck.DealCard();
                Console.WriteLine(dealtCard);
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
