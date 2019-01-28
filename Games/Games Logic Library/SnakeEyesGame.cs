using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Low_Level_Objects_Library;

namespace Games_Logic_Library {
    /// <summary>
    /// Implements the majority of logic required to run a game of Snake Eyes.
    /// </summary>
    public static class SnakeEyesGame {
        private static int rollTotal;
        private static int playerTotal;
        private static int houseTotal;
        private static int possiblePoints;

        private static string rollOutcome;

        private static Die[] dice;

        public const string PLAYER_WIN = "Congratulations, you won!";
        public const string HOUSE_WIN = "Sorry, you lost.";
        public const string PLAYER_ROLL_AGAIN = "Roll again.";

        private const int NUM_PLAYERS = 2;

        /// <summary>
        /// Prepares the STATIC class for a NEW game of Snake Eyes.
        /// </summary>
        public static void SetUpGame() {
            rollTotal = 0;
            playerTotal = 0;
            houseTotal = 0;
            possiblePoints = 0;

            // Create die
            dice = new Die[NUM_PLAYERS];

            for (int i = 0; i < dice.Length; i++) {
                dice[i] = new Die();
            }
        }

        /// <summary>
        /// Plays the user's first roll and calculates the outcome.
        /// 
        /// NOTE: Arbitrary numbers based on game rules
        /// </summary>
        /// <returns>A boolean to indicate whether another roll is necessary</returns>
        public static bool FirstRoll() {
            rollTotal = 0;
            possiblePoints = 0;

            // Calculate the total value of both die
            for (int i = 0; i < dice.Length; i++) {
                dice[i].RollDie();

                rollTotal += dice[i].GetFaceValue();
            }

            // "2 (Snake Eyes): player wins and receives 2 points"
            if (rollTotal == 2) {
                possiblePoints = 2;
                playerTotal += possiblePoints;

                rollOutcome = PLAYER_WIN;

                return false;
            }

            // "7 or 11: player wins and the player receives 1 point"
            if (rollTotal == 7 || rollTotal == 11) {
                possiblePoints = 1;
                playerTotal += possiblePoints;

                rollOutcome = PLAYER_WIN;

                return false;
            }

            // "3 or 12: player loses and the House (the computer) receives 2 points"
            if (rollTotal == 3 || rollTotal == 12) {
                possiblePoints = 2;
                houseTotal += possiblePoints;

                rollOutcome = HOUSE_WIN;

                return false;
            }

            // 4, 5, 6, 8, 9, 10: player rolls again
            possiblePoints = rollTotal;

            rollOutcome = PLAYER_ROLL_AGAIN;

            return true;
        }

        /// <summary>
        /// Plays the user's additional rolls and calculates the outcome.
        /// 
        /// NOTE: Arbitrary numbers based on game rules
        /// </summary>
        /// <returns>A boolean to indicate whether another roll is necessary</returns>
        public static bool AnotherRoll() {
            rollTotal = 0;

            // Calculate the total value of both die
            for (int i = 0; i < dice.Length; i++) {
                dice[i].RollDie();

                rollTotal += dice[i].GetFaceValue();
            }

            // Player loses all points if they roll a 7
            if (possiblePoints != 0 && rollTotal == 7) {
                possiblePoints = 2;
                houseTotal += possiblePoints;

                rollOutcome = HOUSE_WIN;

                return false;
            }

            // Player gets all possible points
            if (rollTotal == possiblePoints) {
                playerTotal += possiblePoints;

                rollOutcome = PLAYER_WIN;

                return false;
            }

            rollOutcome = PLAYER_ROLL_AGAIN;

            return true;
        }

        // *************************
        // * TRIVIAL METHODS BELOW *
        // *************************

        public static int GetDiceFaceValue(int whichDie) {
            return dice[whichDie].GetFaceValue();
        }

        public static int GetPlayersPoints() {
            return playerTotal;
        }

        public static int GetHousePoints() {
            return houseTotal;
        }

        public static int GetPossiblePoints() {
            return possiblePoints;
        }

        public static int GetRollTotal() {
            return rollTotal;
        }

        public static string GetRollOutcome() {
            return rollOutcome;
        }
    }
}
