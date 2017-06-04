namespace ClassAssignment {
    partial class Which_Card_Game {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.whichCardGameLabel = new System.Windows.Forms.Label();
            this.cardGameComboBox = new System.Windows.Forms.ComboBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // whichCardGameLabel
            // 
            this.whichCardGameLabel.AutoSize = true;
            this.whichCardGameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.whichCardGameLabel.Location = new System.Drawing.Point(26, 39);
            this.whichCardGameLabel.Name = "whichCardGameLabel";
            this.whichCardGameLabel.Size = new System.Drawing.Size(227, 24);
            this.whichCardGameLabel.TabIndex = 0;
            this.whichCardGameLabel.Text = "Choose a Game to play";
            // 
            // cardGameComboBox
            // 
            this.cardGameComboBox.FormattingEnabled = true;
            this.cardGameComboBox.Location = new System.Drawing.Point(75, 75);
            this.cardGameComboBox.Name = "cardGameComboBox";
            this.cardGameComboBox.Size = new System.Drawing.Size(121, 21);
            this.cardGameComboBox.TabIndex = 1;
            this.cardGameComboBox.SelectedIndexChanged += new System.EventHandler(this.CardGameComboBox_SelectedIndexChanged);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(97, 144);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 46);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "EXIT";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // Which_Card_Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 251);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.cardGameComboBox);
            this.Controls.Add(this.whichCardGameLabel);
            this.Name = "Which_Card_Game";
            this.Text = "Card Games";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label whichCardGameLabel;
        private System.Windows.Forms.ComboBox cardGameComboBox;
        private System.Windows.Forms.Button exitButton;
    }
}