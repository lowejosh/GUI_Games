using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Low_Level_Objects_Library;

namespace Games_Logic_Library {
    public static class Pig_Double_Dice_Game {
        // Initialise dice
        private static Die[] dice = new Die[2] { new Die(), new Die() };

        // Initialise class variables
        private static int[] faceValue;
        private static int[] pointsTotal;
        private static string[] playersName;

        // Additional variables
        private static string currentPlayer;
        private static int currentTurnPoints;

        /// <summary>
        /// Initialises the class variables at the start of a new game
        /// </summary>
        public static void SetUpGame() {
            // Set point values and player name array
            pointsTotal = new int[] { 0, 0 };
            currentTurnPoints = 0;
            playersName = new string[] { "Player 1", "Player 2" };
            faceValue = new int[] { 0, 0 };
            

            // Set the current player
            currentPlayer = GetFirstPlayersName();
        }// End SetUpGame

        /// <summary>
        /// Rolls the die once for the current player, updating the player’s score 
        /// appropriately according to the faceValue just rolled.
        /// </summary>
        /// <returns>Returns true if the player has rolled a “1”, otherwise it returns false.</returns>
        public static bool PlayGame() {

            // Roll the dice and update the face values
            for (int i = 0; i < 2; i++) {
                dice[i].RollDie();
                faceValue[i] = GetFaceValue(i);

                if (faceValue[i] == 1) {   // if player rolls a 1
                    if (currentPlayer == playersName[0]) {
                        pointsTotal[0] -= currentTurnPoints;
                    } else {
                        pointsTotal[1] -= currentTurnPoints;
                    }
                    ResetCurrentTurnPoints();
                    currentPlayer = GetNextPlayersName();
                    return true;
                } else {
                    // update the current player's score
                    if (currentPlayer == playersName[0]) {  // if player 1
                        pointsTotal[0] += faceValue[i];        // update player 1's score
                        currentTurnPoints += faceValue[i];     // update current turn points  
                    } else {
                        pointsTotal[1] += faceValue[i];        // if player 2
                        currentTurnPoints += faceValue[i];     // update current turn points 
                    }
                }
            }            

            // Return if loop completes
            return false;
        }// End PlayGame

        /// <summary>
        /// Shows whether a player has won 
        /// </summary>
        /// <returns>Returns true if a player has won (by reaching 30 points) and returns false if not</returns>
        public static bool HasWon() {
            return (pointsTotal[0] >= 30 || pointsTotal[1] >= 30) ? true : false; // Only return true when points for either player has reached the winning amount
        }// End HasWon

        /// <summary>
        /// Gets the first player's name 
        /// </summary>
        /// <returns>Return the 0th position in the playersName array, Player 1</returns>
        public static string GetFirstPlayersName() {
            // Return player 1's name
            return playersName[0];
        }// End GetFirstPlayersName

        /// <summary>
        /// Gets the next player's name
        /// </summary>
        /// <returns>Returns the opposite player to the current player</returns>
        public static string GetNextPlayersName() {
            return (currentPlayer == playersName[0]) ? playersName[1] : playersName[0]; // Return the next player's name depending on the value of currentPlayer 
        }// End GetNextPlayersName

        /// <summary>
        /// Gets the total points of the desired player 
        /// </summary>
        /// <param name="nameOfPlayer">Name of the player whose points are being returned</param>
        /// <returns>Returns the total points respective to the name of the player inputted</returns>
        public static int GetPointsTotal(string nameOfPlayer) {
            return (nameOfPlayer == playersName[0]) ? pointsTotal[0] : pointsTotal[1];
        }// End GetPoiintsTotal

        /// <summary>
        /// Gets the face value
        /// </summary>
        /// <param name="die">Die which is being evaluated for it's face value</param>
        /// <returns>The face value</returns>
        public static int GetFaceValue(int die) {
            return (die == 0) ? dice[0].GetFaceValue() : dice[1].GetFaceValue();
        }// End GetFaceValue

        /// <summary>
        /// Gets the current player value
        /// </summary>
        /// <returns>returns the currentPlayer variable</returns>
        public static string GetCurrentPlayer() {
            return currentPlayer;
        }// End GetCurrentPlayer

        /// <summary>
        /// Sets the current player variable to a desired value
        /// </summary>
        /// <param name="playerName">Input string paramater to set the currentPlayer value to</param>
        public static void SetCurrentPlayer(string playerName) {
            currentPlayer = playerName;
        }// End SetCurrentPlayer

        /// <summary>
        /// Resets the current turn points
        /// </summary>
        public static void ResetCurrentTurnPoints() {
            currentTurnPoints = 0;
        }// End ResetCurrentTurnPoints
    }
}

