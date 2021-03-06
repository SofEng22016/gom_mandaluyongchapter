﻿using System;
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
            modifyFormDesign();
            this.btnSearch.Visible = false;
        }
        private void modifyFormDesign()
        {
            this.BackgroundImage = Properties.Resources.formBackground;
            this.BackgroundImageLayout = ImageLayout.Stretch;

            foreach (Button btn in this.Controls.OfType<Button>())
            {//this will controll all button inside form
                btn.FlatStyle = FlatStyle.Standard;
                btn.ForeColor = Color.Black;
                btn.BackColor = Color.White;
                btn.Cursor = Cursors.Hand;

            }
            foreach (Label lbl in this.Controls.OfType<Label>())
            {//this will controll all label inside form
                lbl.BackColor = Color.Transparent;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

        private void ViewSchedules_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iReserveDBDataSet.schedules' table. You can move, or remove it, as needed.
            this.schedulesTableAdapter.Fill(this.iReserveDBDataSet.schedules);
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
            //if escape key is pressed
            else if (e.KeyCode == Keys.Escape)
            {
                this.Close();
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
            else if(txtSearch.Text.Equals("Search for Floor name, Room name, Subject, or Weekday")){
            
            }
            else
            {
                this.floorsXroomsXSchedulesTableAdapter.FillBySearch(this.iReserveDBDataSet.floorsXroomsXSchedules, txtSearch.Text, txtSearch.Text, txtSearch.Text, txtSearch.Text);
                btnSearch.Enabled = true;
            }
        }

        private void ViewSchedules_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void floorsXroomsXSchedulesDataGridView_KeyDown(object sender, KeyEventArgs e)
        {
            //if escape key is pressed
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.iReserveDBDataSet.AcceptChanges();

            foreach (DataGridViewRow row in floorsXroomsXSchedulesDataGridView.SelectedRows)
            {
                String value1 = row.Cells[0].Value.ToString();
                
                if (MessageBox.Show("Are you sure you want to delete this schedule", "Cancel", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    this.schedulesTableAdapter.DeleteSchedule(Convert.ToInt32(value1));
                }
            }
            //refill the table
            this.floorsXroomsXSchedulesTableAdapter.FillBySearch(this.iReserveDBDataSet.floorsXroomsXSchedules, "", "", "", "");

        }
    }
}
