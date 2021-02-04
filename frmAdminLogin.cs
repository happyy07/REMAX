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
    public partial class frmAdminLogin : Form
    {
        public frmAdminLogin()
        {
            InitializeComponent();
        }

        //global variable
        DataTable tabAdmin;
        string adminPin;

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            string pin = txtPin.Text.ToString();

            if (pin == adminPin)
            {
                frmMenuAdmin mnuAdmin = new frmMenuAdmin();
                mnuAdmin.Show();
                clsGlobal.flag = "admin";
            }
            else
            {
                MessageBox.Show("Incorrect pin, Try again.", "TD: Incorrect pin Error",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPin.Focus();
                return;
            }
        }

        private void frmAdminLogin_Load(object sender, EventArgs e)
        {
            tabAdmin = clsGlobal.mySet.Tables["Admin"];
        }

        private void btnNextId_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtId.Text);

            var foundAdmin = from admin in tabAdmin.AsEnumerable()
                                 where admin.Field<int>("id") == id
                                 select admin;
                                 

            if (foundAdmin.Count() > 0)
            {
                DataRow myRow = foundAdmin.First();
                lblWelcome.Text = "Welcome " + myRow["name"];

                clsGlobal.Id = myRow["id"].ToString();
                clsGlobal.Name = myRow["name"].ToString();
                adminPin = myRow["pin"].ToString();

                txtPin.Focus();
                this.Height = 500;
            }
            else
            {
                MessageBox.Show("Admin Id Not Found, Try again.", "TD: Identification Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtId.Focus();
            }
        }

        private void frmAdminLogin_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
   
}
