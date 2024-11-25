using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelReservationApp
{
    public partial class FormHome : Form
    {
        public FormHome()
        {
            InitializeComponent();
        }

      

        private void FormHome_Load(object sender, EventArgs e)
        {

        }

        private void buttonAdmin_Click_1(object sender, EventArgs e)
        {
            FormAdmin formAdmin = new FormAdmin();
            this.Hide();
            formAdmin.Show();
        }

        private void buttonRreservation_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            FormRoomReservation formRoomReservation = new FormRoomReservation();
            formRoomReservation.Show();
        }

        private void buttonHallReservation_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            FormHallReservation formHallReservation = new FormHallReservation();
            formHallReservation.Show();
        }

        private void buttonCheckout_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            FormCheckOut formCheckOut = new FormCheckOut();
            formCheckOut.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            FormReservationHistory formReservationHistory = new FormReservationHistory();
            formReservationHistory.Show();
        }

        private void buttonlogout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

      
    
}
