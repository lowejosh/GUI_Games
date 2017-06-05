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
using Low_Level_Objects_Library;

namespace ClassAssignment {
    /// <summary>
    /// Shows the solitaire game form and makes use of the logic implemented in the Solitiare Game class
    /// </summary>
    public partial class Solitaire_Game_Form : Form {
        // Class variables
        TableLayoutPanel[] playArea;
        PictureBox[] suitPiles;

        // Currently selected table position
        int selectedPos;
       

        public Solitaire_Game_Form() {
            InitializeComponent();
            InitializeForm();
            Solitaire_Game.SetUpGame();
            UpdateGUI();
            UpdateCardPileGUI();
        }

        private void InitializeForm() {
            // Initialise table array
            playArea = new TableLayoutPanel[Solitaire_Game.NUM_OF_TABLES] { playAreaTable1, playAreaTable2, playAreaTable3, playAreaTable4, playAreaTable5, playAreaTable6, playAreaTable7 };
            suitPiles = new PictureBox[Solitaire_Game.NUM_OF_SUIT_PILES] { suitPilePicture1, suitPilePicture2, suitPilePicture3, suitPilePicture4 };
        }

        private void pictureBox_Click(object sender, EventArgs e) {
            // Which table was clicked
            PictureBox clickedPictureBox = (PictureBox)sender;

            // Find the table position
            int tablePos = (int)clickedPictureBox.Tag;
            selectedPos = tablePos;

            // Get a reference to the hand
            Hand clickedHand = Solitaire_Game.GetTableauPiles(tablePos);

            TryToPlayCard(clickedHand);
        }


        private void TryToPlayCard(Hand clickedHand) {
            //Clicked card: card clickedCard = clickedHand.GetCard(clickedHand.GetCount() - 1);

            // If selected hand is null
            if (Solitaire_Game.GetSelected() == null) {
                // Set the clicked hand as selected
                Solitaire_Game.SetSelected(clickedHand, selectedPos);
            } else {
                // If selected hand isn't empty
                if (Solitaire_Game.GetSelected().GetCount() != 0) {
                    // Check if the move is valid
                    if (Solitaire_Game.ValidMove(clickedHand)) {
                        Solitaire_Game.IncrementNumberOfCardsVisible(selectedPos);
                        Solitaire_Game.MoveCardTo(clickedHand);
                        // If the initially selected hand already has multiple cards visible, decrement it 
                        if (Solitaire_Game.GetNumberOfCardsVisible(Solitaire_Game.GetSelectedPos()) > 1) {
                            Solitaire_Game.DecrementNumberOfCardsVisible(Solitaire_Game.GetSelectedPos());
                        }
                        // Update the GUI
                        UpdateGUI();
                    } else {
                        MessageBox.Show("Move not allowed - Cannot place card onto this card");
                        Solitaire_Game.ClearSelected();
                    }
                }
            }


        }

        private void drawPilePicture_Click(object sender, EventArgs e) {
            // If there are cards in the draw pile
            if (Solitaire_Game.GetDrawPile().GetCount() != 0) {
                // Draw a card
                Solitaire_Game.DrawOneCard();
                // Update the card piles
                UpdateCardPileGUI();
            } else {
                // Flip the discard pile into the draw pile
                Solitaire_Game.FlipDiscardPile();
                // Draw a card
                Solitaire_Game.DrawOneCard();
                // Update the card piles
                UpdateCardPileGUI();
            }
        }

        private void UpdateGUI() {
            // For every table
            for (int i = 0; i < Solitaire_Game.NUM_OF_TABLES; i++) {
                // Update the table GUI
                UpdateTable(Solitaire_Game.GetTableauPiles(i), playArea[i], i);
            }
        }

        private void UpdateCardPileGUI() {
            // If there is a card in the draw pile 
            if (Solitaire_Game.GetDrawPile().GetCount() != 0) {
                drawPilePicture.Image = Images.GetBackOfCardImage();
            } else {
                drawPilePicture.Image = null;
            }
            // If there is a card in the discard pile
            if (Solitaire_Game.GetDiscardPile().GetCount() != 0) {
                // Set the picturebox to the last card in the pile
                discardPilePicture.Image = Images.GetCardImage(Solitaire_Game.GetDiscardPile().GetLastCardInPile());
            }

        }


        private void UpdateTable(Hand hand, TableLayoutPanel tableLayoutPanel, int tablePos) {
            tableLayoutPanel.Controls.Clear(); // Remove any cards already being shown.
            int cardCount = 0;

            foreach (Card card in hand) {
                // Construct a PictureBox object.
                PictureBox pictureBox = new PictureBox();
                // Set the PictureBox to use all of its space
                pictureBox.Dock = DockStyle.Fill;
                // Set picturebox size mode
                pictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
                // Remove spacing around the PictureBox. (Default is 3 pixels.)
                pictureBox.Margin = new Padding(0);
                // If the card if the last card of the hand
                if (cardCount >= hand.GetCount() - Solitaire_Game.GetNumberOfCardsVisible(tablePos)) {
                    Console.WriteLine(tablePos + " | " + Solitaire_Game.GetNumberOfCardsVisible(tablePos));
                    // Show the card face up
                    pictureBox.Image = Images.GetCardImage(card);
                    // Set event-handler for click on this PictureBox
                    pictureBox.Click += new EventHandler(pictureBox_Click);
                    // Tell the PictureBox which card object it has the picture of
                    pictureBox.Tag = tablePos;
                } else {
                    // Show the card face down
                    pictureBox.Image = Images.GetBackOfCardImage();
                    pictureBox.Tag = tablePos;
                }
                // Add the PictureBox object to the tableLayoutPanel.
                tableLayoutPanel.Controls.Add(pictureBox);
                cardCount++;
            }
        }
    }
}
