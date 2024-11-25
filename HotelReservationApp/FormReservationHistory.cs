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
    public partial class FormReservationHistory : Form
    {
        public FormReservationHistory()
        {
            InitializeComponent();
        }

   
        private void buttonSearch_Click_1(object sender, EventArgs e)
        {
            string date = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            string customerName = textBox1CustomerNAme.Text;
            ClassConnection connection = new ClassConnection();
            SqlConnection sqlconnection = connection.GetConnection();


            string sql = "SELECT RR.Reservation_Id, RR.Status, RR.Day_Count, RR.price, C.Customer_Id, C.Name, C.Address, C.Tele, R.Room_Id, R.Room_Type " +
                         "FROM RoomReservation RR " +
                         "INNER JOIN Customer C ON RR.Customer_Id = C.Customer_Id " +
                         "INNER JOIN Room R ON RR.Room_Id = R.Room_Id " +
                         "INNER JOIN Reservation Res ON RR.Reservation_Id = Res.Reservation_Id " +
                         "WHERE 1=1";

            // Add conditions based on inputs
            if (!string.IsNullOrEmpty(date))
            {
                sql += $" AND Res.Reserved_Date = '{date}'";
            }
            if (!string.IsNullOrEmpty(customerName))
            {
                sql += $" AND C.Name LIKE '%{customerName}%'";
            }

            SqlDataAdapter adapter = new SqlDataAdapter(sql, sqlconnection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            // Assuming you have a DataGridView control named dataGridView1
            dataGridView1.DataSource = dt;
        }
    }
}
