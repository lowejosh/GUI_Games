namespace ClassAssignment {
    partial class Pig_Game_Form {
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
            this.DiePictureBox = new System.Windows.Forms.PictureBox();
            this.RollButton = new System.Windows.Forms.Button();
            this.HoldButton = new System.Windows.Forms.Button();
            this.Player1TotalTextBox = new System.Windows.Forms.TextBox();
            this.Player2TotalTextBox = new System.Windows.Forms.TextBox();
            this.AnotherGameGroup = new System.Windows.Forms.GroupBox();
            this.NoRadio = new System.Windows.Forms.RadioButton();
            this.YesRadio = new System.Windows.Forms.RadioButton();
            this.TextLine1 = new System.Windows.Forms.Label();
            this.Player1TotalLabel = new System.Windows.Forms.Label();
            this.Player2TotalLabel = new System.Windows.Forms.Label();
            this.TextLine2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DiePictureBox)).BeginInit();
            this.AnotherGameGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // DiePictureBox
            // 
            this.DiePictureBox.Location = new System.Drawing.Point(114, 60);
            this.DiePictureBox.Name = "DiePictureBox";
            this.DiePictureBox.Size = new System.Drawing.Size(55, 55);
            this.DiePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DiePictureBox.TabIndex = 0;
            this.DiePictureBox.TabStop = false;
            // 
            // RollButton
            // 
            this.RollButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.RollButton.Location = new System.Drawing.Point(34, 165);
            this.RollButton.Name = "RollButton";
            this.RollButton.Size = new System.Drawing.Size(87, 23);
            this.RollButton.TabIndex = 1;
            this.RollButton.TabStop = false;
            this.RollButton.Text = "Roll";
            this.RollButton.UseVisualStyleBackColor = false;
            this.RollButton.Click += new System.EventHandler(this.RollButton_Click);
            // 
            // HoldButton
            // 
            this.HoldButton.BackColor = System.Drawing.Color.Red;
            this.HoldButton.Enabled = false;
            this.HoldButton.Location = new System.Drawing.Point(143, 165);
            this.HoldButton.Name = "HoldButton";
            this.HoldButton.Size = new System.Drawing.Size(87, 23);
            this.HoldButton.TabIndex = 2;
            this.HoldButton.TabStop = false;
            this.HoldButton.Text = "Hold";
            this.HoldButton.UseVisualStyleBackColor = false;
            this.HoldButton.Click += new System.EventHandler(this.HoldButton_Click);
            // 
            // Player1TotalTextBox
            // 
            this.Player1TotalTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player1TotalTextBox.Location = new System.Drawing.Point(341, 57);
            this.Player1TotalTextBox.Name = "Player1TotalTextBox";
            this.Player1TotalTextBox.ReadOnly = true;
            this.Player1TotalTextBox.Size = new System.Drawing.Size(68, 20);
            this.Player1TotalTextBox.TabIndex = 3;
            this.Player1TotalTextBox.TabStop = false;
            this.Player1TotalTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Player2TotalTextBox
            // 
            this.Player2TotalTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player2TotalTextBox.Location = new System.Drawing.Point(341, 95);
            this.Player2TotalTextBox.Name = "Player2TotalTextBox";
            this.Player2TotalTextBox.ReadOnly = true;
            this.Player2TotalTextBox.Size = new System.Drawing.Size(68, 20);
            this.Player2TotalTextBox.TabIndex = 4;
            this.Player2TotalTextBox.TabStop = false;
            this.Player2TotalTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // AnotherGameGroup
            // 
            this.AnotherGameGroup.Controls.Add(this.NoRadio);
            this.AnotherGameGroup.Controls.Add(this.YesRadio);
            this.AnotherGameGroup.Enabled = false;
            this.AnotherGameGroup.Location = new System.Drawing.Point(267, 152);
            this.AnotherGameGroup.Name = "AnotherGameGroup";
            this.AnotherGameGroup.Size = new System.Drawing.Size(142, 70);
            this.AnotherGameGroup.TabIndex = 5;
            this.AnotherGameGroup.TabStop = false;
            this.AnotherGameGroup.Text = "Another Game?";
            // 
            // NoRadio
            // 
            this.NoRadio.AutoSize = true;
            this.NoRadio.Location = new System.Drawing.Point(8, 42);
            this.NoRadio.Name = "NoRadio";
            this.NoRadio.Size = new System.Drawing.Size(41, 17);
            this.NoRadio.TabIndex = 1;
            this.NoRadio.Text = "No";
            this.NoRadio.UseVisualStyleBackColor = true;
            this.NoRadio.CheckedChanged += new System.EventHandler(this.NoRadio_CheckedChanged);
            // 
            // YesRadio
            // 
            this.YesRadio.AutoSize = true;
            this.YesRadio.Location = new System.Drawing.Point(8, 19);
            this.YesRadio.Name = "YesRadio";
            this.YesRadio.Size = new System.Drawing.Size(46, 17);
            this.YesRadio.TabIndex = 0;
            this.YesRadio.Text = "Yes";
            this.YesRadio.UseVisualStyleBackColor = true;
            this.YesRadio.CheckedChanged += new System.EventHandler(this.YesRadio_CheckedChanged);
            // 
            // TextLine1
            // 
            this.TextLine1.AutoSize = true;
            this.TextLine1.Location = new System.Drawing.Point(12, 73);
            this.TextLine1.Name = "TextLine1";
            this.TextLine1.Size = new System.Drawing.Size(87, 13);
            this.TextLine1.TabIndex = 6;
            this.TextLine1.Text = "Whose turn to";
            // 
            // Player1TotalLabel
            // 
            this.Player1TotalLabel.AutoSize = true;
            this.Player1TotalLabel.Location = new System.Drawing.Point(249, 60);
            this.Player1TotalLabel.Name = "Player1TotalLabel";
            this.Player1TotalLabel.Size = new System.Drawing.Size(86, 13);
            this.Player1TotalLabel.TabIndex = 7;
            this.Player1TotalLabel.Text = "Player 1 Total";
            // 
            // Player2TotalLabel
            // 
            this.Player2TotalLabel.AutoSize = true;
            this.Player2TotalLabel.Location = new System.Drawing.Point(249, 98);
            this.Player2TotalLabel.Name = "Player2TotalLabel";
            this.Player2TotalLabel.Size = new System.Drawing.Size(86, 13);
            this.Player2TotalLabel.TabIndex = 8;
            this.Player2TotalLabel.Text = "Player 2 Total";
            // 
            // TextLine2
            // 
            this.TextLine2.AutoSize = true;
            this.TextLine2.Location = new System.Drawing.Point(12, 95);
            this.TextLine2.Name = "TextLine2";
            this.TextLine2.Size = new System.Drawing.Size(67, 13);
            this.TextLine2.TabIndex = 9;
            this.TextLine2.Text = "roll or hold";
            // 
            // Pig_Game_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 244);
            this.Controls.Add(this.TextLine2);
            this.Controls.Add(this.Player2TotalLabel);
            this.Controls.Add(this.Player1TotalLabel);
            this.Controls.Add(this.TextLine1);
            this.Controls.Add(this.AnotherGameGroup);
            this.Controls.Add(this.Player2TotalTextBox);
            this.Controls.Add(this.Player1TotalTextBox);
            this.Controls.Add(this.HoldButton);
            this.Controls.Add(this.RollButton);
            this.Controls.Add(this.DiePictureBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Pig_Game_Form";
            this.Text = "Pig Game";
            ((System.ComponentModel.ISupportInitialize)(this.DiePictureBox)).EndInit();
            this.AnotherGameGroup.ResumeLayout(false);
            this.AnotherGameGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox DiePictureBox;
        private System.Windows.Forms.Button RollButton;
        private System.Windows.Forms.Button HoldButton;
        private System.Windows.Forms.TextBox Player1TotalTextBox;
        private System.Windows.Forms.TextBox Player2TotalTextBox;
        private System.Windows.Forms.GroupBox AnotherGameGroup;
        private System.Windows.Forms.RadioButton NoRadio;
        private System.Windows.Forms.RadioButton YesRadio;
        private System.Windows.Forms.Label TextLine1;
        private System.Windows.Forms.Label Player1TotalLabel;
        private System.Windows.Forms.Label Player2TotalLabel;
        private System.Windows.Forms.Label TextLine2;
    }
}