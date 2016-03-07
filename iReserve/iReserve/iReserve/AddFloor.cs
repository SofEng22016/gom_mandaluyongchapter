using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class AddFloor : Form
    {
        public AddFloor()
        {
            InitializeComponent();
            this.btnDone.Enabled = false;
            this.lblMessage.Visible = false;
            this.lblGreen.Visible = false;
            this.lblRed.Visible = false;

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

        private void button1_Click(object sender, EventArgs e)
        {
            int valid;
            valid = (int)this.floorsTableAdapter1.CheckAvailability(this.txtFloorName.Text);
            if (valid == 0)
            {
                this.btnDone.Enabled = true;
                this.lblMessage.Text = "Floor name available please click finish.";
                this.lblMessage.Visible = true;
                this.lblMessage.ForeColor = this.lblGreen.ForeColor;
            }
            else
            {
                this.btnDone.Enabled = false;
                this.lblMessage.Text = "Floor name taken please select a new one.";
                this.lblMessage.Visible = true;
                this.lblMessage.ForeColor = this.lblRed.ForeColor;
            }
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            //DO SQL stuff
            
            try
            {
                floorsTableAdapter1.AddFloor(this.txtFloorName.Text);
                floorsTableAdapter1.Update(this.iReserveDBDataSet);

                MessageBox.Show("Added Floor: " + this.txtFloorName.Text);
            }
            catch(Exception ex){
                MessageBox.Show(ex.StackTrace);
                MessageBox.Show("Insert Failed");
            }
            
            //this.DestroyHandle();
            this.Close();
        }

        private void lblMessage_Click(object sender, EventArgs e)
        {

        }

        private void lblGreen_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DestroyHandle();
            this.Close();
        }

        private void txtFloorName_KeyDown(object sender, KeyEventArgs e)
        {
            //if enter key is pressed
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(sender, e);
            }
        }

        private void txtFloorName_TextChanged(object sender, EventArgs e)
        {
            lblMessage.Visible = false;
            this.btnDone.Enabled = false;
        }

        private void floorsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.floorsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.iReserveDBDataSet);

        }
    }
}
