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
        String weekDay;
        int idOfRoom;
        int floorID;
        String startTime;
        String endTime;
        bool doThisOnce = true;

        public MakeSchedule()
        {
            InitializeComponent();
            modifyFormDesign();
            this.startTimePicker.CustomFormat = "hh:mm tt";
            this.endTimePicker.CustomFormat = "hh:mm tt";
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
            // TODO: This line of code loads data into the 'iReserveDBDataSet.schedules' table. You can move, or remove it, as needed.
            this.schedulesTableAdapter.Fill(this.iReserveDBDataSet.schedules);
            

        }

        private void btnNextTab1_Click(object sender, EventArgs e)
        {
            this.tabControlMakeSched.SelectedIndex = 1;//needed this to test things paki ayos mo na lang
            
            this.lblSubjCode.Text = txtCode.Text;
            this.lblProf.Text = txtProf.Text;
            this.lblSubject.Text = txtSubject.Text;

            if (doThisOnce)
            {
                
                // TODO: This line of code loads data into the 'iReserveDBDataSet.floors' table. You can move, or remove it, as needed.
                this.floorsTableAdapter.Fill(this.iReserveDBDataSet.floors);
                // TODO: This line of code loads data into the 'iReserveDBDataSet.rooms' table. You can move, or remove it, as needed.
                this.roomsTableAdapter.FillByFloor(this.iReserveDBDataSet.rooms, (int)this.floorsTableAdapter.GetID(this.cBoxFloors.Text));
                doThisOnce = false;

                
            }
        }

        private void btnNextPage2_Click(object sender, EventArgs e)
        {
            this.tabControlMakeSched.SelectedIndex = 2;

            cBoxDays_SelectedIndexChanged(sender, e);
            roomsDataGridView_SelectionChanged(sender, e);
            if (cBoxDays.SelectedIndex < 0)
            {
                cBoxDays.SelectedIndex = 0;
            }
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void startTimePicker_ValueChanged(object sender, EventArgs e)
        {
            this.startTime = this.startTimePicker.Text;
            this.btnReserve.Enabled = false;
            this.lblResult.Text = "";
        }

        private void endTimePicker_ValueChanged(object sender, EventArgs e)
        {
            this.endTime = this.endTimePicker.Text;
            this.btnReserve.Enabled = false;
            this.lblResult.Text = "";
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            this.startTime = this.startTimePicker.Text;
            this.endTime = this.endTimePicker.Text;
            this.weekDay = (String)cBoxDays.SelectedItem;

            if (0 == (int)this.schedulesTableAdapter.CheckConflict(this.idOfRoom, this.weekDay, convertToMilitary(this.startTime), convertToMilitary(this.endTime)))
            {
                //no conflict
                lblResult.Text = "The Schedule is Available!";
                lblResult.ForeColor = Color.Green;
                lblResult.Visible = true;
            }
            else
            {
                //conflict
                lblResult.Text = "The Schedule is Unavailable";
                lblResult.ForeColor = Color.Red;
                lblResult.Visible = true;
            }



        }

        private void cBoxDays_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.weekDay = (String)cBoxDays.SelectedItem;
            this.btnReserve.Enabled = false;
            this.lblResult.Text = "";
            //MessageBox.Show(this.weekDay);
        }

        public int convertToMilitary(String input)
        {
            String[] array;
            String[] time;
            array = input.Split(' ');

            time = array[0].Split(':');

            int hours = Convert.ToInt16(time[0]);
            int minutes = Convert.ToInt16(time[1]);

            if (array[1].Equals("PM") && hours != 12)
            {
                hours += 12;
                hours *= 100;
            }
            else if (array[1].Equals("PM") && hours == 12)
            {
                hours *= 100;
            }
            else if (array[1].Equals("AM") && hours == 12)
            {
                hours = 0;
            }
            else
            {
                hours *= 100;
            }




            return hours + minutes;
        }

        private void btnNextTab3_Click(object sender, EventArgs e)
        {
            this.tabControlMakeSched.SelectedIndex = 3;
            this.startTime = this.startTimePicker.Text;
            this.endTime = this.endTimePicker.Text;

            this.lblDay.Text = this.weekDay;
            this.lblStartTime.Text = this.startTime;
            this.lblEndTime.Text = this.endTime;
        }

        private void cBoxFloors_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                String dummy = this.cBoxFloors.Text;
                int x = (int)this.floorsTableAdapter.GetID(dummy);
                this.roomsTableAdapter.FillByFloor(this.iReserveDBDataSet.rooms, x);
                this.lblFloor.Text = "" + dummy;
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            this.lblResult.Text = "";
        }

        private void roomsDataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            this.roomsDataGridView.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.roomsDataGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.roomsDataGridView.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void roomsDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                //String toMessage = "";
                this.Validate();
                this.roomsBindingSource.EndEdit();
                this.iReserveDBDataSet.AcceptChanges();
                //this.roomsTableAdapter.Update(this.iReserveDBDataSet.rooms);

                foreach (DataGridViewRow row in roomsDataGridView.SelectedRows)
                {
                    String value1 = row.Cells[0].Value.ToString();//ID of room is now in value1
                    String value2 = row.Cells[1].Value.ToString();
                    String value3 = row.Cells[2].Value.ToString();
                    //toMessage += "Room: " + value2 + " " + value3 + "\n";

                    this.idOfRoom = Convert.ToInt32(value1);
                    this.lblRoom.Text = value2;
                }


                //MessageBox.Show(toMessage);
                //MessageBox.Show("Update successful");
                //this.Close();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
                //MessageBox.Show("Update failed");
                //this.Close();
            }
            this.lblResult.Text = "";
        }

        private void btnReserve_Click(object sender, EventArgs e)
        {
            //TODO: Conflict checking
            this.schedulesTableAdapter.AddSchedule(this.idOfRoom,this.weekDay,convertToMilitary(this.startTime),convertToMilitary(this.endTime),this.txtSubject.Text,3,"2015-2016",this.txtCode.Text,this.txtProf.Text);
            MessageBox.Show("Schedule added!");
            //INSERT INTO `schedules` (`roomID`, `weekDay`, `startTime`, `endTime`, `purpose`, `Term`, `SY`, `subj`, `section`) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?)
            this.Close();
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            if (this.lblResult.Text.Equals("The Schedule is Available!"))
            {
                this.btnReserve.Enabled = true;
                MessageBox.Show("You may now click on Reserve.");
            }
            else
            {
                MessageBox.Show("Please Check if Schedule is available in Step 3.");
            }
        }

        

    }
}
