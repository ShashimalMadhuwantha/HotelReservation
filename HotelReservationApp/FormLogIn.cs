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
    public partial class FormLogIn : Form
    {
        public FormLogIn()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {

            try
            {

                if (string.IsNullOrWhiteSpace(textBoxUsername.Text))
                {
                   
                  errorProvidername .SetError(textBoxUsername, "Name cannot be empty.");
                    return;
                }
                else
                {
                    errorProvidername.SetError(textBoxUsername, "");
                }

                if (string.IsNullOrWhiteSpace(textBoxPassword.Text))
                {
                    errorProviderpassword.SetError(textBoxPassword, "passowrd cannot be empty.");
                    return;
                }
                else
                {
                    errorProviderpassword.SetError(textBoxPassword, "");
                }

                ClassConnection classConnection = new ClassConnection();
                SqlConnection sqlConnection = classConnection.GetConnection();
                sqlConnection.Open();
                string sql = "Select * from Admin where UserName='" + textBoxUsername.Text + "' and Password='" + textBoxPassword.Text + "'";
                SqlCommand cmdobj = new SqlCommand(sql, sqlConnection);
                SqlDataReader reader = cmdobj.ExecuteReader();
                if (reader.HasRows)
                {
                    
                    reader.Read();

               
                    string status = reader["Status"].ToString();
                    if (status == "unblocked")
                    {
                        this.Hide();
                        FormHome formHome = new FormHome();
                        formHome.Show();
                    }
                    else
                    {
                        MessageBox.Show("User account is blocked.");
                    }
                }
                else
                {
                    MessageBox.Show("Incorrect username or password.");
                }

                sqlConnection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
