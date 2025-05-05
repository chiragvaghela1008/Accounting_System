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
    public partial class MNG_MAIN : Form
    {
        public MNG_MAIN()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            Item_Master mn = new Item_Master();

            mn.Show();

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Sale_Entry mn = new Sale_Entry();

            mn.Show();

        }

        private void toolStripMenuItem12_Click(object sender, EventArgs e)
        {
            this.Hide();
            login_main mn = new login_main();

            mn.Show();

            MessageBox.Show("Logout Successfully");
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            Ledger_details mn = new Ledger_details();

            mn.Show();
        }

        private void saleReportToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Sale_Report mn = new Sale_Report();

            mn.Show();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Purchase_entry mn = new Purchase_entry();

            mn.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip3_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
