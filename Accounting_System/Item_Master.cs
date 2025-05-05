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
    public partial class Item_Master : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter dap;
        DataSet ds;
        public Item_Master()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void textBox21_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
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

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox20_TextChanged(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtitemname.Clear();
            txtitemcode.Clear();
            ddlname.SelectedIndex= -1;
            ddlpack.SelectedIndex = -1;
            ddlitemname.SelectedIndex = -1;
            txthsncode.Clear();
            txtmrp.Clear();
            txtlandingprice.Clear();
            txtopeningstock.Clear();

            txtcgst.Clear();
            txtsgst.Clear();

            txtdiscount.Clear();
            txtsalerate.Clear();
            txtnarration.Clear();
            

            btnupdate.Visible = false;
            btnsave.Visible = true;

           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("update  MNG_ITEM_MASTER set ITEM_CODE=@1,ITEM_NAME=@2,COMPANY_NAME=@3,PACK=@4,HSN_CODE=@5,MRP=@6,ITEM_LANDING_PRICE=@7,OPENING_STOCK=@8,CGST=@9,SGST=@10,DISCOUNT=@11,SALE_PRICE=@12,NARRATION=@13,ENTRY_DATE=@14 where MNG_ITEM_MASTER_ID=@0", con);
            cmd.Parameters.AddWithValue("@0", lblID.Text);
            cmd.Parameters.AddWithValue("@1", txtitemcode.Text);
            cmd.Parameters.AddWithValue("@2", txtitemname.Text);
            cmd.Parameters.AddWithValue("@3", ddlname.Text);
            cmd.Parameters.AddWithValue("@4", ddlpack.Text);
            cmd.Parameters.AddWithValue("@5", txthsncode.Text);
            cmd.Parameters.AddWithValue("@6", txtmrp.Text);
            cmd.Parameters.AddWithValue("@7", txtlandingprice.Text);
            cmd.Parameters.AddWithValue("@8", txtopeningstock.Text);
            cmd.Parameters.AddWithValue("@9", txtcgst.Text);
            cmd.Parameters.AddWithValue("@10", txtsgst.Text);
            cmd.Parameters.AddWithValue("@11", txtdiscount.Text);
            cmd.Parameters.AddWithValue("@12", txtsalerate.Text);
            cmd.Parameters.AddWithValue("@13", txtnarration.Text);
            cmd.Parameters.AddWithValue("@14", "");
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            txtitemname.Clear();
            txtitemcode.Clear();
            ddlname.SelectedIndex = -1;

            ddlpack.SelectedIndex = -1;

            txthsncode.Clear();
            txtmrp.Clear();
            txtlandingprice.Clear();
            txtopeningstock.Clear();

            txtcgst.Clear();
            txtsgst.Clear();

            txtdiscount.Clear();
            txtsalerate.Clear();
            txtnarration.Clear();








            cmd = new SqlCommand("select  * from  MNG_ITEM_MASTER", con);
            dap = new SqlDataAdapter(cmd);
            ds = new DataSet();
            dap.Fill(ds, "datax");
            dataGridView1.DataMember = "datax";
            dataGridView1.DataSource = ds;
            MessageBox.Show("update data successfully");
        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void Item_Master_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=ACCOUNTING_SYSTEM;Integrated Security=True");
            con.Open();
            cmd = new SqlCommand("select  * from  MNG_ITEM_MASTER", con);
            dap = new SqlDataAdapter(cmd);
            ds = new DataSet();
            dap.Fill(ds, "datax");
            
            cmd.ExecuteNonQuery();



            SqlCommand cmd1 = new SqlCommand("Select DISTINCT ITEM_NAME from MNG_ITEM_MASTER ", con);
          
            SqlDataAdapter dap1 = new SqlDataAdapter(cmd);
            DataSet ds1 = new DataSet();
            dap1.Fill(ds);

            for (int index = 0; index < ds.Tables[0].Rows.Count; index++)
            {
                ddlitemname.Items.Add(ds.Tables[0].Rows[index][2].ToString());
            }
            



            con.Close();

            btnupdate.Visible = false;
            btnsave.Visible = true;
            
            dataGridView1.DataMember = "datax";
            dataGridView1.DataSource = ds;


            con.Open();
            cmd = new SqlCommand("select  * from  MNG_COMPANY", con);
            dap = new SqlDataAdapter(cmd);
            ds = new DataSet();
            dap.Fill(ds, "datax");
            cmd.ExecuteNonQuery();
            con.Close();
            ddlname.DataSource = ds.Tables[0];
            ddlname.DisplayMember = "COMPANY_NAME";
            ddlname.ValueMember = "COMPANY_NAME";

            con.Open();
            cmd = new SqlCommand("select  * from  MNG_PACK", con);
            dap = new SqlDataAdapter(cmd);
            ds = new DataSet();
            dap.Fill(ds, "datax");
            cmd.ExecuteNonQuery();
            con.Close();
            ddlpack.DataSource = ds.Tables[0];
            ddlpack.DisplayMember = "PACK";
            ddlpack.ValueMember = "PACK";

            
            
          


        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            

            cmd = new SqlCommand("insert into MNG_ITEM_MASTER values (@1,@2,@3,@4,@5,@6,@7,@8,@9,@10,@11,@12,@13,@14)", con);

            cmd.Parameters.AddWithValue("@1", txtitemcode.Text);
            cmd.Parameters.AddWithValue("@2", txtitemname.Text);
            cmd.Parameters.AddWithValue("@3", ddlname.Text);
            cmd.Parameters.AddWithValue("@4", ddlpack.Text);
            cmd.Parameters.AddWithValue("@5", txthsncode.Text);
            cmd.Parameters.AddWithValue("@6", txtmrp.Text);
            cmd.Parameters.AddWithValue("@7", txtlandingprice.Text);
            cmd.Parameters.AddWithValue("@8", txtopeningstock.Text);
            cmd.Parameters.AddWithValue("@9", txtcgst.Text);
            cmd.Parameters.AddWithValue("@10", txtsgst.Text);
            cmd.Parameters.AddWithValue("@11", txtdiscount.Text);
            cmd.Parameters.AddWithValue("@12", txtsalerate.Text);
            cmd.Parameters.AddWithValue("@13", txtnarration.Text);
            cmd.Parameters.AddWithValue("@14", "");
            
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("insert data successfully");
            
            






            txtitemname.Clear();
            txtitemcode.Clear();
            //ddlname.;
            //ddlpack.Items.Clear();

            txthsncode.Clear();
            txtmrp.Clear();
            txtlandingprice.Clear();
            txtopeningstock.Clear();

            txtcgst.Clear();
            txtsgst.Clear();

            txtdiscount.Clear();
            txtsalerate.Clear();
            txtnarration.Clear();



            cmd = new SqlCommand("select  * from  MNG_ITEM_MASTER", con);
            dap = new SqlDataAdapter(cmd);
            ds = new DataSet();
            dap.Fill(ds, "datax");

            dataGridView1.DataMember = "datax";
            dataGridView1.DataSource = ds;

        }

        private void comboBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {
           

        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
           
        }

        private void ddlname_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            lblID.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            txtitemcode.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            txtitemname.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            ddlname.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            ddlpack.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            txthsncode.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            txtmrp.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            txtlandingprice.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            txtopeningstock.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
            txtcgst.Text = dataGridView1.SelectedRows[0].Cells[9].Value.ToString();
            txtsgst.Text = dataGridView1.SelectedRows[0].Cells[10].Value.ToString();
            txtdiscount.Text = dataGridView1.SelectedRows[0].Cells[11].Value.ToString();
            txtsalerate.Text = dataGridView1.SelectedRows[0].Cells[12].Value.ToString();
            txtnarration.Text = dataGridView1.SelectedRows[0].Cells[13].Value.ToString();
            
            btnupdate.Visible = true;
            btnsave.Visible = false;
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            
        }

        private void ddlitemname_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmd = new SqlCommand("select  * from  MNG_ITEM_MASTER where ITEM_NAME=@1", con);
            cmd.Parameters.AddWithValue("@1", ddlitemname.Text);
            dap = new SqlDataAdapter(cmd);
            ds = new DataSet();
            dap.Fill(ds, "datax");

            dataGridView1.DataMember = "datax";
            dataGridView1.DataSource = ds;
            
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            cmd = new SqlCommand("select  * from  MNG_ITEM_MASTER", con);
            dap = new SqlDataAdapter(cmd);
            ds = new DataSet();
            dap.Fill(ds, "datax");

            dataGridView1.DataMember = "datax";
            dataGridView1.DataSource = ds;

            
        }

       
    }
}
