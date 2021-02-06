using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SystemHR.DataAccessLayer.Model;
using SystemHR.DataAccessLayer.Model.Dictionaries;
using SystemHR.UserInterface.Classes;
using SystemHR.UserInterface.Extensions;
using SystemHR.UserInterface.Helpers;

namespace SystemHR.UserInterface.Forms.Employees
{
    public partial class EmployeeAddForm : BaseAddEditForm
    {
        public EventHandler ReloadEmployees;


        public EmployeeAddForm()
        {
            InitializeComponent();
            InitializeData();
            ValidateControls();
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

        private void EmployeeAddForm_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Cancel();
        }

        protected override void Save()
        {
            if (ValidateForm())
            {
                EmployeeModel employee = new EmployeeModel()
                { LastName = txt_LastName.Text,
                    FirstName = txt_FirstName.Text,
                    Gender = new GenderModel(cmb_Gender.Text),
                    BirthDate = dtpick_BirthDate.Value,
                    PESEL = txt_Pesel.Text,
                    PhoneNumber = txt_PhoneNumber.Text,
                    EmailAdress = txt_Email.Text,
                    IdentityCardNumber = txt_IdCardNumber.Text,
                    IssueDateIndentityCard = dtpick_IdIssueDate.Value,
                    ExpirationDateIdentityCard = dtpick_IdCardExpiration.Value,
                    PassportNumber = txt_PassportNumber.Text,
                    IssueDatePassport = dtpick_PassportIssueDate.Value,
                    ExpirationDatePassport = dtpick_PassportExpiration.Value,
                    Status  = new StatusModel("wprowadzony"),
                };

                //employee = CreateEmployee(employee);
                employee.Id = 4;
                employee.Code = 4;

                ReloadEmployees?.Invoke(btn_save, new EmployeeEventArgs(employee));
                
                
                
                
                Close();

            }


            MessageBox.Show("Zapisano");
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

        protected override void Cancel()
        {
            MessageBox.Show("Anulowano");
            Close();
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
    }
}
