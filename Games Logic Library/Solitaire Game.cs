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
        }// End SetUpGame


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
        }// End MoveCardTo


        /// <summary>
        /// Moves chosen card to selected suit card pile
        /// </summary>
        /// <param name="cp">CardPile: Chosen card pile</param>
        public static void MoveCardToSuit(CardPile cp) {
            // Move the selected card to the card pile chosen
            cp.Add(selectedHand.GetCard(selectedHand.GetCount() - 1));

            // Remove the top card in the selected hand
            selectedHand.RemoveAt(selectedHand.GetCount() - 1);
        }// End NovecardToSuit
        

        /// <summary>
        /// Validates whether the move to a suit is valid
        /// </summary>
        /// <param name="clickedPile"></param>
        /// <returns>bool: true if the move is valid</returns>
        public static bool ValidateSuitMove(CardPile clickedPile) {
            // Set the selected card
            Card c = selectedHand.GetCard(selectedHand.GetCount() - 1);

            // If it is the first card to the suit
            if (clickedPile.GetCount() == 0) {
                if (c.GetFaceValue() == FaceValue.Ace) {
                    return true;
                } else {
                    return false;
                }
            } else {
                // If they are opposite colours
                if (c.GetColour() != clickedPile.GetLastCardInPile().GetColour()) {
                    // If the value of the face is one lmore 
                    if (CalculateValue(c.GetFaceValue()) == CalculateValue(clickedPile.GetLastCardInPile().GetFaceValue()) + 1) {
                        return true;
                    } else {
                        return false;
                    } 
                } else {
                    return false;
                }
            }


        }// End ValidateSuitMove
        

        /// <summary>
        /// Calculates the number value of the inputted face value
        /// </summary>
        /// <param name="fv">FaceValue: Facevalue of the card</param>
        /// <returns>int: Gameplay value of inputted face value</returns>
        public static int CalculateValue(FaceValue fv) {
            if (fv == FaceValue.Queen || fv == FaceValue.King || fv == FaceValue.Jack) {
                return 10;
            } else if (fv == FaceValue.Ace) {
                return 1;
            } else {
                return (int)fv + 2;
            }
        }



        /// <summary>
        /// Checks whether the move from one hand to another is valid
        /// </summary>
        /// <param name="h">Hand: The hand that the selected card is attempting to move to</param>
        /// <returns>bool: True if the move is valid</returns>
        public static bool ValidMove(Hand h) {
            Card sc = selectedHand.GetCard(selectedHand.GetCount() - 1);
            Card c = h.GetCard(h.GetCount() - 1);
            if (sc.GetColour() != c.GetColour()) {
                if (CalculateValue(c.GetFaceValue()) == CalculateValue(sc.GetFaceValue()) + 1) {      
                    return true;
                } else {
                    return false;
                }
            } else {
                return false;
            }
        }// End ValidMove


        /// <summary>
        /// Flips the discard pile back onto the draw pile
        /// </summary>
        public static void FlipDiscardPile() {
            Hand cards = new Hand(discardPile.DealCards(discardPile.GetCount()));
            foreach (Card c in cards) {
                drawPile.Add(c);
            }
        }// End FlipDiscardPile


        /// <summary>
        /// Draws one card from the draw pile
        /// </summary>
        /// <returns>Card: the card that was drawn</returns>
        public static Card DrawOneCard() {
            Card c = drawPile.DealOneCard();
            discardPile.Add(c);
            return c;
        }// End DrawOnecard


        /// <summary>
        /// Creates a single card hand for use in other methods
        /// </summary>
        /// <param name="c">Card: Card to be made into a hand</param>
        /// <returns>Hand: Hand made from input of card</returns>
        public static Hand CreateHand(Card c) {
            Hand h = new Hand();
            h.Add(c);
            return h;
        }// End CreateHand


        /// <summary>
        /// Returns the Hand for the specified table
        /// </summary>
        /// <param name="tableNo">int: table number</param>
        /// <returns>Hand: hand respective to the table number</returns>
        public static Hand GetTableauPiles(int tableNo) {
            return tableauPiles[tableNo];
        }// End GetTableauPiles


        /// <summary>
        /// Returns the suit pile for the specified pile
        /// </summary>
        /// <param name="suitNo">int: index of suit pile</param>
        /// <returns>CardPile: the specified suit pile</returns>
        public static CardPile GetSuitPiles(int suitNo) {
            return suitPiles[suitNo];
        }// End GetSuitPiles


        /// <summary>
        /// Returns the discard pile
        /// </summary>
        /// <returns>CardPile: the discard pile</returns>
        public static CardPile GetDiscardPile() {
            return discardPile;
        }// End GetDiscardPile
        

        /// <summary>
        /// Returns the draw pile
        /// </summary>
        /// <returns>CardPile: the draw pile</returns>
        public static CardPile GetDrawPile() {
            return drawPile;
        }// End GetDrawPile


        /// <summary>
        /// Sets the selected hand and position
        /// </summary>
        /// <param name="h">Hand: Hand that is to be set as selected</param>
        /// <param name="selectedPos">int: Position respective to the selected hand</param>
        public static void SetSelected(Hand h, int selectedPos) {
            selectedHand = h;
            selectedHandPos = selectedPos;
        }// End SetSelected
        

        /// <summary>
        /// Returns the position of the selected hand
        /// </summary>
        /// <returns>int: position of the selected hand</returns>
        public static int GetSelectedPos() {
            return selectedHandPos;
        }// End GetSelectedPos


        /// <summary>
        /// Clears the selection
        /// </summary>
        public static void ClearSelected() {
            selectedHand = null;
        }// End ClearSelected


        /// <summary>
        /// Returns the currently selected card
        /// </summary>
        /// <returns>Card: the selected card</returns>
        public static Hand GetSelected() {
            return selectedHand;
        }// End GetSelected


        /// <summary>
        /// Returns the number of cards visible at the selected table
        /// </summary>
        /// <param name="pos">int: position of the table</param>
        /// <returns>int: number of cards visible at that position</returns>
        public static int GetNumberOfCardsVisible(int pos) {
            return numberOfCardsVisible[pos];
        }// End GetNumberOfCardsVisible

        /// <summary>
        /// Increments the number of cards visible for the specified table position
        /// </summary>
        /// <param name="pos">int: position of the table</param>
        public static void IncrementNumberOfCardsVisible(int pos) {
            numberOfCardsVisible[pos]++;
        }// End IncrementNumberOfCardsVisible


        /// <summary>
        /// Decrements the number of cards visible for the specified table position
        /// </summary>
        /// <param name="pos"></param>
        public static void DecrementNumberOfCardsVisible(int pos) {
            numberOfCardsVisible[pos]--;
        }// End DecrementNumberOfCardsVisible
    }
}
