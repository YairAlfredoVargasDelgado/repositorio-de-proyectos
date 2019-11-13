using System.Collections.Generic;

namespace Repositorio.Models
{
    public class Estudiante : Persona
    {
        public ICollection<Proyecto> Proyectos { get; set; }

        public Estudiante()
        {
            Proyectos = new HashSet<Proyecto>();
        }
    }
}