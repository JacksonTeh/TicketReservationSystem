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
    public partial class Registration : Form
    {
        private OleDbConnection registerConn;
        private OleDbCommand cmd = new OleDbCommand();

        private string connString =
            @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\CSharp\TicketReservationSystem\TicketReservationDataBase.mdb";

        public Registration()
        {
            registerConn = new OleDbConnection(connString);
            InitializeComponent();
        }

        private bool validation(string loginID, string password, string name,
                string ic, string contactNum, int comboIndex)
        {

            if (validateEmptyID(loginID) &&
                validateEmptyPassword(password) && 
                validateEmptyName(name) &&
                validateEmptyIC(ic) &&
                validateEmptyContactNum(contactNum) &&
                validateEmptyCustomerType(comboIndex) &&
                validateICFormat(ic) &&
                validateContactNumFormat(contactNum))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool validateEmptyID(string loginID)
        {
            if (String.IsNullOrEmpty(loginID))
            {
                MessageBox.Show("Login ID is empty");
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool validateEmptyPassword(string password)
        {
            if (String.IsNullOrEmpty(password))
            {
                MessageBox.Show("Password ID is empty");
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool validateEmptyName(string name)
        {
            if (String.IsNullOrEmpty(name))
            {
                MessageBox.Show("Name is empty");
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool validateEmptyIC(string ic)
        {
            if (String.IsNullOrEmpty(ic))
            {
                MessageBox.Show("IC is empty");
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool validateEmptyContactNum(string contactNum)
        {
            if (String.IsNullOrEmpty(contactNum))
            {
                MessageBox.Show("contactNum is empty");
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool validateEmptyCustomerType(int customerIndex)
        {
            if (customerIndex == -1)
            {
                MessageBox.Show("Customer Type is not select");
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool validateICFormat(string ic)
        {
            int integer;
            if (!int.TryParse(ic, out integer))
            {
                MessageBox.Show("Invalid IC format");
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool validateContactNumFormat(string contactNum)
        {
            int integer;
            if (!int.TryParse(contactNum, out integer))
            {
                MessageBox.Show("Invalid contact number format");
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool validateID(string id)
        {
            bool valid = true;
            try
            {
                registerConn.Open();
                string selectString =
                    "Select * from CustomerDetail where LoginID = '" + id + "'";

                OleDbDataAdapter da = new OleDbDataAdapter(selectString, registerConn);
                OleDbCommandBuilder cBuilder = new OleDbCommandBuilder(da);

                DataTable dataTable = new DataTable();
                da.Fill(dataTable);

                if (dataTable.Rows.Count > 0)
                {
                    MessageBox.Show("ID Is Already Exists! ");
                    valid = false;
                }
                else
                {
                    MessageBox.Show(id + " can be use");
                    valid = true;

                }
                registerConn.Close();
                return valid;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                registerConn.Close();
            }

            return false;
        }

        private void submitButton_Click_1(object sender, EventArgs e)
        {
            string customerType;
            string loginID = txtLoginID.Text;
            string password = txtPassword.Text;
            string name = txtName.Text;
            string ic = txtIC.Text;
            string contactNum = txtContactNum.Text;
            int comboIndex = comboCustomerType.SelectedIndex;

            bool valid = validation(loginID, password, name, ic, contactNum, comboIndex);

            if (valid)
            {
                customerType = comboCustomerType.SelectedItem.ToString();
                cmd.Connection = registerConn;
                cmd.CommandText =
                    "INSERT INTO CustomerDetail ([LoginID], [Password], [Name], [IC], [ContactNum], [CustomerType])" +
                    "VALUES('" + loginID + "','"
                                + password + "','"
                                + name + "','"
                                + ic + "','"
                                + contactNum + "','"
                                + customerType + "')";

                try
                {
                    registerConn.Open();

                    cmd.Parameters.AddWithValue("", loginID);
                    cmd.Parameters.AddWithValue("", password);
                    cmd.Parameters.AddWithValue("", name);
                    cmd.Parameters.AddWithValue("", ic);
                    cmd.Parameters.AddWithValue("", contactNum);

                    int temp = cmd.ExecuteNonQuery();

                    if (temp > 0)
                    {
                        MessageBox.Show("Register Successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Not Able to register!");
                    }

                    registerConn.Close();
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                    registerConn.Close();
                }

                cmd.CommandText =
                    "INSERT INTO TopSales ([LoginID])" +
                    "VALUES('" + loginID + "')";

                try
                {
                    registerConn.Open();

                    int temp = cmd.ExecuteNonQuery();

                    if (temp > 0)
                    {
                        //MessageBox.Show("Insert Successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Not Able to insert customer's ID!");
                    }

                    registerConn.Close();

                    this.Hide();
                    Login login = new Login();
                    login.ShowDialog();
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                    registerConn.Close();
                }
            }
        }
    }
}
