using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace WarMegaChallenge
{
    public class Deck
    {
        // List
        private List<Card> _deck;
        private Random _random;
        private StringBuilder _sb;

        // Constructor for deck
        public Deck()
        {
            _deck = new List<Card>();
            _random = new Random();
            _sb = new StringBuilder();

            // Suits and card value (Type)
            string[] suits = new string[] { "Diamonds", "Hearts", "Clubs", "Spades" };
            string[] types = new string[] { "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King", "Ace" };

            // Adding a suit to a card value (type) so there is 1 of each
            foreach (var suit in suits)
            {
                foreach (var type in types)
                {
                    _deck.Add(new Card { Suit = suit, Type = type });
                }
            }
        }

        // Method to show what players have which cards
        public string Deal(Player player1, Player player2)
        {
            while (_deck.Count > 0)
            {
              
                dealCard(player1);
                dealCard(player2);
            }
            return _sb.ToString();
        }

        // Print cards "dealt" w/type and suit w/o repeats
        private void dealCard(Player player)
        {
            Card card = _deck.ElementAt(_random.Next(_deck.Count));
            player.Cards.Add(card);
            _deck.Remove(card);

            _sb.Append("<br/>");
            _sb.Append(player.Name);
            _sb.Append(" card: ");
            _sb.Append(card.Type);
            _sb.Append(" of ");
            _sb.Append(card.Suit);
        }


    }
}