using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicketReservationSystem
{
    public partial class MainMenu : Form
    {
        Customer customer;

        public MainMenu()
        {
            InitializeComponent();
        }
        
        public MainMenu(Customer cust)
        {
            customer = cust;
            InitializeComponent();
            lblCustomerID.Text = "Welcome! " + customer.getLoginID();
        }

        private void btnProfile_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            UserProfile profile = new UserProfile(customer);
            profile.ShowDialog();
        }

        private void btnReserve_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            SelectTrip st = new SelectTrip(customer);
            st.ShowDialog();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
        }

        private void btnTransaction_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewTransaction vt = new ViewTransaction(customer);
            vt.ShowDialog();
        }
    }
}
