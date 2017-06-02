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
            this.DealerTable = new System.Windows.Forms.TableLayoutPanel();
            this.playerTable = new System.Windows.Forms.TableLayoutPanel();
            this.DealButton = new System.Windows.Forms.Button();
            this.HitButton = new System.Windows.Forms.Button();
            this.StandButton = new System.Windows.Forms.Button();
            this.CancelGameButton = new System.Windows.Forms.Button();
            this.dealerBustedLabel = new System.Windows.Forms.Label();
            this.DealerLabel = new System.Windows.Forms.Label();
            this.dealerPointsLabel = new System.Windows.Forms.Label();
            this.DealerGamesWonLabel = new System.Windows.Forms.Label();
            this.DealerGamesWonCountLabel = new System.Windows.Forms.Label();
            this.playerBustedLabel = new System.Windows.Forms.Label();
            this.PlayerLabel = new System.Windows.Forms.Label();
            this.playerPointsLabel = new System.Windows.Forms.Label();
            this.PlayerGamesWonLabel = new System.Windows.Forms.Label();
            this.PlayerGamesWonCountLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DealerTable
            // 
            this.DealerTable.ColumnCount = 8;
            this.DealerTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.DealerTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.DealerTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.DealerTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.DealerTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.DealerTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.DealerTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.DealerTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.DealerTable.Location = new System.Drawing.Point(12, 89);
            this.DealerTable.Name = "DealerTable";
            this.DealerTable.RowCount = 1;
            this.DealerTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.DealerTable.Size = new System.Drawing.Size(580, 98);
            this.DealerTable.TabIndex = 0;
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
            // DealButton
            // 
            this.DealButton.Location = new System.Drawing.Point(37, 373);
            this.DealButton.Name = "DealButton";
            this.DealButton.Size = new System.Drawing.Size(75, 23);
            this.DealButton.TabIndex = 2;
            this.DealButton.Text = "Deal";
            this.DealButton.UseVisualStyleBackColor = true;
            this.DealButton.Click += new System.EventHandler(this.DealButton_Click);
            // 
            // HitButton
            // 
            this.HitButton.Enabled = false;
            this.HitButton.Location = new System.Drawing.Point(134, 373);
            this.HitButton.Name = "HitButton";
            this.HitButton.Size = new System.Drawing.Size(75, 23);
            this.HitButton.TabIndex = 3;
            this.HitButton.Text = "Hit";
            this.HitButton.UseVisualStyleBackColor = true;
            // 
            // StandButton
            // 
            this.StandButton.Enabled = false;
            this.StandButton.Location = new System.Drawing.Point(230, 373);
            this.StandButton.Name = "StandButton";
            this.StandButton.Size = new System.Drawing.Size(75, 23);
            this.StandButton.TabIndex = 4;
            this.StandButton.Text = "Stand";
            this.StandButton.UseVisualStyleBackColor = true;
            // 
            // CancelGameButton
            // 
            this.CancelGameButton.Location = new System.Drawing.Point(345, 373);
            this.CancelGameButton.Name = "CancelGameButton";
            this.CancelGameButton.Size = new System.Drawing.Size(75, 23);
            this.CancelGameButton.TabIndex = 5;
            this.CancelGameButton.Text = "Cancel";
            this.CancelGameButton.UseVisualStyleBackColor = true;
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
            // DealerLabel
            // 
            this.DealerLabel.AutoSize = true;
            this.DealerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DealerLabel.Location = new System.Drawing.Point(188, 31);
            this.DealerLabel.Name = "DealerLabel";
            this.DealerLabel.Size = new System.Drawing.Size(71, 24);
            this.DealerLabel.TabIndex = 8;
            this.DealerLabel.Text = "Dealer";
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
            // DealerGamesWonLabel
            // 
            this.DealerGamesWonLabel.AutoSize = true;
            this.DealerGamesWonLabel.Location = new System.Drawing.Point(399, 39);
            this.DealerGamesWonLabel.Name = "DealerGamesWonLabel";
            this.DealerGamesWonLabel.Size = new System.Drawing.Size(63, 13);
            this.DealerGamesWonLabel.TabIndex = 10;
            this.DealerGamesWonLabel.Text = "Games won";
            // 
            // DealerGamesWonCountLabel
            // 
            this.DealerGamesWonCountLabel.AutoSize = true;
            this.DealerGamesWonCountLabel.BackColor = System.Drawing.Color.White;
            this.DealerGamesWonCountLabel.Location = new System.Drawing.Point(468, 39);
            this.DealerGamesWonCountLabel.Name = "DealerGamesWonCountLabel";
            this.DealerGamesWonCountLabel.Size = new System.Drawing.Size(13, 13);
            this.DealerGamesWonCountLabel.TabIndex = 11;
            this.DealerGamesWonCountLabel.Text = "0";
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
            // PlayerLabel
            // 
            this.PlayerLabel.AutoSize = true;
            this.PlayerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerLabel.Location = new System.Drawing.Point(191, 325);
            this.PlayerLabel.Name = "PlayerLabel";
            this.PlayerLabel.Size = new System.Drawing.Size(68, 24);
            this.PlayerLabel.TabIndex = 13;
            this.PlayerLabel.Text = "Player";
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
            // PlayerGamesWonLabel
            // 
            this.PlayerGamesWonLabel.AutoSize = true;
            this.PlayerGamesWonLabel.Location = new System.Drawing.Point(399, 333);
            this.PlayerGamesWonLabel.Name = "PlayerGamesWonLabel";
            this.PlayerGamesWonLabel.Size = new System.Drawing.Size(63, 13);
            this.PlayerGamesWonLabel.TabIndex = 15;
            this.PlayerGamesWonLabel.Text = "Games won";
            // 
            // PlayerGamesWonCountLabel
            // 
            this.PlayerGamesWonCountLabel.AutoSize = true;
            this.PlayerGamesWonCountLabel.BackColor = System.Drawing.Color.White;
            this.PlayerGamesWonCountLabel.Location = new System.Drawing.Point(468, 333);
            this.PlayerGamesWonCountLabel.Name = "PlayerGamesWonCountLabel";
            this.PlayerGamesWonCountLabel.Size = new System.Drawing.Size(13, 13);
            this.PlayerGamesWonCountLabel.TabIndex = 16;
            this.PlayerGamesWonCountLabel.Text = "0";
            // 
            // TwentyOne_Game_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 421);
            this.Controls.Add(this.PlayerGamesWonCountLabel);
            this.Controls.Add(this.PlayerGamesWonLabel);
            this.Controls.Add(this.playerPointsLabel);
            this.Controls.Add(this.PlayerLabel);
            this.Controls.Add(this.playerBustedLabel);
            this.Controls.Add(this.DealerGamesWonCountLabel);
            this.Controls.Add(this.DealerGamesWonLabel);
            this.Controls.Add(this.dealerPointsLabel);
            this.Controls.Add(this.DealerLabel);
            this.Controls.Add(this.dealerBustedLabel);
            this.Controls.Add(this.CancelGameButton);
            this.Controls.Add(this.StandButton);
            this.Controls.Add(this.HitButton);
            this.Controls.Add(this.DealButton);
            this.Controls.Add(this.playerTable);
            this.Controls.Add(this.DealerTable);
            this.Name = "TwentyOne_Game_Form";
            this.Text = "Twenty One Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel DealerTable;
        private System.Windows.Forms.TableLayoutPanel playerTable;
        private System.Windows.Forms.Button DealButton;
        private System.Windows.Forms.Button HitButton;
        private System.Windows.Forms.Button StandButton;
        private System.Windows.Forms.Button CancelGameButton;
        private System.Windows.Forms.Label dealerBustedLabel;
        private System.Windows.Forms.Label DealerLabel;
        private System.Windows.Forms.Label dealerPointsLabel;
        private System.Windows.Forms.Label DealerGamesWonLabel;
        private System.Windows.Forms.Label DealerGamesWonCountLabel;
        private System.Windows.Forms.Label playerBustedLabel;
        private System.Windows.Forms.Label PlayerLabel;
        private System.Windows.Forms.Label playerPointsLabel;
        private System.Windows.Forms.Label PlayerGamesWonLabel;
        private System.Windows.Forms.Label PlayerGamesWonCountLabel;
    }
}