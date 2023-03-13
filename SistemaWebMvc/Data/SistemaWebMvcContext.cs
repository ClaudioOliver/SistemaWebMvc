using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SistemaWebMvc.Models;

namespace SistemaWebMvc.Data
{
    public class SistemaWebMvcContext : DbContext
    {
        public SistemaWebMvcContext (DbContextOptions<SistemaWebMvcContext> options)
            : base(options)
        {
        }

        public DbSet<Department> Department { get; set; }
        public DbSet<Seller> Seller { get; set; }
        public DbSet<SalesRecord> SalesRecord { get; set; }

    }
}
