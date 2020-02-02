using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bookingProjectWithGUI
{
    public partial class BookingsForm : Form
    {
        AirlineCoordinator a;
        MainMenu f1;
        public BookingsForm()
        {
            InitializeComponent();
        }
        public BookingsForm(MainMenu f, AirlineCoordinator a)
        {
            this.a = a;
            f1 = f;
            InitializeComponent();
        }

        private void BookingsForm_Load(object sender, EventArgs e)
        {
            dgv_Flight.DataSource = a.flightList();
            dgv_Cust.DataSource = a.customerList();
            dgv_Book.DataSource = a.bookingList();

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            f1.Show();
            this.Close();
        }

        private void BtnAddBook_Click(object sender, EventArgs e)
        {
            int fid, cid;
            if (int.TryParse(txtFlNum.Text, out fid) && int.TryParse(txtCustId.Text, out cid))
            {
                Customer c = a.getCustomer(cid);
                Flight f = a.getFlight(fid);
                a.addBooking(c, f);
                string name = c.getFirstName() + " " + c.getLastName();
                a.addPassenger(f.getFlightNumber(), c.getId(), name);
                txtFlNum.Text = "";
                txtCustId.Text = "";
                dgv_Book.DataSource = a.bookingList();
            }
            else
            {
                txtMsg.Visible = true;
                txtMsg.Text = "please select a valid flight and customer";
            }
        }

        private void BtnSelectF_Click(object sender, EventArgs e)
        {
            if (dgv_Flight.Rows.Count > 1)
            {
                txtFlNum.Text = dgv_Flight.SelectedRows[0].Cells[0].Value.ToString();
            }
        }

        private void BtnSelectC_Click(object sender, EventArgs e)
        {
            if (dgv_Cust.Rows.Count > 1)
            {
                txtCustId.Text = dgv_Cust.SelectedRows[0].Cells[0].Value.ToString();
            }
        }

        private void BtnClr_Click(object sender, EventArgs e)
        {
            txtCustId.Text = "";
            txtFlNum.Text = "";
        }

    }
}
