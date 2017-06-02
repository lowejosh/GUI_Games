namespace ClassAssignment {
    partial class DiceMenu {
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
            this.SelectDiceGameGroup = new System.Windows.Forms.GroupBox();
            this.TwoPigRadio = new System.Windows.Forms.RadioButton();
            this.SinglePigRadio = new System.Windows.Forms.RadioButton();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SelectDiceGameGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // SelectDiceGameGroup
            // 
            this.SelectDiceGameGroup.Controls.Add(this.TwoPigRadio);
            this.SelectDiceGameGroup.Controls.Add(this.SinglePigRadio);
            this.SelectDiceGameGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectDiceGameGroup.Location = new System.Drawing.Point(12, 21);
            this.SelectDiceGameGroup.Name = "SelectDiceGameGroup";
            this.SelectDiceGameGroup.Size = new System.Drawing.Size(200, 100);
            this.SelectDiceGameGroup.TabIndex = 0;
            this.SelectDiceGameGroup.TabStop = false;
            this.SelectDiceGameGroup.Text = "Select which Pig to play";
            // 
            // TwoPigRadio
            // 
            this.TwoPigRadio.AutoSize = true;
            this.TwoPigRadio.Location = new System.Drawing.Point(7, 65);
            this.TwoPigRadio.Name = "TwoPigRadio";
            this.TwoPigRadio.Size = new System.Drawing.Size(101, 17);
            this.TwoPigRadio.TabIndex = 1;
            this.TwoPigRadio.Text = "Two Dice Pig";
            this.TwoPigRadio.UseVisualStyleBackColor = true;
            this.TwoPigRadio.CheckedChanged += new System.EventHandler(this.TwoPigRadio_CheckedChanged);
            // 
            // SinglePigRadio
            // 
            this.SinglePigRadio.AutoSize = true;
            this.SinglePigRadio.Location = new System.Drawing.Point(7, 29);
            this.SinglePigRadio.Name = "SinglePigRadio";
            this.SinglePigRadio.Size = new System.Drawing.Size(105, 17);
            this.SinglePigRadio.TabIndex = 0;
            this.SinglePigRadio.Text = "Single Die Pig";
            this.SinglePigRadio.UseVisualStyleBackColor = true;
            this.SinglePigRadio.CheckedChanged += new System.EventHandler(this.SinglePigRadio_CheckedChanged);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(69, 140);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 1;
            this.ExitButton.Text = "EXIT";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // DiceMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(226, 187);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.SelectDiceGameGroup);
            this.Name = "DiceMenu";
            this.Text = "Dice Games";
            this.SelectDiceGameGroup.ResumeLayout(false);
            this.SelectDiceGameGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox SelectDiceGameGroup;
        private System.Windows.Forms.RadioButton TwoPigRadio;
        private System.Windows.Forms.RadioButton SinglePigRadio;
        private System.Windows.Forms.Button ExitButton;
    }
}