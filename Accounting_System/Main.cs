using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Accounting_System
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }


       

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Sale_Entry mn = new Sale_Entry();
            mn.Show();

        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            Item_Master mn = new Item_Master();
            mn.Show();
        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            Mng_City mn = new Mng_City();
            mn.Show();
        }

        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {
            Mng_Company mn = new Mng_Company();
            mn.Show();
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            Ledger_details mn = new Ledger_details();
            mn.Show();
        }

        private void ledgerTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mng_ledger mn = new Mng_ledger();
            mn.Show();
        }

        private void contraVoucherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Contra_Voucher mn = new Contra_Voucher();
            mn.Show();
        }

        private void receiptVoucherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Receipt_Voucher mn = new Receipt_Voucher();
            mn.Show();
        }

        private void journalVoucherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Journal_voucher mn = new Journal_voucher();
            mn.Show();
        }

        private void paymentVoucherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Payment_vouchercs mn = new Payment_vouchercs();
            mn.Show();
        }

        private void saleReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sale_Report mn = new Sale_Report();
            mn.Show();
        }

        private void toolStripMenuItem12_Click(object sender, EventArgs e)
        {
            this.Hide();
           
            login_main mn = new login_main();
           
            mn.Show();
            
            MessageBox.Show("Logout Successfully");
            
            
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Purchase_entry mn = new Purchase_entry();
            mn.Show();
        }

        private void purchaseReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Purchase_report mn = new Purchase_report();
            mn.Show();
        }
        }

        
    }

