namespace Amila_Motors
{
    partial class Vehicle
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cmbSupplier = new System.Windows.Forms.ComboBox();
            this.Pricetooltip = new System.Windows.Forms.ToolTip(this.components);
            this.quantitytooltip = new System.Windows.Forms.ToolTip(this.components);
            this.Partnametooltip = new System.Windows.Forms.ToolTip(this.components);
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PartNameLabel = new System.Windows.Forms.Label();
            this.SupplierGridbox = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.StockInventoryLabel = new System.Windows.Forms.Label();
            this.BrandTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.btnBack = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.OwnernameTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.DateTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.ColorTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.ModelTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.VehicleTypeTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.NumberTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.SupplierGridbox)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(564, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 19);
            this.label1.TabIndex = 33;
            this.label1.Text = "Model";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.AccessibleDescription = "";
            this.textBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.textBox1.Font = new System.Drawing.Font("Franklin Gothic Demi", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(568, 106);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(168, 27);
            this.textBox1.TabIndex = 32;
            this.textBox1.Tag = "Type vehicle brand";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Partnametooltip.SetToolTip(this.textBox1, "Enter part name");
            this.textBox1.UseWaitCursor = true;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // cmbSupplier
            // 
            this.cmbSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbSupplier.Font = new System.Drawing.Font("Franklin Gothic Demi", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSupplier.ForeColor = System.Drawing.Color.Black;
            this.cmbSupplier.FormatString = "N0";
            this.cmbSupplier.FormattingEnabled = true;
            this.cmbSupplier.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cmbSupplier.Location = new System.Drawing.Point(26, 104);
            this.cmbSupplier.Name = "cmbSupplier";
            this.cmbSupplier.Size = new System.Drawing.Size(126, 29);
            this.cmbSupplier.TabIndex = 31;
            this.quantitytooltip.SetToolTip(this.cmbSupplier, "Select the quantity");
            this.cmbSupplier.SelectedIndexChanged += new System.EventHandler(this.cmbSupplier_SelectedIndexChanged);
            // 
            // Pricetooltip
            // 
            this.Pricetooltip.Popup += new System.Windows.Forms.PopupEventHandler(this.Pricetooltip_Popup);
            // 
            // quantitytooltip
            // 
            this.quantitytooltip.Popup += new System.Windows.Forms.PopupEventHandler(this.quantitytooltip_Popup);
            // 
            // Partnametooltip
            // 
            this.Partnametooltip.Popup += new System.Windows.Forms.PopupEventHandler(this.Partnametooltip_Popup);
            // 
            // txtName
            // 
            this.txtName.AccessibleDescription = "";
            this.txtName.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.txtName.Font = new System.Drawing.Font("Franklin Gothic Demi", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(356, 106);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(174, 27);
            this.txtName.TabIndex = 25;
            this.txtName.Tag = "Type vehicle brand";
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Partnametooltip.SetToolTip(this.txtName, "Enter part name");
            this.txtName.UseWaitCursor = true;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Britannic Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(22, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 19);
            this.label2.TabIndex = 30;
            this.label2.Text = "Vehicle ID";
            this.label2.UseWaitCursor = true;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // PartNameLabel
            // 
            this.PartNameLabel.AutoSize = true;
            this.PartNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.PartNameLabel.Font = new System.Drawing.Font("Britannic Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PartNameLabel.ForeColor = System.Drawing.Color.White;
            this.PartNameLabel.Location = new System.Drawing.Point(352, 84);
            this.PartNameLabel.Name = "PartNameLabel";
            this.PartNameLabel.Size = new System.Drawing.Size(43, 19);
            this.PartNameLabel.TabIndex = 26;
            this.PartNameLabel.Text = "Type";
            this.PartNameLabel.Click += new System.EventHandler(this.PartNameLabel_Click);
            // 
            // SupplierGridbox
            // 
            this.SupplierGridbox.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SupplierGridbox.Location = new System.Drawing.Point(19, 254);
            this.SupplierGridbox.Name = "SupplierGridbox";
            this.SupplierGridbox.RowHeadersWidth = 51;
            this.SupplierGridbox.RowTemplate.Height = 24;
            this.SupplierGridbox.Size = new System.Drawing.Size(909, 287);
            this.SupplierGridbox.TabIndex = 24;
            this.SupplierGridbox.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SupplierGridbox_CellContentClick);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAdd.FlatAppearance.BorderSize = 5;
            this.btnAdd.FlatAppearance.CheckedBackColor = System.Drawing.Color.Yellow;
            this.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Font = new System.Drawing.Font("Franklin Gothic Demi", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(230, 176);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(121, 38);
            this.btnAdd.TabIndex = 23;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.dateTimePicker1);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.textBox2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Controls.Add(this.cmbSupplier);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.PartNameLabel);
            this.panel3.Controls.Add(this.txtName);
            this.panel3.Controls.Add(this.SupplierGridbox);
            this.panel3.Controls.Add(this.btnAdd);
            this.panel3.Controls.Add(this.btnEdit);
            this.panel3.Controls.Add(this.btnDelete);
            this.panel3.Controls.Add(this.StockInventoryLabel);
            this.panel3.Location = new System.Drawing.Point(187, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(956, 567);
            this.panel3.TabIndex = 2;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnEdit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEdit.FlatAppearance.BorderSize = 5;
            this.btnEdit.FlatAppearance.CheckedBackColor = System.Drawing.Color.Yellow;
            this.btnEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEdit.Font = new System.Drawing.Font("Franklin Gothic Demi", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(393, 176);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(121, 38);
            this.btnEdit.TabIndex = 22;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDelete.FlatAppearance.BorderSize = 5;
            this.btnDelete.FlatAppearance.CheckedBackColor = System.Drawing.Color.Yellow;
            this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Font = new System.Drawing.Font("Franklin Gothic Demi", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(555, 176);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(121, 38);
            this.btnDelete.TabIndex = 21;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // StockInventoryLabel
            // 
            this.StockInventoryLabel.AutoSize = true;
            this.StockInventoryLabel.BackColor = System.Drawing.Color.Transparent;
            this.StockInventoryLabel.Font = new System.Drawing.Font("Britannic Bold", 13.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StockInventoryLabel.ForeColor = System.Drawing.Color.White;
            this.StockInventoryLabel.Location = new System.Drawing.Point(14, 15);
            this.StockInventoryLabel.Name = "StockInventoryLabel";
            this.StockInventoryLabel.Size = new System.Drawing.Size(207, 26);
            this.StockInventoryLabel.TabIndex = 3;
            this.StockInventoryLabel.Text = "Vehicle Information";
            this.StockInventoryLabel.Click += new System.EventHandler(this.StockInventoryLabel_Click);
            // 
            // BrandTooltip
            // 
            this.BrandTooltip.Popup += new System.Windows.Forms.PopupEventHandler(this.BrandTooltip_Popup);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Black;
            this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnBack.FlatAppearance.BorderSize = 5;
            this.btnBack.FlatAppearance.CheckedBackColor = System.Drawing.Color.Yellow;
            this.btnBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBack.Font = new System.Drawing.Font("Franklin Gothic Demi", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(12, 16);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(121, 38);
            this.btnBack.TabIndex = 27;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel2.Controls.Add(this.btnBack);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(158, 589);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Britannic Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(40, 694);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(153, 15);
            this.label11.TabIndex = 25;
            this.label11.Text = "Created by NIBM students";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // OwnernameTooltip
            // 
            this.OwnernameTooltip.Popup += new System.Windows.Forms.PopupEventHandler(this.OwnernameTooltip_Popup);
            // 
            // DateTooltip
            // 
            this.DateTooltip.Popup += new System.Windows.Forms.PopupEventHandler(this.DateTooltip_Popup);
            // 
            // ColorTooltip
            // 
            this.ColorTooltip.Popup += new System.Windows.Forms.PopupEventHandler(this.ColorTooltip_Popup);
            // 
            // ModelTooltip
            // 
            this.ModelTooltip.Popup += new System.Windows.Forms.PopupEventHandler(this.ModelTooltip_Popup);
            // 
            // VehicleTypeTooltip
            // 
            this.VehicleTypeTooltip.AutoPopDelay = 5000;
            this.VehicleTypeTooltip.InitialDelay = 500;
            this.VehicleTypeTooltip.ReshowDelay = 100;
            this.VehicleTypeTooltip.ShowAlways = true;
            this.VehicleTypeTooltip.Popup += new System.Windows.Forms.PopupEventHandler(this.VehicleTypeTooltip_Popup);
            // 
            // NumberTooltip
            // 
            this.NumberTooltip.Popup += new System.Windows.Forms.PopupEventHandler(this.NumberTooltip_Popup);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1170, 589);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Britannic Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(179, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 19);
            this.label3.TabIndex = 39;
            this.label3.Text = "Vehicle Number";
            // 
            // textBox2
            // 
            this.textBox2.AccessibleDescription = "";
            this.textBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.textBox2.Font = new System.Drawing.Font("Franklin Gothic Demi", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(183, 106);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(139, 27);
            this.textBox2.TabIndex = 38;
            this.textBox2.Tag = "Type vehicle brand";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Partnametooltip.SetToolTip(this.textBox2, "Enter part name");
            this.textBox2.UseWaitCursor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Britannic Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(766, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 19);
            this.label5.TabIndex = 49;
            this.label5.Text = "Year of Manufacture";
            this.label5.UseWaitCursor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(770, 106);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(155, 27);
            this.dateTimePicker1.TabIndex = 48;
            // 
            // Vehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1170, 589);
            this.Controls.Add(this.panel1);
            this.Name = "Vehicle";
            this.Text = "Vehicle";
            ((System.ComponentModel.ISupportInitialize)(this.SupplierGridbox)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolTip Partnametooltip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox cmbSupplier;
        private System.Windows.Forms.ToolTip quantitytooltip;
        private System.Windows.Forms.ToolTip Pricetooltip;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label PartNameLabel;
        private System.Windows.Forms.DataGridView SupplierGridbox;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label StockInventoryLabel;
        private System.Windows.Forms.ToolTip BrandTooltip;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ToolTip OwnernameTooltip;
        private System.Windows.Forms.ToolTip DateTooltip;
        private System.Windows.Forms.ToolTip ColorTooltip;
        private System.Windows.Forms.ToolTip ModelTooltip;
        private System.Windows.Forms.ToolTip VehicleTypeTooltip;
        private System.Windows.Forms.ToolTip NumberTooltip;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}