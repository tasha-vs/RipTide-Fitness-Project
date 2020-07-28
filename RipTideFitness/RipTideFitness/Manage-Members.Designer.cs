namespace RipTideFitness
{
    partial class Manage_StaffDB
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manage_StaffDB));
            this.gbxCurrentMembers = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.memberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ripTideDBDataSet = new RipTideFitness.RipTideDBDataSet();
            this.memberTableAdapter = new RipTideFitness.RipTideDBDataSetTableAdapters.MemberTableAdapter();
            this.gbxMemberDetails = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnViewDB = new System.Windows.Forms.Button();
            this.txtbxFullName = new System.Windows.Forms.TextBox();
            this.txtbxAge = new System.Windows.Forms.TextBox();
            this.txtbxPassword = new System.Windows.Forms.TextBox();
            this.txtbxUsername = new System.Windows.Forms.TextBox();
            this.txtbxCardDetails = new System.Windows.Forms.TextBox();
            this.txtbxAddress = new System.Windows.Forms.TextBox();
            this.chkbxActive = new System.Windows.Forms.CheckBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblCardDetails = new System.Windows.Forms.Label();
            this.lblActive = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblFullName = new System.Windows.Forms.Label();
            this.txtbxHiddenID = new System.Windows.Forms.TextBox();
            this.datagridDB = new System.Windows.Forms.DataGridView();
            this.memberIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goldMemberDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.fullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cardDetailsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activeDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnBack = new System.Windows.Forms.Button();
            this.gbxCurrentMembers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ripTideDBDataSet)).BeginInit();
            this.gbxMemberDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridDB)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxCurrentMembers
            // 
            this.gbxCurrentMembers.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gbxCurrentMembers.Controls.Add(this.listBox1);
            this.gbxCurrentMembers.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxCurrentMembers.Location = new System.Drawing.Point(23, 29);
            this.gbxCurrentMembers.Name = "gbxCurrentMembers";
            this.gbxCurrentMembers.Size = new System.Drawing.Size(354, 309);
            this.gbxCurrentMembers.TabIndex = 0;
            this.gbxCurrentMembers.TabStop = false;
            this.gbxCurrentMembers.Text = "Current Members by ID:";
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.LightCyan;
            this.listBox1.DataSource = this.memberBindingSource;
            this.listBox1.DisplayMember = "MemberID";
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 22;
            this.listBox1.Location = new System.Drawing.Point(6, 28);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(341, 268);
            this.listBox1.TabIndex = 0;
            // 
            // memberBindingSource
            // 
            this.memberBindingSource.DataMember = "Member";
            this.memberBindingSource.DataSource = this.ripTideDBDataSet;
            // 
            // ripTideDBDataSet
            // 
            this.ripTideDBDataSet.DataSetName = "RipTideDBDataSet";
            this.ripTideDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // memberTableAdapter
            // 
            this.memberTableAdapter.ClearBeforeFill = true;
            // 
            // gbxMemberDetails
            // 
            this.gbxMemberDetails.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gbxMemberDetails.Controls.Add(this.button1);
            this.gbxMemberDetails.Controls.Add(this.btnDelete);
            this.gbxMemberDetails.Controls.Add(this.btnViewDB);
            this.gbxMemberDetails.Controls.Add(this.txtbxFullName);
            this.gbxMemberDetails.Controls.Add(this.txtbxAge);
            this.gbxMemberDetails.Controls.Add(this.txtbxPassword);
            this.gbxMemberDetails.Controls.Add(this.txtbxUsername);
            this.gbxMemberDetails.Controls.Add(this.txtbxCardDetails);
            this.gbxMemberDetails.Controls.Add(this.txtbxAddress);
            this.gbxMemberDetails.Controls.Add(this.chkbxActive);
            this.gbxMemberDetails.Controls.Add(this.lblPassword);
            this.gbxMemberDetails.Controls.Add(this.lblAddress);
            this.gbxMemberDetails.Controls.Add(this.lblCardDetails);
            this.gbxMemberDetails.Controls.Add(this.lblActive);
            this.gbxMemberDetails.Controls.Add(this.lblAge);
            this.gbxMemberDetails.Controls.Add(this.lblUsername);
            this.gbxMemberDetails.Controls.Add(this.lblFullName);
            this.gbxMemberDetails.Controls.Add(this.txtbxHiddenID);
            this.gbxMemberDetails.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxMemberDetails.Location = new System.Drawing.Point(397, 29);
            this.gbxMemberDetails.Margin = new System.Windows.Forms.Padding(4);
            this.gbxMemberDetails.Name = "gbxMemberDetails";
            this.gbxMemberDetails.Size = new System.Drawing.Size(602, 309);
            this.gbxMemberDetails.TabIndex = 1;
            this.gbxMemberDetails.TabStop = false;
            this.gbxMemberDetails.Text = "Member Details:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.CadetBlue;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Palatino Linotype", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(385, 199);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(194, 62);
            this.button1.TabIndex = 20;
            this.button1.Text = "Refresh Changes";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.btnDelete.Location = new System.Drawing.Point(385, 51);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(194, 62);
            this.btnDelete.TabIndex = 19;
            this.btnDelete.Text = "Delete Member";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
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
            this.btnViewDB.Location = new System.Drawing.Point(385, 126);
            this.btnViewDB.Name = "btnViewDB";
            this.btnViewDB.Size = new System.Drawing.Size(194, 62);
            this.btnViewDB.TabIndex = 18;
            this.btnViewDB.Text = "View in Database";
            this.btnViewDB.UseVisualStyleBackColor = false;
            this.btnViewDB.Click += new System.EventHandler(this.btnViewDB_Click);
            // 
            // txtbxFullName
            // 
            this.txtbxFullName.BackColor = System.Drawing.Color.LightCyan;
            this.txtbxFullName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.memberBindingSource, "FullName", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtbxFullName.Location = new System.Drawing.Point(148, 25);
            this.txtbxFullName.MaxLength = 80;
            this.txtbxFullName.Name = "txtbxFullName";
            this.txtbxFullName.Size = new System.Drawing.Size(201, 29);
            this.txtbxFullName.TabIndex = 16;
            this.txtbxFullName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbxFullName_KeyPress);
            // 
            // txtbxAge
            // 
            this.txtbxAge.BackColor = System.Drawing.Color.LightCyan;
            this.txtbxAge.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.memberBindingSource, "Age", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, null, "N0"));
            this.txtbxAge.Location = new System.Drawing.Point(148, 61);
            this.txtbxAge.Name = "txtbxAge";
            this.txtbxAge.Size = new System.Drawing.Size(201, 29);
            this.txtbxAge.TabIndex = 15;
            this.txtbxAge.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbxAge_KeyPress);
            // 
            // txtbxPassword
            // 
            this.txtbxPassword.BackColor = System.Drawing.Color.LightCyan;
            this.txtbxPassword.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.memberBindingSource, "Password", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtbxPassword.Location = new System.Drawing.Point(148, 250);
            this.txtbxPassword.MaxLength = 255;
            this.txtbxPassword.Name = "txtbxPassword";
            this.txtbxPassword.Size = new System.Drawing.Size(201, 29);
            this.txtbxPassword.TabIndex = 14;
            // 
            // txtbxUsername
            // 
            this.txtbxUsername.BackColor = System.Drawing.Color.LightCyan;
            this.txtbxUsername.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.memberBindingSource, "Username", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtbxUsername.Location = new System.Drawing.Point(148, 209);
            this.txtbxUsername.MaxLength = 40;
            this.txtbxUsername.Name = "txtbxUsername";
            this.txtbxUsername.Size = new System.Drawing.Size(201, 29);
            this.txtbxUsername.TabIndex = 13;
            // 
            // txtbxCardDetails
            // 
            this.txtbxCardDetails.BackColor = System.Drawing.Color.LightCyan;
            this.txtbxCardDetails.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.memberBindingSource, "CardDetails", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtbxCardDetails.Location = new System.Drawing.Point(148, 136);
            this.txtbxCardDetails.Name = "txtbxCardDetails";
            this.txtbxCardDetails.Size = new System.Drawing.Size(201, 29);
            this.txtbxCardDetails.TabIndex = 12;
            this.txtbxCardDetails.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbxCardDetails_KeyPress);
            // 
            // txtbxAddress
            // 
            this.txtbxAddress.BackColor = System.Drawing.Color.LightCyan;
            this.txtbxAddress.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.memberBindingSource, "Address", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtbxAddress.Location = new System.Drawing.Point(148, 98);
            this.txtbxAddress.MaxLength = 150;
            this.txtbxAddress.Name = "txtbxAddress";
            this.txtbxAddress.Size = new System.Drawing.Size(201, 29);
            this.txtbxAddress.TabIndex = 11;
            this.txtbxAddress.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbxAddress_KeyPress);
            // 
            // chkbxActive
            // 
            this.chkbxActive.AutoSize = true;
            this.chkbxActive.BackColor = System.Drawing.Color.LightCyan;
            this.chkbxActive.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.memberBindingSource, "Active", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkbxActive.Location = new System.Drawing.Point(148, 180);
            this.chkbxActive.Name = "chkbxActive";
            this.chkbxActive.Size = new System.Drawing.Size(15, 14);
            this.chkbxActive.TabIndex = 9;
            this.chkbxActive.UseVisualStyleBackColor = false;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(21, 253);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(78, 22);
            this.lblPassword.TabIndex = 7;
            this.lblPassword.Text = "Password:";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(19, 101);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(68, 22);
            this.lblAddress.TabIndex = 6;
            this.lblAddress.Text = "Address:";
            // 
            // lblCardDetails
            // 
            this.lblCardDetails.AutoSize = true;
            this.lblCardDetails.Location = new System.Drawing.Point(19, 139);
            this.lblCardDetails.Name = "lblCardDetails";
            this.lblCardDetails.Size = new System.Drawing.Size(98, 22);
            this.lblCardDetails.TabIndex = 5;
            this.lblCardDetails.Text = "Card Details:";
            // 
            // lblActive
            // 
            this.lblActive.AutoSize = true;
            this.lblActive.Location = new System.Drawing.Point(19, 180);
            this.lblActive.Name = "lblActive";
            this.lblActive.Size = new System.Drawing.Size(118, 22);
            this.lblActive.TabIndex = 4;
            this.lblActive.Text = "Active Member:";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(19, 64);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(41, 22);
            this.lblAge.TabIndex = 3;
            this.lblAge.Text = "Age:";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(21, 212);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(84, 22);
            this.lblUsername.TabIndex = 2;
            this.lblUsername.Text = "Username:";
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Location = new System.Drawing.Point(19, 28);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(86, 22);
            this.lblFullName.TabIndex = 0;
            this.lblFullName.Text = "Full Name:";
            // 
            // txtbxHiddenID
            // 
            this.txtbxHiddenID.BackColor = System.Drawing.Color.LightCyan;
            this.txtbxHiddenID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.memberBindingSource, "MemberID", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtbxHiddenID.Location = new System.Drawing.Point(385, 267);
            this.txtbxHiddenID.MaxLength = 80;
            this.txtbxHiddenID.Name = "txtbxHiddenID";
            this.txtbxHiddenID.Size = new System.Drawing.Size(201, 29);
            this.txtbxHiddenID.TabIndex = 21;
            // 
            // datagridDB
            // 
            this.datagridDB.AutoGenerateColumns = false;
            this.datagridDB.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.datagridDB.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.datagridDB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridDB.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.memberIDDataGridViewTextBoxColumn,
            this.goldMemberDataGridViewCheckBoxColumn,
            this.fullNameDataGridViewTextBoxColumn,
            this.ageDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.cardDetailsDataGridViewTextBoxColumn,
            this.activeDataGridViewCheckBoxColumn,
            this.usernameDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn});
            this.datagridDB.DataSource = this.memberBindingSource;
            this.datagridDB.Location = new System.Drawing.Point(23, 365);
            this.datagridDB.Name = "datagridDB";
            this.datagridDB.Size = new System.Drawing.Size(976, 143);
            this.datagridDB.TabIndex = 17;
            // 
            // memberIDDataGridViewTextBoxColumn
            // 
            this.memberIDDataGridViewTextBoxColumn.DataPropertyName = "MemberID";
            this.memberIDDataGridViewTextBoxColumn.HeaderText = "MemberID";
            this.memberIDDataGridViewTextBoxColumn.Name = "memberIDDataGridViewTextBoxColumn";
            this.memberIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // goldMemberDataGridViewCheckBoxColumn
            // 
            this.goldMemberDataGridViewCheckBoxColumn.DataPropertyName = "GoldMember";
            this.goldMemberDataGridViewCheckBoxColumn.HeaderText = "GoldMember";
            this.goldMemberDataGridViewCheckBoxColumn.Name = "goldMemberDataGridViewCheckBoxColumn";
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
            // cardDetailsDataGridViewTextBoxColumn
            // 
            this.cardDetailsDataGridViewTextBoxColumn.DataPropertyName = "CardDetails";
            this.cardDetailsDataGridViewTextBoxColumn.HeaderText = "CardDetails";
            this.cardDetailsDataGridViewTextBoxColumn.Name = "cardDetailsDataGridViewTextBoxColumn";
            // 
            // activeDataGridViewCheckBoxColumn
            // 
            this.activeDataGridViewCheckBoxColumn.DataPropertyName = "Active";
            this.activeDataGridViewCheckBoxColumn.HeaderText = "Active";
            this.activeDataGridViewCheckBoxColumn.Name = "activeDataGridViewCheckBoxColumn";
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "Username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "Username";
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
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
            this.btnBack.Location = new System.Drawing.Point(397, 519);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(194, 62);
            this.btnBack.TabIndex = 23;
            this.btnBack.Text = "Back to Home";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // Manage_StaffDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1029, 593);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.datagridDB);
            this.Controls.Add(this.gbxMemberDetails);
            this.Controls.Add(this.gbxCurrentMembers);
            this.Name = "Manage_StaffDB";
            this.Text = "Manage_Members";
            this.Load += new System.EventHandler(this.Manage_Members_Load);
            this.gbxCurrentMembers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ripTideDBDataSet)).EndInit();
            this.gbxMemberDetails.ResumeLayout(false);
            this.gbxMemberDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridDB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxCurrentMembers;
        private System.Windows.Forms.ListBox listBox1;
        private RipTideDBDataSet ripTideDBDataSet;
        private System.Windows.Forms.BindingSource memberBindingSource;
        private RipTideDBDataSetTableAdapters.MemberTableAdapter memberTableAdapter;
        private System.Windows.Forms.GroupBox gbxMemberDetails;
        private System.Windows.Forms.TextBox txtbxFullName;
        private System.Windows.Forms.TextBox txtbxAge;
        private System.Windows.Forms.TextBox txtbxPassword;
        private System.Windows.Forms.TextBox txtbxUsername;
        private System.Windows.Forms.TextBox txtbxCardDetails;
        private System.Windows.Forms.TextBox txtbxAddress;
        private System.Windows.Forms.CheckBox chkbxActive;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblCardDetails;
        private System.Windows.Forms.Label lblActive;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.DataGridView datagridDB;
        private System.Windows.Forms.DataGridViewTextBoxColumn memberIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn goldMemberDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cardDetailsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn activeDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnViewDB;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtbxHiddenID;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnBack;
    }
}