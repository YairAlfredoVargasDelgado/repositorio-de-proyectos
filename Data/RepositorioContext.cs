using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Repositorio.Models
{
    public class RepositorioContext : DbContext
    {
        public RepositorioContext (DbContextOptions<RepositorioContext> options)
            : base(options)
        {
        }

        public DbSet<Repositorio.Models.Administrador> Administrador { get; set; }
    }
}
