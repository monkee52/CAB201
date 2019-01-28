namespace Games {
    partial class FormGameSelector {
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
            this.lblHeader = new System.Windows.Forms.Label();
            this.grpGameOptions = new System.Windows.Forms.GroupBox();
            this.radGameTypeCard = new System.Windows.Forms.RadioButton();
            this.radGameTypeDice = new System.Windows.Forms.RadioButton();
            this.radGameTypeCoin = new System.Windows.Forms.RadioButton();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.grpGameOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(81, 59);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(123, 25);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Game World";
            // 
            // grpGameOptions
            // 
            this.grpGameOptions.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.grpGameOptions.AutoSize = true;
            this.grpGameOptions.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.grpGameOptions.Controls.Add(this.radGameTypeCard);
            this.grpGameOptions.Controls.Add(this.radGameTypeDice);
            this.grpGameOptions.Controls.Add(this.radGameTypeCoin);
            this.grpGameOptions.Location = new System.Drawing.Point(96, 87);
            this.grpGameOptions.Name = "grpGameOptions";
            this.grpGameOptions.Size = new System.Drawing.Size(92, 105);
            this.grpGameOptions.TabIndex = 1;
            this.grpGameOptions.TabStop = false;
            this.grpGameOptions.Text = "Game Type";
            // 
            // radGameTypeCard
            // 
            this.radGameTypeCard.AutoSize = true;
            this.radGameTypeCard.Location = new System.Drawing.Point(6, 67);
            this.radGameTypeCard.Name = "radGameTypeCard";
            this.radGameTypeCard.Size = new System.Drawing.Size(80, 17);
            this.radGameTypeCard.TabIndex = 6;
            this.radGameTypeCard.TabStop = true;
            this.radGameTypeCard.Text = "Card game";
            this.radGameTypeCard.UseVisualStyleBackColor = true;
            this.radGameTypeCard.CheckedChanged += new System.EventHandler(this.radGameType_CheckedChanged);
            // 
            // radGameTypeDice
            // 
            this.radGameTypeDice.AutoSize = true;
            this.radGameTypeDice.Location = new System.Drawing.Point(6, 44);
            this.radGameTypeDice.Name = "radGameTypeDice";
            this.radGameTypeDice.Size = new System.Drawing.Size(78, 17);
            this.radGameTypeDice.TabIndex = 5;
            this.radGameTypeDice.TabStop = true;
            this.radGameTypeDice.Text = "Dice game";
            this.radGameTypeDice.UseVisualStyleBackColor = true;
            this.radGameTypeDice.CheckedChanged += new System.EventHandler(this.radGameType_CheckedChanged);
            // 
            // radGameTypeCoin
            // 
            this.radGameTypeCoin.AutoSize = true;
            this.radGameTypeCoin.Location = new System.Drawing.Point(6, 21);
            this.radGameTypeCoin.Name = "radGameTypeCoin";
            this.radGameTypeCoin.Size = new System.Drawing.Size(80, 17);
            this.radGameTypeCoin.TabIndex = 4;
            this.radGameTypeCoin.TabStop = true;
            this.radGameTypeCoin.Text = "Coin game";
            this.radGameTypeCoin.UseVisualStyleBackColor = true;
            this.radGameTypeCoin.CheckedChanged += new System.EventHandler(this.radGameType_CheckedChanged);
            // 
            // btnStart
            // 
            this.btnStart.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnStart.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnStart.Enabled = false;
            this.btnStart.Location = new System.Drawing.Point(105, 198);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "START";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(105, 227);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // FormGameSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.grpGameOptions);
            this.Controls.Add(this.lblHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormGameSelector";
            this.Padding = new System.Windows.Forms.Padding(112, 50, 112, 50);
            this.Text = "Games";
            this.grpGameOptions.ResumeLayout(false);
            this.grpGameOptions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.GroupBox grpGameOptions;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.RadioButton radGameTypeCard;
        private System.Windows.Forms.RadioButton radGameTypeDice;
        private System.Windows.Forms.RadioButton radGameTypeCoin;
    }
}

