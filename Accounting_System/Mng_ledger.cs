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
    public partial class Mng_ledger : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter dap;
        DataSet ds;
        public Mng_ledger()
        {
            InitializeComponent();
        }

        private void Mng_ledger_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=ACCOUNTING_SYSTEM;Integrated Security=True");
            con.Open();

            btnupdate.Visible = false;
            btnsave.Visible = true;

            cmd = new SqlCommand("select  * from  ADM_LEDGER_TYPE", con);
            dap = new SqlDataAdapter(cmd);
            ds = new DataSet();
            dap.Fill(ds, "datax");
            dataGridView1.DataMember = "datax";
            dataGridView1.DataSource = ds;
        }

        private void txtledgername_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("insert into ADM_LEDGER_TYPE values (@1,@2)", con);
            cmd.Parameters.AddWithValue("@1", txtledgertype.Text);
            cmd.Parameters.AddWithValue("@2", txtremarks.Text);

            cmd.ExecuteNonQuery();

            txtledgertype.Clear();
            txtremarks.Clear();
            cmd = new SqlCommand("select  * from  ADM_LEDGER_TYPE", con);
            dap = new SqlDataAdapter(cmd);
            ds = new DataSet();
            dap.Fill(ds, "datax");
            dataGridView1.DataMember = "datax";
            dataGridView1.DataSource = ds;
            MessageBox.Show("insert data successfully");
           

        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtledgertype.Clear();
            txtremarks.Clear();
            btnupdate.Visible = false;
            btnsave.Visible = true;

            cmd = new SqlCommand("select  * from  ADM_LEDGER_TYPE", con);
            dap = new SqlDataAdapter(cmd);
            ds = new DataSet();
            dap.Fill(ds, "datax");
            dataGridView1.DataMember = "datax";
            dataGridView1.DataSource = ds;


            
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            
            
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("select  * from  ADM_LEDGER_TYPE where LEDGER_TYPE =@1", con);
            cmd.Parameters.AddWithValue("@1", txtsearchexcel.Text);
            dap = new SqlDataAdapter(cmd);
            ds = new DataSet();
            dap.Fill(ds, "datax");
            dataGridView1.DataMember = "datax";
            dataGridView1.DataSource = ds;
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            lblID.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            txtledgertype.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();

            txtremarks.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();

            btnupdate.Visible = true;
            btnsave.Visible = false;
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("update ADM_LEDGER_TYPE set LEDGER_TYPE=@1, REMARKS=@2 where ADM_LEDGER_TYPE_ID=@0", con);
            cmd.Parameters.AddWithValue("@0", lblID.Text);
            cmd.Parameters.AddWithValue("@1", txtledgertype.Text);
            cmd.Parameters.AddWithValue("@2", txtremarks.Text);
            cmd.ExecuteNonQuery();


            txtledgertype.Clear();
            txtremarks.Clear();


            cmd = new SqlCommand("select  * from  ADM_LEDGER_TYPE", con);
            dap = new SqlDataAdapter(cmd);
            ds = new DataSet();
            dap.Fill(ds, "datax");
            dataGridView1.DataMember = "datax";
            dataGridView1.DataSource = ds;
            MessageBox.Show("update data successfully");
        }

        private void btnexcel_Click(object sender, EventArgs e)
        {
            dataGridView1.SelectAll();
            DataObject copyData = dataGridView1.GetClipboardContent();

            if (copyData != null)
            {
                Clipboard.SetDataObject(copyData);

            }


            Microsoft.Office.Interop.Excel.Application xlapp = new Microsoft.Office.Interop.Excel.Application();
            xlapp.Visible = true;
            Microsoft.Office.Interop.Excel.Workbook xlwbook;
            Microsoft.Office.Interop.Excel.Worksheet xlsheet;
            object miseddata = System.Reflection.Missing.Value;
            xlwbook = xlapp.Workbooks.Add(miseddata);

            xlsheet = (Microsoft.Office.Interop.Excel.Worksheet)xlwbook.Worksheets.get_Item(1);
            Microsoft.Office.Interop.Excel.Range xlr = (Microsoft.Office.Interop.Excel.Range)xlsheet.Cells[1, 1];
            xlr.Select();

            xlsheet.PasteSpecial(xlr, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);
        }
    }
}
