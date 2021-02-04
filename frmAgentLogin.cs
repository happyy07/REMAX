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
    public partial class frmAgentLogin : Form
    {
        public frmAgentLogin()
        {
            InitializeComponent();
        }

        //global variable
        DataTable tabAgents;
        string agentPin;

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
           
        }

        private void lblPin_Click(object sender, EventArgs e)
        {

        }

        private void txtPin_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnNextId_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtId.Text);

            var foundAgent = from agent in tabAgents.AsEnumerable()
                             where agent.Field<int>("id") == id
                             select agent;
                              
            if (foundAgent.Count() > 0)
            {
                DataRow myRow = foundAgent.First();
                lblWelcome.Text = "Welcome " + myRow["name"];

                clsGlobal.Id = myRow["id"].ToString();
                clsGlobal.Name = myRow["name"].ToString();
                agentPin = myRow["pin"].ToString();

                txtPin.Focus();
                this.Height = 450;
            }
            else
            {
                MessageBox.Show("Agent Id Not Found, Try again.", "TD: Identification Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtId.Focus();
            }
            
        }

        private void frmAgentLogin_Load(object sender, EventArgs e)
        {
            tabAgents = clsGlobal.mySet.Tables["Agents"];
           
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string pin = txtPin.Text.ToString();

            if (pin == agentPin)
            {
                frmMenuAgent mnuAgent = new frmMenuAgent();
                mnuAgent.Show();                
                clsGlobal.flag = "agent";
            }
            else
            {
                MessageBox.Show("Incorrect pin, Try again.", "TD: Incorrect pin Error",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPin.Focus();
                return;
            }
            
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
