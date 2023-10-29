namespace OOP_ICT.Models;

public class CardDeck
{
    private List<Card> _cards { get; }

    public List<Card> GetCards()
    {
        return _cards;
    }

    public CardDeck(List<Card> listOfCards)
    {
        if (listOfCards.Count == 0)
        {
            throw new InvalidOperationException();
        }

        _cards = listOfCards;
    }

    public CardDeck()
    {
        _cards = new List<Card>();

        var suits = Enum.GetValues(typeof(Suit)).Cast<Suit>();
        var values = Enum.GetValues(typeof(Value)).Cast<Value>();

        _cards.AddRange(
            from suit in suits
            from value in values
            select new Card(suit, value)
        );
    }
}