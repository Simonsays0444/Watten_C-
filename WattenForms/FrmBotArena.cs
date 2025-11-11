using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WattenForms
{
    public partial class FrmBotArena : Form
    {
        private Deck deck;

        public FrmBotArena(Deck deck)
        {
            InitializeComponent();
            this.deck = deck;
        }

        private static void DealCards(Deck deck, Player player1, Player player2)
        {
            deck.Shuffle();

            for (int i = 0; i < 10; i+= 2)
            {
                player1.PlayerCards.Add(deck.Cards[i]);
                player2.PlayerCards.Add(deck.Cards[i+1]);
            }
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            lblBot1WinCount.Text = "0";
            lblBot2WinCount.Text = "0";
            lblProzentPlayer1.Text = "0%";
            lblProzentPlayer2.Text = "0%";

            if (comboBoxBot1.SelectedItem != null && comboBoxBot2.SelectedItem != null && comboBoxAmountOfRounds.SelectedItem != null)
            {
                int bot1Wins = 0;
                int bot2Wins = 0;

                Player Winner;

                Player bot1 = CreateChoosenBot(comboBoxBot1.Text);
                Player bot2 = CreateChoosenBot(comboBoxBot2.Text);

                Player LastBeginner = bot2;

                int AmountOfRounds = int.Parse(comboBoxAmountOfRounds.Text);

                for (int i = 0; i < AmountOfRounds; i++)
                {
                    if (bot2 == LastBeginner)
                    {
                        Winner = Game(bot1, bot2, deck);
                        LastBeginner = bot1;
                    }
                    else
                    {
                        Winner = Game(bot2, bot1, deck);
                        LastBeginner = bot2;
                    }
                    

                    if (Winner == bot1)
                    {
                        bot1Wins++;
                    } 
                    else
                    {
                        bot2Wins++;
                    }
                }
                lblBot1WinCount.Text = bot1Wins.ToString();
                lblBot2WinCount.Text = bot2Wins.ToString();
                lblProzentPlayer1.Text = $"{(((float)bot1Wins / (float)AmountOfRounds) * 100).ToString("F2")} %";
                lblProzentPlayer2.Text = $"{(((float)bot2Wins / (float)AmountOfRounds) * 100).ToString("F2")} %";
            } 
            else
            {
                MessageBox.Show("Bitte wählen Sie für alle Felder etwas aus!");
            }
        }

        private Player CreateChoosenBot(string choice)
        {
            switch (choice)
            {
                case "Easy":
                    BotEasy BotEasy = new BotEasy();
                    return BotEasy;
                case "Medium":
                    BotMedium BotMedium = new BotMedium();
                    return BotMedium;
                case "Hard":
                    BotHard BotHard = new BotHard();
                    return BotHard;
                case "Simon":
                    BotSimon BotChatGpt = new BotSimon();
                    return BotChatGpt;
                case "Markus":
                    BotMarkus Markus = new BotMarkus();
                    return Markus;
                default:
                    return null;
            }
        }

        private static Player Game(Player bot1, Player bot2, Deck deck)
        {
            bot1.PlayerCards.Clear();
            bot2.PlayerCards.Clear();

            bot1.WinCount = 0;
            bot2.WinCount = 0;



            DealCards(deck, bot1, bot2);

            string Rank = bot1.ChooseRank();
            string Suit = bot2.ChooseSuit();

            Card CardFromPlayer1 = null;
            Card CardFromPlayer2 = null;

            bool isPlayer1LastWinner = true;

            CardFunctions.SetCardValue(Rank, Suit);

            while (bot1.WinCount != 3 && bot2.WinCount != 3)
            {
                CardFromPlayer1 = bot1.ChooseCard(bot1.GetPossibleCards(CardFromPlayer1, CardFromPlayer2, isPlayer1LastWinner), CardFromPlayer2, isPlayer1LastWinner);
                CardFromPlayer2 = bot2.ChooseCard(bot2.GetPossibleCards(CardFromPlayer1, CardFromPlayer2, isPlayer1LastWinner), CardFromPlayer1, isPlayer1LastWinner);

                isPlayer1LastWinner = WhoIsTheWinner.GetWinner(CardFromPlayer1, CardFromPlayer2, isPlayer1LastWinner);

                if (isPlayer1LastWinner)
                {
                    bot1.WinCount++;
                }
                else
                {
                    bot2.WinCount++;
                    isPlayer1LastWinner = false;
                }
                bot1.PlayerCards.Remove(CardFromPlayer1);
                bot2.PlayerCards.Remove(CardFromPlayer2);
            }

            if (bot1.WinCount == 3)
            {
                return bot1;
            }
            else
            {
                return bot2;
            }
        }

    }
}
