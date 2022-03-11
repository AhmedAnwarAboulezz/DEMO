using AutoMapper;
using Common.StandardInfrastructure;
using Lookups.Data.Entities;
using Lookups.Service.Dto;
using Microsoft.AspNetCore.Http;

namespace Lookups.Service.AutoMapper
{
    public class LookupsProfile : Profile
    {

        public LookupsProfile()
        {
            MapCountry();            
            MapGender();           
        }

        

        private void MapCountry()
        {
            CreateMap<CountryDto, Country>().ReverseMap();
        }
      
        private void MapGender()
        {
            CreateMap<GenderDto, Gender>().ReverseMap()
                .ForMember(dest => dest.GenderNameFl, opts =>
                opts.MapFrom(src => Helper.ChangeProperty() == (int)Helper.ChangePropertyEnum.Ar ||
                Helper.ChangeProperty() == (int)Helper.ChangePropertyEnum.ArEn ? src.GenderNameSl : src.GenderNameFl))
                .ForMember(dest => dest.GenderNameSl,
                opts => opts.MapFrom(src => Helper.ChangeProperty() == (int)Helper.ChangePropertyEnum.En
                 || Helper.ChangeProperty() == (int)Helper.ChangePropertyEnum.ArEn ? src.GenderNameFl : src.GenderNameSl));
            CreateMap<DropdownDto, Gender>().ReverseMap()
                .ForMember(dest => dest.Id, opts => opts.MapFrom(src => src.Id))

                .ForMember(dest => dest.NameFl, opts =>
                opts.MapFrom(src => Helper.ChangeProperty() == (int)Helper.ChangePropertyEnum.Ar ||
                Helper.ChangeProperty() == (int)Helper.ChangePropertyEnum.ArEn ? src.GenderNameSl : src.GenderNameFl))
                .ForMember(dest => dest.NameSl,
                opts => opts.MapFrom(src => Helper.ChangeProperty() == (int)Helper.ChangePropertyEnum.En
                 || Helper.ChangeProperty() == (int)Helper.ChangePropertyEnum.ArEn ? src.GenderNameFl : src.GenderNameSl));

        }
      

    }
   
}
