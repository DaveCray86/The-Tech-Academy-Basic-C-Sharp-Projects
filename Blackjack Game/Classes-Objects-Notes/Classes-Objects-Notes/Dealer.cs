using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Objects_Notes
{
    public class Dealer
    {
        public string Name { get; set; }
        public Deck Deck { get; set; }                                          //Inheritance is an 'is a' relationship.
        public int Balance { get; set; }                                        //21 game 'is a' game, where a Dealer 'has a' deck. A dealer is not a 21 game, but 'has a' deck.

                                                                                //21 game does not 'have a' game, it 'is a' 21 game. If unclear, just add as a property.

        public void Deal(List<Card> Hand)
        {
            Hand.Add(Deck.Cards.First());                                       //Adds first card off deck to dealers hand
            Console.WriteLine(Deck.Cards.First().ToString() + "\n");            //Prints card
            Deck.Cards.RemoveAt(0);                                             //Removes card from deck
        }
    }
}
