using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Games_Logic_Library;
using Low_Level_Objects_Library;

using System.Threading;
using System.Media;

namespace Games {
    /// <summary>
    /// Provides a presentation for a game of Crazy Eights
    /// </summary>
    public partial class FormGameCrazyEights : Form {
        private CrazyEightsGame game;
        private bool gameOver;

        private Dictionary<CrazyEightsGame.Player, TableLayoutPanel> panels;

        public FormGameCrazyEights() {
            InitializeComponent();

            this.game = new CrazyEightsGame();

            // Store a dictionary reference to the table layout panels
            this.panels = new Dictionary<CrazyEightsGame.Player, TableLayoutPanel>() {
                { CrazyEightsGame.Player.Computer, this.tblComputer },
                { CrazyEightsGame.Player.User, this.tblUser }
            };

            this.gameOver = false;
        }

        /// <summary>
        /// Determines if there is a winner or stalemate and shows a message to that effect.
        /// </summary>
        /// <param name="stalemate">Whether the game over signal was triggered by the computer</param>
        private void ShowWinner(bool stalemate) {
            CrazyEightsGame.Player? winner = this.game.GetWinner();

            if (winner != null || stalemate) {
                if (!this.gameOver) {
                    // Display a friendly error message
                    string message = "It was a stalemate!";

                    if (winner == CrazyEightsGame.Player.User) {
                        message = "You won! Well done.";

                        // Play a sound
                        try {
                            new SoundPlayer(Environment.ExpandEnvironmentVariables("%WINDIR%\\Media\\tada.wav")).Play();
                        } catch (Exception e) {

                        }
                    } else if (winner == CrazyEightsGame.Player.Computer) {
                        message = "The computer won! Better luck next time.";
                    }

                    MessageBox.Show(message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();

                    // Prevent win message showing multiple times
                    this.gameOver = true;
                }
            }
        }

        /// <summary>
        /// Copies data from the logic class to the form
        /// </summary>
        /// <param name="firstRun"></param>
        private void UpdateDisplay(bool firstRun) {
            this.lblInstruction.Text = "Your turn. Click on one of your cards to play.\r\nSuit = " + this.game.GetTopCardSuit().ToString();

            // Hands
            this.DisplayGuiHand(CrazyEightsGame.Player.Computer);
            this.DisplayGuiHand(CrazyEightsGame.Player.User);

            // Determine if the player must deal a card
            CrazyEightsGame.PlayabilityState state = this.game.GetPlayabilityState(CrazyEightsGame.Player.User);

            this.btnDeal.Enabled = state == CrazyEightsGame.PlayabilityState.DealCard;

            if (this.btnDeal.Enabled) {
                this.lblInstruction.Text = "You have no cards that you can play. You must draw a card.";
            }

            // Update top card
            this.imgTopCard.Image = Images.GetCardImage(this.game.GetTopCard());

            if (!firstRun) {
                this.ShowWinner(false);
            }
        }

        private void DisplayGuiHand(CrazyEightsGame.Player player) {
            // Programatically get the hand and panel based on the player
            Hand hand = this.game.GetPlayerHand(player);
            TableLayoutPanel panel = this.panels[player];

            panel.Controls.Clear();

            foreach (Card card in hand) {
                // Create a picture box
                PictureBox pictureBox = new PictureBox();

                // Expand
                pictureBox.Dock = DockStyle.Fill;
                // No margin
                pictureBox.Margin = new Padding(0);
                // Set image
                pictureBox.Image = Images.GetCardImage(card);

                // Allow player to click on the card
                if (player == CrazyEightsGame.Player.User) {
                    pictureBox.Click += new EventHandler(this.card_Click);
                    pictureBox.Tag = card;
                }

                // Add the picture box
                this.panels[player].Controls.Add(pictureBox);
            }
        }

        private void FormGameCrazyEights_Load(object sender, EventArgs e) {
            this.UpdateDisplay(true);
        }

        private void card_Click(object sender, EventArgs e) {
            PictureBox pictureBox = (PictureBox)sender;
            Card card = (Card)pictureBox.Tag;

            if (!this.game.IsCardPlayable(card)) {
                this.lblInstruction.Text = "Can't play that card now";

                return;
            }

            // Play a card
            bool chooseSuit = this.game.PlayCard(CrazyEightsGame.Player.User, card);

            // Choose suit if necessary
            if (chooseSuit) {
                FormGameCrazyEightsSelectSuit form = new FormGameCrazyEightsSelectSuit();

                form.ShowDialog();

                this.game.PlayCard(CrazyEightsGame.Player.User, card, form.ReturnValue);
            }

            this.UpdateDisplay(false);

            // Delay
            Application.DoEvents();

            const int HALF_SECOND_MS = 500;

            Thread.Sleep(HALF_SECOND_MS);

            // Play for computer
            this.ShowWinner(this.game.PlayForComputer());

            this.UpdateDisplay(false);
        }

        private void button1_Click(object sender, EventArgs e) {
            this.game.GetPlayerHand(CrazyEightsGame.Player.User).Sort();

            this.UpdateDisplay(false);
        }

        private void btnDeal_Click(object sender, EventArgs e) {
            this.game.DealCard(CrazyEightsGame.Player.User);

            this.UpdateDisplay(false);
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            this.ShowWinner(true);
        }

        private void imgCardBack_Click(object sender, EventArgs e) {
            if (this.game.GetPlayabilityState(CrazyEightsGame.Player.User) == CrazyEightsGame.PlayabilityState.DealCard) {
                this.btnDeal_Click(sender, e);
            }
        }
    }
}
