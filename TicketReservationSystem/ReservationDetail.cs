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
    public partial class ReservationDetail : Form
    {
        Reservation reservation;
        public ReservationDetail()
        {
            InitializeComponent();
        }

        public ReservationDetail(Reservation r)
        {
            InitializeComponent();
            reservation = r;
            txtArrive.Text = r.getTripInfo().getArrive().ToString();
            txtCode.Text = r.getTripInfo().getCode().ToString();
            txtDepart.Text = r.getTripInfo().getDepart().ToString();
            txtDest.Text = r.getTripInfo().getDestination().ToString();
            txtName.Text = r.getCustomer().getCustomerName();
            txtOrigin.Text = r.getTripInfo().getDepartFrom();
            txtPrice.Text = r.getTripInfo().getPrice().ToString();
        }

        private void finishButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu m = new MainMenu(reservation.getCustomer());
            m.ShowDialog();
        }
    }
}
