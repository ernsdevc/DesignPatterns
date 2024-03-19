using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.CQRS.DAL
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=MACHINEX\\MSSQLSERVER01;Initial Catalog=DesignPattern2;Integrated Security=True;");
        }

        public DbSet<Product> Products { get; set; }
    }
}
