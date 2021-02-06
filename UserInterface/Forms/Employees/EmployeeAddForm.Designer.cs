
namespace SystemHR.UserInterface.Forms.Employees
{
    partial class EmployeeAddForm
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
            this.grp_General = new System.Windows.Forms.GroupBox();
            this.cmb_Gender = new System.Windows.Forms.ComboBox();
            this.bs_Gender = new System.Windows.Forms.BindingSource(this.components);
            this.dtpick_BirthDate = new System.Windows.Forms.DateTimePicker();
            this.lbl_BirthDate = new System.Windows.Forms.Label();
            this.txt_Pesel = new System.Windows.Forms.TextBox();
            this.lbl_Pesel = new System.Windows.Forms.Label();
            this.lbl_Gender = new System.Windows.Forms.Label();
            this.txt_FirstName = new System.Windows.Forms.TextBox();
            this.lbl_FirstName = new System.Windows.Forms.Label();
            this.txt_LastName = new System.Windows.Forms.TextBox();
            this.lbl_LastName = new System.Windows.Forms.Label();
            this.grp_Contact = new System.Windows.Forms.GroupBox();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.lbl_Email = new System.Windows.Forms.Label();
            this.txt_PhoneNumber = new System.Windows.Forms.TextBox();
            this.lbl_PhoneNumber = new System.Windows.Forms.Label();
            this.grp_IdCard = new System.Windows.Forms.GroupBox();
            this.dtpick_IdCardExpiration = new System.Windows.Forms.DateTimePicker();
            this.dtpick_IdIssueDate = new System.Windows.Forms.DateTimePicker();
            this.lbl_IdCardExpiration = new System.Windows.Forms.Label();
            this.lbl_IDCardIssueDate = new System.Windows.Forms.Label();
            this.txt_IdCardNumber = new System.Windows.Forms.TextBox();
            this.lbl_IdCardNumber = new System.Windows.Forms.Label();
            this.grp_Passport = new System.Windows.Forms.GroupBox();
            this.dtpick_PassportExpiration = new System.Windows.Forms.DateTimePicker();
            this.dtpick_PassportIssueDate = new System.Windows.Forms.DateTimePicker();
            this.lbl_PassportExpiration = new System.Windows.Forms.Label();
            this.lbl_PassportIssueDate = new System.Windows.Forms.Label();
            this.txt_PassportNumber = new System.Windows.Forms.TextBox();
            this.lbl_PassportNumber = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.er_LastName = new System.Windows.Forms.ErrorProvider(this.components);
            this.er_FirstName = new System.Windows.Forms.ErrorProvider(this.components);
            this.er_Pesel = new System.Windows.Forms.ErrorProvider(this.components);
            this.grp_General.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bs_Gender)).BeginInit();
            this.grp_Contact.SuspendLayout();
            this.grp_IdCard.SuspendLayout();
            this.grp_Passport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.er_LastName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.er_FirstName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.er_Pesel)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(22, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dane Identyfikacyjne";
            // 
            // grp_General
            // 
            this.grp_General.Controls.Add(this.cmb_Gender);
            this.grp_General.Controls.Add(this.dtpick_BirthDate);
            this.grp_General.Controls.Add(this.lbl_BirthDate);
            this.grp_General.Controls.Add(this.txt_Pesel);
            this.grp_General.Controls.Add(this.lbl_Pesel);
            this.grp_General.Controls.Add(this.lbl_Gender);
            this.grp_General.Controls.Add(this.txt_FirstName);
            this.grp_General.Controls.Add(this.lbl_FirstName);
            this.grp_General.Controls.Add(this.txt_LastName);
            this.grp_General.Controls.Add(this.lbl_LastName);
            this.grp_General.Location = new System.Drawing.Point(17, 83);
            this.grp_General.Name = "grp_General";
            this.grp_General.Size = new System.Drawing.Size(334, 238);
            this.grp_General.TabIndex = 1;
            this.grp_General.TabStop = false;
            this.grp_General.Text = "Ogólne";
            // 
            // cmb_Gender
            // 
            this.cmb_Gender.DataSource = this.bs_Gender;
            this.cmb_Gender.DisplayMember = "Value";
            this.cmb_Gender.FormattingEnabled = true;
            this.cmb_Gender.Location = new System.Drawing.Point(111, 113);
            this.cmb_Gender.Name = "cmb_Gender";
            this.cmb_Gender.Size = new System.Drawing.Size(200, 24);
            this.cmb_Gender.TabIndex = 10;
            this.cmb_Gender.ValueMember = "Id";
            // 
            // bs_Gender
            // 
            this.bs_Gender.DataSource = typeof(SystemHR.DataAccessLayer.Model.Dictionaries.GenderModel);
            // 
            // dtpick_BirthDate
            // 
            this.dtpick_BirthDate.CustomFormat = " ";
            this.dtpick_BirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpick_BirthDate.Location = new System.Drawing.Point(111, 152);
            this.dtpick_BirthDate.Name = "dtpick_BirthDate";
            this.dtpick_BirthDate.Size = new System.Drawing.Size(200, 22);
            this.dtpick_BirthDate.TabIndex = 9;
            this.dtpick_BirthDate.ValueChanged += new System.EventHandler(this.dtp_ValueChanged);
            // 
            // lbl_BirthDate
            // 
            this.lbl_BirthDate.AutoSize = true;
            this.lbl_BirthDate.Location = new System.Drawing.Point(7, 157);
            this.lbl_BirthDate.Name = "lbl_BirthDate";
            this.lbl_BirthDate.Size = new System.Drawing.Size(105, 17);
            this.lbl_BirthDate.TabIndex = 8;
            this.lbl_BirthDate.Text = "Data urodzenia";
            // 
            // txt_Pesel
            // 
            this.txt_Pesel.Location = new System.Drawing.Point(111, 193);
            this.txt_Pesel.Name = "txt_Pesel";
            this.txt_Pesel.Size = new System.Drawing.Size(200, 22);
            this.txt_Pesel.TabIndex = 7;
            this.txt_Pesel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Pesel_KeyPress);
            this.txt_Pesel.Validated += new System.EventHandler(this.txt_Pesel_Validated);
            // 
            // lbl_Pesel
            // 
            this.lbl_Pesel.AutoSize = true;
            this.lbl_Pesel.Location = new System.Drawing.Point(7, 198);
            this.lbl_Pesel.Name = "lbl_Pesel";
            this.lbl_Pesel.Size = new System.Drawing.Size(52, 17);
            this.lbl_Pesel.TabIndex = 6;
            this.lbl_Pesel.Text = "PESEL";
            // 
            // lbl_Gender
            // 
            this.lbl_Gender.AutoSize = true;
            this.lbl_Gender.Location = new System.Drawing.Point(7, 116);
            this.lbl_Gender.Name = "lbl_Gender";
            this.lbl_Gender.Size = new System.Drawing.Size(35, 17);
            this.lbl_Gender.TabIndex = 4;
            this.lbl_Gender.Text = "Płeć";
            this.lbl_Gender.Click += new System.EventHandler(this.label2_Click);
            // 
            // txt_FirstName
            // 
            this.txt_FirstName.Location = new System.Drawing.Point(111, 70);
            this.txt_FirstName.Name = "txt_FirstName";
            this.txt_FirstName.Size = new System.Drawing.Size(200, 22);
            this.txt_FirstName.TabIndex = 3;
            this.txt_FirstName.TextChanged += new System.EventHandler(this.txt_FirstName_TextChanged);
            // 
            // lbl_FirstName
            // 
            this.lbl_FirstName.AutoSize = true;
            this.lbl_FirstName.Location = new System.Drawing.Point(7, 75);
            this.lbl_FirstName.Name = "lbl_FirstName";
            this.lbl_FirstName.Size = new System.Drawing.Size(33, 17);
            this.lbl_FirstName.TabIndex = 2;
            this.lbl_FirstName.Text = "Imię";
            // 
            // txt_LastName
            // 
            this.txt_LastName.Location = new System.Drawing.Point(111, 29);
            this.txt_LastName.Name = "txt_LastName";
            this.txt_LastName.Size = new System.Drawing.Size(200, 22);
            this.txt_LastName.TabIndex = 1;
            this.txt_LastName.TextChanged += new System.EventHandler(this.txt_LastName_TextChanged);
            // 
            // lbl_LastName
            // 
            this.lbl_LastName.AutoSize = true;
            this.lbl_LastName.Location = new System.Drawing.Point(7, 34);
            this.lbl_LastName.Name = "lbl_LastName";
            this.lbl_LastName.Size = new System.Drawing.Size(67, 17);
            this.lbl_LastName.TabIndex = 0;
            this.lbl_LastName.Text = "Nazwisko";
            // 
            // grp_Contact
            // 
            this.grp_Contact.Controls.Add(this.txt_Email);
            this.grp_Contact.Controls.Add(this.lbl_Email);
            this.grp_Contact.Controls.Add(this.txt_PhoneNumber);
            this.grp_Contact.Controls.Add(this.lbl_PhoneNumber);
            this.grp_Contact.Location = new System.Drawing.Point(17, 340);
            this.grp_Contact.Name = "grp_Contact";
            this.grp_Contact.Size = new System.Drawing.Size(334, 120);
            this.grp_Contact.TabIndex = 3;
            this.grp_Contact.TabStop = false;
            this.grp_Contact.Text = "Kontakt";
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(118, 60);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(200, 22);
            this.txt_Email.TabIndex = 13;
            // 
            // lbl_Email
            // 
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.Location = new System.Drawing.Point(7, 65);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(88, 17);
            this.lbl_Email.TabIndex = 12;
            this.lbl_Email.Text = "Adres E-mail";
            // 
            // txt_PhoneNumber
            // 
            this.txt_PhoneNumber.Location = new System.Drawing.Point(118, 21);
            this.txt_PhoneNumber.Name = "txt_PhoneNumber";
            this.txt_PhoneNumber.Size = new System.Drawing.Size(200, 22);
            this.txt_PhoneNumber.TabIndex = 11;
            // 
            // lbl_PhoneNumber
            // 
            this.lbl_PhoneNumber.AutoSize = true;
            this.lbl_PhoneNumber.Location = new System.Drawing.Point(7, 26);
            this.lbl_PhoneNumber.Name = "lbl_PhoneNumber";
            this.lbl_PhoneNumber.Size = new System.Drawing.Size(78, 17);
            this.lbl_PhoneNumber.TabIndex = 10;
            this.lbl_PhoneNumber.Text = "Nr telefonu";
            // 
            // grp_IdCard
            // 
            this.grp_IdCard.Controls.Add(this.dtpick_IdCardExpiration);
            this.grp_IdCard.Controls.Add(this.dtpick_IdIssueDate);
            this.grp_IdCard.Controls.Add(this.lbl_IdCardExpiration);
            this.grp_IdCard.Controls.Add(this.lbl_IDCardIssueDate);
            this.grp_IdCard.Controls.Add(this.txt_IdCardNumber);
            this.grp_IdCard.Controls.Add(this.lbl_IdCardNumber);
            this.grp_IdCard.Location = new System.Drawing.Point(441, 83);
            this.grp_IdCard.Name = "grp_IdCard";
            this.grp_IdCard.Size = new System.Drawing.Size(321, 154);
            this.grp_IdCard.TabIndex = 4;
            this.grp_IdCard.TabStop = false;
            this.grp_IdCard.Text = "Dowód osobisty";
            // 
            // dtpick_IdCardExpiration
            // 
            this.dtpick_IdCardExpiration.CustomFormat = " ";
            this.dtpick_IdCardExpiration.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpick_IdCardExpiration.Location = new System.Drawing.Point(115, 111);
            this.dtpick_IdCardExpiration.Name = "dtpick_IdCardExpiration";
            this.dtpick_IdCardExpiration.Size = new System.Drawing.Size(200, 22);
            this.dtpick_IdCardExpiration.TabIndex = 15;
            this.dtpick_IdCardExpiration.ValueChanged += new System.EventHandler(this.dtp_ValueChanged);
            // 
            // dtpick_IdIssueDate
            // 
            this.dtpick_IdIssueDate.CustomFormat = " ";
            this.dtpick_IdIssueDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpick_IdIssueDate.Location = new System.Drawing.Point(115, 68);
            this.dtpick_IdIssueDate.Name = "dtpick_IdIssueDate";
            this.dtpick_IdIssueDate.Size = new System.Drawing.Size(200, 22);
            this.dtpick_IdIssueDate.TabIndex = 10;
            this.dtpick_IdIssueDate.ValueChanged += new System.EventHandler(this.dtp_ValueChanged);
            // 
            // lbl_IdCardExpiration
            // 
            this.lbl_IdCardExpiration.AutoSize = true;
            this.lbl_IdCardExpiration.Location = new System.Drawing.Point(11, 114);
            this.lbl_IdCardExpiration.Name = "lbl_IdCardExpiration";
            this.lbl_IdCardExpiration.Size = new System.Drawing.Size(99, 17);
            this.lbl_IdCardExpiration.TabIndex = 14;
            this.lbl_IdCardExpiration.Text = "Data ważności";
            // 
            // lbl_IDCardIssueDate
            // 
            this.lbl_IDCardIssueDate.AutoSize = true;
            this.lbl_IDCardIssueDate.Location = new System.Drawing.Point(11, 73);
            this.lbl_IDCardIssueDate.Name = "lbl_IDCardIssueDate";
            this.lbl_IDCardIssueDate.Size = new System.Drawing.Size(93, 17);
            this.lbl_IDCardIssueDate.TabIndex = 12;
            this.lbl_IDCardIssueDate.Text = "Data wydania";
            // 
            // txt_IdCardNumber
            // 
            this.txt_IdCardNumber.Location = new System.Drawing.Point(115, 29);
            this.txt_IdCardNumber.Name = "txt_IdCardNumber";
            this.txt_IdCardNumber.Size = new System.Drawing.Size(200, 22);
            this.txt_IdCardNumber.TabIndex = 11;
            // 
            // lbl_IdCardNumber
            // 
            this.lbl_IdCardNumber.AutoSize = true;
            this.lbl_IdCardNumber.Location = new System.Drawing.Point(11, 32);
            this.lbl_IdCardNumber.Name = "lbl_IdCardNumber";
            this.lbl_IdCardNumber.Size = new System.Drawing.Size(76, 17);
            this.lbl_IdCardNumber.TabIndex = 10;
            this.lbl_IdCardNumber.Text = "Nr dowodu";
            // 
            // grp_Passport
            // 
            this.grp_Passport.Controls.Add(this.dtpick_PassportExpiration);
            this.grp_Passport.Controls.Add(this.dtpick_PassportIssueDate);
            this.grp_Passport.Controls.Add(this.lbl_PassportExpiration);
            this.grp_Passport.Controls.Add(this.lbl_PassportIssueDate);
            this.grp_Passport.Controls.Add(this.txt_PassportNumber);
            this.grp_Passport.Controls.Add(this.lbl_PassportNumber);
            this.grp_Passport.Location = new System.Drawing.Point(441, 253);
            this.grp_Passport.Name = "grp_Passport";
            this.grp_Passport.Size = new System.Drawing.Size(321, 154);
            this.grp_Passport.TabIndex = 16;
            this.grp_Passport.TabStop = false;
            this.grp_Passport.Text = "Paszport";
            // 
            // dtpick_PassportExpiration
            // 
            this.dtpick_PassportExpiration.CustomFormat = " ";
            this.dtpick_PassportExpiration.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpick_PassportExpiration.Location = new System.Drawing.Point(115, 111);
            this.dtpick_PassportExpiration.Name = "dtpick_PassportExpiration";
            this.dtpick_PassportExpiration.Size = new System.Drawing.Size(200, 22);
            this.dtpick_PassportExpiration.TabIndex = 15;
            this.dtpick_PassportExpiration.ValueChanged += new System.EventHandler(this.dtp_ValueChanged);
            // 
            // dtpick_PassportIssueDate
            // 
            this.dtpick_PassportIssueDate.CustomFormat = " ";
            this.dtpick_PassportIssueDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpick_PassportIssueDate.Location = new System.Drawing.Point(115, 68);
            this.dtpick_PassportIssueDate.Name = "dtpick_PassportIssueDate";
            this.dtpick_PassportIssueDate.Size = new System.Drawing.Size(200, 22);
            this.dtpick_PassportIssueDate.TabIndex = 10;
            this.dtpick_PassportIssueDate.ValueChanged += new System.EventHandler(this.dtp_ValueChanged);
            // 
            // lbl_PassportExpiration
            // 
            this.lbl_PassportExpiration.AutoSize = true;
            this.lbl_PassportExpiration.Location = new System.Drawing.Point(11, 114);
            this.lbl_PassportExpiration.Name = "lbl_PassportExpiration";
            this.lbl_PassportExpiration.Size = new System.Drawing.Size(99, 17);
            this.lbl_PassportExpiration.TabIndex = 14;
            this.lbl_PassportExpiration.Text = "Data ważności";
            // 
            // lbl_PassportIssueDate
            // 
            this.lbl_PassportIssueDate.AutoSize = true;
            this.lbl_PassportIssueDate.Location = new System.Drawing.Point(11, 73);
            this.lbl_PassportIssueDate.Name = "lbl_PassportIssueDate";
            this.lbl_PassportIssueDate.Size = new System.Drawing.Size(93, 17);
            this.lbl_PassportIssueDate.TabIndex = 12;
            this.lbl_PassportIssueDate.Text = "Data wydania";
            // 
            // txt_PassportNumber
            // 
            this.txt_PassportNumber.Location = new System.Drawing.Point(115, 29);
            this.txt_PassportNumber.Name = "txt_PassportNumber";
            this.txt_PassportNumber.Size = new System.Drawing.Size(200, 22);
            this.txt_PassportNumber.TabIndex = 11;
            // 
            // lbl_PassportNumber
            // 
            this.lbl_PassportNumber.AutoSize = true;
            this.lbl_PassportNumber.Location = new System.Drawing.Point(11, 32);
            this.lbl_PassportNumber.Name = "lbl_PassportNumber";
            this.lbl_PassportNumber.Size = new System.Drawing.Size(90, 17);
            this.lbl_PassportNumber.TabIndex = 10;
            this.lbl_PassportNumber.Text = "Nr paszportu";
            // 
            // btn_cancel
            // 
            this.btn_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_cancel.Image = global::SystemHR.UserInterface.Properties.Resources.dismiss_241;
            this.btn_cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cancel.Location = new System.Drawing.Point(654, 413);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(108, 47);
            this.btn_cancel.TabIndex = 18;
            this.btn_cancel.Text = "Anuluj";
            this.btn_cancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_save
            // 
            this.btn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_save.Image = global::SystemHR.UserInterface.Properties.Resources.save_32;
            this.btn_save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_save.Location = new System.Drawing.Point(516, 413);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(112, 47);
            this.btn_save.TabIndex = 17;
            this.btn_save.Text = "Zapisz";
            this.btn_save.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SystemHR.UserInterface.Properties.Resources.employee_64;
            this.pictureBox1.Location = new System.Drawing.Point(706, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(56, 54);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // er_LastName
            // 
            this.er_LastName.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.er_LastName.ContainerControl = this;
            // 
            // er_FirstName
            // 
            this.er_FirstName.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.er_FirstName.ContainerControl = this;
            // 
            // er_Pesel
            // 
            this.er_Pesel.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.er_Pesel.ContainerControl = this;
            // 
            // EmployeeAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 472);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.grp_Passport);
            this.Controls.Add(this.grp_IdCard);
            this.Controls.Add(this.grp_Contact);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.grp_General);
            this.Controls.Add(this.label1);
            this.KeyPreview = true;
            this.Name = "EmployeeAddForm";
            this.Text = "Dodaj pracownika";
            this.Load += new System.EventHandler(this.EmployeeAddForm_Load);
            this.grp_General.ResumeLayout(false);
            this.grp_General.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bs_Gender)).EndInit();
            this.grp_Contact.ResumeLayout(false);
            this.grp_Contact.PerformLayout();
            this.grp_IdCard.ResumeLayout(false);
            this.grp_IdCard.PerformLayout();
            this.grp_Passport.ResumeLayout(false);
            this.grp_Passport.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.er_LastName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.er_FirstName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.er_Pesel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grp_General;
        private System.Windows.Forms.Label lbl_Gender;
        private System.Windows.Forms.TextBox txt_FirstName;
        private System.Windows.Forms.Label lbl_FirstName;
        private System.Windows.Forms.TextBox txt_LastName;
        private System.Windows.Forms.Label lbl_LastName;
        private System.Windows.Forms.DateTimePicker dtpick_BirthDate;
        private System.Windows.Forms.Label lbl_BirthDate;
        private System.Windows.Forms.TextBox txt_Pesel;
        private System.Windows.Forms.Label lbl_Pesel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox grp_Contact;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.Label lbl_Email;
        private System.Windows.Forms.TextBox txt_PhoneNumber;
        private System.Windows.Forms.Label lbl_PhoneNumber;
        private System.Windows.Forms.GroupBox grp_IdCard;
        private System.Windows.Forms.DateTimePicker dtpick_IdIssueDate;
        private System.Windows.Forms.Label lbl_IdCardExpiration;
        private System.Windows.Forms.Label lbl_IDCardIssueDate;
        private System.Windows.Forms.TextBox txt_IdCardNumber;
        private System.Windows.Forms.Label lbl_IdCardNumber;
        private System.Windows.Forms.DateTimePicker dtpick_IdCardExpiration;
        private System.Windows.Forms.GroupBox grp_Passport;
        private System.Windows.Forms.DateTimePicker dtpick_PassportExpiration;
        private System.Windows.Forms.DateTimePicker dtpick_PassportIssueDate;
        private System.Windows.Forms.Label lbl_PassportExpiration;
        private System.Windows.Forms.Label lbl_PassportIssueDate;
        private System.Windows.Forms.TextBox txt_PassportNumber;
        private System.Windows.Forms.Label lbl_PassportNumber;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.ComboBox cmb_Gender;
        private System.Windows.Forms.BindingSource bs_Gender;
        private System.Windows.Forms.ErrorProvider er_LastName;
        private System.Windows.Forms.ErrorProvider er_FirstName;
        private System.Windows.Forms.ErrorProvider er_Pesel;
    }
}