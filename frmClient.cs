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
    public partial class frmClient : Form
    {
        public frmClient()
        {
            InitializeComponent();
        }

        //global variable       
        DataTable tabClients, tabAgents;
        int currentIndex;
        string mode = " ";

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (currentIndex > 0)
            {
                currentIndex--;
                displayClient();
            }
        }

        private void frmClient_Load(object sender, EventArgs e)
        {
            tabClients = clsGlobal.mySet.Tables["Clients"];
            tabAgents = clsGlobal.mySet.Tables["Agents"];

            //when frmClient_Load form load currentIndex always be 0 for displaying info about first element in table(which is on 0th index)
            currentIndex = 0;

            //Create primarykey index for Id(client)
            DataColumn[] keys = new DataColumn[1];
            keys[0] = tabClients.Columns["Id"];
            keys[0].AutoIncrement = true;
            keys[0].AutoIncrementSeed = 1;
            tabClients.PrimaryKey = keys;

            //Create primarykey index for Id(agent)
            DataColumn[] keys1 = new DataColumn[1];
            keys1[0] = tabAgents.Columns["Id"];
            keys1[0].AutoIncrement = true;
            keys1[0].AutoIncrementSeed = 1;
            tabAgents.PrimaryKey = keys1;


            cboType.Items.Add("buyer");
            cboType.Items.Add("seller");


            // Fill the combobox with the agent id
            foreach (DataRow myrow in tabAgents.Rows)
            {
                cboAgentId.Items.Add(myrow["Id"].ToString());
            }

            //txtAgentId.Text = clsGlobal.Id;

            lblLoggedinMember.Text = "Id: " + clsGlobal.Id + "       Name: " + clsGlobal.Name;
            
            displayClient();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            currentIndex = 0;
            displayClient();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (clsGlobal.flag == "agent")
            {
                var foundAllClients = from client in tabClients.AsEnumerable()
                                      where client.Field<string>("AgentId") == clsGlobal.Id
                                      select client;
                if (currentIndex < (foundAllClients.Count() - 1))
                {
                    currentIndex++;
                    displayClient();
                }

            }
            else
            {
                if (currentIndex < (tabClients.Rows.Count - 1))
                {
                    currentIndex++;
                    displayClient();
                }
            }
            
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            if (clsGlobal.flag == "agent")
            {
                var foundAllClients = from client in tabClients.AsEnumerable()
                                      where client.Field<string>("AgentId") == clsGlobal.Id
                                      select client;
                
                currentIndex =foundAllClients.Count()- 1;
                displayClient();
            }
            else
            {
                currentIndex = tabClients.Rows.Count - 1;
                displayClient();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            mode = "add";
            txtId.Text = txtName.Text = txtPin.Text = txtPhone.Text = "";
           
            txtName.Focus();

            if(clsGlobal.flag == "agent")
            {
                cboAgentId.Text = clsGlobal.Id;
                cboAgentId.Enabled = false;
            }
            

            lblInfo.Text = "- - - - - - ADDING MODE - - - - -";
            ActivateButtons(false, false, false, true, true, false, false);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            mode = "edit";
            txtName.Focus();

            if (clsGlobal.flag == "agent")
            {
                cboAgentId.Text = clsGlobal.Id;
                cboAgentId.Enabled = false;
            }

            lblInfo.Text = "- - - - - - EDITING MODE - - - - -";
            ActivateButtons(false, false, false, true, true, false, false);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to delete this client ?", "Deletion Warning",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                // delete the current datarow (at the currentindex)
                tabClients.Rows[currentIndex].Delete();

                // Save (or Synchronize Dataset.Datatable -> Database.Table ) the contents of dataset to database
                SqlCommandBuilder myBuilder = new SqlCommandBuilder(clsGlobal.adpClients);
                clsGlobal.adpClients.Update(clsGlobal.mySet, "Clients");

                //reload the datatable (or Synchronize Database.Table -> Dataset.Datatable ) the contents of database to dataset
                // first: delete the old datatable Clients
                clsGlobal.mySet.Tables.Remove("Clients");

                // second: reload the table Clients from database
                clsGlobal.adpClients.Fill(clsGlobal.mySet, "Clients");

                tabClients = clsGlobal.mySet.Tables["Clients"];

                // move to the first record
                currentIndex = 0;
                displayClient();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (mode == "add")
            {
                //create new row
                DataRow newRow = tabClients.NewRow();
                // Fill the columns of the record with the contents of the textboxes
                //newRow["Id"] = 9090;
                newRow["Name"] = txtName.Text;
                newRow["Pin"] = txtPin.Text;
                newRow["Type"] = cboType.SelectedItem.ToString();
                newRow["Phone_no"] = txtPhone.Text;
                newRow["AgentId"] = cboAgentId.Text;                           

                // Add the new datarow in the collection tabAgents.Rows
                tabClients.Rows.Add(newRow);

                // Save (or Synchronize Dataset.Datatable -> Database.Table ) the contents of dataset to database
                SqlCommandBuilder myBuilder = new SqlCommandBuilder(clsGlobal.adpClients);
                clsGlobal.adpClients.Update(clsGlobal.mySet, "Clients");

                //reload the datatable (or Synchronize Database.Table -> Dataset.Datatable ) the contents of database to dataset
                // first: delete the old datatable Clients
                clsGlobal.mySet.Tables.Remove("Clients");

                // second: reload the table Clients from database
                clsGlobal.adpClients.Fill(clsGlobal.mySet, "Clients");

                MessageBox.Show("One new client has added sucessfully");

                tabClients = clsGlobal.mySet.Tables["Clients"];

                int i = tabClients.Rows.Count - 1;
                clsGlobal.newClientId = tabClients.Rows[i]["Id"].ToString();
                if (tabClients.Rows[i]["Type"].ToString() == "seller")
                {
                    frmHouse house = new frmHouse();
                    house.Show();

                    //ActivateButtons(true, false, false, false, false, false, false);
                    //btnFirst.Enabled = btnNext.Enabled = btnPrevious.Enabled = btnLast.Enabled = false;

                }


            }
            else if (mode == "edit")
            {
                // positon the currentRow at the currentIndex in the tabClients.Rows
                DataRow currentRow = tabClients.Rows[currentIndex];

                // overwrite the columns of the record with the contents of the textboxes
                currentRow["Name"] = txtName.Text;
                currentRow["Pin"] = txtPin.Text;
                currentRow["Type"] = cboType.SelectedItem.ToString();
                currentRow["Phone_no"] = txtPhone.Text;
                currentRow["AgentId"] = cboAgentId.Text;
              
                // Save (or Synchronize Dataset.Datatable -> Database.Table ) the contents of dataset to database
                SqlCommandBuilder myBuilder = new SqlCommandBuilder(clsGlobal.adpClients);
                clsGlobal.adpClients.Update(clsGlobal.mySet, "Clients");

                //reload the datatable (or Synchronize Database.Table -> Dataset.Datatable ) the contents of database to dataset
                // first: delete the old datatable Clients
                clsGlobal.mySet.Tables.Remove("Clients");

                // second: reload the table Agents from database
                clsGlobal.adpClients.Fill(clsGlobal.mySet, "Clients");

                MessageBox.Show("Information of a client has updated sucessfully");

                tabClients = clsGlobal.mySet.Tables["Clients"];

            }

            displayClient();
            mode = "";
            ActivateButtons(true, true, true, false, false, true, true);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            displayClient();
            ActivateButtons(true, true, true, false, false, true, true);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ActivateButtons(bool Add, bool Edit, bool Del, bool Save, bool Cancel, bool Navigs, bool Close)
        {
            btnAdd.Enabled = Add;
            btnEdit.Enabled = Edit;
            btnDelete.Enabled = Del;
            btnSave.Enabled = Save;
            btnCancel.Enabled = Cancel;
            btnFirst.Enabled = btnNext.Enabled = btnPrevious.Enabled = btnLast.Enabled = Navigs;
            btnClose.Enabled = Close;
        }

        private void displayClient()
        {
            if (clsGlobal.flag == "agent")
            {
                var foundAllClients = from client in tabClients.AsEnumerable()
                                      where client.Field<string>("AgentId") == clsGlobal.Id
                                      select client;

                if (foundAllClients.Count() > 0)
                {
                    txtId.Text = foundAllClients.ElementAt(currentIndex)["Id"].ToString();
                    txtName.Text = foundAllClients.ElementAt(currentIndex)["Name"].ToString();
                    txtPin.Text = foundAllClients.ElementAt(currentIndex)["Pin"].ToString();
                    txtPhone.Text = foundAllClients.ElementAt(currentIndex)["Phone_no"].ToString();
                    cboType.Text = foundAllClients.ElementAt(currentIndex)["Type"].ToString();
                    cboAgentId.Text = foundAllClients.ElementAt(currentIndex)["AgentId"].ToString();

                    cboAgentId.Enabled = false;

                    // Display the label info about the current record on the total
                    lblInfo.Text = "Client " + (currentIndex + 1) + " on a total of " + foundAllClients.Count();

                }
            }
            else
            {
                txtId.Text = tabClients.Rows[currentIndex]["Id"].ToString();
                txtName.Text = tabClients.Rows[currentIndex]["Name"].ToString();
                txtPin.Text = tabClients.Rows[currentIndex]["Pin"].ToString();
                txtPhone.Text = tabClients.Rows[currentIndex]["Phone_no"].ToString();
                cboType.Text = tabClients.Rows[currentIndex]["Type"].ToString();
                //cboAgentId.Text = tabClients.Rows[currentIndex]["AgentId"].ToString();
                string agentId = tabClients.Rows[currentIndex]["AgentId"].ToString();

                

                DataRow myRow = tabAgents.Rows.Find(Convert.ToInt32(agentId));
                
                if (myRow != null)
                {
                    cboAgentId.Text = myRow["Id"].ToString();
                }
                else
                {
                    cboAgentId.Text = "N/A";
                }
                

                // Display the label info about the current record on the total
                lblInfo.Text = "Client " + (currentIndex + 1) + " on a total of " + tabClients.Rows.Count;

            }
        }
    }
}
