using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Ponto_VirgulaConsulta.Models;
using System.Reflection;

namespace Ponto_VirgulaConsulta.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : IdentityDbContext<ApplicationUser>(options)
    {
        public DbSet<Especialidade> Especialidades { get; set; }
        public DbSet<Medico> Medicos { get; set; }
        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<Agendamento> Agendamentos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            //builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            //new DbInitializer(builder).seed();

            //base.OnModelCreating(builder);
        }
    }
}
