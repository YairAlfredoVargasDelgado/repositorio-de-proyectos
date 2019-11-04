using System.Collections.Generic;

namespace Models
{
    public class Administrador : BaseEntity
    {
        public ICollection<Rúbrica> Rúbricas { get; set; }

        public Administrador() { }
    }
}