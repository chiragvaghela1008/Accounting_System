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

namespace Accounting_System
{
    public partial class Forgot_password : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter dap;
        DataSet ds;
        public Forgot_password()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Assuming 'con' is a SqlConnection object declared elsewhere
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=ACCOUNTING_SYSTEM;Integrated Security=True");
            
            // Replace 'cmd' with a new SqlCommand object
            using (SqlCommand cmd = new SqlCommand("UPDATE ADM_REGISTRATION SET PASSWORD = @NewPassword WHERE PASSWORD = @OldPassword", con))
            {
                // Add parameters for old and new passwords
                cmd.Parameters.AddWithValue("@OldPassword", txtoldpassword.Text); // Assuming txtoldpassword is the TextBox for old password
                cmd.Parameters.AddWithValue("@NewPassword", txtnewpassword.Text); // Assuming txtnewpassword is the TextBox for new password

                try
                {
                    con.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Password changed successfully.");
                    }
                    else
                    {
                        MessageBox.Show("Failed to change password. Old password might be incorrect.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
                finally
                {
                    con.Close(); // Ensure connection is closed
                }

                txtoldpassword.Clear();
                txtnewpassword.Clear();
            }
        }


        private void Forgot_password_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=ACCOUNTING_SYSTEM;Integrated Security=True");
            
            
        }

        private void txtgetpassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
