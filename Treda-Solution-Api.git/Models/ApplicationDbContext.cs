using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace Treda_Solution_Api.git.Models
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Producto> Producto { get; set; }
        public DbSet<Tienda> Tienda { get; set; }
    }
}
