using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();

            foreach (Button btn in this.Controls.OfType<Button>())
            {//this will controll all button inside form
                btn.FlatStyle = FlatStyle.Standard;
                btn.ForeColor = Color.Black;
                btn.BackColor = Color.White;
                
            }
            foreach (TextBox txtbox in this.Controls.OfType<TextBox>())
            {//this will controll all textbox inside form
                txtbox.BorderStyle = BorderStyle.None;
                
            }

            //background
            this.BackgroundImage = Properties.Resources.bg;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(0, 0, pictureBox1.Width - 3, pictureBox1.Height - 3);
            Region rg = new Region(gp);
            pictureBox1.Region = rg;
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
                try { valid = (int)usersTableAdapter.LoginValidation(username, password); }
            catch(Exception ewan){
                
            }
            if (valid > 0)
            {
                MessageBox.Show("Login Successful.");
                
                frmDashboard Dashboard = new frmDashboard(valid);
                this.Visible = false;
                
                Dashboard.ShowDialog();
                try
                {
                    this.txtPassword.Text = "";
                    this.txtUsername.Text = "";
                    this.Visible = true;
                }
                catch (Exception ex)
                {
                }
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
            try
            {
                this.usersTableAdapter.Fill(this.iReserveDBDataSet.users);
            }
            catch (Exception ex)
            {
                MessageBox.Show("DB file not found please quit the application and supply the file.");
            }
           
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
