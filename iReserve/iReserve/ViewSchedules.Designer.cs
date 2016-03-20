﻿namespace WindowsFormsApplication1
{
    partial class ViewSchedules
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
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.iReserveDBDataSet = new WindowsFormsApplication1.iReserveDBDataSet();
            this.floorsXroomsXSchedulesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.floorsXroomsXSchedulesTableAdapter = new WindowsFormsApplication1.iReserveDBDataSetTableAdapters.floorsXroomsXSchedulesTableAdapter();
            this.tableAdapterManager = new WindowsFormsApplication1.iReserveDBDataSetTableAdapters.TableAdapterManager();
            this.floorsXroomsXSchedulesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.iReserveDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.floorsXroomsXSchedulesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.floorsXroomsXSchedulesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(564, 9);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(104, 33);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.Gray;
            this.txtSearch.Location = new System.Drawing.Point(22, 15);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(527, 26);
            this.txtSearch.TabIndex = 5;
            this.txtSearch.Text = "Search";
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.Enter += new System.EventHandler(this.txtSearch_Enter);
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            this.txtSearch.Leave += new System.EventHandler(this.txtSearch_Leave);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(336, 401);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(103, 36);
            this.btnBack.TabIndex = 8;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.button1_Click);
            // 
            // iReserveDBDataSet
            // 
            this.iReserveDBDataSet.DataSetName = "iReserveDBDataSet";
            this.iReserveDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // floorsXroomsXSchedulesBindingSource
            // 
            this.floorsXroomsXSchedulesBindingSource.DataMember = "floorsXroomsXSchedules";
            this.floorsXroomsXSchedulesBindingSource.DataSource = this.iReserveDBDataSet;
            // 
            // floorsXroomsXSchedulesTableAdapter
            // 
            this.floorsXroomsXSchedulesTableAdapter.ClearBeforeFill = true;
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
            // floorsXroomsXSchedulesDataGridView
            // 
            this.floorsXroomsXSchedulesDataGridView.AllowUserToAddRows = false;
            this.floorsXroomsXSchedulesDataGridView.AllowUserToDeleteRows = false;
            this.floorsXroomsXSchedulesDataGridView.AutoGenerateColumns = false;
            this.floorsXroomsXSchedulesDataGridView.BackgroundColor = System.Drawing.Color.DarkSlateGray;
            this.floorsXroomsXSchedulesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.floorsXroomsXSchedulesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.floorsXroomsXSchedulesDataGridView.DataSource = this.floorsXroomsXSchedulesBindingSource;
            this.floorsXroomsXSchedulesDataGridView.Location = new System.Drawing.Point(22, 51);
            this.floorsXroomsXSchedulesDataGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.floorsXroomsXSchedulesDataGridView.Name = "floorsXroomsXSchedulesDataGridView";
            this.floorsXroomsXSchedulesDataGridView.ReadOnly = true;
            this.floorsXroomsXSchedulesDataGridView.RowTemplate.Height = 24;
            this.floorsXroomsXSchedulesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.floorsXroomsXSchedulesDataGridView.Size = new System.Drawing.Size(759, 344);
            this.floorsXroomsXSchedulesDataGridView.TabIndex = 9;
            this.floorsXroomsXSchedulesDataGridView.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.floorsXroomsXSchedulesDataGridView_DataBindingComplete);
            this.floorsXroomsXSchedulesDataGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.floorsXroomsXSchedulesDataGridView_KeyDown);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "floorName";
            this.dataGridViewTextBoxColumn1.HeaderText = "Floor Name";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "roomName";
            this.dataGridViewTextBoxColumn2.HeaderText = "Room Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "subj";
            this.dataGridViewTextBoxColumn3.HeaderText = "Subject";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "weekDay";
            this.dataGridViewTextBoxColumn4.HeaderText = "Weekday";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "startTime";
            this.dataGridViewTextBoxColumn5.HeaderText = "Start Time";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "endTime";
            this.dataGridViewTextBoxColumn6.HeaderText = "End Time";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(677, 9);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(104, 33);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // ViewSchedules
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 448);
            this.ControlBox = false;
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.floorsXroomsXSchedulesDataGridView);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ViewSchedules";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewSchedules";
            this.Load += new System.EventHandler(this.ViewSchedules_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ViewSchedules_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.iReserveDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.floorsXroomsXSchedulesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.floorsXroomsXSchedulesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnBack;
        private iReserveDBDataSet iReserveDBDataSet;
        private System.Windows.Forms.BindingSource floorsXroomsXSchedulesBindingSource;
        private iReserveDBDataSetTableAdapters.floorsXroomsXSchedulesTableAdapter floorsXroomsXSchedulesTableAdapter;
        private iReserveDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView floorsXroomsXSchedulesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Button btnDelete;
    }
}