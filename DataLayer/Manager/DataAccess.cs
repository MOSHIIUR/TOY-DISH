﻿using DataLayer.Interface;
using DataLayer.Models;
using DataLayer.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Manager
{
    public class DataAccess
    {
        public static iRepo<Employee, int, bool> EmployeeData()
        {
            return new EmployeeRepo();
        }
        
        public static iRepo<Category, int, bool> CategoryData()
        {
            return new CategoryRepo();
        }
        
        public static iRepo<Game, int, bool> GameData()
        {
            return new GameRepo();
        }
        
        public static iRepo<Comment, int, bool> CommentData()
        {
            return new CommentRepo();
        }
        
    
    
    }
}
