using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Low_Level_Objects_Library;

namespace Games_Logic_Library {
    public static class Pig_Single_Die_Game {
        // Initialise class variables
        static Die die;                
        static int faceValue;         
        static int[] pointsTotal;
        static string[] playersName;

        // Variable for current player
        public static string currentPlayer;


        public static void SetUpGame() {
            // Initialise die object
            die = new Die();

            // Initialise points and player name array
            pointsTotal = new int[] { 0, 0 };
            playersName = new string[] { "Player 1", "Player 2" };

            // Set the current player
            currentPlayer = GetFirstPlayersName();
        }


        public static bool PlayGame() {
            // Roll the die and update the face value
            die.RollDie();
            faceValue = GetFaceValue();
            
            if (faceValue == 1) {   // If player rolls a 1
                currentPlayer = GetNextPlayersName();
                return true; 
            } else {
                // Update the current player's score
                if (currentPlayer == playersName[0]) {  // If player 1
                    pointsTotal[0] += faceValue;        // Update player 1's score
                    return false;
                } else {
                    pointsTotal[1] += faceValue;        // If player 2
                    return false;                       // Update player 2's score
                }
            }
        }


        public static bool HasWon() {
            return (pointsTotal[0] == 30 || pointsTotal[1] == 30) ? true : false; // Only return true when points for either player has reached the winning amount
        }


        public static string GetFirstPlayersName() {
            // Generate a random number between 0 and 1 
            Random rnd = new Random();
            int randomPlayer = rnd.Next(1);

            // Return a random player's name
            return playersName[randomPlayer];
        }


        public static string GetNextPlayersName() {
            return (currentPlayer == playersName[0]) ? playersName[1] : playersName[0]; // Return the next player's name depending on the value of currentPlayer 
        }


        public static int GetPointsTotal(string nameOfPlayer) {
            return (nameOfPlayer == playersName[0]) ? pointsTotal[0] : pointsTotal[1]; // Returns the player's points depending on the value of nameOfPlayer
        }


        public static int GetFaceValue() {
            return die.GetFaceValue(); // Returns the value derived from a method in the die object
        }
    }
}
