using System.Collections.Generic;

namespace Repositorio.Models
{
    public class Calificador : Profesor
    {
        public virtual ICollection<Proyecto> Proyectos { get; set; }

        public Calificador()
        {
            Proyectos = new HashSet<Proyecto>();
        }
    }
}