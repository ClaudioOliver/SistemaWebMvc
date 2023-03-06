using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SistemaWebMvc.Models;

namespace SistemaWebMvc.Data
{
    public class Context : DbContext
    {
        public Context (DbContextOptions<Context> options)
            : base(options)
        {
        }

        public DbSet<SistemaWebMvc.Models.Department> Department { get; set; } = default!;
    }
}
