using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AT_DE_JAVA.Models;

namespace AT_DE_JAVA.Data
{
    public class AT_DE_JAVAContext : DbContext
    {
        public AT_DE_JAVAContext (DbContextOptions<AT_DE_JAVAContext> options)
            : base(options)
        {
        }

        public DbSet<AT_DE_JAVA.Models.Restaurante> Restaurante { get; set; } = default!;

        public DbSet<AT_DE_JAVA.Models.Talheres>? Talheres { get; set; }
    }
}
