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
        //creating a db without creating it again nd again. now everytime Employee is used it will
        //automatically invoke the constructoe
        //static dBCC db;

        //static EmployeeRepo()
        //{
        //    db = new dBCC();
        //}


        //total 4/5 operations
        //1. get all employee 2.get one employee 3.update 4.delete
        //main idea is that for every table we will have a designated class that will used to
        //perform the basic crud operations.............
        //public static List<Employee> Get()
        //{

        //    return db.Employees.ToList();
        //}
        //public static Employee Get(int id)
        //{
        //    return db.Employees.Find(id);
        //}

        //public static bool Create(Employee employee)
        //{
        //    db.Employees.Add(employee);
        //    return db.SaveChanges() > 0; //how many rows are affected that number is returning.....
        //}

        //public static bool Update(Employee employee)
        //{
        //    var exemp = db.Employees.Find(employee.id);
        //    db.Entry(exemp).CurrentValues.SetValues(employee);
        //    return db.SaveChanges() > 0;
        //}
        //public static bool Delete(int id)
        //{
        //    var exemp = Get(id);
        //    db.Employees.Remove(exemp);
        //    return db.SaveChanges() > 0;
        //}
        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

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
    }
}
