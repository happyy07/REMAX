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
    public partial class frmClientLogin : Form
    {
        public frmClientLogin()
        {
            InitializeComponent();
        }

        //global variable
        DataTable tabClients;
        string clientPin;       

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNextId_Click(object sender, EventArgs e)
        {

            int id = Convert.ToInt32(txtId.Text);

            var foundClient = from client in tabClients.AsEnumerable()
                              where client.Field<int>("id") == id
                              select client;
           
            if (foundClient.Count() > 0)
            { 
               
                DataRow myRow = foundClient.First();
                lblWelcome.Text = "Welcome " + myRow["name"];

                clsGlobal.Id = myRow["id"].ToString();
                clsGlobal.Name = myRow["name"].ToString();
                clientPin = myRow["pin"].ToString();              
                txtPin.Focus();
                this.Height = 500;
            }
            else
            {
                MessageBox.Show("Client Id Not Found, Try again.", "TD: Identification Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtId.Focus();
            }
            
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string pin = txtPin.Text.ToString();

            if (pin == clientPin.ToString())
            {
                frmListHouse houses = new frmListHouse();
                houses.Show();               
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

        private void frmClientLogin_Load(object sender, EventArgs e)
        {
            tabClients = clsGlobal.mySet.Tables["Clients"];

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
