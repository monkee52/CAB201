using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Low_Level_Objects_Library;

namespace Games_Logic_Library {
    /// <summary>
    /// Represents the logic required to run a game of Crazy Eights
    /// </summary>
    public class CrazyEightsGame {
        public enum Player {
            Computer,
            User
        }

        public const int NUM_PLAYERS = 2;

        private const int INITIAL_DEALT = 8;
        private const int MAX_HAND_SIZE = 13;

        private Dictionary<Player, Hand> hands;
        private bool stalemate;

        private CardPile deck;
        private List<Card> discarded;

        private Card topCard;
        private Suit? topCardSuit;
        private bool firstRun;

        public CrazyEightsGame() {
            // Create decks
            this.deck = new CardPile(true);
            this.discarded = new List<Card>();

            this.deck.Shuffle();

            this.topCard = this.deck.DealOneCard();

            // Create player hands
            this.hands = new Dictionary<Player, Hand>();

            foreach (Player player in Enum.GetValues(typeof(Player))) {
                this.hands[player] = new Hand();

                // Deal initial 8 cards
                this.deck.DealCards(INITIAL_DEALT).ForEach((Card card) => this.hands[player].Add(card));
            }

            firstRun = true;
            stalemate = false;
        }

        /// <summary>
        /// Determines if based on the current state of the game, a provided card can be played
        /// </summary>
        /// <param name="card">The card</param>
        /// <returns>If the card is playable</returns>
        public bool IsCardPlayable(Card card) {
            if (this.topCard.GetFaceValue() == FaceValue.Eight && firstRun) {
                return true;
            }

            if (this.topCard.GetFaceValue() == card.GetFaceValue()) {
                return true;
            }

            if (this.GetTopCardSuit() == card.GetSuit()) {
                return true;
            }

            if (card.GetFaceValue() == FaceValue.Eight) {
                return true;
            }

            return false;
        }
        
        /// <summary>
        /// Determines if any card in a player's hand can be played
        /// </summary>
        /// <param name="player">The player</param>
        /// <returns>If a playable card is found</returns>
        private bool IsHandPlayable(Player player) {
            foreach (Card card in this.hands[player]) {
                if (this.IsCardPlayable(card)) {
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Determines if the player can be dealt a new card
        /// </summary>
        /// <param name="player">The player</param>
        /// <returns>If the player can be dealt a new card</returns>
        public bool HandCanFitNewCard(Player player) {
            return this.hands[player].GetCount() < MAX_HAND_SIZE;
        }

        /// <summary>
        /// Deals a new card to a player
        /// </summary>
        /// <param name="player">The player</param>
        public void DealCard(Player player) {
            if (this.deck.GetCount() == 0) {
                this.discarded.ForEach((Card card) => this.deck.Add(card));
            }

            this.hands[player].Add(this.deck.DealOneCard());
        }

        /// <summary>
        /// Determines the winner
        /// </summary>
        /// <returns>The player who won, otherwise null to indicate a draw</returns>
        public Player? GetWinner() {
            if (this.hands[Player.Computer].GetCount() == 0) {
                return Player.Computer;
            }

            if (this.hands[Player.User].GetCount() == 0) {
                return Player.User;
            }

            return null;
        }

        public enum PlayabilityState {
            None,
            DealCard,
            PlayCard
        }

        /// <summary>
        /// Determines the initial action the user can take
        /// </summary>
        /// <returns>Which action</returns>
        public PlayabilityState GetPlayabilityState(Player player) {
            if (this.IsHandPlayable(player)) {
                return PlayabilityState.PlayCard;
            }

            if (this.HandCanFitNewCard(player)) {
                return PlayabilityState.DealCard;
            }

            stalemate = true;

            return PlayabilityState.None;
        }

        /// <summary>
        /// Plays a user-selected card
        /// </summary>
        /// <param name="card">The card</param>
        /// <param name="suit">The suit if face value is eight</param>
        /// <returns>Whether the user must pick a new suit</returns>
        public bool PlayCard(Player player, Card card, Suit? suit = null) {
            if (card.GetFaceValue() == FaceValue.Eight) {
                if (suit == null) {
                    return true;
                }

                this.topCardSuit = suit;
            }

            this.discarded.Insert(0, this.topCard);
            this.topCard = card;

            this.hands[player].Remove(card);

            this.firstRun = false;

            return false;
        }

        /// <summary>
        /// Plays a round as the computer
        /// </summary>
        /// <returns>If the game is over</returns>
        public bool PlayForComputer() {
            // A hand is empty
            if (this.GetWinner() != null) {
                return true;
            }

            // Determine if computer can play
            PlayabilityState state = this.GetPlayabilityState(Player.Computer);

            // Stalemate, game over
            if (state == PlayabilityState.None && this.stalemate) {
                return true;
            }

            // Deal a card
            if (state == PlayabilityState.DealCard) {
                this.DealCard(Player.Computer);

                return false;
            }

            // Fitler to most appropriate cards
            List<Card> cards = new List<Card>();

            foreach (Card card in this.hands[Player.Computer]) {
                if (this.IsCardPlayable(card)) {
                    cards.Add(card);
                }
            }

            // Find the proper suit for the top card
            Suit suit = this.GetTopCardSuit();

            // Find the most appropriate of the bunch

            // Same face value
            Card selectedCard = cards.FirstOrDefault((Card card) => card.GetFaceValue() == this.topCard.GetFaceValue());

            // Same suit
            if (selectedCard == null) {
                selectedCard = cards.FirstOrDefault((Card card) => card.GetSuit() == suit);
            }

            // Face value = 8
            if (selectedCard == null) {
                selectedCard = cards.FirstOrDefault((Card card) => card.GetFaceValue() == FaceValue.Eight);
            }

            this.PlayCard(Player.Computer, selectedCard, selectedCard.GetSuit());

            this.topCardSuit = null;

            return false;
        }

        // *************************
        // * TRIVIAL METHODS BELOW *
        // *************************

        public Hand GetPlayerHand(Player player) {
            return this.hands[player];
        }

        public Card GetTopCard() {
            return this.topCard;
        }

        public Suit GetTopCardSuit() {
            return this.topCardSuit != null ? (Suit)this.topCardSuit : this.topCard.GetSuit();
        }
    }
}
