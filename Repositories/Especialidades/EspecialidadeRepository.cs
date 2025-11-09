using Microsoft.EntityFrameworkCore;
using Ponto_VirgulaConsulta.Data;
using Ponto_VirgulaConsulta.Models;

namespace Ponto_VirgulaConsulta.Repositories.Especialidades
{
    public class EspecialidadeRepository : IEspecialidadeRepository
    {
        private readonly ApplicationDbContext _context;
        public EspecialidadeRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<List<Especialidade>> GetAllAsync()
        {
            return await _context
                .Especialidades
                .AsNoTracking()
                .ToListAsync();
        }
    }
}
