using Common.StandardInfrastructure;
using Lookups.Service.Dto;
using Lookups.Service.FilterDto;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Lookups.Service.Interfaces
{
    public interface IGenderService
    {
        Task<GenderDto> Get(Guid id);
        Task<IEnumerable<GenderDto>> GetAll();
        Task<IEnumerable<DropdownDto>> GetDropdownList();
    }
}