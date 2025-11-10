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


        public List<Card> GetPossibleCards(Card card1, Card card2, bool isPlayer1LastWinner)
        {
            List<Card> PossibleCards = new List<Card>();
            Card firstCard;

            if (isPlayer1LastWinner)
            {
                firstCard = card1;
            } else
            {
                firstCard = card2;
            }

            if (firstCard == null)
            {
                return PlayerCards;
            } 
            else
            {
                if (firstCard.Value >= 20)
                {
                    foreach (Card card in PlayerCards)
                    {
                        if (card.Value >= 20)
                        {
                            PossibleCards.Add(card);
                        }
                    }
                }
                if (PossibleCards.Count == 0)
                {
                    PossibleCards = PlayerCards;
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

        public virtual Card ChooseCard(List<Card> PossibleCards)
        {
            return PossibleCards.FirstOrDefault();
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

    public class BotEasy : Player
    {
        public BotEasy()
        {
            Init();
            PlayerType = PlayerType.Bot;    
        }

        public override Card ChooseCard(List<Card> PossibleCards)
        {
            return base.ChooseCard(PossibleCards);
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


    public class BotMedium : Player
    {
        public BotMedium()
        {
            Init();
            PlayerType = PlayerType.Bot;
        }

        public override Card ChooseCard(List<Card> PossibleCards)
        {
            return base.ChooseCard(PossibleCards);
        }

        public override string ChooseRank()
        {
            string ChoosenRank = PlayerCards.GroupBy(k => k.Rank).OrderByDescending(g => g.Count()).First().Key.ToString();
            return ChoosenRank;
        }

        public override string ChooseSuit()
        {
            string ChoosenSuit = PlayerCards.GroupBy(k => k.Suit).OrderByDescending(g => g.Count()).First().Key.ToString();
            return ChoosenSuit;
        }
    }
}
