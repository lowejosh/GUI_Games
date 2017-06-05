using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Games_Logic_Library;
using Low_Level_Objects_Library;

namespace Games_Logic_Library {
    public static class Solitaire_Game {
        // Class variables
        private static CardPile drawPile;
        private static CardPile discardPile;
        private static Hand[] tableauPiles;
        private static CardPile[] suitPiles;

        // Constants
        public const int NUM_OF_TABLES = 7;

        public static void SetUpGame() {
            // Set vars
            drawPile = new CardPile(true);
            tableauPiles = new Hand[NUM_OF_TABLES];
            
            // Initialise hands
            for (int i = 0; i < NUM_OF_TABLES; i++) {
                tableauPiles[i] = new Hand();
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



                // Debugging
                for (int ii = 0; ii < i + 1; ii++) {
                    Console.Write(ii);
                    if (ii == i) {
                        Console.Write("\n");
                    }
                }
            }
        }

        public static Hand GetTableauPiles(int tableNo) {
            return tableauPiles[tableNo];
        }

    }
}
