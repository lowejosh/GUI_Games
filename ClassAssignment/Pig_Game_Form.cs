using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Games_Logic_Library;

namespace ClassAssignment {
    /// <summary>
    /// Displays the form GUI for the Pig Game and makes use of the logic implemented in the Pig Single Die Game class for further interaction
    /// </summary>
    public partial class Pig_Game_Form : Form {

        public Pig_Game_Form() {
            InitializeComponent();
            Pig_Single_Die_Game.SetUpGame();
            UpdateFormInfo();
        }

        /// <summary>
        /// Helper function to update the properties of the form in accordance with gameplay values
        /// </summary>
        void UpdateFormInfo() {
            diePictureBox.Image = Images.GetDieImage(Pig_Single_Die_Game.GetFaceValue());           // Set the image to the die value
            player1TotalTextBox.Text = Pig_Single_Die_Game.GetPointsTotal("Player 1").ToString();   // Set the Player 1 points label to player 1's points
            player2TotalTextBox.Text = Pig_Single_Die_Game.GetPointsTotal("Player 2").ToString();   // Set the Player 2 points label to player 2's points

            textLine1.Text = Pig_Single_Die_Game.GetCurrentPlayer();                                // Set the information text's first line to the player name
            textLine2.Text = (holdButton.Enabled) ? "Roll or Hold" : "Roll Die";                    // Set the information text's second line to the player's available action
        }


        private void RollButton_Click(object sender, EventArgs e) {
            holdButton.Enabled = true; // Enabled the hold button once a die has been thrown
            if (Pig_Single_Die_Game.PlayGame()) { // If a 1 has been thrown
                holdButton.Enabled = false;       // Disable the hold button
                UpdateFormInfo();
                MessageBox.Show("Sorry you have thrown a 1.\nYour turn is over!\nYour score reverts to " + Pig_Single_Die_Game.GetPointsTotal(Pig_Single_Die_Game.GetNextPlayersName()));
            } else {
                UpdateFormInfo();
                if (Pig_Single_Die_Game.HasWon()) { // If a player has won the game
                    MessageBox.Show(Pig_Single_Die_Game.GetCurrentPlayer() + " has won!\nWell done.");
                    // Disable gameplay buttons until the user makes a choice whether to play again
                    rollButton.Enabled = false;     
                    holdButton.Enabled = false;
                    // Enable the user to make a choice whether to play again
                    anotherGameGroup.Enabled = true;
                }
            }
        }


        private void HoldButton_Click(object sender, EventArgs e) {
            Pig_Single_Die_Game.SetCurrentPlayer(Pig_Single_Die_Game.GetNextPlayersName());     // Move to next player
            holdButton.Enabled = false;
            UpdateFormInfo();
        }


        private void YesRadio_CheckedChanged(object sender, EventArgs e) {
            Pig_Single_Die_Game.SetUpGame();        // Reset the game
            rollButton.Enabled = true;              // Enable the roll button again
            anotherGameGroup.Enabled = false;       // Disable the play again choice
            UpdateFormInfo();
            yesRadio.Checked = false;
        }


        private void NoRadio_CheckedChanged(object sender, EventArgs e) {
            DialogResult result = MessageBox.Show("Do you really want to quit?", "Quit?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes) {
                this.Hide();
                Initial_Menu GameForm = new Initial_Menu();
                GameForm.Closed += (s, args) => this.Close();
                GameForm.Show();
            }
        }
    }
}
