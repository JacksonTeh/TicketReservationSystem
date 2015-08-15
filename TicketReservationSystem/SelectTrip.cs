using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace TicketReservationSystem
{
    public partial class SelectTrip : Form
    {
        Customer customer;

        private OleDbConnection reservationConn;
        private OleDbCommand cmd = new OleDbCommand();

        private string connString =
            @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\CSharp\TicketReservationSystem\TicketReservationDataBase.mdb";

        public SelectTrip()
        {
            reservationConn = new OleDbConnection(connString);
            InitializeComponent();
        }

        public SelectTrip(Customer customer)
        {
            this.customer = customer;
            reservationConn = new OleDbConnection(connString);
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu main = new MainMenu(customer);
            main.ShowDialog();
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbxOrigin.Text) || string.IsNullOrEmpty(cbxDestination.Text))
            {
                MessageBox.Show("Please select your origin or destination");
            }
            else
            {
                string origin = cbxOrigin.SelectedItem.ToString();
                string destination = cbxDestination.SelectedItem.ToString();

                try
                {
                    reservationConn.Open();
                    string selectString =
                        "Select * from Trip where Origin = @ori and Destination = @dest";

                    OleDbDataAdapter da = new OleDbDataAdapter(selectString, reservationConn);
                    da.SelectCommand.Parameters.AddWithValue("@ori", origin);
                    da.SelectCommand.Parameters.AddWithValue("@dest", destination);
                    OleDbCommandBuilder cBuilder = new OleDbCommandBuilder(da);

                    DataTable dataTable = new DataTable();
                    da.Fill(dataTable);

                    if (dataTable.Rows.Count > 0)
                    {
                        txtDepart.Text = dataTable.Rows[0][3].ToString();
                        txtArrive.Text = dataTable.Rows[0][4].ToString();
                        txtCode.Text = dataTable.Rows[0][0].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Unable to display info!");
                    }

                    reservationConn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    reservationConn.Close();
                }
            }
        }

        private void cbxOrigin_SelectedIndexChanged(object sender, EventArgs e)
        {
            string origin = cbxOrigin.SelectedItem.ToString();

            cbxDestination.Items.Clear();

            if (origin == "Kuala Lumpur")
            {
                cbxDestination.Items.Add("Kota Kinabalu");
                cbxDestination.Items.Add("Kuching");
                cbxDestination.Items.Add("Sibu");
            }
            else if (origin == "Kota Kinabalu" || origin == "Kuching" || origin == "Sibu")
            {
                cbxDestination.Items.Add("Kuala Lumpur");
            }
            cbxDestination.Enabled = true;
        }

        private void SelectTrip_Load(object sender, EventArgs e)
        {
            cbxDestination.Enabled = false;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Confirm Trip?", "Confirmation", MessageBoxButtons.OKCancel);

            if (dialogResult == DialogResult.OK)
            {
                string o = cbxOrigin.SelectedItem.ToString();
                string d = cbxDestination.SelectedItem.ToString();
                string dt = txtArrive.Text;
                string at = txtDepart.Text;
                string fc = txtCode.Text;

                TripInfo tripInfo = new TripInfo(fc, o, d, dt, at, 0.0);

                this.Hide();
                ReservationForm rf = new ReservationForm(customer, txtCode.Text, tripInfo);
                rf.ShowDialog();
            }
        }
    }
}
