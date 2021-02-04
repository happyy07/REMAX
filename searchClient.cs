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
    public partial class searchClient : Form
    {
        public searchClient()
        {
            InitializeComponent();
        }

        DataTable tabClients;
        private void searchClient_Load(object sender, EventArgs e)
        {
            tabClients = clsGlobal.mySet.Tables["Clients"];
           
            gridClients.DataSource = tabClients;

            lblSearchMessage.Text = "ALL CLIENTS";

        }

        private void btnSearchClient_Click(object sender, EventArgs e)
        {
            if(cboSearch.SelectedItem.ToString() == "clientId")
            {
                int id = Convert.ToInt32(txtValue.Text);

                var foundClient = from client in tabClients.AsEnumerable()
                                  where client.Field<int>("id") == id
                                  select client;


                if (foundClient.Count() > 0)
                {
                    gridClients.DataSource = foundClient.CopyToDataTable();
                    lblSearchMessage.Text = "CLIENT OF CLIENT ID: " + id;
                }
                else
                {
                    MessageBox.Show("Client Id Not Found, Try again.", "TD: Identification Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                }
            }
            else if(cboSearch.SelectedItem.ToString() == "agentId")
            {
                string id = txtValue.Text.ToString();

                var foundAllClients = from client in tabClients.AsEnumerable()
                                  where client.Field<string>("AgentId") == id
                                  select client;


                if (foundAllClients.Count() > 0)
                {
                    gridClients.DataSource = foundAllClients.CopyToDataTable();
                    lblSearchMessage.Text = "ALL CLIENTS OF AGENT ID: " + id;
                }
                else
                {
                    MessageBox.Show("Agent Id Not Found, Try again.", "TD: Identification Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                   
                }
            }
            else
            {
                string type = txtValue.Text.ToString();

                var foundAllClients = from client in tabClients.AsEnumerable()
                                      where client.Field<string>("Type") == type
                                      select client;


                if (foundAllClients.Count() > 0)
                {
                    gridClients.DataSource = foundAllClients.CopyToDataTable();
                    lblSearchMessage.Text = "ALL CLIENTS OF TYPE " + type;
                }
                else
                {
                    MessageBox.Show("Agent Id Not Found, Try again.", "TD: Identification Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }


        }
    }
}
