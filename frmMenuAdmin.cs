using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjFinal
{
    public partial class frmMenuAdmin : Form
    {
        public frmMenuAdmin()
        {
            InitializeComponent();
            
        }

        private void mnuQuit_Click(object sender, EventArgs e)
        {
            string info = "Are you sure to want to qui this program ?";
            string title = "Application Closing Warning";

            if (MessageBox.Show(info, title, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void mnuAgents_Click(object sender, EventArgs e)
        {
            frmAgent agent = new frmAgent();
            agent.Show();
        }

        private void mnuClients_Click(object sender, EventArgs e)
        {
            frmClient client = new frmClient();
            client.Show();

        }

        private void mnuHouses_Click(object sender, EventArgs e)
        {
            frmHouse house = new frmHouse();
            house.Show();

        }

        private void frmMenuAdmin_Load(object sender, EventArgs e)
        {

        }

        private void searchAgent_Click(object sender, EventArgs e)
        {
            searchAgent agent = new searchAgent();
            agent.Show();
        }

        private void searchClient_Click(object sender, EventArgs e)
        {
            searchClient client = new searchClient();
            client.Show();
        }

        private void SearchHouse_Click(object sender, EventArgs e)
        {
            searchHouse house = new searchHouse();
            house.Show();
        }
    }
}
