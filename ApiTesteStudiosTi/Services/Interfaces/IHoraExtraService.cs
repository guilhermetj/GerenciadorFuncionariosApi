using ApiTesteStudiosTi.Data.Dtos;

namespace ApiTesteStudiosTi.Services.Interfaces
{
    public interface IHoraExtraService
    {
        Task<HoraExtraDto> GetHoraExtra(int id, int qtdHoraExtra);
    }
}
