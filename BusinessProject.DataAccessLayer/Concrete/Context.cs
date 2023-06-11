using BusinessProject.EntityLayer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessProject.DataAccessLayer.Concrete
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DEVELOPER04-VM5\\SERKANOZDEMIR;initial catalog=BusinessDB;TrustServerCertificate=True;User Id=sa;Password=Qwer1234");
        }
        public DbSet<Operation> Operations { get; set; }
        public DbSet<Employee> Employees { get; set; }
    }
}
