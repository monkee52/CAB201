using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaOrder {
    public partial class frmOrderForm : Form {
        /// <summary>
        /// A list of optional toppings for the pizza
        /// </summary>
        public readonly string[] Toppings = {
            "Tomatoes",
            "Olives",
            "Pepperoni",
            "Capsicum",
            "Jalapeños",
            "Ham",
            "Spinach",
            "Pineapple",
            "Chicken",
            "Ground beef",
            "Mushroom",
            "Bacon",
            "Prawn",
            "Mozarella cheese",
            "Feta cheese",
            "Cheddar cheese"
        };

        /// <summary>
        /// Keep track of all the checkboxes for the toppings
        /// </summary>
        private List<CheckBox> checkboxes;

        public frmOrderForm() {
            this.InitializeComponent();
            this.InitializeCheckboxes();
        }

        /// <summary>
        /// Create all the checkboxes for the toppings. Initially disabled.
        /// </summary>
        private void InitializeCheckboxes() {
            this.checkboxes = new List<CheckBox>();

            const int PADDING_LEFT = 13;
            const int PADDING_NORMAL = 3;

            const int HORIZONTAL_INCREMENT = 88;
            const int HORIZONTAL_OFFSET = 3;

            const int VERTICAL_INCREMENT = 30;
            const int VERTICAL_OFFSET = 3;

            const int COLUMNS = 4;

            int cellCount = this.tblToppings.RowCount * this.tblToppings.ColumnCount;
            int length = Math.Min(this.Toppings.Length, cellCount);

            for (int i = 0; i < length; i++) {
                int x = i / COLUMNS;
                int y = i % COLUMNS;

                CheckBox checkbox = new CheckBox();

                checkbox.AutoSize = true;
                checkbox.Location = new Point(HORIZONTAL_OFFSET + HORIZONTAL_INCREMENT * x, VERTICAL_OFFSET + VERTICAL_INCREMENT * y);
                checkbox.Name = "chkTopping" + (i + 1).ToString();
                checkbox.TabIndex = i;
                checkbox.Text = this.Toppings[i];
                checkbox.UseVisualStyleBackColor = true;
                checkbox.Margin = new Padding(PADDING_LEFT, PADDING_NORMAL, PADDING_NORMAL, PADDING_NORMAL);
                checkbox.Enabled = false;

                checkbox.Click += new EventHandler(this.chkTopping_Click);

                this.checkboxes.Add(checkbox);

                this.tblToppings.Controls.Add(checkbox, x, y);
            }
        }

        private void frmOrderForm_Load(object sender, EventArgs e) {
            // Focus the user's name text box first
            this.txtName.Focus();
        }

        private void txtName_TextChanged(object sender, EventArgs e) {
            this.radCrustThin.Enabled = true;
            this.radCrustThick.Enabled = true;
            this.radCrustGlutenFree.Enabled = true;
        }

        private void radCrust_CheckedChanged(object sender, EventArgs e) {
            this.cmbSauce.Enabled = true;
        }

        private void cmbSauce_SelectedIndexChanged(object sender, EventArgs e) {
            // Lambda function to enable all checkboxes
            // - Known from previous experience with C#
            this.checkboxes.ForEach((CheckBox checkbox) => checkbox.Enabled = true);
        }

        private void chkTopping_Click(object sender, EventArgs e) {
            this.btnDone.Visible = true;
        }

        /// <summary>
        /// Counts the number of checked toppings
        /// </summary>
        /// <returns>THe number of toppings</returns>
        private int GetToppingCount() {
            return this.checkboxes.Count((CheckBox checkbox) => checkbox.Checked);
        }

        /// <summary>
        /// Calculates the cost of a pizza based on the user entered values
        /// </summary>
        /// <returns>The price of the pizza</returns>
        private decimal GetTotalCost() {
            const int FREE_TOPPINGS = 4;
            const decimal ADDITIONAL_TOPPING_COST = 1.0M;
            const decimal GLUTEN_CRUST_COST = 2.0M;
            const decimal PIZZA_BASE_PRICE = 10.0M;

            int toppingCount = this.GetToppingCount();

            decimal price = PIZZA_BASE_PRICE;

            // Factor in additional toppings
            if (toppingCount > FREE_TOPPINGS) {
                price += ADDITIONAL_TOPPING_COST * (toppingCount - FREE_TOPPINGS);
            }

            // Factor in the crust choice
            if (this.radCrustGlutenFree.Checked) {
                price += GLUTEN_CRUST_COST;
            }

            return price;
        }

        /// <summary>
        /// Gets the name the user entered on the form
        /// </summary>
        /// <returns>The user's name</returns>
        private string GetName() {
            return this.txtName.Text;
        }

        /// <summary>
        /// Returns the user selected pizza base as a lower case string.
        /// If the radio button has a tag value set, it is cast to a string
        /// and returned instead of the text value.
        /// </summary>
        /// <returns>The user selected pizza base</returns>
        private string GetPizzaBase() {
            RadioButton[] radios = new[] { this.radCrustThin, this.radCrustThick, this.radCrustGlutenFree };

            RadioButton radio = radios.First((RadioButton r) => r.Checked);

            string text = radio.Text;

            // Check if there is alternative text to return
            if (radio.Tag != null) {
                text = (string)radio.Tag;
            }

            return text.ToLower();
        }

        /// <summary>
        /// Returns the user selected pizza sauce
        /// </summary>
        /// <returns>The user selected pizza sauce</returns>
        private string GetPizzaSauce() {
            return ((string)this.cmbSauce.SelectedItem).ToLower();
        }

        private void btnDone_Click(object sender, EventArgs e) {
            string name = this.GetName();
            string pizzaBase = this.GetPizzaBase();
            string sauce = this.GetPizzaSauce();
            int toppingCount = this.GetToppingCount();
            decimal price = this.GetTotalCost();

            if (name.Length == 0) {
                MessageBox.Show("You must enter a name!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);

                this.txtName.Focus();

                return;
            }

            if (toppingCount == 0) {
                MessageBox.Show("You must select at least one topping.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            string message = "Thank you for your order {0}, for a {1} pizza base with {2} sauce and {3} toppings.\n\nThe cost of your pizza is ${4:F2}";

            MessageBox.Show(string.Format(message, name, pizzaBase, sauce, toppingCount, price), this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            MessageBox.Show("Thanks for ordering from Beagle Boys Pizza,\nyour pizza will be delivered in 30 minutes or it's free!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }
    }
}
