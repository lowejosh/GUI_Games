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
    /// Contains the GUI and logic necessary to determine which dice game the user wishes to play
    /// </summary>
    public partial class diceMenu : Form {
        public diceMenu() {
            InitializeComponent();
        }

        private void SinglePigRadio_CheckedChanged(object sender, EventArgs e) {
            this.Hide();
            Pig_Game_Form GameForm = new Pig_Game_Form();
            GameForm.Closed += (s, args) => this.Close();
            GameForm.Show();
        }

        private void TwoPigRadio_CheckedChanged(object sender, EventArgs e) {
            this.Hide();
            Pig_with_Two_Dice_Form GameForm = new Pig_with_Two_Dice_Form();
            GameForm.Closed += (s, args) => this.Close();
            GameForm.Show();
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
