﻿using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class dBCC: DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Game> Games { get; set; }
        public DbSet<User> Users { get;set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<Rating> Ratings { get; set; } 
        public DbSet<Follower> Followers { get; set; } 
        public DbSet<Token> Tokens { get; set; } 
    }
}
