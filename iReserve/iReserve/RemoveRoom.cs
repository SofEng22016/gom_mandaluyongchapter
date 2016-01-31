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
                this.Validate();
                this.roomsBindingSource.EndEdit();
                this.iReserveDBDataSet.AcceptChanges();
                //this.roomsTableAdapter.Update(this.iReserveDBDataSet.rooms);
                MessageBox.Show("Update successful");
                this.Close();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
                MessageBox.Show("Update failed");
                this.Close();
            }
        }

        

        
    }
}
