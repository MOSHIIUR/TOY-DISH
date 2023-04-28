using DataLayer.Interface;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repo
{
    internal class EmployeeRepoV2 : dBinstance, iRepo<Employee, int, bool>
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
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

    }
}
