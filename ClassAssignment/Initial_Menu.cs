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
    /// Contains the GUI initialization and logic for the intial menu to be shown in the project.
    /// Author: Joshua Lowe
    /// Student Number: n9745734
    /// </summary>
    public partial class Initial_Menu : Form {
        public Initial_Menu() {
            InitializeComponent();
        }

        private void DiceRadio_CheckedChanged(object sender, EventArgs e) {
            startButton.Enabled = true;
        }

        private void CardRadio_CheckedChanged(object sender, EventArgs e) {
            startButton.Enabled = true;
        }

        private void StartButton_Click(object sender, EventArgs e) {
            if (diceRadio.Checked) {
                this.Hide();
                diceMenu GameForm = new diceMenu();
                GameForm.Closed += (s, args) => this.Close();
                GameForm.Show();
            } else if (cardRadio.Checked) {
                this.Hide();
                Which_Card_Game GameForm = new Which_Card_Game();
                GameForm.Closed += (s, args) => this.Close();
                GameForm.Show();
            } else {
                MessageBox.Show("An error has occured");
            }
        }

        private void ExitButton_Click(object sender, EventArgs e) {
            DialogResult result = MessageBox.Show("Do you really want to quit?", "Quit?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes) {
                Environment.Exit(0);
            }
        }
    }
}
