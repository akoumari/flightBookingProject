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

namespace bookingProjectWithGUI
{
    public partial class CustomersForm : Form
    {
        MainMenu f1;
        AirlineCoordinator a;
        Regex name,phone;
        public CustomersForm()
        {
            InitializeComponent();
        }
        public CustomersForm(MainMenu f, AirlineCoordinator a)
        {
            this.a = a;
            f1 = f;
            InitializeComponent();
        }

        private void CustomersForm_Load(object sender, EventArgs e)
        {
            name = new Regex("^[a-zA-Z]+[a-zA-z\\s\\-\\,]*$", RegexOptions.IgnoreCase | RegexOptions.IgnorePatternWhitespace);
            phone = new Regex("^\\(?[\\d]{3}\\)?[\\s-]?[\\d]{3}[\\s-]?[\\d]{4}$");
            dgv_Cust.DataSource = a.customerList();

        }
        private bool isInvalid()
        {
            bool isInvalid = false;
            if (!name.IsMatch(txtFName.Text))
            {
                txtMsg.Visible = true;
                txtMsg.Text = "Red boxes need attention";
                txtFName.BackColor = Color.LightPink;
                isInvalid = true;
            }
            else
            {
                txtFName.BackColor = Color.White;
            }
            if (!name.IsMatch(txtLName.Text))
            {
                txtMsg.Visible = true;
                txtMsg.Text = "Red boxes need attention";
                txtLName.BackColor = Color.LightPink;
                isInvalid = true;
            }
            else
            {
                txtLName.BackColor = Color.White;
            }
            if (!phone.IsMatch(txtPhone.Text))
            {
                txtMsg.Visible = true;
                txtMsg.Text = "Red boxes need attention";
                txtPhone.BackColor = Color.LightPink;
                isInvalid = true;
            }
            else
            {
                txtPhone.BackColor = Color.White;
            }

            return isInvalid;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            f1.Show();
            this.Close();
        }
        public string UppercaseFirst(string s)
        {
            char[] a = s.ToCharArray();
            a[0] = char.ToUpper(a[0]);
            return new string(a);
        }

        private void BtnAddCust_Click(object sender, EventArgs e)
        {
            if (!isInvalid())
            {
                a.addCustomer(UppercaseFirst(txtFName.Text), UppercaseFirst(txtLName.Text), txtPhone.Text);
                txtPhone.Text = "";
                txtLName.Text = "";
                txtFName.Text = "";
                dgv_Cust.DataSource = a.customerList();
                txtMsg.Visible = true;
                txtMsg.Text = "Add Successful";
            }
        }

        private void TxtFName_Leave(object sender, EventArgs e)
        {
            if (!name.IsMatch(txtFName.Text))
            {
                txtMsg.Visible = true;
                txtMsg.Text = "First name can only contain A - Z and whitespace or punctuation";
                txtFName.BackColor = Color.LightPink;
            }
            else
            {
                txtMsg.Text = "";
                txtFName.BackColor = Color.White;
            }
        }

        private void TxtLName_Leave(object sender, EventArgs e)
        {
            if (!name.IsMatch(txtLName.Text))
            {
                txtMsg.Visible = true;
                txtMsg.Text = "Last name can only contain A - Z and whitespace or punctuation";
                txtLName.BackColor = Color.LightPink;
            }
            else
            {
                txtMsg.Text = "";
                txtLName.BackColor = Color.White;
            }
        }

        private void TxtPhone_Leave(object sender, EventArgs e)
        {
            if (!phone.IsMatch(txtPhone.Text))
            {
                txtMsg.Visible = true;
                txtMsg.Text = "Incorrect phone number format";
                txtPhone.BackColor = Color.LightPink;
            }
            else
            {
                txtMsg.Text = "";
                txtPhone.BackColor = Color.White;
            }
        }

        private void ToolTip1_Popup(object sender, PopupEventArgs e)
        {
         
        }

        private void TxtPhone_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(txtPhone, "Acceptable formats\n" +
                    "1231231234\n" +
                    "123 123 1234\n" +
                    "123-123-1234\n" +
                    "(123)1231234\n" +
                    "Or any combination of the above");
        }

        private void BtnDeleteCust_Click(object sender, EventArgs e)
        {
            if (dgv_Cust.Rows.Count > 1)
            {
                int id = Convert.ToInt32(dgv_Cust.SelectedRows[0].Cells[0].Value.ToString());
                a.deleteCustomer(id);
                a.deleteBookingsCust(id);
                a.propagateDeleteCust(id);
                txtMsg.Visible = true;
                txtMsg.Text = "Customer deleted successfully";
                dgv_Cust.DataSource = a.customerList();
            }
        }
    }
}
