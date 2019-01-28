using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Low_Level_Objects_Library;

namespace Games_Logic_Library {
    /// <summary>
    /// Implements a majority of the logic required to run a game of Twenty-One
    /// </summary>
    public static class TwentyOneGame {
        public const int NUM_OF_PLAYERS = 2;

        public const int PLAYER_USER = 0;
        public const int PLAYER_CPU = 1;

        // Used to assist in the computer's gambling
        public const int MAX_POINTS = 21;
        public const int STAND_POINTS = 17;
        public const int AGRESSIVE_POINTS = 19;

        // Difference between an Ace with a value of one or eleven
        private const int ACE_ONE_ELEVEN_DIFF = 10;

        // Turn FaceValue enum into a "points" value
        private static readonly Dictionary<FaceValue, int> FACE_VALUES = new Dictionary<FaceValue, int> {
            { FaceValue.Two, 2 },
            { FaceValue.Three, 3 },
            { FaceValue.Four, 4 },
            { FaceValue.Five, 5 },
            { FaceValue.Six, 6 },
            { FaceValue.Seven, 7 },
            { FaceValue.Eight, 8 },
            { FaceValue.Nine, 9 },
            { FaceValue.Ten, 10 },
            { FaceValue.Jack, 10 },
            { FaceValue.Queen, 10 },
            { FaceValue.King, 10 },
            { FaceValue.Ace, 11 }
        };

        private static CardPile cardPile;
        private static Hand[] hands;
        private static int[] totalPoints;
        private static int[] numOfGamesWon = { 0, 0 };
        private static int numOfUserAcesWithValueOne;

        /// <summary>
        /// Prepares the STATIC class for a NEW game of Snake Eyes.
        /// </summary>
        public static void SetUpGame() {
            // Create card pile
            cardPile = new CardPile(true);

            // Create new hands

            hands = new Hand[NUM_OF_PLAYERS] { new Hand(), new Hand() };

            // Reset points values
            totalPoints = new int[NUM_OF_PLAYERS] { 0, 0 };

            numOfUserAcesWithValueOne = 0;

            // Shuffle cards
            cardPile.Shuffle();
        }

        /// <summary>
        /// Deals a card and adds it to the hand
        /// </summary>
        /// <param name="who">Which player</param>
        /// <returns>The dealt card</returns>
        public static Card DealOneCardTo(int who) {
            Card card = cardPile.DealOneCard();

            hands[who].Add(card);

            return card;
        }

        /// <summary>
        /// Calculates a numerical value for each card in the hand and sums it all up
        /// </summary>
        /// <param name="who">Which player</param>
        /// <returns>The total value of a hand</returns>
        public static int CalculateHandTotal(int who) {
            int handTotal = 0;

            // Get raw value for each card, based on lookup
            foreach (Card card in hands[who]) {
                handTotal += FACE_VALUES[card.GetFaceValue()];
            }

            // Handle multi-value aces
            if (who == PLAYER_USER) {
                handTotal -= ACE_ONE_ELEVEN_DIFF * numOfUserAcesWithValueOne;
            }

            // Store
            totalPoints[who] = handTotal;

            return handTotal;
        }

        /// <summary>
        /// Allows the computer to gamble
        /// </summary>
        public static void PlayForDealer() {
            int playerPoints = CalculateHandTotal(PLAYER_USER);
            int cpuPoints = CalculateHandTotal(PLAYER_CPU);

            if (cpuPoints == MAX_POINTS && playerPoints != MAX_POINTS) {
                numOfGamesWon[PLAYER_CPU]++;
                return;
            }

            if (cpuPoints > MAX_POINTS) {
                numOfGamesWon[PLAYER_USER]++;
                return;
            }

            if (playerPoints > MAX_POINTS) {
                numOfGamesWon[PLAYER_CPU]++;
                return;
            }

            if (playerPoints == MAX_POINTS) {
                numOfGamesWon[PLAYER_USER]++;
                return;
            }

            if (cpuPoints > playerPoints) {
                numOfGamesWon[PLAYER_CPU]++;
                return;
            }

            bool keepGoing = true;

            while (keepGoing) {
                cpuPoints = CalculateHandTotal(PLAYER_CPU);
                
                // Determine if the computer should get a card
                if (cpuPoints < STAND_POINTS || playerPoints >= AGRESSIVE_POINTS) {
                    DealOneCardTo(PLAYER_CPU);

                    cpuPoints = CalculateHandTotal(PLAYER_CPU);
                } else {
                    // Break at end of current iteration
                    keepGoing = false;
                }

                // Determine if computer wins or loses
                if (cpuPoints == MAX_POINTS) {
                    numOfGamesWon[PLAYER_CPU]++;
                    break;
                } else if (cpuPoints > MAX_POINTS) {
                    numOfGamesWon[PLAYER_USER]++;
                    break;
                }

                // Calculate if the computer wins due to a greater hand value
                if (cpuPoints > totalPoints[PLAYER_USER]) {
                    numOfGamesWon[PLAYER_CPU]++;
                    break;
                }
            }

            // Calculates if the player wins due to a greater hand value
            if (totalPoints[PLAYER_USER] > totalPoints[PLAYER_CPU]) {
                numOfGamesWon[PLAYER_USER]++;
            }
        }

        // *************************
        // * TRIVIAL METHODS BELOW *
        // *************************

        public static Hand GetHand(int who) {
            return hands[who];
        }

        public static int GetTotalPoints(int who) {
            return totalPoints[who];
        }

        public static int GetNumOfGamesWon(int who) {
            return numOfGamesWon[who];
        }

        public static int GetNumOfUserAcesWithValueOne() {
            return numOfUserAcesWithValueOne;
        }

        public static void IncrementNumOfUserAcesWithValueOne() {
            numOfUserAcesWithValueOne++;
        }

        public static void ResetTotals() {
            totalPoints[PLAYER_USER] = 0;
            totalPoints[PLAYER_CPU] = 0;
        }
    }
}
