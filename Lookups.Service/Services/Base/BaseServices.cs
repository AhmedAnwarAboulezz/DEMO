using AutoMapper;
using Lookups.DataAccess;
using Microsoft.Extensions.Localization;

namespace Lookups.Service.Services.Base
{
    public class BaseServices
    {
        protected readonly IUnitOfWork UnitOfWork;
        protected readonly IMapper Mapper;
        protected readonly IStringLocalizer<Common.StandardInfrastructure.Resources.Common> CommonLocalize;
        protected readonly IStringLocalizer<Service.Resources.Lookups> LookupsLocalize;

        public BaseServices(IMapper mapper, IUnitOfWork unitOfWork, IStringLocalizer<Service.Resources.Lookups> lookupsLocalize, IStringLocalizer<Common.StandardInfrastructure.Resources.Common> commonLocalize)
        {
            UnitOfWork = unitOfWork;
            Mapper = mapper;

            LookupsLocalize = lookupsLocalize;
            CommonLocalize = commonLocalize;
        }
    }
}
