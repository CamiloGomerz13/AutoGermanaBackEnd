using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoGermanaBackEnd.Models
{
    public class dbproductosContext : DbContext
    {
        public dbproductosContext(DbContextOptions<dbproductosContext> options) : base(options)
        {

        }

        public DbSet<producto> productos { get; set; }
        public DbSet<categoria> categorias { get; set; }
    }
}
