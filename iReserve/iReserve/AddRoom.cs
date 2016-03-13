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
    public partial class AddRoom : Form
    {
        public AddRoom()
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((int)roomsTableAdapter.CheckAvailability(txtRoomName.Text) == 0)
            {
                //valid

                lblAvailability.ForeColor = Color.ForestGreen;
                lblAvailability.Text = "Room name is available!";
                lblAvailability.Visible = true;

                btnDone.Enabled = true;
                


            }
            else
            {
                //invalid

                lblAvailability.ForeColor = Color.Red;
                lblAvailability.Text = "Room name already exists!";
                lblAvailability.Visible = true;
                
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

        private void AddRoom_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iReserveDBDataSet.rooms' table. You can move, or remove it, as needed.
            this.roomsTableAdapter.Fill(this.iReserveDBDataSet.rooms);
            // TODO: This line of code loads data into the 'iReserveDBDataSet.floors' table. You can move, or remove it, as needed.
            this.floorsTableAdapter.Fill(this.iReserveDBDataSet.floors);

        }

        private void txtRoomName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(sender, e);
            }
        }

        private void txtRoomName_TextChanged(object sender, EventArgs e)
        {
            lblAvailability.Visible = false;
            btnDone.Enabled = false;
        }

        private void rtbDescription_Enter(object sender, EventArgs e)
        {
            this.rtbDescription.Text = "";
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            String roomName = this.txtRoomName.Text;
            String description = this.rtbDescription.Text;
            int floorID = (int)this.floorsTableAdapter.GetID(this.cBoxFloors.Text);
            this.roomsTableAdapter.AddRoom(roomName, description, floorID);
            MessageBox.Show("Added: " + roomName);
            this.Close();
        }
    }
}
