namespace Amila_Motors
{
    partial class Customer
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
            this.NumberTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.VehicleTypeTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.ModelTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.ColorTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.cmbCID = new System.Windows.Forms.ComboBox();
            this.DateTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.OwnernameTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.label11 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.BrandTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.PartNameLabel = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.StockInventoryLabel = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbUID = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNIC = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.SupplierGridbox = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Partnametooltip = new System.Windows.Forms.ToolTip(this.components);
            this.quantitytooltip = new System.Windows.Forms.ToolTip(this.components);
            this.Pricetooltip = new System.Windows.Forms.ToolTip(this.components);
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SupplierGridbox)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // VehicleTypeTooltip
            // 
            this.VehicleTypeTooltip.AutoPopDelay = 5000;
            this.VehicleTypeTooltip.InitialDelay = 500;
            this.VehicleTypeTooltip.ReshowDelay = 100;
            this.VehicleTypeTooltip.ShowAlways = true;
            // 
            // cmbCID
            // 
            this.cmbCID.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbCID.Font = new System.Drawing.Font("Franklin Gothic Demi", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCID.ForeColor = System.Drawing.Color.Black;
            this.cmbCID.FormatString = "N0";
            this.cmbCID.FormattingEnabled = true;
            this.cmbCID.Location = new System.Drawing.Point(27, 98);
            this.cmbCID.Name = "cmbCID";
            this.cmbCID.Size = new System.Drawing.Size(126, 29);
            this.cmbCID.TabIndex = 31;
            this.quantitytooltip.SetToolTip(this.cmbCID, "Select the quantity");
            this.cmbCID.SelectedIndexChanged += new System.EventHandler(this.cmbCID_SelectedIndexChanged);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Britannic Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(23, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 19);
            this.label2.TabIndex = 30;
            this.label2.Text = "Customer ID";
            this.label2.UseWaitCursor = true;
            // 
            // PartNameLabel
            // 
            this.PartNameLabel.AutoSize = true;
            this.PartNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.PartNameLabel.Font = new System.Drawing.Font("Britannic Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PartNameLabel.ForeColor = System.Drawing.Color.White;
            this.PartNameLabel.Location = new System.Drawing.Point(174, 76);
            this.PartNameLabel.Name = "PartNameLabel";
            this.PartNameLabel.Size = new System.Drawing.Size(126, 19);
            this.PartNameLabel.TabIndex = 26;
            this.PartNameLabel.Text = "Customer Name";
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
            this.btnEdit.Location = new System.Drawing.Point(424, 242);
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
            this.btnDelete.Location = new System.Drawing.Point(586, 242);
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
            this.StockInventoryLabel.Size = new System.Drawing.Size(234, 26);
            this.StockInventoryLabel.TabIndex = 3;
            this.StockInventoryLabel.Text = "Customer Information";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.txtAddress);
            this.panel3.Controls.Add(this.cmbStatus);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.cmbUID);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.txtNIC);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.txtEmail);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.txtContact);
            this.panel3.Controls.Add(this.cmbCID);
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Britannic Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(637, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 19);
            this.label4.TabIndex = 45;
            this.label4.Text = "Address";
            // 
            // txtAddress
            // 
            this.txtAddress.AccessibleDescription = "";
            this.txtAddress.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.txtAddress.Font = new System.Drawing.Font("Franklin Gothic Demi", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(641, 160);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(246, 48);
            this.txtAddress.TabIndex = 44;
            this.txtAddress.Tag = "Type vehicle brand";
            this.txtAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Partnametooltip.SetToolTip(this.txtAddress, "Enter part name");
            this.txtAddress.UseWaitCursor = true;
            // 
            // cmbStatus
            // 
            this.cmbStatus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbStatus.Font = new System.Drawing.Font("Franklin Gothic Demi", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStatus.ForeColor = System.Drawing.Color.Black;
            this.cmbStatus.FormatString = "N0";
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "Active",
            "Deactivated"});
            this.cmbStatus.Location = new System.Drawing.Point(448, 162);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(126, 29);
            this.cmbStatus.TabIndex = 43;
            this.quantitytooltip.SetToolTip(this.cmbStatus, "Select the quantity");
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Britannic Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(444, 138);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 19);
            this.label7.TabIndex = 42;
            this.label7.Text = "Status";
            this.label7.UseWaitCursor = true;
            // 
            // cmbUID
            // 
            this.cmbUID.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbUID.Font = new System.Drawing.Font("Franklin Gothic Demi", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbUID.ForeColor = System.Drawing.Color.Black;
            this.cmbUID.FormatString = "N0";
            this.cmbUID.FormattingEnabled = true;
            this.cmbUID.Location = new System.Drawing.Point(27, 160);
            this.cmbUID.Name = "cmbUID";
            this.cmbUID.Size = new System.Drawing.Size(126, 29);
            this.cmbUID.TabIndex = 41;
            this.quantitytooltip.SetToolTip(this.cmbUID, "Select the quantity");
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Britannic Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(23, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 19);
            this.label6.TabIndex = 40;
            this.label6.Text = "User ID";
            this.label6.UseWaitCursor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Britannic Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(174, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 19);
            this.label5.TabIndex = 39;
            this.label5.Text = "NIC";
            // 
            // txtNIC
            // 
            this.txtNIC.AccessibleDescription = "";
            this.txtNIC.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.txtNIC.Font = new System.Drawing.Font("Franklin Gothic Demi", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNIC.Location = new System.Drawing.Point(178, 162);
            this.txtNIC.Name = "txtNIC";
            this.txtNIC.Size = new System.Drawing.Size(168, 27);
            this.txtNIC.TabIndex = 38;
            this.txtNIC.Tag = "Type vehicle brand";
            this.txtNIC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Partnametooltip.SetToolTip(this.txtNIC, "Enter part name");
            this.txtNIC.UseWaitCursor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Britannic Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(637, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 19);
            this.label3.TabIndex = 35;
            this.label3.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.AccessibleDescription = "";
            this.txtEmail.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.txtEmail.Font = new System.Drawing.Font("Franklin Gothic Demi", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(641, 97);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(246, 27);
            this.txtEmail.TabIndex = 34;
            this.txtEmail.Tag = "Type vehicle brand";
            this.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Partnametooltip.SetToolTip(this.txtEmail, "Enter part name");
            this.txtEmail.UseWaitCursor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(444, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 19);
            this.label1.TabIndex = 33;
            this.label1.Text = "Contact";
            // 
            // txtContact
            // 
            this.txtContact.AccessibleDescription = "";
            this.txtContact.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.txtContact.Font = new System.Drawing.Font("Franklin Gothic Demi", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContact.Location = new System.Drawing.Point(448, 97);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(168, 27);
            this.txtContact.TabIndex = 32;
            this.txtContact.Tag = "Type vehicle brand";
            this.txtContact.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Partnametooltip.SetToolTip(this.txtContact, "Enter part name");
            this.txtContact.UseWaitCursor = true;
            // 
            // txtName
            // 
            this.txtName.AccessibleDescription = "";
            this.txtName.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.txtName.Font = new System.Drawing.Font("Franklin Gothic Demi", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(178, 98);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(246, 27);
            this.txtName.TabIndex = 25;
            this.txtName.Tag = "Type vehicle brand";
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Partnametooltip.SetToolTip(this.txtName, "Enter part name");
            this.txtName.UseWaitCursor = true;
            // 
            // SupplierGridbox
            // 
            this.SupplierGridbox.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SupplierGridbox.Location = new System.Drawing.Point(19, 306);
            this.SupplierGridbox.Name = "SupplierGridbox";
            this.SupplierGridbox.RowHeadersWidth = 51;
            this.SupplierGridbox.RowTemplate.Height = 24;
            this.SupplierGridbox.Size = new System.Drawing.Size(909, 235);
            this.SupplierGridbox.TabIndex = 24;
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
            this.btnAdd.Location = new System.Drawing.Point(261, 242);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(121, 38);
            this.btnAdd.TabIndex = 23;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1170, 589);
            this.panel1.TabIndex = 3;
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1170, 589);
            this.Controls.Add(this.panel1);
            this.Name = "Customer";
            this.Text = "Customer";
            this.Load += new System.EventHandler(this.Customer_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SupplierGridbox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolTip NumberTooltip;
        private System.Windows.Forms.ToolTip VehicleTypeTooltip;
        private System.Windows.Forms.ToolTip ModelTooltip;
        private System.Windows.Forms.ToolTip ColorTooltip;
        private System.Windows.Forms.ComboBox cmbCID;
        private System.Windows.Forms.ToolTip quantitytooltip;
        private System.Windows.Forms.ToolTip DateTooltip;
        private System.Windows.Forms.ToolTip OwnernameTooltip;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ToolTip BrandTooltip;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label PartNameLabel;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label StockInventoryLabel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ToolTip Partnametooltip;
        private System.Windows.Forms.DataGridView SupplierGridbox;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolTip Pricetooltip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNIC;
        private System.Windows.Forms.ComboBox cmbUID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAddress;
    }
}