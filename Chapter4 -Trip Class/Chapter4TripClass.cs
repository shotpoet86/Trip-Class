/* Programmer: Austin Parker
   Date: Feb 3rd, 2020
   Purpose: This program displays how
   to make use of classes that can be attached to main program.
 */
using static System.Console;

namespace Chapter4__Trip_Class
{
    internal class Chapter4TripClass
    {
        // Using Main class as second class for testing Trip class.
        private static void Main()
        {
            var trip = new Trip();

            trip.Destination = "Atlanta";
            trip.DistanceTraveled = 300;
            trip.TotalGasCost = 29.16;
            trip.GallonsConsumed = 12;
            trip.Mpg();

            WriteLine(trip.ToString());
            Read();
        }
    }
}