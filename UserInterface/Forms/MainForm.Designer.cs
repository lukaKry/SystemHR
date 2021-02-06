
namespace SystemHR.UserInterface.Forms
{
    partial class MainForm
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
            this.tcMain = new System.Windows.Forms.TabControl();
            this.tpGeneral = new System.Windows.Forms.TabPage();
            this.btn_Positions = new System.Windows.Forms.Button();
            this.splitter5 = new System.Windows.Forms.Splitter();
            this.btn_Departments = new System.Windows.Forms.Button();
            this.splitter4 = new System.Windows.Forms.Splitter();
            this.btn_Salaries = new System.Windows.Forms.Button();
            this.splitter3 = new System.Windows.Forms.Splitter();
            this.btn_OrganizationStructure = new System.Windows.Forms.Button();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.btn_contracts = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.btn_Employees = new System.Windows.Forms.Button();
            this.tpConfiguration = new System.Windows.Forms.TabPage();
            this.ssMain = new System.Windows.Forms.StatusStrip();
            this.tssl_Version = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssl_Database = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssl_User = new System.Windows.Forms.ToolStripStatusLabel();
            this.pMain = new System.Windows.Forms.Panel();
            this.tcTab = new System.Windows.Forms.TabControl();
            this.tcMain.SuspendLayout();
            this.tpGeneral.SuspendLayout();
            this.ssMain.SuspendLayout();
            this.pMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcMain
            // 
            this.tcMain.Controls.Add(this.tpGeneral);
            this.tcMain.Controls.Add(this.tpConfiguration);
            this.tcMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.tcMain.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tcMain.Location = new System.Drawing.Point(0, 0);
            this.tcMain.Margin = new System.Windows.Forms.Padding(4);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(872, 83);
            this.tcMain.TabIndex = 0;
            // 
            // tpGeneral
            // 
            this.tpGeneral.Controls.Add(this.btn_Positions);
            this.tpGeneral.Controls.Add(this.splitter5);
            this.tpGeneral.Controls.Add(this.btn_Departments);
            this.tpGeneral.Controls.Add(this.splitter4);
            this.tpGeneral.Controls.Add(this.btn_Salaries);
            this.tpGeneral.Controls.Add(this.splitter3);
            this.tpGeneral.Controls.Add(this.btn_OrganizationStructure);
            this.tpGeneral.Controls.Add(this.splitter2);
            this.tpGeneral.Controls.Add(this.btn_contracts);
            this.tpGeneral.Controls.Add(this.splitter1);
            this.tpGeneral.Controls.Add(this.btn_Employees);
            this.tpGeneral.Location = new System.Drawing.Point(4, 29);
            this.tpGeneral.Margin = new System.Windows.Forms.Padding(4);
            this.tpGeneral.Name = "tpGeneral";
            this.tpGeneral.Padding = new System.Windows.Forms.Padding(4);
            this.tpGeneral.Size = new System.Drawing.Size(864, 50);
            this.tpGeneral.TabIndex = 0;
            this.tpGeneral.Text = "Ogólne";
            this.tpGeneral.UseVisualStyleBackColor = true;
            // 
            // btn_Positions
            // 
            this.btn_Positions.BackColor = System.Drawing.Color.White;
            this.btn_Positions.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_Positions.Image = global::SystemHR.UserInterface.Properties.Resources.Positions_32;
            this.btn_Positions.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Positions.Location = new System.Drawing.Point(738, 4);
            this.btn_Positions.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Positions.Name = "btn_Positions";
            this.btn_Positions.Size = new System.Drawing.Size(123, 42);
            this.btn_Positions.TabIndex = 10;
            this.btn_Positions.Text = "Stanowiska";
            this.btn_Positions.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Positions.UseVisualStyleBackColor = false;
            // 
            // splitter5
            // 
            this.splitter5.Location = new System.Drawing.Point(733, 4);
            this.splitter5.Margin = new System.Windows.Forms.Padding(4);
            this.splitter5.Name = "splitter5";
            this.splitter5.Size = new System.Drawing.Size(5, 42);
            this.splitter5.TabIndex = 9;
            this.splitter5.TabStop = false;
            // 
            // btn_Departments
            // 
            this.btn_Departments.BackColor = System.Drawing.Color.White;
            this.btn_Departments.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_Departments.Image = global::SystemHR.UserInterface.Properties.Resources.Departments_32;
            this.btn_Departments.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Departments.Location = new System.Drawing.Point(631, 4);
            this.btn_Departments.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Departments.Name = "btn_Departments";
            this.btn_Departments.Size = new System.Drawing.Size(102, 42);
            this.btn_Departments.TabIndex = 8;
            this.btn_Departments.Text = "Działy";
            this.btn_Departments.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Departments.UseVisualStyleBackColor = false;
            // 
            // splitter4
            // 
            this.splitter4.Location = new System.Drawing.Point(626, 4);
            this.splitter4.Margin = new System.Windows.Forms.Padding(4);
            this.splitter4.Name = "splitter4";
            this.splitter4.Size = new System.Drawing.Size(5, 42);
            this.splitter4.TabIndex = 7;
            this.splitter4.TabStop = false;
            // 
            // btn_Salaries
            // 
            this.btn_Salaries.BackColor = System.Drawing.Color.White;
            this.btn_Salaries.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_Salaries.Image = global::SystemHR.UserInterface.Properties.Resources.Salary_32;
            this.btn_Salaries.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Salaries.Location = new System.Drawing.Point(462, 4);
            this.btn_Salaries.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Salaries.Name = "btn_Salaries";
            this.btn_Salaries.Size = new System.Drawing.Size(164, 42);
            this.btn_Salaries.TabIndex = 6;
            this.btn_Salaries.Text = "Wynagrodzenia";
            this.btn_Salaries.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Salaries.UseVisualStyleBackColor = false;
            // 
            // splitter3
            // 
            this.splitter3.Location = new System.Drawing.Point(457, 4);
            this.splitter3.Margin = new System.Windows.Forms.Padding(4);
            this.splitter3.Name = "splitter3";
            this.splitter3.Size = new System.Drawing.Size(5, 42);
            this.splitter3.TabIndex = 5;
            this.splitter3.TabStop = false;
            // 
            // btn_OrganizationStructure
            // 
            this.btn_OrganizationStructure.BackColor = System.Drawing.Color.White;
            this.btn_OrganizationStructure.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_OrganizationStructure.Image = global::SystemHR.UserInterface.Properties.Resources.OrganizationalUnits_32;
            this.btn_OrganizationStructure.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_OrganizationStructure.Location = new System.Drawing.Point(249, 4);
            this.btn_OrganizationStructure.Margin = new System.Windows.Forms.Padding(4);
            this.btn_OrganizationStructure.Name = "btn_OrganizationStructure";
            this.btn_OrganizationStructure.Size = new System.Drawing.Size(208, 42);
            this.btn_OrganizationStructure.TabIndex = 4;
            this.btn_OrganizationStructure.Text = "Struktura organizacyjna";
            this.btn_OrganizationStructure.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_OrganizationStructure.UseVisualStyleBackColor = false;
            // 
            // splitter2
            // 
            this.splitter2.Location = new System.Drawing.Point(244, 4);
            this.splitter2.Margin = new System.Windows.Forms.Padding(4);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(5, 42);
            this.splitter2.TabIndex = 3;
            this.splitter2.TabStop = false;
            // 
            // btn_contracts
            // 
            this.btn_contracts.BackColor = System.Drawing.Color.White;
            this.btn_contracts.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_contracts.Image = global::SystemHR.UserInterface.Properties.Resources.Contracts_32;
            this.btn_contracts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_contracts.Location = new System.Drawing.Point(137, 4);
            this.btn_contracts.Margin = new System.Windows.Forms.Padding(4);
            this.btn_contracts.Name = "btn_contracts";
            this.btn_contracts.Size = new System.Drawing.Size(107, 42);
            this.btn_contracts.TabIndex = 2;
            this.btn_contracts.Text = "Umowy";
            this.btn_contracts.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_contracts.UseVisualStyleBackColor = false;
            this.btn_contracts.Click += new System.EventHandler(this.btn_contracts_Click);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(132, 4);
            this.splitter1.Margin = new System.Windows.Forms.Padding(4);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(5, 42);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // btn_Employees
            // 
            this.btn_Employees.BackColor = System.Drawing.Color.White;
            this.btn_Employees.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_Employees.Image = global::SystemHR.UserInterface.Properties.Resources.Emplyees_32;
            this.btn_Employees.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Employees.Location = new System.Drawing.Point(4, 4);
            this.btn_Employees.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Employees.Name = "btn_Employees";
            this.btn_Employees.Size = new System.Drawing.Size(128, 42);
            this.btn_Employees.TabIndex = 0;
            this.btn_Employees.Text = "Pracownicy";
            this.btn_Employees.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Employees.UseVisualStyleBackColor = false;
            this.btn_Employees.Click += new System.EventHandler(this.btn_Employees_Click);
            // 
            // tpConfiguration
            // 
            this.tpConfiguration.Location = new System.Drawing.Point(4, 29);
            this.tpConfiguration.Margin = new System.Windows.Forms.Padding(4);
            this.tpConfiguration.Name = "tpConfiguration";
            this.tpConfiguration.Padding = new System.Windows.Forms.Padding(4);
            this.tpConfiguration.Size = new System.Drawing.Size(864, 50);
            this.tpConfiguration.TabIndex = 1;
            this.tpConfiguration.Text = "Konfiguracja";
            this.tpConfiguration.UseVisualStyleBackColor = true;
            // 
            // ssMain
            // 
            this.ssMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ssMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssl_Version,
            this.tssl_Database,
            this.tssl_User});
            this.ssMain.Location = new System.Drawing.Point(0, 527);
            this.ssMain.Name = "ssMain";
            this.ssMain.Padding = new System.Windows.Forms.Padding(1, 0, 15, 0);
            this.ssMain.Size = new System.Drawing.Size(872, 26);
            this.ssMain.TabIndex = 1;
            this.ssMain.Text = "statusStrip1";
            // 
            // tssl_Version
            // 
            this.tssl_Version.Name = "tssl_Version";
            this.tssl_Version.Size = new System.Drawing.Size(101, 20);
            this.tssl_Version.Text = "Werjsa: 1.0.0.0";
            // 
            // tssl_Database
            // 
            this.tssl_Database.Image = global::SystemHR.UserInterface.Properties.Resources.Database_16;
            this.tssl_Database.Name = "tssl_Database";
            this.tssl_Database.Size = new System.Drawing.Size(182, 20);
            this.tssl_Database.Text = "Baza: HumanResources";
            // 
            // tssl_User
            // 
            this.tssl_User.Image = global::SystemHR.UserInterface.Properties.Resources.User_16;
            this.tssl_User.Name = "tssl_User";
            this.tssl_User.Size = new System.Drawing.Size(207, 20);
            this.tssl_User.Text = "Użytkownik: Łukasz Kryszak";
            // 
            // pMain
            // 
            this.pMain.BackColor = System.Drawing.Color.White;
            this.pMain.Controls.Add(this.tcTab);
            this.pMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pMain.Location = new System.Drawing.Point(0, 83);
            this.pMain.Margin = new System.Windows.Forms.Padding(4);
            this.pMain.Name = "pMain";
            this.pMain.Size = new System.Drawing.Size(872, 444);
            this.pMain.TabIndex = 2;
            // 
            // tcTab
            // 
            this.tcTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcTab.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tcTab.ItemSize = new System.Drawing.Size(100, 28);
            this.tcTab.Location = new System.Drawing.Point(0, 0);
            this.tcTab.Name = "tcTab";
            this.tcTab.SelectedIndex = 0;
            this.tcTab.Size = new System.Drawing.Size(872, 444);
            this.tcTab.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tcTab.TabIndex = 0;
            this.tcTab.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tcTab_DrawItem);
            this.tcTab.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tcTab_MouseDown);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 553);
            this.Controls.Add(this.pMain);
            this.Controls.Add(this.ssMain);
            this.Controls.Add(this.tcMain);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sytem HR";
            this.tcMain.ResumeLayout(false);
            this.tpGeneral.ResumeLayout(false);
            this.ssMain.ResumeLayout(false);
            this.ssMain.PerformLayout();
            this.pMain.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tcMain;
        private System.Windows.Forms.TabPage tpGeneral;
        private System.Windows.Forms.Button btn_Positions;
        private System.Windows.Forms.Splitter splitter5;
        private System.Windows.Forms.Button btn_Departments;
        private System.Windows.Forms.Splitter splitter4;
        private System.Windows.Forms.Button btn_Salaries;
        private System.Windows.Forms.Splitter splitter3;
        private System.Windows.Forms.Button btn_OrganizationStructure;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.Button btn_contracts;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Button btn_Employees;
        private System.Windows.Forms.TabPage tpConfiguration;
        private System.Windows.Forms.StatusStrip ssMain;
        private System.Windows.Forms.ToolStripStatusLabel tssl_Version;
        private System.Windows.Forms.ToolStripStatusLabel tssl_Database;
        private System.Windows.Forms.ToolStripStatusLabel tssl_User;
        private System.Windows.Forms.Panel pMain;
        private System.Windows.Forms.TabControl tcTab;
    }
}