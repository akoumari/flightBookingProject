using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace bookingProjectWithGUI
{
    class FlightManager
    {

        private int maxFlights;
        private int numFlights;
        private SqlConnection con;
        

        public FlightManager(int max)
        {
            maxFlights = max;
            numFlights = 0;
            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Flight.mdf;Integrated Security=True");
           
        }

        public bool addFlight(int fn, string origin, string destination, int maxSeats)
        {
            if (numFlights >= maxFlights) { return false; }
            Flight f = new Flight(fn, origin, destination, maxSeats);
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT into tbl_Flights (flightNumber,origin,destination,maxSeats,numPassengers) values ('" + fn + "','" + origin + "','" + destination + "','" + maxSeats + "','0');";
            cmd.ExecuteNonQuery();
            con.Close();
            numFlights++;
            return true;
        }

        public Flight getFlight(int fid)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from tbl_Flights WHERE flightNumber = " + fid;
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            if(!reader.HasRows) { con.Close(); return null; }
            Flight f = new Flight(reader.GetInt32(0),reader.GetString(1), reader.GetString(2), reader.GetInt32(3));
            reader.Close();
            con.Close();
            return f;
        }

        public bool deleteFlight(int fid)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "DELETE FROM tbl_Flights WHERE flightNumber = "+fid;
            cmd.ExecuteNonQuery();
            con.Close();
            numFlights--;
            return true;
        }
        public bool addPassenger(int fid, int custId, string name)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from tbl_Flights WHERE flightNumber = " + fid;
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            int numPass = reader.GetInt32(4);
            reader.Close();
            cmd.CommandText = "UPDATE tbl_Flights SET numPassengers = "+(++numPass)+" WHERE flightNumber = "+fid;
            cmd.ExecuteNonQuery();
            cmd.CommandText = "INSERT into tbl_Passengers (flightNumber,customerId,customerName) values ('" + fid + "','" + custId + "','" + name + "');";
            cmd.ExecuteNonQuery();
            con.Close();
            return true;
        }
        public bool removePassenger(int fid, int custId)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "DELETE from tbl_Passengers WHERE flightNumber = " + fid + " AND customerId = "+custId;
            cmd.ExecuteNonQuery();
            cmd.CommandText = "select * from tbl_Flights WHERE flightNumber = " + fid + ";";
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            int numPass = reader.GetInt32(4);
            reader.Close();
            cmd.CommandText = "UPDATE tbl_Flights SET numPassengers = " + (--numPass) + " WHERE flightNumber = " + fid ;
            cmd.ExecuteNonQuery();
            con.Close();
            return true;
        }
        public bool removePassenger(int pid)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "DELETE from tbl_Passengers WHERE id = " + pid;
            cmd.ExecuteNonQuery();
            con.Close();
            return true;
        }
        public bool removePassengers(int fid)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "DELETE from tbl_Passengers WHERE flightNumber = " + fid;
            cmd.ExecuteNonQuery();
            con.Close();
            return true;
        }
        public bool propagateDeleteCust(int cid)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "DELETE from tbl_Passengers WHERE customerId = " + cid;
            cmd.ExecuteNonQuery();
            con.Close();
            return true;
        }
        public DataTable getFlightList()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select flightNumber as 'Flight Number', origin as 'Port of Origin', destination as 'Port of Destination', maxSeats as 'Max Passenger Capacity', numPassengers as 'Seats Booked' from tbl_Flights";
            cmd.ExecuteNonQuery();
            DataTable dTable = new DataTable();
            SqlDataAdapter dAdapter = new SqlDataAdapter(cmd);
            dAdapter.Fill(dTable);
            con.Close();
            return dTable;
        }
        public DataTable getPassengerList(int fid)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select flightNumber as 'Flight Number', customerId as 'Customer ID', customerName as 'Customer Name' from tbl_Passengers WHERE flightNumber = "+fid;
            cmd.ExecuteNonQuery();
            DataTable dTable = new DataTable();
            SqlDataAdapter dAdapter = new SqlDataAdapter(cmd);
            dAdapter.Fill(dTable);
            con.Close();
            return dTable;
        }
    }
}
