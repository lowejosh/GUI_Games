using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassAssignment {
    /// <summary>
    /// Contains the GUI and logic necessary to determine which card game the user wishes to play
    /// </summary>
    public partial class Which_Card_Game : Form {
        public Which_Card_Game() {
            InitializeComponent();
            cardGameComboBox.Items.Add("Solitaire");
            cardGameComboBox.Items.Add("Twenty-One");
        }

        private void CardGameComboBox_SelectedIndexChanged(object sender, EventArgs e) {
            if (cardGameComboBox.SelectedIndex == 0) {
                this.Hide();
                Solitaire_Game_Form GameForm = new Solitaire_Game_Form();
                GameForm.Closed += (s, args) => this.Close();
                GameForm.Show();
            } else if (cardGameComboBox.SelectedIndex == 1) {
                this.Hide();
                TwentyOne_Game_Form GameForm = new TwentyOne_Game_Form();
                GameForm.Closed += (s, args) => this.Close();
                GameForm.Show();
            } else {
                MessageBox.Show("An error has occured");
            } 
        }

        private void ExitButton_Click(object sender, EventArgs e) {
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
