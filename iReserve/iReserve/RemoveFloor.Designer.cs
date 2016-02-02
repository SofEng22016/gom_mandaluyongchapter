namespace WindowsFormsApplication1
{
    partial class RemoveFloor
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
            this.cBoxFloors = new System.Windows.Forms.ComboBox();
            this.iReserveDBDataSet = new WindowsFormsApplication1.iReserveDBDataSet();
            this.floorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.floorsTableAdapter = new WindowsFormsApplication1.iReserveDBDataSetTableAdapters.floorsTableAdapter();
            this.tableAdapterManager = new WindowsFormsApplication1.iReserveDBDataSetTableAdapters.TableAdapterManager();
            this.roomsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.roomsTableAdapter = new WindowsFormsApplication1.iReserveDBDataSetTableAdapters.roomsTableAdapter();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.iReserveDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.floorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cBoxFloors
            // 
            this.cBoxFloors.DataSource = this.floorsBindingSource;
            this.cBoxFloors.DisplayMember = "floorName";
            this.cBoxFloors.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxFloors.FormattingEnabled = true;
            this.cBoxFloors.Location = new System.Drawing.Point(12, 30);
            this.cBoxFloors.Name = "cBoxFloors";
            this.cBoxFloors.Size = new System.Drawing.Size(158, 24);
            this.cBoxFloors.TabIndex = 0;
            this.cBoxFloors.ValueMember = "floorName";
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
            this.tableAdapterManager.reservationsTableAdapter = null;
            this.tableAdapterManager.roomsTableAdapter = this.roomsTableAdapter;
            this.tableAdapterManager.schedulesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApplication1.iReserveDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usersTableAdapter = null;
            // 
            // roomsBindingSource
            // 
            this.roomsBindingSource.DataMember = "rooms";
            this.roomsBindingSource.DataSource = this.iReserveDBDataSet;
            // 
            // roomsTableAdapter
            // 
            this.roomsTableAdapter.ClearBeforeFill = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(42, 85);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(102, 42);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(180, 85);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(102, 42);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // RemoveFloor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 160);
            this.ControlBox = false;
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.cBoxFloors);
            this.Name = "RemoveFloor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RemoveFloor";
            this.Load += new System.EventHandler(this.RemoveFloor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iReserveDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.floorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cBoxFloors;
        private iReserveDBDataSet iReserveDBDataSet;
        private System.Windows.Forms.BindingSource floorsBindingSource;
        private iReserveDBDataSetTableAdapters.floorsTableAdapter floorsTableAdapter;
        private iReserveDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private iReserveDBDataSetTableAdapters.roomsTableAdapter roomsTableAdapter;
        private System.Windows.Forms.BindingSource roomsBindingSource;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDelete;
    }
}