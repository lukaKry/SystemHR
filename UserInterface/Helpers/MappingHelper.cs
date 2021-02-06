using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemHR.DataAccessLayer.Model;
using SystemHR.DataAccessLayer.ViewModels;

namespace SystemHR.UserInterface.Helpers
{
    public class MappingHelper
    {
        public static IList<EmployeeViewModel> MapToView(IList<EmployeeModel> emp)
        {
            IList<EmployeeViewModel> employeesViewModel = new List<EmployeeViewModel>();

            foreach (var empl in emp)
            {
                EmployeeViewModel emplVw = new EmployeeViewModel();
                emplVw.Id = empl.Id;
                emplVw.LastName = empl.LastName;
                emplVw.FirstName = empl.FirstName;
                emplVw.Code = empl.Code.ToString();
                emplVw.Status = empl.Status.Value;
                emplVw.Position = "tzreba uzupel mappinhelper";

                employeesViewModel.Add(emplVw);

            }


            return employeesViewModel;
        }

        public static EmployeeViewModel MapToView(EmployeeModel empl)
        {

                EmployeeViewModel emplVw = new EmployeeViewModel();
                emplVw.Id = empl.Id;
                emplVw.LastName = empl.LastName;
                emplVw.FirstName = empl.FirstName;
                emplVw.Code = empl.Code.ToString();
                emplVw.Status = empl.Status.Value;
                emplVw.Position = "tzreba uzupel mappinhelper";


            return emplVw;
        }
    }
}
