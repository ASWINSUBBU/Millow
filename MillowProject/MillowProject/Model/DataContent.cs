using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MillowProject.Model
{
    public class DataContent : DbContext
    {
        public DataContent(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Employee> employees { get; set; }
        public DbSet<Company> company { get; set; }
    }
}
