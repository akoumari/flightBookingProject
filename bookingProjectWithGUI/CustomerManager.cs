using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace bookingProjectWithGUI
{
    class CustomerManager
    {
        private int maxNumCustomers;
        private int numCustomers;
        private SqlConnection con;


        public CustomerManager(int max)
        {
            maxNumCustomers = max;
            numCustomers = 0;
            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\CustAndBooking.mdf;Integrated Security=True");
        }

        public bool addCustomer(string fn, string ln, string ph)
        {
            if (numCustomers >= maxNumCustomers) { return false; }
            Customer c = new Customer(0, fn, ln, ph);
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT into tbl_Customer (firstName,lastName,phone,bookings) values ('" + fn + "','" + ln + "','" + ph + "','0');";
            cmd.ExecuteNonQuery();
            con.Close();
            numCustomers++;
            return true;
        }
        public Customer getCustomer(int cid)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM tbl_Customer WHERE customerId = " + cid;
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            Customer c = new Customer(reader.GetInt32(0),reader.GetString(1), reader.GetString(2), reader.GetString(3));
            reader.Close();
            con.Close();
            return c;
        }


        public bool deleteCustomer(int cid)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "DELETE FROM tbl_Customer WHERE customerId = " + cid;
            cmd.ExecuteNonQuery();
            con.Close();
            numCustomers--;
            return true;
        }

        public DataTable getCustomerList()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select CustomerID as 'ID', concat(firstName, concat(' ', lastName)) as 'Name', phone as 'Phone Number', bookings as 'Number of Tickets Booked'  from tbl_Customer";
            cmd.ExecuteNonQuery();
            DataTable dTable = new DataTable();
            SqlDataAdapter dAdapter = new SqlDataAdapter(cmd);
            dAdapter.Fill(dTable);
            con.Close();
            return dTable;
        }

    }
}
