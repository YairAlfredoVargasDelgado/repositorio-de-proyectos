using System.Collections.Generic;

namespace Models
{
    public class DirectorModel : ProfesorModel
    {
        public IEnumerable<ProfesorModel> Proyectos { get; set; }

        public DirectorModel() { }
    }
}