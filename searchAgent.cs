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
    public partial class searchAgent : Form
    {
        public searchAgent()
        {
            InitializeComponent();
        }

        DataTable tabAgents;

        private void gridHouses_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSearchAgent_Click(object sender, EventArgs e)
        {
            
                int id = Convert.ToInt32(txtAgentId.Text);

                var foundAgent = from agent in tabAgents.AsEnumerable()
                                 where agent.Field<int>("id") == id
                                 select agent;

                if (foundAgent.Count() > 0)
                {
                    gridAgents.DataSource = foundAgent.CopyToDataTable();
                    lblSearchMessage.Text = "AGENT OF AGENT ID: " + id;
                }
                else
                {
                    MessageBox.Show("Agent Id Not Found, Try again.", "TD: Identification Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                }            

        }

        private void searchAgent_Load(object sender, EventArgs e)
        {
            tabAgents = clsGlobal.mySet.Tables["Agents"];

            gridAgents.DataSource = tabAgents;

            lblSearchMessage.Text = "ALL AGENTS";

        }
    }
}
