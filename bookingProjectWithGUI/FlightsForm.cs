using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;


namespace bookingProjectWithGUI
{
    public partial class FlightsForm : Form
    {
        MainMenu f1;
        AirlineCoordinator a;
        Regex name;
        
        public FlightsForm()
        {
            InitializeComponent();
        }
        public FlightsForm(MainMenu f, AirlineCoordinator a)
        {
            this.a = a;
            f1 = f;
            InitializeComponent();
        }
        private bool isInvalid()
        {
            bool isInvalid = false;
            int test;

            if (((!int.TryParse(txtFlightNum.Text, out test)) || test < 0) || txtFlightNum.Text == string.Empty)
            {
                txtMsg.Visible = true;
                txtMsg.Text = "Red boxes need attention";
                txtFlightNum.BackColor = Color.LightPink;
                isInvalid = true;
            }
            else if(a.getFlight(Convert.ToInt32(txtFlightNum.Text)) != null)
            {
                txtMsg.Visible = true;
                txtMsg.Text = "Red boxes need attention";
                txtFlightNum.BackColor = Color.LightPink;
                isInvalid = true;
            }
            else
            {
                txtFlightNum.BackColor = Color.White;
            }
            if (((!int.TryParse(txtMaxCap.Text, out test)) && test > 0) || txtMaxCap.Text == string.Empty)
            {
                txtMsg.Visible = true;
                txtMsg.Text = "Red boxes need attention";
                txtMaxCap.BackColor = Color.LightPink;
                isInvalid = true;
            }
            else
            {
                txtMaxCap.BackColor = Color.White;
            }
            if (!name.IsMatch(txtOrigin.Text))
            {
                txtMsg.Visible = true;
                txtMsg.Text = "Red boxes need attention";
                txtOrigin.BackColor = Color.LightPink;
                isInvalid = true;
            }
            else
            {
                txtOrigin.BackColor = Color.White;
            }
            if (!name.IsMatch(txtDest.Text))
            {
                txtMsg.Visible = true;
                txtMsg.Text = "Red boxes need attention";
                txtDest.BackColor = Color.LightPink;
                isInvalid = true;
            }
            else
            {
                txtDest.BackColor = Color.White;
            }

            return isInvalid;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            
            f1.Show();
            this.Close();
        }

        private void FlightsForm_Load(object sender, EventArgs e)
        {
            name = new Regex("^[a-zA-Z]+[a-zA-z\\s\\-\\,]*$", RegexOptions.IgnoreCase | RegexOptions.IgnorePatternWhitespace);
            dgv_FlightList.DataSource = a.flightList();
            StreamReader sr = new StreamReader(Path.Combine(Environment.CurrentDirectory, @"airport.txt"));
            AutoCompleteStringCollection Collection = new AutoCompleteStringCollection();
            while (sr.Peek() >= 0)
            {
                Collection.Add(sr.ReadLine());
            }
            sr.Close();
            txtDest.AutoCompleteCustomSource = Collection;
            txtOrigin.AutoCompleteCustomSource = Collection;

        }

        private void BtnAddFlight_Click(object sender, EventArgs e)
        {
            if (!isInvalid())
            {
                a.addFlight(Convert.ToInt32(txtFlightNum.Text), txtOrigin.Text, txtDest.Text, Convert.ToInt32(txtMaxCap.Text));
                txtFlightNum.Text = "";
                txtOrigin.Text = "";
                txtDest.Text = "";
                txtMaxCap.Text = "";
                dgv_FlightList.DataSource = a.flightList();
                txtMsg.Visible = true;
                txtMsg.Text = "Add Successful";
            }

        }

        private void Dgv_FlightList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void BtnViewFlight_Click(object sender, EventArgs e)
        {
            if (dgv_FlightList.Rows.Count > 0)
            {
                int id = Convert.ToInt32(dgv_FlightList.SelectedRows[0].Cells[0].Value.ToString());
                dgv_fDetails.DataSource = a.passengerList(id);
            }
        }

        private void BtnDeleteFlight_Click(object sender, EventArgs e)
        {
            if (dgv_FlightList.Rows.Count > 0)
            {
                int id = Convert.ToInt32(dgv_FlightList.SelectedRows[0].Cells[0].Value.ToString());
                a.deleteFlight(id);
                dgv_FlightList.DataSource = a.flightList();
                a.removePassengers(id);
                a.removeBookings(id);
                dgv_fDetails.DataSource = a.passengerList(id);
                txtMsg.Visible = true;
                txtMsg.Text = "Flight deleted successfully";
            }
        }

