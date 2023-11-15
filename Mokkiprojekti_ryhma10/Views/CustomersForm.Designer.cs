namespace Mokkiprojekti_ryhma10.Views
{
    partial class CustomersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomersForm));
            this.btn_Delete = new System.Windows.Forms.Button();
            this.cbPostalCode = new System.Windows.Forms.ComboBox();
            this.tbPhoneNumber_Customers = new System.Windows.Forms.TextBox();
            this.tbAddress_Customers = new System.Windows.Forms.TextBox();
            this.tbEmail_Customers = new System.Windows.Forms.TextBox();
            this.tbLastName_Customers = new System.Windows.Forms.TextBox();
            this.tbFirstName_Customers = new System.Windows.Forms.TextBox();
            this.tbID_Customers = new System.Windows.Forms.TextBox();
            this.btnDiscard_Customers = new System.Windows.Forms.Button();
            this.btnSave_Customers = new System.Windows.Forms.Button();
            this.btnCreateNew_Customers = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.postBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgvCustomers = new System.Windows.Forms.DataGridView();
            this.customerIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phonenumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbNameSearch_Customers = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMenu = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pbManageCustomerslogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.postBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbManageCustomerslogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Delete
            // 
            this.btn_Delete.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.btn_Delete.FlatAppearance.BorderSize = 0;
            this.btn_Delete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.btn_Delete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(122)))), ((int)(((byte)(120)))));
            this.btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Delete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_Delete.Location = new System.Drawing.Point(735, 703);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(148, 56);
            this.btn_Delete.TabIndex = 13;
            this.btn_Delete.Text = "Delete customer";
            this.btn_Delete.UseVisualStyleBackColor = false;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // cbPostalCode
            // 
            this.cbPostalCode.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cbPostalCode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbPostalCode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbPostalCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbPostalCode.FormattingEnabled = true;
            this.cbPostalCode.Location = new System.Drawing.Point(579, 633);
            this.cbPostalCode.Name = "cbPostalCode";
            this.cbPostalCode.Size = new System.Drawing.Size(148, 23);
            this.cbPostalCode.TabIndex = 7;
            this.cbPostalCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbPostalCode_KeyPress);
            // 
            // tbPhoneNumber_Customers
            // 
            this.tbPhoneNumber_Customers.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tbPhoneNumber_Customers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tbPhoneNumber_Customers.Location = new System.Drawing.Point(734, 633);
            this.tbPhoneNumber_Customers.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbPhoneNumber_Customers.Name = "tbPhoneNumber_Customers";
            this.tbPhoneNumber_Customers.Size = new System.Drawing.Size(148, 23);
            this.tbPhoneNumber_Customers.TabIndex = 8;
            // 
            // tbAddress_Customers
            // 
            this.tbAddress_Customers.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tbAddress_Customers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tbAddress_Customers.Location = new System.Drawing.Point(409, 633);
            this.tbAddress_Customers.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbAddress_Customers.Name = "tbAddress_Customers";
            this.tbAddress_Customers.Size = new System.Drawing.Size(148, 23);
            this.tbAddress_Customers.TabIndex = 6;
            // 
            // tbEmail_Customers
            // 
            this.tbEmail_Customers.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tbEmail_Customers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tbEmail_Customers.Location = new System.Drawing.Point(734, 577);
            this.tbEmail_Customers.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbEmail_Customers.Name = "tbEmail_Customers";
            this.tbEmail_Customers.Size = new System.Drawing.Size(148, 23);
            this.tbEmail_Customers.TabIndex = 5;
            // 
            // tbLastName_Customers
            // 
            this.tbLastName_Customers.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tbLastName_Customers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tbLastName_Customers.Location = new System.Drawing.Point(578, 577);
            this.tbLastName_Customers.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbLastName_Customers.Name = "tbLastName_Customers";
            this.tbLastName_Customers.Size = new System.Drawing.Size(148, 23);
            this.tbLastName_Customers.TabIndex = 4;
            // 
            // tbFirstName_Customers
            // 
            this.tbFirstName_Customers.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tbFirstName_Customers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tbFirstName_Customers.Location = new System.Drawing.Point(417, 577);
            this.tbFirstName_Customers.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbFirstName_Customers.Name = "tbFirstName_Customers";
            this.tbFirstName_Customers.Size = new System.Drawing.Size(148, 23);
            this.tbFirstName_Customers.TabIndex = 3;
            // 
            // tbID_Customers
            // 
            this.tbID_Customers.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tbID_Customers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tbID_Customers.Enabled = false;
            this.tbID_Customers.Location = new System.Drawing.Point(247, 577);
            this.tbID_Customers.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbID_Customers.Name = "tbID_Customers";
            this.tbID_Customers.ReadOnly = true;
            this.tbID_Customers.Size = new System.Drawing.Size(148, 23);
            this.tbID_Customers.TabIndex = 2;
            // 
            // btnDiscard_Customers
            // 
            this.btnDiscard_Customers.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDiscard_Customers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.btnDiscard_Customers.FlatAppearance.BorderSize = 0;
            this.btnDiscard_Customers.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.btnDiscard_Customers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(122)))), ((int)(((byte)(120)))));
            this.btnDiscard_Customers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDiscard_Customers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnDiscard_Customers.Location = new System.Drawing.Point(567, 703);
            this.btnDiscard_Customers.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDiscard_Customers.Name = "btnDiscard_Customers";
            this.btnDiscard_Customers.Size = new System.Drawing.Size(148, 55);
            this.btnDiscard_Customers.TabIndex = 12;
            this.btnDiscard_Customers.Text = "Discard changes";
            this.btnDiscard_Customers.UseVisualStyleBackColor = false;
            this.btnDiscard_Customers.Click += new System.EventHandler(this.btnDiscard_Customers_Click);
            // 
            // btnSave_Customers
            // 
            this.btnSave_Customers.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSave_Customers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.btnSave_Customers.FlatAppearance.BorderSize = 0;
            this.btnSave_Customers.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.btnSave_Customers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(122)))), ((int)(((byte)(120)))));
            this.btnSave_Customers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave_Customers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSave_Customers.Location = new System.Drawing.Point(399, 703);
            this.btnSave_Customers.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSave_Customers.Name = "btnSave_Customers";
            this.btnSave_Customers.Size = new System.Drawing.Size(148, 53);
            this.btnSave_Customers.TabIndex = 11;
            this.btnSave_Customers.Text = "Save changes";
            this.btnSave_Customers.UseVisualStyleBackColor = false;
            this.btnSave_Customers.Click += new System.EventHandler(this.btnSave_Customers_Click);
            // 
            // btnCreateNew_Customers
            // 
            this.btnCreateNew_Customers.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCreateNew_Customers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.btnCreateNew_Customers.FlatAppearance.BorderSize = 0;
            this.btnCreateNew_Customers.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.btnCreateNew_Customers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(122)))), ((int)(((byte)(120)))));
            this.btnCreateNew_Customers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateNew_Customers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnCreateNew_Customers.Location = new System.Drawing.Point(13, 550);
            this.btnCreateNew_Customers.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCreateNew_Customers.Name = "btnCreateNew_Customers";
            this.btnCreateNew_Customers.Size = new System.Drawing.Size(131, 47);
            this.btnCreateNew_Customers.TabIndex = 9;
            this.btnCreateNew_Customers.Text = "Create new customer";
            this.btnCreateNew_Customers.UseVisualStyleBackColor = false;
            this.btnCreateNew_Customers.Click += new System.EventHandler(this.btnCreateNew_Customers_Click);
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(409, 613);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 21);
            this.label11.TabIndex = 8;
            this.label11.Text = "Address";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(734, 615);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(113, 21);
            this.label10.TabIndex = 7;
            this.label10.Text = "Phone number";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(579, 615);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 21);
            this.label9.TabIndex = 6;
            this.label9.Text = "Postal code";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(734, 553);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 21);
            this.label6.TabIndex = 3;
            this.label6.Text = "E-mail";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(578, 553);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 21);
            this.label5.TabIndex = 2;
            this.label5.Text = "Last name";
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(417, 553);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(83, 21);
            this.label15.TabIndex = 1;
            this.label15.Text = "First name";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(247, 553);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 21);
            this.label8.TabIndex = 0;
            this.label8.Text = "ID";
            // 
            // postBindingSource
            // 
            this.postBindingSource.DataSource = typeof(Mokkiprojekti_ryhma10.Post);
            // 
            // dgvCustomers
            // 
            this.dgvCustomers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCustomers.AutoGenerateColumns = false;
            this.dgvCustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCustomers.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerIdDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.postDataGridViewTextBoxColumn,
            this.phonenumberDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn});
            this.dgvCustomers.DataSource = this.customerBindingSource;
            this.dgvCustomers.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(175)))), ((int)(((byte)(169)))));
            this.dgvCustomers.Location = new System.Drawing.Point(13, 262);
            this.dgvCustomers.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvCustomers.MultiSelect = false;
            this.dgvCustomers.Name = "dgvCustomers";
            this.dgvCustomers.ReadOnly = true;
            this.dgvCustomers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCustomers.Size = new System.Drawing.Size(1152, 280);
            this.dgvCustomers.TabIndex = 13;
            this.dgvCustomers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomers_CellClick);
            // 
            // customerIdDataGridViewTextBoxColumn
            // 
            this.customerIdDataGridViewTextBoxColumn.DataPropertyName = "CustomerId";
            this.customerIdDataGridViewTextBoxColumn.FillWeight = 40.60914F;
            this.customerIdDataGridViewTextBoxColumn.HeaderText = "Id";
            this.customerIdDataGridViewTextBoxColumn.Name = "customerIdDataGridViewTextBoxColumn";
            this.customerIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.FillWeight = 108.4844F;
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "First name";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.FillWeight = 108.4844F;
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "Last name";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.FillWeight = 108.4844F;
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // postDataGridViewTextBoxColumn
            // 
            this.postDataGridViewTextBoxColumn.DataPropertyName = "Post";
            this.postDataGridViewTextBoxColumn.FillWeight = 108.4844F;
            this.postDataGridViewTextBoxColumn.HeaderText = "Postal code";
            this.postDataGridViewTextBoxColumn.Name = "postDataGridViewTextBoxColumn";
            this.postDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // phonenumberDataGridViewTextBoxColumn
            // 
            this.phonenumberDataGridViewTextBoxColumn.DataPropertyName = "Phonenumber";
            this.phonenumberDataGridViewTextBoxColumn.FillWeight = 108.4844F;
            this.phonenumberDataGridViewTextBoxColumn.HeaderText = "Phone number";
            this.phonenumberDataGridViewTextBoxColumn.Name = "phonenumberDataGridViewTextBoxColumn";
            this.phonenumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.FillWeight = 108.4844F;
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataSource = typeof(Mokkiprojekti_ryhma10.Customer);
            // 
            // tbNameSearch_Customers
            // 
            this.tbNameSearch_Customers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tbNameSearch_Customers.Location = new System.Drawing.Point(13, 233);
            this.tbNameSearch_Customers.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbNameSearch_Customers.Name = "tbNameSearch_Customers";
            this.tbNameSearch_Customers.PlaceholderText = "Search...";
            this.tbNameSearch_Customers.Size = new System.Drawing.Size(284, 23);
            this.tbNameSearch_Customers.TabIndex = 1;
            this.tbNameSearch_Customers.TextChanged += new System.EventHandler(this.tbNameSearch_Customers_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(123, -115);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "MANAGE CUSTOMERS";
            // 
            // btnMenu
            // 
            this.btnMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.btnMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(122)))), ((int)(((byte)(120)))));
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnMenu.Location = new System.Drawing.Point(1021, 193);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(139, 62);
            this.btnMenu.TabIndex = 14;
            this.btnMenu.Text = "Return to Menu";
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(557, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(227, 30);
            this.label3.TabIndex = 19;
            this.label3.Text = "MANAGE CUSTOMERS";
            // 
            // pbManageCustomerslogo
            // 
            this.pbManageCustomerslogo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pbManageCustomerslogo.Image = global::Mokkiprojekti_ryhma10.Properties.Resources.restagelogotextwhite;
            this.pbManageCustomerslogo.Location = new System.Drawing.Point(424, 147);
            this.pbManageCustomerslogo.Name = "pbManageCustomerslogo";
            this.pbManageCustomerslogo.Size = new System.Drawing.Size(228, 62);
            this.pbManageCustomerslogo.TabIndex = 20;
            this.pbManageCustomerslogo.TabStop = false;
            // 
            // CustomersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(175)))), ((int)(((byte)(169)))));
            this.ClientSize = new System.Drawing.Size(1186, 804);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.pbManageCustomerslogo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbPostalCode);
            this.Controls.Add(this.tbPhoneNumber_Customers);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.tbAddress_Customers);
            this.Controls.Add(this.tbEmail_Customers);
            this.Controls.Add(this.dgvCustomers);
            this.Controls.Add(this.tbLastName_Customers);
            this.Controls.Add(this.tbNameSearch_Customers);
            this.Controls.Add(this.tbFirstName_Customers);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbID_Customers);
            this.Controls.Add(this.btnSave_Customers);
            this.Controls.Add(this.btnDiscard_Customers);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.btnCreateNew_Customers);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CustomersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customers";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CustomersForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.postBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbManageCustomerslogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox tbPhoneNumber_Customers;
        private TextBox tbAddress_Customers;
        private TextBox tbEmail_Customers;
        private TextBox tbLastName_Customers;
        private TextBox tbFirstName_Customers;
        private TextBox tbID_Customers;
        private Button btnDiscard_Customers;
        private Button btnSave_Customers;
        private Button btnCreateNew_Customers;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label6;
        private Label label5;
        private Label label15;
        private Label label8;
        private DataGridView dgvCustomers;
        private TextBox tbNameSearch_Customers;
        private Label label1;
        private BindingSource postBindingSource;
        private Button btnMenu;
        private BindingSource customerBindingSource;
        private ComboBox cbPostalCode;
        private DataGridViewTextBoxColumn customerIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn postDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn phonenumberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private Label label3;
        private PictureBox pbManageCustomerslogo;
        private Button btn_Delete;
    }
}