using Microsoft.EntityFrameworkCore;
using MVC2.Models;
using _2cProg5_2024.Models;
using Prog5_1C_Clase2_2025.Models;

namespace MVC2.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
                
        }
        public DbSet<MVC2.Models.Enfermedades> Enfermedades { get; set; } = default!;
        public DbSet<_2cProg5_2024.Models.CentroVacunacion> CentroVacunacion { get; set; } = default!;
        public DbSet<MVC2.Models.EnfermedadesNOEF> EnfermedadesNOEF { get; set; } = default!;
        public DbSet<Prog5_1C_Clase2_2025.Models.Persona> Persona { get; set; } = default!;
    }
}
