using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SystemHR.DataAccessLayer;
using SystemHR.DataAccessLayer.Model;
using SystemHR.DataAccessLayer.Model.Dictionaries;
using SystemHR.UserInterface.Classes;
using SystemHR.UserInterface.Extensions;
using SystemHR.UserInterface.Helpers;

namespace SystemHR.UserInterface.Forms.Employees
{
    public partial class EmployeeEditForm : BaseAddEditForm
    {
        #region Fields
        public EventHandler ReloadEmployees;
        private EmployeeModel employee;

        #endregion

        #region Constructor

        public EmployeeEditForm(int employeeId)
        {
            InitializeComponent();
            InitializeData();
            employee = GlobalConfig.Connection.GetEmployee(employeeId);
            PrepareEmpoyeeDatat(employee);
            ValidateControls();
        }

        private void PrepareEmpoyeeDatat(EmployeeModel employee)
        {
            txt_LastName.Text = employee.LastName;
            txt_FirstName.Text = employee.FirstName;
            cmb_Gender.Text = (employee.Gender != null)?employee.Gender.Value:null;
            dtpick_BirthDate.Value = employee.BirthDate.Value;
            txt_Pesel.Text = employee.PESEL;
            txt_PhoneNumber.Text = employee.PESEL;
            txt_Email.Text = employee.EmailAdress;
            txt_IdCardNumber.Text = employee.IdentityCardNumber;
            dtpick_IdIssueDate.Value = employee.IssueDateIndentityCard.Value;
            dtpick_IdCardExpiration.Value = employee.ExpirationDateIdentityCard.Value;
            txt_PassportNumber.Text = employee.PassportNumber;
            dtpick_PassportIssueDate.Value = employee.IssueDatePassport.Value;
            dtpick_PassportExpiration.Value = employee.ExpirationDatePassport.Value;

            lbl_EmployeeData.Text = $"{employee.FirstName} {employee.LastName} {employee.Code.ToString().PadLeft(4, '0')} - {employee.Status.Value}";
        }


        #endregion

        #region Private Methods
        private EmployeeModel GetFakeEmployee(int employeeId)
        {
            IList<EmployeeModel> fakeEmployeesModel = new List<EmployeeModel>();
            fakeEmployeesModel.Add(new EmployeeModel()
            {
                Id = 1,
                LastName = "Nowak",
                FirstName = "Jan",
                Code = 2,
                Gender = new GenderModel("mężczyzna"),
                BirthDate = new DateTime(1992, 11, 11),
                PESEL = "12334232",
                EmailAdress = "dla@dlad.pd",
                IdentityCardNumber = "aldf334",
                IssueDateIndentityCard = new DateTime(2020, 11, 11),
                ExpirationDateIdentityCard = new DateTime(2020, 11, 12),
                PassportNumber = "eafdasf23923",
                IssueDatePassport = new DateTime(2019, 8, 14),
                ExpirationDatePassport = new DateTime(2019, 1, 1),
                Status = new StatusModel("wprowadzony")
            });

            fakeEmployeesModel.Add(new EmployeeModel()
            {
                Id = 2,
                LastName = "Kowalski",
                FirstName = "Wojtek",
                Code = 1,
                Gender = new GenderModel("mężczyzna"),
                BirthDate = new DateTime(1992, 11, 11),
                PESEL = "12334232",
                EmailAdress = "dla@dlad.pd",
                IdentityCardNumber = "aldf334",
                IssueDateIndentityCard = new DateTime(2020, 11, 11),
                ExpirationDateIdentityCard = new DateTime(2020, 11, 12),
                PassportNumber = "eafdasf23923",
                IssueDatePassport = new DateTime(2019, 8, 14),
                ExpirationDatePassport = new DateTime(2019, 1, 1),
                Status = new StatusModel("uprowadzony")
            });

            fakeEmployeesModel.Add(new EmployeeModel()
            {
                Id = 3,
                LastName = "Smith",
                FirstName = "John",
                Code = 3,
                Gender = new GenderModel("mężczyzna"),
                BirthDate = new DateTime(1992, 11, 11),
                PESEL = "12334232",
                EmailAdress = "dla@dlad.pd",
                IdentityCardNumber = "aldf334",
                IssueDateIndentityCard = new DateTime(2020, 11, 11),
                ExpirationDateIdentityCard = new DateTime(2020, 11, 12),
                PassportNumber = "eafdasf23923",
                IssueDatePassport = new DateTime(2019, 8, 14),
                ExpirationDatePassport = new DateTime(2019, 1, 1),
                Status = new StatusModel("doprowadzony")
            });

            EmployeeModel fakeEmployeeModel = fakeEmployeesModel.Where(x => x.Id == employeeId).FirstOrDefault();
            return fakeEmployeeModel;
        }

