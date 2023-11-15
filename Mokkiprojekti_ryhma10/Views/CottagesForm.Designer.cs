namespace Mokkiprojekti_ryhma10.Views
{
    partial class CottagesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CottagesForm));
            this.label1 = new System.Windows.Forms.Label();
            this.tbSearchByName = new System.Windows.Forms.TextBox();
            this.dgvCottages = new System.Windows.Forms.DataGridView();
            this.CottageId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CottageName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AmountOfPeople = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Post = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amenities = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Area = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cottageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnAddNewArea = new System.Windows.Forms.Button();
            this.cbPostalCode = new System.Windows.Forms.ComboBox();
            this.cbAreas = new System.Windows.Forms.ComboBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.btnDiscard = new System.Windows.Forms.Button();
            this.tbAmenities = new System.Windows.Forms.TextBox();
            this.tbAmount = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCreateNew = new System.Windows.Forms.Button();
            this.tbID = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnMenu = new System.Windows.Forms.Button();
            this.pbManageCottagesLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCottages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cottageBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbManageCottagesLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Location = new System.Drawing.Point(580, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "MANAGE COTTAGES";
            // 
            // tbSearchByName
            // 
            this.tbSearchByName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tbSearchByName.Location = new System.Drawing.Point(12, 216);
            this.tbSearchByName.Name = "tbSearchByName";
            this.tbSearchByName.PlaceholderText = "Search...";
            this.tbSearchByName.Size = new System.Drawing.Size(256, 23);
            this.tbSearchByName.TabIndex = 1;
            this.tbSearchByName.TextChanged += new System.EventHandler(this.tbSearchByName_TextChanged);
            // 
            // dgvCottages
            // 
            this.dgvCottages.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCottages.AutoGenerateColumns = false;
            this.dgvCottages.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCottages.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvCottages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCottages.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CottageId,
            this.CottageName,
            this.Address,
            this.Price,
            this.AmountOfPeople,
            this.Post,
            this.Amenities,
            this.Description,
            this.Area});
            this.dgvCottages.DataSource = this.cottageBindingSource;
            this.dgvCottages.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(122)))), ((int)(((byte)(120)))));
            this.dgvCottages.Location = new System.Drawing.Point(12, 245);
            this.dgvCottages.MultiSelect = false;
            this.dgvCottages.Name = "dgvCottages";
            this.dgvCottages.ReadOnly = true;
            this.dgvCottages.RowTemplate.Height = 25;
            this.dgvCottages.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCottages.Size = new System.Drawing.Size(1195, 197);
            this.dgvCottages.TabIndex = 2;
            this.dgvCottages.SelectionChanged += new System.EventHandler(this.dgvCottages_SelectionChanged);
            // 
            // CottageId
            // 
            this.CottageId.DataPropertyName = "CottageId";
            this.CottageId.HeaderText = "CottageId";
            this.CottageId.Name = "CottageId";
            this.CottageId.ReadOnly = true;
            // 
            // CottageName
            // 
            this.CottageName.DataPropertyName = "CottageName";
            this.CottageName.HeaderText = "Name";
            this.CottageName.Name = "CottageName";
            this.CottageName.ReadOnly = true;
            // 
            // Address
            // 
            this.Address.DataPropertyName = "Address";
            this.Address.HeaderText = "Address";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // AmountOfPeople
            // 
            this.AmountOfPeople.DataPropertyName = "AmountOfPeople";
            this.AmountOfPeople.HeaderText = "Max people";
            this.AmountOfPeople.Name = "AmountOfPeople";
            this.AmountOfPeople.ReadOnly = true;
            // 
            // Post
            // 
            this.Post.DataPropertyName = "Post";
            this.Post.HeaderText = "Post";
            this.Post.Name = "Post";
            this.Post.ReadOnly = true;
            // 
            // Amenities
            // 
            this.Amenities.DataPropertyName = "Amenities";
            this.Amenities.HeaderText = "Amenities";
            this.Amenities.Name = "Amenities";
            this.Amenities.ReadOnly = true;
            // 
            // Description
            // 
            this.Description.DataPropertyName = "Description";
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // Area
            // 
            this.Area.DataPropertyName = "Area";
            this.Area.HeaderText = "ID, Area";
            this.Area.Name = "Area";
            this.Area.ReadOnly = true;
            // 
            // btnAddNewArea
            // 
            this.btnAddNewArea.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAddNewArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.btnAddNewArea.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btnAddNewArea.FlatAppearance.BorderSize = 0;
            this.btnAddNewArea.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.btnAddNewArea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewArea.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAddNewArea.Location = new System.Drawing.Point(968, 545);
            this.btnAddNewArea.Name = "btnAddNewArea";
            this.btnAddNewArea.Size = new System.Drawing.Size(121, 23);
            this.btnAddNewArea.TabIndex = 13;
            this.btnAddNewArea.Text = "Add new area";
            this.btnAddNewArea.UseVisualStyleBackColor = false;
            this.btnAddNewArea.Click += new System.EventHandler(this.btnAddNewArea_Click);
            // 
            // cbPostalCode
            // 
            this.cbPostalCode.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cbPostalCode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbPostalCode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbPostalCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbPostalCode.FormattingEnabled = true;
            this.cbPostalCode.Location = new System.Drawing.Point(505, 544);
            this.cbPostalCode.Name = "cbPostalCode";
            this.cbPostalCode.Size = new System.Drawing.Size(218, 23);
            this.cbPostalCode.TabIndex = 6;
            this.cbPostalCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbPostalCode_KeyPress);
            this.cbPostalCode.Leave += new System.EventHandler(this.cbPostalCode_Leave);
            // 
            // cbAreas
            // 
            this.cbAreas.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cbAreas.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbAreas.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbAreas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbAreas.FormattingEnabled = true;
            this.cbAreas.Location = new System.Drawing.Point(747, 545);
            this.cbAreas.Name = "cbAreas";
            this.cbAreas.Size = new System.Drawing.Size(215, 23);
            this.cbAreas.TabIndex = 7;
            this.cbAreas.Leave += new System.EventHandler(this.cbAreas_Leave);
            // 
            // tbName
            // 
            this.tbName.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tbName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tbName.Location = new System.Drawing.Point(506, 477);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(218, 23);
            this.tbName.TabIndex = 4;
            // 
            // tbAddress
            // 
            this.tbAddress.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tbAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tbAddress.Location = new System.Drawing.Point(268, 544);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(216, 23);
            this.tbAddress.TabIndex = 5;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnDelete.Location = new System.Drawing.Point(582, 781);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(131, 53);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "Delete cottage";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // tbPrice
            // 
            this.tbPrice.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tbPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tbPrice.Location = new System.Drawing.Point(746, 666);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(218, 23);
            this.tbPrice.TabIndex = 11;
            this.tbPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPrice_KeyPress);
            // 
            // tbDescription
            // 
            this.tbDescription.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tbDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tbDescription.Location = new System.Drawing.Point(506, 611);
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(218, 149);
            this.tbDescription.TabIndex = 9;
            // 
            // btnDiscard
            // 
            this.btnDiscard.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDiscard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.btnDiscard.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btnDiscard.FlatAppearance.BorderSize = 0;
            this.btnDiscard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.btnDiscard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDiscard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnDiscard.Location = new System.Drawing.Point(427, 781);
            this.btnDiscard.Name = "btnDiscard";
            this.btnDiscard.Size = new System.Drawing.Size(131, 53);
            this.btnDiscard.TabIndex = 15;
            this.btnDiscard.Text = "Discard changes";
            this.btnDiscard.UseVisualStyleBackColor = false;
            this.btnDiscard.Click += new System.EventHandler(this.btnDiscard_Click);
            // 
            // tbAmenities
            // 
            this.tbAmenities.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tbAmenities.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tbAmenities.Location = new System.Drawing.Point(268, 611);
            this.tbAmenities.Multiline = true;
            this.tbAmenities.Name = "tbAmenities";
            this.tbAmenities.Size = new System.Drawing.Size(218, 149);
            this.tbAmenities.TabIndex = 8;
            // 
            // tbAmount
            // 
            this.tbAmount.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tbAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tbAmount.Location = new System.Drawing.Point(746, 616);
            this.tbAmount.Name = "tbAmount";
            this.tbAmount.Size = new System.Drawing.Size(216, 23);
            this.tbAmount.TabIndex = 10;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSave.Location = new System.Drawing.Point(268, 781);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(131, 53);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Save changes";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCreateNew
            // 
            this.btnCreateNew.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCreateNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.btnCreateNew.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btnCreateNew.FlatAppearance.BorderSize = 0;
            this.btnCreateNew.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.btnCreateNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateNew.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnCreateNew.Location = new System.Drawing.Point(12, 458);
            this.btnCreateNew.Name = "btnCreateNew";
            this.btnCreateNew.Size = new System.Drawing.Size(131, 53);
            this.btnCreateNew.TabIndex = 15;
            this.btnCreateNew.Text = "Create new cottage";
            this.btnCreateNew.UseVisualStyleBackColor = false;
            this.btnCreateNew.Click += new System.EventHandler(this.btnCreateNew_Click);
            // 
            // tbID
            // 
            this.tbID.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tbID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tbID.Location = new System.Drawing.Point(266, 477);
            this.tbID.Name = "tbID";
            this.tbID.ReadOnly = true;
            this.tbID.Size = new System.Drawing.Size(216, 23);
            this.tbID.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(506, 587);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 21);
            this.label11.TabIndex = 8;
            this.label11.Text = "Description";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(506, 453);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 21);
            this.label10.TabIndex = 7;
            this.label10.Text = "Name";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(746, 521);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 21);
            this.label9.TabIndex = 6;
            this.label9.Text = "Area";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(268, 520);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 21);
            this.label8.TabIndex = 5;
            this.label8.Text = "Address";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(506, 519);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 21);
            this.label7.TabIndex = 4;
            this.label7.Text = "Postal code";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(746, 642);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 21);
            this.label6.TabIndex = 3;
            this.label6.Text = "Price";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(746, 591);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 21);
            this.label5.TabIndex = 2;
            this.label5.Text = "Amount of people";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(268, 587);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 21);
            this.label4.TabIndex = 1;
            this.label4.Text = "Amenities";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(261, 453);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "ID";
            // 
            // btnMenu
            // 
            this.btnMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.btnMenu.FlatAppearance.BorderColor = System.Drawing.Color.Olive;
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnMenu.Location = new System.Drawing.Point(1066, 186);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(131, 53);
            this.btnMenu.TabIndex = 17;
            this.btnMenu.Text = "Return to Menu";
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // pbManageCottagesLogo
            // 
            this.pbManageCottagesLogo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pbManageCottagesLogo.Image = global::Mokkiprojekti_ryhma10.Properties.Resources.restagelogotextwhite;
            this.pbManageCottagesLogo.Location = new System.Drawing.Point(427, 131);
            this.pbManageCottagesLogo.Name = "pbManageCottagesLogo";
            this.pbManageCottagesLogo.Size = new System.Drawing.Size(228, 64);
            this.pbManageCottagesLogo.TabIndex = 18;
            this.pbManageCottagesLogo.TabStop = false;
            // 
            // CottagesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(175)))), ((int)(((byte)(169)))));
            this.ClientSize = new System.Drawing.Size(1219, 851);
            this.Controls.Add(this.pbManageCottagesLogo);
            this.Controls.Add(this.btnAddNewArea);
            this.Controls.Add(this.cbPostalCode);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.cbAreas);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.dgvCottages);
            this.Controls.Add(this.tbAddress);
            this.Controls.Add(this.tbSearchByName);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.tbDescription);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnDiscard);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbAmenities);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbAmount);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnCreateNew);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CottagesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cottages";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Cottages_FormClosing);
            this.VisibleChanged += new System.EventHandler(this.Cottages_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCottages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cottageBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbManageCottagesLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox tbSearchByName;
        private DataGridView dgvCottages;
        private Button btnDiscard;
        private Button btnSave;
        private Button btnCreateNew;
        private TextBox tbName;
        private TextBox tbAddress;
        private TextBox tbPrice;
        private TextBox tbDescription;
        private TextBox tbAmenities;
        private TextBox tbAmount;
        private TextBox tbID;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button btnDelete;
        private Button btnMenu;
        private ComboBox cbPostalCode;
        private ComboBox cbAreas;
        private Button btnAddNewArea;
        private BindingSource cottageBindingSource;
        private PictureBox pbManageCottagesLogo;
        private DataGridViewTextBoxColumn CottageId;
        private DataGridViewTextBoxColumn CottageName;
        private DataGridViewTextBoxColumn Address;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn AmountOfPeople;
        private DataGridViewTextBoxColumn Post;
        private DataGridViewTextBoxColumn Amenities;
        private DataGridViewTextBoxColumn Description;
        private DataGridViewTextBoxColumn Area;
    }
}