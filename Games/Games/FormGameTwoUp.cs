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
    /// Presents a visual representation of a game of Two-Up
    /// </summary>
    public partial class FormGameTwoUp : Form {
        private double animationCounter;
        private const double ONE_SECOND = 1.0f;

        private const int COIN_1 = 1;
        private const int COIN_2 = 2;

        public FormGameTwoUp() {
            InitializeComponent();

            TwoUpGame.SetUpGame();

            this.UpdateDisplay(true);
        }

        /// <summary>
        /// Copies data from logic class to display
        /// </summary>
        /// <param name="isFirstRun">Prevent exceptions resulting from no game being played prior</param>
        private void UpdateDisplay(bool isFirstRun) {
            // Show images
            this.UpdatePictureBoxImage(this.picCoin1, TwoUpGame.IsHeads(COIN_1));
            this.UpdatePictureBoxImage(this.picCoin2, TwoUpGame.IsHeads(COIN_2));

            // Show scores
            this.lblScorePlayer.Text = TwoUpGame.GetPlayersScore().ToString();
            this.lblScoreComputer.Text = TwoUpGame.GetComputersScore().ToString();

            if (!isFirstRun) {
                // Show toss outcomes
                this.lblOutcome.Visible = true;

                string tossOutcome = TwoUpGame.TossOutcome();

                this.lblOutcome.Text = tossOutcome;

                if (tossOutcome != "Odds") {
                    this.btnThrowCoins.Enabled = false;
                    this.btnPlayAgain.Visible = true;
                }
            }
        }

        /// <summary>
        /// Updates a picture box to have the correct coin image
        /// </summary>
        /// <param name="pictureBox">Which picture box</param>
        /// <param name="isHeads">Whether the coin is heads</param>
        private void UpdatePictureBoxImage(PictureBox pictureBox, bool isHeads) {
            pictureBox.Image = Images.GetCoinImage(isHeads);
        }

        private void btnCancelGame_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void btnThrowCoins_Click(object sender, EventArgs e) {
            // Logic deferred to animation tick

            // Prepare for animation
            animationCounter = 0;

            tmrAnimation.Start();

            btnThrowCoins.Enabled = false;
        }

        private void btnPlayAgain_Click(object sender, EventArgs e) {
            this.btnThrowCoins.Enabled = true;
            this.btnPlayAgain.Visible = false;
        }

        private void tmrAnimation_Tick(object sender, EventArgs e) {
            // Display true result after one second
            if (animationCounter >= ONE_SECOND) {
                tmrAnimation.Stop();

                btnThrowCoins.Enabled = true;

                TwoUpGame.TossCoins();

                this.UpdateDisplay(false);

                return;
            }

            // DateTime.UtcNow.Ticks is a measure of nanoseconds, so values between are different.
            // Makes for slightly more realistic coin flips
            UpdatePictureBoxImage(this.picCoin1, DateTime.UtcNow.Ticks % 2 == 0);
            UpdatePictureBoxImage(this.picCoin2, DateTime.UtcNow.Ticks % 2 == 0);

            // Update animationCounter with how many seconds it has been
            animationCounter += (double)tmrAnimation.Interval / 1000.0f;
        }
    }
}
