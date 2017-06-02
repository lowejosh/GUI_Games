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
            this.GameTypeGroup = new System.Windows.Forms.GroupBox();
            this.CardRadio = new System.Windows.Forms.RadioButton();
            this.DiceRadio = new System.Windows.Forms.RadioButton();
            this.StartButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.GameTypeGroup.SuspendLayout();
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
            // GameTypeGroup
            // 
            this.GameTypeGroup.Controls.Add(this.CardRadio);
            this.GameTypeGroup.Controls.Add(this.DiceRadio);
            this.GameTypeGroup.Location = new System.Drawing.Point(24, 76);
            this.GameTypeGroup.Name = "GameTypeGroup";
            this.GameTypeGroup.Size = new System.Drawing.Size(200, 100);
            this.GameTypeGroup.TabIndex = 1;
            this.GameTypeGroup.TabStop = false;
            this.GameTypeGroup.Text = "Select Game Type";
            // 
            // CardRadio
            // 
            this.CardRadio.AutoSize = true;
            this.CardRadio.Location = new System.Drawing.Point(17, 63);
            this.CardRadio.Name = "CardRadio";
            this.CardRadio.Size = new System.Drawing.Size(76, 17);
            this.CardRadio.TabIndex = 1;
            this.CardRadio.Text = "Card game";
            this.CardRadio.UseVisualStyleBackColor = true;
            this.CardRadio.CheckedChanged += new System.EventHandler(this.CardRadio_CheckedChanged);
            // 
            // DiceRadio
            // 
            this.DiceRadio.AutoSize = true;
            this.DiceRadio.Location = new System.Drawing.Point(17, 30);
            this.DiceRadio.Name = "DiceRadio";
            this.DiceRadio.Size = new System.Drawing.Size(76, 17);
            this.DiceRadio.TabIndex = 0;
            this.DiceRadio.Text = "Dice game";
            this.DiceRadio.UseVisualStyleBackColor = true;
            this.DiceRadio.CheckedChanged += new System.EventHandler(this.DiceRadio_CheckedChanged);
            // 
            // StartButton
            // 
            this.StartButton.Enabled = false;
            this.StartButton.Location = new System.Drawing.Point(72, 206);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(75, 23);
            this.StartButton.TabIndex = 2;
            this.StartButton.Text = "START";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(72, 265);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 3;
            this.ExitButton.Text = "EXIT";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // Initial_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 323);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.GameTypeGroup);
            this.Controls.Add(this.TitleLabel);
            this.Name = "Initial_Menu";
            this.Text = "Games";
            this.GameTypeGroup.ResumeLayout(false);
            this.GameTypeGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.GroupBox GameTypeGroup;
        private System.Windows.Forms.RadioButton CardRadio;
        private System.Windows.Forms.RadioButton DiceRadio;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button ExitButton;
    }
}

