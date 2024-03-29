﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TCCarShare.Models;

namespace TCCarShare.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Car> Car { get; set; }

        public DbSet<Employee> Employee { get; set; }

        public DbSet<Line> Line { get; set; }
        public DbSet<Order> Order { get; set; }


    }
}
