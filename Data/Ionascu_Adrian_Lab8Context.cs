﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Ionascu_Adrian_Lab8.Models;

namespace Ionascu_Adrian_Lab8.Data
{
    public class Ionascu_Adrian_Lab8Context : DbContext
    {
        public Ionascu_Adrian_Lab8Context (DbContextOptions<Ionascu_Adrian_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Ionascu_Adrian_Lab8.Models.Book> Book { get; set; }

        public DbSet<Ionascu_Adrian_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Ionascu_Adrian_Lab8.Models.BookCategory> BookCategory { get; set; }

        public DbSet<Ionascu_Adrian_Lab8.Models.Category> Category { get; set; }
    }
}
