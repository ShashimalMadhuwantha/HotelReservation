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
    public partial class FormCheckOut : Form
    {
        public FormCheckOut()
        {
            InitializeComponent();
        }

        private void FormCheckOut_Load(object sender, EventArgs e)
        {
            LoadReservationgrid();
        }

        private void LoadReservationgrid()
        {
            try
            {
                ClassConnection classConnection = new ClassConnection();
                SqlConnection sqlConnection = classConnection.GetConnection();
                sqlConnection.Open();
                string sql = "Select * from RoomReservation where Status='Pending' ";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, sqlConnection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridViewPendingReservations.DataSource = dt;
                sqlConnection.Close();
            }catch (Exception ex)
            {
                throw ex;
            }
        }

        private void LoadSearchgrid()
        {
            try
            {
                ClassConnection classConnection = new ClassConnection();
                SqlConnection sqlConnection = classConnection.GetConnection();
                sqlConnection.Open();
                string sql = "Select * from RoomReservation where Status='Pending' and Reservation_Id='" + textBoxReservationId.Text + "' ";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, sqlConnection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridViewPendingReservations.DataSource = dt;
                sqlConnection.Close();
            }catch(Exception ex)
            {
                throw ex;
            }
        }

      

     

        private void buttonSearch_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxReservationId.Text))
            {
                errorProviderReservationID.SetError(textBoxReservationId, "ReservationID cannot be empty.");
                return;
            }
            else
            {
                errorProviderReservationID.SetError(textBoxReservationId, "");
            }
            LoadSearchgrid();
        }

        private void buttonCheckout_Click_1(object sender, EventArgs e)
        {
            try
            {
                ClassConnection classConnection = new ClassConnection();
                SqlConnection sqlConnection = classConnection.GetConnection();
                sqlConnection.Open();
                string sql = "Update RoomReservation set Status='Complete' where Reservation_Id='" + textBoxReservationId.Text + "'";
                SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);
                sqlCommand.ExecuteNonQuery();

                string sqlroomid = "Select Room_Id from RoomReservation where Reservation_Id='" + textBoxReservationId.Text + "'";
                SqlCommand sqlCommand1 = new SqlCommand(sqlroomid, sqlConnection);
                object Roomid = sqlCommand1.ExecuteScalar();

                string updatesql = "Update Room Set Is_Available=1 where Room_Id='" + Roomid + "'";
                SqlCommand sqlCommand2 = new SqlCommand(@updatesql, sqlConnection);
                sqlCommand2.ExecuteNonQuery();

                sqlConnection.Close();

                MessageBox.Show("Checkout Succesfull");
                LoadReservationgrid();


            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
