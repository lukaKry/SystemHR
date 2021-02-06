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
using SystemHR.DataAccessLayer.ViewModels;
using SystemHR.UserInterface.Classes;
using SystemHR.UserInterface.Helpers;

namespace SystemHR.UserInterface.Forms.Employees
{
    public partial class EmployeesForm : BaseForm
    {
        private static IList<EmployeeViewModel> fakeEmployee;


        public static EmployeesForm _instance = null;

        public static EmployeesForm Instance 
        {
            get
            {
                if (_instance == null)
                    _instance = new EmployeesForm();
                return _instance;
            }

        }

        private EmployeesForm()
        {
            InitializeComponent();
            //SqlConnector sqlConnector = new SqlConnector();
            IEnumerable<EmployeeModel> employees = GlobalConfig.Connection.GetEmployees();
            fakeEmployee = MappingHelper.MapToView(employees.ToList());
            PrepareEmployeesData();
            
        }

        private void PrepareEmployeesData()
        {
            var sorted = fakeEmployee.OrderBy(x => x.Code).ToList();
            bsEmployees.DataSource = new BindingList<EmployeeViewModel>(sorted);
            dgvEmployees.DataSource = bsEmployees;
        }

        private IList<EmployeeViewModel> GetFakeEmployees()
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

            return MappingHelper.MapToView(fakeEmployeesModel);
           

        }

        private void EmployeesForm_Load(object sender, EventArgs e)
        {

        }


        private void EmployeesForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _instance = null;
        }

        private void dgvEmployees_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            bsEmployees.ResetBindings(false);
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            EmployeeAddForm empl = new EmployeeAddForm();
            empl.ReloadEmployees += (s, ea) =>
            {
                EmployeeEventArgs evetArgs = ea as EmployeeEventArgs;
                if (evetArgs != null)
                {
                    EmployeeViewModel employee = MappingHelper.MapToView(evetArgs.Employee);
                    bsEmployees.Add(employee);

                    dgvEmployees.ClearSelection();
                    dgvEmployees.Rows[dgvEmployees.Rows.Count - 1].Selected = true;
                }
            };
            empl.ShowDialog();
        }

        private void btn_Modify_Click(object sender, EventArgs e)
        {
            int employeeId = Convert.ToInt32(dgvEmployees.CurrentRow.Cells["colId"].Value);
            int selectedRowIndex = dgvEmployees.CurrentRow.Index;
            EmployeeEditForm emplEdit = new EmployeeEditForm(employeeId);

            emplEdit.ReloadEmployees += (s, ea) =>
            {
                EmployeeEventArgs evetArgs = ea as EmployeeEventArgs;
                if (evetArgs != null)
                {
                    EmployeeViewModel employee = MappingHelper.MapToView(evetArgs.Employee);
                    bsEmployees[selectedRowIndex] = employee;

                    
                }
            };


            emplEdit.ShowDialog();
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            int employeeId = Convert.ToInt32(dgvEmployees.CurrentRow.Cells["colId"].Value);
            int selectedRowIndex = dgvEmployees.CurrentRow.Index;

            //RemoveEmployee(employee);

            EmployeeViewModel employee = fakeEmployee.Where(x => x.Id == employeeId).FirstOrDefault();
            if(employee != null)
            {
                bsEmployees.Remove(employee);
                dgvEmployees.ClearSelection();
            }
        }
    }
}
