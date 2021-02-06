
namespace SystemHR.UserInterface.Forms.Employees
{
    partial class EmployeesForm
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
            this.tlpEmployees = new System.Windows.Forms.TableLayoutPanel();
            this.pEmployees = new System.Windows.Forms.Panel();
            this.btn_sendMail = new System.Windows.Forms.Button();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.btn_remove = new System.Windows.Forms.Button();
            this.btn_dismiss = new System.Windows.Forms.Button();
            this.btn_Modify = new System.Windows.Forms.Button();
            this.btn_create = new System.Windows.Forms.Button();
            this.dgvEmployees = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPosition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsEmployees = new System.Windows.Forms.BindingSource(this.components);
            this.tlpEmployees.SuspendLayout();
            this.pEmployees.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsEmployees)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpEmployees
            // 
            this.tlpEmployees.ColumnCount = 1;
            this.tlpEmployees.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpEmployees.Controls.Add(this.pEmployees, 0, 0);
            this.tlpEmployees.Controls.Add(this.dgvEmployees, 0, 1);
            this.tlpEmployees.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpEmployees.Location = new System.Drawing.Point(0, 0);
            this.tlpEmployees.Name = "tlpEmployees";
            this.tlpEmployees.RowCount = 2;
            this.tlpEmployees.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpEmployees.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpEmployees.Size = new System.Drawing.Size(800, 450);
            this.tlpEmployees.TabIndex = 1;
            // 
            // pEmployees
            // 
            this.pEmployees.Controls.Add(this.btn_sendMail);
            this.pEmployees.Controls.Add(this.btn_refresh);
            this.pEmployees.Controls.Add(this.btn_remove);
            this.pEmployees.Controls.Add(this.btn_dismiss);
            this.pEmployees.Controls.Add(this.btn_Modify);
            this.pEmployees.Controls.Add(this.btn_create);
            this.pEmployees.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pEmployees.Location = new System.Drawing.Point(3, 3);
            this.pEmployees.Name = "pEmployees";
            this.pEmployees.Size = new System.Drawing.Size(794, 34);
            this.pEmployees.TabIndex = 0;
            // 
            // btn_sendMail
            // 
            this.btn_sendMail.BackColor = System.Drawing.Color.White;
            this.btn_sendMail.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_sendMail.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_sendMail.Image = global::SystemHR.UserInterface.Properties.Resources.email_24;
            this.btn_sendMail.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_sendMail.Location = new System.Drawing.Point(664, 0);
            this.btn_sendMail.Name = "btn_sendMail";
            this.btn_sendMail.Size = new System.Drawing.Size(130, 34);
            this.btn_sendMail.TabIndex = 5;
            this.btn_sendMail.Text = "Wyślij e-mail";
            this.btn_sendMail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_sendMail.UseVisualStyleBackColor = false;
            // 
            // btn_refresh
            // 
            this.btn_refresh.BackColor = System.Drawing.Color.White;
            this.btn_refresh.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_refresh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_refresh.Image = global::SystemHR.UserInterface.Properties.Resources.refresh_24;
            this.btn_refresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_refresh.Location = new System.Drawing.Point(390, 0);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(110, 34);
            this.btn_refresh.TabIndex = 4;
            this.btn_refresh.Text = "Odśwież";
            this.btn_refresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_refresh.UseVisualStyleBackColor = false;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // btn_remove
            // 
            this.btn_remove.BackColor = System.Drawing.Color.White;
            this.btn_remove.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_remove.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_remove.Image = global::SystemHR.UserInterface.Properties.Resources.delete_24;
            this.btn_remove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_remove.Location = new System.Drawing.Point(300, 0);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(90, 34);
            this.btn_remove.TabIndex = 3;
            this.btn_remove.Text = "Usuń";
            this.btn_remove.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_remove.UseVisualStyleBackColor = false;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // btn_dismiss
            // 
            this.btn_dismiss.BackColor = System.Drawing.Color.White;
            this.btn_dismiss.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_dismiss.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_dismiss.Image = global::SystemHR.UserInterface.Properties.Resources.dismiss_24;
            this.btn_dismiss.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_dismiss.Location = new System.Drawing.Point(210, 0);
            this.btn_dismiss.Name = "btn_dismiss";
            this.btn_dismiss.Size = new System.Drawing.Size(90, 34);
            this.btn_dismiss.TabIndex = 2;
            this.btn_dismiss.Text = "Zwolnij";
            this.btn_dismiss.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_dismiss.UseVisualStyleBackColor = false;
            // 
            // btn_Modify
            // 
            this.btn_Modify.BackColor = System.Drawing.Color.White;
            this.btn_Modify.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_Modify.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_Modify.Image = global::SystemHR.UserInterface.Properties.Resources.edit_24;
            this.btn_Modify.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Modify.Location = new System.Drawing.Point(90, 0);
            this.btn_Modify.Name = "btn_Modify";
            this.btn_Modify.Size = new System.Drawing.Size(120, 34);
            this.btn_Modify.TabIndex = 1;
            this.btn_Modify.Text = "Modyfikuj";
            this.btn_Modify.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Modify.UseVisualStyleBackColor = false;
            this.btn_Modify.Click += new System.EventHandler(this.btn_Modify_Click);
            // 
            // btn_create
            // 
            this.btn_create.BackColor = System.Drawing.Color.White;
            this.btn_create.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_create.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_create.Image = global::SystemHR.UserInterface.Properties.Resources.add_24;
            this.btn_create.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_create.Location = new System.Drawing.Point(0, 0);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(90, 34);
            this.btn_create.TabIndex = 0;
            this.btn_create.Text = "Dodaj";
            this.btn_create.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_create.UseVisualStyleBackColor = false;
            this.btn_create.Click += new System.EventHandler(this.btn_create_Click);
            // 
            // dgvEmployees
            // 
            this.dgvEmployees.AllowUserToAddRows = false;
            this.dgvEmployees.AllowUserToDeleteRows = false;
            this.dgvEmployees.AutoGenerateColumns = false;
            this.dgvEmployees.BackgroundColor = System.Drawing.Color.White;
            this.dgvEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployees.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colLastName,
            this.colFirstName,
            this.colCode,
            this.colPosition,
            this.colStatus});
            this.dgvEmployees.DataSource = this.bsEmployees;
            this.dgvEmployees.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEmployees.Location = new System.Drawing.Point(3, 43);
            this.dgvEmployees.Name = "dgvEmployees";
            this.dgvEmployees.ReadOnly = true;
            this.dgvEmployees.RowHeadersVisible = false;
            this.dgvEmployees.RowHeadersWidth = 51;
            this.dgvEmployees.RowTemplate.Height = 24;
            this.dgvEmployees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmployees.Size = new System.Drawing.Size(794, 404);
            this.dgvEmployees.TabIndex = 1;
            this.dgvEmployees.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmployees_CellContentClick);
            // 
            // colId
            // 
            this.colId.DataPropertyName = "Id";
            this.colId.HeaderText = "Id";
            this.colId.MinimumWidth = 6;
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            this.colId.Visible = false;
            this.colId.Width = 125;
            // 
            // colLastName
            // 
            this.colLastName.DataPropertyName = "LastName";
            this.colLastName.HeaderText = "Nazwisko";
            this.colLastName.MinimumWidth = 6;
            this.colLastName.Name = "colLastName";
            this.colLastName.ReadOnly = true;
            this.colLastName.ToolTipText = "Nazwisko pracownika";
            this.colLastName.Width = 125;
            // 
            // colFirstName
            // 
            this.colFirstName.DataPropertyName = "FirstName";
            this.colFirstName.HeaderText = "Imię";
            this.colFirstName.MinimumWidth = 6;
            this.colFirstName.Name = "colFirstName";
            this.colFirstName.ReadOnly = true;
            this.colFirstName.ToolTipText = "Imię pracownika";
            this.colFirstName.Width = 125;
            // 
            // colCode
            // 
            this.colCode.DataPropertyName = "Code";
            this.colCode.HeaderText = "Kod";
            this.colCode.MinimumWidth = 6;
            this.colCode.Name = "colCode";
            this.colCode.ReadOnly = true;
            this.colCode.ToolTipText = "Kod pracownika";
            this.colCode.Width = 125;
            // 
            // colPosition
            // 
            this.colPosition.DataPropertyName = "Position";
            this.colPosition.HeaderText = "Stanowisko";
            this.colPosition.MinimumWidth = 6;
            this.colPosition.Name = "colPosition";
            this.colPosition.ReadOnly = true;
            this.colPosition.ToolTipText = "Aktualnie zajmowane stanowisko";
            this.colPosition.Width = 150;
            // 
            // colStatus
            // 
            this.colStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colStatus.DataPropertyName = "Status";
            this.colStatus.HeaderText = "Status";
            this.colStatus.MinimumWidth = 6;
            this.colStatus.Name = "colStatus";
            this.colStatus.ReadOnly = true;
            this.colStatus.ToolTipText = "Status pracownika";
            // 
            // bsEmployees
            // 
            this.bsEmployees.DataSource = typeof(SystemHR.DataAccessLayer.ViewModels.EmployeeViewModel);
            // 
            // EmployeesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tlpEmployees);
            this.Name = "EmployeesForm";
            this.Text = "Pracownicy";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EmployeesForm_FormClosed);
            this.Load += new System.EventHandler(this.EmployeesForm_Load);
            this.tlpEmployees.ResumeLayout(false);
            this.pEmployees.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsEmployees)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpEmployees;
        private System.Windows.Forms.Panel pEmployees;
        private System.Windows.Forms.Button btn_sendMail;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.Button btn_remove;
        private System.Windows.Forms.Button btn_dismiss;
        private System.Windows.Forms.Button btn_Modify;
        private System.Windows.Forms.Button btn_create;
        private System.Windows.Forms.DataGridView dgvEmployees;
        private System.Windows.Forms.BindingSource bsEmployees;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPosition;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
    }
}