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
    public partial class Which_Card_Game : Form {
        public Which_Card_Game() {
            InitializeComponent();
            CardGameComboBox.Items.Add("Solitaire");
            CardGameComboBox.Items.Add("Twenty-One");
        }

        private void CardGameComboBox_SelectedIndexChanged(object sender, EventArgs e) {
            if (CardGameComboBox.SelectedIndex == 0) {
                this.Hide();
                Solitaire_Form GameForm = new Solitaire_Form();
                GameForm.Closed += (s, args) => this.Close();
                GameForm.Show();
            } else if (CardGameComboBox.SelectedIndex == 1) {
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
