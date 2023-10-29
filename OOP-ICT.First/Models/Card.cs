namespace OOP_ICT.Models;

public class Card
{
    public Suit Suit { get; }
    public Value Value { get; }

    public Card(Suit suit, Value value)
    {
        Suit = suit;
        Value = value;
    }
    public override bool Equals(object obj)
    {
        if (obj == null || GetType() != obj.GetType())
        {
            return false;
        }

        Card otherCard = (Card)obj;
        return Suit == otherCard.Suit && Value == otherCard.Value;
    }
    
}