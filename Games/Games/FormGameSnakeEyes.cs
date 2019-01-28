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

namespace Games {
    /// <summary>
    /// Provides the user with a visual representation of the Snake-Eyes class
    /// </summary>
    public partial class FormGameSnakeEyes : Form {
        private double animationCounter;
        private const double ONE_SECOND = 1.0f;
        private const int DIE_RNG_MAX = 5;

        private bool firstRoll = true;

        public FormGameSnakeEyes() {
            InitializeComponent();

            SnakeEyesGame.SetUpGame();

            this.UpdateDisplay(true);
        }

        /// <summary>
        /// Copies data from the logic class to the form
        /// </summary>
        /// <param name="firstRun">Prevent exceptions as a result of the game not being played prior</param>
        private void UpdateDisplay(bool firstRun) {
            // Update images
            this.imgDie1.Image = Images.GetDieImage(SnakeEyesGame.GetDiceFaceValue(0));
            this.imgDie2.Image = Images.GetDieImage(SnakeEyesGame.GetDiceFaceValue(1));

            // Update scores
            this.lblPlayerScore.Text = SnakeEyesGame.GetPlayersPoints().ToString();
            this.lblHouseScore.Text = SnakeEyesGame.GetHousePoints().ToString();

            if (!firstRun) {
                // Show roll outcome
                string rollOutcome = SnakeEyesGame.GetRollOutcome();

                this.lblRoll.Text = rollOutcome;

                this.lblResult.Visible = true;

                int points = SnakeEyesGame.GetPossiblePoints();

                // Create user friendly, gramatically correct text.
                if (rollOutcome == SnakeEyesGame.PLAYER_WIN) {
                    this.lblResult.Text = "You get " + points.ToString() + " point" + (points == 1 ? "" : "s") + ".";
                } else if (rollOutcome == SnakeEyesGame.HOUSE_WIN) {
                    this.lblResult.Text = "House gets " + points.ToString() + " point" + (points == 1 ? "" : "s") + ".";
                } else if (!this.firstRoll) {
                    bool anNeeded = false;

                    // Only the numbers 8 and 11 need "an" instead of "a"
                    if (points == 8 || points == 11) {
                        anNeeded = true;
                    }

                    this.lblResult.Text = "You need to roll a" + (anNeeded ? "n " : " ") + points.ToString();
                }
            }

            // Aesthetics
            this.CenterControlHorizontally(this.lblRoll);
            this.CenterControlHorizontally(this.lblResult);
        }

        /// <summary>
        /// Centers a control horizontally in its parent
        /// </summary>
        /// <param name="control">The control to center</param>
        private void CenterControlHorizontally(Control control) {
            // Re-flow
            control.Update();

            // Calculate horizontal center
            int x = (control.Parent.Width - control.Width) / 2;
            int y = control.Location.Y;

            control.Location = new Point(x, y);
        }

        private void btnRollDice_Click(object sender, EventArgs e) {
            // Logic deferred to animation tick

            // Prepare for animation
            animationCounter = 0;

            tmrAnimation.Start();

            this.btnRollDice.Enabled = false;
        }

        private void btnCancelGame_Click(object sender, EventArgs e) {
            // Cache points
            int playerPoints = SnakeEyesGame.GetPlayersPoints();
            int housePoints = SnakeEyesGame.GetHousePoints();

            // Calculate appropriate message
            string message = "It was a draw!";

            if (playerPoints > housePoints) {
                message = "You won! Well done.";
            } else if (housePoints > playerPoints) {
                message = "House won! Better luck next time.";
            }

            MessageBox.Show(message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }

        private void btnContinuePlaying_Click(object sender, EventArgs e) {
            this.btnRollDice.Enabled = true;
            this.btnContinuePlaying.Visible = false;

            this.lblRoll.Text = "First Roll";
            this.lblResult.Visible = false;

            this.CenterControlHorizontally(this.lblRoll);
        }

        private void tmrAnimation_Tick(object sender, EventArgs e) {
            // Display true result after one second
            if (animationCounter >= ONE_SECOND) {
                this.btnRollDice.Enabled = true;

                // Run the type of roll required
                if (this.firstRoll) {
                    this.firstRoll = !SnakeEyesGame.FirstRoll();
                } else {
                    this.firstRoll = !SnakeEyesGame.AnotherRoll();
                }

                this.UpdateDisplay(false);

                if (this.firstRoll) {
                    this.btnRollDice.Enabled = false;
                    this.btnContinuePlaying.Enabled = true;
                    this.btnContinuePlaying.Visible = true;
                }

                tmrAnimation.Stop();

                return;
            }

            // DateTime.UtcNow.Ticks is a measure of nanoseconds, so values between are different.
            // Makes for slightly more realistic die rolls
            this.imgDie1.Image = Images.GetDieImage(((int)DateTime.UtcNow.Ticks % DIE_RNG_MAX) + 1);
            this.imgDie2.Image = Images.GetDieImage(((int)DateTime.UtcNow.Ticks % DIE_RNG_MAX) + 1);

            // Update animationCounter with how many seconds it has been
            animationCounter += (double)tmrAnimation.Interval / 1000.0f;
        }
    }
}
