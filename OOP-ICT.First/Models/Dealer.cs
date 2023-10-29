using System.Net.Sockets;

namespace OOP_ICT.Models;

public class Dealer
{
    private CardDeck _deck;

    public Dealer()
    {
        _deck = new CardDeck();
    }

    public CardDeck Deck
    {
        get { return _deck; }
    }

    public CardDeck SuffleDeck()
    {
        List<Card> shuffleDeck = new List<Card>(_deck.GetCards());
        List<Card> firstHalf = shuffleDeck.GetRange(0, shuffleDeck.Count / 2);
        List<Card> secondHalf = shuffleDeck.GetRange(shuffleDeck.Count / 2, shuffleDeck.Count / 2);

        List<Card> result = new List<Card>();

        int i = 0;
        while (i < shuffleDeck.Count / 2)
        {
            result.Add(firstHalf[i]);
            result.Add(secondHalf[i]);
            i++;
        }

        return new CardDeck(result);
    }
}