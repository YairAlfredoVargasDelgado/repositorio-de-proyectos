using System.Collections.Generic;

namespace Models
{
    public class Proyecto : BaseEntity
    {
        public string Código { get; set; }

        public string Nombre { get; set; }

        public Asignatura Asignatura { get; set; }

        public ICollection<Estudiante> Estudiantes { get; set; }

        public Director Director { get; set; }

        public ICollection<Calificador> Calificadores { get; set; }

        
    }
}