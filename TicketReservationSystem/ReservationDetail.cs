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
    public partial class ReservationDetail : Form
    {
        string loginID, name, origin, dest, departT, arriveT, code, payment;
        double previousTransaction = 0;
        Reservation reservation;
        private OleDbConnection dataBaseConn;
        private OleDbCommand cmd = new OleDbCommand();

        private string connString =
            @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\CSharp\TicketReservationSystem\TicketReservationDataBase.mdb";

        public ReservationDetail()
        {
            InitializeComponent();
        }

        public ReservationDetail(Reservation r)
        {
            InitializeComponent();
            dataBaseConn = new OleDbConnection(connString);
            reservation = r;
            loginID = r.getCustomer().getLoginID();
            arriveT = txtArrive.Text = r.getTripInfo().getArrive().ToString();
            code = txtCode.Text = r.getTripInfo().getCode().ToString();
            departT = txtDepart.Text = r.getTripInfo().getDepart().ToString();
            dest = txtDest.Text = r.getTripInfo().getDestination().ToString();
            name = txtName.Text = r.getCustomer().getCustomerName();
            origin = txtOrigin.Text = r.getTripInfo().getDepartFrom();
            payment = txtPrice.Text = r.getTripInfo().getPrice().ToString();
        }

        private void finishButton_Click(object sender, EventArgs e)
        {
            cmd.Connection = dataBaseConn;
            cmd.CommandText =
                "INSERT INTO ConfirmBooking ([Name], [Origin], [Destination], [Depart], [Arrive], [FlightCode], [TotalPayment])" +
                "VALUES('"  + loginID + "','"
                            + origin + "','"
                            + dest + "','"
                            + departT + "','"
                            + arriveT + "','"
                            + code + "','"
                            + payment + "')";

            try
            {
                dataBaseConn.Open();

                int temp = cmd.ExecuteNonQuery();

                if (temp > 0)
                {
                    MessageBox.Show("Transcation Store Successfully!");
                }
                else
                {
                    MessageBox.Show("Fail to store transcation!");
                }

                dataBaseConn.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                dataBaseConn.Close();
            }

            try
            {
                dataBaseConn.Open();
                string selectString =
                "Select * from TopSales where LoginID = @id";

                OleDbDataAdapter da = new OleDbDataAdapter(selectString, dataBaseConn);
                da.SelectCommand.Parameters.AddWithValue("@id", loginID);
                OleDbCommandBuilder cBuilder = new OleDbCommandBuilder(da);

                DataTable dataTable = new DataTable();
                da.Fill(dataTable);

                if (dataTable.Rows.Count > 0)
                {
                    previousTransaction = Convert.ToDouble(dataTable.Rows[0][1]);
                }

                previousTransaction += Convert.ToDouble(txtPrice.Text);

                cmd.CommandText =
                    "UPDATE TopSales SET [TotalTransaction] = '" + previousTransaction +
                    "' WHERE [LoginID] = '" + reservation.getCustomer().getLoginID() + "'";

                int temp = cmd.ExecuteNonQuery();

                if (temp > 0)
                {
                    MessageBox.Show("Update Customer's Sale Successfully!");
                }
                else
                {
                    MessageBox.Show("Updata failed!");
                }

                dataBaseConn.Close();

                this.Hide();
                MainMenu m = new MainMenu(reservation.getCustomer());
                m.ShowDialog();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                dataBaseConn.Close();
            }
        }
    }
}
