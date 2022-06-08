using ApiTesteStudiosTi.Data;
using ApiTesteStudiosTi.Data.Dtos;

namespace ApiTesteStudiosTi.Repository.Interfaces
{
    public interface IHoraExtraRepository
    {
        Task<HoraExtraDto> GetHoraExtra(int id, int qtdHoraExtra);
    }
}
