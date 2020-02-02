using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace bookingProjectWithGUI
{
    public class AirlineCoordinator
    {
        FlightManager flManager;
        CustomerManager custManager;
        BookingManager bookManager;


        public AirlineCoordinator(int maxCust, int maxFlights, int maxBookings )
        {
            flManager = new FlightManager(maxFlights);
            custManager = new CustomerManager(maxCust);
            bookManager = new BookingManager(maxBookings);
        }

        public bool addFlight(int flightNo, string origin, string destination, int maxSeats)
        {
            return flManager.addFlight(flightNo, origin, destination, maxSeats);
        }

        public bool addCustomer(string fname, string lname, string phone)
        {
            return custManager.addCustomer(fname, lname, phone);
        }
        public bool addBooking(Customer cust, Flight fl)
        {
            return bookManager.addBooking(cust, fl);
        }
        public DataTable passengerList(int fid)
        {
            return flManager.getPassengerList(fid);
        }

        public DataTable flightList()
        {
            return flManager.getFlightList();
        }
        public Flight getFlight(int id)
        {
            return flManager.getFlight(id);
        }
        public Customer getCustomer(int id)
        {
            return custManager.getCustomer(id);
        }

        public DataTable customerList()
        {
            return custManager.getCustomerList();
        }
        public DataTable bookingList()
        {
            return bookManager.getBookingList();
        }
        public bool deleteCustomer(int id)
        {
            return custManager.deleteCustomer(id);
        }

        public bool deleteFlight(int fid)
        {
            return flManager.deleteFlight(fid);
        }
        public bool addPassenger(int fid, int cust, string name)
        {
            return flManager.addPassenger(fid, cust, name);
        }
        public bool removePassengers(int fid)
        {
            return flManager.removePassengers(fid);
        }
        public bool deleteBookingsCust(int cid)
        {
            return bookManager.deleteBookingsCust(cid);
        }
        public bool propagateDeleteCust(int cid)
        {
            return flManager.propagateDeleteCust(cid);
        }
        public bool removeBookings(int fid)
        {
            return bookManager.removeBookings(fid);
        }
        public bool removeBooking(int fid, int cid)
        {
            return bookManager.removeBooking(fid, cid);
        }
        public bool removePassenger(int fid, int cust)
        {
            return flManager.removePassenger(fid, cust);
        }

    }

}
