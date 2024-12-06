namespace Amila_Motors
{
    partial class SystemAdministratorDashboard
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
            this.btnSupplier = new System.Windows.Forms.Button();
            this.btnLabor = new System.Windows.Forms.Button();
            this.tabManage = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabManage.SuspendLayout();
            this.tabPage2.SuspendLayout();
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
            this.panel2.TabIndex = 9;
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
            this.tabPage1.Controls.Add(this.btnSupplier);
            this.tabPage1.Controls.Add(this.btnLabor);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(670, 453);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Users";
            // 
            // btnSupplier
            // 
            this.btnSupplier.BackColor = System.Drawing.Color.AliceBlue;
            this.btnSupplier.Location = new System.Drawing.Point(357, 144);
            this.btnSupplier.Name = "btnSupplier";
            this.btnSupplier.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnSupplier.Size = new System.Drawing.Size(112, 114);
            this.btnSupplier.TabIndex = 4;
            this.btnSupplier.Text = "Manage Supplier";
            this.btnSupplier.UseVisualStyleBackColor = false;
            // 
            // btnLabor
            // 
            this.btnLabor.BackColor = System.Drawing.Color.AliceBlue;
            this.btnLabor.Location = new System.Drawing.Point(174, 144);
            this.btnLabor.Name = "btnLabor";
            this.btnLabor.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnLabor.Size = new System.Drawing.Size(112, 114);
            this.btnLabor.TabIndex = 3;
            this.btnLabor.Text = "Manage Labor";
            this.btnLabor.UseVisualStyleBackColor = false;
            // 
            // tabManage
            // 
            this.tabManage.Controls.Add(this.tabPage1);
            this.tabManage.Controls.Add(this.tabPage2);
            this.tabManage.Location = new System.Drawing.Point(175, 4);
            this.tabManage.Name = "tabManage";
            this.tabManage.SelectedIndex = 0;
            this.tabManage.Size = new System.Drawing.Size(678, 482);
            this.tabManage.TabIndex = 8;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Gray;
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(670, 453);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Backup";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.AliceBlue;
            this.button1.Location = new System.Drawing.Point(279, 169);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 114);
            this.button1.TabIndex = 4;
            this.button1.Text = "System Backup\r\nand\r\nRestore";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // SystemAdministratorDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(854, 498);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.tabManage);
            this.Name = "SystemAdministratorDashboard";
            this.Text = "SystemAdministratorDashboard";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabManage.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl tabManage;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSupplier;
        private System.Windows.Forms.Button btnLabor;
    }
}