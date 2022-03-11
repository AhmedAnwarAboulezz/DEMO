using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Lookups.Data.Entities.Base;

namespace Lookups.Data.Entities
{
    public class Country : BaseModel
    {
        [StringLength(10)]
        public string Code { get; set; }
        [StringLength(200)]
        public string NameFl { get; set; }
        [StringLength(200)]
        public string NameSl { get; set; }




    }
}
