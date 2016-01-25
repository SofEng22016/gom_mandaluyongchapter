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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to quit?", "Exit", MessageBoxButtons.OKCancel) == DialogResult.OK)
                Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do Login. \nClick OK to simulate successful login. \nClick Cancel to simulate failed login.", "Login", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                //TODO: new view here maybe the dashboard?
                //MessageBox.Show("Login Successful");

                //Potential resource leak here ask for better solution
                usersTableAdapter1.GetData();
                Form2 Dashboard = new Form2();
                //this.Visible = false;

                //Dashboard.ShowDialog();
                //this.DestroyHandle();
                //this.Close();
                //this.Visible = true;
            }
            else
            {
                //TODO: error invalid user.
                MessageBox.Show("Login Failed");
            }
        }

        private void usersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void usersBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }
    }
}
