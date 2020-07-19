/* Programmer: Austin Parker
   Date: Feb 3rd, 2020
   Purpose: This program displays how
   to make use of classes that can be attached to main program.
 */
using System;
using static System.Console;

namespace Chapter4__Trip_Class
{
    public class Trip
    {
        //Fields
        private string destination;
        private double distanceTraveled;
        private double totalGasCost;
        private double gallonsConsumed;
  

        //Constructors
        public Trip()
        {

        }
        public Trip(string Destination)
        {
            Destination = destination;
        }
        public Trip(double distance, double totalGas, double totalGallonsConsumed)
        {
            distanceTraveled = distance;
            totalGasCost = totalGas;
            gallonsConsumed = totalGallonsConsumed;
        }

        //Properties 
        public string Destination
        {
            get { return destination; }

            set { destination = value; }
        }
        public double DistanceTraveled
        {
            get { return distanceTraveled; }

            set { distanceTraveled = value; }
        }
        public double TotalGasCost
        {
            get { return totalGasCost; }

            set { totalGasCost = value; }
        }
        public double GallonsConsumed
        {
            get { return gallonsConsumed; }

            set { gallonsConsumed = value; }
        }

        //Methods for calculating values
        public double Mpg()
        {
            return distanceTraveled / gallonsConsumed;
        }
        public double CostPerMile()
        {
            return totalGasCost / distanceTraveled *10;
        }
        //Method for displaying content in Main project.
        public override string ToString()
        {
            return "Destination: " + Destination + "\n" + "\n   Distance traveled: " + DistanceTraveled + " mi." +
                   "\n   Cost of gasonline per gallon: $ " + totalGasCost + "\n   Gallons consumed: " + GallonsConsumed + " gal.\n" +
                   "\n   Miles per gallon: " + Mpg() + " mpg." +
                   "\n   Trip cost per mile: $ " + CostPerMile() + "\n";
        }
    }
}





