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
            }
            else
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

            //Card cheapestWinningCard = winningCards.OrderByDescending(c => c.Value).FirstOrDefault();
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

                foreach (Card card in PossibleCards)
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


    public class BotSimon : Player
    {
        public BotSimon()
        {
            Init();
            PlayerType = PlayerType.Bot;
            PlayerName = "Hard_Bot";
        }

        public override string ChooseRank()
        {
            List<Card> NoKritCards = PlayerCards
                .Where(c => c.Name != "König Herz" && c.Name != "7 Schellen" && c.Name != "7 Eichel")
                .ToList();

            var rankOrder = new List<string> { "7", "8", "9", "10", "Unter", "Ober", "König", "Ass" };

            var groupedRanks = NoKritCards
                .GroupBy(k => k.Rank)
                .Select(g => new { Rank = g.Key, Count = g.Count() })
                .ToList();

            int maxCount = groupedRanks.Max(g => g.Count);

            var mostCommonRanks = groupedRanks
                .Where(g => g.Count == maxCount)
                .Select(g => g.Rank)
                .ToList();

            // jetzt kleinster Rank basierend auf unserer Reihenfolge
            string chosenRank = mostCommonRanks
                .OrderBy(r => rankOrder.IndexOf(r))
                .First();

            return chosenRank;
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

        public override Card ChooseCard(List<Card> PossibleCards, Card otherCard, bool isPlayer1LastWinner)
        {
            List<Card> winningCards = new List<Card>();
            Card choosenCard;
            List<Card> noTrump = new List<Card>();

            if (otherCard != null)
            {
                foreach (Card card in PossibleCards)
                {
                    if (WhoIsTheWinner.GetWinner(card, otherCard, isPlayer1LastWinner))
                    {
                        winningCards.Add(card);
                    }
                }

                if (winningCards.Count > 0)
                {
                    Card cheapestWinningCard = winningCards.FirstOrDefault();

                    foreach (Card card in winningCards)
                    {
                        if (card.Value < cheapestWinningCard.Value)
                        {
                            cheapestWinningCard = card;
                        }
                    }

                    choosenCard = cheapestWinningCard;
                }
                else
                {
                    Card cheapestCard = PossibleCards.FirstOrDefault();

                    foreach (Card card in PossibleCards)
                    {
                        if (card.Value < cheapestCard.Value)
                        {
                            cheapestCard = card;
                        }
                    }
                    choosenCard = cheapestCard;
                }
            }
            else
            {
                foreach (Card card in PossibleCards)
                {
                    if (card.Value <= 20)
                    {
                        noTrump.Add(card);
                    }
                }

                return noTrump.FirstOrDefault();
            }


            return choosenCard;
        }


    }


    public class BotMarkus : Player
    {
        // Track seen cards within a game to adapt decisions
        private readonly HashSet<string> seenCards = new HashSet<string>();

        // Adaptive bot strategy:
        // - Preserves critical trumps when possible
        // - Closes the game proactively at 2 tricks
        // - Chooses majority rank/suit at the start with sensible tie-breakers
        public BotMarkus()
        {
            Init();
            PlayerType = PlayerType.Bot;
            PlayerName = "Markus_Bot";
        }

        public override Card ChooseCard(List<Card> PossibleCards, Card otherCard, bool isPlayer1LastWinner)
        {
            // iAmLeading: true if we play first in this trick
            // needToClose: one trick away from winning this game
            bool iAmLeading = otherCard == null;
            bool needToClose = this.WinCount == 2;
            // New game heuristic reset: start of a game we have 5 cards and 0 wins
            if (this.PlayerCards.Count == 5 && this.WinCount == 0)
            {
                seenCards.Clear();
            }
            if (otherCard != null)
            {
                seenCards.Add(otherCard.Name);
            }
            int cardsLeft = PlayerCards.Count;
            int tricksPlayed = 5 - cardsLeft;
            int oppWins = tricksPlayed - this.WinCount;
            if (oppWins < 0) oppWins = 0;
            bool opponentNeedsClose = oppWins == 2;
            bool weAreBehind = oppWins > this.WinCount;

            // Responding: try to win as cheaply as possible (same-suit winners > non-critical trumps > cheapest winner)
            if (!iAmLeading)
            {
                var winningCards = PossibleCards.Where(c => WouldWin(c, otherCard, false)).ToList();

                if (winningCards.Count > 0)
                {
                    var sameSuitWinners = winningCards.Where(c => c.Suit == otherCard.Suit).OrderBy(c => c.Value).ToList();
                    if (sameSuitWinners.Count > 0)
                    {
                        var nonCritSame = sameSuitWinners.Where(c => !IsCriticalCard(c)).OrderBy(c => c.Value).FirstOrDefault();
                        return Remember(nonCritSame ?? sameSuitWinners.First());
                    }

                    var suitTrumpWin = winningCards.Where(c => IsSuitTrump(c)).OrderBy(c => c.Value).FirstOrDefault();
                    if (suitTrumpWin != null) return Remember(suitTrumpWin);

                    var rankTrumpWin = winningCards.Where(c => IsRankTrump(c)).OrderBy(c => c.Value).FirstOrDefault();
                    if (rankTrumpWin != null) return Remember(rankTrumpWin);

                    var doubleTrumpWin = winningCards.Where(c => IsDoubleTrump(c)).OrderBy(c => c.Value).FirstOrDefault();
                    if (doubleTrumpWin != null) return Remember(doubleTrumpWin);

                    return Remember(winningCards.OrderBy(c => c.Value).First());
                }

                // No winning reply: discard lowest non-trump non-critical; fallback to lowest non-trump, then lowest non-critical, else global lowest
                var discard = PossibleCards.Where(c => !IsTrump(c) && !IsCriticalCard(c)).OrderBy(c => c.Value).FirstOrDefault()
                             ?? PossibleCards.Where(c => !IsTrump(c)).OrderBy(c => c.Value).FirstOrDefault()
                             ?? PossibleCards.Where(c => !IsCriticalCard(c)).OrderBy(c => c.Value).FirstOrDefault()
                             ?? PossibleCards.OrderBy(c => c.Value).First();
                return Remember(discard);
            }

            // One trick from victory: lead a small trump if possible to close the game
            if (needToClose)
            {
                var nonCritTrump = PossibleCards.Where(c => IsTrump(c) && !IsCriticalCard(c)).OrderByDescending(c => c.Value).FirstOrDefault();
                if (nonCritTrump != null) return Remember(nonCritTrump);

                var anyTrump = PossibleCards.Where(c => IsTrump(c)).OrderByDescending(c => c.Value).FirstOrDefault();
                if (anyTrump != null) return Remember(anyTrump);
            }

            if (opponentNeedsClose)
            {
                var strongTrump = PossibleCards.Where(c => IsTrump(c) && !IsCriticalCard(c)).OrderByDescending(c => c.Value).FirstOrDefault()
                                 ?? PossibleCards.Where(c => IsTrump(c)).OrderByDescending(c => c.Value).FirstOrDefault();
                if (strongTrump != null) return Remember(strongTrump);
            }

            // Count our trumps to decide whether to draw trump
            int trumps = PlayerCards.Count(c => IsTrump(c));
            if (trumps >= 3)
            {
                var lowTrump = PossibleCards.Where(c => IsSuitTrump(c)).OrderBy(c => c.Value).FirstOrDefault()
                              ?? PossibleCards.Where(c => IsTrump(c) && !IsCriticalCard(c)).OrderBy(c => c.Value).FirstOrDefault()
                              ?? PossibleCards.Where(c => IsTrump(c)).OrderBy(c => c.Value).FirstOrDefault();
                if (lowTrump != null) return Remember(lowTrump);
            }

            bool early = PlayerCards.Count >= 4;
            bool hasCheapNonCritTrump = PossibleCards.Any(c => IsTrump(c) && !IsCriticalCard(c));
            bool strongSidePotential = PlayerCards.Count(c => !IsTrump(c) && BaseRankValue(c) >= 12) >= 2;

            // Extended bait logic: allow when early, we have cheap non-critical trump, and either have 2+ trumps or are behind, and some side strength
            if (!needToClose && !opponentNeedsClose && iAmLeading && hasCheapNonCritTrump && early && (trumps >= 2 || weAreBehind) && strongSidePotential)
            {
                var bait = PossibleCards.Where(c => IsSuitTrump(c) && !IsCriticalCard(c)).OrderBy(c => c.Value).FirstOrDefault()
                        ?? PossibleCards.Where(c => IsTrump(c) && !IsCriticalCard(c)).OrderBy(c => c.Value).FirstOrDefault();
                if (bait != null) return Remember(bait);
            }

            // Score-based lead selection as a fallback: avoid criticals if possible, prefer conserving high value
            var leadPool = PossibleCards.Where(c => !IsCriticalCard(c)).ToList();
            if (leadPool.Count == 0) leadPool = PossibleCards.ToList();
            var bestLead = leadPool
                .OrderByDescending(c => EvaluateCard(c, leadPool, null, true, needToClose, opponentNeedsClose, trumps, false))
                .First();

            return Remember(bestLead);
        }

        public bool IsCriticalCard(Card card)
        {
            // The three permanent top trumps in Watten
            return card.Name == "König Herz" || card.Name == "7 Schellen" || card.Name == "7 Eichel";
        }

        public override string ChooseRank()
        {
            if (PlayerCards.Count == 0) return base.ChooseRank();

            // Ignore criticals for counting majority to avoid bias
            var source = PlayerCards.Where(c => !IsCriticalCard(c)).ToList();
            if (source.Count == 0) source = PlayerCards.ToList();

            // Prefer: majority rank, then ranks that include permanent criticals (7/König), then our own critical presence, then base strength
            var ranked = source
                .GroupBy(c => c.Rank)
                .Select(g => new
                {
                    Rank = g.Key,
                    Count = g.Count(),
                    Sum = PlayerCards.Where(c => c.Rank == g.Key).Sum(c => BaseRankValue(c)),
                    HasPermCriticalRank = RankHasPermanentCritical(g.Key),
                    OwnCriticalInRank = WeHoldRankCritical(g.Key)
                })
                .OrderByDescending(x => x.Count)
                .ThenByDescending(x => x.HasPermCriticalRank)
                .ThenByDescending(x => x.OwnCriticalInRank)
                .ThenByDescending(x => x.Sum)
                .ToList();

            return ranked.First().Rank;
        }

        public override string ChooseSuit()
        {
            if (PlayerCards.Count == 0) return base.ChooseSuit();

            // Ignore criticals for counting majority to avoid bias
            var source = PlayerCards.Where(c => !IsCriticalCard(c)).ToList();
            if (source.Count == 0) source = PlayerCards.ToList();

            // Prefer: majority suit, then suits that contain permanent criticals (Herz/Eichel/Schellen), then our own critical presence, then base strength
            var suited = source
                .GroupBy(c => c.Suit)
                .Select(g => new
                {
                    Suit = g.Key,
                    Count = g.Count(),
                    Sum = PlayerCards.Where(c => c.Suit == g.Key).Sum(c => BaseRankValue(c)),
                    HasPermCriticalSuit = SuitHasPermanentCritical(g.Key),
                    OwnCriticalInSuit = WeHoldSuitCritical(g.Key)
                })
                .OrderByDescending(x => x.Count)
                .ThenByDescending(x => x.HasPermCriticalSuit)
                .ThenByDescending(x => x.OwnCriticalInSuit)
                .ThenByDescending(x => x.Sum)
                .ToList();

            return suited.First().Suit;
        }

        private bool IsTrump(Card card)
        {
            // In this ruleset, Value >= 20 indicates a trump (chosen suit, chosen rank, or critical)
            return card.Value >= 20;
        }

        private bool WouldWin(Card card, Card otherCard, bool iAmLeading)
        {
            // Theoretical outcome using the same logic as WhoIsTheWinner; ties go to the leading player
            if (card == null) return false;
            if (otherCard == null) return true;

            if (card.Value > 20 || otherCard.Value > 20 || card.Suit == otherCard.Suit)
            {
                if (card.Value > otherCard.Value) return true;
                if (otherCard.Value > card.Value) return false;
                return iAmLeading;
            }

            return iAmLeading;
        }

        private int BaseRankValue(Card card)
        {
            // Neutral rank mapping (pre-trump value), used for tie-breaking in rank/suit choice
            switch (card.Rank)
            {
                case "Unter": return 11;
                case "Ober": return 12;
                case "König": return 13;
                case "Ass": return 14;
                default:
                    int n;
                    if (int.TryParse(card.Rank, out n)) return n;
                    return 0;
            }
        }

        private int BoostOverBase(Card card)
        {
            if (IsCriticalCard(card)) return 1000;
            return card.Value - BaseRankValue(card);
        }

        private bool IsDoubleTrump(Card card)
        {
            int boost = BoostOverBase(card);
            return !IsCriticalCard(card) && boost >= 50;
        }

        private bool IsRankTrump(Card card)
        {
            int boost = BoostOverBase(card);
            return !IsCriticalCard(card) && boost >= 30 && boost < 50;
        }

        private bool IsSuitTrump(Card card)
        {
            int boost = BoostOverBase(card);
            return !IsCriticalCard(card) && boost >= 20 && boost < 50;
        }

        private bool SuitHasPermanentCritical(string suit)
        {
            return suit == "Herz" || suit == "Eichel" || suit == "Schellen"; // Blatt has none
        }

        private bool RankHasPermanentCritical(string rank)
        {
            return rank == "7" || rank == "König";
        }

        private bool WeHoldSuitCritical(string suit)
        {
            return (suit == "Herz" && PlayerCards.Any(c => c.Name == "König Herz"))
                || (suit == "Eichel" && PlayerCards.Any(c => c.Name == "7 Eichel"))
                || (suit == "Schellen" && PlayerCards.Any(c => c.Name == "7 Schellen"));
        }

        private bool WeHoldRankCritical(string rank)
        {
            return (rank == "König" && PlayerCards.Any(c => c.Name == "König Herz"))
                || (rank == "7" && (PlayerCards.Any(c => c.Name == "7 Eichel") || PlayerCards.Any(c => c.Name == "7 Schellen")));
        }

        private double EvaluateCard(Card card, List<Card> candidatePool, Card otherCard, bool iAmLeading, bool needToClose, bool opponentNeedsClose, int trumps, bool baitOpportunity)
        {
            double score = 0;

            // General conservation of high-value assets
            if (IsCriticalCard(card)) score -= 15;

            if (iAmLeading)
            {
                // Prefer lower cards when leading unless closing/baiting
                score -= card.Value * 0.3;
                if (IsTrump(card) && !needToClose && !baitOpportunity) score -= 6;
                if (!IsTrump(card)) score += 3;
                if (trumps >= 3 && IsSuitTrump(card)) score += 2; // drawing trumps lightly when rich in trumps
            }
            else
            {
                bool wouldWin = WouldWin(card, otherCard, false);
                if (wouldWin) score += 20; else score -= 10;
                if (otherCard != null && card.Suit == otherCard.Suit) score += 3;
                if (IsTrump(card) && !needToClose && !opponentNeedsClose) score -= 3; // avoid wasting trump if not necessary
            }

            if (needToClose)
            {
                score += IsTrump(card) ? 12 : 4;
            }

            if (opponentNeedsClose)
            {
                score += iAmLeading ? (IsTrump(card) ? 6 : 0) : 0;
            }

            return score;
        }

        private Card Remember(Card card)
        {
            if (card != null) seenCards.Add(card.Name);
            return card;
        }
    }
}
