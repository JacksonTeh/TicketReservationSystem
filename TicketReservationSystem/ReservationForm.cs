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
    public partial class ReservationForm : Form
    {
        Customer customer;
        Panel myPanel = new Panel();
        Button[,] btnSeat = new Button[15, 4];
        Label[] label = new Label[20];
        int column = 2, rows = 15, seatLeft;

        private OleDbConnection reservationConn;
        private OleDbCommand cmd = new OleDbCommand();

        private string connString =
            @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\CSharp\TicketReservationSystem\TicketReservationDataBase.mdb";

        public ReservationForm()
        {
            reservationConn = new OleDbConnection(connString);
            drawPanel();
            drawPlan();
            InitializeComponent();
        }

        public ReservationForm(Customer cust)
        {
            reservationConn = new OleDbConnection(connString);
            customer = cust;
            drawPanel();
            drawPlan();
            InitializeComponent();
        }

        public void drawPanel()
        {
            myPanel.Size = new Size(250, 280);
            myPanel.Location = new Point(37, 70);
            myPanel.BackColor = Color.White;
            myPanel.AutoScroll = true;

            for (int i = 0; i < rows; i++)
            {
                label[i] = new Label();
                label[i].Size = new Size(28, 28);
                char c = Convert.ToChar(65 + i);
                label[i].Text = Convert.ToString(c);
                label[i].Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                label[i].Location = new Point(20, 10 + 28 * i);
                myPanel.Controls.Add(label[i]);
            }
            
            Controls.Add(myPanel);
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
            else if(origin == "Kota Kinabalu" || origin == "Kuching" || origin == "Sibu")
            {
                cbxDestination.Items.Add("Kuala Lumpur");
            }
        }

        private void cbxDestination_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            MessageBoxButtons.OKCancel.;
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbxOrigin.Text) || string.IsNullOrEmpty(cbxDestination.Text))
            {
                MessageBox.Show("Please select your origin or destination");
            }
            else
            {
                try
                {
                    reservationConn.Open();
                    string selectString =
                        "Select * from Trip where Origin = @ori and Destination = @dest";
                    string origin = cbxOrigin.SelectedItem.ToString();
                    string destination = cbxDestination.SelectedItem.ToString();

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

                    reservationConn.Close();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    reservationConn.Close();
                }
            }
        }

        private void drawPlan()
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    btnSeat[i, j] = new Button();
                    btnSeat[i, j].Size = new Size(28, 28);

                    if (j == 0)
                        btnSeat[i, j].Location = new Point(48 + 10, 10 + 28 * i);
                    else
                        btnSeat[i, j].Location = new Point(78 + 10, 10 + 28 * i);

                    string tooltipText = Convert.ToChar(i + 65).ToString() + (j).ToString();
                    ToolTip buttonToolTip = new ToolTip();
                    buttonToolTip.SetToolTip(btnSeat[i, j], tooltipText);
                    myPanel.Controls.Add(btnSeat[i, j]);
                }
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 2; j < column + 2; j++)
                {
                    btnSeat[i, j] = new Button();
                    btnSeat[i, j].Size = new Size(28, 28);

                    if (j == 2)
                        btnSeat[i, j].Location = new Point(78 + 10 + 28 + 28, 10 + 28 * i);
                    else
                        btnSeat[i, j].Location = new Point(78 + 10 + 28 + 28 + 28, 10 + 28 * i);

                    string tooltipText = Convert.ToChar(i + 65).ToString() + (j).ToString();
                    ToolTip buttonToolTip = new ToolTip();
                    buttonToolTip.SetToolTip(btnSeat[i, j], tooltipText);
                    myPanel.Controls.Add(btnSeat[i, j]);
                }
            }
        }

        private void ReservationForm_Load(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < column + 2; j++)
                    {
                        char c = Convert.ToChar(i + 65);
                        reservationConn.Open();
                        string selectString =
                            "Select * from SeatInfo where SeatRow = @row and SeatNumber = @col";

                        OleDbDataAdapter da = new OleDbDataAdapter(selectString, reservationConn);
                        da.SelectCommand.Parameters.AddWithValue("@row", c);
                        da.SelectCommand.Parameters.AddWithValue("@col", j);
                        OleDbCommandBuilder cBuilder = new OleDbCommandBuilder(da);

                        DataTable dataTable = new DataTable();
                        da.Fill(dataTable);

                        if (dataTable.Rows.Count > 0)
                        {
                            btnSeat[i, j].Enabled = false;
                            btnSeat[i, j].BackColor = Color.Red;
                            seatLeft++;
                        }

                        reservationConn.Close();
                    }
                }

                if(seatLeft == 80)
                {
                    MessageBox.Show("All Seats Have Taken");
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                reservationConn.Close();
            }
        }
    }
}
