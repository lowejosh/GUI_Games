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
    public partial class Solitaire_Game_Form : Form {
        // Class variables
        TableLayoutPanel[] playArea;
        PictureBox[][] allHands;

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

            // Initialise picturebox group multi-array
            allHands = new PictureBox[Solitaire_Game.NUM_OF_TABLES][];

        }

        private void pictureBox_Click(object sender, EventArgs e) {
            // Which card was clicked?
            PictureBox clickedPictureBox = (PictureBox)sender;
            // Get a reference to the card
            Card clickedCard = (Card)clickedPictureBox.Tag;

            TryToPlayCard(clickedCard);
        }

        private void TryToPlayCard(Card clickedCard) {
            // Debug 
            MessageBox.Show(clickedCard.ToString(false, true), "Clicked");


        }

        private void drawPilePicture_Click(object sender, EventArgs e) {
            if (Solitaire_Game.GetDrawPile().GetCount() != 0) {
                Solitaire_Game.DrawOneCard();
                UpdateCardPileGUI();
            }
        }

        private void UpdateGUI() {
            // For every table
            for (int i = 0; i < Solitaire_Game.NUM_OF_TABLES; i++) {
                // Update the table GUI
                UpdateTable(Solitaire_Game.GetTableauPiles(i), playArea[i]);
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


        private void UpdateTable(Hand hand, TableLayoutPanel tableLayoutPanel) {
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
                if (cardCount == hand.GetCount() - 1) {
                    // Show the card face up
                    pictureBox.Image = Images.GetCardImage(card);
                    // Set event-handler for click on this PictureBox
                    pictureBox.Click += new EventHandler(pictureBox_Click);
                    // Tell the PictureBox which card object it has the picture of
                    pictureBox.Tag = card;
                } else {
                    // Show the card face down
                    pictureBox.Image = Images.GetBackOfCardImage();
                    pictureBox.Tag = card;
                }
                // Add the PictureBox object to the tableLayoutPanel.
                tableLayoutPanel.Controls.Add(pictureBox);
                cardCount++;
            }
        }
    }
}
