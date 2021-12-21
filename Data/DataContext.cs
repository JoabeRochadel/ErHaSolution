using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ErHaSolution.Models;
using Microsoft.EntityFrameworkCore;

namespace ErHaSolution.Data
{
    public class DataContext : DbContext
    {
        public DataContext()
        {

        }
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }
        public DbSet<EmployeeCategory> EmployeeCategories { get; set; }

    }

}
