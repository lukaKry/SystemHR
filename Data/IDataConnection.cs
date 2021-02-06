using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemHR.DataAccessLayer.Model;

namespace SystemHR.DataAccessLayer
{
    public interface IDataConnection
    {
        IEnumerable<EmployeeModel> GetEmployees();

        EmployeeModel GetEmployee(int id);

        EmployeeModel CreateEmployee(EmployeeModel model);

        EmployeeModel ModifyEmployee(EmployeeModel model);

        void RemoveEmployee(int id);
    }
}
