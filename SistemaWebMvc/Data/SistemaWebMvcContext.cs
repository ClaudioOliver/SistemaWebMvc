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

        public DbSet<SistemaWebMvc.Models.Departamento> Departamento { get; set; } 
        public DbSet<SistemaWebMvc.Models.Vendedor> Vendedor { get; set; }
        public DbSet<SistemaWebMvc.Models.RegistrodeVenda> RegistrodeVenda { get; set; } 
    }
}
