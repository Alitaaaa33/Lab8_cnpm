using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab7
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            IsMdiContainer = true;
            frmLogin lgform = new frmLogin();
            lgform.ShowDialog();
        }

        private void managementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataView fview = new DataView();
            fview.Show();
        }

        private void itemToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            DataItem fItem = new DataItem();
            fItem.Show();
        }

        private void agentToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            DataAgent fAgent = new DataAgent();
            fAgent.Show();
        }

        private void orderToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            DataOrder fOrder = new DataOrder();
            fOrder.Show();
        }

       

        private void orderDetailToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            DataOrderDetail fOrderDe = new DataOrderDetail();
            fOrderDe.Show();
        }
    }
}
