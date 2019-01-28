using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Low_Level_Objects_Library;
using Games_Logic_Library;

namespace Games {
    /// <summary>
    /// Provides a visual representation of the logic of Twenty-One
    /// </summary>
    public partial class FormGameTwentyOne : Form {
        TableLayoutPanel[] tableLayoutPanels;
        Label[] bustedLabels;
        Label[] pointsLabels;
        Label[] gamesWonLabels;

        private bool gameCurrent;

        public FormGameTwentyOne() {
            InitializeComponent();

            // Store references to controls
            this.tableLayoutPanels = new TableLayoutPanel[TwentyOneGame.NUM_OF_PLAYERS] {
                this.tlpPlayer,
                this.tlpDealer
            };

            this.bustedLabels = new Label[TwentyOneGame.NUM_OF_PLAYERS] {
                this.lblPlayerBusted,
                this.lblDealerBusted
            };

            this.pointsLabels = new Label[TwentyOneGame.NUM_OF_PLAYERS] {
                this.lblPlayerPoints,
                this.lblDealerPoints
            };

            this.gamesWonLabels = new Label[TwentyOneGame.NUM_OF_PLAYERS] {
                this.lblPlayerWon,
                this.lblDealerWon
            };

            this.gameCurrent = false;
        }

        /// <summary>
        /// Displays the cards of a hand in the appropriate control
        /// </summary>
        /// <param name="hand">The hand</param>
        /// <param name="tableLayoutPanel">The control</param>
        private void DisplayGuiHand(Hand hand, TableLayoutPanel tableLayoutPanel) {
            tableLayoutPanel.Controls.Clear(); // Remove any cards already being shown.

            foreach (Card card in hand) {
                // Contrust a PictureBox object.
                PictureBox pictureBox = new PictureBox();
                // Tell the PictureBox to use all the space inside its square.
                pictureBox.Dock = DockStyle.Fill;
                // Remove spacing around the PictureBox. (Default is 3 pixels.)
                pictureBox.Margin = new Padding(0);

                pictureBox.Image = Images.GetCardImage(card);

                // Add the PictureBox object to the tableLayoutPanel.
                tableLayoutPanel.Controls.Add(pictureBox);
            }
        } // End DisplayGuiHand

        /// <summary>
        /// Copies data from logic class to display
        /// </summary>
        /// <param name="firstRun">Prevent exceptions resulting from no game being played prior</param>
        private void UpdateDisplay(bool firstRun) {
            // Show number of games won
            this.gamesWonLabels[TwentyOneGame.PLAYER_USER].Text = TwentyOneGame.GetNumOfGamesWon(TwentyOneGame.PLAYER_USER).ToString();
            this.gamesWonLabels[TwentyOneGame.PLAYER_CPU].Text = TwentyOneGame.GetNumOfGamesWon(TwentyOneGame.PLAYER_CPU).ToString();

            // Show how many aces the user has that have a value of 1
            this.lblOneAces.Text = TwentyOneGame.GetNumOfUserAcesWithValueOne().ToString();

            if (!firstRun) {
                // Show the hands
                this.DisplayGuiHand(TwentyOneGame.GetHand(TwentyOneGame.PLAYER_USER), this.tableLayoutPanels[TwentyOneGame.PLAYER_USER]);
                this.DisplayGuiHand(TwentyOneGame.GetHand(TwentyOneGame.PLAYER_CPU), this.tableLayoutPanels[TwentyOneGame.PLAYER_CPU]);

                int pointsPlayer = TwentyOneGame.CalculateHandTotal(TwentyOneGame.PLAYER_USER);
                int pointsCpu = TwentyOneGame.CalculateHandTotal(TwentyOneGame.PLAYER_CPU);

                // Show whether a player is busted
                this.bustedLabels[TwentyOneGame.PLAYER_USER].Visible = !this.gameCurrent && pointsPlayer > TwentyOneGame.MAX_POINTS;
                this.bustedLabels[TwentyOneGame.PLAYER_CPU].Visible = !this.gameCurrent && pointsCpu > TwentyOneGame.MAX_POINTS;

                // Only show if they have more than 0 points
                this.pointsLabels[TwentyOneGame.PLAYER_USER].Visible = pointsPlayer > 0;
                this.pointsLabels[TwentyOneGame.PLAYER_CPU].Visible = pointsCpu > 0;

                // Show points
                this.pointsLabels[TwentyOneGame.PLAYER_USER].Text = pointsPlayer.ToString();
                this.pointsLabels[TwentyOneGame.PLAYER_CPU].Text = pointsCpu.ToString();

                if (!this.gameCurrent && pointsPlayer >= TwentyOneGame.MAX_POINTS) {
                    btnDeal.Enabled = true;
                    btnHit.Enabled = false;
                    btnStand.Enabled = false;
                }
            }

            // Force visual update
            this.Update();
        }

