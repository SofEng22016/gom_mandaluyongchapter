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
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to quit?", "Exit", MessageBoxButtons.OKCancel) == DialogResult.OK)
                Application.Exit();
                //this.Close();
                
        }

        private void btnAddFloor_Click(object sender, EventArgs e)
        {
            new AddFloor().ShowDialog();
        }

        private void btnRemoveRoom_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Please Delete Records one at a time.");
            new RemoveRoom().ShowDialog();
            
        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            new AddRoom().ShowDialog();
        }

        private void reservationsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.reservationsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.iReserveDBDataSet);

        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iReserveDBDataSet.reservations' table. You can move, or remove it, as needed.
            this.reservationsTableAdapter.Fill(this.iReserveDBDataSet.reservations);

        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRemoveFloor_Click(object sender, EventArgs e)
        {
            new RemoveFloor().ShowDialog();
        }

        private void btnMakeReservation_Click(object sender, EventArgs e)
        {
            new ReserveRoom().ShowDialog();
            // TODO: This line of code loads data into the 'iReserveDBDataSet.reservations' table. You can move, or remove it, as needed.
            this.reservationsTableAdapter.Fill(this.iReserveDBDataSet.reservations);
        }

        
    }
}
