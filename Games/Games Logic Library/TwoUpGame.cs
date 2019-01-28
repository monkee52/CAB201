using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Low_Level_Objects_Library;

namespace Games_Logic_Library {
    /// <summary>
    /// Implements a majority of the logic required to run a game of Two-Up
    /// </summary>
    public static class TwoUpGame {
        private const int COIN_1 = 1;
        private const int COIN_2 = 2;

        private static Coin coin1;
        private static Coin coin2;

        private static int playersScore;
        private static int computersScore;

        /// <summary>
        /// Prepares the STATIC class for a NEW game of Two-Up
        /// </summary>
        public static void SetUpGame() {
            // Create coins
            coin1 = new Coin();
            coin2 = new Coin();

            playersScore = 0;
            computersScore = 0;
        }

        /// <summary>
        /// Flips both coins and calculated the outcome
        /// </summary>
        public static void TossCoins() {
            // Flip coins
            coin1.Flip();
            coin2.Flip();

            // Calculate outcome
            if (coin1.IsHeads() && coin2.IsHeads()) {
                playersScore++;
            } else if (!(coin1.IsHeads() || coin2.IsHeads())) {
                computersScore++;
            }
        }

        /// <summary>
        /// Stringifies the outcome of the coin toss
        /// </summary>
        /// <returns>A string value to represent the outcome of the coin toss</returns>
        public static string TossOutcome() {
            if (coin1.IsHeads() && coin2.IsHeads()) {
                return "Heads";
            } else if (coin1.IsHeads() || coin2.IsHeads()) {
                return "Odds";
            } else {
                return "Tails";
            }
        }

        /// <summary>
        /// Accessor to determine if a coin is heads
        /// </summary>
        /// <param name="whichCoin">Which coin</param>
        /// <returns>Whether the coin selected is heads</returns>
        public static bool IsHeads(int whichCoin) {
            if (whichCoin == COIN_1) {
                return coin1.IsHeads();
            } else if (whichCoin == COIN_2) {
                return coin2.IsHeads();
            }

            throw new ApplicationException("Coin does not exist");
        }

        // *************************
        // * TRIVIAL METHODS BELOW *
        // *************************

        public static int GetPlayersScore() {
            return playersScore;
        }

        public static int GetComputersScore() {
            return computersScore;
        }
    }
}
