namespace WindowsFormsApplication1
{
    partial class ReserveRoom
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnReserve = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtReqeust = new System.Windows.Forms.TextBox();
            this.dateReserved = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.startTimePicker = new System.Windows.Forms.DateTimePicker();
            this.endTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.iReserveDBDataSet = new WindowsFormsApplication1.iReserveDBDataSet();
            this.floorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.floorsTableAdapter = new WindowsFormsApplication1.iReserveDBDataSetTableAdapters.floorsTableAdapter();
            this.tableAdapterManager = new WindowsFormsApplication1.iReserveDBDataSetTableAdapters.TableAdapterManager();
            this.reservationsTableAdapter = new WindowsFormsApplication1.iReserveDBDataSetTableAdapters.reservationsTableAdapter();
            this.roomsTableAdapter = new WindowsFormsApplication1.iReserveDBDataSetTableAdapters.roomsTableAdapter();
            this.schedulesTableAdapter = new WindowsFormsApplication1.iReserveDBDataSetTableAdapters.schedulesTableAdapter();
            this.reservationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.schedulesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.roomsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPurpose = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnCheck = new System.Windows.Forms.Button();
            this.tabControlReserve = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnNextTab1 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnBack2 = new System.Windows.Forms.Button();
            this.btnNextTab2 = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.roomsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cBoxFloors = new System.Windows.Forms.ComboBox();
            this.btnBack3 = new System.Windows.Forms.Button();
            this.btnNextPage3 = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.lblReset = new System.Windows.Forms.Label();
            this.btnYes = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.lblFloor = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblRoom = new System.Windows.Forms.Label();
            this.lblEndTime = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblStartTime = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblPurpose = new System.Windows.Forms.Label();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnBack4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.iReserveDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.floorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabControlReserve.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomsDataGridView)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(61, 535);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(165, 52);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnReserve
            // 
            this.btnReserve.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReserve.Location = new System.Drawing.Point(472, 378);
            this.btnReserve.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReserve.Name = "btnReserve";
            this.btnReserve.Size = new System.Drawing.Size(97, 43);
            this.btnReserve.TabIndex = 1;
            this.btnReserve.Text = "Reserve";
            this.btnReserve.UseVisualStyleBackColor = true;
            this.btnReserve.Click += new System.EventHandler(this.btnReserve_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Requesting Department:";
            // 
            // txtReqeust
            // 
            this.txtReqeust.Location = new System.Drawing.Point(39, 96);
            this.txtReqeust.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtReqeust.Name = "txtReqeust";
            this.txtReqeust.Size = new System.Drawing.Size(531, 26);
            this.txtReqeust.TabIndex = 3;
            // 
            // dateReserved
            // 
            this.dateReserved.Location = new System.Drawing.Point(84, 114);
            this.dateReserved.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateReserved.Name = "dateReserved";
            this.dateReserved.Size = new System.Drawing.Size(300, 26);
            this.dateReserved.TabIndex = 4;
            this.dateReserved.ValueChanged += new System.EventHandler(this.dateReserved_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Reservation Date:";
            // 
            // startTimePicker
            // 
            this.startTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.startTimePicker.Location = new System.Drawing.Point(93, 32);
            this.startTimePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.startTimePicker.Name = "startTimePicker";
            this.startTimePicker.ShowUpDown = true;
            this.startTimePicker.Size = new System.Drawing.Size(125, 26);
            this.startTimePicker.TabIndex = 6;
            this.startTimePicker.ValueChanged += new System.EventHandler(this.startTimePicker_ValueChanged);
            // 
            // endTimePicker
            // 
            this.endTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.endTimePicker.Location = new System.Drawing.Point(321, 31);
            this.endTimePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.endTimePicker.Name = "endTimePicker";
            this.endTimePicker.ShowUpDown = true;
            this.endTimePicker.Size = new System.Drawing.Size(141, 26);
            this.endTimePicker.TabIndex = 7;
            this.endTimePicker.ValueChanged += new System.EventHandler(this.endTimePicker_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Start:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(269, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "End:";
            // 
            // iReserveDBDataSet
            // 
            this.iReserveDBDataSet.DataSetName = "iReserveDBDataSet";
            this.iReserveDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // floorsBindingSource
            // 
            this.floorsBindingSource.DataMember = "floors";
            this.floorsBindingSource.DataSource = this.iReserveDBDataSet;
            // 
            // floorsTableAdapter
            // 
            this.floorsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.floorsTableAdapter = this.floorsTableAdapter;
            this.tableAdapterManager.reservationsTableAdapter = this.reservationsTableAdapter;
            this.tableAdapterManager.roomsTableAdapter = this.roomsTableAdapter;
            this.tableAdapterManager.schedulesTableAdapter = this.schedulesTableAdapter;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApplication1.iReserveDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usersTableAdapter = null;
            // 
            // reservationsTableAdapter
            // 
            this.reservationsTableAdapter.ClearBeforeFill = true;
            // 
            // roomsTableAdapter
            // 
            this.roomsTableAdapter.ClearBeforeFill = true;
            // 
            // schedulesTableAdapter
            // 
            this.schedulesTableAdapter.ClearBeforeFill = true;
            // 
            // reservationsBindingSource
            // 
            this.reservationsBindingSource.DataMember = "reservations";
            this.reservationsBindingSource.DataSource = this.iReserveDBDataSet;
            // 
            // schedulesBindingSource
            // 
            this.schedulesBindingSource.DataMember = "schedules";
            this.schedulesBindingSource.DataSource = this.iReserveDBDataSet;
            // 
            // roomsBindingSource
            // 
            this.roomsBindingSource.DataMember = "rooms";
            this.roomsBindingSource.DataSource = this.iReserveDBDataSet;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(413, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Floor:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Rooms:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.startTimePicker);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.endTimePicker);
            this.groupBox1.Location = new System.Drawing.Point(43, 212);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(504, 74);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Time";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(28, 160);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Purpose:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txtPurpose
            // 
            this.txtPurpose.Location = new System.Drawing.Point(41, 206);
            this.txtPurpose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPurpose.Name = "txtPurpose";
            this.txtPurpose.Size = new System.Drawing.Size(529, 26);
            this.txtPurpose.TabIndex = 16;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(363, 294);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(112, 20);
            this.lblResult.TabIndex = 17;
            this.lblResult.Text = "Results Label";
            this.lblResult.Visible = false;
            // 
            // btnCheck
            // 
            this.btnCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheck.Location = new System.Drawing.Point(57, 287);
            this.btnCheck.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(173, 36);
            this.btnCheck.TabIndex = 18;
            this.btnCheck.Text = "Check Availability";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // tabControlReserve
            // 
            this.tabControlReserve.Controls.Add(this.tabPage1);
            this.tabControlReserve.Controls.Add(this.tabPage2);
            this.tabControlReserve.Controls.Add(this.tabPage3);
            this.tabControlReserve.Controls.Add(this.tabPage4);
            this.tabControlReserve.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlReserve.Location = new System.Drawing.Point(35, 34);
            this.tabControlReserve.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControlReserve.Multiline = true;
            this.tabControlReserve.Name = "tabControlReserve";
            this.tabControlReserve.SelectedIndex = 0;
            this.tabControlReserve.Size = new System.Drawing.Size(636, 462);
            this.tabControlReserve.TabIndex = 19;
            this.tabControlReserve.SelectedIndexChanged += new System.EventHandler(this.tabControlReserve_SelectedIndexChanged);
            this.tabControlReserve.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabControlReserve_Selecting);
            this.tabControlReserve.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.tabControlReserve_ControlAdded);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnNextTab1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txtReqeust);
            this.tabPage1.Controls.Add(this.txtPurpose);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(628, 429);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Step 1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnNextTab1
            // 
            this.btnNextTab1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextTab1.Location = new System.Drawing.Point(472, 378);
            this.btnNextTab1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNextTab1.Name = "btnNextTab1";
            this.btnNextTab1.Size = new System.Drawing.Size(97, 43);
            this.btnNextTab1.TabIndex = 0;
            this.btnNextTab1.Text = "Next";
            this.btnNextTab1.UseVisualStyleBackColor = true;
            this.btnNextTab1.Click += new System.EventHandler(this.btnNextTab1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnBack2);
            this.tabPage2.Controls.Add(this.btnNextTab2);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.dateReserved);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabPage2.Size = new System.Drawing.Size(628, 429);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Step 2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnBack2
            // 
            this.btnBack2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack2.Location = new System.Drawing.Point(349, 378);
            this.btnBack2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBack2.Name = "btnBack2";
            this.btnBack2.Size = new System.Drawing.Size(97, 43);
            this.btnBack2.TabIndex = 2;
            this.btnBack2.Text = "Go Back";
            this.btnBack2.UseVisualStyleBackColor = true;
            this.btnBack2.Click += new System.EventHandler(this.btnBack2_Click);
            // 
            // btnNextTab2
            // 
            this.btnNextTab2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextTab2.Location = new System.Drawing.Point(472, 378);
            this.btnNextTab2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNextTab2.Name = "btnNextTab2";
            this.btnNextTab2.Size = new System.Drawing.Size(97, 43);
            this.btnNextTab2.TabIndex = 0;
            this.btnNextTab2.Text = "Next";
            this.btnNextTab2.UseVisualStyleBackColor = true;
            this.btnNextTab2.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.roomsDataGridView);
            this.tabPage3.Controls.Add(this.cBoxFloors);
            this.tabPage3.Controls.Add(this.btnBack3);
            this.tabPage3.Controls.Add(this.lblResult);
            this.tabPage3.Controls.Add(this.btnCheck);
            this.tabPage3.Controls.Add(this.btnNextPage3);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage3.Size = new System.Drawing.Size(628, 429);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Step 3";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Enter += new System.EventHandler(this.tabPage3_Enter);
            // 
            // roomsDataGridView
            // 
            this.roomsDataGridView.AllowUserToAddRows = false;
            this.roomsDataGridView.AllowUserToDeleteRows = false;
            this.roomsDataGridView.AutoGenerateColumns = false;
            this.roomsDataGridView.BackgroundColor = System.Drawing.Color.DarkSlateGray;
            this.roomsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.roomsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.roomsDataGridView.DataSource = this.roomsBindingSource;
            this.roomsDataGridView.Location = new System.Drawing.Point(39, 78);
            this.roomsDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.roomsDataGridView.MultiSelect = false;
            this.roomsDataGridView.Name = "roomsDataGridView";
            this.roomsDataGridView.ReadOnly = true;
            this.roomsDataGridView.RowTemplate.Height = 24;
            this.roomsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.roomsDataGridView.Size = new System.Drawing.Size(327, 161);
            this.roomsDataGridView.TabIndex = 20;
            this.roomsDataGridView.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.roomsDataGridView_DataBindingComplete);
            this.roomsDataGridView.SelectionChanged += new System.EventHandler(this.roomsDataGridView_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "roomName";
            this.dataGridViewTextBoxColumn2.HeaderText = "roomName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "description";
            this.dataGridViewTextBoxColumn3.HeaderText = "description";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // cBoxFloors
            // 
            this.cBoxFloors.DataSource = this.floorsBindingSource;
            this.cBoxFloors.DisplayMember = "floorName";
            this.cBoxFloors.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxFloors.FormattingEnabled = true;
            this.cBoxFloors.Location = new System.Drawing.Point(417, 79);
            this.cBoxFloors.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cBoxFloors.Name = "cBoxFloors";
            this.cBoxFloors.Size = new System.Drawing.Size(121, 28);
            this.cBoxFloors.TabIndex = 19;
            this.cBoxFloors.ValueMember = "floorName";
            this.cBoxFloors.SelectedIndexChanged += new System.EventHandler(this.cBoxFloors_SelectedIndexChanged);
            // 
            // btnBack3
            // 
            this.btnBack3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack3.Location = new System.Drawing.Point(349, 378);
            this.btnBack3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBack3.Name = "btnBack3";
            this.btnBack3.Size = new System.Drawing.Size(97, 43);
            this.btnBack3.TabIndex = 2;
            this.btnBack3.Text = "Go Back";
            this.btnBack3.UseVisualStyleBackColor = true;
            this.btnBack3.Click += new System.EventHandler(this.btnBack3_Click);
            // 
            // btnNextPage3
            // 
            this.btnNextPage3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextPage3.Location = new System.Drawing.Point(472, 378);
            this.btnNextPage3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNextPage3.Name = "btnNextPage3";
            this.btnNextPage3.Size = new System.Drawing.Size(97, 43);
            this.btnNextPage3.TabIndex = 0;
            this.btnNextPage3.Text = "Next";
            this.btnNextPage3.UseVisualStyleBackColor = true;
            this.btnNextPage3.Click += new System.EventHandler(this.btnNextPage3_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.White;
            this.tabPage4.Controls.Add(this.lblReset);
            this.tabPage4.Controls.Add(this.btnReserve);
            this.tabPage4.Controls.Add(this.btnYes);
            this.tabPage4.Controls.Add(this.label14);
            this.tabPage4.Controls.Add(this.lblFloor);
            this.tabPage4.Controls.Add(this.label13);
            this.tabPage4.Controls.Add(this.lblRoom);
            this.tabPage4.Controls.Add(this.lblEndTime);
            this.tabPage4.Controls.Add(this.label15);
            this.tabPage4.Controls.Add(this.lblStartTime);
            this.tabPage4.Controls.Add(this.lblDate);
            this.tabPage4.Controls.Add(this.lblPurpose);
            this.tabPage4.Controls.Add(this.lblDepartment);
            this.tabPage4.Controls.Add(this.label12);
            this.tabPage4.Controls.Add(this.label11);
            this.tabPage4.Controls.Add(this.label10);
            this.tabPage4.Controls.Add(this.label9);
            this.tabPage4.Controls.Add(this.label8);
            this.tabPage4.Controls.Add(this.btnBack4);
            this.tabPage4.Location = new System.Drawing.Point(4, 29);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage4.Size = new System.Drawing.Size(628, 429);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Step 4";
            // 
            // lblReset
            // 
            this.lblReset.AutoSize = true;
            this.lblReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReset.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblReset.Location = new System.Drawing.Point(219, 304);
            this.lblReset.Name = "lblReset";
            this.lblReset.Size = new System.Drawing.Size(134, 17);
            this.lblReset.TabIndex = 19;
            this.lblReset.Text = "No, Reset all values";
            this.lblReset.Click += new System.EventHandler(this.lblReset_Click);
            // 
            // btnYes
            // 
            this.btnYes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYes.Location = new System.Drawing.Point(61, 294);
            this.btnYes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(97, 31);
            this.btnYes.TabIndex = 18;
            this.btnYes.Text = "Yes";
            this.btnYes.UseVisualStyleBackColor = true;
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(57, 257);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(206, 17);
            this.label14.TabIndex = 17;
            this.label14.Text = "Are all information correct?";
            // 
            // lblFloor
            // 
            this.lblFloor.AutoSize = true;
            this.lblFloor.Location = new System.Drawing.Point(363, 207);
            this.lblFloor.Name = "lblFloor";
            this.lblFloor.Size = new System.Drawing.Size(84, 20);
            this.lblFloor.TabIndex = 16;
            this.lblFloor.Text = "FloorHere";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(347, 206);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(13, 20);
            this.label13.TabIndex = 15;
            this.label13.Text = ",";
            // 
            // lblRoom
            // 
            this.lblRoom.AutoSize = true;
            this.lblRoom.Location = new System.Drawing.Point(263, 206);
            this.lblRoom.Name = "lblRoom";
            this.lblRoom.Size = new System.Drawing.Size(84, 20);
            this.lblRoom.TabIndex = 14;
            this.lblRoom.Text = "roomHere";
            // 
            // lblEndTime
            // 
            this.lblEndTime.AutoSize = true;
            this.lblEndTime.Location = new System.Drawing.Point(372, 169);
            this.lblEndTime.Name = "lblEndTime";
            this.lblEndTime.Size = new System.Drawing.Size(73, 20);
            this.lblEndTime.TabIndex = 13;
            this.lblEndTime.Text = "endTime";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(351, 169);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(15, 20);
            this.label15.TabIndex = 12;
            this.label15.Text = "-";
            // 
            // lblStartTime
            // 
            this.lblStartTime.AutoSize = true;
            this.lblStartTime.Location = new System.Drawing.Point(263, 169);
            this.lblStartTime.Name = "lblStartTime";
            this.lblStartTime.Size = new System.Drawing.Size(80, 20);
            this.lblStartTime.TabIndex = 11;
            this.lblStartTime.Text = "startTime";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(263, 130);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(124, 20);
            this.lblDate.TabIndex = 10;
            this.lblDate.Text = "insertDateHere";
            // 
            // lblPurpose
            // 
            this.lblPurpose.AutoSize = true;
            this.lblPurpose.Location = new System.Drawing.Point(263, 91);
            this.lblPurpose.Name = "lblPurpose";
            this.lblPurpose.Size = new System.Drawing.Size(106, 20);
            this.lblPurpose.TabIndex = 9;
            this.lblPurpose.Text = "purposeHere";
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Location = new System.Drawing.Point(263, 57);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(78, 20);
            this.lblDepartment.TabIndex = 8;
            this.lblDepartment.Text = "deptHere";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(53, 206);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 20);
            this.label12.TabIndex = 7;
            this.label12.Text = "Room:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(52, 130);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(117, 20);
            this.label11.TabIndex = 6;
            this.label11.Text = "Reserve Date:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(52, 169);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(145, 20);
            this.label10.TabIndex = 5;
            this.label10.Text = "Reservation Time:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(53, 91);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 20);
            this.label9.TabIndex = 4;
            this.label9.Text = "Purpose:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(53, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(191, 20);
            this.label8.TabIndex = 3;
            this.label8.Text = "Requesting Department:";
            // 
            // btnBack4
            // 
            this.btnBack4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack4.Location = new System.Drawing.Point(349, 378);
            this.btnBack4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBack4.Name = "btnBack4";
            this.btnBack4.Size = new System.Drawing.Size(97, 43);
            this.btnBack4.TabIndex = 2;
            this.btnBack4.Text = "Go Back";
            this.btnBack4.UseVisualStyleBackColor = true;
            this.btnBack4.Click += new System.EventHandler(this.btnBack4_Click_1);
            // 
            // ReserveRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 620);
            this.ControlBox = false;
            this.Controls.Add(this.tabControlReserve);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ReserveRoom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Make Reservation";
            this.Load += new System.EventHandler(this.ReserveRoom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iReserveDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.floorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControlReserve.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomsDataGridView)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnReserve;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtReqeust;
        private System.Windows.Forms.DateTimePicker dateReserved;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker startTimePicker;
        private System.Windows.Forms.DateTimePicker endTimePicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private iReserveDBDataSet iReserveDBDataSet;
        private System.Windows.Forms.BindingSource floorsBindingSource;
        private iReserveDBDataSetTableAdapters.floorsTableAdapter floorsTableAdapter;
        private iReserveDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private iReserveDBDataSetTableAdapters.reservationsTableAdapter reservationsTableAdapter;
        private System.Windows.Forms.BindingSource reservationsBindingSource;
        private iReserveDBDataSetTableAdapters.schedulesTableAdapter schedulesTableAdapter;
        private System.Windows.Forms.BindingSource schedulesBindingSource;
        private iReserveDBDataSetTableAdapters.roomsTableAdapter roomsTableAdapter;
        private System.Windows.Forms.BindingSource roomsBindingSource;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPurpose;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.TabControl tabControlReserve;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnNextTab2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button btnNextPage3;
        private System.Windows.Forms.Button btnBack2;
        private System.Windows.Forms.Button btnBack3;
        private System.Windows.Forms.Button btnBack4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblFloor;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblRoom;
        private System.Windows.Forms.Label lblEndTime;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblStartTime;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblPurpose;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblReset;
        private System.Windows.Forms.Button btnYes;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cBoxFloors;
        private System.Windows.Forms.DataGridView roomsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Button btnNextTab1;
    }
}