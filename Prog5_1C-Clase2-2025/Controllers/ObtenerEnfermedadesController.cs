using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVC2.Data;
using MVC2.Models;
using Newtonsoft.Json;

namespace Prog5_1C_Clase2_2025.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class ObtenerEnfermedadesController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ObtenerEnfermedadesController(AppDbContext context)
        {
            _context = context;
        }
        [Route("ObtenerEnfermedades")]
        [HttpGet]
        public List<Enfermedades> ObtenerEnfermedades(string enfermedad)
        {
            return (from c in this._context.Enfermedades.Take(10)
                    where c.Enfermedad.StartsWith(enfermedad) || string.IsNullOrEmpty(enfermedad)
                    select c).ToList();
        }
    }
}
