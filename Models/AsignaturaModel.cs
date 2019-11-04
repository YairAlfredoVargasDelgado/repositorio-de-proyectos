using System.Collections.Generic;

namespace Models
{
    public class AsignaturaModel
    {
        public string Código { get; set; }

        public string Nombre { get; set; }

        public IEnumerable<ProyectoModel> Proyectos { get; set; }
    }
}