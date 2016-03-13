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
    public partial class ViewReservations : Form
    {
        public ViewReservations()
        {
            InitializeComponent();
            modifyFormDesign();
          
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

            }
            foreach (Label lbl in this.Controls.OfType<Label>())
            {//this will controll all button inside form
                lbl.BackColor = Color.Transparent;

            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ViewReservations_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iReserveDBDataSet.floorsXroomsXReservations' table. You can move, or remove it, as needed.
            this.floorsXroomsXReservationsTableAdapter.Fill(this.iReserveDBDataSet.floorsXroomsXReservations);

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.floorsXroomsXReservationsTableAdapter.FillBySearch(this.iReserveDBDataSet.floorsXroomsXReservations, this.txtSearch.Text, this.txtSearch.Text, this.txtSearch.Text, this.txtSearch.Text, this.txtSearch.Text);
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            //if enter key is pressed
            if (e.KeyCode == Keys.Enter)
            {
                btnSearch_Click(sender, e);
            }
        }

        private void txtSearch_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void txtSearch_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if (this.txtSearch.Text.Equals(""))
            {
                this.txtSearch.ForeColor = Color.Gray;
                this.txtSearch.Text = "Search for Floor, Room, Reservee, Date, Purpose";
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.iReserveDBDataSet.AcceptChanges();

            foreach (DataGridViewRow row in floorsXroomsXReservationsDataGridView.SelectedRows)
            {
                String value1 = row.Cells[0].Value.ToString();
                String value2 = row.Cells[1].Value.ToString();
                String value3 = row.Cells[2].Value.ToString();
                String value4 = row.Cells[3].Value.ToString();
                String value5 = row.Cells[4].Value.ToString();
                String value6 = row.Cells[5].Value.ToString();
                String value7 = row.Cells[6].Value.ToString();
                String value8 = row.Cells[7].Value.ToString();
                if (MessageBox.Show("Are you sure you want to cancel this reservation?", "Cancel", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    this.reservationsTableAdapter1.DeleteReservation(Convert.ToInt32(value8));
                }
            }
            //refill the table
            this.floorsXroomsXReservationsTableAdapter.FillBySearch(this.iReserveDBDataSet.floorsXroomsXReservations, this.txtSearch.Text, this.txtSearch.Text, this.txtSearch.Text, this.txtSearch.Text, this.txtSearch.Text);

            
            
        }

        private void floorsXroomsXReservationsDataGridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                btnDelete_Click(sender, e);
            }
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            this.txtSearch.Text = "";
            txtSearch.ForeColor = Color.Black;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
             if (this.txtSearch.Text.Equals(""))
            {
                this.floorsXroomsXReservationsTableAdapter.FillBySearch(this.iReserveDBDataSet.floorsXroomsXReservations, this.txtSearch.Text, this.txtSearch.Text, this.txtSearch.Text, this.txtSearch.Text, this.txtSearch.Text);
            }
        }

        private void floorsXroomsXReservationsDataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            this.floorsXroomsXReservationsDataGridView.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.floorsXroomsXReservationsDataGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.floorsXroomsXReservationsDataGridView.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
    }
}
