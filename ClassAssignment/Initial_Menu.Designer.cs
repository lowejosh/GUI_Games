namespace ClassAssignment {
    partial class Initial_Menu {
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
            this.TitleLabel = new System.Windows.Forms.Label();
            this.gameTypeGroup = new System.Windows.Forms.GroupBox();
            this.cardRadio = new System.Windows.Forms.RadioButton();
            this.diceRadio = new System.Windows.Forms.RadioButton();
            this.startButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.gameTypeGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(20, 28);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(204, 24);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "GUI Game Collection";
            // 
            // gameTypeGroup
            // 
            this.gameTypeGroup.Controls.Add(this.cardRadio);
            this.gameTypeGroup.Controls.Add(this.diceRadio);
            this.gameTypeGroup.Location = new System.Drawing.Point(24, 76);
            this.gameTypeGroup.Name = "gameTypeGroup";
            this.gameTypeGroup.Size = new System.Drawing.Size(200, 100);
            this.gameTypeGroup.TabIndex = 1;
            this.gameTypeGroup.TabStop = false;
            this.gameTypeGroup.Text = "Select Game Type";
            // 
            // cardRadio
            // 
            this.cardRadio.AutoSize = true;
            this.cardRadio.Location = new System.Drawing.Point(17, 63);
            this.cardRadio.Name = "cardRadio";
            this.cardRadio.Size = new System.Drawing.Size(76, 17);
            this.cardRadio.TabIndex = 1;
            this.cardRadio.Text = "Card game";
            this.cardRadio.UseVisualStyleBackColor = true;
            this.cardRadio.CheckedChanged += new System.EventHandler(this.CardRadio_CheckedChanged);
            // 
            // diceRadio
            // 
            this.diceRadio.AutoSize = true;
            this.diceRadio.Location = new System.Drawing.Point(17, 30);
            this.diceRadio.Name = "diceRadio";
            this.diceRadio.Size = new System.Drawing.Size(76, 17);
            this.diceRadio.TabIndex = 0;
            this.diceRadio.Text = "Dice game";
            this.diceRadio.UseVisualStyleBackColor = true;
            this.diceRadio.CheckedChanged += new System.EventHandler(this.DiceRadio_CheckedChanged);
            // 
            // startButton
            // 
            this.startButton.Enabled = false;
            this.startButton.Location = new System.Drawing.Point(72, 206);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 2;
            this.startButton.Text = "START";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(72, 265);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "EXIT";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // Initial_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 323);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.gameTypeGroup);
            this.Controls.Add(this.TitleLabel);
            this.Name = "Initial_Menu";
            this.Text = "Games";
            this.gameTypeGroup.ResumeLayout(false);
            this.gameTypeGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.GroupBox gameTypeGroup;
        private System.Windows.Forms.RadioButton cardRadio;
        private System.Windows.Forms.RadioButton diceRadio;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button exitButton;
    }
}

