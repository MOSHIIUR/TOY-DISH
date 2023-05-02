using BusinessLayer.DTOs;
using DataLayer.Manager;
using DataLayer.Models;
using DataLayer.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Services
{
    public class EmployeeService
    {

        public static List<EmployeeDTO> Get()
        {
            return convert(DataAccess.EmployeeData().Get());
        }

        public static Employee Get(int id)
        {
            return (DataAccess.EmployeeData().Get(id));
        }

        public static List<Employee> Get10()
        {
            var data = (from e in DataAccess.EmployeeData().Get()
                        where e.id < 11
                        select e).ToList();
            return data;
        }

        public static bool Create(EmployeeDTO employee)
        {
            var data = convert(employee); //convert DTO to employee

            var res = DataAccess.EmployeeData().Insert(data); //pass to data layer

            //pass result to app layer
            if (res) return true;
            else return false;

            
        }

        public static bool Update(EmployeeDTO employee)
        {
            var data = convert(employee); //convert DTO to employee

            var res = DataAccess.EmployeeData().Update(data); //pass to data layer

            //pass result to app layer
            if (res) return true;
            else return false;
        }
        public static bool Delete(int id)
        {
            return DataAccess.EmployeeData().Delete(id);
        }

        //take list of employee retunr employeeDto
        static List<EmployeeDTO> convert(List<Employee> employees)
        {
            var data = new List<EmployeeDTO>();
            foreach (var emp in employees)
            {
                data.Add(new EmployeeDTO{ 
                id = emp.id,
                name = emp.name
                });
            }

            return data;
        }

        //take a employee and retun it's dto
        static EmployeeDTO convert(Employee employee)
        {
            return new EmployeeDTO()
            {
                id = employee.id,
                name = employee.name
            };
        }

        //take a employeeDto and retun just the employee
        static Employee convert(EmployeeDTO employee)
        {
            return new Employee()
            {
                id = employee.id,
                name = employee.name
            };
        }


    }
}
