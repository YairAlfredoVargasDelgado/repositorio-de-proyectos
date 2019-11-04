using System.Collections.Generic;

namespace Models
{
    public class Rúbrica : BaseEntity
    {
        public ICollection<Criterio> Criterios { get; set; }

        public Rúbrica() { }
    }
}