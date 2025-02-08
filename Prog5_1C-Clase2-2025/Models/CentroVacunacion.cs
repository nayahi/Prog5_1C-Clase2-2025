using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Prog5_1C_Clase2_2025.Models
{
    public class CentroVacunacion
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Descripcion { get; set; }

        [Required]
        [DisplayName("Provincia")]
        [Range(1, 7, ErrorMessage = "Los valores de las provincias deben estar entre {1} y {2}")]
        public int ProvinciaId { get; set; }
    }
}
