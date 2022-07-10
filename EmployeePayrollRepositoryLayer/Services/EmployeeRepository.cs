using EmployeePayrollModelLayer;
using EmployeePayrollRepositoryLayer.Interface;
using Microsoft.Extensions.Configuration;
using MongoDB.Driver;
using MongoDB.Driver.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePayrollRepositoryLayer.Services
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly IMongoCollection<EmployeeModel> Employee;
        private readonly IConfiguration configuration;

        public EmployeeRepository(IDatabaseSetting settings,IConfiguration configuration)
        {
            this.configuration = configuration;
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);
            Employee = database.GetCollection<EmployeeModel>("EmployeePayroll");
        }

        /// <summary>
        /// Adding Employee (Method 1)
        /// </summary>
        /// <param name="employee"></param>
        /// <returns></returns>
        public async Task<EmployeeModel> AddEmployee(EmployeeModel employee)
        {
            try
            {
                var checkId = this.Employee.AsQueryable().Where(t => t.Id == employee.Id).FirstOrDefault();
                if(checkId == null)
                {
                    await this.Employee.InsertOneAsync(employee);
                    return employee;
                }
                return null;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// Get All Employee (Method 2)
        /// </summary>
        /// <param name="employee"></param>
        /// <returns></returns>
        public List<EmployeeModel> GetAllEmployee()
        {
            try
            {
                List<EmployeeModel> checkId = this.Employee.AsQueryable().ToList();
                if(checkId != null)
                {
                    return checkId;
                }
                return null;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// Get Employee by Id (Method 3)
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public EmployeeModel GetEmployeeById(string Id)
        {
            try
            {
                var idCheck = this.Employee.AsQueryable().Where(t => t.Id.Equals(Id)).FirstOrDefault();
                if(idCheck != null)
                {
                    return idCheck;
                }
                return null;
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// Delete Employee (Method 4)
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public async Task<string> DeleteEmployee(string Id)
        {
            try
            {
                var checkId = this.Employee.AsQueryable().Where(t => t.Id == Id).FirstOrDefaultAsync();
                if(checkId != null)
                {
                    await this.Employee.DeleteOneAsync(b => b.Id == Id);
                }
                return null;
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// Update Employees (Method 5)
        /// </summary>
        /// <param name="employee"></param>
        /// <returns></returns>
        public  EmployeeModel UpdateEmployee(EmployeeModel model)
        {
            try
            {
                EmployeeModel emp = new EmployeeModel();
                var checkUpdate = this.Employee.AsQueryable().Where(t => t.Id == model.Id).FirstOrDefault();
                if(checkUpdate != null)
                {
                    if(model.Id != null)
                    {
                        this.Employee.UpdateManyAsync(t => t.Id == model.Id,
                            Builders<EmployeeModel>.Update.Set(a => a.Name, model.Name));
                        this.Employee.UpdateManyAsync(t => t.Id == model.Id,
                            Builders<EmployeeModel>.Update.Set(a => a.Profile, model.Profile));
                        this.Employee.UpdateManyAsync(t => t.Id == model.Id,
                            Builders<EmployeeModel>.Update.Set(a => a.Salary, model.Salary));
                        this.Employee.UpdateManyAsync(t => t.Id == model.Id,
                            Builders<EmployeeModel>.Update.Set(a => a.Gender, model.Gender));
                        this.Employee.UpdateManyAsync(t => t.Id == model.Id,
                            Builders<EmployeeModel>.Update.Set(a => a.Date, model.Date));
                        this.Employee.UpdateManyAsync(t => t.Id == model.Id,
                            Builders<EmployeeModel>.Update.Set(a => a.Department, model.Department));
                        this.Employee.UpdateManyAsync(t => t.Id == model.Id,
                            Builders<EmployeeModel>.Update.Set(a => a.Notes, model.Notes));
                        return checkUpdate;
                    }
                    else
                    {
                        return null;
                    }
                }
                return null;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


    }
}
