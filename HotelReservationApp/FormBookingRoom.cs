using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelReservationApp
{
    public partial class FormBookingRoom : Form
    {
        string roomID;
        public FormBookingRoom(string RoomID)
        {
            InitializeComponent();
            roomID = RoomID;
        }

        private void FormBookingRoom_Load(object sender, EventArgs e)
        {

        }

     

        private void buttonClear_Click(object sender, EventArgs e)
        {
            labelTotalBill.Text = "";
            textBoxAddress.Text = "";
            textBoxDayCount.Text = "";
            textBoxName.Text = "";
            textBoxTelephoneNumber.Text = "";
        }

        private void buttonReserve_Click_1(object sender, EventArgs e)
        {
            try
            {

                if (string.IsNullOrWhiteSpace(textBoxName.Text))
                {
                    errorProviderName.SetError(textBoxName, "Name cannot be empty.");
                    return;
                }
                else
                {
                    errorProviderName.SetError(textBoxName, "");
                }
                if (string.IsNullOrWhiteSpace(textBoxAddress.Text))
                {
                    errorProviderAddress.SetError(textBoxAddress, "Address cannot be empty.");
                    return;
                }
                else
                {
                    errorProviderAddress.SetError(textBoxAddress, "");
                }
                if (string.IsNullOrWhiteSpace(textBoxTelephoneNumber.Text))
                {
                    errorProviderTelephoneNmb.SetError(textBoxTelephoneNumber, "Telephone Number cannot be empty.");
                    return;
                }
                else
                {
                    errorProviderTelephoneNmb.SetError(textBoxTelephoneNumber, "");
                }
                if (string.IsNullOrWhiteSpace(textBoxDayCount.Text))
                {
                    errorProviderDaycount.SetError(textBoxDayCount, "Day Count cannot be empty.");
                    return;
                }
                else
                {
                    errorProviderDaycount.SetError(textBoxDayCount, "");
                }

                if (!int.TryParse(textBoxDayCount.Text, out _))
                {
                    errorProviderDaycount.SetError(textBoxDayCount, "Day count must be a valid number.");
                    return;
                }
                else
                {
                    errorProviderDaycount.SetError(textBoxDayCount, "");
                }

                ClassConnection classConnection = new ClassConnection();
                SqlConnection sqlConnection = classConnection.GetConnection();
                sqlConnection.Open();


                string newCustomerId = "C001";
                string sqlMaxCustomerId = "SELECT MAX(Customer_Id) FROM Customer";
                SqlCommand cmdMaxCustomerId = new SqlCommand(sqlMaxCustomerId, sqlConnection);
                object result = cmdMaxCustomerId.ExecuteScalar();

                if (result != DBNull.Value && result != null)
                {
                    string maxCustomerId = (string)result;
                    int currentMaxId = int.Parse(maxCustomerId.Substring(1));
                    newCustomerId = "C" + (currentMaxId + 1).ToString("D3");
                }


                string sqlInsertCustomer = "INSERT INTO Customer(Customer_Id, Name, Address, Tele) VALUES ('"
                    + newCustomerId + "', '" + textBoxName.Text + "', '" + textBoxAddress.Text + "', '"
                    + textBoxTelephoneNumber.Text + "')";
                SqlCommand cmdInsertCustomer = new SqlCommand(sqlInsertCustomer, sqlConnection);
                cmdInsertCustomer.ExecuteNonQuery();


                string newReservationId = "B001";
                string sqlMaxReservationId = "SELECT MAX(Reservation_Id) FROM Reservation";
                SqlCommand cmdMaxReservationId = new SqlCommand(sqlMaxReservationId, sqlConnection);
                object reservationIdResult = cmdMaxReservationId.ExecuteScalar();

                if (reservationIdResult != DBNull.Value && reservationIdResult != null)
                {
                    string maxReservationId = (string)reservationIdResult;
                    int currentMaxId = int.Parse(maxReservationId.Substring(1));
                    newReservationId = "B" + (currentMaxId + 1).ToString("D3");
                }


                string sqlInsertReservation = "INSERT INTO Reservation(Reservation_Id, Reserved_Date) VALUES ('"
                    + newReservationId + "', '" + DateTime.Now.ToString("yyyy-MM-dd") + "')";
                SqlCommand cmdInsertReservation = new SqlCommand(sqlInsertReservation, sqlConnection);
                cmdInsertReservation.ExecuteNonQuery();


                int dayCount = Convert.ToInt32(textBoxDayCount.Text);

                string sqlRoomPrice = "SELECT Price FROM Room WHERE Room_Id = '" + roomID + "'";
                SqlCommand cmdRoomPrice = new SqlCommand(sqlRoomPrice, sqlConnection);
                object roomPriceResult = cmdRoomPrice.ExecuteScalar();

                string sql = "UPDATE Room set Is_Available=0 where Room_Id='" + roomID + "'";
                SqlCommand updatecmd = new SqlCommand(sql, sqlConnection);
                updatecmd.ExecuteNonQuery();

                if (roomPriceResult != DBNull.Value && roomPriceResult != null)
                {
                    int roomPrice = Convert.ToInt32(roomPriceResult);
                    int total = roomPrice * dayCount;


                    string sqlInsertRoomReservation = "INSERT INTO RoomReservation(Reservation_Id, Status, Day_Count, Price, Customer_Id, Room_Id) " +
                                                      "VALUES ('" + newReservationId + "', 'Pending', '" + dayCount + "', '"
                                                      + total + "', '" + newCustomerId + "', '" + roomID + "')";
                    SqlCommand cmdInsertRoomReservation = new SqlCommand(sqlInsertRoomReservation, sqlConnection);
                    cmdInsertRoomReservation.ExecuteNonQuery();

                    labelTotalBill.Text = "Reservation Id:" + newReservationId + "\n\n" + "Booked Room-ID:" + roomID + "\n\n" + "Price Per Day:" + roomPrice + "\n\n" + "Day Count:" + dayCount + "\n\n" + "Total Amount: Rs" + total;

                    MessageBox.Show("Reservation Successful. Total price: " + total);
                }
                else
                {
                    MessageBox.Show("Room price not found.");
                }

                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void buttonClear_Click_1(object sender, EventArgs e)
        {

        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormHome formHome = new FormHome();
            formHome.Show();
        }

        private void reservationHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormReservationHistory formReservationHistory = new FormReservationHistory();
            this.Hide();
            formReservationHistory.Show();  
        }
    }
}
