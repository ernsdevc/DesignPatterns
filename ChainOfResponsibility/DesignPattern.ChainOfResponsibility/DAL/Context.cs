using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.ChainOfResponsibility.DAL
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=MACHINEX\\MSSQLSERVER01;Initial Catalog=DesignPattern1;Integrated Security=True;");
        }

        public DbSet<CustomerProcess> CustomerProcess { get; set; }
    }
}
