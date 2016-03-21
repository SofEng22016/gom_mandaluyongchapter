namespace WindowsFormsApplication1
{
    partial class MakeSchedule
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
            this.tabControlMakeSched = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnNextTab1 = new System.Windows.Forms.Button();
            this.txtProf = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.roomsDataGridView = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.floorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reservationIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iReserveDBDataSet = new WindowsFormsApplication1.iReserveDBDataSet();
            this.cBoxFloors = new System.Windows.Forms.ComboBox();
            this.floorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnBack2 = new System.Windows.Forms.Button();
            this.btnNextPage2 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnCheck = new System.Windows.Forms.Button();
            this.cBoxDays = new System.Windows.Forms.ComboBox();
            this.btnBack3 = new System.Windows.Forms.Button();
            this.btnNextTab3 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.startTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.endTimePicker = new System.Windows.Forms.DateTimePicker();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.lblSubject = new System.Windows.Forms.Label();
            this.lblReset = new System.Windows.Forms.Label();
            this.btnReserve = new System.Windows.Forms.Button();
            this.btnYes = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.lblFloor = new System.Windows.Forms.Label();
            this.lblRoom = new System.Windows.Forms.Label();
            this.lblEndTime = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblStartTime = new System.Windows.Forms.Label();
            this.lblDay = new System.Windows.Forms.Label();
            this.lblProf = new System.Windows.Forms.Label();
            this.lblSubjCode = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.btnBack4 = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.floorsTableAdapter = new WindowsFormsApplication1.iReserveDBDataSetTableAdapters.floorsTableAdapter();
            this.roomsTableAdapter = new WindowsFormsApplication1.iReserveDBDataSetTableAdapters.roomsTableAdapter();
            this.schedulesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.schedulesTableAdapter = new WindowsFormsApplication1.iReserveDBDataSetTableAdapters.schedulesTableAdapter();
            this.tableAdapterManager = new WindowsFormsApplication1.iReserveDBDataSetTableAdapters.TableAdapterManager();
            this.tabControlMakeSched.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iReserveDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.floorsBindingSource)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.schedulesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlMakeSched
            // 
            this.tabControlMakeSched.Controls.Add(this.tabPage1);
            this.tabControlMakeSched.Controls.Add(this.tabPage2);
            this.tabControlMakeSched.Controls.Add(this.tabPage3);
            this.tabControlMakeSched.Controls.Add(this.tabPage4);
            this.tabControlMakeSched.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlMakeSched.Location = new System.Drawing.Point(26, 28);
            this.tabControlMakeSched.Multiline = true;
            this.tabControlMakeSched.Name = "tabControlMakeSched";
            this.tabControlMakeSched.SelectedIndex = 0;
            this.tabControlMakeSched.Size = new System.Drawing.Size(477, 375);
            this.tabControlMakeSched.TabIndex = 0;
            this.tabControlMakeSched.SelectedIndexChanged += new System.EventHandler(this.tabControlMakeSched_SelectedIndexChanged);
            this.tabControlMakeSched.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabControlMakeSched_Selecting);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnNextTab1);
            this.tabPage1.Controls.Add(this.txtProf);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txtSubject);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txtCode);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage1.Size = new System.Drawing.Size(469, 346);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Step 1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnNextTab1
            // 
            this.btnNextTab1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextTab1.Location = new System.Drawing.Point(377, 293);
            this.btnNextTab1.Name = "btnNextTab1";
            this.btnNextTab1.Size = new System.Drawing.Size(73, 35);
            this.btnNextTab1.TabIndex = 13;
            this.btnNextTab1.Text = "Next";
            this.btnNextTab1.UseVisualStyleBackColor = true;
            this.btnNextTab1.Click += new System.EventHandler(this.btnNextTab1_Click);
            // 
            // txtProf
            // 
            this.txtProf.Location = new System.Drawing.Point(30, 250);
            this.txtProf.Name = "txtProf";
            this.txtProf.Size = new System.Drawing.Size(398, 22);
            this.txtProf.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Section";
            // 
            // txtSubject
            // 
            this.txtSubject.Location = new System.Drawing.Point(30, 155);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(398, 22);
            this.txtSubject.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Purpose";
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(30, 65);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(100, 22);
            this.txtCode.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Subject Code";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.roomsDataGridView);
            this.tabPage2.Controls.Add(this.cBoxFloors);
            this.tabPage2.Controls.Add(this.btnBack2);
            this.tabPage2.Controls.Add(this.btnNextPage2);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage2.Size = new System.Drawing.Size(469, 346);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Step 2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // roomsDataGridView
            // 
            this.roomsDataGridView.AllowUserToAddRows = false;
            this.roomsDataGridView.AllowUserToDeleteRows = false;
            this.roomsDataGridView.AutoGenerateColumns = false;
            this.roomsDataGridView.BackgroundColor = System.Drawing.Color.DarkSlateGray;
            this.roomsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.roomsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.roomNameDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.floorDataGridViewTextBoxColumn,
            this.reservationIDDataGridViewTextBoxColumn});
            this.roomsDataGridView.DataSource = this.roomsBindingSource;
            this.roomsDataGridView.Location = new System.Drawing.Point(27, 54);
            this.roomsDataGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.roomsDataGridView.MultiSelect = false;
            this.roomsDataGridView.Name = "roomsDataGridView";
            this.roomsDataGridView.ReadOnly = true;
            this.roomsDataGridView.RowTemplate.Height = 24;
            this.roomsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.roomsDataGridView.Size = new System.Drawing.Size(258, 131);
            this.roomsDataGridView.TabIndex = 28;
            this.roomsDataGridView.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.roomsDataGridView_DataBindingComplete);
            this.roomsDataGridView.SelectionChanged += new System.EventHandler(this.roomsDataGridView_SelectionChanged);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // roomNameDataGridViewTextBoxColumn
            // 
            this.roomNameDataGridViewTextBoxColumn.DataPropertyName = "roomName";
            this.roomNameDataGridViewTextBoxColumn.HeaderText = "roomName";
            this.roomNameDataGridViewTextBoxColumn.Name = "roomNameDataGridViewTextBoxColumn";
            this.roomNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // floorDataGridViewTextBoxColumn
            // 
            this.floorDataGridViewTextBoxColumn.DataPropertyName = "floor";
            this.floorDataGridViewTextBoxColumn.HeaderText = "floor";
            this.floorDataGridViewTextBoxColumn.Name = "floorDataGridViewTextBoxColumn";
            this.floorDataGridViewTextBoxColumn.ReadOnly = true;
            this.floorDataGridViewTextBoxColumn.Visible = false;
            // 
            // reservationIDDataGridViewTextBoxColumn
            // 
            this.reservationIDDataGridViewTextBoxColumn.DataPropertyName = "reservationID";
            this.reservationIDDataGridViewTextBoxColumn.HeaderText = "reservationID";
            this.reservationIDDataGridViewTextBoxColumn.Name = "reservationIDDataGridViewTextBoxColumn";
            this.reservationIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.reservationIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // roomsBindingSource
            // 
            this.roomsBindingSource.DataMember = "rooms";
            this.roomsBindingSource.DataSource = this.iReserveDBDataSet;
            // 
            // iReserveDBDataSet
            // 
            this.iReserveDBDataSet.DataSetName = "iReserveDBDataSet";
            this.iReserveDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cBoxFloors
            // 
            this.cBoxFloors.DataSource = this.floorsBindingSource;
            this.cBoxFloors.DisplayMember = "floorName";
            this.cBoxFloors.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxFloors.FormattingEnabled = true;
            this.cBoxFloors.Location = new System.Drawing.Point(311, 55);
            this.cBoxFloors.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cBoxFloors.Name = "cBoxFloors";
            this.cBoxFloors.Size = new System.Drawing.Size(92, 24);
            this.cBoxFloors.TabIndex = 27;
            this.cBoxFloors.ValueMember = "floorName";
            this.cBoxFloors.SelectedIndexChanged += new System.EventHandler(this.cBoxFloors_SelectedIndexChanged);
            // 
            // floorsBindingSource
            // 
            this.floorsBindingSource.DataMember = "floors";
            this.floorsBindingSource.DataSource = this.iReserveDBDataSet;
            // 
            // btnBack2
            // 
            this.btnBack2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack2.Location = new System.Drawing.Point(277, 293);
            this.btnBack2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBack2.Name = "btnBack2";
            this.btnBack2.Size = new System.Drawing.Size(73, 35);
            this.btnBack2.TabIndex = 22;
            this.btnBack2.Text = "Go Back";
            this.btnBack2.UseVisualStyleBackColor = true;
            this.btnBack2.Click += new System.EventHandler(this.btnBack2_Click);
            // 
            // btnNextPage2
            // 
            this.btnNextPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextPage2.Location = new System.Drawing.Point(377, 293);
            this.btnNextPage2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNextPage2.Name = "btnNextPage2";
            this.btnNextPage2.Size = new System.Drawing.Size(73, 35);
            this.btnNextPage2.TabIndex = 21;
            this.btnNextPage2.Text = "Next";
            this.btnNextPage2.UseVisualStyleBackColor = true;
            this.btnNextPage2.Click += new System.EventHandler(this.btnNextPage2_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 34);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 16);
            this.label8.TabIndex = 24;
            this.label8.Text = "Rooms:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(308, 34);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 16);
            this.label9.TabIndex = 23;
            this.label9.Text = "Floor:";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.lblResult);
            this.tabPage3.Controls.Add(this.btnCheck);
            this.tabPage3.Controls.Add(this.cBoxDays);
            this.tabPage3.Controls.Add(this.btnBack3);
            this.tabPage3.Controls.Add(this.btnNextTab3);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.groupBox1);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage3.Size = new System.Drawing.Size(469, 346);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Step 3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(172, 224);
            this.lblResult.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(278, 16);
            this.lblResult.TabIndex = 28;
            this.lblResult.Text = "Check conflict with room and weekly schedule";
            this.lblResult.Visible = false;
            // 
            // btnCheck
            // 
            this.btnCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheck.Location = new System.Drawing.Point(21, 218);
            this.btnCheck.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(130, 29);
            this.btnCheck.TabIndex = 27;
            this.btnCheck.Text = "Check Availability";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // cBoxDays
            // 
            this.cBoxDays.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxDays.FormattingEnabled = true;
            this.cBoxDays.Items.AddRange(new object[] {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday"});
            this.cBoxDays.Location = new System.Drawing.Point(100, 29);
            this.cBoxDays.Name = "cBoxDays";
            this.cBoxDays.Size = new System.Drawing.Size(121, 24);
            this.cBoxDays.TabIndex = 26;
            this.cBoxDays.SelectedIndexChanged += new System.EventHandler(this.cBoxDays_SelectedIndexChanged);
            // 
            // btnBack3
            // 
            this.btnBack3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack3.Location = new System.Drawing.Point(277, 293);
            this.btnBack3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBack3.Name = "btnBack3";
            this.btnBack3.Size = new System.Drawing.Size(73, 35);
            this.btnBack3.TabIndex = 25;
            this.btnBack3.Text = "Go Back";
            this.btnBack3.UseVisualStyleBackColor = true;
            this.btnBack3.Click += new System.EventHandler(this.btnBack3_Click);
            // 
            // btnNextTab3
            // 
            this.btnNextTab3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextTab3.Location = new System.Drawing.Point(377, 293);
            this.btnNextTab3.Name = "btnNextTab3";
            this.btnNextTab3.Size = new System.Drawing.Size(73, 35);
            this.btnNextTab3.TabIndex = 24;
            this.btnNextTab3.Text = "Next";
            this.btnNextTab3.UseVisualStyleBackColor = true;
            this.btnNextTab3.Click += new System.EventHandler(this.btnNextTab3_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 16);
            this.label6.TabIndex = 22;
            this.label6.Text = "Day";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.startTimePicker);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.endTimePicker);
            this.groupBox1.Location = new System.Drawing.Point(33, 110);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(378, 60);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Time";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 28);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Start:";
            // 
            // startTimePicker
            // 
            this.startTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.startTimePicker.Location = new System.Drawing.Point(70, 26);
            this.startTimePicker.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.startTimePicker.Name = "startTimePicker";
            this.startTimePicker.ShowUpDown = true;
            this.startTimePicker.Size = new System.Drawing.Size(95, 22);
            this.startTimePicker.TabIndex = 6;
            this.startTimePicker.ValueChanged += new System.EventHandler(this.startTimePicker_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(202, 28);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "End:";
            // 
            // endTimePicker
            // 
            this.endTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.endTimePicker.Location = new System.Drawing.Point(241, 25);
            this.endTimePicker.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.endTimePicker.Name = "endTimePicker";
            this.endTimePicker.ShowUpDown = true;
            this.endTimePicker.Size = new System.Drawing.Size(107, 22);
            this.endTimePicker.TabIndex = 7;
            this.endTimePicker.ValueChanged += new System.EventHandler(this.endTimePicker_ValueChanged);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.lblSubject);
            this.tabPage4.Controls.Add(this.lblReset);
            this.tabPage4.Controls.Add(this.btnReserve);
            this.tabPage4.Controls.Add(this.btnYes);
            this.tabPage4.Controls.Add(this.label14);
            this.tabPage4.Controls.Add(this.lblFloor);
            this.tabPage4.Controls.Add(this.lblRoom);
            this.tabPage4.Controls.Add(this.lblEndTime);
            this.tabPage4.Controls.Add(this.label15);
            this.tabPage4.Controls.Add(this.lblStartTime);
            this.tabPage4.Controls.Add(this.lblDay);
            this.tabPage4.Controls.Add(this.lblProf);
            this.tabPage4.Controls.Add(this.lblSubjCode);
            this.tabPage4.Controls.Add(this.label12);
            this.tabPage4.Controls.Add(this.label11);
            this.tabPage4.Controls.Add(this.label10);
            this.tabPage4.Controls.Add(this.label13);
            this.tabPage4.Controls.Add(this.label);
            this.tabPage4.Controls.Add(this.btnBack4);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage4.Size = new System.Drawing.Size(469, 346);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Step 4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Location = new System.Drawing.Point(298, 35);
            this.lblSubject.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(81, 16);
            this.lblSubject.TabIndex = 38;
            this.lblSubject.Text = "subjectHere";
            // 
            // lblReset
            // 
            this.lblReset.AutoSize = true;
            this.lblReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReset.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblReset.Location = new System.Drawing.Point(155, 236);
            this.lblReset.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblReset.Name = "lblReset";
            this.lblReset.Size = new System.Drawing.Size(102, 13);
            this.lblReset.TabIndex = 37;
            this.lblReset.Text = "No, Reset all values";
            this.lblReset.Click += new System.EventHandler(this.lblReset_Click);
            // 
            // btnReserve
            // 
            this.btnReserve.Enabled = false;
            this.btnReserve.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReserve.Location = new System.Drawing.Point(377, 293);
            this.btnReserve.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnReserve.Name = "btnReserve";
            this.btnReserve.Size = new System.Drawing.Size(73, 35);
            this.btnReserve.TabIndex = 20;
            this.btnReserve.Text = "Reserve";
            this.btnReserve.UseVisualStyleBackColor = true;
            this.btnReserve.Click += new System.EventHandler(this.btnReserve_Click);
            // 
            // btnYes
            // 
            this.btnYes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYes.Location = new System.Drawing.Point(37, 228);
            this.btnYes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(73, 25);
            this.btnYes.TabIndex = 36;
            this.btnYes.Text = "Yes";
            this.btnYes.UseVisualStyleBackColor = true;
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(34, 198);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(160, 13);
            this.label14.TabIndex = 35;
            this.label14.Text = "Are all information correct?";
            // 
            // lblFloor
            // 
            this.lblFloor.AutoSize = true;
            this.lblFloor.Location = new System.Drawing.Point(263, 157);
            this.lblFloor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFloor.Name = "lblFloor";
            this.lblFloor.Size = new System.Drawing.Size(69, 16);
            this.lblFloor.TabIndex = 34;
            this.lblFloor.Text = "FloorHere";
            // 
            // lblRoom
            // 
            this.lblRoom.AutoSize = true;
            this.lblRoom.Location = new System.Drawing.Point(188, 156);
            this.lblRoom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRoom.Name = "lblRoom";
            this.lblRoom.Size = new System.Drawing.Size(69, 16);
            this.lblRoom.TabIndex = 33;
            this.lblRoom.Text = "roomHere";
            // 
            // lblEndTime
            // 
            this.lblEndTime.AutoSize = true;
            this.lblEndTime.Location = new System.Drawing.Point(270, 126);
            this.lblEndTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEndTime.Name = "lblEndTime";
            this.lblEndTime.Size = new System.Drawing.Size(62, 16);
            this.lblEndTime.TabIndex = 32;
            this.lblEndTime.Text = "endTime";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(254, 126);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(12, 16);
            this.label15.TabIndex = 31;
            this.label15.Text = "-";
            // 
            // lblStartTime
            // 
            this.lblStartTime.AutoSize = true;
            this.lblStartTime.Location = new System.Drawing.Point(188, 126);
            this.lblStartTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStartTime.Name = "lblStartTime";
            this.lblStartTime.Size = new System.Drawing.Size(64, 16);
            this.lblStartTime.TabIndex = 30;
            this.lblStartTime.Text = "startTime";
            // 
            // lblDay
            // 
            this.lblDay.AutoSize = true;
            this.lblDay.Location = new System.Drawing.Point(188, 95);
            this.lblDay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(95, 16);
            this.lblDay.TabIndex = 29;
            this.lblDay.Text = "insertDayHere";
            // 
            // lblProf
            // 
            this.lblProf.AutoSize = true;
            this.lblProf.Location = new System.Drawing.Point(188, 63);
            this.lblProf.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProf.Name = "lblProf";
            this.lblProf.Size = new System.Drawing.Size(61, 16);
            this.lblProf.TabIndex = 28;
            this.lblProf.Text = "profHere";
            // 
            // lblSubjCode
            // 
            this.lblSubjCode.AutoSize = true;
            this.lblSubjCode.Location = new System.Drawing.Point(188, 35);
            this.lblSubjCode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSubjCode.Name = "lblSubjCode";
            this.lblSubjCode.Size = new System.Drawing.Size(96, 16);
            this.lblSubjCode.TabIndex = 27;
            this.lblSubjCode.Text = "subjCodeHere";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(31, 156);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 16);
            this.label12.TabIndex = 26;
            this.label12.Text = "Room:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(30, 95);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 16);
            this.label11.TabIndex = 25;
            this.label11.Text = "Reserve Day:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(30, 126);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(118, 16);
            this.label10.TabIndex = 24;
            this.label10.Text = "Reservation Time:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(31, 63);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 16);
            this.label13.TabIndex = 23;
            this.label13.Text = "Section:";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(31, 35);
            this.label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(53, 16);
            this.label.TabIndex = 22;
            this.label.Text = "Subject";
            // 
            // btnBack4
            // 
            this.btnBack4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack4.Location = new System.Drawing.Point(277, 293);
            this.btnBack4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBack4.Name = "btnBack4";
            this.btnBack4.Size = new System.Drawing.Size(73, 35);
            this.btnBack4.TabIndex = 21;
            this.btnBack4.Text = "Go Back";
            this.btnBack4.UseVisualStyleBackColor = true;
            this.btnBack4.Click += new System.EventHandler(this.btnBack4_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(51, 432);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(124, 42);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // floorsTableAdapter
            // 
            this.floorsTableAdapter.ClearBeforeFill = true;
            // 
            // roomsTableAdapter
            // 
            this.roomsTableAdapter.ClearBeforeFill = true;
            // 
            // schedulesBindingSource
            // 
            this.schedulesBindingSource.DataMember = "schedules";
            this.schedulesBindingSource.DataSource = this.iReserveDBDataSet;
            // 
            // schedulesTableAdapter
            // 
            this.schedulesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.floorsTableAdapter = this.floorsTableAdapter;
            this.tableAdapterManager.reservationsTableAdapter = null;
            this.tableAdapterManager.roomsTableAdapter = this.roomsTableAdapter;
            this.tableAdapterManager.schedulesTableAdapter = this.schedulesTableAdapter;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApplication1.iReserveDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usersTableAdapter = null;
            // 
            // MakeSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 499);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.tabControlMakeSched);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MakeSchedule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Make Schedule";
            this.Load += new System.EventHandler(this.MakeSchedule_Load);
            this.tabControlMakeSched.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iReserveDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.floorsBindingSource)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.schedulesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMakeSched;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnNextTab1;
        private System.Windows.Forms.TextBox txtProf;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBack3;
        private System.Windows.Forms.Button btnNextTab3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker startTimePicker;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker endTimePicker;
        private System.Windows.Forms.DataGridView roomsDataGridView;
        private System.Windows.Forms.ComboBox cBoxFloors;
        private System.Windows.Forms.Button btnBack2;
        private System.Windows.Forms.Button btnNextPage2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblReset;
        private System.Windows.Forms.Button btnReserve;
        private System.Windows.Forms.Button btnYes;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblFloor;
        private System.Windows.Forms.Label lblRoom;
        private System.Windows.Forms.Label lblEndTime;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblStartTime;
        private System.Windows.Forms.Label lblDay;
        private System.Windows.Forms.Label lblProf;
        private System.Windows.Forms.Label lblSubjCode;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button btnBack4;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.ComboBox cBoxDays;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnCheck;
        private iReserveDBDataSet iReserveDBDataSet;
        private System.Windows.Forms.BindingSource floorsBindingSource;
        private iReserveDBDataSetTableAdapters.floorsTableAdapter floorsTableAdapter;
        private System.Windows.Forms.BindingSource roomsBindingSource;
        private iReserveDBDataSetTableAdapters.roomsTableAdapter roomsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn floorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reservationIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource schedulesBindingSource;
        private iReserveDBDataSetTableAdapters.schedulesTableAdapter schedulesTableAdapter;
        private iReserveDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}