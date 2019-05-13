using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Objects_Notes
{
    public struct Card                            // Public sets it so this set of code can be used with our main program.
    {
        public Suit Suit { get; set; }         // The Card Class, has a property of data type string called suit. You can 'get' or 'set' this property.
        public Face Face { get; set; }         // A class is a model/design for an object in OOP.

        public override string ToString()
        {
            return string.Format("{0} of {1}", Face, Suit);
        }
    }
    public enum Suit
    {
        Clubs,
        Diamonds,
        Hearts,
        Spades
    }
    public enum Face
    {
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
        King,
        Ace
    }
    //public static Deck Shuffle(Deck deck)   //Method
    //{
    //    List<Card> TempList = new List<Card>();
    //    Random random = new Random();

    //    while (deck.Cards.Count > 0)
    //    {
    //        int randomIndex = random.Next(0, deck.Cards.Count);
    //        TempList.Add(deck.Cards[randomIndex]);
    //        deck.Cards.RemoveAt(randomIndex);
    //    }
    //    deck.Cards = TempList;
    //    return deck;
    //}
}
