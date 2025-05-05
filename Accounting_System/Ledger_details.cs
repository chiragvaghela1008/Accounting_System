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
    public partial class Ledger_details : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter dap;
        DataSet ds;
        public Ledger_details()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            Account_Create mn = new Account_Create();
            mn.Show();
        }

        private void Ledger_details_Load(object sender, EventArgs e)
        {

            con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=ACCOUNTING_SYSTEM;Integrated Security=True");
            con.Open();
            cmd = new SqlCommand("select  * from  MNG_LEDGER", con);
            dap = new SqlDataAdapter(cmd);
            ds = new DataSet();
            dap.Fill(ds, "datax");

            cmd.ExecuteNonQuery();


            SqlCommand cmd1 = new SqlCommand("Select DISTINCT LEDGER_NAME from MNG_LEDGER ", con);

            SqlDataAdapter dap1 = new SqlDataAdapter(cmd);
            DataSet ds1 = new DataSet();
            dap1.Fill(ds);

            for (int index = 0; index < ds.Tables[0].Rows.Count; index++)
            {
                ddlledgername.Items.Add(ds.Tables[0].Rows[index][3].ToString());
            }

            con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=ACCOUNTING_SYSTEM;Integrated Security=True");
            con.Open();
            cmd = new SqlCommand("select  * from  MNG_LEDGER", con);
            dap = new SqlDataAdapter(cmd);
            ds = new DataSet();
            dap.Fill(ds, "datax");
            cmd.ExecuteNonQuery();
            con.Close();

            dataGridView1.DataMember = "datax";
            dataGridView1.DataSource = ds;

            con.Open();
            cmd = new SqlCommand("select  * from  MNG_LEDGER", con);
            dap = new SqlDataAdapter(cmd);
            ds = new DataSet();
            dap.Fill(ds, "datax");
            cmd.ExecuteNonQuery();
            con.Close();
            ddlledgername.DataSource = ds.Tables[0];
            ddlledgername.DisplayMember = "LEDGER_NAME";
            ddlledgername.ValueMember = "LEDGER_NAME";

        }

        private void ddlledgername_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            cmd = new SqlCommand("select  * from  MNG_LEDGER where LEDGER_NAME=@1", con);
            cmd.Parameters.AddWithValue("@1", ddlledgername.Text);
            dap = new SqlDataAdapter(cmd);
            ds = new DataSet();
            dap.Fill(ds, "datax");

            dataGridView1.DataMember = "datax";
            dataGridView1.DataSource = ds;

        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("select  * from  MNG_LEDGER", con);
            dap = new SqlDataAdapter(cmd);
            ds = new DataSet();
            dap.Fill(ds, "datax");

            dataGridView1.DataMember = "datax";
            dataGridView1.DataSource = ds;
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
