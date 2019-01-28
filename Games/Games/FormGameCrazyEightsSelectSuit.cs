using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Low_Level_Objects_Library;

namespace Games {
    public partial class FormGameCrazyEightsSelectSuit : Form {
        public Suit ReturnValue { get; private set; }

        private List<RadioButton> suitButtons;

        public FormGameCrazyEightsSelectSuit() {
            InitializeComponent();

            this.suitButtons = new List<RadioButton>() {
                this.radClubs,
                this.radDiamonds,
                this.radHearts,
                this.radSpades
            };

            this.radClubs.Tag = Suit.Clubs;
            this.radDiamonds.Tag = Suit.Diamonds;
            this.radHearts.Tag = Suit.Hearts;
            this.radSpades.Tag = Suit.Spades;
        }

        private void btnAccept_Click(object sender, EventArgs e) {
            RadioButton radChecked = this.suitButtons.FirstOrDefault((RadioButton radSuit) => radSuit.Checked);

            if (radChecked == null) {
                MessageBox.Show("You must select a suit.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            this.ReturnValue = (Suit)this.suitButtons.First((RadioButton radSuit) => radSuit.Checked).Tag;
            this.DialogResult = DialogResult.OK;

            this.Close();
        }
    }
}
