using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieCounter {
    class Program {

        const int DAYS_IN_WEEK = 7;
        const int MEALS_IN_DAY = 3;
        static string[] DaysOfWeek = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
        static string[] MealsOfDay = { "Breakfast", "Lunch", "Dinner" };

        static void Main(string[] args) {

            int[,] calories = {{900, 750, 1020 },
                               {300, 1000, 2700 },
                               {500, 700, 2100 },
                               {400, 900, 1780 },
                               {600, 1200, 1100},
                               {575, 1150, 1900 },
                               {600, 1020, 1700 } };

            double[] dailyAverage = new double [DAYS_IN_WEEK];
            double[] mealAverage = new double[MEALS_IN_DAY];

            Welcome();

            dailyAverage = CalculateAverageByDay(calories);
            mealAverage = CalculateAverageByMeal(calories);

            DisplayDailyAverage(dailyAverage);
            DisplayMealAverage(mealAverage);
            DisplayAverageCaloriesPerMeal(calories);

            ExitProgram();
        }//end Main



        static double [] CalculateAverageByDay(int[,] calories) {
            int totalByDay = 0;
            double [] dailyAverage = new double[DAYS_IN_WEEK];

            for(int row = 0; row < DAYS_IN_WEEK; row++) {
                for (int column = 0; column < MEALS_IN_DAY; column++) {
                    totalByDay = totalByDay + calories[row, column];
                }
                dailyAverage[row] = (double) totalByDay / MEALS_IN_DAY;
                totalByDay = 0;
            }//end for (int row ...)

            return dailyAverage;
        }//end CalculateAverageByDay

        static void DisplayDailyAverage(double [] dailyAverage) {
            int dayNumber = 0;

            Console.WriteLine("\t    Daily Averages\n");
             foreach (double average in dailyAverage) {
                Console.WriteLine("\t{0, -12}: {1, 6:N0}\n", DaysOfWeek[dayNumber], average);
                dayNumber++;
             }//end foreach
        }// end DisplayDailyAverage


        static double [] CalculateAverageByMeal(int[,] calories) {
            int totalByMeals = 0;

            double[] mealAverage = new double[MEALS_IN_DAY];

            for (int i = 0; i < DAYS_IN_WEEK; i++) {
                for (int j = 0; j < MEALS_IN_DAY; j++) {
                    mealAverage[j] += calories[i, j];
                }
            }

            for (int i = 0; i < MEALS_IN_DAY; i++) {
                mealAverage[i] /= MEALS_IN_DAY;
            }

            // Calculate the average number of calories per meal

            return mealAverage;
        }//end CalculateAverageByMeal

        static void DisplayMealAverage(double [] mealAverage) {

            Console.WriteLine("\n\n\t    Average per Meal\n");

            for (int i = 0; i < MEALS_IN_DAY; i++) {
                Console.WriteLine("\t{0, -12}: {1, 6:N0}\n", MealsOfDay[i], mealAverage[i]);
            }

            // Output the average number of calories per meal

        }//end DisplayMealAverage

        
        
        static void DisplayAverageCaloriesPerMeal(int[,] calories) {
            int totalCalories = 0;

            // Calculate the total numberr of calories consumed in a week 
            for (int i = 0; i < DAYS_IN_WEEK; i++) {
                for (int j = 0; j < MEALS_IN_DAY; j++) {
                    totalCalories += calories[i, j];
                }
            }

            Console.WriteLine("Overall average per meal: {0, 6:N0}", totalCalories / DAYS_IN_WEEK / MEALS_IN_DAY);

            // Output the average calories per meal

        }//end DisplayAverageCaloriesPerMeal 



        static void Welcome() {
            Console.WriteLine("\n\n\t Welcome to Calorie Counter\n\n");
        }//end Welcome

        static void ExitProgram() {
            Console.Write("Press any key to exit ...");
            Console.ReadKey();
        }//end ExitProgram



    }//end class
}
