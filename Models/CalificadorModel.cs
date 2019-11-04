using System.Collections.Generic;

namespace Models
{
    public class CalificadorModel
    {
        public IEnumerable<ProyectoModel> Proyectos { get; set; }

        public CalificadorModel() {  }
    }
}