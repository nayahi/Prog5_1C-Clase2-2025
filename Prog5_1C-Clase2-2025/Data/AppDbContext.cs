using Microsoft.EntityFrameworkCore;
using Prog5_1C_Clase2_2025.Models;

namespace Prog5_1C_Clase2_2025.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Prog5_1C_Clase2_2025.Models.CentroVacunacion> CentroVacunacion { get; set; } = default!;

    }
}
