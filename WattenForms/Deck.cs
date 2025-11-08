using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WattenForms
{
    public class Deck
    {
        private static Random rnd = new Random();
        public string[] suits = { "Eichel", "Blatt", "Herz", "Schellen" };
        public string[] ranks = { "7", "8", "9", "10", "Unter", "Ober", "König", "Ass" };

        public Deck()
        {
            Cards = new Card[suits.Length * ranks.Length];
            GenerateCardsInDeck();
            Shuffle();
        }

        public Card[] Cards { get; set; }

        public void GenerateCardsInDeck()
        {
            int i = 0;
            foreach(string suit in suits)
            {
                foreach (string rank in ranks)
                {
                    Card card = new Card(suit, rank);
                    Cards[i] = card;
                    i++;
                }
            }
        }

        public void Shuffle()
        {
            for (int i = Cards.Length - 1; i > 0; i--)
            {
                int j = rnd.Next(i + 1);
                Card temp = Cards[i];
                Cards[i] = Cards[j];
                Cards[j] = temp;
            }
        }

    }
}
