using DataLayer.Interface;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repo
{
    internal class EmployeeRepo : dBinstance, iRepo<Employee, int, bool>
    {
        public List<Employee> Get()
        {
            return db.Employees.ToList();
        }

        public Employee Get(int id)
        {
            return db.Employees.Find(id);
        }

        public bool Insert(Employee emp)
        {
            db.Employees.Add(emp);
            return db.SaveChanges() > 0;
        }

        public bool Update(Employee emp)
        {
            Employee newEmp = new Employee();
            newEmp = db.Employees.Find(emp.id);
            if (newEmp != null)
            {
                newEmp.name = emp.name;
                return db.SaveChanges() > 0;
            }

            else return db.SaveChanges() > 0;


        }

        public bool Delete(int id)
        {
            var newEmp = db.Employees.Find(id); 
            db.Employees.Remove(newEmp);
            return db.SaveChanges() > 0;
        }
    }
}
