using System.Collections.Generic;

namespace Models
{
    public class ProfesorModel : UsuarioModel
    {
        public IEnumerable<AsignaturaModel> Asignaturas { get; set; }
    }
}