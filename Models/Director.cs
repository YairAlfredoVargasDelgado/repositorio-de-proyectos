using System.Collections.Generic;

namespace Models
{
    public class Director : Profesor
    {
        public ICollection<Proyecto> Proyectos { get; set; }

        public Director() { }
    }
}