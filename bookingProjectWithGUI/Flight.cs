using System;
using System.Collections.Generic;
using System.Text;

namespace bookingProjectWithGUI
{
    public class Flight
    {
        private int flightNumber;
        private string origin;
        private string destination;
        private int maxSeats;
        private int numPassengers;
        private Customer[] passengers;

        public Flight(int fn, string or, string dest, int mSeats)
        {
            maxSeats = mSeats;
            flightNumber = fn;
            origin = or;
            destination = dest;
            numPassengers = 0;
            passengers = new Customer[maxSeats];
        }

        public int getFlightNumber() { return flightNumber; }
        public string getOrigin() { return origin; }
        public string getDestination() { return destination; }
        public int getMaxSeats() { return maxSeats; }
        public int getNumPassengers() { return numPassengers; }


    }
}
