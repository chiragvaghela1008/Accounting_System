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
    public partial class Receipt_Voucher : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter dap;
        DataSet ds;
        public Receipt_Voucher()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Receipt_Voucher_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=ACCOUNTING_SYSTEM;Integrated Security=True");
            con.Open();
            cmd = new SqlCommand("select  * from MNG_LEDGER ", con);
            dap = new SqlDataAdapter(cmd);
            ds = new DataSet();
            dap.Fill(ds, "datax");

            cmd.ExecuteNonQuery();


            SqlCommand cmd1 = new SqlCommand("Select DISTINCT LEDGER_NAME from MNG_LEDGER", con);

            SqlDataAdapter dap1 = new SqlDataAdapter(cmd);
            DataSet ds1 = new DataSet();
            dap1.Fill(ds);

            for (int index = 0; index < ds.Tables[0].Rows.Count; index++)
            {
                ddldr.Items.Add(ds.Tables[0].Rows[index][2].ToString());
            }

            SqlCommand cmd2 = new SqlCommand("Select DISTINCT LEDGER_NAME  from MNG_LEDGER ", con);

            SqlDataAdapter dap2 = new SqlDataAdapter(cmd);
            DataSet ds2 = new DataSet();
            dap1.Fill(ds);

            for (int index = 0; index < ds.Tables[0].Rows.Count; index++)
            {
                ddl_cr.Items.Add(ds.Tables[0].Rows[index][2].ToString());
            }

            DataClasses1DataContext abc = new DataClasses1DataContext();

            int FileCount = (from row in abc.ADM_LEDGER_REPORTs
                             select row).Count();
            txtvoucherno.Text = (FileCount + 1).ToString();
            txtvoucherno.Focus();


        }

        private void ddldr_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmd = new SqlCommand("select  * from  MNG_LEDGER where LEDGER_NAME=@2", con);
            cmd.Parameters.AddWithValue("@2", ddldr.Text);
            dap = new SqlDataAdapter(cmd);
            ds = new DataSet();
            dap.Fill(ds, "datax");

            try
            {
                if (string.IsNullOrEmpty(label11.Text))
                {

                    label10.Focus();
                }
                else
                {

                    SqlDataAdapter dap1 = new SqlDataAdapter(cmd);
                    DataSet ds1 = new DataSet();

                    if (dap.Fill(ds) > 0)
                    {


                        label10.Text = ds.Tables[0].Rows[0][10].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


           
        }

        private void ddl_cr_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmd = new SqlCommand("select  * from  MNG_LEDGER where LEDGER_NAME=@2", con);
            cmd.Parameters.AddWithValue("@2", ddl_cr.Text);
            dap = new SqlDataAdapter(cmd);
            ds = new DataSet();
            dap.Fill(ds, "datax");

            try
            {
                if (string.IsNullOrEmpty(label11.Text))
                {

                    label11.Focus();
                }
                else
                {

                    SqlDataAdapter dap1 = new SqlDataAdapter(cmd);
                    DataSet ds1 = new DataSet();

                    if (dap.Fill(ds) > 0)
                    {


                        label11.Text = ds.Tables[0].Rows[0][10].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void txtamount_TextChanged(object sender, EventArgs e)
        {
            int num2, num3, num4, num5;

            if (int.TryParse(label10.Text, out num2) && int.TryParse(txtamount.Text, out num3))
            {
                int abc = num2 - num3;
                lbldenow.Text = abc.ToString();
            }
            else
            {
                // MessageBox.Show("please enter valid number");
            }

            if (int.TryParse(label11.Text, out num4) && int.TryParse(txtamount.Text, out num5))
            {
                int xyz = num4 + num5;
                lblcr.Text = xyz.ToString();
            }
            else
            {
                // MessageBox.Show(" Please enter valid number");
            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("insert into ADM_RECEIPT_VOUCHER values (@1,@2,@3,@4,@5,@6,@7,@8,@9,@10,@11,@12)", con);
            cmd.Parameters.AddWithValue("@1", ddldr.Text);
            cmd.Parameters.AddWithValue("@2", ddldate.Text);
            cmd.Parameters.AddWithValue("@3", lbldenow.Text);
            cmd.Parameters.AddWithValue("@4", label10.Text);
            cmd.Parameters.AddWithValue("@5", txtvoucherno.Text);
            cmd.Parameters.AddWithValue("@6", txtamount.Text);
            cmd.Parameters.AddWithValue("@7", ddl_cr.Text);
            cmd.Parameters.AddWithValue("@8", lblcr.Text);
            cmd.Parameters.AddWithValue("@9", label11.Text);
            cmd.Parameters.AddWithValue("@10", txtdocno.Text);
            cmd.Parameters.AddWithValue("@11", ddldocdate.Text);
            cmd.Parameters.AddWithValue("@12", txtnarration.Text);
            //con.Open();
            cmd.ExecuteNonQuery();
            //con.Close();
            MessageBox.Show("insert data successfully");

            ddldr.SelectedIndex = -1;
            label10.Text = "";
            label11.Text = "";
            lbldenow.Text = "";
            lblcr.Text = "";
            txtvoucherno.Clear();
            txtamount.Clear();
            ddl_cr.SelectedIndex = -1;
            txtdocno.Clear();

            txtnarration.Clear();










            cmd = new SqlCommand("select  * from  ADM_RECEIPT_VOUCHER", con);
            dap = new SqlDataAdapter(cmd);
            ds = new DataSet();
            dap.Fill(ds, "datax");

        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            ddldr.SelectedIndex = -1;

            label10.Text = "";
            label11.Text = "";
            lbldenow.Text = "";
            lblcr.Text = "";

            txtvoucherno.Clear();
            txtamount.Clear();
            ddl_cr.SelectedIndex = -1;
            txtdocno.Clear();

            txtnarration.Clear();
        }
    }
}
