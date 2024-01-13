using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFC_01.Entity
{
    public class AppDbContext:DbContext
    {
        public virtual DbSet<HocVien> HocVien { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-V5E7153\\SQLEXPRESS;Database=EFC_01;Trusted_Connection = True;TrustServerCertificate=True");
        }
    }
}
