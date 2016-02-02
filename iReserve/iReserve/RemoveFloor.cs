using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class RemoveFloor : Form
    {
        public RemoveFloor()
        {
            InitializeComponent();
        }

        private void floorsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.floorsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.iReserveDBDataSet);

        }

        private void RemoveFloor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iReserveDBDataSet.rooms' table. You can move, or remove it, as needed.
            this.roomsTableAdapter.Fill(this.iReserveDBDataSet.rooms);
            // TODO: This line of code loads data into the 'iReserveDBDataSet.floors' table. You can move, or remove it, as needed.
            this.floorsTableAdapter.Fill(this.iReserveDBDataSet.floors);

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
