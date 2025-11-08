namespace WattenForms
{

    public static class Globals
    {
        public static Deck Deck = new Deck();
    }

    public static class CardFunctions
    {
        public static void SetCardValue(string Rank, string Suit)
        {
            // für jede Karte im Deck
            foreach (Card card in Globals.Deck.Cards)
            {
                // Überprüfung der Standartwerte
                int value = 0;
                if (card.Rank != "König" && card.Rank != "Ober" && card.Rank != "Unter" && card.Rank != "Ass")
                {
                    value = int.Parse(card.Rank);
                }
                else
                {
                    switch (card.Rank)
                    {
                        case "Unter":
                            value = 11;
                            break;
                        case "Ober":
                            value = 12;
                            break;
                        case "König":
                            value = 13;
                            break;
                        case "Ass":
                            value = 14;
                            break;
                    }
                }

                // Überprüfung auf kleinen Trumpf
                if (card.Rank == Rank)
                {
                    value += 30;
                }
                if (card.Suit == Suit)
                {
                    value += 20;
                }

                // Überprüfung auf einer der drei großen Trümpfe
                if (card.Rank == "7" && card.Suit == "Eichel")
                {
                    value = 100;
                }
                if (card.Rank == "7" && card.Suit == "Schellen")
                {
                    value = 200;
                }
                if (card.Rank == "König" && card.Suit == "Herz")
                {
                    value = 300;
                }

                card.Value = value;
            }
        }
    }
}