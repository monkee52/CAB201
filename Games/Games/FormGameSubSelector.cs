using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Games {
    /// <summary>
    /// Allows the user to pick a game based on the genre provided
    /// </summary>
    public partial class FormGameSubSelector : Form {
        public Games ReturnValue { get; private set; }

        private bool safeToReturn = false;
        private bool internalClose = false;

        public FormGameSubSelector(string caption, Games[] games) {
            InitializeComponent();

            this.Text = "Which " + caption + " Game?";

            List<KeyValuePair<Games, string>> options = new List<KeyValuePair<Games, string>>();

            // Creates a drop-down option for each game, with the enum value and then the user-friendly name
            foreach (Games game in games) {
                options.Add(new KeyValuePair<Games, string>(game, GamesImplementation.GetGameName(game)));
            }

            this.cmbGame.DataSource = options;
            this.cmbGame.SelectedItem = null;
        }

        private void cmbGame_SelectedIndexChanged(object sender, EventArgs e) {
            // Prevent closing straight after form is opened.
            if (this.safeToReturn) {
                // Allow parent form to access user selected option
                this.ReturnValue = ((KeyValuePair<Games, string>)this.cmbGame.SelectedItem).Key;
                this.DialogResult = DialogResult.OK;

                this.internalClose = true;

                this.Close();
            }
        }

        private void FormGameSubSelector_Load(object sender, EventArgs e) {
            this.safeToReturn = true;
        }

        private void FormGameSubSelector_FormClosing(object sender, FormClosingEventArgs e) {
            // Only question user if they didn't make a selection
            if (!this.internalClose) {
                DialogResult result = MessageBox.Show("Do you really want to quit?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.No) {
                    e.Cancel = true;
                }
            }
        }
    }
}
