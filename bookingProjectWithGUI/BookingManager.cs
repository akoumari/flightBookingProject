using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace bookingProjectWithGUI
{
    class BookingManager
    {
        private int maxBookings;
        private int numBookings;
        private SqlConnection con;

        public BookingManager(int max)
        {
            maxBookings = max;
            numBookings = 0;
            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\CustAndBooking.mdf;Integrated Security=True");

        }
        public bool addBooking( Customer cust, Flight fl)
        {
            if (numBookings >= maxBookings) { return false; }
            Booking b = new Booking(fl, cust);
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT into tbl_Bookings (date, flightNumber, customerId,customerName) values ('" + b.getDate() + "','" + fl.getFlightNumber() + "','" + cust.getId() + "','" + cust.getFirstName()+" "+cust.getLastName() + "');";
            cmd.ExecuteNonQuery();
            con.Close();
            return true;
        }
        public bool removeBooking(int fid, int cid)
        {
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "DELETE from tbl_Bookings WHERE flightNumber = " + fid+" and customerId = "+cid;
                cmd.ExecuteNonQuery();
                con.Close();
                return true;
            }
        }
        public bool removeBookings(int fid)
        {
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "DELETE from tbl_Bookings WHERE flightNumber = " + fid;
                cmd.ExecuteNonQuery();
                con.Close();
                return true;
            }
        }
        public bool deleteBookingsCust(int cid)
        {
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "DELETE from tbl_Bookings WHERE customerId = " + cid;
                cmd.ExecuteNonQuery();
                con.Close();
                return true;
            }
        }

        public DataTable getBookingList()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select date as 'Date Booked', bookingNum AS 'Booking Number', customerName AS 'Customer Name', flightNumber AS 'Flight Number' from tbl_Bookings;";
            cmd.ExecuteNonQuery();
            DataTable dTable = new DataTable();
            SqlDataAdapter dAdapter = new SqlDataAdapter(cmd);
            dAdapter.Fill(dTable);
            con.Close();
            return dTable;
        }
    }
}
