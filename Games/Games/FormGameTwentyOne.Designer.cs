namespace Games {
    partial class FormGameTwentyOne {
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
            this.tlpDealer = new System.Windows.Forms.TableLayoutPanel();
            this.tlpPlayer = new System.Windows.Forms.TableLayoutPanel();
            this.btnDeal = new System.Windows.Forms.Button();
            this.btnTest = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnStand = new System.Windows.Forms.Button();
            this.btnHit = new System.Windows.Forms.Button();
            this.lblDealerBusted = new System.Windows.Forms.Label();
            this.lblDealer = new System.Windows.Forms.Label();
            this.lblDealerPoints = new System.Windows.Forms.Label();
            this.lblDealerWonText = new System.Windows.Forms.Label();
            this.lblDealerWon = new System.Windows.Forms.Label();
            this.lblPlayerWon = new System.Windows.Forms.Label();
            this.lblPlayerPoints = new System.Windows.Forms.Label();
            this.lblPlayerWonText = new System.Windows.Forms.Label();
            this.lblPlayer = new System.Windows.Forms.Label();
            this.lblPlayerBusted = new System.Windows.Forms.Label();
            this.lblOneAces = new System.Windows.Forms.Label();
            this.lblOneAcesText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tlpDealer
            // 
            this.tlpDealer.ColumnCount = 8;
            this.tlpDealer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlpDealer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlpDealer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlpDealer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlpDealer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlpDealer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlpDealer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlpDealer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlpDealer.Location = new System.Drawing.Point(12, 60);
            this.tlpDealer.Name = "tlpDealer";
            this.tlpDealer.RowCount = 1;
            this.tlpDealer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpDealer.Size = new System.Drawing.Size(576, 95);
            this.tlpDealer.TabIndex = 0;
            // 
            // tlpPlayer
            // 
            this.tlpPlayer.ColumnCount = 8;
            this.tlpPlayer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlpPlayer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlpPlayer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlpPlayer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlpPlayer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlpPlayer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlpPlayer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlpPlayer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlpPlayer.Location = new System.Drawing.Point(12, 217);
            this.tlpPlayer.Name = "tlpPlayer";
            this.tlpPlayer.RowCount = 1;
            this.tlpPlayer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPlayer.Size = new System.Drawing.Size(576, 95);
            this.tlpPlayer.TabIndex = 1;
            // 
            // btnDeal
            // 
            this.btnDeal.Location = new System.Drawing.Point(103, 386);
            this.btnDeal.Name = "btnDeal";
            this.btnDeal.Size = new System.Drawing.Size(75, 23);
            this.btnDeal.TabIndex = 2;
            this.btnDeal.Text = "Deal";
            this.btnDeal.UseVisualStyleBackColor = true;
            this.btnDeal.Click += new System.EventHandler(this.btnDeal_Click);
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(427, 386);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(75, 23);
            this.btnTest.TabIndex = 3;
            this.btnTest.Text = "Test";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Visible = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(346, 386);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnStand
            // 
            this.btnStand.Enabled = false;
            this.btnStand.Location = new System.Drawing.Point(265, 386);
            this.btnStand.Name = "btnStand";
            this.btnStand.Size = new System.Drawing.Size(75, 23);
            this.btnStand.TabIndex = 5;
            this.btnStand.Text = "Stand";
            this.btnStand.UseVisualStyleBackColor = true;
            this.btnStand.Click += new System.EventHandler(this.btnStand_Click);
            // 
            // btnHit
            // 
            this.btnHit.Enabled = false;
            this.btnHit.Location = new System.Drawing.Point(184, 386);
            this.btnHit.Name = "btnHit";
            this.btnHit.Size = new System.Drawing.Size(75, 23);
            this.btnHit.TabIndex = 6;
            this.btnHit.Text = "Hit";
            this.btnHit.UseVisualStyleBackColor = true;
            this.btnHit.Click += new System.EventHandler(this.btnHit_Click);
            // 
            // lblDealerBusted
            // 
            this.lblDealerBusted.AutoSize = true;
            this.lblDealerBusted.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDealerBusted.ForeColor = System.Drawing.Color.Red;
            this.lblDealerBusted.Location = new System.Drawing.Point(138, 32);
            this.lblDealerBusted.Name = "lblDealerBusted";
            this.lblDealerBusted.Size = new System.Drawing.Size(79, 25);
            this.lblDealerBusted.TabIndex = 7;
            this.lblDealerBusted.Text = "BUSTED";
            this.lblDealerBusted.Visible = false;
            // 
            // lblDealer
            // 
            this.lblDealer.AutoSize = true;
            this.lblDealer.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDealer.Location = new System.Drawing.Point(223, 32);
            this.lblDealer.Name = "lblDealer";
            this.lblDealer.Size = new System.Drawing.Size(69, 25);
            this.lblDealer.TabIndex = 8;
            this.lblDealer.Text = "Dealer";
            // 
            // lblDealerPoints
            // 
            this.lblDealerPoints.AutoSize = true;
            this.lblDealerPoints.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDealerPoints.Location = new System.Drawing.Point(298, 32);
            this.lblDealerPoints.Name = "lblDealerPoints";
            this.lblDealerPoints.Size = new System.Drawing.Size(57, 25);
            this.lblDealerPoints.TabIndex = 10;
            this.lblDealerPoints.Text = "?????";
            this.lblDealerPoints.Visible = false;
            // 
            // lblDealerWonText
            // 
            this.lblDealerWonText.AutoSize = true;
            this.lblDealerWonText.Location = new System.Drawing.Point(361, 41);
            this.lblDealerWonText.Name = "lblDealerWonText";
            this.lblDealerWonText.Size = new System.Drawing.Size(67, 13);
            this.lblDealerWonText.TabIndex = 9;
            this.lblDealerWonText.Text = "Games won";
            // 
            // lblDealerWon
            // 
            this.lblDealerWon.AutoSize = true;
            this.lblDealerWon.Location = new System.Drawing.Point(434, 41);
            this.lblDealerWon.Name = "lblDealerWon";
            this.lblDealerWon.Size = new System.Drawing.Size(32, 13);
            this.lblDealerWon.TabIndex = 12;
            this.lblDealerWon.Text = "?????";
            // 
            // lblPlayerWon
            // 
            this.lblPlayerWon.AutoSize = true;
            this.lblPlayerWon.Location = new System.Drawing.Point(434, 324);
            this.lblPlayerWon.Name = "lblPlayerWon";
            this.lblPlayerWon.Size = new System.Drawing.Size(32, 13);
            this.lblPlayerWon.TabIndex = 21;
            this.lblPlayerWon.Text = "?????";
            // 
            // lblPlayerPoints
            // 
            this.lblPlayerPoints.AutoSize = true;
            this.lblPlayerPoints.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerPoints.Location = new System.Drawing.Point(298, 315);
            this.lblPlayerPoints.Name = "lblPlayerPoints";
            this.lblPlayerPoints.Size = new System.Drawing.Size(57, 25);
            this.lblPlayerPoints.TabIndex = 20;
            this.lblPlayerPoints.Text = "?????";
            this.lblPlayerPoints.Visible = false;
            // 
            // lblPlayerWonText
            // 
            this.lblPlayerWonText.AutoSize = true;
            this.lblPlayerWonText.Location = new System.Drawing.Point(361, 324);
            this.lblPlayerWonText.Name = "lblPlayerWonText";
            this.lblPlayerWonText.Size = new System.Drawing.Size(67, 13);
            this.lblPlayerWonText.TabIndex = 19;
            this.lblPlayerWonText.Text = "Games won";
            // 
            // lblPlayer
            // 
            this.lblPlayer.AutoSize = true;
            this.lblPlayer.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer.Location = new System.Drawing.Point(223, 315);
            this.lblPlayer.Name = "lblPlayer";
            this.lblPlayer.Size = new System.Drawing.Size(67, 25);
            this.lblPlayer.TabIndex = 18;
            this.lblPlayer.Text = "Player";
            // 
            // lblPlayerBusted
            // 
            this.lblPlayerBusted.AutoSize = true;
            this.lblPlayerBusted.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerBusted.ForeColor = System.Drawing.Color.Red;
            this.lblPlayerBusted.Location = new System.Drawing.Point(138, 315);
            this.lblPlayerBusted.Name = "lblPlayerBusted";
            this.lblPlayerBusted.Size = new System.Drawing.Size(79, 25);
            this.lblPlayerBusted.TabIndex = 17;
            this.lblPlayerBusted.Text = "BUSTED";
            this.lblPlayerBusted.Visible = false;
            // 
            // lblOneAces
            // 
            this.lblOneAces.AutoSize = true;
            this.lblOneAces.Location = new System.Drawing.Point(220, 358);
            this.lblOneAces.Margin = new System.Windows.Forms.Padding(3, 18, 3, 28);
            this.lblOneAces.Name = "lblOneAces";
            this.lblOneAces.Size = new System.Drawing.Size(32, 13);
            this.lblOneAces.TabIndex = 22;
            this.lblOneAces.Text = "?????";
            this.lblOneAces.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblOneAcesText
            // 
            this.lblOneAcesText.AutoSize = true;
            this.lblOneAcesText.Location = new System.Drawing.Point(258, 358);
            this.lblOneAcesText.Margin = new System.Windows.Forms.Padding(3, 18, 3, 28);
            this.lblOneAcesText.Name = "lblOneAcesText";
            this.lblOneAcesText.Size = new System.Drawing.Size(126, 13);
            this.lblOneAcesText.TabIndex = 23;
            this.lblOneAcesText.Text = "aces with value one (1).";
            // 
            // FormGameTwentyOne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(604, 421);
            this.Controls.Add(this.lblOneAcesText);
            this.Controls.Add(this.lblOneAces);
            this.Controls.Add(this.lblPlayerWon);
            this.Controls.Add(this.lblPlayerPoints);
            this.Controls.Add(this.lblPlayerWonText);
            this.Controls.Add(this.lblPlayer);
            this.Controls.Add(this.lblPlayerBusted);
            this.Controls.Add(this.lblDealerWon);
            this.Controls.Add(this.lblDealerPoints);
            this.Controls.Add(this.lblDealerWonText);
            this.Controls.Add(this.lblDealer);
            this.Controls.Add(this.lblDealerBusted);
            this.Controls.Add(this.btnHit);
            this.Controls.Add(this.btnStand);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.btnDeal);
            this.Controls.Add(this.tlpPlayer);
            this.Controls.Add(this.tlpDealer);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormGameTwentyOne";
            this.Text = "Twenty One";
            this.Load += new System.EventHandler(this.FormGameTwentyOne_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpDealer;
        private System.Windows.Forms.TableLayoutPanel tlpPlayer;
        private System.Windows.Forms.Button btnDeal;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnStand;
        private System.Windows.Forms.Button btnHit;
        private System.Windows.Forms.Label lblDealerBusted;
        private System.Windows.Forms.Label lblDealer;
        private System.Windows.Forms.Label lblDealerPoints;
        private System.Windows.Forms.Label lblDealerWonText;
        private System.Windows.Forms.Label lblDealerWon;
        private System.Windows.Forms.Label lblPlayerWon;
        private System.Windows.Forms.Label lblPlayerPoints;
        private System.Windows.Forms.Label lblPlayerWonText;
        private System.Windows.Forms.Label lblPlayer;
        private System.Windows.Forms.Label lblPlayerBusted;
        private System.Windows.Forms.Label lblOneAces;
        private System.Windows.Forms.Label lblOneAcesText;
    }
}