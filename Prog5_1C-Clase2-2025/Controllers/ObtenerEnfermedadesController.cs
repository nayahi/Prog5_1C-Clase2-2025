using Microsoft.AspNetCore.Mvc;
using MVC2.Data;
using MVC2.Models;

namespace Prog5_1C_Clase2_2025.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ObtenerEnfermedadesController : ControllerBase
    {
        private readonly AppDbContext _appDbContext;

        public ObtenerEnfermedadesController(AppDbContext context)
        {
            _appDbContext = context;
        }
        [Route("ObtenerEnfermedades")]
        [HttpGet]
        public List<Enfermedades> ObtenerEnfermedades(string enfermedad)
        {
            return (from c in this._appDbContext.Enfermedades.Take(10)
                    where c.Enfermedad.StartsWith(enfermedad) || string.IsNullOrEmpty(enfermedad)
                    select c).ToList();
        }
    }
}