        private void ValidateControls()
        {
            if (string.IsNullOrEmpty(txt_FirstName.Text))
                er_FirstName.SetError(txt_FirstName, "Pole Imię jest wymgane");
            else er_FirstName.Clear();

            if (string.IsNullOrEmpty(txt_LastName.Text))
                er_LastName.SetError(txt_LastName, "Pole Nazwisko jest wymgane");
            else er_LastName.Clear();
        }

        private void InitializeData()
        {
            IList<GenderModel> genders = new List<GenderModel>()
            { new GenderModel("Kobieta"),
            new GenderModel("Mężczyzna"),
            new GenderModel(" ")
            };

            bs_Gender.DataSource = genders;
            cmb_Gender.Text = " ";
        }

        

        private bool ValidateForm()
        {
            StringBuilder sbErrorMessage = new StringBuilder();
            string LastNameErrorMessage = er_LastName.GetError(txt_LastName);
            if (!string.IsNullOrEmpty(LastNameErrorMessage))
                sbErrorMessage.Append(LastNameErrorMessage);

            string FirstNameErrorMessage = er_FirstName.GetError(txt_FirstName);
            if (!string.IsNullOrEmpty(FirstNameErrorMessage))
                sbErrorMessage.Append("\n" + FirstNameErrorMessage);

            if (sbErrorMessage.Length > 0)
            {
                MessageBox.Show(
                    sbErrorMessage.ToString(),
                    "Dodawanie pracownika",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }

            string peselWarningMessage = er_Pesel.GetError(txt_Pesel);
            if (!string.IsNullOrEmpty(peselWarningMessage))
            {
                DialogResult answer =
                    MessageBox.Show(
                        peselWarningMessage + "\nCzy mimo to chcesz dodać pracownika",
                        "Dodawawnie pracownika",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning);
                if (answer == DialogResult.No)
                    return false;
            }

            return true;
        }

        
        #endregion

        #region Events
        private void btn_save_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Cancel();
        }

        private void dtp_ValueChanged(object sender, EventArgs e)
        {
            DateTimePicker dtp = sender as DateTimePicker;
            dtp.DateTimePickerValueChanged();
        }

        private void txt_LastName_TextChanged(object sender, EventArgs e)
        {
            ValidateControls();
        }

        private void txt_FirstName_TextChanged(object sender, EventArgs e)
        {
            ValidateControls();
        }

        private void txt_Pesel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txt_Pesel_Validated(object sender, EventArgs e)
        {
            string pesel = txt_Pesel.Text;

            if (ValidatorHelper.IsValidPESEL(pesel))
                er_Pesel.Clear();
            else if (!string.IsNullOrEmpty(pesel))
                er_Pesel.SetError(txt_Pesel, "Numer PESEL nieprawidłowy");


        }
        #endregion

        #region Override Methods
        protected override void Save()
        {
            if (ValidateForm())
            {
                employee.LastName = txt_LastName.Text;
                employee.FirstName = txt_FirstName.Text;
                employee.Gender = new GenderModel(cmb_Gender.Text);
                employee.BirthDate = dtpick_BirthDate.Value;
                employee.PESEL = txt_Pesel.Text;
                employee.PhoneNumber = txt_PhoneNumber.Text;
                employee.EmailAdress = txt_Email.Text;
                employee.IdentityCardNumber = txt_IdCardNumber.Text;
                employee.IssueDateIndentityCard = dtpick_IdIssueDate.Value;
                employee.ExpirationDateIdentityCard = dtpick_IdCardExpiration.Value;
                employee.PassportNumber = txt_PassportNumber.Text;
                employee.IssueDatePassport = dtpick_PassportIssueDate.Value;
                employee.ExpirationDatePassport = dtpick_PassportExpiration.Value;
               

                //employee = ModifyEmployee(employee);
               

                ReloadEmployees?.Invoke(btn_save, new EmployeeEventArgs(employee));




                Close();

            }


            MessageBox.Show("Zapisano");
        }

        protected override void Cancel()
        {
            MessageBox.Show("Anulowano");
            Close();
        }
        #endregion
    }
}
