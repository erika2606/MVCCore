
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WvcCore2.Models;

namespace WvcCore2.Context
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions<MyContext> dbcontext) : base(dbcontext)
        {

        }

        public DbSet<Province> Provinces { get; set; }
        public DbSet<City> City { get; set; }


    }
}
