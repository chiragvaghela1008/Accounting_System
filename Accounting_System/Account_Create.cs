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
    public partial class Account_Create : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter dap;
        DataSet ds;
        public Account_Create()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void lblpanno_Click(object sender, EventArgs e)
        {

        }

        private void brnupdate_Click(object sender, EventArgs e)
        {
            
            cmd = new SqlCommand("update MNG_LEDGER set LEDGER_CODE=@1,LEDGER_NAME=@2,LEDGER_TYPE=@3,MOBILE_NO=@4,ADDRESS=@5,CITY=@6,GST_NO=@7,AADHAR_NO=@8,PAN_NO=@9,OPENING_BALANCE=@10,NARRATION=@11,ENTRY_DATE=@12 where MNG_LEDGER_ID=@0", con);
            cmd.Parameters.AddWithValue("@0", lblID.Text);
            cmd.Parameters.AddWithValue("@1", txtledgercode.Text);
            cmd.Parameters.AddWithValue("@2", txtname.Text);
            cmd.Parameters.AddWithValue("@3", ddlledgertype.Text);
            cmd.Parameters.AddWithValue("@4", txtmobileno.Text);
            cmd.Parameters.AddWithValue("@5", txtaddress.Text);
            cmd.Parameters.AddWithValue("@6", ddlcity.Text);
            cmd.Parameters.AddWithValue("@7", txtgstidno.Text);
            cmd.Parameters.AddWithValue("@8", txtaadharno.Text);
            cmd.Parameters.AddWithValue("@9", txtpanno.Text);
            cmd.Parameters.AddWithValue("@10", txtopeningbalance.Text);
            cmd.Parameters.AddWithValue("@11", txtnarration.Text);
            cmd.Parameters.AddWithValue("@12", "");
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            
            


            txtledgercode.Clear();
            txtname.Clear();
            ddlledgertype.SelectedIndex = -1;

            txtmobileno.Clear();
            txtaddress.Clear();
            txtgstidno.Clear();
            ddlcity.SelectedIndex = -1;
            txtaadharno.Clear();
            txtopeningbalance.Clear();
            txtpanno.Clear();
            txtnarration.Clear();

            cmd = new SqlCommand("select  * from  MNG_LEDGER", con);
            dap = new SqlDataAdapter(cmd);
            ds = new DataSet();
            dap.Fill(ds, "datax");
            dataGridView1.DataMember = "datax";
            dataGridView1.DataSource = ds;
            MessageBox.Show("update data successfully");
        
        }

        private void Account_Create_Load(object sender, EventArgs e)
        {
            
            con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=ACCOUNTING_SYSTEM;Integrated Security=True");
            con.Open();
            cmd = new SqlCommand("select  * from  MNG_LEDGER", con);
            dap = new SqlDataAdapter(cmd);
            ds = new DataSet();
            dap.Fill(ds, "datax");
            cmd.ExecuteNonQuery();
            con.Close();

            btnupdate.Visible = false;
            btnsave.Visible = true;

            
            dataGridView1.DataMember = "datax";
            dataGridView1.DataSource = ds;


            con.Open();
            cmd = new SqlCommand("select  * from  ADM_LEDGER_TYPE", con);
            dap = new SqlDataAdapter(cmd);
            ds = new DataSet();
            dap.Fill(ds, "datax");
            cmd.ExecuteNonQuery();
            con.Close();
            ddlledgertype.DataSource = ds.Tables[0];
            ddlledgertype.DisplayMember = "LEDGER_TYPE";
            ddlledgertype.ValueMember = "LEDGER_TYPE";

            con.Open();
            cmd = new SqlCommand("select  * from  MNG_CITY", con);
            dap = new SqlDataAdapter(cmd);
            ds = new DataSet();
            dap.Fill(ds, "datax");
            cmd.ExecuteNonQuery();
            con.Close();
            ddlcity.DataSource = ds.Tables[0];
            ddlcity.DisplayMember = "CITY";
            ddlcity.ValueMember = "CITY";
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
            cmd = new SqlCommand("insert into MNG_LEDGER values (@1,@2,@3,@4,@5,@6,@7,@8,@9,@10,@11,@12)", con);
            cmd.Parameters.AddWithValue("@1", txtledgercode.Text);
            cmd.Parameters.AddWithValue("@2", txtname.Text);
            cmd.Parameters.AddWithValue("@3", ddlledgertype.Text);
            cmd.Parameters.AddWithValue("@4", txtmobileno.Text);
            cmd.Parameters.AddWithValue("@5", txtaddress.Text);
            cmd.Parameters.AddWithValue("@6", ddlcity.Text);
            cmd.Parameters.AddWithValue("@7", txtgstidno.Text);
            cmd.Parameters.AddWithValue("@8", txtaadharno.Text);
            cmd.Parameters.AddWithValue("@9", txtpanno.Text);
            cmd.Parameters.AddWithValue("@10", txtopeningbalance.Text);
            cmd.Parameters.AddWithValue("@11", txtnarration.Text);
            cmd.Parameters.AddWithValue("@12", "");
            MessageBox.Show("insert data successfully");
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            

            
           txtledgercode.Clear();
           txtname.Clear();
           
                      
           txtmobileno.Clear();
           txtaddress.Clear();
           
           txtgstidno.Clear();
           txtaadharno.Clear();
           txtpanno.Clear();
           txtopeningbalance.Clear();
           txtnarration.Clear();
            
           cmd = new SqlCommand("select  * from  MNG_LEDGER", con);
           dap = new SqlDataAdapter(cmd);
           ds = new DataSet();
           dap.Fill(ds, "datax");
           
           dataGridView1.DataMember = "datax";
           dataGridView1.DataSource = ds;
        }

        private void btnclear_Click(object sender, EventArgs e)
        {

           

            txtledgercode.Clear();
            txtname.Clear();
            ddlledgertype.SelectedIndex = -1;
                      
            txtmobileno.Clear();
            txtaddress.Clear();
            txtgstidno.Clear();
            ddlcity.SelectedIndex = -1;
            txtaadharno.Clear();
            txtopeningbalance.Clear();
            txtpanno.Clear();
            txtnarration.Clear();

            btnupdate.Visible = false;
            btnsave.Visible = true;

            cmd = new SqlCommand("select  * from  MNG_LEDGER", con);
            dap = new SqlDataAdapter(cmd);
            ds = new DataSet();
            dap.Fill(ds, "datax");
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
           

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ddlledgertype_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            lblID.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            txtledgercode.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            txtname.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            ddlledgertype.Text= dataGridView1.SelectedRows[0].Cells[3].Value.ToString();            
            txtmobileno.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            txtaddress.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            ddlcity.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            txtgstidno.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            txtaadharno.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
            txtpanno.Text = dataGridView1.SelectedRows[0].Cells[9].Value.ToString();
            txtopeningbalance.Text = dataGridView1.SelectedRows[0].Cells[10].Value.ToString();
            txtnarration.Text = dataGridView1.SelectedRows[0].Cells[11].Value.ToString();

            btnupdate.Visible = true;
            btnsave.Visible = false;

        
        }
    }
}
