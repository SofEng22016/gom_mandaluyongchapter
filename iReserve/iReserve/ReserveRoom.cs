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
    public partial class ReserveRoom : Form
    {
        String strDate = "";
        String strWeekDay = "";
        String startTime = "";
        String endTime = "";
        int idOfRoom = 1;
        int adminID = 0;

        
        

        public int convertToMilitary(String input){
            String [] array;
            String [] time;
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

        public ReserveRoom(int id)
        {
            InitializeComponent();
            this.startTimePicker.CustomFormat = "hh:mm tt";
            this.endTimePicker.CustomFormat = "hh:mm tt";
            this.btnReserve.Enabled = false;
            this.adminID = id;

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
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dateReserved_ValueChanged(object sender, EventArgs e)
        {
            this.strDate = this.dateReserved.Text;
            String[] temp;
            temp = this.strDate.Split(',');
            this.strWeekDay = temp[0];
            //MessageBox.Show(this.strWeekDay);
            
        }

        private void startTimePicker_ValueChanged(object sender, EventArgs e)
        {
            this.startTime = this.startTimePicker.Text;
            
            //TimeSpan.TryParse(this.startTime+"-"+this.endTime, out spanStart);
            //MessageBox.Show(""+convertToMilitary(this.startTime));
        }

        private void endTimePicker_ValueChanged(object sender, EventArgs e)
        {
            this.endTime = this.endTimePicker.Text;
            
            //TimeSpan.TryParse(this.startTime, out spanEnd);
            //MessageBox.Show("" + convertToMilitary(this.endTime));
        }

        private void floorsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.floorsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.iReserveDBDataSet);

        }

        private void ReserveRoom_Load(object sender, EventArgs e)
        {
            
            // TODO: This line of code loads data into the 'iReserveDBDataSet.schedules' table. You can move, or remove it, as needed.
            this.schedulesTableAdapter.Fill(this.iReserveDBDataSet.schedules);
            // TODO: This line of code loads data into the 'iReserveDBDataSet.reservations' table. You can move, or remove it, as needed.
            this.reservationsTableAdapter.Fill(this.iReserveDBDataSet.reservations);
            // TODO: This line of code loads data into the 'iReserveDBDataSet.floors' table. You can move, or remove it, as needed.
            this.floorsTableAdapter.Fill(this.iReserveDBDataSet.floors);

            // TODO: This line of code loads data into the 'iReserveDBDataSet.rooms' table. You can move, or remove it, as needed.
            this.roomsTableAdapter.FillByFloor(this.iReserveDBDataSet.rooms, (int)this.floorsTableAdapter.GetID(this.cBoxFloors.Text));

            
        }

        private void cBoxFloors_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int x = (int)this.floorsTableAdapter.GetID(this.cBoxFloors.Text);
                this.roomsTableAdapter.FillByFloor(this.iReserveDBDataSet.rooms, x);

            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            
                this.lblResult.Visible = false;
                this.btnReserve.Enabled = false;
            
        }

        private void roomsDataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            this.roomsDataGridView.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.roomsDataGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.roomsDataGridView.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            this.startTime = this.startTimePicker.Text;
            this.endTime = this.endTimePicker.Text;

            this.strDate = this.dateReserved.Text;
            String[] temp;
            temp = this.strDate.Split(',');
            this.strWeekDay = temp[0];

            //TODO: Checking for conflict

            //Check for conflicts with schedules

            //Check for conflicts with reservations




            if (0 == (int)reservationsTableAdapter.CheckConflict(this.idOfRoom, this.strDate, convertToMilitary(this.endTime), convertToMilitary(this.startTime)))
            {
                //if there is no conflict within the schedule on the said room
                
                lblResult.Text = "The Schedule is Available!";
                lblResult.ForeColor = Color.Green;
                lblResult.Visible = true;
                this.btnReserve.Enabled = true;
            }
            else
            {
                //if there is a same schedule at the same room
                
                lblResult.Text = "The Schedule is Unavailable";
                lblResult.ForeColor = Color.Red;
                lblResult.Visible = true;
            }
        }

        private void roomsDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            this.lblResult.Visible = false;
            this.btnReserve.Enabled = false;

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
                }

                //MessageBox.Show("Update successful");
                //this.Close();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
                //MessageBox.Show("Update failed");
                //this.Close();
            }
        }

        private void btnReserve_Click(object sender, EventArgs e)
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
                    reservationsTableAdapter.AddReservation(this.txtReqeust.Text, adminID, Convert.ToInt32(value1), this.txtPurpose.Text, 3, "2015-2016", this.strDate, this.strWeekDay, convertToMilitary(this.startTime), convertToMilitary(this.endTime));
                    //FIX THE DATA TYPES
                    MessageBox.Show("Reservation Successful");
                    this.Close();
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

            //Right now default values for admin term and sy are being used we should change the form so we can have that as input aswell
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        
    }
}
