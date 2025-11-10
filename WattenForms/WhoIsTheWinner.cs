using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WattenForms
{
    public class WhoIsTheWinner
    {
    public static bool GetWinner(Card card1, Card card2, bool isPlayer1LastWinner)
        {
            if (card1.Value > 20 || card2.Value > 20 || card1.Suit == card2.Suit)
            {
                if (card1.Value > card2.Value)
                {
                    isPlayer1LastWinner = true;
                    return isPlayer1LastWinner;
                }
                else if (card2.Value > card1.Value)
                {
                    isPlayer1LastWinner = false;
                    return isPlayer1LastWinner;
                }
                else
                {
                    return isPlayer1LastWinner;
                }
            }
            return isPlayer1LastWinner;
        }
    }
}

