using Microsoft.EntityFrameworkCore;
using ParcialProgra.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParcialProgra.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        // Agregar los modelos a utilizar
        public DbSet<Modelosuerte> Modelosuerte { get; set; } //modelo cancion en este caso
    }

}
