namespace Mokkiprojekti_ryhma10.Views
{
    partial class ServicesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServicesForm));
            this.dgvServices = new System.Windows.Forms.DataGridView();
            this.serviceIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.areaIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.areaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbNameSearch_Activities = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMenu = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnNewArea = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.cbAreas = new System.Windows.Forms.ComboBox();
            this.tbALV_Activities = new System.Windows.Forms.TextBox();
            this.tbType_Activities = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbDescription_Activities = new System.Windows.Forms.TextBox();
            this.tbPrice_Activities = new System.Windows.Forms.TextBox();
            this.tbName_Activities = new System.Windows.Forms.TextBox();
            this.tbID_Activities = new System.Windows.Forms.TextBox();
            this.btnDiscard_Activities = new System.Windows.Forms.Button();
            this.btnSave_Activities = new System.Windows.Forms.Button();
            this.btnCreateNew_Activities = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvServices
            // 
            this.dgvServices.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvServices.AutoGenerateColumns = false;
            this.dgvServices.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvServices.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvServices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServices.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.serviceIdDataGridViewTextBoxColumn,
            this.areaIdDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.vatDataGridViewTextBoxColumn,
            this.areaDataGridViewTextBoxColumn});
            this.dgvServices.DataSource = this.serviceBindingSource;
            this.dgvServices.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(175)))), ((int)(((byte)(169)))));
            this.dgvServices.Location = new System.Drawing.Point(44, 289);
            this.dgvServices.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvServices.Name = "dgvServices";
            this.dgvServices.ReadOnly = true;
            this.dgvServices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvServices.Size = new System.Drawing.Size(980, 200);
            this.dgvServices.TabIndex = 15;
            this.dgvServices.SelectionChanged += new System.EventHandler(this.dgvServices_SelectionChanged);
            // 
            // serviceIdDataGridViewTextBoxColumn
            // 
            this.serviceIdDataGridViewTextBoxColumn.DataPropertyName = "ServiceId";
            this.serviceIdDataGridViewTextBoxColumn.HeaderText = "ServiceId";
            this.serviceIdDataGridViewTextBoxColumn.Name = "serviceIdDataGridViewTextBoxColumn";
            this.serviceIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // areaIdDataGridViewTextBoxColumn
            // 
            this.areaIdDataGridViewTextBoxColumn.DataPropertyName = "AreaId";
            this.areaIdDataGridViewTextBoxColumn.HeaderText = "AreaId";
            this.areaIdDataGridViewTextBoxColumn.Name = "areaIdDataGridViewTextBoxColumn";
            this.areaIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vatDataGridViewTextBoxColumn
            // 
            this.vatDataGridViewTextBoxColumn.DataPropertyName = "Vat";
            this.vatDataGridViewTextBoxColumn.HeaderText = "Vat";
            this.vatDataGridViewTextBoxColumn.Name = "vatDataGridViewTextBoxColumn";
            this.vatDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // areaDataGridViewTextBoxColumn
            // 
            this.areaDataGridViewTextBoxColumn.DataPropertyName = "Area";
            this.areaDataGridViewTextBoxColumn.HeaderText = "Area";
            this.areaDataGridViewTextBoxColumn.Name = "areaDataGridViewTextBoxColumn";
            this.areaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // serviceBindingSource
            // 
            this.serviceBindingSource.DataSource = typeof(Mokkiprojekti_ryhma10.Service);
            // 
            // tbNameSearch_Activities
            // 
            this.tbNameSearch_Activities.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbNameSearch_Activities.Location = new System.Drawing.Point(44, 260);
            this.tbNameSearch_Activities.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbNameSearch_Activities.Name = "tbNameSearch_Activities";
            this.tbNameSearch_Activities.PlaceholderText = "Search...";
            this.tbNameSearch_Activities.Size = new System.Drawing.Size(290, 23);
            this.tbNameSearch_Activities.TabIndex = 13;
            this.tbNameSearch_Activities.TextChanged += new System.EventHandler(this.tbNameSearch_Activities_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(512, 245);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 30);
            this.label1.TabIndex = 10;
            this.label1.Text = "MANAGE ACTIVITIES";
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
            this.btnMenu.Location = new System.Drawing.Point(832, 226);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(192, 57);
            this.btnMenu.TabIndex = 14;
            this.btnMenu.Text = "Return to Menu";
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Mokkiprojekti_ryhma10.Properties.Resources.restagelogotextwhite;
            this.pictureBox1.Location = new System.Drawing.Point(387, 184);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(227, 58);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // btnNewArea
            // 
            this.btnNewArea.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnNewArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.btnNewArea.FlatAppearance.BorderSize = 0;
            this.btnNewArea.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.btnNewArea.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(122)))), ((int)(((byte)(120)))));
            this.btnNewArea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewArea.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnNewArea.Location = new System.Drawing.Point(229, 602);
            this.btnNewArea.Name = "btnNewArea";
            this.btnNewArea.Size = new System.Drawing.Size(113, 32);
            this.btnNewArea.TabIndex = 4;
            this.btnNewArea.Text = "Create new area";
            this.btnNewArea.UseVisualStyleBackColor = false;
            this.btnNewArea.Click += new System.EventHandler(this.btnNewArea_Click);
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
            this.btnDelete.Location = new System.Drawing.Point(651, 763);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(148, 56);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Delete Activity";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // cbAreas
            // 
            this.cbAreas.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cbAreas.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbAreas.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbAreas.FormattingEnabled = true;
            this.cbAreas.Location = new System.Drawing.Point(229, 570);
            this.cbAreas.Name = "cbAreas";
            this.cbAreas.Size = new System.Drawing.Size(161, 23);
            this.cbAreas.TabIndex = 3;
            // 
            // tbALV_Activities
            // 
            this.tbALV_Activities.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tbALV_Activities.Location = new System.Drawing.Point(606, 570);
            this.tbALV_Activities.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbALV_Activities.Name = "tbALV_Activities";
            this.tbALV_Activities.Size = new System.Drawing.Size(180, 23);
            this.tbALV_Activities.TabIndex = 6;
            this.tbALV_Activities.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbALV_Activities_KeyPress);
            // 
            // tbType_Activities
            // 
            this.tbType_Activities.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tbType_Activities.Location = new System.Drawing.Point(609, 522);
            this.tbType_Activities.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbType_Activities.Name = "tbType_Activities";
            this.tbType_Activities.Size = new System.Drawing.Size(180, 23);
            this.tbType_Activities.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(606, 548);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 21);
            this.label4.TabIndex = 42;
            this.label4.Text = "ALV (%)";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(606, 498);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 21);
            this.label3.TabIndex = 41;
            this.label3.Text = "Type";
            // 
            // tbDescription_Activities
            // 
            this.tbDescription_Activities.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tbDescription_Activities.Location = new System.Drawing.Point(411, 624);
            this.tbDescription_Activities.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbDescription_Activities.Multiline = true;
            this.tbDescription_Activities.Name = "tbDescription_Activities";
            this.tbDescription_Activities.Size = new System.Drawing.Size(540, 127);
            this.tbDescription_Activities.TabIndex = 7;
            // 
            // tbPrice_Activities
            // 
            this.tbPrice_Activities.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tbPrice_Activities.Location = new System.Drawing.Point(411, 570);
            this.tbPrice_Activities.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbPrice_Activities.Name = "tbPrice_Activities";
            this.tbPrice_Activities.Size = new System.Drawing.Size(180, 23);
            this.tbPrice_Activities.TabIndex = 5;
            this.tbPrice_Activities.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPrice_Activities_KeyPress);
            // 
            // tbName_Activities
            // 
            this.tbName_Activities.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tbName_Activities.Location = new System.Drawing.Point(411, 522);
            this.tbName_Activities.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbName_Activities.Name = "tbName_Activities";
            this.tbName_Activities.Size = new System.Drawing.Size(180, 23);
            this.tbName_Activities.TabIndex = 1;
            // 
            // tbID_Activities
            // 
            this.tbID_Activities.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tbID_Activities.Location = new System.Drawing.Point(229, 522);
            this.tbID_Activities.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbID_Activities.Name = "tbID_Activities";
            this.tbID_Activities.ReadOnly = true;
            this.tbID_Activities.Size = new System.Drawing.Size(161, 23);
            this.tbID_Activities.TabIndex = 37;
            // 
            // btnDiscard_Activities
            // 
            this.btnDiscard_Activities.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDiscard_Activities.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.btnDiscard_Activities.FlatAppearance.BorderSize = 0;
            this.btnDiscard_Activities.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.btnDiscard_Activities.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(122)))), ((int)(((byte)(120)))));
            this.btnDiscard_Activities.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDiscard_Activities.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnDiscard_Activities.Location = new System.Drawing.Point(496, 763);
            this.btnDiscard_Activities.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDiscard_Activities.Name = "btnDiscard_Activities";
            this.btnDiscard_Activities.Size = new System.Drawing.Size(148, 56);
            this.btnDiscard_Activities.TabIndex = 10;
            this.btnDiscard_Activities.Text = "Discard changes";
            this.btnDiscard_Activities.UseVisualStyleBackColor = false;
            this.btnDiscard_Activities.Click += new System.EventHandler(this.btnDiscard_Activities_Click);
            // 
            // btnSave_Activities
            // 
            this.btnSave_Activities.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSave_Activities.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.btnSave_Activities.FlatAppearance.BorderSize = 0;
            this.btnSave_Activities.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.btnSave_Activities.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(122)))), ((int)(((byte)(120)))));
            this.btnSave_Activities.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave_Activities.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSave_Activities.Location = new System.Drawing.Point(330, 763);
            this.btnSave_Activities.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSave_Activities.Name = "btnSave_Activities";
            this.btnSave_Activities.Size = new System.Drawing.Size(148, 56);
            this.btnSave_Activities.TabIndex = 9;
            this.btnSave_Activities.Text = "Save Changes";
            this.btnSave_Activities.UseVisualStyleBackColor = false;
            this.btnSave_Activities.Click += new System.EventHandler(this.btnSave_Activities_Click);
            // 
            // btnCreateNew_Activities
            // 
            this.btnCreateNew_Activities.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCreateNew_Activities.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.btnCreateNew_Activities.FlatAppearance.BorderSize = 0;
            this.btnCreateNew_Activities.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.btnCreateNew_Activities.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(122)))), ((int)(((byte)(120)))));
            this.btnCreateNew_Activities.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateNew_Activities.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnCreateNew_Activities.Location = new System.Drawing.Point(44, 498);
            this.btnCreateNew_Activities.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCreateNew_Activities.Name = "btnCreateNew_Activities";
            this.btnCreateNew_Activities.Size = new System.Drawing.Size(125, 47);
            this.btnCreateNew_Activities.TabIndex = 8;
            this.btnCreateNew_Activities.Text = "Create New Activity";
            this.btnCreateNew_Activities.UseVisualStyleBackColor = false;
            this.btnCreateNew_Activities.Click += new System.EventHandler(this.btnCreateNew_Activities_Click);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(411, 600);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 21);
            this.label7.TabIndex = 33;
            this.label7.Text = "Description";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(411, 550);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 21);
            this.label6.TabIndex = 32;
            this.label6.Text = "Price";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(225, 550);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 21);
            this.label5.TabIndex = 31;
            this.label5.Text = "Area";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(411, 502);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 21);
            this.label8.TabIndex = 30;
            this.label8.Text = "Name";
            // 
            // ID
            // 
            this.ID.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ID.AutoSize = true;
            this.ID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ID.Location = new System.Drawing.Point(225, 502);
            this.ID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(25, 21);
            this.ID.TabIndex = 29;
            this.ID.Text = "ID";
            // 
            // ServicesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(175)))), ((int)(((byte)(169)))));
            this.ClientSize = new System.Drawing.Size(1086, 860);
            this.Controls.Add(this.btnNewArea);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.cbAreas);
            this.Controls.Add(this.tbALV_Activities);
            this.Controls.Add(this.tbType_Activities);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbDescription_Activities);
            this.Controls.Add(this.tbPrice_Activities);
            this.Controls.Add(this.tbName_Activities);
            this.Controls.Add(this.tbID_Activities);
            this.Controls.Add(this.btnDiscard_Activities);
            this.Controls.Add(this.btnSave_Activities);
            this.Controls.Add(this.btnCreateNew_Activities);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.dgvServices);
            this.Controls.Add(this.tbNameSearch_Activities);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ServicesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Activities";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ServicesForm_FormClosing);
            this.VisibleChanged += new System.EventHandler(this.ServicesForm_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dgvServices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DataGridView dgvServices;
        private TextBox tbNameSearch_Activities;
        private Label label1;
        private Button btnMenu;
        private PictureBox pictureBox1;
        private Button btnNewArea;
        private Button btnDelete;
        private ComboBox cbAreas;
        private TextBox tbALV_Activities;
        private TextBox tbType_Activities;
        private Label label4;
        private Label label3;
        private TextBox tbDescription_Activities;
        private TextBox tbPrice_Activities;
        private TextBox tbName_Activities;
        private TextBox tbID_Activities;
        private Button btnDiscard_Activities;
        private Button btnSave_Activities;
        private Button btnCreateNew_Activities;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label8;
        private Label ID;
        private DataGridViewTextBoxColumn serviceIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn areaIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn vatDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn areaDataGridViewTextBoxColumn;
        private BindingSource serviceBindingSource;
    }
}