// Fig. 8.11: DeckOfCards.cs
// DeckOfCards class represents a deck of playing cards.
using System;

class Card
{
    public string Face { get; }
    public string Suit { get; }

    public Card(string face, string suit)
    {
        Face = face;
        Suit = suit;
    }

    // Kartın okunabilir şekilde yazdırılması
    public override string ToString() => $"{Face} of {Suit}";
}

class DeckOfCards
{
    // Rastgele karıştırma için tek Random nesnesi
    private static Random randomNumbers = new Random();

    private const int NumberOfCards = 52; // kart sayısı
    private Card[] deck = new Card[NumberOfCards];
    private int currentCard = 0; // sıradaki kartın dizin numarası

    // Kurucu metot (deck dizisini kartlarla doldurur)
    public DeckOfCards()
    {
        string[] faces = { "Ace", "Deuce", "Three", "Four", "Five", "Six",
                           "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King" };

        string[] suits = { "Hearts", "Diamonds", "Clubs", "Spades" };

        // 52 kart oluşturuluyor
        for (var count = 0; count < deck.Length; ++count)
        {
            deck[count] = new Card(faces[count % 13], suits[count / 13]);
        }
    }

    // Deste karıştırma metodu
    public void Shuffle()
    {
        // karıştırmadan sonra ilk karttan başlanır
        currentCard = 0;

        // her kart için rastgele bir başka kart seçilir ve yerleri değiştirilir
        for (var first = 0; first < deck.Length; ++first)
        {
            var second = randomNumbers.Next(NumberOfCards);

            // swap işlemi
            Card temp = deck[first];
            deck[first] = deck[second];
            deck[second] = temp;
        }
    }

    // sıradaki kartı dağıt
    public Card DealCard()
    {
        if (currentCard < deck.Length)
        {
            return deck[currentCard++]; // sıradaki kartı döndür
        }
        else
        {
            return null; // tüm kartlar dağıtıldı
        }
    }
}

// Test programı
class Program
{
    static void Main()
    {
        DeckOfCards deck = new DeckOfCards();
        deck.Shuffle();

        // 52 kartı dağıt
        for (int i = 0; i < 52; i++)
        {
            Console.Write($"{deck.DealCard(),-19}");
            if ((i + 1) % 4 == 0)
                Console.WriteLine();
        }
    }
}
