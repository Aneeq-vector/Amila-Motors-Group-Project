namespace Amila_Motors
{
    partial class CustomerCareAssistantDashboard
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
            this.btnJobComplete = new System.Windows.Forms.Button();
            this.btnappointments = new System.Windows.Forms.Button();
            this.btnInquiry = new System.Windows.Forms.Button();
            this.btnManageSupplier = new System.Windows.Forms.Button();
            this.tabManage = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button4 = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabManage.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
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
            this.panel2.TabIndex = 5;
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
            this.btnBack.Text = "Log Out";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Gray;
            this.tabPage1.Controls.Add(this.btnJobComplete);
            this.tabPage1.Controls.Add(this.btnappointments);
            this.tabPage1.Controls.Add(this.btnInquiry);
            this.tabPage1.Controls.Add(this.btnManageSupplier);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(670, 453);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Customers";
            // 
            // btnJobComplete
            // 
            this.btnJobComplete.BackColor = System.Drawing.Color.AliceBlue;
            this.btnJobComplete.Location = new System.Drawing.Point(378, 244);
            this.btnJobComplete.Name = "btnJobComplete";
            this.btnJobComplete.Size = new System.Drawing.Size(112, 114);
            this.btnJobComplete.TabIndex = 3;
            this.btnJobComplete.Text = "Update Job Completions";
            this.btnJobComplete.UseVisualStyleBackColor = false;
            this.btnJobComplete.Click += new System.EventHandler(this.btnJobComplete_Click);
            // 
            // btnappointments
            // 
            this.btnappointments.BackColor = System.Drawing.Color.AliceBlue;
            this.btnappointments.Location = new System.Drawing.Point(188, 244);
            this.btnappointments.Name = "btnappointments";
            this.btnappointments.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnappointments.Size = new System.Drawing.Size(112, 114);
            this.btnappointments.TabIndex = 2;
            this.btnappointments.Text = "Manage Appoinments";
            this.btnappointments.UseVisualStyleBackColor = false;
            this.btnappointments.Click += new System.EventHandler(this.btnappointments_Click);
            // 
            // btnInquiry
            // 
            this.btnInquiry.BackColor = System.Drawing.Color.AliceBlue;
            this.btnInquiry.Location = new System.Drawing.Point(378, 85);
            this.btnInquiry.Name = "btnInquiry";
            this.btnInquiry.Size = new System.Drawing.Size(112, 114);
            this.btnInquiry.TabIndex = 1;
            this.btnInquiry.Text = "Manage Inquiries";
            this.btnInquiry.UseVisualStyleBackColor = false;
            this.btnInquiry.Click += new System.EventHandler(this.btnInquiry_Click);
            // 
            // btnManageSupplier
            // 
            this.btnManageSupplier.BackColor = System.Drawing.Color.AliceBlue;
            this.btnManageSupplier.Location = new System.Drawing.Point(188, 85);
            this.btnManageSupplier.Name = "btnManageSupplier";
            this.btnManageSupplier.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnManageSupplier.Size = new System.Drawing.Size(112, 114);
            this.btnManageSupplier.TabIndex = 0;
            this.btnManageSupplier.Text = "Manage Customers";
            this.btnManageSupplier.UseVisualStyleBackColor = false;
            this.btnManageSupplier.Click += new System.EventHandler(this.btnManageSupplier_Click);
            // 
            // tabManage
            // 
            this.tabManage.Controls.Add(this.tabPage1);
            this.tabManage.Controls.Add(this.tabPage2);
            this.tabManage.Controls.Add(this.tabPage3);
            this.tabManage.Location = new System.Drawing.Point(170, 4);
            this.tabManage.Name = "tabManage";
            this.tabManage.SelectedIndex = 0;
            this.tabManage.Size = new System.Drawing.Size(678, 482);
            this.tabManage.TabIndex = 4;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Gray;
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(670, 453);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Vehicle";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.AliceBlue;
            this.button3.Location = new System.Drawing.Point(279, 169);
            this.button3.Name = "button3";
            this.button3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button3.Size = new System.Drawing.Size(112, 114);
            this.button3.TabIndex = 1;
            this.button3.Text = "Manage Vehicle";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Gray;
            this.tabPage3.Controls.Add(this.button4);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(670, 453);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Incomes";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.AliceBlue;
            this.button4.Location = new System.Drawing.Point(279, 169);
            this.button4.Name = "button4";
            this.button4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button4.Size = new System.Drawing.Size(112, 114);
            this.button4.TabIndex = 1;
            this.button4.Text = "Manage\r\nInvoice";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // CustomerCareAssistantDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(854, 498);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.tabManage);
            this.Name = "CustomerCareAssistantDashboard";
            this.Text = "CustomerCareAssistantDashboard";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabManage.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnInquiry;
        private System.Windows.Forms.Button btnManageSupplier;
        private System.Windows.Forms.TabControl tabManage;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnJobComplete;
        private System.Windows.Forms.Button btnappointments;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}