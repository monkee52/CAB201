using System;
using System.Globalization;
using System.Text;

namespace TrainTimetable {
    /*
     * Calculates the departure time from a selected station in a way
     * that makes sure the user will arrive at their other selected at
     * or before their requested arrival time.
     * 
     * Author: Ayden Hull, 9749675
     * Date: September 2016
     */
    enum Stations { Central, Roma_Street, Milton, Auchenflower, Toowong, Taringa, Indooroopilly };

    class Program {

        public const int NUMBER_OF_TRAINS = 76;
        public const int NUMBER_OF_STATIONS = 7;
        static int[,] timeTable = new int[NUMBER_OF_STATIONS, NUMBER_OF_TRAINS];

        public const int MAX_STATION = NUMBER_OF_STATIONS - 1;

        static string departFrom = "\n Which station are you leaving from?\n"
                              + "\n1) Central"
                              + "\n2) Roma Street"
                              + "\n3) Milton"
                              + "\n4) Auchenflower"
                              + "\n5) Toowong"
                              + "\n6) Taringa"
                              + "\n\nEnter your option(1-6 or 0 to exit): ";

        static string arriveAt = "\n Which station are you going to?\n"
                           + "\n1) Roma Street"
                           + "\n2) Milton"
                           + "\n3) Auchenflower"
                           + "\n4) Toowong"
                           + "\n5) Taringa"
                           + "\n6) Indooroopilly"
                           + "\n\nEnter your option(1-6 or 0 to exit): ";

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
        /// Converts a TimeSpan into a string using a specified format
        /// </summary>
        /// <param name="time">The TimeSpan</param>
        /// <param name="format">An optional format</param>
        /// <returns></returns>
        static string ConvertTimeSpanToString(TimeSpan time, string format = "hh:mm tt") {
            DateTimeOffset dateTime = DateTime.Today + time;

            return dateTime.ToString(format);
        }

        /// <summary>
        /// Continously asks for a time until the user entered time is valid
        /// </summary>
        /// <param name="prompt">An optional prompt to display before prompting</param>
        /// <returns>The user entered time</returns>
        static TimeSpan LoopReadTimeSpan(string prompt, TimeSpan[,] timetable, Stations? endAt) {
            bool valid = false;
            TimeSpan value = default(TimeSpan);

            TimeSpan min = timetable[(int)endAt, 0];
            TimeSpan max = TimeSpan.FromTicks(TimeSpan.TicksPerDay - 1); // 1 day - 1 "tick"

            if (prompt != null) {
                Console.WriteLine(prompt);
            }

            while (!valid) {
                Console.Write("> ");

                // Attempt parsing as 24-hour time
                valid = TimeSpan.TryParseExact(Console.ReadLine(), "g", CultureInfo.CurrentCulture, out value);

                if (valid && (value < min || value > max)) {
                    Console.WriteLine("You cannot catch any train to arrive by {0} at {1}", ConvertTimeSpanToString(value), endAt);
                    Console.WriteLine();

                    valid = false;
                }
            }

            Console.WriteLine();

            return value;
        }

        /// <summary>
        /// Determine if the selected stations are compatible for the journey
        /// </summary>
        /// <param name="startAt"></param>
        /// <param name="endAt"></param>
        /// <returns>Whether the journey is possible</returns>
        static bool AreStationsValid(Stations? startAt, Stations? endAt) {
            if (startAt > endAt) {
                Console.WriteLine("You cannot travel from {0} to {1}, this enquiry is cancelled.", startAt, endAt);

                return false;
            }

            if (startAt == endAt) {
                Console.WriteLine("You have selected {0} as both your departure and arrival station, this enquiry is cancelled.", startAt);

                return false;
            }

            return true;
        }

        /// <summary>
        /// Given an 2d array of HHMM (decimal integer) times, convert them to TimeSpans
        /// </summary>
        /// <param name="timetable">The timetable</param>
        /// <returns>The timetable consisting of TimeSpans</returns>
        static TimeSpan[,] ConvertTimetableToTimeSpans(int[,] timetable) {
            const int HOURS_DISPLACEMENT_FACTOR = 100;
            const int LOWER_TWO_DIGITS_MASK = 100;

            TimeSpan[,] output = new TimeSpan[timetable.GetLength(0), timetable.GetLength(1)];

            for (int station = 0; station < timetable.GetLength(0); station++) {
                for (int time = 0; time < timetable.GetLength(1); time++) {
                    int hours = timetable[station, time] / HOURS_DISPLACEMENT_FACTOR;
                    int minutes = timetable[station, time] % LOWER_TWO_DIGITS_MASK;

                    output[station, time] = new TimeSpan(hours, minutes, 0);
                }
            }

            return output;
        }

