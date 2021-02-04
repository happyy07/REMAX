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
    public partial class searchHouse : Form
    {
        public searchHouse()
        {
            InitializeComponent();
        }

        DataTable tabHouses;

        private void btnSearchHouse_Click(object sender, EventArgs e)
        {
            if (cboSearch.SelectedItem.ToString() == "houseId")
            {
                int id = Convert.ToInt32(txtValue.Text);

                var foundHouse = from house in tabHouses.AsEnumerable()
                                 where house.Field<int>("id") == id
                                 select house;


                if (foundHouse.Count() > 0)
                {
                    gridHouses.DataSource = foundHouse.CopyToDataTable();
                    lblSearchMessage.Text = "HOUSE OF HOUSE ID: " + id;
                }
                else
                {
                    MessageBox.Show("House Id Not Found, Try again.", "TD: Identification Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else if (cboSearch.SelectedItem.ToString() == "clientId")
            {
                string id = txtValue.Text.ToString();

                var foundAllHouses = from house in tabHouses.AsEnumerable()
                                     where house.Field<string>("ClientId") == id
                                     select house;


                if (foundAllHouses.Count() > 0)
                {
                    gridHouses.DataSource = foundAllHouses.CopyToDataTable();
                    lblSearchMessage.Text = "ALL HOUSES OF CLIENT ID: " + id;
                }
                else
                {
                    MessageBox.Show("Client Id Not Found, Try again.", "TD: Identification Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else if (cboSearch.SelectedItem.ToString() == "City")
            {
                string city = txtValue.Text.ToString();

                var foundAllHouses = from house in tabHouses.AsEnumerable()
                                     where house.Field<string>("City") == city
                                     select house;


                if (foundAllHouses.Count() > 0)
                {
                    gridHouses.DataSource = foundAllHouses.CopyToDataTable();
                    lblSearchMessage.Text = "ALL HOUSES OF CITY " + city;
                }
                else
                {
                    MessageBox.Show("City not found, Try again.", "TD: Identification Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else if (cboSearch.SelectedItem.ToString() == "Province")
            {
                string province = txtValue.Text.ToString();

                var foundAllHouses = from house in tabHouses.AsEnumerable()
                                     where house.Field<string>("Province") == province
                                     select house;


                if (foundAllHouses.Count() > 0)
                {
                    gridHouses.DataSource = foundAllHouses.CopyToDataTable();
                    lblSearchMessage.Text = "ALL HOUSES OF PROVINCE " + province;
                }
                else
                {
                    MessageBox.Show("City not found, Try again.", "TD: Identification Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {
                decimal price = Convert.ToDecimal(txtValue.Text);

                var foundAllHouses = from house in tabHouses.AsEnumerable()
                                     where house.Field<decimal>("Price") <= price
                                     select house;


                if (foundAllHouses.Count() > 0)
                {
                    gridHouses.DataSource = foundAllHouses.CopyToDataTable();
                    lblSearchMessage.Text = "ALL HOUSES WHOSE PRICE IS MAXIMUM " + price;
                }
                else
                {
                    MessageBox.Show("City not found, Try again.", "TD: Identification Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }


        }

        private void searchHouse_Load(object sender, EventArgs e)
        {
            tabHouses = clsGlobal.mySet.Tables["Houses"];

            gridHouses.DataSource = tabHouses;

            lblSearchMessage.Text = "ALL HOUSES";
        }
    }
}
