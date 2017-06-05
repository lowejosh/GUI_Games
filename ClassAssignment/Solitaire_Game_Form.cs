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
        }

        private void InitializeForm() {
            // Initialise table array
            playArea = new TableLayoutPanel[Solitaire_Game.NUM_OF_TABLES] { playAreaTable1, playAreaTable2, playAreaTable3, playAreaTable4, playAreaTable5, playAreaTable6, playAreaTable7 };

            // Initialise picturebox group multi-array
            allHands = new PictureBox[Solitaire_Game.NUM_OF_TABLES][];

            // For every table
            for (int i = 0; i < Solitaire_Game.NUM_OF_TABLES; i++) {

                // Initialize another picturebox array
                allHands[i] = new PictureBox[Solitaire_Game.NUM_OF_TABLES];
            }
             
        }

        private void drawPilePicture_Click(object sender, EventArgs e) {
            Solitaire_Game.SetUpGame();
            
            UpdateGUI();
        }

        private void UpdateGUI() {
            for (int i = 0; i < Solitaire_Game.NUM_OF_TABLES; i++) {
                UpdateTable(Solitaire_Game.GetTableauPiles(i), playArea[i]);
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
                if (cardCount == hand.GetCount() - 1) {
                    pictureBox.Image = Images.GetCardImage(card);
                } else {
                    pictureBox.Image = Images.GetBackOfCardImage();
                }
                // Add the PictureBox object to the tableLayoutPanel.
                tableLayoutPanel.Controls.Add(pictureBox);
                cardCount++;
            }
        }
    }
}
