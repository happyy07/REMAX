using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjFinal
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            string info = "Are you sure to want to qui this program ?";
            string title = "Application Closing Warning";

            if(MessageBox.Show(info, title, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void btnNextMain_Click(object sender, EventArgs e)
        {
            if(radioAdmin.Checked == true)
            {             
                frmAdminLogin formAdmin = new frmAdminLogin();
                formAdmin.MdiParent = this;
                formAdmin.Show();                              
            }
            else if(radioAgent.Checked == true)
            {              
                frmAgentLogin formAgent = new frmAgentLogin();
                formAgent.MdiParent = this;
                formAgent.Show();
            }
            else
            {               
                frmClientLogin formClient = new frmClientLogin();
                formClient.MdiParent = this;
                formClient.Show();
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            clsGlobal.mySet = new DataSet();

            // create a connection to the database dbRemax and open it
            clsGlobal.myCon = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=dbRemax;Integrated Security=True");
            clsGlobal.myCon.Open();


            //// -------  INSERT The table Admin from the database to the global dataset
            // create a command to the connection to request the table Admin
            SqlCommand myCmd = new SqlCommand("SELECT * FROM Admin", clsGlobal.myCon);
            // create a dataAdapter with the command, and fill (or insert) the dataset with the result of the command as a new datatable
            clsGlobal.adpAdmin = new SqlDataAdapter(myCmd);
            clsGlobal.adpAdmin.Fill(clsGlobal.mySet, "Admin");


            //// -------  INSERT The table Agents from the database to the global dataset
            // create a command to the connection to request the table Agents
            myCmd = new SqlCommand("SELECT * FROM Agents", clsGlobal.myCon);
            // create a dataAdapter with the command, and fill (or insert) the dataset with the result of the command as a new datatable
            clsGlobal.adpAgents = new SqlDataAdapter(myCmd);
            clsGlobal.adpAgents.Fill(clsGlobal.mySet, "Agents");

            //// -------  INSERT The table Clients from the database to the global dataset
            // create a command to the connection to request the table Clients
            myCmd = new SqlCommand("SELECT * FROM Clients", clsGlobal.myCon);
            // create a dataAdapter with the command, and fill (or insert) the dataset with the result of the command as a new datatable
            clsGlobal.adpClients = new SqlDataAdapter(myCmd);
            clsGlobal.adpClients.Fill(clsGlobal.mySet, "Clients");

            //// -------  INSERT The table Houses from the database to the global dataset
            // create a command to the connection to request the table Houses
            myCmd = new SqlCommand("SELECT * FROM Houses", clsGlobal.myCon);
            // create a dataAdapter with the command, and fill (or insert) the dataset with the result of the command as a new datatable
            clsGlobal.adpHouses = new SqlDataAdapter(myCmd);
            clsGlobal.adpHouses.Fill(clsGlobal.mySet, "Houses");

        }

        private void radioAdmin_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
