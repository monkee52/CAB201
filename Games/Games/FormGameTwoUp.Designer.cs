namespace Games {
    partial class FormGameTwoUp {
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
            this.picCoin1 = new System.Windows.Forms.PictureBox();
            this.picCoin2 = new System.Windows.Forms.PictureBox();
            this.lblScorePlayerLabel = new System.Windows.Forms.Label();
            this.lblScoreComputerLabel = new System.Windows.Forms.Label();
            this.lblScorePlayer = new System.Windows.Forms.Label();
            this.lblScoreComputer = new System.Windows.Forms.Label();
            this.lblOutcome = new System.Windows.Forms.Label();
            this.panButtons = new System.Windows.Forms.Panel();
            this.btnPlayAgain = new System.Windows.Forms.Button();
            this.btnCancelGame = new System.Windows.Forms.Button();
            this.btnThrowCoins = new System.Windows.Forms.Button();
            this.tmrAnimation = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picCoin1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCoin2)).BeginInit();
            this.panButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // picCoin1
            // 
            this.picCoin1.Location = new System.Drawing.Point(53, 53);
            this.picCoin1.Margin = new System.Windows.Forms.Padding(3, 3, 13, 3);
            this.picCoin1.Name = "picCoin1";
            this.picCoin1.Size = new System.Drawing.Size(150, 150);
            this.picCoin1.TabIndex = 0;
            this.picCoin1.TabStop = false;
            // 
            // picCoin2
            // 
            this.picCoin2.Location = new System.Drawing.Point(238, 53);
            this.picCoin2.Margin = new System.Windows.Forms.Padding(13, 3, 3, 3);
            this.picCoin2.Name = "picCoin2";
            this.picCoin2.Size = new System.Drawing.Size(150, 150);
            this.picCoin2.TabIndex = 1;
            this.picCoin2.TabStop = false;
            // 
            // lblScorePlayerLabel
            // 
            this.lblScorePlayerLabel.AutoSize = true;
            this.lblScorePlayerLabel.Location = new System.Drawing.Point(53, 206);
            this.lblScorePlayerLabel.Name = "lblScorePlayerLabel";
            this.lblScorePlayerLabel.Size = new System.Drawing.Size(78, 13);
            this.lblScorePlayerLabel.TabIndex = 2;
            this.lblScorePlayerLabel.Text = "Player\'s score:";
            // 
            // lblScoreComputerLabel
            // 
            this.lblScoreComputerLabel.AutoSize = true;
            this.lblScoreComputerLabel.Location = new System.Drawing.Point(235, 206);
            this.lblScoreComputerLabel.Name = "lblScoreComputerLabel";
            this.lblScoreComputerLabel.Size = new System.Drawing.Size(99, 13);
            this.lblScoreComputerLabel.TabIndex = 3;
            this.lblScoreComputerLabel.Text = "Computer\'s score:";
            // 
            // lblScorePlayer
            // 
            this.lblScorePlayer.AutoSize = true;
            this.lblScorePlayer.Location = new System.Drawing.Point(134, 206);
            this.lblScorePlayer.Name = "lblScorePlayer";
            this.lblScorePlayer.Size = new System.Drawing.Size(32, 13);
            this.lblScorePlayer.TabIndex = 4;
            this.lblScorePlayer.Text = "?????";
            // 
            // lblScoreComputer
            // 
            this.lblScoreComputer.AutoSize = true;
            this.lblScoreComputer.Location = new System.Drawing.Point(332, 206);
            this.lblScoreComputer.Name = "lblScoreComputer";
            this.lblScoreComputer.Size = new System.Drawing.Size(32, 13);
            this.lblScoreComputer.TabIndex = 5;
            this.lblScoreComputer.Text = "?????";
            // 
            // lblOutcome
            // 
            this.lblOutcome.AutoSize = true;
            this.lblOutcome.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutcome.Location = new System.Drawing.Point(414, 114);
            this.lblOutcome.Margin = new System.Windows.Forms.Padding(23, 0, 3, 0);
            this.lblOutcome.Name = "lblOutcome";
            this.lblOutcome.Size = new System.Drawing.Size(63, 30);
            this.lblOutcome.TabIndex = 6;
            this.lblOutcome.Text = "?????";
            this.lblOutcome.Visible = false;
            // 
            // panButtons
            // 
            this.panButtons.AutoSize = true;
            this.panButtons.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panButtons.Controls.Add(this.btnPlayAgain);
            this.panButtons.Controls.Add(this.btnCancelGame);
            this.panButtons.Controls.Add(this.btnThrowCoins);
            this.panButtons.Location = new System.Drawing.Point(53, 252);
            this.panButtons.Margin = new System.Windows.Forms.Padding(3, 33, 3, 3);
            this.panButtons.MinimumSize = new System.Drawing.Size(335, 0);
            this.panButtons.Name = "panButtons";
            this.panButtons.Size = new System.Drawing.Size(335, 29);
            this.panButtons.TabIndex = 7;
            // 
            // btnPlayAgain
            // 
            this.btnPlayAgain.Location = new System.Drawing.Point(117, 3);
            this.btnPlayAgain.Name = "btnPlayAgain";
            this.btnPlayAgain.Size = new System.Drawing.Size(100, 23);
            this.btnPlayAgain.TabIndex = 2;
            this.btnPlayAgain.Text = "Play Again";
            this.btnPlayAgain.UseVisualStyleBackColor = true;
            this.btnPlayAgain.Visible = false;
            this.btnPlayAgain.Click += new System.EventHandler(this.btnPlayAgain_Click);
            // 
            // btnCancelGame
            // 
            this.btnCancelGame.Location = new System.Drawing.Point(232, 3);
            this.btnCancelGame.Name = "btnCancelGame";
            this.btnCancelGame.Size = new System.Drawing.Size(100, 23);
            this.btnCancelGame.TabIndex = 1;
            this.btnCancelGame.Text = "Cancel Game";
            this.btnCancelGame.UseVisualStyleBackColor = true;
            this.btnCancelGame.Click += new System.EventHandler(this.btnCancelGame_Click);
            // 
            // btnThrowCoins
            // 
            this.btnThrowCoins.Location = new System.Drawing.Point(3, 3);
            this.btnThrowCoins.Name = "btnThrowCoins";
            this.btnThrowCoins.Size = new System.Drawing.Size(100, 23);
            this.btnThrowCoins.TabIndex = 0;
            this.btnThrowCoins.Text = "Throw Coins";
            this.btnThrowCoins.UseVisualStyleBackColor = true;
            this.btnThrowCoins.Click += new System.EventHandler(this.btnThrowCoins_Click);
            // 
            // tmrAnimation
            // 
            this.tmrAnimation.Tick += new System.EventHandler(this.tmrAnimation_Tick);
            // 
            // FormGameTwoUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1082, 543);
            this.Controls.Add(this.panButtons);
            this.Controls.Add(this.lblOutcome);
            this.Controls.Add(this.lblScoreComputer);
            this.Controls.Add(this.lblScorePlayer);
            this.Controls.Add(this.lblScoreComputerLabel);
            this.Controls.Add(this.lblScorePlayerLabel);
            this.Controls.Add(this.picCoin2);
            this.Controls.Add(this.picCoin1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "FormGameTwoUp";
            this.Padding = new System.Windows.Forms.Padding(50);
            this.Text = "Two Up";
            ((System.ComponentModel.ISupportInitialize)(this.picCoin1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCoin2)).EndInit();
            this.panButtons.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picCoin1;
        private System.Windows.Forms.PictureBox picCoin2;
        private System.Windows.Forms.Label lblScorePlayerLabel;
        private System.Windows.Forms.Label lblScoreComputerLabel;
        private System.Windows.Forms.Label lblScorePlayer;
        private System.Windows.Forms.Label lblScoreComputer;
        private System.Windows.Forms.Label lblOutcome;
        private System.Windows.Forms.Panel panButtons;
        private System.Windows.Forms.Button btnPlayAgain;
        private System.Windows.Forms.Button btnCancelGame;
        private System.Windows.Forms.Button btnThrowCoins;
        private System.Windows.Forms.Timer tmrAnimation;
    }
}