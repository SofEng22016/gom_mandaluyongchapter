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
    public partial class MakeSchedule : Form
    {
        public MakeSchedule()
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

            foreach (TabControl tabCtrl in this.Controls.OfType<TabControl>())
            {//this will controll all button inside form
                tabControlMakeSched.BackColor = Color.White;

                foreach (TabPage tabPage in tabCtrl.Controls.OfType<TabPage>())
                {//this will controll all button inside form
                    tabPage.BackgroundImage = Properties.Resources.white;
                    tabPage.BackgroundImageLayout = ImageLayout.Stretch;



                    foreach (Label lbl in tabPage.Controls.OfType<Label>())
                    {//this will controll all button inside form
                        lbl.BackColor = Color.Transparent;

                    }
                    foreach (Button btn in tabPage.Controls.OfType<Button>())
                    {//this will controll all button inside form
                        btn.FlatStyle = FlatStyle.Standard;
                        btn.ForeColor = Color.Black;
                        btn.BackColor = Color.White;

                    }
                }

            }
        }

        private void MakeSchedule_Load(object sender, EventArgs e)
        {

        }

    }
}
