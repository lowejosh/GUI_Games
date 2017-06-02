using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Low_Level_Objects_Library;
using Games_Logic_Library;

namespace ClassAssignment {
    public partial class TwentyOne_Game_Form : Form {
        public TwentyOne_Game_Form() {
            InitializeComponent();
            TwentyOne_Game.SetUpGame();

            // Class variables
            TableLayoutPanel[] tableLayoutPanels;
            Label[] bustedLabels;
            Label[] pointsLabels;
            Label[] gamesWonLabels;

            tableLayoutPanels = new TableLayoutPanel[TwentyOne_Game.NUM_OF_PLAYERS] {playerTable, DealerTable};
            bustedLabels = new Label[TwentyOne_Game.NUM_OF_PLAYERS] {playerBustedLabel, dealerBustedLabel};
            pointsLabels = new Label[TwentyOne_Game.NUM_OF_PLAYERS] {playerPointsLabel, dealerPointsLabel};
            gamesWonLabels = new Label[TwentyOne_Game.NUM_OF_PLAYERS] {PlayerGamesWonCountLabel, DealerGamesWonCountLabel};
        }
        

        private void DisplayGuiHand(Hand hand, TableLayoutPanel tableLayoutPanel) {
            tableLayoutPanel.Controls.Clear(); // Remove any cards already being shown.
            foreach (Card card in hand) {
                // Construct a PictureBox object.
                PictureBox pictureBox = new PictureBox();
                // Set the PictureBox to use all of its space
                pictureBox.Dock = DockStyle.Fill;
                // Remove spacing around the PictureBox. (Default is 3 pixels.)
                pictureBox.Margin = new Padding(0);
                pictureBox.Image = Images.GetCardImage(card);
                // Add the PictureBox object to the tableLayoutPanel.
                tableLayoutPanel.Controls.Add(pictureBox);
            }
        }// End DisplayGuiHand

        private void DealButton_Click(object sender, EventArgs e) {
            TwentyOne_Game.SetUpGame();
            
            // Deal cards and then display them
            for (int i = 0; i < 2; i++) {
                TwentyOne_Game.DealOneCardTo(0);    // Deal two cards to player
                TwentyOne_Game.DealOneCardTo(1);    // Deal two cards to dealer
            }
            DisplayGuiHand(TwentyOne_Game.GetHand(0), playerTable);
            DisplayGuiHand(TwentyOne_Game.GetHand(1), playerTable);

            // Update POINTS labels and make them visible
            playerPointsLabel.Text = TwentyOne_Game.CalculateHandTotal(0).ToString();
            playerPointsLabel.Visible = true;
            dealerPointsLabel.Text = TwentyOne_Game.CalculateHandTotal(1).ToString();
            dealerPointsLabel.Visible = true;

            // Enable and disable buttons
            StandButton.Enabled = true;
            HitButton.Enabled = true; 
            DealButton.Enabled = false;
        }
    }
}
