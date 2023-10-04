using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Db.Models;

namespace MyApp.Db.DbOperations
{
    public class EmployeeRepository
    {
        //Inserting Employee Data
        public int AddNewEmployee(EmployeeModel model)
        {
            using (var context = new EmployeeDbEntities())
            {
                Employee emp = new Employee()
                {
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    Email = model.Email,
                    Code = model.Code
                };

                if (model.Address != null)
                {
                    emp.Address = new Address()
                    {
                        Details = model.Address.Details,
                        State = model.Address.State,
                        Country = model.Address.Country
                    };
                }
                context.Employees.Add(emp);
                context.SaveChanges();

                return emp.Id; 
            }
        }

        //Showing/Listing data in the table
        public List<EmployeeModel> GetAllEmployees()
        {
            using (var context = new EmployeeDbEntities())
            {
                var result = context.Employees
                    .Select(x => new EmployeeModel()
                    {
                        Id = x.Id,
                        AddressId = x.AddressId,
                        Code = x.Code,
                        Email = x.Email,
                        FirstName = x.FirstName,
                        LastName = x.LastName,
                        Address = x.Address != null ? new AddressModel()
                        {
                            Id = x.Address.Id,
                            Details = x.Address.Details,
                            State = x.Address.State,
                            Country = x.Address.Country

                        } : null

                    }).ToList();

                return result;
            }

        }

        //Getting Employee Detail
        public EmployeeModel GetEmployees(int id)
        {
            using (var context = new EmployeeDbEntities())
            {
                var result = context.Employees
                    .Where(x => x.Id == id)
                    .Select(x => new EmployeeModel()
                    {
                        Id = x.Id,
                        AddressId = x.AddressId,
                        Code = x.Code,
                        Email = x.Email,
                        FirstName = x.FirstName,
                        LastName = x.LastName,
                        Address = x.Address != null ? new AddressModel()
                        {
                            Id = x.Address.Id,
                            Details = x.Address.Details,
                            State = x.Address.State,
                            Country = x.Address.Country

                        } : null

                    }).FirstOrDefault();

                return result;
            }

        }

        //Updating Employee
        public bool UpdateEmployee(int id, EmployeeModel model)
        {
            using (var context = new EmployeeDbEntities())
            {
                var employee = context.Employees.Find(id);

                if (employee != null)
                {
                    employee.FirstName = model.FirstName;
                    employee.LastName = model.LastName;
                    employee.Email = model.Email;
                    employee.Code = model.Code;
                    employee.AddressId = model.AddressId;
                }
                
                context.Entry(employee).State = System.Data.Entity.EntityState.Modified;

                context.SaveChanges();
                return true;
            }
        }
            
        //Delete Employee
        public bool DeleteEmployee(int id)
        {
            using (var context = new EmployeeDbEntities())
            {
                var emp = new Employee()
                {
                    Id = id
                };

                context.Entry(emp).State = System.Data.Entity.EntityState.Deleted;
                context.SaveChanges();
                return false;
            }
        }
    } 
}
