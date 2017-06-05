using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Games_Logic_Library;
using Low_Level_Objects_Library;

namespace Games_Logic_Library {

    /// <summary>
    /// Contains the game logic to be used with the Solitaire_Game_Form class 
    /// </summary>
    public static class Solitaire_Game {
        // Class variables
        private static CardPile drawPile;
        private static CardPile discardPile;
        private static Hand[] tableauPiles;
        private static CardPile[] suitPiles;

        // Currently selected card
        private static Hand selectedHand;
        private static int selectedHandPos;

        // Number of cards visible in a table
        private static int[] numberOfCardsVisible; 

        // Constants
        public const int NUM_OF_TABLES = 7;
        public const int NUM_OF_SUIT_PILES = 4;

        /// <summary>
        /// Sets up the game and initializes class variables
        /// </summary>
        public static void SetUpGame() {
            // Set vars
            drawPile = new CardPile(true);
            discardPile = new CardPile(false);
            tableauPiles = new Hand[NUM_OF_TABLES];
            numberOfCardsVisible = new int[NUM_OF_TABLES];
            suitPiles = new CardPile[NUM_OF_SUIT_PILES];

            
            // Initialise hands and number of cards visible 
            for (int i = 0; i < NUM_OF_TABLES; i++) {
                tableauPiles[i] = new Hand();
                numberOfCardsVisible[i] = 1;
            }
            
            // Initialise suit piles
            for (int i = 0; i < NUM_OF_SUIT_PILES; i++) {
                suitPiles[i] = new CardPile(false);
            } 

            // Shuffle the draw pile a random amount of times
            Random rnd = new Random();
            int randAmount = rnd.Next(1, 10);
            for (int i = 0; i < randAmount; i++) {
                drawPile.Shuffle();
            }

            // For every pile
            for (int i = 0; i < tableauPiles.Length; i++) {
                // For every card necessary in pile
                for (int ii = 0; ii < i + 1; ii++) {
                    // Deal one card from the draw pile
                    tableauPiles[i].Add(drawPile.DealOneCard());
                }
            }
        }


        /// <summary>
        /// Moves a card from one hand to the other
        /// </summary>
        /// <param name="h">Hand: The hand that the selected card is being moved to</param>
        public static void MoveCardTo(Hand h) {
            // Move the selected card to the hand chosen
            h.Add(selectedHand.GetCard(selectedHand.GetCount() - 1));

            // Remove the top card in the selected hand
            selectedHand.RemoveAt(selectedHand.GetCount() - 1);

            // Clears the selection
            ClearSelected();
        }


        /// <summary>
        /// Checks whether the move chosen is valid
        /// </summary>
        /// <param name="h">Hand: The hand that the selected card is attempting to move to</param>
        /// <returns>bool: True if the move is valid</returns>
        public static bool ValidMove(Hand h) {
            Card sc = selectedHand.GetCard(selectedHand.GetCount() - 1);
            Card c = h.GetCard(h.GetCount() - 1);
            if (sc.GetColour() != c.GetColour()) {
                return true;
            } else {
                return false;
            }
        }


        /// <summary>
        /// Flips the discard pile back onto the draw pile
        /// </summary>
        public static void FlipDiscardPile() {
            Hand cards = new Hand(discardPile.DealCards(discardPile.GetCount()));
            foreach (Card c in cards) {
                drawPile.Add(c);
            }
        }


        /// <summary>
        /// Draws one card from the draw pile
        /// </summary>
        /// <returns>Card: the card that was drawn</returns>
        public static Card DrawOneCard() {
            Card c = drawPile.DealOneCard();
            discardPile.Add(c);
            return c;
        }


        /// <summary>
        /// Returns the Hand for the specified table
        /// </summary>
        /// <param name="tableNo">int: table number</param>
        /// <returns>Hand: hand respective to the table number</returns>
        public static Hand GetTableauPiles(int tableNo) {
            return tableauPiles[tableNo];
        }


        /// <summary>
        /// Returns the suit pile for the specified pile
        /// </summary>
        /// <param name="suitNo">int: index of suit pile</param>
        /// <returns>CardPile: the specified suit pile</returns>
        public static CardPile GetSuitPiles(int suitNo) {
            return suitPiles[suitNo];
        }


        /// <summary>
        /// Returns the discard pile
        /// </summary>
        /// <returns>CardPile: the discard pile</returns>
        public static CardPile GetDiscardPile() {
            return discardPile;
        }
        

        /// <summary>
        /// Returns the draw pile
        /// </summary>
        /// <returns>CardPile: the draw pile</returns>
        public static CardPile GetDrawPile() {
            return drawPile;
        }


        /// <summary>
        /// Sets the selected hand and position
        /// </summary>
        /// <param name="h">Hand: Hand that is to be set as selected</param>
        /// <param name="selectedPos">int: Position respective to the selected hand</param>
        public static void SetSelected(Hand h, int selectedPos) {
            selectedHand = h;
            selectedHandPos = selectedPos;
        }
        

        /// <summary>
        /// Returns the position of the selected hand
        /// </summary>
        /// <returns>int: position of the selected hand</returns>
        public static int GetSelectedPos() {
            return selectedHandPos;
        }


        /// <summary>
        /// Clears the selection
        /// </summary>
        public static void ClearSelected() {
            selectedHand = null;
        }


        /// <summary>
        /// Returns the currently selected card
        /// </summary>
        /// <returns>Card: the selected card</returns>
        public static Hand GetSelected() {
            return selectedHand;
        }


        /// <summary>
        /// Returns the number of cards visible at the selected table
        /// </summary>
        /// <param name="pos">int: position of the table</param>
        /// <returns>int: number of cards visible at that position</returns>
        public static int GetNumberOfCardsVisible(int pos) {
            return numberOfCardsVisible[pos];
        }

        /// <summary>
        /// Increments the number of cards visible for the specified table position
        /// </summary>
        /// <param name="pos">int: position of the table</param>
        public static void IncrementNumberOfCardsVisible(int pos) {
            numberOfCardsVisible[pos]++;
        }


        /// <summary>
        /// Decrements the number of cards visible for the specified table position
        /// </summary>
        /// <param name="pos"></param>
        public static void DecrementNumberOfCardsVisible(int pos) {
            numberOfCardsVisible[pos]--;
        }
    }
}
