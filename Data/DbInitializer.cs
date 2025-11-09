using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Ponto_VirgulaConsulta.Models;

namespace Ponto_VirgulaConsulta.Data
{
    public class DbInitializer
    {
        private readonly ModelBuilder _modelBuilder;
        public DbInitializer(ModelBuilder modelBuilder)
        {
            _modelBuilder = modelBuilder;
        }
        internal void Seed()
        {
            // ===== Roles (valores fijos) =====
            _modelBuilder.Entity<IdentityRole>().HasData
            (
                new IdentityRole
                {
                    Id = "8305f33b-5412-47d0-b4ab-17cf6867f2e2",
                    Name = "Atendente",
                    NormalizedName = "ATENDENTE",
                    ConcurrencyStamp = "a1a1b2b2-c3c3-4d4d-8e8e-111111111111"
                },
                new IdentityRole
                {
                    Id = "00043fbd-e5e1-49eb-8e36-837561d584f1",
                    Name = "Medico",
                    NormalizedName = "MEDICO",
                    ConcurrencyStamp = "b2b2c3c3-d4d4-5e5e-9f9f-222222222222"
                }
            );

            // ===== Usuario Atendente (hash fijo) =====
            const string userId = "95433ac4-2fe9-468f-b80d-b05ec3724d1d";
            const string email = "ponto&virgulaconsulta@hotmail.com.br";
            const string normalized = "PONTO&VIRGULACONSULTA@HOTMAIL.COM.BR";

            // Hash estático para "Pa$$w0rd"
            const string passwordHash =
                "AQAAAAIAAYagAAAAELxdekNm/SvKUM1MLpvbRAE5xDZXeUmCEYsPKjwyn+34+eI5q9DtFuhNM5UUJCOg2g==";

            _modelBuilder.Entity<Atendente>().HasData
            (
                new Atendente
                {
                    Id = userId,
                    Nome = "Ponto & Virgula Consulta",
                    Email = email,
                    EmailConfirmed = true,
                    UserName = email,
                    NormalizedEmail = normalized,
                    NormalizedUserName = normalized,
                    PasswordHash = passwordHash,

                    // Fija stamps para evitar valores volátiles
                    SecurityStamp = "c3c3d4d4-e5e5-4f4f-aaaa-333333333333",
                    ConcurrencyStamp = "d4d4e5e5-f6f6-5a5a-bbbb-444444444444"
                }
            );

            // ===== Relación Usuario–Rol =====
            _modelBuilder.Entity<IdentityUserRole<string>>().HasData
            (
                new IdentityUserRole<string>
                {
                    RoleId = "8305f33b-5412-47d0-b4ab-17cf6867f2e2", // Atendente
                    UserId = userId
                }
            );

            // ===== Otras tablas (valores fijos) =====
            _modelBuilder.Entity<Especialidade>().HasData
            (
                new Especialidade { Id = 1, Nome = "Cardiologia", Descricao = "Especialidade médica que trata doenças do coração e do sistema cardiovascular." },
                new Especialidade { Id = 2, Nome = "Dermatologia", Descricao = "Especialidade médica que trata doenças da pele, cabelo e unhas." },
                new Especialidade { Id = 3, Nome = "Gastroenterologia", Descricao = "Especialidade médica que trata doenças do sistema digestivo." },
                new Especialidade { Id = 4, Nome = "Neurologia", Descricao = "Especialidade médica que trata doenças do sistema nervoso." },
                new Especialidade { Id = 5, Nome = "Ortopedia", Descricao = "Especialidade médica que trata doenças e lesões do sistema musculoesquelético." },
                new Especialidade { Id = 6, Nome = "Pediatria", Descricao = "Especialidade médica que trata de crianças e adolescentes." },
                new Especialidade { Id = 7, Nome = "Psiquiatria", Descricao = "Especialidade médica que trata de doenças mentais e distúrbios emocionais." },
                new Especialidade { Id = 8, Nome = "Oftalmologia", Descricao = "Especialidade médica que trata doenças dos olhos." },
                new Especialidade { Id = 9, Nome = "Ginecologia", Descricao = "Especialidade médica que trata do sistema reprodutor feminino." },
                new Especialidade { Id = 10, Nome = "Oncologia", Descricao = "Especialidade médica que trata do câncer." }
            );
        }
    }
}
