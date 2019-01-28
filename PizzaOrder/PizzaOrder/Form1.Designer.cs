namespace PizzaOrder {
    partial class frmOrderForm {
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
            this.lblWelcome = new System.Windows.Forms.Label();
            this.tblDetails = new System.Windows.Forms.TableLayoutPanel();
            this.grpToppings = new System.Windows.Forms.GroupBox();
            this.lblToppings = new System.Windows.Forms.Label();
            this.tblToppings = new System.Windows.Forms.TableLayoutPanel();
            this.grpCrust = new System.Windows.Forms.GroupBox();
            this.lblSurcharge = new System.Windows.Forms.Label();
            this.radCrustGlutenFree = new System.Windows.Forms.RadioButton();
            this.radCrustThick = new System.Windows.Forms.RadioButton();
            this.radCrustThin = new System.Windows.Forms.RadioButton();
            this.pnlSauce = new System.Windows.Forms.Panel();
            this.cmbSauce = new System.Windows.Forms.ComboBox();
            this.lblSauce = new System.Windows.Forms.Label();
            this.pnlName = new System.Windows.Forms.Panel();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblBasePrice = new System.Windows.Forms.Label();
            this.btnDone = new System.Windows.Forms.Button();
            this.tblDetails.SuspendLayout();
            this.grpToppings.SuspendLayout();
            this.grpCrust.SuspendLayout();
            this.pnlSauce.SuspendLayout();
            this.pnlName.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI Light", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.Black;
            this.lblHeader.Location = new System.Drawing.Point(219, 9);
            this.lblHeader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(352, 45);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Welcome to Beagle Boys";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblWelcome
            // 
            this.lblWelcome.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI Light", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.Color.Black;
            this.lblWelcome.Location = new System.Drawing.Point(301, 54);
            this.lblWelcome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(188, 30);
            this.lblWelcome.TabIndex = 1;
            this.lblWelcome.Text = "Online Order Form";
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tblDetails
            // 
            this.tblDetails.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tblDetails.AutoSize = true;
            this.tblDetails.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tblDetails.ColumnCount = 2;
            this.tblDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66F));
            this.tblDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tblDetails.Controls.Add(this.grpToppings, 0, 3);
            this.tblDetails.Controls.Add(this.grpCrust, 0, 2);
            this.tblDetails.Controls.Add(this.pnlSauce, 1, 2);
            this.tblDetails.Controls.Add(this.pnlName, 0, 0);
            this.tblDetails.Controls.Add(this.lblBasePrice, 0, 1);
            this.tblDetails.Location = new System.Drawing.Point(16, 107);
            this.tblDetails.Margin = new System.Windows.Forms.Padding(3, 23, 3, 3);
            this.tblDetails.Name = "tblDetails";
            this.tblDetails.RowCount = 4;
            this.tblDetails.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblDetails.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblDetails.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblDetails.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblDetails.Size = new System.Drawing.Size(774, 372);
            this.tblDetails.TabIndex = 3;
            // 
            // grpToppings
            // 
            this.grpToppings.AutoSize = true;
            this.grpToppings.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tblDetails.SetColumnSpan(this.grpToppings, 2);
            this.grpToppings.Controls.Add(this.lblToppings);
            this.grpToppings.Controls.Add(this.tblToppings);
            this.grpToppings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpToppings.Location = new System.Drawing.Point(3, 175);
            this.grpToppings.Name = "grpToppings";
            this.grpToppings.Size = new System.Drawing.Size(768, 194);
            this.grpToppings.TabIndex = 0;
            this.grpToppings.TabStop = false;
            this.grpToppings.Text = "Toppings";
            // 
            // lblToppings
            // 
            this.lblToppings.AutoSize = true;
            this.lblToppings.Location = new System.Drawing.Point(6, 148);
            this.lblToppings.Name = "lblToppings";
            this.lblToppings.Size = new System.Drawing.Size(605, 21);
            this.lblToppings.TabIndex = 1;
            this.lblToppings.Text = "Choose the toppings for your pizza. The first four are free; additional toppings " +
    "are $1 each";
            // 
            // tblToppings
            // 
            this.tblToppings.ColumnCount = 4;
            this.tblToppings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblToppings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblToppings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblToppings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblToppings.Dock = System.Windows.Forms.DockStyle.Top;
            this.tblToppings.Location = new System.Drawing.Point(3, 25);
            this.tblToppings.Name = "tblToppings";
            this.tblToppings.RowCount = 4;
            this.tblToppings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblToppings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblToppings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblToppings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblToppings.Size = new System.Drawing.Size(762, 120);
            this.tblToppings.TabIndex = 0;
            // 
            // grpCrust
            // 
            this.grpCrust.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.grpCrust.Controls.Add(this.lblSurcharge);
            this.grpCrust.Controls.Add(this.radCrustGlutenFree);
            this.grpCrust.Controls.Add(this.radCrustThick);
            this.grpCrust.Controls.Add(this.radCrustThin);
            this.grpCrust.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpCrust.Location = new System.Drawing.Point(3, 69);
            this.grpCrust.Name = "grpCrust";
            this.grpCrust.Size = new System.Drawing.Size(504, 100);
            this.grpCrust.TabIndex = 1;
            this.grpCrust.TabStop = false;
            this.grpCrust.Text = "Crust";
            // 
            // lblSurcharge
            // 
            this.lblSurcharge.AutoSize = true;
            this.lblSurcharge.Location = new System.Drawing.Point(12, 66);
            this.lblSurcharge.Margin = new System.Windows.Forms.Padding(13, 0, 3, 13);
            this.lblSurcharge.Name = "lblSurcharge";
            this.lblSurcharge.Size = new System.Drawing.Size(157, 21);
            this.lblSurcharge.TabIndex = 3;
            this.lblSurcharge.Text = "* Incurs a $2 surchage";
            // 
            // radCrustGlutenFree
            // 
            this.radCrustGlutenFree.AutoSize = true;
            this.radCrustGlutenFree.Enabled = false;
            this.radCrustGlutenFree.Location = new System.Drawing.Point(187, 28);
            this.radCrustGlutenFree.Margin = new System.Windows.Forms.Padding(13, 3, 13, 13);
            this.radCrustGlutenFree.Name = "radCrustGlutenFree";
            this.radCrustGlutenFree.Size = new System.Drawing.Size(112, 25);
            this.radCrustGlutenFree.TabIndex = 2;
            this.radCrustGlutenFree.TabStop = true;
            this.radCrustGlutenFree.Tag = "gluten free";
            this.radCrustGlutenFree.Text = "Gluten free *";
            this.radCrustGlutenFree.UseVisualStyleBackColor = true;
            this.radCrustGlutenFree.CheckedChanged += new System.EventHandler(this.radCrust_CheckedChanged);
            // 
            // radCrustThick
            // 
            this.radCrustThick.AutoSize = true;
            this.radCrustThick.Enabled = false;
            this.radCrustThick.Location = new System.Drawing.Point(99, 28);
            this.radCrustThick.Margin = new System.Windows.Forms.Padding(13, 3, 13, 13);
            this.radCrustThick.Name = "radCrustThick";
            this.radCrustThick.Size = new System.Drawing.Size(62, 25);
            this.radCrustThick.TabIndex = 1;
            this.radCrustThick.TabStop = true;
            this.radCrustThick.Text = "Thick";
            this.radCrustThick.UseVisualStyleBackColor = true;
            this.radCrustThick.CheckedChanged += new System.EventHandler(this.radCrust_CheckedChanged);
            // 
            // radCrustThin
            // 
            this.radCrustThin.AutoSize = true;
            this.radCrustThin.Enabled = false;
            this.radCrustThin.Location = new System.Drawing.Point(16, 28);
            this.radCrustThin.Margin = new System.Windows.Forms.Padding(13, 3, 13, 13);
            this.radCrustThin.Name = "radCrustThin";
            this.radCrustThin.Size = new System.Drawing.Size(57, 25);
            this.radCrustThin.TabIndex = 0;
            this.radCrustThin.Text = "Thin";
            this.radCrustThin.UseVisualStyleBackColor = true;
            this.radCrustThin.CheckedChanged += new System.EventHandler(this.radCrust_CheckedChanged);
            // 
            // pnlSauce
            // 
            this.pnlSauce.Controls.Add(this.cmbSauce);
            this.pnlSauce.Controls.Add(this.lblSauce);
            this.pnlSauce.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSauce.Location = new System.Drawing.Point(513, 69);
            this.pnlSauce.Name = "pnlSauce";
            this.pnlSauce.Size = new System.Drawing.Size(258, 100);
            this.pnlSauce.TabIndex = 2;
            // 
            // cmbSauce
            // 
            this.cmbSauce.Dock = System.Windows.Forms.DockStyle.Top;
            this.cmbSauce.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSauce.Enabled = false;
            this.cmbSauce.FormattingEnabled = true;
            this.cmbSauce.Items.AddRange(new object[] {
            "Tomato",
            "Barbeque"});
            this.cmbSauce.Location = new System.Drawing.Point(0, 34);
            this.cmbSauce.Name = "cmbSauce";
            this.cmbSauce.Size = new System.Drawing.Size(258, 29);
            this.cmbSauce.TabIndex = 2;
            this.cmbSauce.SelectedIndexChanged += new System.EventHandler(this.cmbSauce_SelectedIndexChanged);
            // 
            // lblSauce
            // 
            this.lblSauce.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSauce.Location = new System.Drawing.Point(0, 0);
            this.lblSauce.Margin = new System.Windows.Forms.Padding(3);
            this.lblSauce.Name = "lblSauce";
            this.lblSauce.Padding = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.lblSauce.Size = new System.Drawing.Size(258, 34);
            this.lblSauce.TabIndex = 1;
            this.lblSauce.Text = "Select the sauce for your pizza";
            this.lblSauce.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnlName
            // 
            this.pnlName.AutoSize = true;
            this.pnlName.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tblDetails.SetColumnSpan(this.pnlName, 2);
            this.pnlName.Controls.Add(this.txtName);
            this.pnlName.Controls.Add(this.lblName);
            this.pnlName.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlName.Location = new System.Drawing.Point(3, 3);
            this.pnlName.Name = "pnlName";
            this.pnlName.Size = new System.Drawing.Size(768, 39);
            this.pnlName.TabIndex = 3;
            // 
            // txtName
            // 
            this.txtName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.Location = new System.Drawing.Point(363, 5);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(296, 29);
            this.txtName.TabIndex = 3;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // lblName
            // 
            this.lblName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblName.AutoSize = true;
            this.lblName.ForeColor = System.Drawing.Color.Black;
            this.lblName.Location = new System.Drawing.Point(109, 8);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(246, 21);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Please enter a name for your order:";
            // 
            // lblBasePrice
            // 
            this.lblBasePrice.AutoSize = true;
            this.lblBasePrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblBasePrice.Location = new System.Drawing.Point(3, 45);
            this.lblBasePrice.Name = "lblBasePrice";
            this.lblBasePrice.Size = new System.Drawing.Size(504, 21);
            this.lblBasePrice.TabIndex = 4;
            this.lblBasePrice.Text = "Pizzas starting from $10";
            this.lblBasePrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDone
            // 
            this.btnDone.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDone.AutoSize = true;
            this.btnDone.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDone.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnDone.Location = new System.Drawing.Point(342, 494);
            this.btnDone.Margin = new System.Windows.Forms.Padding(3, 12, 3, 3);
            this.btnDone.Name = "btnDone";
            this.btnDone.Padding = new System.Windows.Forms.Padding(25, 5, 25, 5);
            this.btnDone.Size = new System.Drawing.Size(111, 41);
            this.btnDone.TabIndex = 4;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = false;
            this.btnDone.Visible = false;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // frmOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(790, 549);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.tblDetails);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.lblHeader);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmOrderForm";
            this.Text = "Beagle Boys";
            this.Load += new System.EventHandler(this.frmOrderForm_Load);
            this.tblDetails.ResumeLayout(false);
            this.tblDetails.PerformLayout();
            this.grpToppings.ResumeLayout(false);
            this.grpToppings.PerformLayout();
            this.grpCrust.ResumeLayout(false);
            this.grpCrust.PerformLayout();
            this.pnlSauce.ResumeLayout(false);
            this.pnlName.ResumeLayout(false);
            this.pnlName.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.TableLayoutPanel tblDetails;
        private System.Windows.Forms.GroupBox grpToppings;
        private System.Windows.Forms.GroupBox grpCrust;
        private System.Windows.Forms.Panel pnlName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Panel pnlSauce;
        private System.Windows.Forms.ComboBox cmbSauce;
        private System.Windows.Forms.Label lblSauce;
        private System.Windows.Forms.Label lblBasePrice;
        private System.Windows.Forms.RadioButton radCrustThick;
        private System.Windows.Forms.RadioButton radCrustThin;
        private System.Windows.Forms.RadioButton radCrustGlutenFree;
        private System.Windows.Forms.Label lblSurcharge;
        private System.Windows.Forms.Label lblToppings;
        private System.Windows.Forms.TableLayoutPanel tblToppings;
        private System.Windows.Forms.Button btnDone;
    }
}

