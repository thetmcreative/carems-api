using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CareMSApi.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace CareMSApi.DB {

    public class DatabaseContext:DbContext
    {
        public DbSet<Organization>? Organization { get; set; }
        public DbSet<User>? User { get; set; }
        public DbSet<Address>? Address { get; set; }

        public DatabaseContext():base()
        {
            // TODO: ... 
        }
    }
}