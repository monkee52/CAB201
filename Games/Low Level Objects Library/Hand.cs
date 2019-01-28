using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections;

namespace Low_Level_Objects_Library {
    /// <summary>
    /// Represents a collection of cards
    /// </summary>
    public class Hand : IEnumerable {
        private List<Card> hand;

        // *************************
        // * TRIVIAL METHODS BELOW *
        // *************************

        public Hand() {
            this.hand = new List<Card>();
        }

        public Hand(List<Card> cards) {
            this.hand = new List<Card>(cards);
        }

        public int GetCount() {
            return this.hand.Count;
        }

        public Card GetCard(int index) {
            return this.hand[index];
        }

        public void Add(Card card) {
            this.hand.Add(card);
        }

        public bool Contains(Card card) {
            return this.hand.Contains(card);
        }

        public bool Remove(Card card) {
            return this.hand.Remove(card);
        }

        public void RemoveAt(int index) {
            this.hand.RemoveAt(index);
        }

        public void Sort() {
            this.hand.Sort();
        }

        public IEnumerator GetEnumerator() {
            return this.hand.GetEnumerator();
        }
    }
}
