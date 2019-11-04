using System.Collections.Generic;

namespace Models
{
    public class UsuarioModel : BaseModel
    {
        public string CorreoElectrónico { get; set; }

        public string Contraseña { get; set; }

        public IEnumerable<SesiónModel> Sesiones;

        public UsuarioModel() { }
    }
}