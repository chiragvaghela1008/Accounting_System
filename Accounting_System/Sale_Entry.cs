using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Accounting_System
{
    public partial class Sale_Entry : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter dap;
        DataSet ds;

        CrystalReport3 doc = new CrystalReport3();
        DataSet2 ds1 = new DataSet2();
       
        
       
        public Sale_Entry()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }

        private void Sale_Entry_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=ACCOUNTING_SYSTEM;Integrated Security=True");
            con.Open();
            cmd = new SqlCommand("select  * from MNG_ITEM_MASTER ", con);
            dap = new SqlDataAdapter(cmd);
            ds = new DataSet();
            dap.Fill(ds, "datax");

            cmd.ExecuteNonQuery();
            con.Close();


            SqlCommand cmd1 = new SqlCommand("Select DISTINCT ITEM_NAME from MNG_ITEM_MASTER ", con);

            SqlDataAdapter dap1 = new SqlDataAdapter(cmd);
            DataSet ds1 = new DataSet();
            dap1.Fill(ds);

            for (int index = 0; index < ds.Tables[0].Rows.Count; index++)
            {
                ddlitemname.Items.Add(ds.Tables[0].Rows[index][2].ToString());
            }

            cmd = new SqlCommand("SELECT DISTINCT CUSTOMER_NAME FROM MNG_SALE_PANEL", con);
            dap = new SqlDataAdapter(cmd);
            ds = new DataSet();
            dap.Fill(ds, "datax");

            ddlcustomername.DataSource = ds.Tables[0];
            ddlcustomername.DisplayMember = "CUSTOMER_NAME";

            DataClasses1DataContext abc = new DataClasses1DataContext();
            
            int FileCount = (from row in abc.MNG_SALE_PANELs
                             select row).Count();
            txtinvoiceno.Text = (FileCount + 1).ToString();
            txtinvoiceno.Focus();
            

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtdisc_TextChanged(object sender, EventArgs e)
        {

        }
        private int k = 0;
        private void btnaddtocart_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(ddlitemname.Text))
                {
                    MessageBox.Show("Product Name Should not be Empty!");
                    ddlitemname.Focus();
                }
                else
                {
                    ListViewItem lst1 = new ListViewItem((k + 1).ToString()); 
                    lst1.SubItems.Add(txtitemcode.Text);
                    lst1.SubItems.Add(ddlitemname.Text);
                    lst1.SubItems.Add(txthsn.Text);
                    lst1.SubItems.Add(txtmrp.Text);
                    lst1.SubItems.Add(txtsellingprice.Text);
                    lst1.SubItems.Add(txtqnt.Text);
                    lst1.SubItems.Add(txtdisc.Text);
                   
                    lst1.SubItems.Add(txttotal.Text);
                    
                    lst1.SubItems.Add(txtc.Text);
                    lst1.SubItems.Add(txtvalue.Text);
                    lst1.SubItems.Add(txts.Text);
                    lst1.SubItems.Add(txt_value.Text);
                    lst1.SubItems.Add(txtamount.Text);
                    

                    listView1.Items.Add(lst1);
                    k++; 

                    txtsubtotal.Text = CalculateSubtotal().ToString();
                    txtgrandtotal.Text = Calculategrandtotal().ToString();
                    txtcgsttotal.Text = Calculatecgsttotal().ToString();
                    txtsgsttotal.Text = Calculatesgsttotal().ToString();
                    txtdiscount.Text = Calculatedisctotal().ToString();
                   


                    CartTextBoxClear();
                 
                    
                   // LastCal();

                    ddlitemname.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private int CalculateSubtotal()
        {
            int subtotal = 0;
            foreach (ListViewItem item in listView1.Items)
            {
                subtotal += int.Parse(item.SubItems[8].Text);
            }
            return subtotal;
        }

        private int Calculategrandtotal()
        {
            int grandtotal = 0;
            foreach (ListViewItem item in listView1.Items)
            {
                grandtotal += int.Parse(item.SubItems[13].Text);
            }
            return grandtotal;
        }
        private int Calculatecgsttotal()
        {
            int cgsttotal = 0;
            foreach (ListViewItem item in listView1.Items)
            {
                cgsttotal += int.Parse(item.SubItems[10].Text);
            }
            return cgsttotal;
        }
        private int Calculatesgsttotal()
        {
            int sgsttotal = 0;
            foreach (ListViewItem item in listView1.Items)
            {
                sgsttotal += int.Parse(item.SubItems[12].Text);
            }
            return sgsttotal;
        }
        private int Calculatedisctotal()
        {
            int disctotal = 0;
            foreach (ListViewItem item in listView1.Items)
            {
                disctotal += int.Parse(item.SubItems[7].Text);
            }
            return disctotal;
        }
      

       
      
       
       
        private void CartTextBoxClear()
        {
            
                
            txtitemcode.Clear();
            ddlitemname.SelectedIndex = -1;
            txthsn.Clear();
            txtmrp.Clear();
            txtsellingprice.Clear();
            txtqnt.Clear();
            txtdisc.Clear();
            txttotal.Clear();
            txtc.Clear();
            txtvalue.Clear();
            txts.Clear();
            txt_value.Clear();
            txtamount.Clear();

            
             
        }
       
        
        private void LastCal()
        {
            
           
        }
        
            
             

        

        private void ddlproductname_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            cmd = new SqlCommand("select  * from  MNG_ITEM_MASTER where ITEM_NAME=@2", con);
            cmd.Parameters.AddWithValue("@2", ddlitemname.Text);

            dap = new SqlDataAdapter(cmd);
            ds = new DataSet();
            dap.Fill(ds, "datax");
            dap = new SqlDataAdapter(cmd);
            ds = new DataSet();
            
            try
            {
                if (string.IsNullOrEmpty(ddlitemname.Text))
                {

                    ddlitemname.Focus();
                }
                else
                {
                    
                    SqlDataAdapter dap1 = new SqlDataAdapter(cmd);
                    DataSet ds1 = new DataSet();
                    
                    if (dap.Fill(ds) > 0)
                    {
                      
                        
                        txtitemcode.Text = ds.Tables[0].Rows[0][1].ToString();
                        ddlitemname.Text = ds.Tables[0].Rows[0][2].ToString();
                        txthsn.Text = ds.Tables[0].Rows[0][5].ToString();
                        txtmrp.Text = ds.Tables[0].Rows[0][6].ToString();
                        //txttotal.Text = (txtsellingprice.Text) * (txtqnt.Text);

                       

                        txtsellingprice.Text = ds.Tables[0].Rows[0][7].ToString();
                        txtqnt.Text = "1";
                      

                        txtc.Text = ds.Tables[0].Rows[0][9].ToString();
                        txts.Text = ds.Tables[0].Rows[0][10].ToString();
                        txtdisc.Text = ds.Tables[0].Rows[0][11].ToString();
                        //txttotal.Text = ds.Tables[0].Rows[0][12].ToString();
                        //decimal sellingprice = decimal.Parse(txtsellingprice.Text);
                       // decimal discount = decimal.Parse(txtdisc.Text);
                        //decimal Qnt = decimal.Parse(txtqnt.Text);
                        //decimal totalAmount = (sellingprice - (sellingprice * discount / 100)) * Qnt;

                        int num1 = Convert.ToInt32(txtsellingprice.Text);
                        int num2 = Convert.ToInt32(txtqnt.Text);
                        int answ = num1 * num2;
                        txttotal.Text = answ.ToString();
                         
                        int num3 = Convert.ToInt32(txttotal.Text);
                        int num4 = Convert.ToInt32(txtc.Text);
                        int div = num3 / num4;
                        txtvalue.Text = div.ToString();

                        int num5 = Convert.ToInt32(txttotal.Text);
                        int num6 = Convert.ToInt32(txts.Text);
                        int abc = num3 / num4;
                        txt_value.Text = abc.ToString();

                        int num7 = Convert.ToInt32(txttotal.Text);
                        int num8 = Convert.ToInt32(txtvalue.Text);
                        int num9 = Convert.ToInt32(txtvalue.Text);
                        int cg = num7 + num8 + num9;
                        txtamount.Text = cg.ToString();

                        
                      


                       

                       
                       

                        
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }




        }



        private void ddlcustomername_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmd = new SqlCommand("select  * from  MNG_SALE_PANEL where CUSTOMER_NAME=@4", con);
            cmd.Parameters.AddWithValue("@4", ddlcustomername.Text);
            dap = new SqlDataAdapter(cmd);
            ds = new DataSet();
            dap.Fill(ds, "datax");

            
        }


        private void btnromoveselected_Click(object sender, EventArgs e)
        {
            try
            {
                if ((listView1.SelectedItems.Count > 0))
                {
                    int itmCnt, i, t;
                    listView1.FocusedItem.Remove();
                    itmCnt = listView1.Items.Count;
                    t = 1;
                    //txtsubtotal.Text = subtotl();
                    //lastcal();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("select  * from MNG_ITEM_MASTER ", con);
            dap = new SqlDataAdapter(cmd);
            ds = new DataSet();
            dap.Fill(ds, "datax");

            cmd.ExecuteNonQuery();

            listView1.Refresh();
        }

        private void btnremoveall_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
        }

        private void txtgiven_TextChanged(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(txtgiven.Text);
            int num2 = Convert.ToInt32(txtgrandtotal.Text);
            int abc = num1 - num2;
            txtreturn.Text = abc.ToString();
        }

        private void btnsaveprint_Click(object sender, EventArgs e)
        {


            cmd = new SqlCommand("insert into MNG_SALE_PANEL values (@1,@2,@3,@4,@5,@6,@7,@8,@9,@10,@11,@12,@13,@14,@15,@16,@17)", con);
            cmd.Parameters.AddWithValue("@1", txtinvoiceno);
            cmd.Parameters.AddWithValue("@2", "");
            cmd.Parameters.AddWithValue("@3", "");
            cmd.Parameters.AddWithValue("@4", "");
            cmd.Parameters.AddWithValue("@5", ddlpaymenttype.Text);
            cmd.Parameters.AddWithValue("@5", txtgiven.Text);
            cmd.Parameters.AddWithValue("@6", txtreturn.Text);
            cmd.Parameters.AddWithValue("@7", txtsubtotal.Text);
            cmd.Parameters.AddWithValue("@8", txtcgsttotal.Text);
            cmd.Parameters.AddWithValue("@9", txtsgsttotal.Text);
            cmd.Parameters.AddWithValue("@10", txtdiscount.Text);
            cmd.Parameters.AddWithValue("@11", "");
            cmd.Parameters.AddWithValue("@12", "");
            cmd.Parameters.AddWithValue("@13", "");
            cmd.Parameters.AddWithValue("@14", "");
            cmd.Parameters.AddWithValue("@15", txtgrandtotal.Text);
            cmd.Parameters.AddWithValue("@16", "");


            for (var i = 0; i <= listView1.Items.Count - 1; i++)
            {
                cmd = new SqlCommand("insert into MNG_SALE_CART values (@1,@2,@3,@4,@5,@6,@7,@8,@9,@10,@11,@12,@13,@14,@15,@16)", con);
                cmd.Parameters.AddWithValue("@1", txtinvoiceno);
                cmd.Parameters.AddWithValue("@2", "");
                cmd.Parameters.AddWithValue("@3", txtitemcode.Text);
                cmd.Parameters.AddWithValue("@4", ddlitemname.Text);
                cmd.Parameters.AddWithValue("@5", txthsn);
                cmd.Parameters.AddWithValue("@5", txtmrp.Text);
                cmd.Parameters.AddWithValue("@6", txtsellingprice.Text);
                cmd.Parameters.AddWithValue("@7", txtqnt.Text);
                cmd.Parameters.AddWithValue("@8", txtdisc.Text);
                cmd.Parameters.AddWithValue("@9", txtdisc.Text);
                cmd.Parameters.AddWithValue("@10", "");
                cmd.Parameters.AddWithValue("@11", txtc.Text);
                cmd.Parameters.AddWithValue("@12", txtvalue.Text);
                cmd.Parameters.AddWithValue("@13", txts.Text);
                cmd.Parameters.AddWithValue("@14", txt_value.Text);
                cmd.Parameters.AddWithValue("@15", txtamount.Text);
                cmd.Parameters.AddWithValue("@16", "");









                ////MessageBox.Show("insert data successfully");
                //con.Open();
                //cmd.ExecuteNonQuery();
                //con.Close();















                CrystalReport3 crystalReport = new CrystalReport3();
                DataSet2 V_SALE = GetData();
                crystalReport.SetDataSource(V_SALE);
                // Inv_print.CrystalReportViewer1.ReportSource = crystalReport
                // Inv_print.CrystalReportViewer1.RefreshReport()
                crystalReport.PrintToPrinter(1, true, 1, 1);


            }
        }

        private DataSet2 GetData()
        {
            // Dim constr As String = "Data Source= 5.189.147.163;Initial Catalog=DEMORES;Persist Security Info=True;User ID=DEMORES;Password=Jani@6194"
            string constr = "Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=ACCOUNTING_SYSTEM;Integrated Security=True";
            // Dim constr As String = "Data Source=LAPTOP-UE5GCQ5Q;Initial Catalog=RESTAURANT_SYSTEM2020;Persist Security Info=True;User ID=sa;Password=Jani@6194"
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM V_SALE WHERE INVOICE_NO='" + txtinvoiceno.Text + "' ", con))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter())
                    {
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        using (DataSet2 V_SALE = new DataSet2())
                        {
                            sda.Fill(V_SALE, "V_SALE");
                            return V_SALE;
                        }
                    }
                }
            }
        }

    }
}
