namespace ClassAssignment {
    partial class TwentyOne_Game_Form {
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
            this.dealerTable = new System.Windows.Forms.TableLayoutPanel();
            this.playerTable = new System.Windows.Forms.TableLayoutPanel();
            this.dealButton = new System.Windows.Forms.Button();
            this.hitButton = new System.Windows.Forms.Button();
            this.standButton = new System.Windows.Forms.Button();
            this.cancelGameButton = new System.Windows.Forms.Button();
            this.dealerBustedLabel = new System.Windows.Forms.Label();
            this.dealerLabel = new System.Windows.Forms.Label();
            this.dealerPointsLabel = new System.Windows.Forms.Label();
            this.dealerGamesWonLabel = new System.Windows.Forms.Label();
            this.dealerGamesWonCountLabel = new System.Windows.Forms.Label();
            this.playerBustedLabel = new System.Windows.Forms.Label();
            this.playerLabel = new System.Windows.Forms.Label();
            this.playerPointsLabel = new System.Windows.Forms.Label();
            this.playerGamesWonLabel = new System.Windows.Forms.Label();
            this.playerGamesWonCountLabel = new System.Windows.Forms.Label();
            this.acesTextLabel = new System.Windows.Forms.Label();
            this.aceCountLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dealerTable
            // 
            this.dealerTable.ColumnCount = 8;
            this.dealerTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.dealerTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.dealerTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.dealerTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.dealerTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.dealerTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.dealerTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.dealerTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.dealerTable.Location = new System.Drawing.Point(12, 89);
            this.dealerTable.Name = "dealerTable";
            this.dealerTable.RowCount = 1;
            this.dealerTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.dealerTable.Size = new System.Drawing.Size(580, 98);
            this.dealerTable.TabIndex = 0;
            // 
            // playerTable
            // 
            this.playerTable.ColumnCount = 8;
            this.playerTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.playerTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.playerTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.playerTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.playerTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.playerTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.playerTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.playerTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.playerTable.Location = new System.Drawing.Point(12, 218);
            this.playerTable.Name = "playerTable";
            this.playerTable.RowCount = 1;
            this.playerTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.playerTable.Size = new System.Drawing.Size(580, 103);
            this.playerTable.TabIndex = 1;
            // 
            // dealButton
            // 
            this.dealButton.Location = new System.Drawing.Point(37, 373);
            this.dealButton.Name = "dealButton";
            this.dealButton.Size = new System.Drawing.Size(75, 23);
            this.dealButton.TabIndex = 2;
            this.dealButton.Text = "Deal";
            this.dealButton.UseVisualStyleBackColor = true;
            this.dealButton.Click += new System.EventHandler(this.DealButton_Click);
            // 
            // hitButton
            // 
            this.hitButton.Enabled = false;
            this.hitButton.Location = new System.Drawing.Point(134, 373);
            this.hitButton.Name = "hitButton";
            this.hitButton.Size = new System.Drawing.Size(75, 23);
            this.hitButton.TabIndex = 3;
            this.hitButton.Text = "Hit";
            this.hitButton.UseVisualStyleBackColor = true;
            this.hitButton.Click += new System.EventHandler(this.HitButton_Click);
            // 
            // standButton
            // 
            this.standButton.Enabled = false;
            this.standButton.Location = new System.Drawing.Point(230, 373);
            this.standButton.Name = "standButton";
            this.standButton.Size = new System.Drawing.Size(75, 23);
            this.standButton.TabIndex = 4;
            this.standButton.Text = "Stand";
            this.standButton.UseVisualStyleBackColor = true;
            this.standButton.Click += new System.EventHandler(this.StandButton_Click);
            // 
            // cancelGameButton
            // 
            this.cancelGameButton.Location = new System.Drawing.Point(345, 373);
            this.cancelGameButton.Name = "cancelGameButton";
            this.cancelGameButton.Size = new System.Drawing.Size(75, 23);
            this.cancelGameButton.TabIndex = 5;
            this.cancelGameButton.Text = "Cancel";
            this.cancelGameButton.UseVisualStyleBackColor = true;
            this.cancelGameButton.Click += new System.EventHandler(this.CancelGameButton_Click);
            // 
            // dealerBustedLabel
            // 
            this.dealerBustedLabel.AutoSize = true;
            this.dealerBustedLabel.BackColor = System.Drawing.Color.Transparent;
            this.dealerBustedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dealerBustedLabel.ForeColor = System.Drawing.Color.Red;
            this.dealerBustedLabel.Location = new System.Drawing.Point(85, 30);
            this.dealerBustedLabel.Name = "dealerBustedLabel";
            this.dealerBustedLabel.Size = new System.Drawing.Size(97, 25);
            this.dealerBustedLabel.TabIndex = 7;
            this.dealerBustedLabel.Text = "BUSTED";
            this.dealerBustedLabel.Visible = false;
            // 
            // dealerLabel
            // 
            this.dealerLabel.AutoSize = true;
            this.dealerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dealerLabel.Location = new System.Drawing.Point(188, 31);
            this.dealerLabel.Name = "dealerLabel";
            this.dealerLabel.Size = new System.Drawing.Size(71, 24);
            this.dealerLabel.TabIndex = 8;
            this.dealerLabel.Text = "Dealer";
            // 
            // dealerPointsLabel
            // 
            this.dealerPointsLabel.AutoSize = true;
            this.dealerPointsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dealerPointsLabel.Location = new System.Drawing.Point(265, 31);
            this.dealerPointsLabel.Name = "dealerPointsLabel";
            this.dealerPointsLabel.Size = new System.Drawing.Size(79, 24);
            this.dealerPointsLabel.TabIndex = 9;
            this.dealerPointsLabel.Text = "POINTS";
            this.dealerPointsLabel.Visible = false;
            // 
            // dealerGamesWonLabel
            // 
            this.dealerGamesWonLabel.AutoSize = true;
            this.dealerGamesWonLabel.Location = new System.Drawing.Point(399, 39);
            this.dealerGamesWonLabel.Name = "dealerGamesWonLabel";
            this.dealerGamesWonLabel.Size = new System.Drawing.Size(63, 13);
            this.dealerGamesWonLabel.TabIndex = 10;
            this.dealerGamesWonLabel.Text = "Games won";
            // 
            // dealerGamesWonCountLabel
            // 
            this.dealerGamesWonCountLabel.AutoSize = true;
            this.dealerGamesWonCountLabel.BackColor = System.Drawing.Color.White;
            this.dealerGamesWonCountLabel.Location = new System.Drawing.Point(468, 39);
            this.dealerGamesWonCountLabel.Name = "dealerGamesWonCountLabel";
            this.dealerGamesWonCountLabel.Size = new System.Drawing.Size(13, 13);
            this.dealerGamesWonCountLabel.TabIndex = 11;
            this.dealerGamesWonCountLabel.Text = "0";
            // 
            // playerBustedLabel
            // 
            this.playerBustedLabel.AutoSize = true;
            this.playerBustedLabel.BackColor = System.Drawing.Color.Transparent;
            this.playerBustedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerBustedLabel.ForeColor = System.Drawing.Color.Red;
            this.playerBustedLabel.Location = new System.Drawing.Point(85, 324);
            this.playerBustedLabel.Name = "playerBustedLabel";
            this.playerBustedLabel.Size = new System.Drawing.Size(97, 25);
            this.playerBustedLabel.TabIndex = 12;
            this.playerBustedLabel.Text = "BUSTED";
            this.playerBustedLabel.Visible = false;
            // 
            // playerLabel
            // 
            this.playerLabel.AutoSize = true;
            this.playerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerLabel.Location = new System.Drawing.Point(191, 325);
            this.playerLabel.Name = "playerLabel";
            this.playerLabel.Size = new System.Drawing.Size(68, 24);
            this.playerLabel.TabIndex = 13;
            this.playerLabel.Text = "Player";
            // 
            // playerPointsLabel
            // 
            this.playerPointsLabel.AutoSize = true;
            this.playerPointsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerPointsLabel.Location = new System.Drawing.Point(265, 325);
            this.playerPointsLabel.Name = "playerPointsLabel";
            this.playerPointsLabel.Size = new System.Drawing.Size(79, 24);
            this.playerPointsLabel.TabIndex = 14;
            this.playerPointsLabel.Text = "POINTS";
            this.playerPointsLabel.Visible = false;
            // 
            // playerGamesWonLabel
            // 
            this.playerGamesWonLabel.AutoSize = true;
            this.playerGamesWonLabel.Location = new System.Drawing.Point(399, 333);
            this.playerGamesWonLabel.Name = "playerGamesWonLabel";
            this.playerGamesWonLabel.Size = new System.Drawing.Size(63, 13);
            this.playerGamesWonLabel.TabIndex = 15;
            this.playerGamesWonLabel.Text = "Games won";
            // 
            // playerGamesWonCountLabel
            // 
            this.playerGamesWonCountLabel.AutoSize = true;
            this.playerGamesWonCountLabel.BackColor = System.Drawing.Color.White;
            this.playerGamesWonCountLabel.Location = new System.Drawing.Point(468, 333);
            this.playerGamesWonCountLabel.Name = "playerGamesWonCountLabel";
            this.playerGamesWonCountLabel.Size = new System.Drawing.Size(13, 13);
            this.playerGamesWonCountLabel.TabIndex = 16;
            this.playerGamesWonCountLabel.Text = "0";
            // 
            // acesTextLabel
            // 
            this.acesTextLabel.AutoSize = true;
            this.acesTextLabel.Location = new System.Drawing.Point(214, 353);
            this.acesTextLabel.Name = "acesTextLabel";
            this.acesTextLabel.Size = new System.Drawing.Size(91, 13);
            this.acesTextLabel.TabIndex = 17;
            this.acesTextLabel.Text = "Aces with value 1";
            // 
            // aceCountLabel
            // 
            this.aceCountLabel.AutoSize = true;
            this.aceCountLabel.BackColor = System.Drawing.Color.White;
            this.aceCountLabel.Location = new System.Drawing.Point(196, 353);
            this.aceCountLabel.Name = "aceCountLabel";
            this.aceCountLabel.Size = new System.Drawing.Size(13, 13);
            this.aceCountLabel.TabIndex = 18;
            this.aceCountLabel.Text = "0";
            // 
            // TwentyOne_Game_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 421);
            this.Controls.Add(this.aceCountLabel);
            this.Controls.Add(this.acesTextLabel);
            this.Controls.Add(this.playerGamesWonCountLabel);
            this.Controls.Add(this.playerGamesWonLabel);
            this.Controls.Add(this.playerPointsLabel);
            this.Controls.Add(this.playerLabel);
            this.Controls.Add(this.playerBustedLabel);
            this.Controls.Add(this.dealerGamesWonCountLabel);
            this.Controls.Add(this.dealerGamesWonLabel);
            this.Controls.Add(this.dealerPointsLabel);
            this.Controls.Add(this.dealerLabel);
            this.Controls.Add(this.dealerBustedLabel);
            this.Controls.Add(this.cancelGameButton);
            this.Controls.Add(this.standButton);
            this.Controls.Add(this.hitButton);
            this.Controls.Add(this.dealButton);
            this.Controls.Add(this.playerTable);
            this.Controls.Add(this.dealerTable);
            this.Name = "TwentyOne_Game_Form";
            this.Text = "Twenty One Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel dealerTable;
        private System.Windows.Forms.TableLayoutPanel playerTable;
        private System.Windows.Forms.Button dealButton;
        private System.Windows.Forms.Button hitButton;
        private System.Windows.Forms.Button standButton;
        private System.Windows.Forms.Button cancelGameButton;
        private System.Windows.Forms.Label dealerBustedLabel;
        private System.Windows.Forms.Label dealerLabel;
        private System.Windows.Forms.Label dealerPointsLabel;
        private System.Windows.Forms.Label dealerGamesWonLabel;
        private System.Windows.Forms.Label dealerGamesWonCountLabel;
        private System.Windows.Forms.Label playerBustedLabel;
        private System.Windows.Forms.Label playerLabel;
        private System.Windows.Forms.Label playerPointsLabel;
        private System.Windows.Forms.Label playerGamesWonLabel;
        private System.Windows.Forms.Label playerGamesWonCountLabel;
        private System.Windows.Forms.Label acesTextLabel;
        private System.Windows.Forms.Label aceCountLabel;
    }
}