namespace ClassAssignment {
    partial class diceMenu {
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
            this.selectDiceGameGroup = new System.Windows.Forms.GroupBox();
            this.twoPigRadio = new System.Windows.Forms.RadioButton();
            this.singlePigRadio = new System.Windows.Forms.RadioButton();
            this.exitButton = new System.Windows.Forms.Button();
            this.selectDiceGameGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // selectDiceGameGroup
            // 
            this.selectDiceGameGroup.Controls.Add(this.twoPigRadio);
            this.selectDiceGameGroup.Controls.Add(this.singlePigRadio);
            this.selectDiceGameGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectDiceGameGroup.Location = new System.Drawing.Point(12, 21);
            this.selectDiceGameGroup.Name = "selectDiceGameGroup";
            this.selectDiceGameGroup.Size = new System.Drawing.Size(200, 100);
            this.selectDiceGameGroup.TabIndex = 0;
            this.selectDiceGameGroup.TabStop = false;
            this.selectDiceGameGroup.Text = "Select which Pig to play";
            // 
            // twoPigRadio
            // 
            this.twoPigRadio.AutoSize = true;
            this.twoPigRadio.Location = new System.Drawing.Point(7, 65);
            this.twoPigRadio.Name = "twoPigRadio";
            this.twoPigRadio.Size = new System.Drawing.Size(101, 17);
            this.twoPigRadio.TabIndex = 1;
            this.twoPigRadio.Text = "Two Dice Pig";
            this.twoPigRadio.UseVisualStyleBackColor = true;
            this.twoPigRadio.CheckedChanged += new System.EventHandler(this.TwoPigRadio_CheckedChanged);
            // 
            // singlePigRadio
            // 
            this.singlePigRadio.AutoSize = true;
            this.singlePigRadio.Location = new System.Drawing.Point(7, 29);
            this.singlePigRadio.Name = "singlePigRadio";
            this.singlePigRadio.Size = new System.Drawing.Size(105, 17);
            this.singlePigRadio.TabIndex = 0;
            this.singlePigRadio.Text = "Single Die Pig";
            this.singlePigRadio.UseVisualStyleBackColor = true;
            this.singlePigRadio.CheckedChanged += new System.EventHandler(this.SinglePigRadio_CheckedChanged);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(69, 140);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "EXIT";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // diceMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(226, 187);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.selectDiceGameGroup);
            this.Name = "diceMenu";
            this.Text = "Dice Games";
            this.selectDiceGameGroup.ResumeLayout(false);
            this.selectDiceGameGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox selectDiceGameGroup;
        private System.Windows.Forms.RadioButton twoPigRadio;
        private System.Windows.Forms.RadioButton singlePigRadio;
        private System.Windows.Forms.Button exitButton;
    }
}