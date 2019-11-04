using System.Collections.Generic;

namespace Models
{
    public class ProyectoModel : BaseModel
    {
        public string Código { get; set; }

        public string Nombre { get; set; }

        public AsignaturaModel Asignatura { get; set; }

        public IEnumerable<EstudianteModel> Estudiantes { get; set; }

        public DirectorModel Director { get; set; }

        public IEnumerable<CalificadorModel> Calificadores { get; set; }
    }
}