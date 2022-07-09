using EmployeePayrollManagerLayer.Interface;
using EmployeePayrollModelLayer;
using EmployeePayrollRepositoryLayer.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePayrollManagerLayer.Services
{
    public class EmployeeManager : IEmployeeManager
    {
        private readonly IEmployeeRepository repository;

        public EmployeeManager(IEmployeeRepository repository)
        {
            this.repository = repository;
        }

        public async Task<EmployeeModel> AddEmployee(EmployeeModel employee)
        {
            try
            {
                return await this.repository.AddEmployee(employee);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<EmployeeModel> GetAllEmployee()
        {
            try
            {
                return this.repository.GetAllEmployee();
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public EmployeeModel GetEmployeeById(string Id)
        {
            try
            {
                return this.repository.GetEmployeeById(Id);
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<string> DeleteEmployee(string Id)
        {
            try
            {
                return await this.repository.DeleteEmployee(Id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public  EmployeeModel UpdateEmployee(EmployeeModel model)
        {
            try
            {
                return  this.repository.UpdateEmployee(model);
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
