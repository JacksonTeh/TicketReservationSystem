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
        string id, password, name, ic, contactNum;

        private OleDbConnection profileConn;
        private OleDbCommand cmd = new OleDbCommand();

        private string connString =
            @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\CSharp\TicketReservationSystem\TicketReservationDataBase.mdb";

        public UserProfile()
        {
            profileConn = new OleDbConnection(connString);
            InitializeComponent();
        }

        public UserProfile(string id, string password, string name,
                            string ic, string contactNum)
        {
            InitializeComponent();
            string loginID = id;
            txtPassword.Text = password;
            txtName.Text = name;
            txtIC.Text = ic;
            txtContactNum.Text = contactNum;
        }

        /*
        private string selectCommandString(string loginID, string password, string name,
                                            string ic, string contactNum)
        {
            string cmdString = "UPDATE CustomerDetail SET ";

            if (!String.IsNullOrEmpty(password))
            {
                cmdString += "[Password] = @pass, ";
            }

            if (!String.IsNullOrEmpty(name))
            {
                cmdString += "[Name] = @name, ";
            }

            if (!String.IsNullOrEmpty(ic))
            {
                cmdString += "[IC] = @ic, ";
            }

            if (!String.IsNullOrEmpty(name))
            {
                cmdString += "[Name] = @name, ";
            }

            if (!String.IsNullOrEmpty(name))
            {
                cmdString += "[Name] = @name, ";
            }

            return cmdString;
        }*/

        private void updateButton_Click(object sender, EventArgs e)
        {
            string loginID = this.id;
            string password = txtPassword.Text;
            string name = txtName.Text;
            string ic = txtIC.Text;
            string contactNum = txtContactNum.Text;

            cmd.Connection = profileConn;
            cmd.CommandText =
                "UPDATE CustomerDetail SET "
                + "[Password] = @pass, [Name] = @name, [IC] = @ic, [ContactNum] = @contactNum "
                + "WHERE [LoginID] = @id";

            try
            {
                profileConn.Open();

                cmd.Parameters.AddWithValue("@id", loginID);
                cmd.Parameters.AddWithValue("@pass", password);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@ic", ic);
                cmd.Parameters.AddWithValue("@contactNum", contactNum);

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
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                profileConn.Close();
            }
        }
    }
}
