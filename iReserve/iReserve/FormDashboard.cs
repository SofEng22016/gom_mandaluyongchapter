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

            this.BackgroundImage = Properties.Resources.formBackground;
            this.BackgroundImageLayout = ImageLayout.Stretch;

            foreach (Button btn in this.Controls.OfType<Button>())
            {//this will controll all button inside form
                btn.FlatStyle = FlatStyle.Standard;
                btn.ForeColor = Color.Black;
                btn.BackColor = Color.White;


            }
            foreach (Label lbl in this.Controls.OfType<Label>())
            {//this will controll all label inside form
                lbl.BackColor = Color.Transparent;

            }
            foreach (GroupBox groupBox in this.Controls.OfType<GroupBox>())
            {//this will controll all label inside form
                foreach (Button groupBtn in groupBox.Controls.OfType<Button>())
                {//this will controll all label inside form
                    groupBtn.FlatStyle = FlatStyle.Standard;
                    groupBtn.ForeColor = Color.Black;
                    groupBtn.BackColor = Color.White;

                }

            }
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
            new ViewSchedules().ShowDialog();
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

        private void lblDate_Click(object sender, EventArgs e)
        {

        }

        private void lblTime_Click(object sender, EventArgs e)
        {

        }

        private void floorsXroomsXReservationsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void floorsXroomsXReservationsDataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            this.floorsXroomsXReservationsDataGridView.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.floorsXroomsXReservationsDataGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.floorsXroomsXReservationsDataGridView.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
    }
}
