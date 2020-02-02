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
    public partial class MainMenu : Form
    {
        //Alexander Koumarianos
        //Nadene Williams
        //Erin Krumins 
        AirlineCoordinator a;
        public MainMenu()
        {
            a = new AirlineCoordinator(100, 100, 100);
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void BtnCustPortal_Click(object sender, EventArgs e)
        {
            CustomersForm f = new CustomersForm(this,a);
            Hide();
            f.Show();
        }

        private void BtnFlightPortal_Click(object sender, EventArgs e)
        {
            FlightsForm f = new FlightsForm(this, a);
            Hide();
            f.Show();
        }

        private void BtnBookPortal_Click(object sender, EventArgs e)
        {
            BookingsForm f = new BookingsForm(this, a);
            Hide();
            f.Show();
        }
    }
}
