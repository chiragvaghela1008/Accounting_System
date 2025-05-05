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
    public partial class Mng_City : Form
    {

        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter dap;
        DataSet ds;


        public Mng_City()
        {
            InitializeComponent();
        }


        private void Mng_City_Load(object sender, EventArgs e)
        {

            con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=ACCOUNTING_SYSTEM;Integrated Security=True");
            con.Open();
            btnupdate.Visible = false;
            BtnSave.Visible = true;
            cmd = new SqlCommand("select  * from  MNG_CITY", con);
            dap = new SqlDataAdapter(cmd);
            ds = new DataSet();
            dap.Fill(ds, "datax");
            dataGridView1.DataMember = "datax";
            dataGridView1.DataSource = ds;


        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void BtnSave_Click(object sender, EventArgs e)
        {


            cmd = new SqlCommand("insert into MNG_CITY values (@1,@2)",con);
            cmd.Parameters.AddWithValue("@1", txtcityname.Text);
            cmd.Parameters.AddWithValue("@2", txtpincode.Text);
            cmd.ExecuteNonQuery();

            txtpincode.Clear();
            txtcityname.Clear();

            cmd = new SqlCommand("select  * from  MNG_CITY", con);
            dap = new SqlDataAdapter(cmd);
            ds = new DataSet();
            dap.Fill(ds, "datax");
            dataGridView1.DataMember = "datax";
            dataGridView1.DataSource = ds;
            MessageBox.Show("insert data successfully");
           
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtcityname.Clear();
            txtpincode.Clear();
            btnupdate.Visible = false;
            BtnSave.Visible = true;

            cmd = new SqlCommand("select  * from  MNG_CITY", con);
            dap = new SqlDataAdapter(cmd);
            ds = new DataSet();
            dap.Fill(ds, "datax");
            dataGridView1.DataMember = "datax";
            dataGridView1.DataSource = ds;

        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("select  * from  MNG_CITY where CITY =@1", con);
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
            txtcityname.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            txtpincode.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();

            btnupdate.Visible = true;
            BtnSave.Visible = false;
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("update MNG_CITY set CITY=@1,PIN_CODE=@2 where MNG_CITY_ID=@0",con);
            cmd.Parameters.AddWithValue("@0", lblID.Text);
            cmd.Parameters.AddWithValue("@1", txtcityname.Text);
            cmd.Parameters.AddWithValue("@2", txtpincode.Text);
            cmd.ExecuteNonQuery();

            txtpincode.Clear();
            txtcityname.Clear();

            cmd = new SqlCommand("select  * from  MNG_CITY", con);
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
