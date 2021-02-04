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
    public partial class frmAgent : Form
    {
        public frmAgent()
        {
            InitializeComponent();
            //lblLoggedinMember.Text = frmAdminLogin.adm
        }

        //global variable       
        DataTable tabAgents;
        int currentIndex;
        string mode = " ";

        private void lstNumbers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmAgent_Load(object sender, EventArgs e)
        {
            tabAgents = clsGlobal.mySet.Tables["Agents"];

            //when frmAgent_Load form load currentIndex always be 0 for displaying info about first element in table(which is on 0th index)
            currentIndex = 0;

            lblLoggedinMember.Text = "Id: " + clsGlobal.Id + "       Name: " + clsGlobal.Name;

            displayAgent();
        }

        private void CreateDataset()
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

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

        private void displayAgent()
        {
            txtId.Text = tabAgents.Rows[currentIndex]["Id"].ToString();
            txtName.Text = tabAgents.Rows[currentIndex]["Name"].ToString();
            txtPin.Text = tabAgents.Rows[currentIndex]["Pin"].ToString();
            txtPhone.Text = tabAgents.Rows[currentIndex]["Phone_no"].ToString();

            // Display the label info about the current record on the total
            lblInfo.Text = "Agent " + (currentIndex + 1) + " on a total of " + tabAgents.Rows.Count;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            mode = "add";
            txtId.Text = txtName.Text = txtPin.Text = txtPhone.Text = "";
            txtName.Focus();

            lblInfo.Text = "- - - - - - ADDING MODE - - - - -";
            ActivateButtons(false, false, false, true, true, false, false);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            mode = "edit";
            txtName.Focus();

            lblInfo.Text = "- - - - - - EDITING MODE - - - - -";
            ActivateButtons(false, false, false, true, true, false, false);
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            currentIndex = 0;
            displayAgent();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (currentIndex > 0)
            {
                currentIndex--;
                displayAgent();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currentIndex < (tabAgents.Rows.Count - 1))
            {
                currentIndex++;
                displayAgent();
            }

        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            currentIndex = tabAgents.Rows.Count - 1;
            displayAgent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(mode == "add")
            {
                //create new row
                DataRow newRow = tabAgents.NewRow();
                // Fill the columns of the record with the contents of the textboxes
                newRow["Name"] = txtName.Text;
                newRow["Pin"] = txtPin.Text;
                newRow["Phone_no"] = txtPhone.Text;

                // Add the new datarow in the collection tabAgents.Rows
                tabAgents.Rows.Add(newRow);

                // Save (or Synchronize Dataset.Datatable -> Database.Table ) the contents of dataset to database
                SqlCommandBuilder myBuilder = new SqlCommandBuilder(clsGlobal.adpAgents);
                clsGlobal.adpAgents.Update(clsGlobal.mySet, "Agents");

                //reload the datatable (or Synchronize Database.Table -> Dataset.Datatable ) the contents of database to dataset
                // first: delete the old datatable Agents
                clsGlobal.mySet.Tables.Remove("Agents");

                // second: reload the table Agents from database
                clsGlobal.adpAgents.Fill(clsGlobal.mySet, "Agents");

                MessageBox.Show("One new agent has added sucessfully");

                tabAgents = clsGlobal.mySet.Tables["Agents"];


            }
            else if(mode == "edit")
            {
                // positon the currentRow at the currentIndex in the tabAgents.Rows
                DataRow currentRow = tabAgents.Rows[currentIndex];

                // overwrite the columns of the record with the contents of the textboxes
                currentRow["Name"] = txtName.Text;
                currentRow["Pin"] = txtPin.Text;
                currentRow["Phone_no"] = txtPhone.Text;
               
                // Save (or Synchronize Dataset.Datatable -> Database.Table ) the contents of dataset to database
                SqlCommandBuilder myBuilder = new SqlCommandBuilder(clsGlobal.adpAgents);
                clsGlobal.adpAgents.Update(clsGlobal.mySet, "Agents");

                //reload the datatable (or Synchronize Database.Table -> Dataset.Datatable ) the contents of database to dataset
                // first: delete the old datatable Agents
                clsGlobal.mySet.Tables.Remove("Agents");

                // second: reload the table Agents from database
                clsGlobal.adpAgents.Fill(clsGlobal.mySet, "Agents");

                MessageBox.Show("Information of an agent has updated sucessfully");

                tabAgents = clsGlobal.mySet.Tables["Agents"];

            }

            displayAgent();
            mode = "";
            ActivateButtons(true, true, true, false, false, true, true);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to delete this agent ?", "Deletion Warning",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                // delete the current datarow (at the currentindex)
                tabAgents.Rows[currentIndex].Delete();

                // Save (or Synchronize Dataset.Datatable -> Database.Table ) the contents of dataset to database
                SqlCommandBuilder myBuilder = new SqlCommandBuilder(clsGlobal.adpAgents);
                clsGlobal.adpAgents.Update(clsGlobal.mySet, "Agents");

                //reload the datatable (or Synchronize Database.Table -> Dataset.Datatable ) the contents of database to dataset
                // first: delete the old datatable Agents
                clsGlobal.mySet.Tables.Remove("Agents");

                // second: reload the table Agents from database
                clsGlobal.adpAgents.Fill(clsGlobal.mySet, "Agents");               

                tabAgents = clsGlobal.mySet.Tables["Agents"];

                // move to the first record
                currentIndex = 0;
                displayAgent();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            displayAgent();
            ActivateButtons(true, true, true, false, false, true, true);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
