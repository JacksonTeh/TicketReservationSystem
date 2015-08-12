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
        public string id;
        public string name;

        public MainMenu()
        {
            InitializeComponent();
        }

        public MainMenu(string id, string name)
        {
            this.id = id;
            this.name = name;
            InitializeComponent();
        }

        private void btnProfile_Click_1(object sender, EventArgs e)
        {

        }

        private void btnReserve_Click_1(object sender, EventArgs e)
        {

        }

        private void MainMenu_Load_1(object sender, EventArgs e)
        {
            lblCustomerID.Text = "Welcome! " + id;
        }
    }
}
