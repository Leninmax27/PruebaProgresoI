using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PruebaProgresoI.Models;

namespace PruebaProgresoI.Data
{
    public class PruebaProgresoIContext : DbContext
    {
        public PruebaProgresoIContext (DbContextOptions<PruebaProgresoIContext> options)
            : base(options)
        {
        }

        public DbSet<PruebaProgresoI.Models.LCando> LCando { get; set; } = default!;
        public DbSet<PruebaProgresoI.Models.Carrera> Carrera { get; set; } = default!;
    }
}
