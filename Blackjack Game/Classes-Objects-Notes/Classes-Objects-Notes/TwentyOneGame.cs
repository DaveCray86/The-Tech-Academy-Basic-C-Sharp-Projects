using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Objects_Notes
{
    public class TwentyOneGame : Game, IWalkAway              //Class Inheritence 'TwentyOneGame : Game'. Multiple inheritance with interfaces.
    {
        public TwentyOneDealer Deal { get; set; }

        public override void Play()
        {
            Deal = new TwentyOneDealer();
            foreach (Player player in Players)
            {
                player.Hand = new List<Card>();
                player.Stay = false;
            }
            Deal.Hand = new List<Card>();
            Deal.Stay = false;
            Deal.Deck = new Deck();
            Deal.Deck.Shuffle();
            Console.WriteLine("Place your bet.");

            foreach (Player player in Players)
            {
                int bet = Convert.ToInt32(Console.ReadLine());
                bool successfullyBet = player.Bet(bet);
                if (!successfullyBet)
                {
                    return;
                }
                Bets[player] = bet;
            }
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("dealing...");
                foreach (Player player in Players)
                {
                    Console.WriteLine("{0}: ", player.Name);
                    Deal.Deal(player.Hand);
                    if (i == 1)
                    {
                        bool blackJack = TwentyOneRules.CheckForBlackJack(player.Hand);
                        if (blackJack)
                        {
                            Console.WriteLine("BLackjack! {0} wins {1}", player.Name, Bets[player]);
                            player.Balance += Convert.ToInt32((Bets[player] * 1.5) + Bets[player]);
                            return;
                        }
                    }
                }
                Console.Write("Dealer: ");
                Deal.Deal(Deal.Hand);
                if (i == 1)
                {
                    bool blackJack = TwentyOneRules.CheckForBlackJack(Deal.Hand);
                    if (blackJack)
                    {
                        Console.WriteLine("The House wins!");
                        foreach (KeyValuePair<Player, int> entry in Bets)
                        {
                            Deal.Balance += entry.Value;
                        }
                        return;
                    }
                }
            }
            foreach (Player player in Players)
            {
                while (!player.Stay)
                {
                    Console.WriteLine("Your cards are: ");
                    foreach (Card card in player.Hand)
                    {
                        Console.Write("{0} ", card.ToString());
                    }
                    Console.WriteLine("\n\nHit or Stay?");
                    string answer = Console.ReadLine().ToLower();
                    if (answer == "stay")
                    {
                        player.Stay = true;
                        break;
                    }
                    else if (answer == "hit")
                    {
                        Deal.Deal(player.Hand);
                    }
                    bool busted = TwentyOneRules.IsBusted(player.Hand);
                    if (busted)
                    {
                        Deal.Balance += Bets[player];
                        Console.WriteLine("{0} Busted! You lose the bet of {1}. Your remaining balace is {2}. ", player.Name, Bets[player], player.Balance);
                        Console.WriteLine("Would you like to play again? ");
                        answer = Console.ReadLine().ToLower();
                        if (answer == "yes" || answer == "yeah")
                        {
                            player.isActivelyPlaying = true;
                            return;
                        }
                        else
                        {
                            player.isActivelyPlaying = false;
                            return;
                        }
                    }
                }
            }
            Deal.isBusted = TwentyOneRules.IsBusted(Deal.Hand);
            Deal.Stay = TwentyOneRules.ShouldDealerStay(Deal.Hand);
            while (!Deal.Stay && !Deal.isBusted)
            {
                Console.WriteLine("Dealer is hitting...");
                Deal.Deal(Deal.Hand);
                Deal.isBusted = TwentyOneRules.IsBusted(Deal.Hand);
                Deal.Stay = TwentyOneRules.ShouldDealerStay(Deal.Hand);
            }
            if (Deal.Stay)
            {
                Console.WriteLine("Dealer is staying.");
            }
            if (Deal.isBusted)
            {
                Console.WriteLine("Dealer is Busted!");
                foreach (KeyValuePair<Player, int> entry in Bets)
                {
                    Console.WriteLine("{0} won {1}! ", entry.Key.Name, entry.Value);
                    Players.Where(x => x.Name == entry.Key.Name).First().Balance += (entry.Value * 2);
                    Deal.Balance -= entry.Value;
                }
                return;
            }
            foreach (Player player in Players)
            {
                bool? playerWon = TwentyOneRules.CompareHands(player.Hand, Deal.Hand);
                if (playerWon == null)
                {
                    Console.WriteLine("Push! No one wins!");
                    player.Balance += Bets[player];
                }
                else if (playerWon == true)
                {
                    Console.WriteLine("{0} won {1}", player.Name, Bets[player]);
                    player.Balance += (Bets[player] * 2);
                    Deal.Balance -= Bets[player];
                }
                else
                {
                    Console.WriteLine("Dealer wins {0}!", Bets[player]);
                    Deal.Balance += Bets[player];
                }
                Console.WriteLine("Would you like to play again? please answer yes or no.");
                string answer = Console.ReadLine().ToLower();
                if (answer == "yes" || answer == "yeah")
                {
                    player.isActivelyPlaying = true;
                }
                else
                {
                    player.isActivelyPlaying = false;
                }
            }
        }
        public override void ListPlayers()
        {
            Console.WriteLine("Welcome 21 players: ");
            base.ListPlayers();
        }
        public void WalkAway(Player player)
        {
            throw new NotImplementedException();
        }
    }
}
