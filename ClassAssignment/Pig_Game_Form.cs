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
    public partial class Pig_Game_Form : Form {

        public Pig_Game_Form() {
            InitializeComponent();
            Pig_Single_Die_Game.SetUpGame();
            UpdateDieImage();
        }

        void UpdateDieImage() {
            DiePictureBox.Image = Images.GetDieImage(Pig_Single_Die_Game.GetFaceValue());
        }

        private void RollButton_Click(object sender, EventArgs e) {
            Pig_Single_Die_Game.PlayGame();
            UpdateDieImage();
            Player1TotalTextBox.Text = Pig_Single_Die_Game.GetPointsTotal("Player 1").ToString();
            Player2TotalTextBox.Text = Pig_Single_Die_Game.GetPointsTotal("Player 2").ToString();
        }


    }
}
