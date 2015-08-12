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
            bool valid;

            valid = validateEmptyString(loginID, password, name, ic, contactNum, comboIndex);

            if (valid)
            {
                valid = validateFormat(ic, contactNum);
            }

            return valid;
        }

        private bool validateEmptyString(string loginID, string password, string name,
                                        string ic, string contactNum, int comboIndex)
        {
            if (String.IsNullOrEmpty(loginID))
            {
                MessageBox.Show("Login ID is empty");
                return false;
            }
            else if (String.IsNullOrEmpty(password))
            {
                MessageBox.Show("Password is empty");
                return false;
            }
            else if (String.IsNullOrEmpty(name))
            {
                MessageBox.Show("Name is empty");
                return false;
            }
            else if (String.IsNullOrEmpty(ic))
            {
                MessageBox.Show("IC is empty");
                return false;
            }
            else if (String.IsNullOrEmpty(contactNum))
            {
                MessageBox.Show("Contact Number is empty");
                return false;
            }
            else if (comboIndex == -1)
            {
                MessageBox.Show("Customer Type is not selected");
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool validateFormat(string ic, string contactNum)
        {
            int integer;

            if (!int.TryParse(ic, out integer))
            {
                MessageBox.Show("Invalid IC format");
                return false;
            }
            else if (!int.TryParse(contactNum, out integer))
            {
                MessageBox.Show("Invalid contact number format");
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool validateIDandName(string id, string name)
        {
            try
            {
                registerConn.Open();
                string selectString =
                    "Select * from CustomerDetail where LoginID = '" + id +
                                                    "' and Password = '" + name + "'";

                OleDbDataAdapter da = new OleDbDataAdapter(selectString, registerConn);
                OleDbCommandBuilder cBuilder = new OleDbCommandBuilder(da);

                DataTable dataTable = new DataTable();
                da.Fill(dataTable);

                if (dataTable.Rows.Count > 0)
                {
                    //MessageBox.Show("Welcome! " + txtID.Text);

                    string loginID = dataTable.Rows[0][0].ToString();
                    //string password = dataTable.Rows[0][1].ToString();
                    string customerName = dataTable.Rows[0][2].ToString();
                    //string customerType = dataTable.Rows[0][5].ToString();
                    //int ic = Convert.ToInt32(dataTable.Rows[0][3].ToString());
                    //int contactNum = Convert.ToInt32(dataTable.Rows[0][4].ToString());

                    //Customer customer = new Customer(loginID, password, customerType, name, ic, contactNum);
                }
                else
                {
                    MessageBox.Show("ID or Password is incorrect! Please try again");

                }
                registerConn.Close();
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
