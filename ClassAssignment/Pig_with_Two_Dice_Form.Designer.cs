namespace ClassAssignment {
    partial class Pig_with_Two_Dice_Form {
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
            this.components = new System.ComponentModel.Container();
            this.textLine2 = new System.Windows.Forms.Label();
            this.player2TotalLabel = new System.Windows.Forms.Label();
            this.player1TotalLabel = new System.Windows.Forms.Label();
            this.textLine1 = new System.Windows.Forms.Label();
            this.anotherGameGroup = new System.Windows.Forms.GroupBox();
            this.noRadio = new System.Windows.Forms.RadioButton();
            this.yesRadio = new System.Windows.Forms.RadioButton();
            this.player2TotalTextBox = new System.Windows.Forms.TextBox();
            this.player1TotalTextBox = new System.Windows.Forms.TextBox();
            this.holdButton = new System.Windows.Forms.Button();
            this.rollButton = new System.Windows.Forms.Button();
            this.diePictureBox1 = new System.Windows.Forms.PictureBox();
            this.diePictureBox2 = new System.Windows.Forms.PictureBox();
            this.rollTimer = new System.Windows.Forms.Timer(this.components);
            this.anotherGameGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diePictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diePictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // textLine2
            // 
            this.textLine2.AutoSize = true;
            this.textLine2.Location = new System.Drawing.Point(18, 77);
            this.textLine2.Name = "textLine2";
            this.textLine2.Size = new System.Drawing.Size(55, 13);
            this.textLine2.TabIndex = 19;
            this.textLine2.Text = "roll or hold";
            // 
            // player2TotalLabel
            // 
            this.player2TotalLabel.AutoSize = true;
            this.player2TotalLabel.Location = new System.Drawing.Point(255, 80);
            this.player2TotalLabel.Name = "player2TotalLabel";
            this.player2TotalLabel.Size = new System.Drawing.Size(72, 13);
            this.player2TotalLabel.TabIndex = 18;
            this.player2TotalLabel.Text = "Player 2 Total";
            // 
            // player1TotalLabel
            // 
            this.player1TotalLabel.AutoSize = true;
            this.player1TotalLabel.Location = new System.Drawing.Point(255, 42);
            this.player1TotalLabel.Name = "player1TotalLabel";
            this.player1TotalLabel.Size = new System.Drawing.Size(72, 13);
            this.player1TotalLabel.TabIndex = 17;
            this.player1TotalLabel.Text = "Player 1 Total";
            // 
            // textLine1
            // 
            this.textLine1.AutoSize = true;
            this.textLine1.Location = new System.Drawing.Point(18, 55);
            this.textLine1.Name = "textLine1";
            this.textLine1.Size = new System.Drawing.Size(74, 13);
            this.textLine1.TabIndex = 16;
            this.textLine1.Text = "Whose turn to";
            // 
            // anotherGameGroup
            // 
            this.anotherGameGroup.Controls.Add(this.noRadio);
            this.anotherGameGroup.Controls.Add(this.yesRadio);
            this.anotherGameGroup.Enabled = false;
            this.anotherGameGroup.Location = new System.Drawing.Point(273, 134);
            this.anotherGameGroup.Name = "anotherGameGroup";
            this.anotherGameGroup.Size = new System.Drawing.Size(142, 70);
            this.anotherGameGroup.TabIndex = 15;
            this.anotherGameGroup.TabStop = false;
            this.anotherGameGroup.Text = "Another Game?";
            // 
            // noRadio
            // 
            this.noRadio.AutoSize = true;
            this.noRadio.Location = new System.Drawing.Point(8, 42);
            this.noRadio.Name = "noRadio";
            this.noRadio.Size = new System.Drawing.Size(39, 17);
            this.noRadio.TabIndex = 1;
            this.noRadio.Text = "No";
            this.noRadio.UseVisualStyleBackColor = true;
            this.noRadio.CheckedChanged += new System.EventHandler(this.NoRadio_CheckedChanged);
            // 
            // yesRadio
            // 
            this.yesRadio.AutoSize = true;
            this.yesRadio.Location = new System.Drawing.Point(8, 19);
            this.yesRadio.Name = "yesRadio";
            this.yesRadio.Size = new System.Drawing.Size(43, 17);
            this.yesRadio.TabIndex = 0;
            this.yesRadio.Text = "Yes";
            this.yesRadio.UseVisualStyleBackColor = true;
            this.yesRadio.CheckedChanged += new System.EventHandler(this.YesRadio_CheckedChanged);
            // 
            // player2TotalTextBox
            // 
            this.player2TotalTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player2TotalTextBox.Location = new System.Drawing.Point(347, 77);
            this.player2TotalTextBox.Name = "player2TotalTextBox";
            this.player2TotalTextBox.ReadOnly = true;
            this.player2TotalTextBox.Size = new System.Drawing.Size(68, 20);
            this.player2TotalTextBox.TabIndex = 14;
            this.player2TotalTextBox.TabStop = false;
            this.player2TotalTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // player1TotalTextBox
            // 
            this.player1TotalTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player1TotalTextBox.Location = new System.Drawing.Point(347, 39);
            this.player1TotalTextBox.Name = "player1TotalTextBox";
            this.player1TotalTextBox.ReadOnly = true;
            this.player1TotalTextBox.Size = new System.Drawing.Size(68, 20);
            this.player1TotalTextBox.TabIndex = 13;
            this.player1TotalTextBox.TabStop = false;
            this.player1TotalTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // holdButton
            // 
            this.holdButton.BackColor = System.Drawing.Color.Red;
            this.holdButton.Enabled = false;
            this.holdButton.Location = new System.Drawing.Point(149, 147);
            this.holdButton.Name = "holdButton";
            this.holdButton.Size = new System.Drawing.Size(87, 23);
            this.holdButton.TabIndex = 12;
            this.holdButton.TabStop = false;
            this.holdButton.Text = "Hold";
            this.holdButton.UseVisualStyleBackColor = false;
            this.holdButton.Click += new System.EventHandler(this.HoldButton_Click);
            // 
            // rollButton
            // 
            this.rollButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.rollButton.Location = new System.Drawing.Point(40, 147);
            this.rollButton.Name = "rollButton";
            this.rollButton.Size = new System.Drawing.Size(87, 23);
            this.rollButton.TabIndex = 11;
            this.rollButton.TabStop = false;
            this.rollButton.Text = "Roll";
            this.rollButton.UseVisualStyleBackColor = false;
            this.rollButton.Click += new System.EventHandler(this.RollButton_Click);
            // 
            // diePictureBox1
            // 
            this.diePictureBox1.Location = new System.Drawing.Point(98, 42);
            this.diePictureBox1.Name = "diePictureBox1";
            this.diePictureBox1.Size = new System.Drawing.Size(55, 55);
            this.diePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.diePictureBox1.TabIndex = 10;
            this.diePictureBox1.TabStop = false;
            // 
            // diePictureBox2
            // 
            this.diePictureBox2.Location = new System.Drawing.Point(170, 42);
            this.diePictureBox2.Name = "diePictureBox2";
            this.diePictureBox2.Size = new System.Drawing.Size(55, 55);
            this.diePictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.diePictureBox2.TabIndex = 20;
            this.diePictureBox2.TabStop = false;
            // 
            // rollTimer
            // 
            this.rollTimer.Interval = 75;
            this.rollTimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Pig_with_Two_Dice_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 243);
            this.Controls.Add(this.diePictureBox2);
            this.Controls.Add(this.textLine2);
            this.Controls.Add(this.player2TotalLabel);
            this.Controls.Add(this.player1TotalLabel);
            this.Controls.Add(this.textLine1);
            this.Controls.Add(this.anotherGameGroup);
            this.Controls.Add(this.player2TotalTextBox);
            this.Controls.Add(this.player1TotalTextBox);
            this.Controls.Add(this.holdButton);
            this.Controls.Add(this.rollButton);
            this.Controls.Add(this.diePictureBox1);
            this.Name = "Pig_with_Two_Dice_Form";
            this.Text = "Two Dice Pig Game";
            this.anotherGameGroup.ResumeLayout(false);
            this.anotherGameGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diePictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diePictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label textLine2;
        private System.Windows.Forms.Label player2TotalLabel;
        private System.Windows.Forms.Label player1TotalLabel;
        private System.Windows.Forms.Label textLine1;
        private System.Windows.Forms.GroupBox anotherGameGroup;
        private System.Windows.Forms.RadioButton noRadio;
        private System.Windows.Forms.RadioButton yesRadio;
        private System.Windows.Forms.TextBox player2TotalTextBox;
        private System.Windows.Forms.TextBox player1TotalTextBox;
        private System.Windows.Forms.Button holdButton;
        private System.Windows.Forms.Button rollButton;
        private System.Windows.Forms.PictureBox diePictureBox1;
        private System.Windows.Forms.PictureBox diePictureBox2;
        private System.Windows.Forms.Timer rollTimer;
    }
}