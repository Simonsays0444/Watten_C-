using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WattenForms
{
    public class Card
    {
        public string Name { get; private set; }
        public string Rank { get; private set; }
        public string Suit { get; private set; }
        public int Value { get; set; }
        
        public Card(string suit, string rank)
        {
            Rank = rank;
            Suit = suit;
            Name = (rank + " " + suit);
        }
    }
}