        private void TxtFlightNum_Leave(object sender, EventArgs e)
        {
            int test;
            if(!int.TryParse(txtFlightNum.Text, out test))
            {
                txtMsg.Visible = true;
                txtMsg.Text = "Flight number must only contain numbers";
                txtFlightNum.BackColor = Color.LightPink;
            }
            else if(a.getFlight(Convert.ToInt32(txtFlightNum.Text)) != null)
            {
                txtMsg.Visible = true;
                txtMsg.Text = "Flight number already assigned";
                txtFlightNum.BackColor = Color.LightPink;
            }
            else
            {

                txtMsg.Text = "";
                txtFlightNum.BackColor = Color.White;
            }
        }

        private void TxtMaxCap_Leave(object sender, EventArgs e)
        {
            int test;
            if (!int.TryParse(txtMaxCap.Text, out test))
            {
                txtMsg.Visible = true;
                txtMsg.Text = "Flight capacity must be a positive integer";
                txtMaxCap.BackColor = Color.LightPink;
            }
            else
            {

                txtMsg.Text = "";
                txtMaxCap.BackColor = Color.White;
            }
        }

        private void TxtOrigin_Leave(object sender, EventArgs e)
        {
            if (!name.IsMatch(txtOrigin.Text))
            {
                txtMsg.Visible = true;
                txtMsg.Text = "Origin can only contain A - Z and whitespace or punctuation";
                txtOrigin.BackColor = Color.LightPink;
            }
            else
            {

                txtMsg.Text = "";
                txtOrigin.BackColor = Color.White;
            }
        }

        private void TxtDest_Leave(object sender, EventArgs e)
        {
            if (!name.IsMatch(txtDest.Text))
            {
                txtMsg.Visible = true;
                txtMsg.Text = "Destination can only contain A - Z and whitespace or punctuation";
                txtDest.BackColor = Color.LightPink;
            }
            else
            {

                txtMsg.Text = "";
                txtDest.BackColor = Color.White;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (dgv_fDetails.Rows.Count > 1)
            {
                int fid = Convert.ToInt32(dgv_fDetails.SelectedRows[0].Cells[0].Value.ToString());
                int cid = Convert.ToInt32(dgv_fDetails.SelectedRows[0].Cells[1].Value.ToString());
                a.removeBooking(fid, cid);
                a.removePassenger(fid, cid);
                dgv_fDetails.DataSource = a.passengerList(fid);
                txtMsg.Visible = true;
                txtMsg.Text = "Passenger removed successfully";
            }
        }

        private void TxtFlightNum_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void TxtFlightNum_Enter(object sender, EventArgs e)
        {
            txtFlightNum.SelectionStart = txtFlightNum.MaskedTextProvider.LastAssignedPosition + 1;
            txtFlightNum.SelectionLength = 0;


        }

        private void TxtFlightNum_Click(object sender, EventArgs e)
        {
            txtFlightNum.SelectionStart = txtFlightNum.MaskedTextProvider.LastAssignedPosition + 1;
            txtFlightNum.SelectionLength = 0;
        }

        private void TxtFlightNum_DoubleClick(object sender, EventArgs e)
        {
            txtFlightNum.SelectionStart = txtFlightNum.MaskedTextProvider.LastAssignedPosition + 1;
            txtFlightNum.SelectionLength = 0;
        }

        private void TxtMaxCap_Click(object sender, EventArgs e)
        {
            txtMaxCap.SelectionStart = txtMaxCap.MaskedTextProvider.LastAssignedPosition + 1;
            txtMaxCap.SelectionLength = 0;
        }

        private void TxtMaxCap_DoubleClick(object sender, EventArgs e)
        {
            txtMaxCap.SelectionStart = txtMaxCap.MaskedTextProvider.LastAssignedPosition + 1;
            txtMaxCap.SelectionLength = 0;
        }

        private void TxtMaxCap_Enter(object sender, EventArgs e)
        {
            txtMaxCap.SelectionStart = txtMaxCap.MaskedTextProvider.LastAssignedPosition + 1;
            txtMaxCap.SelectionLength = 0;
        }

        private void TxtFlightNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtFlightNum.SelectionStart = txtFlightNum.MaskedTextProvider.LastAssignedPosition + 1;
        }

        private void TxtMaxCap_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtMaxCap.SelectionStart = txtMaxCap.MaskedTextProvider.LastAssignedPosition + 1;
        }
    }
}
