namespace Amila_Motors
{
    partial class AppoinmentForm
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
            this.Partnametooltip = new System.Windows.Forms.ToolTip(this.components);
            this.quantitytooltip = new System.Windows.Forms.ToolTip(this.components);
            this.cmbAID = new System.Windows.Forms.ComboBox();
            this.cmbCID = new System.Windows.Forms.ComboBox();
            this.cmbUID = new System.Windows.Forms.ComboBox();
            this.cmbVID = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtbBD = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.AddButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.txtReason = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtbAD = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.StockInventoryLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.NumberTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.VehicleTypeTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.ModelTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.ColorTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.DateTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.OwnernameTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.BrandTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.Pricetooltip = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbAID
            // 
            this.cmbAID.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbAID.Font = new System.Drawing.Font("Franklin Gothic Demi", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAID.ForeColor = System.Drawing.Color.Black;
            this.cmbAID.FormatString = "N0";
            this.cmbAID.FormattingEnabled = true;
            this.cmbAID.Items.AddRange(new object[] {
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
            this.cmbAID.Location = new System.Drawing.Point(19, 91);
            this.cmbAID.Name = "cmbAID";
            this.cmbAID.Size = new System.Drawing.Size(126, 29);
            this.cmbAID.TabIndex = 31;
            this.quantitytooltip.SetToolTip(this.cmbAID, "Select the quantity");
            this.cmbAID.SelectedIndexChanged += new System.EventHandler(this.cmbSupplier_SelectedIndexChanged);
            // 
            // cmbCID
            // 
            this.cmbCID.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbCID.Font = new System.Drawing.Font("Franklin Gothic Demi", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCID.ForeColor = System.Drawing.Color.Black;
            this.cmbCID.FormatString = "N0";
            this.cmbCID.FormattingEnabled = true;
            this.cmbCID.Items.AddRange(new object[] {
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
            this.cmbCID.Location = new System.Drawing.Point(188, 165);
            this.cmbCID.Name = "cmbCID";
            this.cmbCID.Size = new System.Drawing.Size(126, 29);
            this.cmbCID.TabIndex = 57;
            this.quantitytooltip.SetToolTip(this.cmbCID, "Select the quantity");
            // 
            // cmbUID
            // 
            this.cmbUID.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbUID.Font = new System.Drawing.Font("Franklin Gothic Demi", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbUID.ForeColor = System.Drawing.Color.Black;
            this.cmbUID.FormatString = "N0";
            this.cmbUID.FormattingEnabled = true;
            this.cmbUID.Items.AddRange(new object[] {
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
            this.cmbUID.Location = new System.Drawing.Point(19, 165);
            this.cmbUID.Name = "cmbUID";
            this.cmbUID.Size = new System.Drawing.Size(126, 29);
            this.cmbUID.TabIndex = 54;
            this.quantitytooltip.SetToolTip(this.cmbUID, "Select the quantity");
            // 
            // cmbVID
            // 
            this.cmbVID.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbVID.Font = new System.Drawing.Font("Franklin Gothic Demi", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbVID.ForeColor = System.Drawing.Color.Black;
            this.cmbVID.FormatString = "N0";
            this.cmbVID.FormattingEnabled = true;
            this.cmbVID.Items.AddRange(new object[] {
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
            this.cmbVID.Location = new System.Drawing.Point(356, 165);
            this.cmbVID.Name = "cmbVID";
            this.cmbVID.Size = new System.Drawing.Size(126, 29);
            this.cmbVID.TabIndex = 63;
            this.quantitytooltip.SetToolTip(this.cmbVID, "Select the quantity");
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(744, 639);
            this.panel1.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.cmbVID);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.dtbBD);
            this.panel3.Controls.Add(this.cmbCID);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.cmbUID);
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Controls.Add(this.AddButton);
            this.panel3.Controls.Add(this.EditButton);
            this.panel3.Controls.Add(this.DeleteButton);
            this.panel3.Controls.Add(this.txtReason);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.dtbAD);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.cmbAID);
            this.panel3.Controls.Add(this.StockInventoryLabel);
            this.panel3.Location = new System.Drawing.Point(187, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(526, 606);
            this.panel3.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Britannic Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(352, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 19);
            this.label5.TabIndex = 62;
            this.label5.Text = "Vehicle ID";
            this.label5.UseWaitCursor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Britannic Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(184, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 19);
            this.label3.TabIndex = 61;
            this.label3.Text = "Booking Date";
            this.label3.UseWaitCursor = true;
            // 
            // dtbBD
            // 
            this.dtbBD.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtbBD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtbBD.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtbBD.Location = new System.Drawing.Point(188, 93);
            this.dtbBD.Name = "dtbBD";
            this.dtbBD.Size = new System.Drawing.Size(129, 27);
            this.dtbBD.TabIndex = 60;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Britannic Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(184, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 19);
            this.label6.TabIndex = 56;
            this.label6.Text = "Customer ID";
            this.label6.UseWaitCursor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Britannic Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(17, 143);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 19);
            this.label7.TabIndex = 55;
            this.label7.Text = "User ID";
            this.label7.UseWaitCursor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(21, 429);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(464, 141);
            this.dataGridView1.TabIndex = 53;
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.AddButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.AddButton.FlatAppearance.BorderSize = 5;
            this.AddButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Yellow;
            this.AddButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.AddButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddButton.Font = new System.Drawing.Font("Franklin Gothic Demi", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton.ForeColor = System.Drawing.Color.White;
            this.AddButton.Location = new System.Drawing.Point(31, 363);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(121, 38);
            this.AddButton.TabIndex = 52;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.EditButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.EditButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.EditButton.FlatAppearance.BorderSize = 5;
            this.EditButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Yellow;
            this.EditButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.EditButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.EditButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.EditButton.Font = new System.Drawing.Font("Franklin Gothic Demi", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditButton.ForeColor = System.Drawing.Color.White;
            this.EditButton.Location = new System.Drawing.Point(194, 363);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(121, 38);
            this.EditButton.TabIndex = 51;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = false;
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.DeleteButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.DeleteButton.FlatAppearance.BorderSize = 5;
            this.DeleteButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Yellow;
            this.DeleteButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.DeleteButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DeleteButton.Font = new System.Drawing.Font("Franklin Gothic Demi", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteButton.ForeColor = System.Drawing.Color.White;
            this.DeleteButton.Location = new System.Drawing.Point(356, 363);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(121, 38);
            this.DeleteButton.TabIndex = 50;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = false;
            // 
            // txtReason
            // 
            this.txtReason.Location = new System.Drawing.Point(21, 238);
            this.txtReason.Multiline = true;
            this.txtReason.Name = "txtReason";
            this.txtReason.Size = new System.Drawing.Size(464, 86);
            this.txtReason.TabIndex = 49;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Britannic Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(17, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 19);
            this.label4.TabIndex = 48;
            this.label4.Text = "Reason";
            this.label4.UseWaitCursor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Britannic Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(352, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 19);
            this.label2.TabIndex = 47;
            this.label2.Text = "Appointed Date";
            this.label2.UseWaitCursor = true;
            // 
            // dtbAD
            // 
            this.dtbAD.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtbAD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtbAD.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtbAD.Location = new System.Drawing.Point(356, 93);
            this.dtbAD.Name = "dtbAD";
            this.dtbAD.Size = new System.Drawing.Size(129, 27);
            this.dtbAD.TabIndex = 46;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(17, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 19);
            this.label1.TabIndex = 43;
            this.label1.Text = "Appoinment ID";
            this.label1.UseWaitCursor = true;
            // 
            // StockInventoryLabel
            // 
            this.StockInventoryLabel.AutoSize = true;
            this.StockInventoryLabel.BackColor = System.Drawing.Color.Transparent;
            this.StockInventoryLabel.Font = new System.Drawing.Font("Britannic Bold", 13.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StockInventoryLabel.ForeColor = System.Drawing.Color.White;
            this.StockInventoryLabel.Location = new System.Drawing.Point(14, 15);
            this.StockInventoryLabel.Name = "StockInventoryLabel";
            this.StockInventoryLabel.Size = new System.Drawing.Size(188, 26);
            this.StockInventoryLabel.TabIndex = 3;
            this.StockInventoryLabel.Text = "Appoinment Form";
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
            this.panel2.Size = new System.Drawing.Size(158, 639);
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
            this.btnBack.Location = new System.Drawing.Point(21, 16);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(121, 38);
            this.btnBack.TabIndex = 27;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
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
            // VehicleTypeTooltip
            // 
            this.VehicleTypeTooltip.AutoPopDelay = 5000;
            this.VehicleTypeTooltip.InitialDelay = 500;
            this.VehicleTypeTooltip.ReshowDelay = 100;
            this.VehicleTypeTooltip.ShowAlways = true;
            // 
            // AppoinmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(744, 639);
            this.Controls.Add(this.panel1);
            this.Name = "AppoinmentForm";
            this.Text = " ";
            this.Load += new System.EventHandler(this.AppoinmentForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolTip quantitytooltip;
        private System.Windows.Forms.ToolTip Partnametooltip;
        private System.Windows.Forms.ComboBox cmbAID;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label StockInventoryLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ToolTip NumberTooltip;
        private System.Windows.Forms.ToolTip VehicleTypeTooltip;
        private System.Windows.Forms.ToolTip ModelTooltip;
        private System.Windows.Forms.ToolTip ColorTooltip;
        private System.Windows.Forms.ToolTip DateTooltip;
        private System.Windows.Forms.ToolTip OwnernameTooltip;
        private System.Windows.Forms.ToolTip BrandTooltip;
        private System.Windows.Forms.ToolTip Pricetooltip;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtbAD;
        private System.Windows.Forms.TextBox txtReason;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cmbCID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbUID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtbBD;
        private System.Windows.Forms.ComboBox cmbVID;
        private System.Windows.Forms.Label label5;
    }
}