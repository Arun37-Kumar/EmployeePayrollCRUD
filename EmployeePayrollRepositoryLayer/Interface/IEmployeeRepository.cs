using EmployeePayrollModelLayer;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePayrollRepositoryLayer.Interface
{
    public interface IEmployeeRepository
    {
        Task<EmployeeModel> AddEmployee(EmployeeModel employee);
        List<EmployeeModel> GetAllEmployee();
        EmployeeModel GetEmployeeById(string Id);
        Task<string> DeleteEmployee(string Id);
        EmployeeModel UpdateEmployee(EmployeeModel model);
    }
}
