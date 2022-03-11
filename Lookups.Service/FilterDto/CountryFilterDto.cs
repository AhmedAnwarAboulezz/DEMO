using Common.StandardInfrastructure.CommonDto;
using System;


namespace Lookups.Service.FilterDto
{
    public class CountryFilterDto
    {
        public DynamicFilterDto<string> Code { get; set; }
        public DynamicFilterDto<string> NameFl { get; set; }
        public DynamicFilterDto<string> NameSl { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
