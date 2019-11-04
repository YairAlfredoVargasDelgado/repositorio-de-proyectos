using System.Collections.Generic;

namespace Models
{
    public class RúbricaModel : BaseModel
    {
        public IEnumerable<CriterioModel> Criterios { get; set; }
    }
}