using System.Collections.Generic;

namespace Models
{
    public class Estudiante
    {
        public ICollection<Proyecto> Proyectos { get; set; }

        public Estudiante() { }
    }
}