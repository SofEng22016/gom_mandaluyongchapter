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
    public partial class frmLogin : Form
    {
        public frmLogin()
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
            String username, password;
            int valid = 0;
                //TODO: new view here maybe the dashboard?
                //MessageBox.Show("Login Successful");

                //Potential resource leak here ask for better solution
                username = txtUsername.Text;
                password = txtPassword.Text;
                valid = (int)usersTableAdapter.LoginValidation(username, password);
            if (valid > 0)
            {
                MessageBox.Show("Login Successful.");
                
                frmDashboard Dashboard = new frmDashboard();
                this.Visible = false;
                
                Dashboard.ShowDialog();
                this.DestroyHandle();
                this.Close();
                
            }
            else
            {
                //TODO: error invalid user.
                MessageBox.Show("Login Failed.");
            }
        }

        private void usersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iReserveDBDataSet.users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.iReserveDBDataSet.users);
           
        }

        private void usersBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void usersBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.usersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.iReserveDBDataSet);

        }

        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            //if enter key is pressed
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(sender, e);
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            //if enter key is pressed
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(sender, e);
            }
        }
    }
}
