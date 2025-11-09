using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WattenForms
{
    public partial class FrmModeSelection : Form
    {
        public FrmModeSelection()
        {
            InitializeComponent();
        }

        private void btnPvP_Click(object sender, EventArgs e)
        {
            Player player1 = new Player();
            Player player2 = new Player();

            RankAndSuitChoice rankAndSuitChoice = new RankAndSuitChoice(Globals.Deck, player1, player2);
            rankAndSuitChoice.Owner = this;
            rankAndSuitChoice.Show();
            this.Hide();
        }

        private void btnBotEasy_Click(object sender, EventArgs e)
        {
            var player1 = new Player();
            var player2 = new BotEasy();

            RankAndSuitChoice rankAndSuitChoice = new RankAndSuitChoice(Globals.Deck, player1, player2);
            rankAndSuitChoice.Owner = this;
            rankAndSuitChoice.Show();
            this.Hide();
        }

        private void btnBotMedium_Click(object sender, EventArgs e)
        {
            var player1 = new Player();
            var player2 = new BotMedium();

            RankAndSuitChoice rankAndSuitChoice = new RankAndSuitChoice(Globals.Deck, player1, player2);
            rankAndSuitChoice.Owner = this;
            rankAndSuitChoice.Show();
            this.Hide();
        }

        private void btnBotHard_Click(object sender, EventArgs e)
        {

        }
    }
}
