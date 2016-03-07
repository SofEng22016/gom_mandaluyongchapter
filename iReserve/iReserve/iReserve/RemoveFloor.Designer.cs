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
            this.btnCancel = new System.Windows.Forms.Button();
            this.iReserveDBDataSet = new WindowsFormsApplication1.iReserveDBDataSet();
            this.floorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.floorsTableAdapter = new WindowsFormsApplication1.iReserveDBDataSetTableAdapters.floorsTableAdapter();
            this.tableAdapterManager = new WindowsFormsApplication1.iReserveDBDataSetTableAdapters.TableAdapterManager();
            this.roomsTableAdapter = new WindowsFormsApplication1.iReserveDBDataSetTableAdapters.roomsTableAdapter();
            this.cBoxFloors = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnCheck = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.iReserveDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.floorsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(56, 119);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(101, 25);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
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
            // roomsTableAdapter
            // 
            this.roomsTableAdapter.ClearBeforeFill = true;
            // 
            // cBoxFloors
            // 
            this.cBoxFloors.DataSource = this.floorsBindingSource;
            this.cBoxFloors.DisplayMember = "floorName";
            this.cBoxFloors.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxFloors.FormattingEnabled = true;
            this.cBoxFloors.Location = new System.Drawing.Point(117, 26);
            this.cBoxFloors.Name = "cBoxFloors";
            this.cBoxFloors.Size = new System.Drawing.Size(121, 24);
            this.cBoxFloors.TabIndex = 1;
            this.cBoxFloors.ValueMember = "floorName";
            this.cBoxFloors.SelectedIndexChanged += new System.EventHandler(this.cBoxFloors_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Floor name:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(28, 70);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(87, 17);
            this.lblResult.TabIndex = 3;
            this.lblResult.Text = "Result Label";
            this.lblResult.Visible = false;
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(257, 26);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(86, 25);
            this.btnCheck.TabIndex = 4;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Enabled = false;
            this.btnRemove.Location = new System.Drawing.Point(219, 119);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(101, 25);
            this.btnRemove.TabIndex = 5;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // RemoveFloor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 165);
            this.ControlBox = false;
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cBoxFloors);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "RemoveFloor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RemoveFloor";
            this.Load += new System.EventHandler(this.RemoveFloor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iReserveDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.floorsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private iReserveDBDataSet iReserveDBDataSet;
        private System.Windows.Forms.BindingSource floorsBindingSource;
        private iReserveDBDataSetTableAdapters.floorsTableAdapter floorsTableAdapter;
        private iReserveDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private iReserveDBDataSetTableAdapters.roomsTableAdapter roomsTableAdapter;
        private System.Windows.Forms.ComboBox cBoxFloors;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Button btnRemove;
    }
}