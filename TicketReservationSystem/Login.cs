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
    public partial class Login : Form
    {
        private OleDbConnection loginConn;
        private OleDbCommand cmd = new OleDbCommand();

        private string connString =
            @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\CSharp\TicketReservationSystem\TicketReservationDataBase.mdb";

        public Login()
        {
            //hi
            loginConn = new OleDbConnection(connString);
            InitializeComponent();
        }

        private void loginButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                loginConn.Open();
                string selectString =
                    "Select * from CustomerDetail where LoginID = '" + txtID.Text +
                                                    "' and Password = '" + txtPass.Text + "'";

                OleDbDataAdapter da = new OleDbDataAdapter(selectString, loginConn);
                OleDbCommandBuilder cBuilder = new OleDbCommandBuilder(da);

                DataTable dataTable = new DataTable();
                da.Fill(dataTable);

                if (dataTable.Rows.Count > 0)
                {
                    MessageBox.Show("Welcome! " + txtID.Text);

                    string loginID = dataTable.Rows[0][0].ToString();
                    //string password = dataTable.Rows[0][1].ToString();
                    string name = dataTable.Rows[0][2].ToString();
                    //string customerType = dataTable.Rows[0][5].ToString();
                    //int ic = Convert.ToInt32(dataTable.Rows[0][3].ToString());
                    //int contactNum = Convert.ToInt32(dataTable.Rows[0][4].ToString());

                    //Customer customer = new Customer(loginID, password, customerType, name, ic, contactNum);

                    this.Hide();
                    MainMenu mainMenu = new MainMenu(loginID, name);
                    mainMenu.ShowDialog();
                }
                else
                {
                    MessageBox.Show("ID or Password is incorrect! Please try again");

                }
                loginConn.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                loginConn.Close();
            }
        }

        private void registerButton_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Registration register = new Registration();
            register.ShowDialog();
        }
    }
}
