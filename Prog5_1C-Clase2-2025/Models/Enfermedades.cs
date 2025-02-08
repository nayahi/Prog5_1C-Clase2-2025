using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace MVC2.Models
{
    public class Enfermedades
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Enfermedad { get; set; }
    }
}