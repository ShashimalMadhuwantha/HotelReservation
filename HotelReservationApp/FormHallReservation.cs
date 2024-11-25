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
    public partial class FormHallReservation : Form
    {
        public FormHallReservation()
        {
            InitializeComponent();
        }

        private void LoadGrid()
        {
            try
            {
                ClassConnection classConnection = new ClassConnection();
                SqlConnection sqlConnection = classConnection.GetConnection();
                sqlConnection.Open();

                string sql = "SELECT * FROM Hall WHERE Hall_Id NOT IN (SELECT Hall_Id FROM HallReservation WHERE Date = '" + dateTimePickerhallReservation.Value.ToString("yyyy-MM-dd") + "')";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, sqlConnection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridViewHall.DataSource = dt;

                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
      

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHome formHome = new FormHome();
            this.Hide();
            formHome.Show();
        }

        private void reservationHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormReservationHistory formReservationHistory = new FormReservationHistory();
            this.Hide();
            formReservationHistory.Show();
        }

        private void buttonReserve_Click(object sender, EventArgs e)
        {

        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {

        }

        private void buttonReserve_Click_1(object sender, EventArgs e)
        {

            try
            {
                if (dateTimePickerhallReservation.Value.Date == DateTime.MinValue.Date)
                {

                    errorProviderDate.SetError(dateTimePickerhallReservation, "Select a valid date");
                    return;
                }
                else
                {
                    errorProviderDate.SetError(dateTimePickerhallReservation, "");
                }
                if (string.IsNullOrWhiteSpace(textBoxHallId.Text))
                {
                    errorProviderHallID.SetError(textBoxHallId, "ReservationID cannot be empty.");
                    return;
                }
                else
                {
                    errorProviderHallID.SetError(textBoxHallId, "");
                }

                if (string.IsNullOrWhiteSpace(textBoxName.Text))
                {
                    errorProviderName.SetError(textBoxName, "ReservationID cannot be empty.");
                    return;
                }
                else
                {
                    errorProviderName.SetError(textBoxName, "");
                }
                if (string.IsNullOrWhiteSpace(textBoxAddress.Text))
                {
                    errorProviderAddress.SetError(textBoxAddress, "ReservationID cannot be empty.");
                    return;
                }
                else
                {
                    errorProviderAddress.SetError(textBoxAddress, "");
                }
                if (string.IsNullOrWhiteSpace(textBoxTelephoneNumber.Text))
                {
                    errorProviderTeleNmb.SetError(textBoxTelephoneNumber, "ReservationID cannot be empty.");
                    return;
                }
                else
                {
                    errorProviderTeleNmb.SetError(textBoxTelephoneNumber, "");
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
                       + newReservationId + "', '" + DateTime.Now.ToString() + "')";
                SqlCommand cmdInsertReservation = new SqlCommand(sqlInsertReservation, sqlConnection);
                cmdInsertReservation.ExecuteNonQuery();

                string sqlinserthall = "Insert into HallReservation(Reservation_Id,Date,Customer_Id,Hall_Id)Values('" + newReservationId + "','" + dateTimePickerhallReservation.Value.ToString() + "','" + newCustomerId + "','" + textBoxHallId.Text + "')";
                SqlCommand sqlCommand = new SqlCommand(sqlinserthall, sqlConnection);
                sqlCommand.ExecuteNonQuery();

                string sqlhallprice = "Select Price from Hall where Hall_Id='" + textBoxHallId.Text + "'";
                SqlCommand cmd = new SqlCommand(sqlhallprice, sqlConnection);
                object hallprice = cmd.ExecuteScalar();
                int hprice = Convert.ToInt32(hallprice.ToString());
                MessageBox.Show("Reservation Success");
                sqlConnection.Close();
                LoadGrid();
                labelBill.Text = "Reservation Id:" + newReservationId + "\n\n" + "Booked Hall-ID:" + textBoxHallId.Text + "\n\n" + "Reserved Day:" + dateTimePickerhallReservation.Value.ToString() + "\n\n" + "Total Amount: Rs" + hallprice.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void btnconfirm_Click_1(object sender, EventArgs e)
        {
            LoadGrid(); 
        }
    }
}
