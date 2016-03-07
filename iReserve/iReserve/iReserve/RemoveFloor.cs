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

        private void cBoxFloors_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.btnRemove.Enabled = false;
            lblResult.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            //check success

            

            if ((int)roomsTableAdapter.isFloorEmpty((int)floorsTableAdapter.GetID(this.cBoxFloors.Text)) == 0)
            {
                btnRemove.Enabled = true;
                lblResult.ForeColor = Color.Green;
                lblResult.Visible = true;

                lblResult.Text = "This floor is empty and available for removal";
            }
            //floor has rooms
            else
            {
                lblResult.Visible = true;
                lblResult.ForeColor = Color.Red;
                lblResult.Text = "This floor still has rooms!";

            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            String toMessage = "";
            this.Validate();
            this.floorsBindingSource.EndEdit();
            this.iReserveDBDataSet.AcceptChanges();
            toMessage += this.cBoxFloors.Text;
            if (MessageBox.Show("Are you sure you want to delete\n" + toMessage, "Confirm Delete", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.floorsTableAdapter.DeleteFloor(this.cBoxFloors.Text);
                //TODO: add code to update the data inside the combo box.
            }
        }

    }
}
