using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WattenForms
{
    public class Player
    {
        public int WinCount { get; set; }
        public List<Card> PlayerCards { get; set; }
        public PlayerType PlayerType { get; set; }


        public List<Card> GetPossibleCards(Card card)
        {
            List<Card> PossibleCards = new List<Card>();
            
            if (card == null || card.Value < 20)
            {
                return PlayerCards;
            } 
            else
            {
                foreach (Card c in PlayerCards)
                {
                    PossibleCards.Add(c);
                }
                return PossibleCards;
            }
        }

        public virtual string ChooseRank()
        {
            return PlayerCards.FirstOrDefault().Rank;
        }

        public virtual string ChooseSuit()
        {
            return PlayerCards.FirstOrDefault().Suit;
        }

        public virtual string ChooseCard()
        {
            return PlayerCards.FirstOrDefault().Name;
        }

        public Player()
        {
            Init();
            PlayerType = PlayerType.Human;
        }

        protected void Init()
        {
            PlayerCards = new List<Card>();
            WinCount = 0;
        }
    }

    public class Bot : Player
    {
        public Bot()
        {
            Init();
            PlayerType = PlayerType.Bot;    
        }

        public override string ChooseCard()
        {
            return base.ChooseCard();
        }

        public override string ChooseRank()
        {
            return base.ChooseRank();
        }

        public override string ChooseSuit()
        {
            return base.ChooseSuit();
        }
    }
}
