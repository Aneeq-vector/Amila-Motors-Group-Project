namespace Amila_Motors
{
    partial class JobCoordinatorDashboard
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
            this.label11 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnInventory = new System.Windows.Forms.Button();
            this.btnSupplier = new System.Windows.Forms.Button();
            this.tabManage = new System.Windows.Forms.TabControl();
            this.panel2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabManage.SuspendLayout();
            this.SuspendLayout();
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
            this.panel2.Size = new System.Drawing.Size(158, 498);
            this.panel2.TabIndex = 3;
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
            this.btnBack.Location = new System.Drawing.Point(17, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(121, 38);
            this.btnBack.TabIndex = 26;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Gray;
            this.tabPage1.Controls.Add(this.btnInventory);
            this.tabPage1.Controls.Add(this.btnSupplier);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(670, 453);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Job";
            // 
            // btnInventory
            // 
            this.btnInventory.BackColor = System.Drawing.Color.AliceBlue;
            this.btnInventory.Location = new System.Drawing.Point(378, 153);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Size = new System.Drawing.Size(112, 114);
            this.btnInventory.TabIndex = 1;
            this.btnInventory.Text = "Cost Calculation";
            this.btnInventory.UseVisualStyleBackColor = false;
            // 
            // btnSupplier
            // 
            this.btnSupplier.BackColor = System.Drawing.Color.AliceBlue;
            this.btnSupplier.Location = new System.Drawing.Point(188, 153);
            this.btnSupplier.Name = "btnSupplier";
            this.btnSupplier.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnSupplier.Size = new System.Drawing.Size(112, 114);
            this.btnSupplier.TabIndex = 0;
            this.btnSupplier.Text = "Manage Jobs";
            this.btnSupplier.UseVisualStyleBackColor = false;
            this.btnSupplier.Click += new System.EventHandler(this.btnSupplier_Click);
            // 
            // tabManage
            // 
            this.tabManage.Controls.Add(this.tabPage1);
            this.tabManage.Location = new System.Drawing.Point(164, 4);
            this.tabManage.Name = "tabManage";
            this.tabManage.SelectedIndex = 0;
            this.tabManage.Size = new System.Drawing.Size(678, 482);
            this.tabManage.TabIndex = 2;
            // 
            // JobCoordinatorDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(854, 498);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.tabManage);
            this.Name = "JobCoordinatorDashboard";
            this.Text = "JobCoordinatorDashboard";
            this.Load += new System.EventHandler(this.JobCoordinatorDashboard_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabManage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnInventory;
        private System.Windows.Forms.Button btnSupplier;
        private System.Windows.Forms.TabControl tabManage;
    }
}