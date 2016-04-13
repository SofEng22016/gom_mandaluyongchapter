namespace WindowsFormsApplication1
{
    partial class frmDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAddFloor = new System.Windows.Forms.Button();
            this.btnAddRoom = new System.Windows.Forms.Button();
            this.btnRemoveRoom = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRemoveFloor = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnMakeReservation = new System.Windows.Forms.Button();
            this.btnViewReservation = new System.Windows.Forms.Button();
            this.btnMakeSchedule = new System.Windows.Forms.Button();
            this.btnViewSchedules = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tableAdapterManager = new WindowsFormsApplication1.iReserveDBDataSetTableAdapters.TableAdapterManager();
            this.floorsXroomsXReservationsTableAdapter = new WindowsFormsApplication1.iReserveDBDataSetTableAdapters.floorsXroomsXReservationsTableAdapter();
            this.floorsXroomsXReservationsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.floorsXroomsXReservationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iReserveDBDataSet = new WindowsFormsApplication1.iReserveDBDataSet();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblUser = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.floorsXroomsXReservationsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.floorsXroomsXReservationsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iReserveDBDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(1080, 268);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(129, 48);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAddFloor
            // 
            this.btnAddFloor.Location = new System.Drawing.Point(21, 25);
            this.btnAddFloor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddFloor.Name = "btnAddFloor";
            this.btnAddFloor.Size = new System.Drawing.Size(135, 31);
            this.btnAddFloor.TabIndex = 7;
            this.btnAddFloor.Text = "Add Floor";
            this.btnAddFloor.UseVisualStyleBackColor = true;
            this.btnAddFloor.Click += new System.EventHandler(this.btnAddFloor_Click);
            // 
            // btnAddRoom
            // 
            this.btnAddRoom.Location = new System.Drawing.Point(21, 68);
            this.btnAddRoom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddRoom.Name = "btnAddRoom";
            this.btnAddRoom.Size = new System.Drawing.Size(135, 31);
            this.btnAddRoom.TabIndex = 8;
            this.btnAddRoom.Text = "Add Room";
            this.btnAddRoom.UseVisualStyleBackColor = true;
            this.btnAddRoom.Click += new System.EventHandler(this.btnAddRoom_Click);
            // 
            // btnRemoveRoom
            // 
            this.btnRemoveRoom.Location = new System.Drawing.Point(184, 68);
            this.btnRemoveRoom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRemoveRoom.Name = "btnRemoveRoom";
            this.btnRemoveRoom.Size = new System.Drawing.Size(135, 31);
            this.btnRemoveRoom.TabIndex = 9;
            this.btnRemoveRoom.Text = "Remove Room";
            this.btnRemoveRoom.UseVisualStyleBackColor = true;
            this.btnRemoveRoom.Click += new System.EventHandler(this.btnRemoveRoom_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(1080, 208);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(129, 48);
            this.btnLogOut.TabIndex = 10;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.Transparent;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(9, 12);
            this.lblDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(72, 17);
            this.lblDate.TabIndex = 11;
            this.lblDate.Text = "22/1/2016";
            this.lblDate.Click += new System.EventHandler(this.lblDate_Click);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(61, 38);
            this.lblTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(44, 17);
            this.lblTime.TabIndex = 12;
            this.lblTime.Text = "21:00";
            this.lblTime.Click += new System.EventHandler(this.lblTime_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnRemoveFloor);
            this.groupBox1.Controls.Add(this.btnAddFloor);
            this.groupBox1.Controls.Add(this.btnAddRoom);
            this.groupBox1.Controls.Add(this.btnRemoveRoom);
            this.groupBox1.Location = new System.Drawing.Point(677, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(332, 112);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Building Modification";
            // 
            // btnRemoveFloor
            // 
            this.btnRemoveFloor.Location = new System.Drawing.Point(183, 25);
            this.btnRemoveFloor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRemoveFloor.Name = "btnRemoveFloor";
            this.btnRemoveFloor.Size = new System.Drawing.Size(135, 31);
            this.btnRemoveFloor.TabIndex = 10;
            this.btnRemoveFloor.Text = "Remove Floor";
            this.btnRemoveFloor.UseVisualStyleBackColor = true;
            this.btnRemoveFloor.Click += new System.EventHandler(this.btnRemoveFloor_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.btnMakeReservation);
            this.groupBox2.Controls.Add(this.btnViewReservation);
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(21, 15);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(327, 112);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Reservations";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // btnMakeReservation
            // 
            this.btnMakeReservation.Location = new System.Drawing.Point(76, 25);
            this.btnMakeReservation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMakeReservation.Name = "btnMakeReservation";
            this.btnMakeReservation.Size = new System.Drawing.Size(160, 31);
            this.btnMakeReservation.TabIndex = 11;
            this.btnMakeReservation.Text = "Make Reservation";
            this.btnMakeReservation.UseVisualStyleBackColor = true;
            this.btnMakeReservation.Click += new System.EventHandler(this.btnMakeReservation_Click);
            // 
            // btnViewReservation
            // 
            this.btnViewReservation.Location = new System.Drawing.Point(76, 68);
            this.btnViewReservation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnViewReservation.Name = "btnViewReservation";
            this.btnViewReservation.Size = new System.Drawing.Size(160, 31);
            this.btnViewReservation.TabIndex = 0;
            this.btnViewReservation.Text = "View All Reservations";
            this.btnViewReservation.UseVisualStyleBackColor = true;
            this.btnViewReservation.Click += new System.EventHandler(this.btnViewReservation_Click);
            // 
            // btnMakeSchedule
            // 
            this.btnMakeSchedule.Location = new System.Drawing.Point(60, 25);
            this.btnMakeSchedule.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMakeSchedule.Name = "btnMakeSchedule";
            this.btnMakeSchedule.Size = new System.Drawing.Size(160, 31);
            this.btnMakeSchedule.TabIndex = 13;
            this.btnMakeSchedule.Text = "Make Schedule";
            this.btnMakeSchedule.UseVisualStyleBackColor = true;
            this.btnMakeSchedule.Click += new System.EventHandler(this.btnMakeSchedule_Click);
            // 
            // btnViewSchedules
            // 
            this.btnViewSchedules.Location = new System.Drawing.Point(60, 66);
            this.btnViewSchedules.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnViewSchedules.Name = "btnViewSchedules";
            this.btnViewSchedules.Size = new System.Drawing.Size(160, 31);
            this.btnViewSchedules.TabIndex = 12;
            this.btnViewSchedules.Text = "View All Schedules";
            this.btnViewSchedules.UseVisualStyleBackColor = true;
            this.btnViewSchedules.Click += new System.EventHandler(this.btnViewSchedules_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 142);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Today\'s Reservations: ";
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.floorsTableAdapter = null;
            this.tableAdapterManager.reservationsTableAdapter = null;
            this.tableAdapterManager.roomsTableAdapter = null;
            this.tableAdapterManager.schedulesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApplication1.iReserveDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usersTableAdapter = null;
            // 
            // floorsXroomsXReservationsTableAdapter
            // 
            this.floorsXroomsXReservationsTableAdapter.ClearBeforeFill = true;
            // 
            // floorsXroomsXReservationsDataGridView
            // 
            this.floorsXroomsXReservationsDataGridView.AllowUserToAddRows = false;
            this.floorsXroomsXReservationsDataGridView.AllowUserToDeleteRows = false;
            this.floorsXroomsXReservationsDataGridView.AutoGenerateColumns = false;
            this.floorsXroomsXReservationsDataGridView.BackgroundColor = System.Drawing.Color.DarkSlateGray;
            this.floorsXroomsXReservationsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.floorsXroomsXReservationsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15});
            this.floorsXroomsXReservationsDataGridView.DataSource = this.floorsXroomsXReservationsBindingSource;
            this.floorsXroomsXReservationsDataGridView.Location = new System.Drawing.Point(20, 166);
            this.floorsXroomsXReservationsDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.floorsXroomsXReservationsDataGridView.Name = "floorsXroomsXReservationsDataGridView";
            this.floorsXroomsXReservationsDataGridView.ReadOnly = true;
            this.floorsXroomsXReservationsDataGridView.RowTemplate.Height = 24;
            this.floorsXroomsXReservationsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.floorsXroomsXReservationsDataGridView.Size = new System.Drawing.Size(992, 245);
            this.floorsXroomsXReservationsDataGridView.TabIndex = 16;
            this.floorsXroomsXReservationsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.floorsXroomsXReservationsDataGridView_CellContentClick);
            this.floorsXroomsXReservationsDataGridView.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.floorsXroomsXReservationsDataGridView_DataBindingComplete);
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "floorName";
            this.dataGridViewTextBoxColumn9.HeaderText = "Floor Name";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "roomName";
            this.dataGridViewTextBoxColumn10.HeaderText = "Room Name";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "reservee";
            this.dataGridViewTextBoxColumn11.HeaderText = "Reservee";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Purpose";
            this.dataGridViewTextBoxColumn12.HeaderText = "Purpose";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "dateReserved";
            this.dataGridViewTextBoxColumn13.HeaderText = "Date Reserved";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "startTime";
            this.dataGridViewTextBoxColumn14.HeaderText = "Start Time";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "endTime";
            this.dataGridViewTextBoxColumn15.HeaderText = "End Time";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            // 
            // floorsXroomsXReservationsBindingSource
            // 
            this.floorsXroomsXReservationsBindingSource.DataMember = "floorsXroomsXReservations";
            this.floorsXroomsXReservationsBindingSource.DataSource = this.iReserveDBDataSet;
            // 
            // iReserveDBDataSet
            // 
            this.iReserveDBDataSet.DataSetName = "iReserveDBDataSet";
            this.iReserveDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblDate);
            this.panel1.Controls.Add(this.lblTime);
            this.panel1.Location = new System.Drawing.Point(1047, 82);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(199, 67);
            this.panel1.TabIndex = 17;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(1052, 27);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(60, 24);
            this.lblUser.TabIndex = 18;
            this.lblUser.Text = "label1";
            this.lblUser.Click += new System.EventHandler(this.lblUser_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.btnMakeSchedule);
            this.groupBox3.Controls.Add(this.btnViewSchedules);
            this.groupBox3.Location = new System.Drawing.Point(379, 15);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(271, 112);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Schedule";
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1261, 460);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.floorsXroomsXReservationsDataGridView);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.frmDashboard_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.floorsXroomsXReservationsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.floorsXroomsXReservationsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iReserveDBDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAddFloor;
        private System.Windows.Forms.Button btnAddRoom;
        private System.Windows.Forms.Button btnRemoveRoom;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRemoveFloor;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnViewSchedules;
        private System.Windows.Forms.Button btnMakeReservation;
        private System.Windows.Forms.Button btnViewReservation;
        private System.Windows.Forms.Label label3;
        private iReserveDBDataSet iReserveDBDataSet;
        private iReserveDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource floorsXroomsXReservationsBindingSource;
        private iReserveDBDataSetTableAdapters.floorsXroomsXReservationsTableAdapter floorsXroomsXReservationsTableAdapter;
        private System.Windows.Forms.DataGridView floorsXroomsXReservationsDataGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Button btnMakeSchedule;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}