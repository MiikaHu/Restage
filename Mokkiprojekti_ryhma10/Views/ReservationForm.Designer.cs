namespace Mokkiprojekti_ryhma10.Views
{
    partial class ReservationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReservationForm));
            this.label1 = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtpReservedDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbCottages = new System.Windows.Forms.ComboBox();
            this.cbCustomers = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnReturn = new System.Windows.Forms.Button();
            this.tbReservations_Search = new System.Windows.Forms.TextBox();
            this.btnCreateReservation = new System.Windows.Forms.Button();
            this.dgvReservations = new System.Windows.Forms.DataGridView();
            this.reservationIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cottageIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cottageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reservedStartDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reservedEndDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reservationServicesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reservedDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.confirmationDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoicesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reservationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnDiscard = new System.Windows.Forms.Button();
            this.nudServices = new System.Windows.Forms.NumericUpDown();
            this.cbServices = new System.Windows.Forms.ComboBox();
            this.btnAddService = new System.Windows.Forms.Button();
            this.lbReservationServices = new System.Windows.Forms.ListBox();
            this.btnDeleteSelectedService = new System.Windows.Forms.Button();
            this.tbID = new System.Windows.Forms.TextBox();
            this.btnNewCustomer = new System.Windows.Forms.Button();
            this.cbConfirmation = new System.Windows.Forms.CheckBox();
            this.tbSum = new System.Windows.Forms.TextBox();
            this.labelreservation_ID = new System.Windows.Forms.Label();
            this.labelreservation_cottage = new System.Windows.Forms.Label();
            this.labelreservation_customer = new System.Windows.Forms.Label();
            this.labelreservation_amount = new System.Windows.Forms.Label();
            this.labelreservation_activities = new System.Windows.Forms.Label();
            this.labelreservation_price = new System.Windows.Forms.Label();
            this.labelreservations_reservationactivities = new System.Windows.Forms.Label();
            this.mcStartDate = new System.Windows.Forms.MonthCalendar();
            this.cbVAT = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudServices)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(522, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "MANAGE RESERVATIONS";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.dtpStartDate.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStartDate.Location = new System.Drawing.Point(353, 490);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(120, 23);
            this.dtpStartDate.TabIndex = 1;
            this.dtpStartDate.Value = new System.DateTime(2022, 3, 28, 11, 10, 2, 0);
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.dtpEndDate.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEndDate.Location = new System.Drawing.Point(479, 490);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(120, 23);
            this.dtpEndDate.TabIndex = 2;
            // 
            // dtpReservedDate
            // 
            this.dtpReservedDate.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.dtpReservedDate.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dtpReservedDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpReservedDate.Location = new System.Drawing.Point(753, 664);
            this.dtpReservedDate.Name = "dtpReservedDate";
            this.dtpReservedDate.Size = new System.Drawing.Size(120, 23);
            this.dtpReservedDate.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(351, 466);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Start date";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(479, 466);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 21);
            this.label6.TabIndex = 8;
            this.label6.Text = "End date";
            // 
            // cbCottages
            // 
            this.cbCottages.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cbCottages.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbCottages.FormattingEnabled = true;
            this.cbCottages.Location = new System.Drawing.Point(165, 552);
            this.cbCottages.Name = "cbCottages";
            this.cbCottages.Size = new System.Drawing.Size(141, 23);
            this.cbCottages.TabIndex = 18;
            this.cbCottages.SelectedValueChanged += new System.EventHandler(this.cbCottages_SelectedValueChanged);
            // 
            // cbCustomers
            // 
            this.cbCustomers.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cbCustomers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbCustomers.FormattingEnabled = true;
            this.cbCustomers.Location = new System.Drawing.Point(167, 607);
            this.cbCustomers.Name = "cbCustomers";
            this.cbCustomers.Size = new System.Drawing.Size(141, 23);
            this.cbCustomers.TabIndex = 19;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = global::Mokkiprojekti_ryhma10.Properties.Resources.restagelogotextwhite;
            this.pictureBox1.Location = new System.Drawing.Point(392, 110);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(233, 58);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // btnReturn
            // 
            this.btnReturn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.btnReturn.FlatAppearance.BorderSize = 0;
            this.btnReturn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.btnReturn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(122)))), ((int)(((byte)(120)))));
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnReturn.Location = new System.Drawing.Point(975, 149);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(160, 47);
            this.btnReturn.TabIndex = 22;
            this.btnReturn.Text = "Return to Menu";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // tbReservations_Search
            // 
            this.tbReservations_Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tbReservations_Search.Location = new System.Drawing.Point(22, 173);
            this.tbReservations_Search.Name = "tbReservations_Search";
            this.tbReservations_Search.PlaceholderText = "Search...";
            this.tbReservations_Search.Size = new System.Drawing.Size(275, 23);
            this.tbReservations_Search.TabIndex = 24;
            this.tbReservations_Search.TextChanged += new System.EventHandler(this.tbReservations_Search_TextChanged);
            // 
            // btnCreateReservation
            // 
            this.btnCreateReservation.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCreateReservation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.btnCreateReservation.FlatAppearance.BorderSize = 0;
            this.btnCreateReservation.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.btnCreateReservation.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(122)))), ((int)(((byte)(120)))));
            this.btnCreateReservation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateReservation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnCreateReservation.Location = new System.Drawing.Point(22, 459);
            this.btnCreateReservation.Name = "btnCreateReservation";
            this.btnCreateReservation.Size = new System.Drawing.Size(162, 46);
            this.btnCreateReservation.TabIndex = 26;
            this.btnCreateReservation.Text = "Create New Reservation";
            this.btnCreateReservation.UseVisualStyleBackColor = false;
            this.btnCreateReservation.Click += new System.EventHandler(this.btnCreateReservation_Click);
            // 
            // dgvReservations
            // 
            this.dgvReservations.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvReservations.AutoGenerateColumns = false;
            this.dgvReservations.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReservations.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvReservations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReservations.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.reservationIdDataGridViewTextBoxColumn,
            this.customerIdDataGridViewTextBoxColumn,
            this.cottageIdDataGridViewTextBoxColumn,
            this.customerDataGridViewTextBoxColumn,
            this.cottageDataGridViewTextBoxColumn,
            this.reservedStartDateDataGridViewTextBoxColumn,
            this.reservedEndDateDataGridViewTextBoxColumn,
            this.reservationServicesDataGridViewTextBoxColumn,
            this.reservedDateDataGridViewTextBoxColumn,
            this.confirmationDateDataGridViewTextBoxColumn,
            this.invoicesDataGridViewTextBoxColumn});
            this.dgvReservations.DataSource = this.reservationBindingSource;
            this.dgvReservations.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(175)))), ((int)(((byte)(169)))));
            this.dgvReservations.Location = new System.Drawing.Point(22, 204);
            this.dgvReservations.MultiSelect = false;
            this.dgvReservations.Name = "dgvReservations";
            this.dgvReservations.ReadOnly = true;
            this.dgvReservations.RowTemplate.Height = 25;
            this.dgvReservations.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReservations.Size = new System.Drawing.Size(1113, 249);
            this.dgvReservations.TabIndex = 27;
            this.dgvReservations.SelectionChanged += new System.EventHandler(this.dgvReservations_SelectionChanged);
            // 
            // reservationIdDataGridViewTextBoxColumn
            // 
            this.reservationIdDataGridViewTextBoxColumn.DataPropertyName = "ReservationId";
            this.reservationIdDataGridViewTextBoxColumn.HeaderText = "ReservationId";
            this.reservationIdDataGridViewTextBoxColumn.Name = "reservationIdDataGridViewTextBoxColumn";
            this.reservationIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customerIdDataGridViewTextBoxColumn
            // 
            this.customerIdDataGridViewTextBoxColumn.DataPropertyName = "CustomerId";
            this.customerIdDataGridViewTextBoxColumn.HeaderText = "CustomerId";
            this.customerIdDataGridViewTextBoxColumn.Name = "customerIdDataGridViewTextBoxColumn";
            this.customerIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cottageIdDataGridViewTextBoxColumn
            // 
            this.cottageIdDataGridViewTextBoxColumn.DataPropertyName = "CottageId";
            this.cottageIdDataGridViewTextBoxColumn.HeaderText = "CottageId";
            this.cottageIdDataGridViewTextBoxColumn.Name = "cottageIdDataGridViewTextBoxColumn";
            this.cottageIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customerDataGridViewTextBoxColumn
            // 
            this.customerDataGridViewTextBoxColumn.DataPropertyName = "Customer";
            this.customerDataGridViewTextBoxColumn.HeaderText = "Customer";
            this.customerDataGridViewTextBoxColumn.Name = "customerDataGridViewTextBoxColumn";
            this.customerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cottageDataGridViewTextBoxColumn
            // 
            this.cottageDataGridViewTextBoxColumn.DataPropertyName = "Cottage";
            this.cottageDataGridViewTextBoxColumn.HeaderText = "Cottage";
            this.cottageDataGridViewTextBoxColumn.Name = "cottageDataGridViewTextBoxColumn";
            this.cottageDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // reservedStartDateDataGridViewTextBoxColumn
            // 
            this.reservedStartDateDataGridViewTextBoxColumn.DataPropertyName = "ReservedStartDate";
            this.reservedStartDateDataGridViewTextBoxColumn.HeaderText = "ReservedStartDate";
            this.reservedStartDateDataGridViewTextBoxColumn.Name = "reservedStartDateDataGridViewTextBoxColumn";
            this.reservedStartDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // reservedEndDateDataGridViewTextBoxColumn
            // 
            this.reservedEndDateDataGridViewTextBoxColumn.DataPropertyName = "ReservedEndDate";
            this.reservedEndDateDataGridViewTextBoxColumn.HeaderText = "ReservedEndDate";
            this.reservedEndDateDataGridViewTextBoxColumn.Name = "reservedEndDateDataGridViewTextBoxColumn";
            this.reservedEndDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // reservationServicesDataGridViewTextBoxColumn
            // 
            this.reservationServicesDataGridViewTextBoxColumn.DataPropertyName = "ReservationServices";
            this.reservationServicesDataGridViewTextBoxColumn.HeaderText = "ReservationServices";
            this.reservationServicesDataGridViewTextBoxColumn.Name = "reservationServicesDataGridViewTextBoxColumn";
            this.reservationServicesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // reservedDateDataGridViewTextBoxColumn
            // 
            this.reservedDateDataGridViewTextBoxColumn.DataPropertyName = "ReservedDate";
            this.reservedDateDataGridViewTextBoxColumn.HeaderText = "ReservedDate";
            this.reservedDateDataGridViewTextBoxColumn.Name = "reservedDateDataGridViewTextBoxColumn";
            this.reservedDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // confirmationDateDataGridViewTextBoxColumn
            // 
            this.confirmationDateDataGridViewTextBoxColumn.DataPropertyName = "ConfirmationDate";
            this.confirmationDateDataGridViewTextBoxColumn.HeaderText = "ConfirmationDate";
            this.confirmationDateDataGridViewTextBoxColumn.Name = "confirmationDateDataGridViewTextBoxColumn";
            this.confirmationDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // invoicesDataGridViewTextBoxColumn
            // 
            this.invoicesDataGridViewTextBoxColumn.DataPropertyName = "Invoices";
            this.invoicesDataGridViewTextBoxColumn.HeaderText = "Invoices";
            this.invoicesDataGridViewTextBoxColumn.Name = "invoicesDataGridViewTextBoxColumn";
            this.invoicesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // reservationBindingSource
            // 
            this.reservationBindingSource.DataSource = typeof(Mokkiprojekti_ryhma10.Reservation);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(122)))), ((int)(((byte)(120)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSave.Location = new System.Drawing.Point(35, 699);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(162, 43);
            this.btnSave.TabIndex = 29;
            this.btnSave.Text = "Save changes";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(122)))), ((int)(((byte)(120)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnDelete.Location = new System.Drawing.Point(370, 699);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(141, 43);
            this.btnDelete.TabIndex = 30;
            this.btnDelete.Text = "Delete reservation";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnDiscard
            // 
            this.btnDiscard.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDiscard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.btnDiscard.FlatAppearance.BorderSize = 0;
            this.btnDiscard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.btnDiscard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(122)))), ((int)(((byte)(120)))));
            this.btnDiscard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDiscard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnDiscard.Location = new System.Drawing.Point(204, 699);
            this.btnDiscard.Name = "btnDiscard";
            this.btnDiscard.Size = new System.Drawing.Size(160, 44);
            this.btnDiscard.TabIndex = 32;
            this.btnDiscard.Text = "Discard changes";
            this.btnDiscard.UseVisualStyleBackColor = false;
            this.btnDiscard.Click += new System.EventHandler(this.btnDiscard_Click);
            // 
            // nudServices
            // 
            this.nudServices.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.nudServices.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.nudServices.Location = new System.Drawing.Point(699, 517);
            this.nudServices.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudServices.Name = "nudServices";
            this.nudServices.Size = new System.Drawing.Size(71, 23);
            this.nudServices.TabIndex = 33;
            this.nudServices.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cbServices
            // 
            this.cbServices.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cbServices.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbServices.FormattingEnabled = true;
            this.cbServices.Location = new System.Drawing.Point(643, 488);
            this.cbServices.Name = "cbServices";
            this.cbServices.Size = new System.Drawing.Size(127, 23);
            this.cbServices.TabIndex = 34;
            // 
            // btnAddService
            // 
            this.btnAddService.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAddService.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.btnAddService.FlatAppearance.BorderSize = 0;
            this.btnAddService.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.btnAddService.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(122)))), ((int)(((byte)(120)))));
            this.btnAddService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddService.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAddService.Location = new System.Drawing.Point(776, 488);
            this.btnAddService.Name = "btnAddService";
            this.btnAddService.Size = new System.Drawing.Size(129, 27);
            this.btnAddService.TabIndex = 35;
            this.btnAddService.Text = "Add New Activity";
            this.btnAddService.UseVisualStyleBackColor = false;
            this.btnAddService.Click += new System.EventHandler(this.btnAddService_Click);
            // 
            // lbReservationServices
            // 
            this.lbReservationServices.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbReservationServices.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lbReservationServices.FormattingEnabled = true;
            this.lbReservationServices.ItemHeight = 15;
            this.lbReservationServices.Location = new System.Drawing.Point(911, 490);
            this.lbReservationServices.Name = "lbReservationServices";
            this.lbReservationServices.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbReservationServices.Size = new System.Drawing.Size(152, 124);
            this.lbReservationServices.TabIndex = 39;
            // 
            // btnDeleteSelectedService
            // 
            this.btnDeleteSelectedService.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDeleteSelectedService.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.btnDeleteSelectedService.FlatAppearance.BorderSize = 0;
            this.btnDeleteSelectedService.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.btnDeleteSelectedService.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(122)))), ((int)(((byte)(120)))));
            this.btnDeleteSelectedService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteSelectedService.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnDeleteSelectedService.Location = new System.Drawing.Point(776, 521);
            this.btnDeleteSelectedService.Name = "btnDeleteSelectedService";
            this.btnDeleteSelectedService.Size = new System.Drawing.Size(129, 27);
            this.btnDeleteSelectedService.TabIndex = 40;
            this.btnDeleteSelectedService.Text = "Delete Activity";
            this.btnDeleteSelectedService.UseVisualStyleBackColor = false;
            this.btnDeleteSelectedService.Click += new System.EventHandler(this.btnDeleteSelectedService_Click);
            // 
            // tbID
            // 
            this.tbID.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tbID.Location = new System.Drawing.Point(49, 552);
            this.tbID.Name = "tbID";
            this.tbID.ReadOnly = true;
            this.tbID.Size = new System.Drawing.Size(106, 23);
            this.tbID.TabIndex = 41;
            // 
            // btnNewCustomer
            // 
            this.btnNewCustomer.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnNewCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.btnNewCustomer.FlatAppearance.BorderSize = 0;
            this.btnNewCustomer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.btnNewCustomer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(122)))), ((int)(((byte)(120)))));
            this.btnNewCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewCustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnNewCustomer.Location = new System.Drawing.Point(51, 607);
            this.btnNewCustomer.Name = "btnNewCustomer";
            this.btnNewCustomer.Size = new System.Drawing.Size(106, 22);
            this.btnNewCustomer.TabIndex = 42;
            this.btnNewCustomer.Text = "New customer";
            this.btnNewCustomer.UseVisualStyleBackColor = false;
            this.btnNewCustomer.Click += new System.EventHandler(this.btnNewCustomer_Click);
            // 
            // cbConfirmation
            // 
            this.cbConfirmation.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cbConfirmation.AutoSize = true;
            this.cbConfirmation.Location = new System.Drawing.Point(664, 668);
            this.cbConfirmation.Name = "cbConfirmation";
            this.cbConfirmation.Size = new System.Drawing.Size(83, 19);
            this.cbConfirmation.TabIndex = 43;
            this.cbConfirmation.Text = "Confirmed";
            this.cbConfirmation.UseVisualStyleBackColor = true;
            // 
            // tbSum
            // 
            this.tbSum.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tbSum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tbSum.Location = new System.Drawing.Point(663, 629);
            this.tbSum.Name = "tbSum";
            this.tbSum.Size = new System.Drawing.Size(135, 23);
            this.tbSum.TabIndex = 44;
            // 
            // labelreservation_ID
            // 
            this.labelreservation_ID.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelreservation_ID.AutoSize = true;
            this.labelreservation_ID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelreservation_ID.Location = new System.Drawing.Point(46, 528);
            this.labelreservation_ID.Name = "labelreservation_ID";
            this.labelreservation_ID.Size = new System.Drawing.Size(111, 21);
            this.labelreservation_ID.TabIndex = 45;
            this.labelreservation_ID.Text = "Reservation ID";
            // 
            // labelreservation_cottage
            // 
            this.labelreservation_cottage.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelreservation_cottage.AutoSize = true;
            this.labelreservation_cottage.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelreservation_cottage.Location = new System.Drawing.Point(164, 528);
            this.labelreservation_cottage.Name = "labelreservation_cottage";
            this.labelreservation_cottage.Size = new System.Drawing.Size(64, 21);
            this.labelreservation_cottage.TabIndex = 46;
            this.labelreservation_cottage.Text = "Cottage";
            // 
            // labelreservation_customer
            // 
            this.labelreservation_customer.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelreservation_customer.AutoSize = true;
            this.labelreservation_customer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelreservation_customer.Location = new System.Drawing.Point(163, 583);
            this.labelreservation_customer.Name = "labelreservation_customer";
            this.labelreservation_customer.Size = new System.Drawing.Size(78, 21);
            this.labelreservation_customer.TabIndex = 47;
            this.labelreservation_customer.Text = "Customer";
            // 
            // labelreservation_amount
            // 
            this.labelreservation_amount.AllowDrop = true;
            this.labelreservation_amount.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelreservation_amount.AutoSize = true;
            this.labelreservation_amount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelreservation_amount.Location = new System.Drawing.Point(631, 517);
            this.labelreservation_amount.Name = "labelreservation_amount";
            this.labelreservation_amount.Size = new System.Drawing.Size(66, 21);
            this.labelreservation_amount.TabIndex = 48;
            this.labelreservation_amount.Text = "Amount";
            // 
            // labelreservation_activities
            // 
            this.labelreservation_activities.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelreservation_activities.AutoSize = true;
            this.labelreservation_activities.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelreservation_activities.Location = new System.Drawing.Point(641, 466);
            this.labelreservation_activities.Name = "labelreservation_activities";
            this.labelreservation_activities.Size = new System.Drawing.Size(61, 21);
            this.labelreservation_activities.TabIndex = 49;
            this.labelreservation_activities.Text = "Activity";
            // 
            // labelreservation_price
            // 
            this.labelreservation_price.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelreservation_price.AutoSize = true;
            this.labelreservation_price.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelreservation_price.Location = new System.Drawing.Point(663, 605);
            this.labelreservation_price.Name = "labelreservation_price";
            this.labelreservation_price.Size = new System.Drawing.Size(44, 21);
            this.labelreservation_price.TabIndex = 50;
            this.labelreservation_price.Text = "Price";
            // 
            // labelreservations_reservationactivities
            // 
            this.labelreservations_reservationactivities.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelreservations_reservationactivities.AutoSize = true;
            this.labelreservations_reservationactivities.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelreservations_reservationactivities.Location = new System.Drawing.Point(909, 465);
            this.labelreservations_reservationactivities.Name = "labelreservations_reservationactivities";
            this.labelreservations_reservationactivities.Size = new System.Drawing.Size(158, 21);
            this.labelreservations_reservationactivities.TabIndex = 51;
            this.labelreservations_reservationactivities.Text = "Reservation Activities";
            // 
            // mcStartDate
            // 
            this.mcStartDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.mcStartDate.Location = new System.Drawing.Point(355, 525);
            this.mcStartDate.Name = "mcStartDate";
            this.mcStartDate.TabIndex = 52;
            // 
            // cbVAT
            // 
            this.cbVAT.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cbVAT.AutoSize = true;
            this.cbVAT.Checked = true;
            this.cbVAT.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbVAT.Location = new System.Drawing.Point(800, 631);
            this.cbVAT.Name = "cbVAT";
            this.cbVAT.Size = new System.Drawing.Size(45, 19);
            this.cbVAT.TabIndex = 55;
            this.cbVAT.Text = "VAT";
            this.cbVAT.UseVisualStyleBackColor = true;
            // 
            // ReservationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(175)))), ((int)(((byte)(169)))));
            this.ClientSize = new System.Drawing.Size(1153, 755);
            this.Controls.Add(this.cbVAT);
            this.Controls.Add(this.mcStartDate);
            this.Controls.Add(this.labelreservations_reservationactivities);
            this.Controls.Add(this.labelreservation_price);
            this.Controls.Add(this.labelreservation_activities);
            this.Controls.Add(this.labelreservation_amount);
            this.Controls.Add(this.labelreservation_customer);
            this.Controls.Add(this.labelreservation_cottage);
            this.Controls.Add(this.labelreservation_ID);
            this.Controls.Add(this.tbSum);
            this.Controls.Add(this.cbConfirmation);
            this.Controls.Add(this.btnNewCustomer);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.btnDeleteSelectedService);
            this.Controls.Add(this.lbReservationServices);
            this.Controls.Add(this.btnAddService);
            this.Controls.Add(this.cbServices);
            this.Controls.Add(this.nudServices);
            this.Controls.Add(this.btnDiscard);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dgvReservations);
            this.Controls.Add(this.btnCreateReservation);
            this.Controls.Add(this.tbReservations_Search);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cbCustomers);
            this.Controls.Add(this.cbCottages);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpReservedDate);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReservationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reservations";
            this.VisibleChanged += new System.EventHandler(this.ReservationForm_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudServices)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private DateTimePicker dtpStartDate;
        private DateTimePicker dtpEndDate;
        private DateTimePicker dtpReservedDate;
        private Label label2;
        private Label label6;
        private ComboBox cbCottages;
        private ComboBox cbCustomers;
        private PictureBox pictureBox1;
        private Button btnReturn;
        private TextBox tbReservations_Search;
        private Button btnCreateReservation;
        private DataGridView dgvReservations;
        private Button btnSave;
        private Button btnDelete;
        private Button btnDiscard;
        private NumericUpDown nudServices;
        private ComboBox cbServices;
        private Button btnAddService;
        private BindingSource reservationBindingSource;
        private DataGridViewTextBoxColumn reservationIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn customerIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cottageIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn customerDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cottageDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn reservedStartDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn reservedEndDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn reservationServicesDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn reservedDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn confirmationDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn invoicesDataGridViewTextBoxColumn;
        private CheckedListBox checkedListBox1;
        private ListBox lbReservationServices;
        private Button btnDeleteSelectedService;
        private TextBox tbID;
        private Button btnNewCustomer;
        private CheckBox cbConfirmation;
        private TextBox tbSum;
        private Label labelreservation_ID;
        private Label labelreservation_cottage;
        private Label labelreservation_customer;
        private Label labelreservation_amount;
        private Label labelreservation_activities;
        private Label labelreservation_price;
        private Label labelreservations_reservationactivities;
        private MonthCalendar mcStartDate;
        private CheckBox cbVAT;
    }
}