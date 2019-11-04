using System.Collections.Generic;

namespace Models
{
    public class ProyectoModel
    {
        public string Código { get; set; }

        public string Nombre { get; set; }

        public AsignaturaModel Asignatura { get; set; }

        public IEnumerable<EstudianteModel> Estudiantes { get; set; }

        public DirectorModel Director { get; set; }

        public IEnumerable<ProfesorModel> Calificadores { get; set; }
    }
}