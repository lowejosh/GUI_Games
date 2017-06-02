using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Low_Level_Objects_Library;

namespace Games_Logic_Library {
    public static class TwentyOneGame {
        // Initialise cardPile 
        private static CardPile cardPile = new CardPile(true);

        // Initialise class variables
        private static Hand[] hands;
        private static int[] totalPoints = new int[] { 0, 0 };
        private static int[] numOfGamesWon = new int[] { 0, 0 };
        private static int numOfUserAcesWithValueOne;
        
        public static void SetUpGame() {
            // Initialise dealer and player hands
            Hand pHand = new Hand();
            Hand dHand = new Hand();
            hands = new Hand[2] { pHand, dHand };
            cardPile.Shuffle();
        }

        public static Card DealOneCardTo(int who) {
            // TODO empty card deck

            // Deal one card and add it to the player's hand
            Card c = cardPile.DealOneCard();
            hands[who].Add(c);
            return c;
        }

        public static int CalculateHandTotal(int who) {
            int total = 0;
            int aceCount = 0;

            // For each card in the hand, grab the facevalue
            foreach (Card c in hands[who]) {
                FaceValue fVal = c.GetFaceValue();
                if (fVal == FaceValue.Jack || fVal == FaceValue.Queen || fVal == FaceValue.King) {
                    // Add 10 points for 10 points cards 
                    total += 10;
                } else if (fVal == FaceValue.Ace) {
                    // Add 1 if the ace count hasn't reached the number of aces with value 1 
                    total += (aceCount < numOfUserAcesWithValueOne) ? 1 : 11;
                    aceCount++;
                } else {
                    // Cast enum to integer to grab the index value, then add 2 to normalise it
                    total += (int)fVal + 2;
                }
            }

            // If anyone busts, increment the number of games won
            if (total > 21) {
                if (who != 0) {
                    numOfGamesWon[0]++;
                } else {
                    numOfGamesWon[1]++;
                }
            }

            return total;
        }// End CalculateHandTotal


        public static void PlayForDealer() {
            // Set total points to current hand
            totalPoints[1] = CalculateHandTotal(1);

            // Before the dealer can stand after reaching 17, keep dealing cards and recalculating
            while (totalPoints[1] < 17) {
                DealOneCardTo(1);
                totalPoints[1] = CalculateHandTotal(1);
            }

            // If anyone has won, increment the number of games won
            if (totalPoints[0] < totalPoints[1] && !(totalPoints[0] > 21) && !(totalPoints[1] > 21)) {
                numOfGamesWon[1]++;
            } else if (totalPoints[0] > totalPoints[1] && !(totalPoints[0] > 21) && !(totalPoints[1] > 21)) {
                numOfGamesWon[0]++;
            }
        }


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
            totalPoints[0] = 0;
            totalPoints[1] = 0;
            numOfGamesWon[0] = 0;
            numOfGamesWon[1] = 0;
        }
    }
}
