////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// <copyright file="InGame.cs" company="Vector Informatik GmbH">
//    Unauthorized copying of this file, via any medium is strictly prohibited. Proprietary and confidential! - All Rights Reserved.
// </copyright>
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

namespace WattenForms
{
    using System;
    using System.Windows.Forms;

    public partial class InGame : Form
    {
        private Player player1;
        private Player player2;
        bool isPlayer1LastWinner = true;

        public InGame(Player player1, Player player2, string Rank, string Suit)
        {
            this.player1 = player1;
            this.player2 = player2;

            InitializeComponent();
            lblRankAndSuitView.Text = $"Schlag: {Rank}\nFarbe: {Suit}";
            LoadPlayerCardsIntoCombobox();
            ActivatePlayer1();
        }

        public void LoadPlayerCardsIntoCombobox()
        {
            comboBoxCardsPlayer1.Items?.Clear();
            foreach (var card in player1.PlayerCards)
            {
                comboBoxCardsPlayer1.Items.Add(card);
            }

            comboBoxCardsPlayer2.Items?.Clear();
            foreach (var card in player2.PlayerCards)
            {
                comboBoxCardsPlayer2.Items.Add(card);
            }

            comboBoxCardsPlayer1.SelectedItem = null;
            comboBoxCardsPlayer2.SelectedItem = null;
        }


        private void btnGo_Click(object sender, EventArgs e)
        {
            Card card1 = (Card)comboBoxCardsPlayer1.SelectedItem;
            Card card2 = (Card)comboBoxCardsPlayer2.SelectedItem;

            if (card1 == null || card2 == null)
            {
                MessageBox.Show("Bitte wählen Sie 2 Karten!");
            } 
            else
            {
                isPlayer1LastWinner = WhoIsTheWinner.GetWinner(card1, card2, isPlayer1LastWinner);
                if(isPlayer1LastWinner)
                {
                    player1.WinCount++;
                    lblPlayer1WinCount.Text = player1.WinCount.ToString();
                } 
                else
                {
                    player2.WinCount++;
                    lblPlayer2WinCount.Text = player2.WinCount.ToString();
                }

                player1.PlayerCards.Remove(card1);
                player2.PlayerCards.Remove(card2);
                comboBoxCardsPlayer1.Text = null;
                comboBoxCardsPlayer2.Text = null;

                bool isFinished = IsGameFinished();

                if (isFinished)
                {
                    ShowWinner();
                    Owner.Owner.Show();
                    Close();
                }
                else
                {
                    LoadPlayerCardsIntoCombobox();
                    if (isPlayer1LastWinner)
                    {
                        ActivatePlayer1();
                    }
                    else
                    {
                        ActivatePlayer2();
                    }
                }
            }
        }

        private bool IsGameFinished()
        {
            if (player1.WinCount == 3 || player2.WinCount == 3)
            {
                return true;
            }

            return false;
        }

        private void ShowWinner()
        {
            string winner;
            if (player1.WinCount == 3)
            {
                winner = "Player1";
            }
            else
            {
                winner = "Player2";
            }

            MessageBox.Show($"Der Sieger ist {winner}!!!");
        }

        private void ActivatePlayer1()
        {
            comboBoxCardsPlayer1.Enabled = true;
            comboBoxCardsPlayer2.Enabled = false;
        }        
        
        private void ActivatePlayer2()
        {
            comboBoxCardsPlayer1.Enabled = false;

            comboBoxCardsPlayer2.Enabled = true;
            
            if(player2.PlayerType != PlayerType.Human)
            {
                Card ChoosenCard = player2.ChooseCard(player2.GetPossibleCards((Card)comboBoxCardsPlayer1.SelectedItem, (Card)comboBoxCardsPlayer2.SelectedItem, isPlayer1LastWinner), (Card)comboBoxCardsPlayer1.SelectedItem, isPlayer1LastWinner);
                comboBoxCardsPlayer2.Text = ChoosenCard.Name;
                comboBoxCardsPlayer2.SelectedItem = ChoosenCard;

                ActivatePlayer1();
            }
        }

        private void btnPlayer1Play_Click(object sender, EventArgs e)
        {
            if (comboBoxCardsPlayer1.SelectedItem != null)
            {
                if (player1.GetPossibleCards((Card)comboBoxCardsPlayer1.SelectedItem, (Card)comboBoxCardsPlayer2.SelectedItem, isPlayer1LastWinner).Contains((Card)comboBoxCardsPlayer1.SelectedItem))
                {
                    
                    if (comboBoxCardsPlayer2.SelectedItem != null)
                    {
                        comboBoxCardsPlayer2.Enabled = false;
                    } 
                    else
                    {
                        ActivatePlayer2();
                    }
                    comboBoxCardsPlayer1.Enabled = false;
                } 
                else
                {
                    comboBoxCardsPlayer1.SelectedItem = null;
                    comboBoxCardsPlayer1.Text = null;
                    MessageBox.Show("Sie müssen einen Trumpf zugeben!!!");
                }
            } 
            else
            {
                MessageBox.Show("Bitte wähle eine Karte aus!!!");
            }
        }

        private void btnPlayer2Play_Click(object sender, EventArgs e)
        {
            if (comboBoxCardsPlayer2.SelectedItem != null)
            {
                if (player2.GetPossibleCards((Card)comboBoxCardsPlayer1.SelectedItem, (Card)comboBoxCardsPlayer2.SelectedItem, isPlayer1LastWinner).Contains((Card)comboBoxCardsPlayer2.SelectedItem))
                {
                    if (comboBoxCardsPlayer1.SelectedItem != null)
                    {
                        comboBoxCardsPlayer1.Enabled = false;
                    }
                    else
                    {
                        ActivatePlayer1();
                    }
                    comboBoxCardsPlayer2.Enabled = false;
                }
                else
                {
                    comboBoxCardsPlayer2.SelectedItem = null;
                    comboBoxCardsPlayer2.Text = null;
                    MessageBox.Show("Sie müssen einen Trumpf zugeben!!!");
                }
            }
            else
            {
                MessageBox.Show("Bitte wähle eine Karte aus!!!");
            }
        }


        public bool isTrump(Card card)
        {
            if (card.Value > 20)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void comboBoxCardsPlayer1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void comboBoxCardsPlayer2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
