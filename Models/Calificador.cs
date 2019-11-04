using System.Collections.Generic;

namespace Models
{
    public class Calificador
    {
        public ICollection<Proyecto> Proyectos { get; set; }

        public Calificador() { }
    }
}