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
    public partial class frmListHouse : Form
    {
        public frmListHouse()
        {
            InitializeComponent();
        }

        DataTable tabHouses;
        private void frmListHouse_Load(object sender, EventArgs e)
        {
            tabHouses = clsGlobal.mySet.Tables["Houses"];

            gridHouses.DataSource = tabHouses;
        }

        private void btnSearchHouse_Click(object sender, EventArgs e)
        {
            searchHouse house = new searchHouse();
            house.Show();
        }
    }
}
