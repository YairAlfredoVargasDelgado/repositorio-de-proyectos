using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace repositorio.DataAccess
{
    public class RepositorioContext : DbContext
    {   
        public DbSet<Administrador> Administradors { get; set; }

        public DbSet<Asignatura> Asignaturas { get; set; }

        public DbSet<Calificador> Calificadores { get; set; }

        public DbSet<Criterio> Criterios { get; set; }

        public DbSet<Director> Directores { get; set; } 

        public DbSet<Estudiante> Estudiantes { get; set; }

        public DbSet<Proyecto> Proyecto { get; set; }

        public DbSet<Rúbrica> Rúbrica { get; set; }

        public DbSet<Sesión> Sesiones { get; set; }

        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-3QO597M;Database=RepositorioDB;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}
    