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
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();
            
        }
    
        private void buttonAdd_Click(object sender, EventArgs e)
        {
           

        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            
           
        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {
            LoadAdmingrid();
        }

        private void LoadAdmingrid()
        {

            ClassConnection classConnection = new ClassConnection();
            SqlConnection sqlConnection = classConnection.GetConnection();
            sqlConnection.Open();
            string sql = "Select * from Admin";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, sqlConnection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridViewAdmin.DataSource = dt;
            sqlConnection.Close();
        }


        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonAdd_Click_1(object sender, EventArgs e)
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

                if (string.IsNullOrWhiteSpace(textBoxNIC.Text))
                {
                    errorProviderNIC.SetError(textBoxNIC, "NIC cannot be empty.");
                    return;
                }
                else
                {
                    errorProviderNIC.SetError(textBoxNIC, "");
                }


                if (string.IsNullOrWhiteSpace(textBoxContact.Text))
                {
                    errorProviderContact.SetError(textBoxContact, "Contact cannot be empty.");
                    return;
                }
                else
                {
                    errorProviderContact.SetError(textBoxContact, "");
                }


                if (string.IsNullOrWhiteSpace(textBoxUserName.Text))
                {
                    errorProviderUsername.SetError(textBoxUserName, "Username cannot be empty.");
                    return;
                }
                else
                {
                    errorProviderUsername.SetError(textBoxUserName, "");
                }

                if (string.IsNullOrWhiteSpace(textBoxPAssword.Text))
                {
                    errorProviderPassword.SetError(textBoxPAssword, "Password cannot be empty.");
                    return;
                }
                else
                {
                    errorProviderPassword.SetError(textBoxPAssword, "");
                }
                ClassConnection classConnection = new ClassConnection();
                SqlConnection sqlConnection = classConnection.GetConnection();
                sqlConnection.Open();
                string newAdminId = "A001";
                string maxAdminId = null;
                string sql = "SELECT MAX(Admin_Id) FROM Admin";
                SqlCommand cmd = new SqlCommand(sql, sqlConnection);

                object result = cmd.ExecuteScalar();
                if (result != DBNull.Value)
                {
                    maxAdminId = (string)result;
                    int currentMaxId = int.Parse(maxAdminId.Substring(1));
                    newAdminId = "A" + (currentMaxId + 1).ToString("D3");
                }
                string sqlinsert = "Insert into Admin(Admin_Id,Username,Password,Name,NIC,Tele,Status)Values('" + newAdminId + "','" + textBoxUserName.Text + "','" + textBoxPAssword.Text + "','" + textBoxName.Text + "','" + textBoxNIC.Text + "','" + textBoxContact.Text + "','unblocked')";
                SqlCommand cmdinsert = new SqlCommand(sqlinsert, sqlConnection);
                cmdinsert.ExecuteNonQuery();
                sqlConnection.Close();
                LoadAdmingrid();
                MessageBox.Show("Admin Added");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        private void buttonBlock_Click(object sender, EventArgs e)
        {
            try
            {

                if (string.IsNullOrWhiteSpace(textBoxAdminId.Text))
                {
                    errorProviderContact.SetError(textBoxAdminId, "Adminid cannot be empty.");
                    return;
                }
                else
                {
                    errorProviderContact.SetError(textBoxAdminId, "");
                }
                ClassConnection classConnection = new ClassConnection();
                SqlConnection sqlConnection = classConnection.GetConnection();
                sqlConnection.Open();
                string sql = "Update Admin set Status ='Blocked ' where Admin_Id='" + textBoxAdminId.Text + "'";
                SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
                LoadAdmingrid();
                MessageBox.Show("Succesfully BLocked the User");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error" + ex);
            }
        }

        private void buttonunblock_Click_1(object sender, EventArgs e)
        {
            try
            {

                if (string.IsNullOrWhiteSpace(textBoxAdminId.Text))
                {
                    errorProviderContact.SetError(textBoxAdminId, "Adminid cannot be empty.");
                    return;
                }
                else
                {
                    errorProviderContact.SetError(textBoxAdminId, "");
                }

                ClassConnection classConnection = new ClassConnection();
                SqlConnection sqlConnection = classConnection.GetConnection();
                sqlConnection.Open();
                string sql = "Update Admin set Status ='unblocked' where Admin_Id='" + textBoxAdminId.Text + "'";
                SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
                LoadAdmingrid();
                MessageBox.Show("Succesfully UnLocked the User");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error" + ex);
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            FormHome formHome = new FormHome(); 
            this.Hide();
            formHome.Show();
        }
    }
}
