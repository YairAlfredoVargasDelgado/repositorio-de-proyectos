using System.Collections.Generic;

namespace Models
{
    public class AdministradorModel : BaseModel
    {
        IEnumerable<RúbricaModel> Rúbricas { get; set; }

        public AdministradorModel() { }
    }
}