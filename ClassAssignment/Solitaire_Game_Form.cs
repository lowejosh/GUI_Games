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
                        // Increment the amount of cards visible
                        Solitaire_Game.IncrementNumberOfCardsVisible(selectedPos);
                        // Move the card to the new hand
                        Solitaire_Game.MoveCardTo(clickedHand);
                        // If the selected position isn't the discard pile
                        if (Solitaire_Game.GetSelectedPos() < 8) {
                            // If the initially selected hand already has multiple cards visible, decrement it 
                            Console.WriteLine("selectedPos = " + selectedPos);
                            if (Solitaire_Game.GetNumberOfCardsVisible(Solitaire_Game.GetSelectedPos()) > 1) {
                                Solitaire_Game.DecrementNumberOfCardsVisible(Solitaire_Game.GetSelectedPos());
                            }
                        }
                        // Update the GUI
                        UpdateGUI();
                        UpdateCardPileGUI();
                        UpdateSuitPileGUI();
                    } else {
                        // If the move is invalid
                        MessageBox.Show("Move not allowed - Cannot place card onto this card");
                        if (Solitaire_Game.GetSelectedPos() == 8) {
                            // Put the cards back in the discard pile
                            for (int i = 0; i < clickedHand.GetCount(); i++) {
                                Solitaire_Game.GetDiscardPile().Add(clickedHand.GetCard(i));
                                clickedHand.RemoveAt(i);
                            }
                        }
                        UpdateCardPileGUI();
                    Solitaire_Game.ClearSelected();
                    }
                }
            }
        }

        private void drawPilePicture_Click(object sender, EventArgs e) {
            // Clear any selected cards for less confusion
            Solitaire_Game.ClearSelected();

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
            } else {
                discardPilePicture.Image = null;
            }
        }// End UpdateCardPileGUI

        private void UpdateSuitPileGUI() {
            for (int i = 0; i < Solitaire_Game.NUM_OF_SUIT_PILES; i++) {
                if (Solitaire_Game.GetSuitPiles(i).GetCount() != 0) {
                    suitPiles[i].Image = Images.GetCardImage(Solitaire_Game.GetSuitPiles(i).GetLastCardInPile());
                } else {
                    suitPiles[i].Image = null;
                }
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

        private void suitPilePicture1_Click(object sender, EventArgs e) {
            if (Solitaire_Game.GetSelected() != null) {
                // Set clicked hand
                CardPile clickedPile = Solitaire_Game.GetSuitPiles(0);

                // If selected hand isn't empty
                if (Solitaire_Game.GetSelected().GetCount() != 0) {
                    // Check if the move is valid
                    if (Solitaire_Game.ValidateSuitMove(clickedPile)) {
                        Solitaire_Game.MoveCardToSuit(clickedPile);
                        // If the selected position isn't the discard pile
                        if (Solitaire_Game.GetSelectedPos() < 8) {
                            // If the initially selected hand already has multiple cards visible, decrement it 
                            if (Solitaire_Game.GetNumberOfCardsVisible(Solitaire_Game.GetSelectedPos()) > 1) {
                                Solitaire_Game.DecrementNumberOfCardsVisible(Solitaire_Game.GetSelectedPos());
                            }
                        }
                        // Update the GUI
                        UpdateGUI();
                        UpdateSuitPileGUI();
                    } else {
                        MessageBox.Show("Move not allowed - Cannot place this card onto this pile");
                        Solitaire_Game.MoveCardToSuit(clickedPile);
                        if (Solitaire_Game.GetSelectedPos() == 8) {
                            // Put the cards back in the discard pile
                            // Store pile so we can remove the last card
                            Hand temp = new Hand();
                            for (int i = 0; i < clickedPile.GetCount() - 1; i++) {
                                temp.Add(clickedPile.DealOneCard());
                            }

                            // Remove the last card 
                            Card c = clickedPile.DealOneCard();

                            // Add cards back into the discard pile
                            for (int i = 0; i < temp.GetCount(); i++) {
                                clickedPile.Add(temp.GetCard(i));
                                temp.RemoveAt(i);
                            }

                            // Move card to another temporary hand
                            Hand clickedHand = Solitaire_Game.CreateHand(c);

                            Solitaire_Game.GetDiscardPile().Add(c);
                        }
                        UpdateCardPileGUI();
                        Solitaire_Game.ClearSelected();
                    }
                    Solitaire_Game.ClearSelected();
                }
            }
        }

        private void suitPilePicture2_Click(object sender, EventArgs e) {
            if (Solitaire_Game.GetSelected() != null) {
                // Set clicked hand
                CardPile clickedPile = Solitaire_Game.GetSuitPiles(1);

                // If selected hand isn't empty
                if (Solitaire_Game.GetSelected().GetCount() != 0) {
                    // Check if the move is valid
                    if (Solitaire_Game.ValidateSuitMove(clickedPile)) {
                        Solitaire_Game.MoveCardToSuit(clickedPile);
                        // If the selected position isn't the discard pile
                        if (Solitaire_Game.GetSelectedPos() < 8) {
                            // If the initially selected hand already has multiple cards visible, decrement it 
                            if (Solitaire_Game.GetNumberOfCardsVisible(Solitaire_Game.GetSelectedPos()) > 1) {
                                Solitaire_Game.DecrementNumberOfCardsVisible(Solitaire_Game.GetSelectedPos());
                            }
                        }
                        // Update the GUI
                        UpdateGUI();
                        UpdateSuitPileGUI();
                    } else {
                        MessageBox.Show("Move not allowed - Cannot place this card onto this pile");
                        Solitaire_Game.MoveCardToSuit(clickedPile);
                        if (Solitaire_Game.GetSelectedPos() == 8) {
                            // Put the cards back in the discard pile
                            // Store pile so we can remove the last card
                            Hand temp = new Hand();
                            for (int i = 0; i < clickedPile.GetCount() - 1; i++) {
                                temp.Add(clickedPile.DealOneCard());
                            }

                            // Remove the last card 
                            Card c = clickedPile.DealOneCard();

                            // Add cards back into the discard pile
                            for (int i = 0; i < temp.GetCount(); i++) {
                                clickedPile.Add(temp.GetCard(i));
                                temp.RemoveAt(i);
                            }

                            // Move card to another temporary hand
                            Hand clickedHand = Solitaire_Game.CreateHand(c);

                            Solitaire_Game.GetDiscardPile().Add(c);
                        }
                        UpdateCardPileGUI();
                        Solitaire_Game.ClearSelected();
                    }
                    Solitaire_Game.ClearSelected();
                }
            }
        }

        private void suitPilePicture3_Click(object sender, EventArgs e) {
            if (Solitaire_Game.GetSelected() != null) {
                // Set clicked hand
                CardPile clickedPile = Solitaire_Game.GetSuitPiles(2);

                // If selected hand isn't empty
                if (Solitaire_Game.GetSelected().GetCount() != 0) {
                    // Check if the move is valid
                    if (Solitaire_Game.ValidateSuitMove(clickedPile)) {
                        Solitaire_Game.MoveCardToSuit(clickedPile);
                        // If the selected position isn't the discard pile
                        if (Solitaire_Game.GetSelectedPos() < 8) {
                            // If the initially selected hand already has multiple cards visible, decrement it 
                            if (Solitaire_Game.GetNumberOfCardsVisible(Solitaire_Game.GetSelectedPos()) > 1) {
                                Solitaire_Game.DecrementNumberOfCardsVisible(Solitaire_Game.GetSelectedPos());
                            }
                        }
                        // Update the GUI
                        UpdateGUI();
                        UpdateSuitPileGUI();
                    } else {
                        MessageBox.Show("Move not allowed - Cannot place this card onto this pile");
                        Solitaire_Game.MoveCardToSuit(clickedPile);
                        if (Solitaire_Game.GetSelectedPos() == 8) {
                            // Put the cards back in the discard pile
                            // Store pile so we can remove the last card
                            Hand temp = new Hand();
                            for (int i = 0; i < clickedPile.GetCount() - 1; i++) {
                                temp.Add(clickedPile.DealOneCard());
                            }

                            // Remove the last card 
                            Card c = clickedPile.DealOneCard();

                            // Add cards back into the discard pile
                            for (int i = 0; i < temp.GetCount(); i++) {
                                clickedPile.Add(temp.GetCard(i));
                                temp.RemoveAt(i);
                            }

                            // Move card to another temporary hand
                            Hand clickedHand = Solitaire_Game.CreateHand(c);

                            Solitaire_Game.GetDiscardPile().Add(c);
                        }
                        UpdateCardPileGUI();
                        Solitaire_Game.ClearSelected();
                    }
                    Solitaire_Game.ClearSelected();
                }
            }
        }

        private void suitPilePicture4_Click(object sender, EventArgs e) {
            if (Solitaire_Game.GetSelected() != null) {
                // Set clicked hand
                CardPile clickedPile = Solitaire_Game.GetSuitPiles(3);

                // If selected hand isn't empty
                if (Solitaire_Game.GetSelected().GetCount() != 0) {
                    // Check if the move is valid
                    if (Solitaire_Game.ValidateSuitMove(clickedPile)) {
                        Solitaire_Game.MoveCardToSuit(clickedPile);
                        // If the selected position isn't the discard pile
                        if (Solitaire_Game.GetSelectedPos() < 8) {
                            // If the initially selected hand already has multiple cards visible, decrement it 
                            if (Solitaire_Game.GetNumberOfCardsVisible(Solitaire_Game.GetSelectedPos()) > 1) {
                                Solitaire_Game.DecrementNumberOfCardsVisible(Solitaire_Game.GetSelectedPos());
                            }
                        }
                        // Update the GUI
                        UpdateGUI();
                        UpdateSuitPileGUI();
                    } else {
                        MessageBox.Show("Move not allowed - Cannot place this card onto this pile");
                        Solitaire_Game.MoveCardToSuit(clickedPile);
                        if (Solitaire_Game.GetSelectedPos() == 8) {
                            // Put the cards back in the discard pile
                            // Store pile so we can remove the last card
                            Hand temp = new Hand();
                            for (int i = 0; i < clickedPile.GetCount() - 1; i++) {
                                temp.Add(clickedPile.DealOneCard());
                            }

                            // Remove the last card 
                            Card c = clickedPile.DealOneCard();

                            // Add cards back into the discard pile
                            for (int i = 0; i < temp.GetCount(); i++) {
                                clickedPile.Add(temp.GetCard(i));
                                temp.RemoveAt(i);
                            }

                            // Move card to another temporary hand
                            Hand clickedHand = Solitaire_Game.CreateHand(c);

                            Solitaire_Game.GetDiscardPile().Add(c);
                        }
                        UpdateCardPileGUI();
                        Solitaire_Game.ClearSelected();
                    }
                    Solitaire_Game.ClearSelected();
                }
            }
        }

        
        private void discardPilePicture_Click(object sender, EventArgs e) {

            // If discard pile isn't empty
            //if (discardPilePicture.Image != null) {
            if (Solitaire_Game.GetDiscardPile().GetCount() != 0) { 
                // Make the card pile easier to read
                CardPile clickedPile = Solitaire_Game.GetDiscardPile();

                // Store pile so we can remove the last card
                Hand temp = new Hand();
                for (int i = 0; i < clickedPile.GetCount() - 1; i++) {
                    temp.Add(clickedPile.DealOneCard());
                }

                // Remove the last card 
                Card c = clickedPile.DealOneCard();

                // Add cards back into the discard pile
                for (int i = 0; i < temp.GetCount(); i++) {
                    clickedPile.Add(temp.GetCard(i));
                    temp.RemoveAt(i);
                }
                
                // Move card to another temporary hand
                Hand clickedHand = Solitaire_Game.CreateHand(c);

                // If selected hand is null
                if (Solitaire_Game.GetSelected() == null) {
                    // Special selected pos
                    selectedPos = 8;
                    // Set the clicked hand as selected
                    Solitaire_Game.SetSelected(clickedHand, selectedPos);
                } else {
                    MessageBox.Show("Move not allowed - Cannot place card onto Discard Pile");
                    Solitaire_Game.ClearSelected();
                }
            }
        }
    }
}
