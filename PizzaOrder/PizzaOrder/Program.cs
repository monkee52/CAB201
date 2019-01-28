using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaOrder {
    /*
     * Presents the user with a form to order a pizza. The user can enter their name, pizza base,
     * pizza sauce and any number of toppings. When the user has finished selecting their options,
     * the program presents the user with a price.
     * 
     * Author: Ayden Hull, 9749675
     * Date: September 2016
     */
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmOrderForm());
        }
    }
}
