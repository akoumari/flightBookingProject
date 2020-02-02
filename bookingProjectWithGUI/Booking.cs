using System;
using System.Collections.Generic;
using System.Text;

namespace bookingProjectWithGUI
{
    class Booking
    {
        private string date;
        private Flight flight;
        private Customer cust;

        public Booking( Flight flight, Customer cust)
        {
            date = DateTime.Now.ToString(@"MM\/dd\/yyyy h\:mm tt");
            this.flight = flight;
            this.cust = cust;
        }
        public string getDate()
        {
            return date;
        }
        public override string ToString()
        {
            string s = "\nFlight: " + flight.getFlightNumber();
            s += "\nCustomer name: " + cust.getFirstName() + " " + cust.getLastName();
            s += "\nDate of booking: " + date;
            return s;
        }
    }
}