        /// <summary>
        /// Get the station the user is departing from
        /// </summary>
        /// <returns>The user selected station</returns>
        static Stations? GetStartingStation() {
            const int DEPARTURE_STATION_CORRECTION_OFFSET = 1;

            int startingStationRaw = (int)LoopRead(departFrom, 0, MAX_STATION, true);

            if (startingStationRaw == 0) {
                return null;
            }

            return (Stations)(startingStationRaw - DEPARTURE_STATION_CORRECTION_OFFSET);
        }

        /// <summary>
        /// Get the station the user is going to
        /// </summary>
        /// <returns>The user selected station</returns>
        static Stations? GetEndingStation() {
            int endingStationRaw = (int)LoopRead(arriveAt, 0, MAX_STATION, true);

            if (endingStationRaw == 0) {
                return null;
            }

            return (Stations)endingStationRaw;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="timetable">The timetable</param>
        /// <param name="station">The station</param>
        /// <param name="latestTime">The latest time the user can arrive at the station</param>
        /// <returns></returns>
        static int GetStationArrivalTimeIndex(TimeSpan[,] timetable, Stations? station, TimeSpan latestTime) {
            int lastTimeIndex = timetable.GetLength(1) - 1;

            while (lastTimeIndex > 0 && timetable[(int)station, lastTimeIndex] >= latestTime) {
                --lastTimeIndex;
            }

            return lastTimeIndex;
        }

        /// <summary>
        /// Given a starting and ending station, with a time index, present the user with their departure time
        /// </summary>
        /// <param name="timetable">The timetable</param>
        /// <param name="startingStation">The starting station</param>
        /// <param name="endingStation">The ending station</param>
        /// <param name="timeIndex">The offset into the station times</param>
        static void DisplayDepartureTime(TimeSpan[,] timetable, TimeSpan latestArrivalTime, Stations? startingStation, Stations? endingStation, int timeIndex) {
            Console.WriteLine(
                "To arrive at {0} by {1}, you need to catch the train from {2} at {3}.",
                endingStation,
                ConvertTimeSpanToString(latestArrivalTime),
                startingStation,
                ConvertTimeSpanToString(timetable[(int)startingStation, timeIndex])
            );
        }

        static void Main() {
            // ********** Do not remove the following statement ******************
            timeTable = Timetables.CreateTimeTable();

            //*********** Start your code for Main below this line  ******************

            TimeSpan[,] timespanTimetable = ConvertTimetableToTimeSpans(timeTable);

            // Get the starting station, exit on user request
            Stations? startingStation = GetStartingStation();

            if (startingStation == null) {
                ExitProgram();

                return;
            }

            // Get the ending station, exit on user request
            Stations? endingStation = GetEndingStation();

            if (endingStation == null) {
                ExitProgram();

                return;
            }

            // Check if journey is possible
            if (!AreStationsValid(startingStation, endingStation)) {
                ExitProgram();

                return;
            }

            // Calculate journey
            string timePrompt = String.Format("Latest time to arrive at {0} (24-hour format):", endingStation);

            TimeSpan latestArrivalTime = LoopReadTimeSpan(timePrompt, timespanTimetable, endingStation);

            // The index of the arrival time will be the index of the departure time, with different stations
            int prevStationArrivalTimeIndex = GetStationArrivalTimeIndex(timespanTimetable, endingStation, latestArrivalTime);

            DisplayDepartureTime(timespanTimetable, latestArrivalTime, startingStation, endingStation, prevStationArrivalTimeIndex);

            ExitProgram();

            return;
        }// end Main

        /// <summary>
        /// Will exit the project once the user has pressed any key
        /// </summary>
        static void ExitProgram() {
            Console.Write("\n\n\t Press any key to terminate program ...");
            Console.ReadKey();
        }//end ExitProgram
    }//end class
}//end nameSpace
