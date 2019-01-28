using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FuelCalculator {
    /*
     * Calculates fuel consumption in L/100km and the equivalent mpg,
     * input units of measurement are litres (L) for the fuel used and
     * kilometers (km) for the distance travelled
     * 
     * Author: Ayden Hull, 9749675
     * Date: August 2016
     */
    class Program {
        // The minimum allowable fuel in litres
        const double FUEL_MIN = 20D;

        // The multiplier used against litres to get the minimum distance
        const double DISTANCE_MIN_MULTIPLIER = 8D;

        const double KM_100 = 100D;

        // Conversion factor to km/L to mpg
        const double KM_L_TO_MPG = 2.824809363D;

        /// <summary>
        /// Creates a help string based on input criterion
        /// </summary>
        /// <param name="minimum">Minimum number allowed</param>
        /// <param name="maximum">Maximum number allowed</param>
        /// <param name="mustBeInt">Determines if the number supplied must be whole</param>
        /// <returns></returns>
        static string GetInputCriterion(double? minimum = null, double? maximum = null, bool mustBeInt = false) {
            StringBuilder str = new StringBuilder();

            // Type of number
            str.Append(String.Format("Enter a {0} number", mustBeInt ? "natural" : "real"));

            // Minimum
            if (minimum != null) {
                str.Append(String.Format(" that is at least {0}", minimum));
            }

            // Maximum
            if (maximum != null) {
                str.Append(String.Format(" and no greater than {0}", maximum));
            }

            str.Append(".");

            return str.ToString();
        }

        /// <summary>
        /// Repeatedly prompts the user for a value until it is valid according to inputted parameters
        /// </summary>
        /// <param name="prompt">A string prompt to display before the input field</param>
        /// <param name="minimum">Minimum number allowed</param>
        /// <param name="maximum">Maximum number allowed</param>
        /// <param name="mustBeInt">Determines if the number supplied must be whole</param>
        /// <returns>A double representing the user-entered value</returns>
        static double LoopRead(string prompt, double? minimum = null, double? maximum = null, bool mustBeInt = false) {
            bool valid = false;
            double value = 0D;

            if (prompt != null) {
                Console.WriteLine(prompt);
            }

            // Keep prompting while the user has entered an invalid number
            while (!valid) {
                Console.Write("> ");

                // Read the user input string
                valid = double.TryParse(Console.ReadLine(), out value);

                // Make sure number is in bounds if necessary
                if (minimum != null && value < minimum) {
                    valid = false;
                }

                if (maximum != null && value > maximum) {
                    valid = false;
                }

                // Make sure it's an integer if necessary
                if (mustBeInt) {
                    if (Math.Round(value) != value) {
                        valid = false;
                    }
                }

                if (!valid) {
                    Console.WriteLine(GetInputCriterion(minimum, maximum, mustBeInt));
                }
            }

            Console.WriteLine();

            return value;
        }

        /// <summary>
        /// Calculate the fuel consumption in L/100km and mpg and displays it to the user
        /// </summary>
        /// <param name="fuelUsed">The amount of fuel used</param>
        /// <param name="distanceTravelled">The distance travelled</param>
        static void DisplayFuelConsumption(double fuelUsed, double distanceTravelled) {
            double fuelConsumption = fuelUsed / distanceTravelled * KM_100;
            double mpg = 1D / fuelConsumption * KM_100 * KM_L_TO_MPG;

            Console.WriteLine();
            Console.WriteLine("Fuel consumption: {0:F} L/100km or {1:F} mpg", fuelConsumption, mpg);
            Console.WriteLine();
        }

        /// <summary>
        /// Displays the user with a simple menu
        /// </summary>
        /// <param name="prompt">An optional string prompt</param>
        /// <param name="options">A list of string options as a menu</param>
        /// <returns>The user selected option</returns>
        static double DisplayMenu(string prompt, string[] options) {
            // Display prompt
            if (prompt != null) {
                Console.WriteLine(prompt);
                Console.WriteLine();
            }

            for (int i = 0; i < options.Length; i++) {
                Console.WriteLine("{0}. {1}", i + 1, options[i]);
            }

            return LoopRead(null, 1, options.Length, true);
        }

        /// <summary>
        /// Shows a welcome message
        /// </summary>
        static void DisplayWelcome() {
            Console.WriteLine("Welcome to the Fuel Efficiency Calculator");
        }

        /// <summary>
        /// Halts the execution of the program until the user press a key
        /// </summary>
        static void Halt() {
            Console.Write("Press any key to continue...");

            Console.ReadKey(true);
        }

        static void Main(string[] args) {
            DisplayWelcome();

            bool keepGoing = true;

            while (keepGoing) {
                // Get the necessary data from the user
                double fuelUsed = LoopRead("Fuel used (L):", FUEL_MIN);

                double distanceTravelled = LoopRead("Distance travelled (km):", fuelUsed * DISTANCE_MIN_MULTIPLIER);

                DisplayFuelConsumption(fuelUsed, distanceTravelled);

                // Allow the user to repeat calculation
                keepGoing = DisplayMenu("Another calculation?", new string[] {
                    "Yes",
                    "No"
                }) == 1D;
            }

            // Terminate gracefully
            Halt();
        }
    }
}
