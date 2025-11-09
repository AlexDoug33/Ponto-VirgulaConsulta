using Ponto_VirgulaConsulta.Models;

namespace Ponto_VirgulaConsulta.Repositories.Especialidades
{
        public interface IEspecialidadeRepository
        {
            Task<List<Especialidade>> GetAllAsync();
        }
    }
