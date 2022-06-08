using ApiTesteStudiosTi.Data;
using ApiTesteStudiosTi.Data.Dtos;
using ApiTesteStudiosTi.Extensions;
using ApiTesteStudiosTi.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ApiTesteStudiosTi.Repository
{
    public class HoraExtraRepository : IHoraExtraRepository
    {
        private readonly TesteStudiosTiDbContext _context;
        public HoraExtraRepository(TesteStudiosTiDbContext context)
        {
            _context = context;
        }
        public async Task<HoraExtraDto> GetHoraExtra(int id, int qtdHoraExtra)
        {
            var profissionalBanco = await _context.profissionais
                                    .Where(p => p.Id == id)
                                    .FirstOrDefaultAsync();
            if(profissionalBanco == null)
            {
                throw new NotFoundException("Profissional não encontrado");
            }
            var valorHoraExtra = 0.05 * profissionalBanco.Salario;

            var totalHoraExtra = qtdHoraExtra * valorHoraExtra;

            HoraExtraDto resume = new HoraExtraDto
            {
                idProfissional = profissionalBanco.Id,
                salarioProfissional = profissionalBanco.Salario,
                qtdHoraExtra = qtdHoraExtra,
                valorHoraExtra = valorHoraExtra,
                salarioHoraExtra = profissionalBanco.Salario + totalHoraExtra
            };

            return resume;
        }
    }
}
