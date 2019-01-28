namespace Games {
    partial class FormGameCrazyEightsSelectSuit {
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
            this.grpSuit = new System.Windows.Forms.GroupBox();
            this.radClubs = new System.Windows.Forms.RadioButton();
            this.radDiamonds = new System.Windows.Forms.RadioButton();
            this.radHearts = new System.Windows.Forms.RadioButton();
            this.radSpades = new System.Windows.Forms.RadioButton();
            this.btnAccept = new System.Windows.Forms.Button();
            this.grpSuit.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpSuit
            // 
            this.grpSuit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.grpSuit.AutoSize = true;
            this.grpSuit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.grpSuit.Controls.Add(this.radSpades);
            this.grpSuit.Controls.Add(this.radHearts);
            this.grpSuit.Controls.Add(this.radDiamonds);
            this.grpSuit.Controls.Add(this.radClubs);
            this.grpSuit.Location = new System.Drawing.Point(92, 12);
            this.grpSuit.MinimumSize = new System.Drawing.Size(100, 0);
            this.grpSuit.Name = "grpSuit";
            this.grpSuit.Size = new System.Drawing.Size(100, 128);
            this.grpSuit.TabIndex = 0;
            this.grpSuit.TabStop = false;
            this.grpSuit.Text = "Choose a Suit";
            // 
            // radClubs
            // 
            this.radClubs.AutoSize = true;
            this.radClubs.Location = new System.Drawing.Point(6, 21);
            this.radClubs.Name = "radClubs";
            this.radClubs.Size = new System.Drawing.Size(54, 17);
            this.radClubs.TabIndex = 0;
            this.radClubs.TabStop = true;
            this.radClubs.Text = "Clubs";
            this.radClubs.UseVisualStyleBackColor = true;
            // 
            // radDiamonds
            // 
            this.radDiamonds.AutoSize = true;
            this.radDiamonds.Location = new System.Drawing.Point(6, 44);
            this.radDiamonds.Name = "radDiamonds";
            this.radDiamonds.Size = new System.Drawing.Size(77, 17);
            this.radDiamonds.TabIndex = 1;
            this.radDiamonds.TabStop = true;
            this.radDiamonds.Text = "Diamonds";
            this.radDiamonds.UseVisualStyleBackColor = true;
            // 
            // radHearts
            // 
            this.radHearts.AutoSize = true;
            this.radHearts.Location = new System.Drawing.Point(6, 67);
            this.radHearts.Name = "radHearts";
            this.radHearts.Size = new System.Drawing.Size(58, 17);
            this.radHearts.TabIndex = 2;
            this.radHearts.TabStop = true;
            this.radHearts.Text = "Hearts";
            this.radHearts.UseVisualStyleBackColor = true;
            // 
            // radSpades
            // 
            this.radSpades.AutoSize = true;
            this.radSpades.Location = new System.Drawing.Point(6, 90);
            this.radSpades.Name = "radSpades";
            this.radSpades.Size = new System.Drawing.Size(62, 17);
            this.radSpades.TabIndex = 3;
            this.radSpades.TabStop = true;
            this.radSpades.Text = "Spades";
            this.radSpades.UseVisualStyleBackColor = true;
            // 
            // btnAccept
            // 
            this.btnAccept.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAccept.Location = new System.Drawing.Point(105, 146);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(75, 23);
            this.btnAccept.TabIndex = 1;
            this.btnAccept.Text = "OK";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // FormGameCrazyEightsSelectSuit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.ControlBox = false;
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.grpSuit);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormGameCrazyEightsSelectSuit";
            this.Text = "Choose a Suit";
            this.grpSuit.ResumeLayout(false);
            this.grpSuit.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpSuit;
        private System.Windows.Forms.RadioButton radSpades;
        private System.Windows.Forms.RadioButton radHearts;
        private System.Windows.Forms.RadioButton radDiamonds;
        private System.Windows.Forms.RadioButton radClubs;
        private System.Windows.Forms.Button btnAccept;
    }
}