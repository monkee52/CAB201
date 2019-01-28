using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Games {
    /// <summary>
    /// Initial form. Presents user with different categories of games and allows the user to select an option.
    /// </summary>
    public partial class FormGameSelector : Form {
        public FormGameSelector() {
            InitializeComponent();
        }

        private void radGameType_CheckedChanged(object sender, EventArgs e) {
            this.btnStart.Enabled = true;
        }

        private void btnExit_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void btnStart_Click(object sender, EventArgs e) {
            Games game;

            if (this.radGameTypeCard.Checked) { // Show card games
                FormGameSubSelector selector = new FormGameSubSelector("Card", new[] {
                    Games.TwentyOne,
                    Games.CrazyEights
                });

                if (selector.ShowDialog() != DialogResult.OK) {
                    return;
                }

                game = selector.ReturnValue;
            } else if (this.radGameTypeDice.Checked) { // Show dice games
                FormGameSubSelector selector = new FormGameSubSelector("Dice", new[] {
                    Games.SnakeEyes,
                    Games.CaptainShipCrew
                });

                if (selector.ShowDialog() != DialogResult.OK) {
                    return;
                }

                game = selector.ReturnValue;
            } else { // this.radGameTypeCoin.Checked --- Play the only coin game
                game = Games.TwoUp;
            }

            GamesImplementation.PlayGame(game);
        }
    }
}
