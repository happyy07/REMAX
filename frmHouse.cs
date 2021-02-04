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
    public partial class frmHouse : Form
    {
        public frmHouse()
        {
            InitializeComponent();
        }

        //global variable       
        DataTable tabHouses, tabClients;
        int currentIndex;
        string mode = " ";

        private void frmHouse_Load(object sender, EventArgs e)
        {
            tabHouses = clsGlobal.mySet.Tables["Houses"];
            tabClients = clsGlobal.mySet.Tables["Clients"];

            //Create primarykey index for Id(client)
            DataColumn[] keys = new DataColumn[1];
            keys[0] = tabClients.Columns["Id"];
            keys[0].AutoIncrement = true;
            tabClients.PrimaryKey = keys;

            //Create primarykey index for Id(house)
            DataColumn[] keys1 = new DataColumn[1];
            keys1[0] = tabHouses.Columns["Id"];
            keys1[0].AutoIncrement = true;
            tabHouses.PrimaryKey = keys1;


            // Fill the combobox with the client id
            foreach (DataRow myrow in tabClients.Rows)
            {
                cboClientId.Items.Add(myrow["Id"].ToString());
            }

            //when frmHouse_Load form load currentIndex always be 0 for displaying info about first element in table(which is on 0th index)
            currentIndex = 0;

            lblLoggedinMember.Text = "Id: " + clsGlobal.Id + "       Name: " + clsGlobal.Name;

            displayHouse();

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

        private void displayHouse()
        {
            txtId.Text = tabHouses.Rows[currentIndex]["Id"].ToString();
            txtLocation.Text = tabHouses.Rows[currentIndex]["Location"].ToString();
            txtCity.Text = tabHouses.Rows[currentIndex]["City"].ToString();
            txtProvince.Text = tabHouses.Rows[currentIndex]["Province"].ToString();
            txtPrice.Text = tabHouses.Rows[currentIndex]["Price"].ToString();
            //cboClientId.Text = tabHouses.Rows[currentIndex]["ClientId"].ToString();

            string clientId = tabHouses.Rows[currentIndex]["ClientId"].ToString();

           
            DataRow myRow = tabClients.Rows.Find(clientId);

            if (myRow != null)
            {
                cboClientId.Text = myRow["Id"].ToString();
            }
            else
            {
                cboClientId.Text = "N/A";
            }

            // Display the label info about the current record on the total
            lblInfo.Text = "House " + (currentIndex + 1) + " on a total of " + tabHouses.Rows.Count;


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            currentIndex = 0;
            displayHouse();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (currentIndex > 0)
            {
                currentIndex--;
                displayHouse();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currentIndex < (tabHouses.Rows.Count - 1))
            {
                currentIndex++;
                displayHouse();
            }
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            currentIndex = tabHouses.Rows.Count - 1;
            displayHouse();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            mode = "add";
            txtId.Text = txtLocation.Text = txtCity.Text = txtProvince.Text = txtPrice.Text = " ";
            txtLocation.Focus();

            if (clsGlobal.flag == "agent")
            {
                if(clsGlobal.newClientId != " ")
                {
                    cboClientId.Text = clsGlobal.newClientId;
                }
                cboClientId.Enabled = false;

            }

            
            lblInfo.Text = "- - - - - - ADDING MODE - - - - -";
            ActivateButtons(false, false, false, true, true, false, false);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            mode = "edit";
            txtCity.Focus();

            if (clsGlobal.flag == "agent")
            {

                if (clsGlobal.newClientId != " ")
                {
                    cboClientId.Text = clsGlobal.newClientId;
                }

            }
           
                cboClientId.Enabled = false;
            

            
            lblInfo.Text = "- - - - - - EDITING MODE - - - - -";
            ActivateButtons(false, false, false, true, true, false, false);

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to delete this house ?", "Deletion Warning",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                // delete the current datarow (at the currentindex)
                tabHouses.Rows[currentIndex].Delete();

                // Save (or Synchronize Dataset.Datatable -> Database.Table ) the contents of dataset to database
                SqlCommandBuilder myBuilder = new SqlCommandBuilder(clsGlobal.adpHouses);
                clsGlobal.adpHouses.Update(clsGlobal.mySet, "Houses");

                //reload the datatable (or Synchronize Database.Table -> Dataset.Datatable ) the contents of database to dataset
                // first: delete the old datatable Houses
                clsGlobal.mySet.Tables.Remove("Houses");

                // second: reload the table Houses from database
                clsGlobal.adpHouses.Fill(clsGlobal.mySet, "Houses");

                tabHouses = clsGlobal.mySet.Tables["Houses"];

                // move to the first record
                currentIndex = 0;
                displayHouse();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (mode == "add")
            {
                //create new row
                DataRow newRow = tabHouses.NewRow();
                // Fill the columns of the record with the contents of the textboxes
                newRow["Location"] = txtLocation.Text;
                newRow["City"] = txtCity.Text;
                newRow["Province"] = txtProvince.Text;
                newRow["Price"] = txtPrice.Text;
                newRow["ClientId"] = cboClientId.Text;

                
                tabHouses.Rows.Add(newRow);

                // Save (or Synchronize Dataset.Datatable -> Database.Table ) the contents of dataset to database
                SqlCommandBuilder myBuilder = new SqlCommandBuilder(clsGlobal.adpHouses);
                clsGlobal.adpHouses.Update(clsGlobal.mySet, "Houses");

                //reload the datatable (or Synchronize Database.Table -> Dataset.Datatable ) the contents of database to dataset
                // first: delete the old datatable Agents
                clsGlobal.mySet.Tables.Remove("Houses");

                // second: reload the table Agents from database
                clsGlobal.adpHouses.Fill(clsGlobal.mySet, "Houses");

                MessageBox.Show("One new house has added sucessfully");

                tabHouses = clsGlobal.mySet.Tables["Houses"];

                           
                
            }
            else if (mode == "edit")
            {
                // positon the currentRow at the currentIndex in the tabHouses.Rows
                DataRow currentRow = tabHouses.Rows[currentIndex];

                // overwrite the columns of the record with the contents of the textboxes
                currentRow["Location"] = txtLocation.Text;
                currentRow["City"] = txtCity.Text;
                currentRow["Province"] = txtProvince.Text;
                currentRow["Price"] = txtPrice.Text;
                currentRow["ClientId"] = cboClientId.Text;

                // Save (or Synchronize Dataset.Datatable -> Database.Table ) the contents of dataset to database
                SqlCommandBuilder myBuilder = new SqlCommandBuilder(clsGlobal.adpHouses);
                clsGlobal.adpHouses.Update(clsGlobal.mySet, "Houses");

                //reload the datatable (or Synchronize Database.Table -> Dataset.Datatable ) the contents of database to dataset
                // first: delete the old datatable Agents
                clsGlobal.mySet.Tables.Remove("Houses");

                // second: reload the table Agents from database
                clsGlobal.adpHouses.Fill(clsGlobal.mySet, "Houses");

                MessageBox.Show("Information of a house has updated sucessfully");

                tabHouses = clsGlobal.mySet.Tables["Houses"];
                
            }
            mode = "";
            displayHouse();
            ActivateButtons(true, true, true, false, false, true, true);

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            displayHouse();
            ActivateButtons(true, true, true, false, false, true, true);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

   
}
