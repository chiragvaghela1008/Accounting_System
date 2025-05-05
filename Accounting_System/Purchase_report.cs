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
    public partial class Purchase_report : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter dap;
        DataSet ds;
        public Purchase_report()
        {
            InitializeComponent();
        }

        private void Purchase_report_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=ACCOUNTING_SYSTEM;Integrated Security=True");
            con.Open();

            cmd = new SqlCommand("select  * from  MNG_PURCHASE_PANEl", con);
            dap = new SqlDataAdapter(cmd);
            ds = new DataSet();
            dap.Fill(ds, "datax");
            dataGridView1.DataMember = "datax";
            dataGridView1.DataSource = ds;
        }

        private void btngetexcel_Click(object sender, EventArgs e)
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

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("select  * from  MNG_PURCHASE_PANEL", con);
            dap = new SqlDataAdapter(cmd);
            ds = new DataSet();
            dap.Fill(ds, "datax");

            dataGridView1.DataMember = "datax";
            dataGridView1.DataSource = ds;
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            try
            {

                {
                    // con.Open();

                    SqlCommand cmd = new SqlCommand("SELECT * FROM MNG_PURCHASE_PANEL WHERE INVOICE_DATE BETWEEN @StartDate AND @EndDate", con);
                    cmd.Parameters.AddWithValue("@StartDate", dateTimePicker1.Value.ToString("dd-MM-yyyy"));
                    cmd.Parameters.AddWithValue("@EndDate", dateTimePicker3.Value.ToString("dd-MM-yyyy"));
                    cmd.Parameters.AddWithValue("@1", label5.Text);
                    dap = new SqlDataAdapter(cmd);
                    ds = new DataSet();
                    dap.Fill(ds, "datax");
                    dataGridView1.DataMember = "datax";
                    dataGridView1.DataSource = ds;
                    //  con.Close();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
