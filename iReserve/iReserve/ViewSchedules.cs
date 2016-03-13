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
    public partial class ViewSchedules : Form
    {
        public ViewSchedules()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

        private void ViewSchedules_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iReserveDBDataSet.floorsXroomsXSchedules' table. You can move, or remove it, as needed.
            this.floorsXroomsXSchedulesTableAdapter.FillBySearch(this.iReserveDBDataSet.floorsXroomsXSchedules,"","","","");
            
            

        }

        

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.floorsXroomsXSchedulesTableAdapter.FillBySearch(this.iReserveDBDataSet.floorsXroomsXSchedules, this.txtSearch.Text, this.txtSearch.Text, this.txtSearch.Text, this.txtSearch.Text);
        }

        private void floorsXroomsXSchedulesDataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            this.floorsXroomsXSchedulesDataGridView.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.floorsXroomsXSchedulesDataGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.floorsXroomsXSchedulesDataGridView.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            //if enter key is pressed
            if (e.KeyCode == Keys.Enter)
            {
                btnSearch_Click(sender, e);
            }
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            txtSearch.ForeColor = Color.Black;
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            txtSearch.ForeColor = Color.Gray;
            txtSearch.Text = "Search for Floor name, Room name, Subject, or Weekday";
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text.Equals(""))
            {
                btnSearch.Enabled = false;
                this.floorsXroomsXSchedulesTableAdapter.FillBySearch(this.iReserveDBDataSet.floorsXroomsXSchedules, "", "", "", "");
               

            }
            else
            {
                //this.floorsXroomsXSchedulesTableAdapter.FillBySearch(this.iReserveDBDataSet.floorsXroomsXSchedules, txtSearch.Text, txtSearch.Text, txtSearch.Text, txtSearch.Text);
                btnSearch.Enabled = true;
            }
        }
    }
}