        private void btnStand_Click(object sender, EventArgs e) {
            TwentyOneGame.PlayForDealer();

            this.gameCurrent = false;

            this.UpdateDisplay(false);

            this.btnHit.Enabled = false;
            this.btnStand.Enabled = false;
            this.btnDeal.Enabled = true;
        }

        private void FormGameTwentyOne_Load(object sender, EventArgs e) {
            this.UpdateDisplay(true);
        }

        private void btnHit_Click(object sender, EventArgs e) {
            this.DealCardTo(TwentyOneGame.PLAYER_USER, false);

            this.UpdateDisplay(false);
        }

        /// <summary>
        /// Utility method to deal a card, also handles aces and first run of cards
        /// </summary>
        /// <param name="who">Which player</param>
        /// <param name="firstRun">Prevent message box and assign default value of 1 for aces</param>
        /// <returns></returns>
        private Card DealCardTo(int who, bool firstRun) {
            Card card = TwentyOneGame.DealOneCardTo(who);

            // Is it an ace
            if (!firstRun && who == TwentyOneGame.PLAYER_USER && card.GetFaceValue() == FaceValue.Ace) {
                if (MessageBox.Show("Count ace as 1?", this.Text, MessageBoxButtons.YesNo) == DialogResult.Yes) {
                    TwentyOneGame.IncrementNumOfUserAcesWithValueOne();
                }
            }

            this.UpdateDisplay(false);

            return card;
        }

        private void btnDeal_Click(object sender, EventArgs e) {
            this.btnDeal.Enabled = false;
            this.btnHit.Enabled = true;
            this.btnStand.Enabled = true;

            this.gameCurrent = true;

            TwentyOneGame.SetUpGame();

            // Deal initial cards
            this.DealCardTo(TwentyOneGame.PLAYER_CPU, true);
            this.DealCardTo(TwentyOneGame.PLAYER_CPU, true);

            Card card1 = this.DealCardTo(TwentyOneGame.PLAYER_USER, true);
            Card card2 = this.DealCardTo(TwentyOneGame.PLAYER_USER, true);

            // If two aces are dealt, both have a value of one
            if (card1.GetFaceValue() == FaceValue.Ace || card2.GetFaceValue() == FaceValue.Ace) {
                // Handle two aces being dealt
                if (card1.GetFaceValue() == FaceValue.Ace && card2.GetFaceValue() == FaceValue.Ace) {
                    TwentyOneGame.IncrementNumOfUserAcesWithValueOne();
                    TwentyOneGame.IncrementNumOfUserAcesWithValueOne();
                } else { // Or just one
                    if (MessageBox.Show("Count ace as 1?", this.Text, MessageBoxButtons.YesNo) == DialogResult.Yes) {
                        TwentyOneGame.IncrementNumOfUserAcesWithValueOne();
                    }
                }
            }

            this.UpdateDisplay(false);
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            int playerPoints = TwentyOneGame.CalculateHandTotal(TwentyOneGame.PLAYER_USER);
            int cpuPoints = TwentyOneGame.CalculateHandTotal(TwentyOneGame.PLAYER_CPU);

            // Show friendly exit message
            string message = "It was a draw!";

            if (playerPoints > cpuPoints) {
                message = "You won! Well done.";
            } else if (cpuPoints > playerPoints) {
                message = "House won! Better luck next time.";
            }

            MessageBox.Show(message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }
    }
}
