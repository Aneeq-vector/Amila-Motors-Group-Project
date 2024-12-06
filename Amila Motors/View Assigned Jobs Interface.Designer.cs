namespace Amila_Motors
{
    partial class View_Assigned_Jobs_Interface
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
            this.btnBack = new System.Windows.Forms.Button();
            this.OwnernameTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.DateTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.ColorTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.label11 = new System.Windows.Forms.Label();
            this.cmbPaymentID = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PaymentGridbox = new System.Windows.Forms.DataGridView();
            this.VehicleTypeTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.BrandTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.ModelTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.NumberTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.StockInventoryLabel = new System.Windows.Forms.Label();
            this.quantitytooltip = new System.Windows.Forms.ToolTip(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Partnametooltip = new System.Windows.Forms.ToolTip(this.components);
            this.Pricetooltip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PaymentGridbox)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
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
            this.btnBack.Location = new System.Drawing.Point(15, 16);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(121, 38);
            this.btnBack.TabIndex = 27;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
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
            // cmbPaymentID
            // 
            this.cmbPaymentID.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbPaymentID.Font = new System.Drawing.Font("Franklin Gothic Demi", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPaymentID.ForeColor = System.Drawing.Color.Black;
            this.cmbPaymentID.FormatString = "N0";
            this.cmbPaymentID.FormattingEnabled = true;
            this.cmbPaymentID.Items.AddRange(new object[] {
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
            this.cmbPaymentID.Location = new System.Drawing.Point(341, 104);
            this.cmbPaymentID.Name = "cmbPaymentID";
            this.cmbPaymentID.Size = new System.Drawing.Size(90, 29);
            this.cmbPaymentID.TabIndex = 29;
            this.quantitytooltip.SetToolTip(this.cmbPaymentID, "Select the quantity");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(337, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 19);
            this.label1.TabIndex = 28;
            this.label1.Text = "Labor ID";
            // 
            // PaymentGridbox
            // 
            this.PaymentGridbox.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PaymentGridbox.Location = new System.Drawing.Point(21, 189);
            this.PaymentGridbox.Name = "PaymentGridbox";
            this.PaymentGridbox.RowHeadersWidth = 51;
            this.PaymentGridbox.RowTemplate.Height = 24;
            this.PaymentGridbox.Size = new System.Drawing.Size(909, 339);
            this.PaymentGridbox.TabIndex = 24;
            // 
            // VehicleTypeTooltip
            // 
            this.VehicleTypeTooltip.AutoPopDelay = 5000;
            this.VehicleTypeTooltip.InitialDelay = 500;
            this.VehicleTypeTooltip.ReshowDelay = 100;
            this.VehicleTypeTooltip.ShowAlways = true;
            // 
            // StockInventoryLabel
            // 
            this.StockInventoryLabel.AutoSize = true;
            this.StockInventoryLabel.BackColor = System.Drawing.Color.Transparent;
            this.StockInventoryLabel.Font = new System.Drawing.Font("Britannic Bold", 13.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StockInventoryLabel.ForeColor = System.Drawing.Color.White;
            this.StockInventoryLabel.Location = new System.Drawing.Point(14, 15);
            this.StockInventoryLabel.Name = "StockInventoryLabel";
            this.StockInventoryLabel.Size = new System.Drawing.Size(203, 26);
            this.StockInventoryLabel.TabIndex = 3;
            this.StockInventoryLabel.Text = "View Assigned Jobs";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnDelete);
            this.panel3.Controls.Add(this.cmbPaymentID);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.PaymentGridbox);
            this.panel3.Controls.Add(this.StockInventoryLabel);
            this.panel3.Location = new System.Drawing.Point(187, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(956, 567);
            this.panel3.TabIndex = 2;
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
            this.btnDelete.Location = new System.Drawing.Point(486, 98);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(121, 38);
            this.btnDelete.TabIndex = 34;
            this.btnDelete.Text = "Search";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1173, 600);
            this.panel1.TabIndex = 3;
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
            this.panel2.Size = new System.Drawing.Size(158, 600);
            this.panel2.TabIndex = 0;
            // 
            // View_Assigned_Jobs_Interface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1173, 600);
            this.Controls.Add(this.panel1);
            this.Name = "View_Assigned_Jobs_Interface";
            this.Text = "View_Assigned_Jobs_Interface";
            ((System.ComponentModel.ISupportInitialize)(this.PaymentGridbox)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ToolTip OwnernameTooltip;
        private System.Windows.Forms.ToolTip DateTooltip;
        private System.Windows.Forms.ToolTip ColorTooltip;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbPaymentID;
        private System.Windows.Forms.ToolTip quantitytooltip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView PaymentGridbox;
        private System.Windows.Forms.ToolTip VehicleTypeTooltip;
        private System.Windows.Forms.ToolTip Partnametooltip;
        private System.Windows.Forms.ToolTip BrandTooltip;
        private System.Windows.Forms.ToolTip ModelTooltip;
        private System.Windows.Forms.ToolTip NumberTooltip;
        private System.Windows.Forms.Label StockInventoryLabel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolTip Pricetooltip;
        private System.Windows.Forms.Button btnDelete;
    }
}