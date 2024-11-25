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
    public partial class FormRoomReservation : Form
    {
        public FormRoomReservation()
        {
            InitializeComponent();
        }

       
        private void FormRoomReservation_Load(object sender, EventArgs e)
        {
            LoadAvailableRoomgrid();
        }

        private void LoadAvailableRoomgrid()
        {
            ClassConnection classConnection = new ClassConnection();
            SqlConnection sqlConnection = classConnection.GetConnection();
            sqlConnection.Open();
            string sql = "Select * from Room where Is_Available=1";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, sqlConnection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridViewAvailableRoom.DataSource = dt;
            sqlConnection.Close();
        }

        private void buttonReserve_Click_1(object sender, EventArgs e)
        {
            string RoomID = textBoxRoomId.Text;
            this.Hide();
            FormBookingRoom formBookingRoom = new FormBookingRoom(RoomID);
            formBookingRoom.Show();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormHome formHome = new FormHome();
            formHome.Show();
        }
    }
}
