using System.Collections.Generic;

namespace Repositorio.Models
{
    public class Asignatura : BaseEntity
    {
        public string Código { get; set; }

        public string Nombre { get; set; }

        public ICollection<Proyecto> Proyectos { get; set; }

        public Asignatura()
        {
            Proyectos = new HashSet<Proyecto>();
        }
    }
}