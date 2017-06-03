using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Low_Level_Objects_Library {
    public class Hand : IEnumerable {
        private List<Card> hand = new List<Card>();

        public Hand() {
        }


        public int GetCount() {
            return hand.Count();
        }


        public Hand(List<Card> cList) {
            foreach (Card card in cList) {
                hand.Add(card);
            }
        }


        public Card GetCard(int pos) {
            return hand[pos];
        }


        public void Add(Card c) {
            hand.Add(c);
        }


        public bool Contains(Card c) {
            return hand.Contains(c);
        }


        public bool Remove(Card c) {
            return hand.Remove(c);
        }


        public void RemoveAt(int pos) {
            hand.RemoveAt(pos);
        }


        public void Sort() {
            hand.Sort();
        }


        public IEnumerator GetEnumerator() {
            return hand.GetEnumerator();
        }
    }
}
