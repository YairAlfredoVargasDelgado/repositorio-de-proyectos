using System.Collections.Generic;

namespace Models
{
    public class Usuario : BaseEntity
    {
        public string CorreoElectrónico { get; set; }

        public string Contraseña { get; set; }

        public IEnumerable<Sesión> Sesiones;

        public Usuario() { }
    }
}