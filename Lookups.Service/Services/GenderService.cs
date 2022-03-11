using AutoMapper;
using Common.StandardInfrastructure;
using Lookups.Data.Entities;
using Lookups.DataAccess;
using Lookups.Service.Dto;
using Lookups.Service.FilterDto;
using Lookups.Service.Interfaces;
using Lookups.Service.Services.Base;
using Microsoft.Extensions.Localization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lookups.Service.Services
{
    public class GenderService : BaseServices, IGenderService
    {
        public GenderService(IMapper mapper, IUnitOfWork unitOfWork, IStringLocalizer<Service.Resources.Lookups> lookupsLocalize
             , IStringLocalizer<Common.StandardInfrastructure.Resources.Common> commonLocalize)
            : base(mapper, unitOfWork, lookupsLocalize, commonLocalize) { }

        public async Task<IEnumerable<GenderDto>> GetAll()
        {
            var list = await UnitOfWork.GetRepository<Gender>().FindAsync(r => r.IsShown == true);
            return Mapper.Map<IEnumerable<Gender>, IEnumerable<GenderDto>>(list);
        }
        public async Task<IEnumerable<DropdownDto>> GetDropdownList()
        {
            var list = await UnitOfWork.GetRepository<Gender>().GetAllAsync();
            return Mapper.Map<IEnumerable<DropdownDto>>(list.Where(r => r.IsShown == true));
        }
        public async Task<GenderDto> Get(Guid id)
        {
            var gender = await UnitOfWork.GetRepository<Gender>().GetAsync(id);
            return Mapper.Map<Gender, GenderDto>(gender);
        }

    }
}
