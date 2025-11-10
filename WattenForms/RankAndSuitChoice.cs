using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WattenForms;

namespace WattenForms
{
    public partial class RankAndSuitChoice : Form
    {
        private Player player1;
        private Player player2;

        public RankAndSuitChoice(Deck deck, Player player1, Player player2)
        {
            InitializeComponent();

            this.player1 = player1;
            this.player2 = player2;

            btnShowCardsPlayer1.Visible = player1.PlayerType == PlayerType.Human;
            btnShowCardsPlayer2.Visible = player2.PlayerType == PlayerType.Human;
            

            deck.Shuffle();
            DealCards(deck);
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (comboBoxRank.SelectedItem != null && comboBoxSuit.SelectedItem != null)
            {
                CardFunctions.SetCardValue(comboBoxRank.Text, comboBoxSuit.Text);
                InGame inGame = new InGame(player1, player2, comboBoxRank.Text, comboBoxSuit.Text);
                inGame.Owner = this;

                inGame.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Bitte wählen Sie einen Schlag und eine Farbe aus!");
            }
        }

        private void DealCards(Deck deck)
        {
            listBoxPlayer1.Visible = false;
            listBoxPlayer2.Visible = false;
            for (int i = 0; i < 10; i+=2)
            {
                listBoxPlayer1.Items.Add(deck.Cards[i].Name);
                player1.PlayerCards.Add(deck.Cards[i]);
                
                listBoxPlayer2.Items.Add(deck.Cards[i+1].Name);
                player2.PlayerCards.Add(deck.Cards[i+1]);
            }
        }

        private void btnShowCardsPlayer1_Click(object sender, EventArgs e)
        {
            listBoxPlayer1.Visible = !listBoxPlayer1.Visible;
        }

        private void btnShowCardsPlayer2_Click(object sender, EventArgs e)
        {
            listBoxPlayer2.Visible = !listBoxPlayer2.Visible;
        }

        private void comboBoxRank_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxRank.Enabled = false;

            if (comboBoxSuit.SelectedItem == null)
            {
                if (player2.PlayerType != PlayerType.Human)
                {
                    comboBoxSuit.Text = player2.ChooseSuit();
                    comboBoxSuit.SelectedItem = player2.ChooseSuit();
                }

                if (comboBoxSuit.SelectedItem == null)
                {
                    comboBoxSuit.Enabled = player2.PlayerType == PlayerType.Human;
                }
            }
        }

        private void comboBoxSuit_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxSuit.Enabled = false;

            if (comboBoxRank.SelectedItem == null)
            {
                if (player2.PlayerType != PlayerType.Human)
                {
                    comboBoxRank.Text = player2.ChooseRank();
                    comboBoxRank.SelectedItem = player2.ChooseRank();
                }

                if (comboBoxRank.SelectedItem == null)
                {
                    comboBoxRank.Enabled = player1.PlayerType == PlayerType.Human;
                }
            }
        }
    }
}
