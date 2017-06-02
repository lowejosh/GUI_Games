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
            this.WhichCardGameLabel = new System.Windows.Forms.Label();
            this.CardGameComboBox = new System.Windows.Forms.ComboBox();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // WhichCardGameLabel
            // 
            this.WhichCardGameLabel.AutoSize = true;
            this.WhichCardGameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WhichCardGameLabel.Location = new System.Drawing.Point(26, 39);
            this.WhichCardGameLabel.Name = "WhichCardGameLabel";
            this.WhichCardGameLabel.Size = new System.Drawing.Size(227, 24);
            this.WhichCardGameLabel.TabIndex = 0;
            this.WhichCardGameLabel.Text = "Choose a Game to play";
            // 
            // CardGameComboBox
            // 
            this.CardGameComboBox.FormattingEnabled = true;
            this.CardGameComboBox.Location = new System.Drawing.Point(75, 75);
            this.CardGameComboBox.Name = "CardGameComboBox";
            this.CardGameComboBox.Size = new System.Drawing.Size(121, 21);
            this.CardGameComboBox.TabIndex = 1;
            this.CardGameComboBox.SelectedIndexChanged += new System.EventHandler(this.CardGameComboBox_SelectedIndexChanged);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(97, 144);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 46);
            this.ExitButton.TabIndex = 2;
            this.ExitButton.Text = "EXIT";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // Which_Card_Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 251);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.CardGameComboBox);
            this.Controls.Add(this.WhichCardGameLabel);
            this.Name = "Which_Card_Game";
            this.Text = "Card Games";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WhichCardGameLabel;
        private System.Windows.Forms.ComboBox CardGameComboBox;
        private System.Windows.Forms.Button ExitButton;
    }
}