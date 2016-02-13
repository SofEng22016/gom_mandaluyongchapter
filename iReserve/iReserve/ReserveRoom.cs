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
    public partial class ReserveRoom : Form
    {
        String strDate = "";
        String startTime = "";
        String endTime = "";

        TimeSpan spanStart;
        TimeSpan spanEnd;

        public String convertToMilitary(String input){
            //String array[];
            return "";
        }

        public ReserveRoom()
        {
            InitializeComponent();
            this.startTimePicker.CustomFormat = "hh:mm tt";
            this.endTimePicker.CustomFormat = "hh:mm tt";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dateReserved_ValueChanged(object sender, EventArgs e)
        {
            this.strDate = this.dateReserved.Text;
            
        }

        private void startTimePicker_ValueChanged(object sender, EventArgs e)
        {
            this.startTime = this.startTimePicker.Text;
            
            //TimeSpan.TryParse(this.startTime+"-"+this.endTime, out spanStart);
            //MessageBox.Show(this.spanStart.ToString());
        }

        private void endTimePicker_ValueChanged(object sender, EventArgs e)
        {
            this.endTime = this.endTimePicker.Text;
            
            //TimeSpan.TryParse(this.startTime, out spanEnd);
            //MessageBox.Show(this.spanEnd.ToString());
        }

        private void floorsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.floorsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.iReserveDBDataSet);

        }

        private void ReserveRoom_Load(object sender, EventArgs e)
        {
            
            // TODO: This line of code loads data into the 'iReserveDBDataSet.schedules' table. You can move, or remove it, as needed.
            this.schedulesTableAdapter.Fill(this.iReserveDBDataSet.schedules);
            // TODO: This line of code loads data into the 'iReserveDBDataSet.reservations' table. You can move, or remove it, as needed.
            this.reservationsTableAdapter.Fill(this.iReserveDBDataSet.reservations);
            // TODO: This line of code loads data into the 'iReserveDBDataSet.floors' table. You can move, or remove it, as needed.
            this.floorsTableAdapter.Fill(this.iReserveDBDataSet.floors);

            // TODO: This line of code loads data into the 'iReserveDBDataSet.rooms' table. You can move, or remove it, as needed.
            this.roomsTableAdapter.FillByFloor(this.iReserveDBDataSet.rooms, (int)this.floorsTableAdapter.GetID(this.cBoxFloors.Text));

            
        }

        private void cBoxFloors_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int x = (int)this.floorsTableAdapter.GetID(this.cBoxFloors.Text);
                //MessageBox.Show("" + x);
                this.roomsTableAdapter.FillByFloor(this.iReserveDBDataSet.rooms, x);

            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void roomsDataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            this.roomsDataGridView.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.roomsDataGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.roomsDataGridView.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Simulate", "Simulate", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                //if there is no conflict within the schedule on the said room
                
                lblResult.Text = "The Schedule is Available!";
                lblResult.ForeColor = Color.Green;
                lblResult.Visible = true;
            }
            else
            {
                //if there is a same schedule at the same room
                
                lblResult.Text = "The Schedule is Unavailable";
                lblResult.ForeColor = Color.Red;
                lblResult.Visible = true;
            }
        }

        
    }
}
