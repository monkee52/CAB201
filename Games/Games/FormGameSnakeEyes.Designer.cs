namespace Games {
    partial class FormGameSnakeEyes {
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
            this.imgDie1 = new System.Windows.Forms.PictureBox();
            this.imgDie2 = new System.Windows.Forms.PictureBox();
            this.lblRoll = new System.Windows.Forms.Label();
            this.btnRollDice = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblPlayerScoreText = new System.Windows.Forms.Label();
            this.lblHouseScoreText = new System.Windows.Forms.Label();
            this.lblPlayerScore = new System.Windows.Forms.Label();
            this.lblHouseScore = new System.Windows.Forms.Label();
            this.btnContinuePlaying = new System.Windows.Forms.Button();
            this.btnCancelGame = new System.Windows.Forms.Button();
            this.tmrAnimation = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.imgDie1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgDie2)).BeginInit();
            this.SuspendLayout();
            // 
            // imgDie1
            // 
            this.imgDie1.Location = new System.Drawing.Point(12, 37);
            this.imgDie1.Name = "imgDie1";
            this.imgDie1.Size = new System.Drawing.Size(60, 60);
            this.imgDie1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgDie1.TabIndex = 0;
            this.imgDie1.TabStop = false;
            // 
            // imgDie2
            // 
            this.imgDie2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.imgDie2.Location = new System.Drawing.Point(501, 37);
            this.imgDie2.Name = "imgDie2";
            this.imgDie2.Size = new System.Drawing.Size(60, 60);
            this.imgDie2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgDie2.TabIndex = 1;
            this.imgDie2.TabStop = false;
            // 
            // lblRoll
            // 
            this.lblRoll.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblRoll.AutoSize = true;
            this.lblRoll.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoll.Location = new System.Drawing.Point(260, 9);
            this.lblRoll.Name = "lblRoll";
            this.lblRoll.Size = new System.Drawing.Size(89, 25);
            this.lblRoll.TabIndex = 2;
            this.lblRoll.Text = "First Roll";
            // 
            // btnRollDice
            // 
            this.btnRollDice.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnRollDice.Location = new System.Drawing.Point(249, 57);
            this.btnRollDice.Name = "btnRollDice";
            this.btnRollDice.Size = new System.Drawing.Size(75, 23);
            this.btnRollDice.TabIndex = 3;
            this.btnRollDice.Text = "Roll Dice";
            this.btnRollDice.UseVisualStyleBackColor = true;
            this.btnRollDice.Click += new System.EventHandler(this.btnRollDice_Click);
            // 
            // lblResult
            // 
            this.lblResult.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(260, 100);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(52, 25);
            this.lblResult.TabIndex = 4;
            this.lblResult.Text = "?????";
            this.lblResult.Visible = false;
            // 
            // lblPlayerScoreText
            // 
            this.lblPlayerScoreText.AutoSize = true;
            this.lblPlayerScoreText.Location = new System.Drawing.Point(9, 141);
            this.lblPlayerScoreText.Name = "lblPlayerScoreText";
            this.lblPlayerScoreText.Size = new System.Drawing.Size(76, 13);
            this.lblPlayerScoreText.TabIndex = 5;
            this.lblPlayerScoreText.Text = "Player\'s Score";
            // 
            // lblHouseScoreText
            // 
            this.lblHouseScoreText.AutoSize = true;
            this.lblHouseScoreText.Location = new System.Drawing.Point(119, 141);
            this.lblHouseScoreText.Margin = new System.Windows.Forms.Padding(13, 0, 3, 0);
            this.lblHouseScoreText.Name = "lblHouseScoreText";
            this.lblHouseScoreText.Size = new System.Drawing.Size(76, 13);
            this.lblHouseScoreText.TabIndex = 6;
            this.lblHouseScoreText.Text = "Player\'s Score";
            // 
            // lblPlayerScore
            // 
            this.lblPlayerScore.AutoSize = true;
            this.lblPlayerScore.BackColor = System.Drawing.Color.White;
            this.lblPlayerScore.Location = new System.Drawing.Point(91, 141);
            this.lblPlayerScore.Name = "lblPlayerScore";
            this.lblPlayerScore.Size = new System.Drawing.Size(12, 13);
            this.lblPlayerScore.TabIndex = 7;
            this.lblPlayerScore.Text = "?";
            // 
            // lblHouseScore
            // 
            this.lblHouseScore.AutoSize = true;
            this.lblHouseScore.BackColor = System.Drawing.Color.White;
            this.lblHouseScore.Location = new System.Drawing.Point(201, 141);
            this.lblHouseScore.Name = "lblHouseScore";
            this.lblHouseScore.Size = new System.Drawing.Size(12, 13);
            this.lblHouseScore.TabIndex = 8;
            this.lblHouseScore.Text = "?";
            // 
            // btnContinuePlaying
            // 
            this.btnContinuePlaying.Enabled = false;
            this.btnContinuePlaying.Location = new System.Drawing.Point(12, 172);
            this.btnContinuePlaying.Name = "btnContinuePlaying";
            this.btnContinuePlaying.Size = new System.Drawing.Size(75, 46);
            this.btnContinuePlaying.TabIndex = 9;
            this.btnContinuePlaying.Text = "Continue Playing";
            this.btnContinuePlaying.UseVisualStyleBackColor = true;
            this.btnContinuePlaying.Click += new System.EventHandler(this.btnContinuePlaying_Click);
            // 
            // btnCancelGame
            // 
            this.btnCancelGame.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelGame.Location = new System.Drawing.Point(486, 172);
            this.btnCancelGame.Name = "btnCancelGame";
            this.btnCancelGame.Size = new System.Drawing.Size(75, 46);
            this.btnCancelGame.TabIndex = 10;
            this.btnCancelGame.Text = "Cancel Game";
            this.btnCancelGame.UseVisualStyleBackColor = true;
            this.btnCancelGame.Click += new System.EventHandler(this.btnCancelGame_Click);
            // 
            // tmrAnimation
            // 
            this.tmrAnimation.Tick += new System.EventHandler(this.tmrAnimation_Tick);
            // 
            // FormGameSnakeEyes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(573, 261);
            this.Controls.Add(this.btnCancelGame);
            this.Controls.Add(this.btnContinuePlaying);
            this.Controls.Add(this.lblHouseScore);
            this.Controls.Add(this.lblPlayerScore);
            this.Controls.Add(this.lblHouseScoreText);
            this.Controls.Add(this.lblPlayerScoreText);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnRollDice);
            this.Controls.Add(this.lblRoll);
            this.Controls.Add(this.imgDie2);
            this.Controls.Add(this.imgDie1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormGameSnakeEyes";
            this.Text = "Snake Eyes";
            ((System.ComponentModel.ISupportInitialize)(this.imgDie1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgDie2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgDie1;
        private System.Windows.Forms.PictureBox imgDie2;
        private System.Windows.Forms.Label lblRoll;
        private System.Windows.Forms.Button btnRollDice;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblPlayerScoreText;
        private System.Windows.Forms.Label lblHouseScoreText;
        private System.Windows.Forms.Label lblPlayerScore;
        private System.Windows.Forms.Label lblHouseScore;
        private System.Windows.Forms.Button btnContinuePlaying;
        private System.Windows.Forms.Button btnCancelGame;
        private System.Windows.Forms.Timer tmrAnimation;
    }
}