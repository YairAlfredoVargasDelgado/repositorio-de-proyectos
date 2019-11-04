using System.Collections.Generic;

namespace Models
{
    public class AdministradorModel : BaseModel
    {
        public IEnumerable<RúbricaModel> Rúbricas { get; set; }

        public AdministradorModel() { }
    }
}