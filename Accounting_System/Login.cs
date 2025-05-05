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
    public partial class Login : Form
    {

        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter dap;
      
        public Login()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

      private void button1_Click(object sender, EventArgs e)
        {
          SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=ACCOUNTING_SYSTEM;Integrated Security=True");
          SqlCommand cmd = new SqlCommand("select * from ADM_REGISTRATION where EMAIL_ID='" + txtEmail.Text + "' and PASSWORD='" + txtPassword.Text + "'", con);
          SqlDataAdapter dap = new SqlDataAdapter(cmd);
          DataTable dt = new DataTable();
          dap.Fill(dt);
          string cmbItemValue = comboBox1.SelectedItem.ToString();


        // Check if any rows were returned
        if (dt.Rows.Count > 0)
        {
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i]["USER_TYPE"].ToString() == cmbItemValue) 
                {
                    MessageBox.Show("login Succesfully" + dt.Rows[i][2]);
                    if (comboBox1.SelectedIndex == 0)
                    {
                        Main mainForm = new Main();
                        mainForm.Show();
                        this.Hide();
                    }
                    else 
                    {
                        MNG_MAIN mainForm = new MNG_MAIN();
                        mainForm.Show();
                        this.Hide();
                    }
                }
            }
        }
        else
        {
            MessageBox.Show("Invalid email or password");
        }
    }



        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {
           
        }

    }
}