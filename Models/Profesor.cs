using System.Collections.Generic;

namespace Models
{
    public class Profesor : Usuario
    {
        public ICollection<Asignatura> Asignaturas { get; set; }

        public Profesor() { }
    }
}