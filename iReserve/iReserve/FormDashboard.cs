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
        public frmDashboard()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to quit?", "Exit", MessageBoxButtons.OKCancel) == DialogResult.OK)
                Application.Exit();
                //this.Close();
                
        }

        private void btnAddFloor_Click(object sender, EventArgs e)
        {
            AddFloor af = new AddFloor();
            af.ShowDialog();
        }

        private void btnRemoveRoom_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Please Delete Records one at a time.");
            RemoveRoom removeRoom = new RemoveRoom();
            removeRoom.ShowDialog();
        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            new AddRoom().ShowDialog();
        }
    }
}
