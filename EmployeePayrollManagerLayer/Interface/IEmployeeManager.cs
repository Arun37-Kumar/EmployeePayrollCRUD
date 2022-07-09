using EmployeePayrollModelLayer;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePayrollManagerLayer.Interface
{
    public interface IEmployeeManager
    {
        Task<EmployeeModel> AddEmployee(EmployeeModel employee);
        List<EmployeeModel> GetAllEmployee();
        EmployeeModel GetEmployeeById(string Id);
        Task<string> DeleteEmployee(string Id);
        EmployeeModel UpdateEmployee(EmployeeModel model);
    }
}
