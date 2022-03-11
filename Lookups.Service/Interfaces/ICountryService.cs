using Common.StandardInfrastructure;
using Lookups.Service.Dto;
using Lookups.Service.FilterDto;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Lookups.Service.Interfaces
{
    public interface ICountryService
    {
        Task<IEnumerable<CountryDto>> GetAll();
        Task<PagedListDto<CountryDto>> GetAllCountriesPaged(CountryFilterDto filteringDto, PagingSortingDto pagingSortingDto);

        Task<CountryDto> Get(Guid id);
        Task<string> Add(CountryDto countryDto);
        Task<string> Update(CountryDto countryDto);
        Task<string> Delete(Guid id);
    }
}
