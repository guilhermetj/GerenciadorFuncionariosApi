using ApiTesteStudiosTi.Data.Dtos;
using ApiTesteStudiosTi.Models;
using AutoMapper;

namespace ApiTesteStudiosTi.Helpers
{
    public class TesteStrudiosTIProfile : Profile
    {
        public TesteStrudiosTIProfile()
        {
            CreateMap<Profissional, ProfissionalDto>();
            CreateMap<Profissional, ProfissionalDetailsDto>();
            CreateMap<ProfissionalCreateDto, Profissional>();
            CreateMap<ProfissionalUpdateDto, Profissional>();
        }
    }
}
