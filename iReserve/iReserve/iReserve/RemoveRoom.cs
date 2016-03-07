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
    public partial class RemoveRoom : Form
    {
        public RemoveRoom()
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

        private void roomsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.roomsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.iReserveDBDataSet);

        }

        private void RemoveRoom_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iReserveDBDataSet.floors' table. You can move, or remove it, as needed.
            this.floorsTableAdapter.Fill(this.iReserveDBDataSet.floors);
            // TODO: This line of code loads data into the 'iReserveDBDataSet.rooms' table. You can move, or remove it, as needed.
            this.roomsTableAdapter.FillByFloor (this.iReserveDBDataSet.rooms, (int)this.floorsTableAdapter.GetID(this.comboBox1.Text));

        }

        /*private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.roomsTableAdapter.FillBy(this.iReserveDBDataSet.rooms, new System.Nullable<int>(((int)(System.Convert.ChangeType(floorToolStripTextBox.Text, typeof(int))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }*/

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int x = (int)this.floorsTableAdapter.GetID(this.comboBox1.Text);
                //MessageBox.Show("" + x);
                this.roomsTableAdapter.FillByFloor(this.iReserveDBDataSet.rooms, x);
               
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void roomsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void roomsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                String toMessage = "";
                this.Validate();
                this.roomsBindingSource.EndEdit();
                this.iReserveDBDataSet.AcceptChanges();
                //this.roomsTableAdapter.Update(this.iReserveDBDataSet.rooms);
                
                foreach (DataGridViewRow row in roomsDataGridView.SelectedRows)
                {
                    String value1 = row.Cells[0].Value.ToString();
                    String value2 = row.Cells[1].Value.ToString();
                    String value3 = row.Cells[2].Value.ToString();
                    toMessage += "Room: " + value2 + " " + value3 + "\n";  
                    if(MessageBox.Show("Are you sure you want to delete\n"+toMessage, "Confirm Delete", MessageBoxButtons.OKCancel) == DialogResult.OK){
                    roomsTableAdapter.DeleteRoom(Convert.ToInt32(value1));
                    //MessageBox.Show(value1);
                    //code to refill the table
                    this.roomsTableAdapter.FillByFloor(this.iReserveDBDataSet.rooms, (int)this.floorsTableAdapter.GetID(this.comboBox1.Text));
                    }
                     
                }
                
                //MessageBox.Show("Update successful");
                //this.Close();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
                MessageBox.Show("Update failed");
                //this.Close();
            }
        }

        private void roomsDataGridView_KeyDown(object sender, KeyEventArgs e)
        {
            //if delete is pressed for ease of use
            if (e.KeyCode == Keys.Delete)
            {
                button1_Click(sender, e);
            }
        }

        private void roomsDataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            this.roomsDataGridView.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.roomsDataGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.roomsDataGridView.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

        }

        

        
    }
}
