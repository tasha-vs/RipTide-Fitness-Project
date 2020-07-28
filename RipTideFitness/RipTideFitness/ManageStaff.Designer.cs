namespace RipTideFitness
{
    partial class ManageStaff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageStaff));
            this.listBoxStaffID = new System.Windows.Forms.ListBox();
            this.staffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ripTideDBDataSet2 = new RipTideFitness.RipTideDBDataSet2();
            this.ripTideDBDataSetStaffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridDBStaff = new System.Windows.Forms.DataGridView();
            this.staffIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bankAccountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wageRateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffTableAdapter = new RipTideFitness.RipTideDBDataSet2TableAdapters.StaffTableAdapter();
            this.txtbxFullName = new System.Windows.Forms.TextBox();
            this.staffBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.txtbxAge = new System.Windows.Forms.TextBox();
            this.txtbxAddress = new System.Windows.Forms.TextBox();
            this.txtbxBankDetails = new System.Windows.Forms.TextBox();
            this.txtbxWage = new System.Windows.Forms.TextBox();
            this.txtbxJobTitle = new System.Windows.Forms.TextBox();
            this.grpbxStaffID = new System.Windows.Forms.GroupBox();
            this.gpbxStaffDetails = new System.Windows.Forms.GroupBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnViewDB = new System.Windows.Forms.Button();
            this.lblJobTitle = new System.Windows.Forms.Label();
            this.lblWage = new System.Windows.Forms.Label();
            this.lblBankDetails = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblFullName = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtbxHiddenID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ripTideDBDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ripTideDBDataSetStaffBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDBStaff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource1)).BeginInit();
            this.gpbxStaffDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxStaffID
            // 
            this.listBoxStaffID.BackColor = System.Drawing.Color.LightCyan;
            this.listBoxStaffID.DataSource = this.staffBindingSource;
            this.listBoxStaffID.DisplayMember = "StaffId";
            this.listBoxStaffID.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxStaffID.FormattingEnabled = true;
            this.listBoxStaffID.ItemHeight = 22;
            this.listBoxStaffID.Location = new System.Drawing.Point(35, 35);
            this.listBoxStaffID.Name = "listBoxStaffID";
            this.listBoxStaffID.Size = new System.Drawing.Size(341, 268);
            this.listBoxStaffID.TabIndex = 0;
            // 
            // staffBindingSource
            // 
            this.staffBindingSource.DataMember = "Staff";
            this.staffBindingSource.DataSource = this.ripTideDBDataSet2;
            // 
            // ripTideDBDataSet2
            // 
            this.ripTideDBDataSet2.DataSetName = "RipTideDBDataSet2";
            this.ripTideDBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridDBStaff
            // 
            this.dataGridDBStaff.AutoGenerateColumns = false;
            this.dataGridDBStaff.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridDBStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDBStaff.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.staffIdDataGridViewTextBoxColumn,
            this.fullNameDataGridViewTextBoxColumn,
            this.ageDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.bankAccountDataGridViewTextBoxColumn,
            this.wageRateDataGridViewTextBoxColumn,
            this.roleDataGridViewTextBoxColumn});
            this.dataGridDBStaff.DataSource = this.staffBindingSource;
            this.dataGridDBStaff.Location = new System.Drawing.Point(35, 384);
            this.dataGridDBStaff.Name = "dataGridDBStaff";
            this.dataGridDBStaff.Size = new System.Drawing.Size(740, 150);
            this.dataGridDBStaff.TabIndex = 1;
            // 
            // staffIdDataGridViewTextBoxColumn
            // 
            this.staffIdDataGridViewTextBoxColumn.DataPropertyName = "StaffId";
            this.staffIdDataGridViewTextBoxColumn.HeaderText = "StaffId";
            this.staffIdDataGridViewTextBoxColumn.Name = "staffIdDataGridViewTextBoxColumn";
            this.staffIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fullNameDataGridViewTextBoxColumn
            // 
            this.fullNameDataGridViewTextBoxColumn.DataPropertyName = "FullName";
            this.fullNameDataGridViewTextBoxColumn.HeaderText = "FullName";
            this.fullNameDataGridViewTextBoxColumn.Name = "fullNameDataGridViewTextBoxColumn";
            // 
            // ageDataGridViewTextBoxColumn
            // 
            this.ageDataGridViewTextBoxColumn.DataPropertyName = "Age";
            this.ageDataGridViewTextBoxColumn.HeaderText = "Age";
            this.ageDataGridViewTextBoxColumn.Name = "ageDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // bankAccountDataGridViewTextBoxColumn
            // 
            this.bankAccountDataGridViewTextBoxColumn.DataPropertyName = "BankAccount";
            this.bankAccountDataGridViewTextBoxColumn.HeaderText = "BankAccount";
            this.bankAccountDataGridViewTextBoxColumn.Name = "bankAccountDataGridViewTextBoxColumn";
            // 
            // wageRateDataGridViewTextBoxColumn
            // 
            this.wageRateDataGridViewTextBoxColumn.DataPropertyName = "WageRate";
            this.wageRateDataGridViewTextBoxColumn.HeaderText = "WageRate";
            this.wageRateDataGridViewTextBoxColumn.Name = "wageRateDataGridViewTextBoxColumn";
            // 
            // roleDataGridViewTextBoxColumn
            // 
            this.roleDataGridViewTextBoxColumn.DataPropertyName = "Role";
            this.roleDataGridViewTextBoxColumn.HeaderText = "Role";
            this.roleDataGridViewTextBoxColumn.Name = "roleDataGridViewTextBoxColumn";
            // 
            // staffTableAdapter
            // 
            this.staffTableAdapter.ClearBeforeFill = true;
            // 
            // txtbxFullName
            // 
            this.txtbxFullName.BackColor = System.Drawing.Color.LightCyan;
            this.txtbxFullName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.staffBindingSource, "FullName", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtbxFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxFullName.Location = new System.Drawing.Point(556, 48);
            this.txtbxFullName.Name = "txtbxFullName";
            this.txtbxFullName.Size = new System.Drawing.Size(201, 26);
            this.txtbxFullName.TabIndex = 2;
            this.txtbxFullName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbxFullName_KeyPress);
            // 
            // staffBindingSource1
            // 
            this.staffBindingSource1.DataMember = "Staff";
            this.staffBindingSource1.DataSource = this.ripTideDBDataSet2;
            // 
            // txtbxAge
            // 
            this.txtbxAge.BackColor = System.Drawing.Color.LightCyan;
            this.txtbxAge.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.staffBindingSource, "Age", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtbxAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxAge.Location = new System.Drawing.Point(556, 86);
            this.txtbxAge.Name = "txtbxAge";
            this.txtbxAge.Size = new System.Drawing.Size(201, 26);
            this.txtbxAge.TabIndex = 3;
            this.txtbxAge.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbxAge_KeyPress);
            // 
            // txtbxAddress
            // 
            this.txtbxAddress.BackColor = System.Drawing.Color.LightCyan;
            this.txtbxAddress.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.staffBindingSource, "Address", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtbxAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxAddress.Location = new System.Drawing.Point(556, 129);
            this.txtbxAddress.Name = "txtbxAddress";
            this.txtbxAddress.Size = new System.Drawing.Size(201, 26);
            this.txtbxAddress.TabIndex = 4;
            this.txtbxAddress.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbxAddress_KeyPress);
            // 
            // txtbxBankDetails
            // 
            this.txtbxBankDetails.BackColor = System.Drawing.Color.LightCyan;
            this.txtbxBankDetails.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.staffBindingSource, "BankAccount", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtbxBankDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxBankDetails.Location = new System.Drawing.Point(556, 169);
            this.txtbxBankDetails.Name = "txtbxBankDetails";
            this.txtbxBankDetails.Size = new System.Drawing.Size(201, 26);
            this.txtbxBankDetails.TabIndex = 5;
            this.txtbxBankDetails.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbxBankDetails_KeyPress);
            // 
            // txtbxWage
            // 
            this.txtbxWage.BackColor = System.Drawing.Color.LightCyan;
            this.txtbxWage.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.staffBindingSource, "WageRate", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtbxWage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxWage.Location = new System.Drawing.Point(556, 214);
            this.txtbxWage.Name = "txtbxWage";
            this.txtbxWage.Size = new System.Drawing.Size(201, 26);
            this.txtbxWage.TabIndex = 6;
            this.txtbxWage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbxWage_KeyPress);
            // 
            // txtbxJobTitle
            // 
            this.txtbxJobTitle.BackColor = System.Drawing.Color.LightCyan;
            this.txtbxJobTitle.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.staffBindingSource, "Role", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtbxJobTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxJobTitle.Location = new System.Drawing.Point(556, 251);
            this.txtbxJobTitle.Name = "txtbxJobTitle";
            this.txtbxJobTitle.Size = new System.Drawing.Size(201, 26);
            this.txtbxJobTitle.TabIndex = 7;
            this.txtbxJobTitle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbxJobTitle_KeyPress);
            // 
            // grpbxStaffID
            // 
            this.grpbxStaffID.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.grpbxStaffID.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbxStaffID.Location = new System.Drawing.Point(30, 12);
            this.grpbxStaffID.Name = "grpbxStaffID";
            this.grpbxStaffID.Size = new System.Drawing.Size(354, 309);
            this.grpbxStaffID.TabIndex = 9;
            this.grpbxStaffID.TabStop = false;
            this.grpbxStaffID.Text = "Staff by ID:";
            // 
            // gpbxStaffDetails
            // 
            this.gpbxStaffDetails.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gpbxStaffDetails.Controls.Add(this.txtbxHiddenID);
            this.gpbxStaffDetails.Controls.Add(this.btnDelete);
            this.gpbxStaffDetails.Controls.Add(this.btnRefresh);
            this.gpbxStaffDetails.Controls.Add(this.btnViewDB);
            this.gpbxStaffDetails.Controls.Add(this.lblJobTitle);
            this.gpbxStaffDetails.Controls.Add(this.lblWage);
            this.gpbxStaffDetails.Controls.Add(this.lblBankDetails);
            this.gpbxStaffDetails.Controls.Add(this.lblAddress);
            this.gpbxStaffDetails.Controls.Add(this.lblAge);
            this.gpbxStaffDetails.Controls.Add(this.lblFullName);
            this.gpbxStaffDetails.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbxStaffDetails.Location = new System.Drawing.Point(400, 12);
            this.gpbxStaffDetails.Name = "gpbxStaffDetails";
            this.gpbxStaffDetails.Size = new System.Drawing.Size(602, 309);
            this.gpbxStaffDetails.TabIndex = 10;
            this.gpbxStaffDetails.TabStop = false;
            this.gpbxStaffDetails.Text = "Staff Details:";
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.CadetBlue;
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.btnRefresh.FlatAppearance.BorderSize = 2;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Palatino Linotype", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRefresh.Location = new System.Drawing.Point(375, 201);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(194, 62);
            this.btnRefresh.TabIndex = 21;
            this.btnRefresh.Text = "Refresh Changes";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnViewDB
            // 
            this.btnViewDB.BackColor = System.Drawing.Color.CadetBlue;
            this.btnViewDB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewDB.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.btnViewDB.FlatAppearance.BorderSize = 2;
            this.btnViewDB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewDB.Font = new System.Drawing.Font("Palatino Linotype", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewDB.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnViewDB.Location = new System.Drawing.Point(375, 119);
            this.btnViewDB.Name = "btnViewDB";
            this.btnViewDB.Size = new System.Drawing.Size(194, 62);
            this.btnViewDB.TabIndex = 19;
            this.btnViewDB.Text = "View in Database";
            this.btnViewDB.UseVisualStyleBackColor = false;
            this.btnViewDB.Click += new System.EventHandler(this.btnViewDB_Click);
            // 
            // lblJobTitle
            // 
            this.lblJobTitle.AutoSize = true;
            this.lblJobTitle.Location = new System.Drawing.Point(25, 241);
            this.lblJobTitle.Name = "lblJobTitle";
            this.lblJobTitle.Size = new System.Drawing.Size(69, 22);
            this.lblJobTitle.TabIndex = 5;
            this.lblJobTitle.Text = "Job Title:";
            // 
            // lblWage
            // 
            this.lblWage.AutoSize = true;
            this.lblWage.Location = new System.Drawing.Point(25, 204);
            this.lblWage.Name = "lblWage";
            this.lblWage.Size = new System.Drawing.Size(53, 22);
            this.lblWage.TabIndex = 4;
            this.lblWage.Text = "Wage:";
            // 
            // lblBankDetails
            // 
            this.lblBankDetails.AutoSize = true;
            this.lblBankDetails.Location = new System.Drawing.Point(25, 159);
            this.lblBankDetails.Name = "lblBankDetails";
            this.lblBankDetails.Size = new System.Drawing.Size(100, 22);
            this.lblBankDetails.TabIndex = 3;
            this.lblBankDetails.Text = "Bank Details:";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(25, 119);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(68, 22);
            this.lblAddress.TabIndex = 2;
            this.lblAddress.Text = "Address:";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(25, 76);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(41, 22);
            this.lblAge.TabIndex = 1;
            this.lblAge.Text = "Age:";
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Location = new System.Drawing.Point(25, 38);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(86, 22);
            this.lblFullName.TabIndex = 0;
            this.lblFullName.Text = "Full Name:";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.CadetBlue;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.btnBack.FlatAppearance.BorderSize = 2;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Palatino Linotype", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBack.Location = new System.Drawing.Point(808, 433);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(194, 62);
            this.btnBack.TabIndex = 22;
            this.btnBack.Text = "Back to Home";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.CadetBlue;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.btnDelete.FlatAppearance.BorderSize = 2;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Palatino Linotype", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDelete.Location = new System.Drawing.Point(375, 36);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(194, 62);
            this.btnDelete.TabIndex = 22;
            this.btnDelete.Text = "Delete Staff";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtbxHiddenID
            // 
            this.txtbxHiddenID.BackColor = System.Drawing.Color.LightCyan;
            this.txtbxHiddenID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.staffBindingSource, "StaffId", true));
            this.txtbxHiddenID.Location = new System.Drawing.Point(375, 274);
            this.txtbxHiddenID.MaxLength = 80;
            this.txtbxHiddenID.Name = "txtbxHiddenID";
            this.txtbxHiddenID.Size = new System.Drawing.Size(201, 29);
            this.txtbxHiddenID.TabIndex = 23;
            // 
            // ManageStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1029, 593);
            this.Controls.Add(this.txtbxJobTitle);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.txtbxWage);
            this.Controls.Add(this.txtbxBankDetails);
            this.Controls.Add(this.txtbxAddress);
            this.Controls.Add(this.txtbxAge);
            this.Controls.Add(this.txtbxFullName);
            this.Controls.Add(this.dataGridDBStaff);
            this.Controls.Add(this.listBoxStaffID);
            this.Controls.Add(this.grpbxStaffID);
            this.Controls.Add(this.gpbxStaffDetails);
            this.Name = "ManageStaff";
            this.Text = "ManageStaff";
            this.Load += new System.EventHandler(this.ManageStaff_Load);
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ripTideDBDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ripTideDBDataSetStaffBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDBStaff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource1)).EndInit();
            this.gpbxStaffDetails.ResumeLayout(false);
            this.gpbxStaffDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxStaffID;
        private System.Windows.Forms.BindingSource ripTideDBDataSetStaffBindingSource;
        private System.Windows.Forms.DataGridView dataGridDBStaff;
        private RipTideDBDataSet2 ripTideDBDataSet2;
        private System.Windows.Forms.BindingSource staffBindingSource;
        private RipTideDBDataSet2TableAdapters.StaffTableAdapter staffTableAdapter;
        private System.Windows.Forms.TextBox txtbxFullName;
        private System.Windows.Forms.BindingSource staffBindingSource1;
        private System.Windows.Forms.TextBox txtbxAge;
        private System.Windows.Forms.TextBox txtbxAddress;
        private System.Windows.Forms.TextBox txtbxBankDetails;
        private System.Windows.Forms.TextBox txtbxWage;
        private System.Windows.Forms.TextBox txtbxJobTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bankAccountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wageRateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roleDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox grpbxStaffID;
        private System.Windows.Forms.GroupBox gpbxStaffDetails;
        private System.Windows.Forms.Label lblJobTitle;
        private System.Windows.Forms.Label lblWage;
        private System.Windows.Forms.Label lblBankDetails;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Button btnViewDB;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtbxHiddenID;
    }
}