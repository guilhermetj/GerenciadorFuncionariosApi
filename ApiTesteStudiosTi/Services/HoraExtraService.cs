using ApiTesteStudiosTi.Data.Dtos;
using ApiTesteStudiosTi.Repository.Interfaces;
using ApiTesteStudiosTi.Services.Interfaces;

namespace ApiTesteStudiosTi.Services
{
    public class HoraExtraService : IHoraExtraService
    {
        private readonly IHoraExtraRepository _repository;

        public HoraExtraService(IHoraExtraRepository repository)
        {
            _repository = repository;
        }
        public async Task<HoraExtraDto> GetHoraExtra(int id, int qtdHoraExtra)
        {
            return await _repository.GetHoraExtra(id, qtdHoraExtra);
        }
    }
}
