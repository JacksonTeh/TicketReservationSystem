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
        TripInfo ti;
        string flightCode;
        double unitPrice, totalPrice = 0;
        Panel myPanel = new Panel();
        Button[,] btnSeat = new Button[15, 4];
        Label[] label = new Label[20];
        int column = 2, rows = 15, seatLeft;
        List<string> seatName = new List<string>();

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

        public ReservationForm(Customer cust, string flightCode, TripInfo ti)
        {
            reservationConn = new OleDbConnection(connString);
            customer = cust;
            this.ti = ti;
            this.flightCode = flightCode;
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

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Confirm booking", "Confirmation", MessageBoxButtons.OKCancel);

            if (dialogResult == DialogResult.OK)
            {
                try
                {
                    reservationConn.Open();
                    string selectString =
                        "Select * from Trip where Code = @fc";

                    OleDbDataAdapter da = new OleDbDataAdapter(selectString, reservationConn);
                    da.SelectCommand.Parameters.AddWithValue("@fc", flightCode);
                    OleDbCommandBuilder cBuilder = new OleDbCommandBuilder(da);

                    DataTable dataTable = new DataTable();
                    da.Fill(dataTable);

                    if (dataTable.Rows.Count > 0)
                    {
                        unitPrice = Convert.ToDouble(dataTable.Rows[0][5].ToString());
                    }

                    reservationConn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    reservationConn.Close();
                }

                try
                {
                    for (int i = 0; i < seatName.Count; i++)
                    {
                        int col = Convert.ToInt32(seatName[i].Substring(1, 1));
                        char row = Convert.ToChar(seatName[i].Substring(0, 1));

                        reservationConn.Open();

                        cmd.Connection = reservationConn;
                        cmd.CommandText = "INSERT INTO ReservationDetail ([LoginID], [FlightCode], [SeatRow], [SeatNumber])" +
                                            "VALUES('" + customer.getLoginID() + "','"
                                                       + flightCode + "','"
                                                       + row + "','"
                                                       + col + "')";

                        int temp = cmd.ExecuteNonQuery();

                        if (temp > 0)
                        {
                            //MessageBox.Show("Update Seat Successfully!");
                        }
                        else
                        {
                            MessageBox.Show("Not Able to update seat!");
                        }

                        totalPrice += unitPrice;

                        reservationConn.Close();
                    }
                    MessageBox.Show("Update Seat Successfully!");
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                    reservationConn.Close();
                }

                this.Hide();
                this.ti.setPrice(totalPrice);
                Reservation r = new Reservation(customer, this.ti, "");
                ReservationDetail st = new ReservationDetail(r);
                st.ShowDialog();
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
                    btnSeat[i, j].Name = Convert.ToChar(i + 65).ToString() + (j).ToString();
                    btnSeat[i, j].Click += new EventHandler(btnSeat_Click);
                    btnSeat[i, j].BackColor = Color.White;

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
                    btnSeat[i, j].Name = Convert.ToChar(i + 65).ToString() + (j).ToString();
                    btnSeat[i, j].Click += new EventHandler(btnSeat_Click);
                    btnSeat[i, j].BackColor = Color.White;

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

        private void btnSeat_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;

            string s = clickedButton.Name;

            if(clickedButton.BackColor == Color.White)
            {
                if (customer.getCustomerType() == "Regular")
                {
                    if (seatName.Count > 1)
                    {
                        MessageBox.Show("Regular customer only allow two reservation");
                    }
                    else
                    {
                        clickedButton.BackColor = Color.Green;
                        seatName.Add(s);
                    }
                }
                else if (customer.getCustomerType() == "Member")
                {
                    if (seatName.Count > 3)
                    {
                        MessageBox.Show("Member customer only allow four reservation");
                    }
                    else
                    {
                        clickedButton.BackColor = Color.Green;
                        seatName.Add(s);
                    }
                }
            }
            else if(clickedButton.BackColor == Color.Green)
            {
                clickedButton.BackColor = Color.White;
                seatName.Remove(s);
            }
        }

        private void ReservationForm_Load(object sender, EventArgs e)
        {
            try
            {
                reservationConn.Open();
                string selectString =
                    "Select * from ReservationDetail where FlightCode = @fc";

                OleDbDataAdapter da = new OleDbDataAdapter(selectString, reservationConn);
                da.SelectCommand.Parameters.AddWithValue("@fc", flightCode);
                OleDbCommandBuilder cBuilder = new OleDbCommandBuilder(da);

                DataTable dataTable = new DataTable();
                da.Fill(dataTable);

                if (dataTable.Rows.Count > 0)
                {
                    for(int i = 0; i < dataTable.Rows.Count; i++)
                    {
                        int row = Convert.ToInt32(Convert.ToChar(dataTable.Rows[i][2]) - 65);
                        int col = Convert.ToInt32(dataTable.Rows[i][3].ToString());
                        btnSeat[row, col].Enabled = false;
                        btnSeat[row, col].BackColor = Color.Red;
                        seatLeft++;
                    }

                    if (seatLeft == 80)
                    {
                        MessageBox.Show("All Seats Have Taken");
                    }
                }
                reservationConn.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                reservationConn.Close();
            }
        }
    }
}
