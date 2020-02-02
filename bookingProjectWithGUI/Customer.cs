using System;
using System.Collections.Generic;
using System.Text;

namespace bookingProjectWithGUI
{
    public class Customer
    {

        private string firstName;
        private string lastName;
        private string phone;
        private int bookings;
        private int cid;

        public Customer(int cid, string fname, string lname, string ph)
        {
            bookings = 0;
            this.cid = cid;
            firstName = fname;
            lastName = lname;
            phone = ph;
        }

        public int getId() { return cid; }
        public string getFirstName() { return firstName; }
        public string getLastName() { return lastName; }
        public string getPhone() { return phone; }
        public int getNumBookings() { return bookings; }


    }

}
