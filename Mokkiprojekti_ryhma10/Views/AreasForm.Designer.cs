namespace Mokkiprojekti_ryhma10.Views
{
    partial class AreasForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AreasForm));
            this.dgvAreas = new System.Windows.Forms.DataGridView();
            this.areaIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.areaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbNameSearch_Areas = new System.Windows.Forms.TextBox();
            this.ManageAreasHeader = new System.Windows.Forms.Label();
            this.btnMenu = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.tbName_Areas = new System.Windows.Forms.TextBox();
            this.tbID_Areas = new System.Windows.Forms.TextBox();
            this.btnDiscard_Areas = new System.Windows.Forms.Button();
            this.btnSave_Areas = new System.Windows.Forms.Button();
            this.btnCreateNew_Areas = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAreas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.areaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAreas
            // 
            this.dgvAreas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAreas.AutoGenerateColumns = false;
            this.dgvAreas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAreas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvAreas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAreas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.areaIdDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn});
            this.dgvAreas.DataSource = this.areaBindingSource;
            this.dgvAreas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(175)))), ((int)(((byte)(169)))));
            this.dgvAreas.Location = new System.Drawing.Point(23, 235);
            this.dgvAreas.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvAreas.Name = "dgvAreas";
            this.dgvAreas.ReadOnly = true;
            this.dgvAreas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAreas.Size = new System.Drawing.Size(862, 211);
            this.dgvAreas.TabIndex = 9;
            this.dgvAreas.SelectionChanged += new System.EventHandler(this.dgvAreas_SelectionChanged);
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
            // areaBindingSource
            // 
            this.areaBindingSource.DataSource = typeof(Mokkiprojekti_ryhma10.Area);
            // 
            // tbNameSearch_Areas
            // 
            this.tbNameSearch_Areas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tbNameSearch_Areas.Location = new System.Drawing.Point(23, 206);
            this.tbNameSearch_Areas.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbNameSearch_Areas.Name = "tbNameSearch_Areas";
            this.tbNameSearch_Areas.PlaceholderText = "Search...";
            this.tbNameSearch_Areas.Size = new System.Drawing.Size(242, 23);
            this.tbNameSearch_Areas.TabIndex = 7;
            this.tbNameSearch_Areas.TextChanged += new System.EventHandler(this.tbNameSearch_Areas_TextChanged);
            // 
            // ManageAreasHeader
            // 
            this.ManageAreasHeader.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ManageAreasHeader.AutoSize = true;
            this.ManageAreasHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.ManageAreasHeader.Location = new System.Drawing.Point(421, 193);
            this.ManageAreasHeader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ManageAreasHeader.Name = "ManageAreasHeader";
            this.ManageAreasHeader.Size = new System.Drawing.Size(170, 30);
            this.ManageAreasHeader.TabIndex = 10;
            this.ManageAreasHeader.Text = "MANAGE AREAS";
            // 
            // btnMenu
            // 
            this.btnMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.btnMenu.FlatAppearance.BorderColor = System.Drawing.Color.Olive;
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.btnMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(122)))), ((int)(((byte)(120)))));
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnMenu.Location = new System.Drawing.Point(745, 169);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(140, 60);
            this.btnMenu.TabIndex = 1;
            this.btnMenu.Text = "Return to Menu";
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = global::Mokkiprojekti_ryhma10.Properties.Resources.restagelogotextwhite;
            this.pictureBox1.Location = new System.Drawing.Point(304, 137);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(237, 63);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(122)))), ((int)(((byte)(120)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnDelete.Location = new System.Drawing.Point(576, 528);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(140, 36);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete area";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // tbName_Areas
            // 
            this.tbName_Areas.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tbName_Areas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tbName_Areas.Location = new System.Drawing.Point(432, 475);
            this.tbName_Areas.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbName_Areas.Name = "tbName_Areas";
            this.tbName_Areas.Size = new System.Drawing.Size(159, 23);
            this.tbName_Areas.TabIndex = 3;
            // 
            // tbID_Areas
            // 
            this.tbID_Areas.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tbID_Areas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tbID_Areas.Location = new System.Drawing.Point(263, 474);
            this.tbID_Areas.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbID_Areas.Name = "tbID_Areas";
            this.tbID_Areas.ReadOnly = true;
            this.tbID_Areas.Size = new System.Drawing.Size(159, 23);
            this.tbID_Areas.TabIndex = 10;
            this.tbID_Areas.Tag = "2";
            // 
            // btnDiscard_Areas
            // 
            this.btnDiscard_Areas.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDiscard_Areas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.btnDiscard_Areas.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btnDiscard_Areas.FlatAppearance.BorderSize = 0;
            this.btnDiscard_Areas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.btnDiscard_Areas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(122)))), ((int)(((byte)(120)))));
            this.btnDiscard_Areas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDiscard_Areas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnDiscard_Areas.Location = new System.Drawing.Point(420, 528);
            this.btnDiscard_Areas.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDiscard_Areas.Name = "btnDiscard_Areas";
            this.btnDiscard_Areas.Size = new System.Drawing.Size(140, 36);
            this.btnDiscard_Areas.TabIndex = 8;
            this.btnDiscard_Areas.Text = "Discard changes";
            this.btnDiscard_Areas.UseVisualStyleBackColor = false;
            this.btnDiscard_Areas.Click += new System.EventHandler(this.btnDiscard_Areas_Click);
            // 
            // btnSave_Areas
            // 
            this.btnSave_Areas.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSave_Areas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.btnSave_Areas.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btnSave_Areas.FlatAppearance.BorderSize = 0;
            this.btnSave_Areas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.btnSave_Areas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(122)))), ((int)(((byte)(120)))));
            this.btnSave_Areas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave_Areas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSave_Areas.Location = new System.Drawing.Point(263, 528);
            this.btnSave_Areas.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSave_Areas.Name = "btnSave_Areas";
            this.btnSave_Areas.Size = new System.Drawing.Size(140, 36);
            this.btnSave_Areas.TabIndex = 7;
            this.btnSave_Areas.Text = "Save Changes";
            this.btnSave_Areas.UseVisualStyleBackColor = false;
            this.btnSave_Areas.Click += new System.EventHandler(this.btnSave_Areas_Click);
            // 
            // btnCreateNew_Areas
            // 
            this.btnCreateNew_Areas.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCreateNew_Areas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.btnCreateNew_Areas.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btnCreateNew_Areas.FlatAppearance.BorderSize = 0;
            this.btnCreateNew_Areas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.btnCreateNew_Areas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(122)))), ((int)(((byte)(120)))));
            this.btnCreateNew_Areas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateNew_Areas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnCreateNew_Areas.Location = new System.Drawing.Point(23, 452);
            this.btnCreateNew_Areas.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCreateNew_Areas.Name = "btnCreateNew_Areas";
            this.btnCreateNew_Areas.Size = new System.Drawing.Size(140, 40);
            this.btnCreateNew_Areas.TabIndex = 6;
            this.btnCreateNew_Areas.Text = "Create New";
            this.btnCreateNew_Areas.UseVisualStyleBackColor = false;
            this.btnCreateNew_Areas.Click += new System.EventHandler(this.btnCreateNew_Areas_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(432, 453);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "Name";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(263, 450);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 21);
            this.label6.TabIndex = 18;
            this.label6.Text = "ID";
            // 
            // AreasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(175)))), ((int)(((byte)(169)))));
            this.ClientSize = new System.Drawing.Size(913, 613);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.tbName_Areas);
            this.Controls.Add(this.tbID_Areas);
            this.Controls.Add(this.btnDiscard_Areas);
            this.Controls.Add(this.btnSave_Areas);
            this.Controls.Add(this.btnCreateNew_Areas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.dgvAreas);
            this.Controls.Add(this.tbNameSearch_Areas);
            this.Controls.Add(this.ManageAreasHeader);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AreasForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Areas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AreasForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAreas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.areaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DataGridView dgvAreas;
        private TextBox tbNameSearch_Areas;
        private Label ManageAreasHeader;
        private Button btnMenu;
        private PictureBox pictureBox1;
        private Button btnDelete;
        private TextBox tbName_Areas;
        private TextBox tbID_Areas;
        private Button btnDiscard_Areas;
        private Button btnSave_Areas;
        private Button btnCreateNew_Areas;
        private Label label3;
        private Label label6;
        private BindingSource areaBindingSource;
        private DataGridViewTextBoxColumn areaIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
    }
}