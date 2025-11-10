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

        public string PlayerName { get; set; }


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

        public virtual Card ChooseCard(List<Card> PossibleCards, Card otherCard, bool isPlayer1LastWinner)
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
            PlayerName = "Easy_Bot";
        }

        public override Card ChooseCard(List<Card> PossibleCards, Card otherCard, bool isPlayer1LastWinner)
        {
            return base.ChooseCard(PossibleCards, otherCard, isPlayer1LastWinner);
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
            PlayerName = "Medium_Bot";
        }

        public override Card ChooseCard(List<Card> PossibleCards, Card otherCard, bool isPlayer1LastWinner)
        {
            List<Card> winningCards = new List<Card>();
            Card choosenCard;

            foreach (Card card in PossibleCards)
            {
                if (WhoIsTheWinner.GetWinner(card, otherCard, isPlayer1LastWinner))
                {
                    winningCards.Add(card);
                }
            }
            if (winningCards.Count > 0)
            {
                choosenCard = winningCards.FirstOrDefault();
            }
            else
            {
                choosenCard = PossibleCards.FirstOrDefault();
            }
            return choosenCard;
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

    public class BotHard : Player
    {
        public BotHard()
        {
            Init();
            PlayerType = PlayerType.Bot;
            PlayerName = "Hard_Bot";
        }

        public override Card ChooseCard(List<Card> PossibleCards, Card otherCard, bool isPlayer1LastWinner)
        {
            List<Card> winningCards = new List<Card>();
            Card choosenCard;

            foreach (Card card in PossibleCards)
            {
                if (WhoIsTheWinner.GetWinner(card, otherCard, isPlayer1LastWinner))
                {
                    winningCards.Add(card);
                }
            }

            Card cheapestWinningCard = winningCards.FirstOrDefault();

            foreach (Card card in winningCards)
            {
                if (card.Value < cheapestWinningCard.Value)
                {
                    cheapestWinningCard = card;
                }
            }


            if (winningCards.Count > 0)
            {
                choosenCard = cheapestWinningCard;
            }
            else
            {
                Card cheapestCard = PossibleCards.FirstOrDefault();

                foreach(Card card in PossibleCards)
                {
                    if (card.Value < cheapestCard.Value)
                    {
                        cheapestCard = card;
                    }
                }
                choosenCard = cheapestCard;
            }
            return choosenCard;
        }

        public override string ChooseRank()
        {
            List<Card> NoKritCards = new List<Card>();
            foreach (Card card in PlayerCards)
            {
                if (card.Name != "König Herz" && card.Name != "7 Schellen" && card.Name != "7 Eichel")
                {
                    NoKritCards.Add(card);
                }
            }


            string ChoosenRank = NoKritCards.GroupBy(k => k.Rank).OrderByDescending(g => g.Count()).First().Key.ToString();
            return ChoosenRank;
        }

        public override string ChooseSuit()
        {
            List<Card> NoKritCards = new List<Card>();
            foreach (Card card in PlayerCards)
            {
                if (card.Name != "König Herz" && card.Name != "7 Schellen" && card.Name != "7 Eichel")
                {
                    NoKritCards.Add(card);
                }
            }

            string ChoosenSuit = NoKritCards.GroupBy(k => k.Suit).OrderByDescending(g => g.Count()).First().Key.ToString();
            return ChoosenSuit;
        }
    }


    public class ChatGpt : Player
    {
        public ChatGpt()
        {
            Init();
            PlayerType = PlayerType.Bot;
            PlayerName = "ChatGpt_Bot";
        }

        public override Card ChooseCard(List<Card> possibleCards, Card otherCard, bool isPlayer1LastWinner)
        {
            bool iAmLeading = otherCard == null;
            bool needToClose = this.WinCount == 2;

            var scoredCards = possibleCards.Select(c => new
            {
                Card = c,
                Score = EvaluateCard(c, otherCard, isPlayer1LastWinner, iAmLeading, needToClose)
            }).OrderByDescending(x => x.Score).ToList();

            return scoredCards.First().Card;
        }

        private double EvaluateCard(Card card, Card otherCard, bool isPlayer1LastWinner, bool iAmLeading, bool needToClose)
        {
            double score = 0;
            bool wouldWin = GetTheoreticalWinner(card, otherCard, isPlayer1LastWinner);
            bool isTrump = card.Value > 20;
            bool isHigh = card.Value >= 30;

            score += card.Value;

            if (iAmLeading)
            {
                if (isTrump && !isHigh) score += 10;
                if (isHigh) score -= 2;
            }
            else
            {
                if (wouldWin) score += 20;
                else score -= 10;
            }

            if (needToClose)
            {
                if (wouldWin) score += 25;
                else score -= 5;
            }

            if (otherCard != null && card.Suit == otherCard.Suit) score += 3;
            if (isTrump && !needToClose) score -= 3;

            return score;
        }

        public override string ChooseRank()
        {
            if (PlayerCards.Count == 0) return base.ChooseRank();

            return PlayerCards
                .GroupBy(c => c.Rank)
                .OrderByDescending(g => g.Sum(x => x.Value))
                .ThenByDescending(g => g.Count())
                .First().Key;
        }

        public override string ChooseSuit()
        {
            if (PlayerCards.Count == 0) return base.ChooseSuit();

            return PlayerCards
                .GroupBy(c => c.Suit)
                .OrderByDescending(g => g.Sum(x => x.Value))
                .ThenByDescending(g => g.Count())
                .First().Key;
        }

        private static bool GetTheoreticalWinner(Card card, Card otherCard, bool isPlayer1LastWinner)
        {
            if (card == null) return false;
            if (otherCard == null) return true;

            if (card.Value > 20 || otherCard.Value > 20 || card.Suit == otherCard.Suit)
            {
                if (card.Value > otherCard.Value) return true;
                if (otherCard.Value > card.Value) return false;
                return isPlayer1LastWinner;
            }

            return isPlayer1LastWinner;
        }
    }
}
