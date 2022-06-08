using ApiTesteStudiosTi.Data;
using ApiTesteStudiosTi.Models;
using ApiTesteStudiosTi.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ApiTesteStudiosTi.Repository
{
    public class ProfissionalRepository : IProfissionalRepository
    {
        private readonly TesteStudiosTiDbContext _context;
        public ProfissionalRepository(TesteStudiosTiDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Profissional>> Get()
        {
            return await _context.profissionais.ToListAsync();
        }
        public async Task<Profissional> GetById(int id)
        {
            return await _context.profissionais
                                    .Where(p => p.Id == id)
                                    .FirstOrDefaultAsync();
        }
        public void Create(Profissional profissional)
        {
            _context.Add(profissional);
        }
        public void Update(Profissional profissional)
        {
            _context.Update(profissional);
        }
        public void Delete(Profissional profissional)
        {
            _context.Remove(profissional);
        }
        public async Task<bool> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync() > 0;
        }

    }
}
