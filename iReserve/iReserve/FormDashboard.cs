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
        int adminID = 0;
        public frmDashboard(int id)
        {
            InitializeComponent();
            this.adminID = id;
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
            this.floorsXroomsXReservationsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.iReserveDBDataSet);

        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iReserveDBDataSet.floorsXroomsXReservations' table. You can move, or remove it, as needed.
            this.floorsXroomsXReservationsTableAdapter.FillByToday(this.iReserveDBDataSet.floorsXroomsXReservations, DateTime.Now.ToString("dddd, MMMM dd, yyyy"));
            
            Timer tmr = new Timer();
            tmr.Interval = 1000;//ticks every 1 second
            tmr.Tick += new EventHandler(tmr_Tick);
            tmr.Start(); 

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
            new ReserveRoom(adminID).ShowDialog();
            // TODO: This line of code loads data into the 'iReserveDBDataSet.reservations' table. You can move, or remove it, as needed.
            //this.reservationsTableAdapter.Fill(this.iReserveDBDataSet.reservations);
            this.floorsXroomsXReservationsTableAdapter.FillByToday(this.iReserveDBDataSet.floorsXroomsXReservations, lblDate.Text);
        }

        private void btnViewSchedules_Click(object sender, EventArgs e)
        {

        }

        private void tmr_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToString("dddd, MMMM dd, yyyy");
            lblTime.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void btnViewReservation_Click(object sender, EventArgs e)
        {
            new ViewReservations().ShowDialog();
            this.floorsXroomsXReservationsTableAdapter.FillByToday(this.iReserveDBDataSet.floorsXroomsXReservations, lblDate.Text);
        }
    }
}
