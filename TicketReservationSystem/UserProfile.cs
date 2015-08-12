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
    public partial class UserProfile : Form
    {
        string id = "", customerType = "";
        Customer customer;

        private OleDbConnection profileConn;
        private OleDbCommand cmd = new OleDbCommand();

        private string connString =
            @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\CSharp\TicketReservationSystem\TicketReservationDataBase.mdb";

        public UserProfile()
        {
            profileConn = new OleDbConnection(connString);
            InitializeComponent();
        }

        public UserProfile(Customer customer)
        {
            profileConn = new OleDbConnection(connString);
            this.customer = customer;
            InitializeComponent();

            id = customer.getLoginID();
            txtPassword.Text = customer.getPassword();
            txtName.Text = customer.getCustomerName();
            txtIC.Text = customer.getIC();
            txtContactNum.Text = customer.getContactNum();
            customerType = customer.getCustomerType();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            cmd.Connection = profileConn;
            cmd.CommandText =
                "UPDATE CustomerDetail SET [Password] = '" + txtPassword.Text +
                "' ,[Name] = '" + txtName.Text +
                "' ,[IC] = '" + txtIC.Text +
                "' ,[contactNum] = '" + txtContactNum.Text +
                "' WHERE [LoginID] = '" + id + "'";
            try
            {
                profileConn.Open();

                cmd.Parameters.AddWithValue("", txtPassword.Text);
                cmd.Parameters.AddWithValue("", txtName.Text);
                cmd.Parameters.AddWithValue("", txtIC.Text);
                cmd.Parameters.AddWithValue("", txtContactNum.Text);

                /* Update customer class */
                Customer c = new Customer(id, txtPassword.Text, customerType,
                                        txtName.Text, txtIC.Text, txtContactNum.Text);

                int temp = cmd.ExecuteNonQuery();

                if (temp > 0)
                {
                    MessageBox.Show("Update Successfully!");
                }
                else
                {
                    MessageBox.Show("Updata failed!");
                }

                profileConn.Close();

                this.Hide();
                MainMenu m = new MainMenu(c);
                m.ShowDialog();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                profileConn.Close();
            }
        }
    }
}
