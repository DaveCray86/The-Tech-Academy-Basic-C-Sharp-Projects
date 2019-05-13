using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Objects_Notes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello player. Please enter a player alias: ");
            string playerName = Console.ReadLine();

            Console.WriteLine("How many credits did you bring for the day?");
            int bank = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hello, {0}. Would you like to join a game of 21? ", playerName);
            string answer = Console.ReadLine().ToLower();

            if (answer == "yes" || answer == "yeah" || answer == "y" || answer == "ya")
            {
                Player player = new Player(playerName, bank);                           //player object instantiated.
                Game game = new TwentyOneGame();
                game += player;                                         //Adding player to the game.
                player.isActivelyPlaying = true;

                while (player.isActivelyPlaying && player.Balance > 0)
                {
                    game.Play();
                }
                game -= player;
                Console.WriteLine("Thank you for playing.");
            }

            Console.WriteLine("Feel free to come back later.");
            Console.ReadLine();
            
            //------------------------------------------------------------------------------------------------------------

            //Deck deck = new Deck();
            //deck.Shuffle(3);                         //Calling the 'Shuffle' method from the deck class.

            //foreach (Card card in deck.Cards)
            //{
            //    Console.WriteLine(card.Face + " of " + card.Suit);
            //}
            //Console.WriteLine(deck.Cards.Count);
            //Console.ReadLine();

            //----------------------------------------------------------------------------------------------------------
            //Lambda Functions: Hard to debug, can also be hard to read if chaining together too many Lambda Functs.

            //Deck deck = new Deck();
            //List<int> numberList = new List<int>() { 1, 2, 3, 535, 324, 19};
            //int sum = numberList.Sum(x => x + 10);                            //Takes all numbers added ,+ 10.
            //int sum = numberList.Max();                                       //Largest num in list.
            //int sum = numberList.Min();                                       //Lowest num in list.
            //int sum = numberList.Where(x => x > 20).Sum();                    //Adds together all nums greater than 20 in the list and prints.

            //Console.WriteLine(sum);
            //Console.ReadLine();


            //Deck deck = new Deck();
            //int count = deck.Cards.Count(x => x.Face == Face.Ace);          //Lambda funct. 'x = the deck' 'x.Face == Face.Ace' is telling it to pull all face cards that are 'Ace'. x represents each element in the list.
            //Console.WriteLine(count);                                       // 4 aces in the deck, telling it to pull and print how many 'Aces' are in the deck.
            //Console.ReadLine();

            //Deck deck = new Deck();
            //List<Card> newList = deck.Cards.Where(x => x.Face == Face.King).ToList();       //Filtering a list witha Lambda funct.

            //foreach (Card card in newList)
            //{
            //    Console.WriteLine(card.Face);
            //}
            //Console.ReadLine();


            //--------------------------------------------------------------------------------------------------------
            //Deck deck = new Deck();                             //This function will count all object that are 'Ace' in the deck. Equals 4.
            //int counter = 0;
            //foreach (Card card in deck.Cards)
            //{
            //    if (card.Face == Face.Ace)
            //    {
            //        counter++;
            //    }
            //}
            //Console.WriteLine(counter);
            //Console.ReadLine();
            //--------------------------------------------------------------------------------------------------------



            //TwentyOneGame game = new TwentyOneGame();
            //game.Players = new List<string>() { "Bill", "Bob", "Jessie", "Steve" };
            //game.ListPlayers();
            //Console.ReadLine();


            //List<Game> Games = new List<Game>();                //Polymorphism: the ability of a class to 'morph' into its inheriting class.
            //TwentyOneGame game = new TwentyOneGame();
            //Games.Add(game);

            //Game game = new TwentyOneGame();
            //game.Players = new List<Player>();
            //Player player = new Player();
            //player.Name = "David";
            //game += player;
            //game -= player;



            //Player<Card> player = new Player<Card>();

            //Card card = new Card();
            //card.Suit = Suit.Clubs;
            //int underlyingvalue = (int)Suit.Diamonds;           //Casting a string to an integer.
            //Console.WriteLine(underlyingvalue);


            //Card card1 = new Card();                             //Reference types.
            //Card card2 = card1;
            //card1.Face = Face.Eight;
            //card2.Face = Face.King;

            //Console.WriteLine(card1.Face);

            //----------------------------------------------------------------------------------------------------------
        }
    }
}
