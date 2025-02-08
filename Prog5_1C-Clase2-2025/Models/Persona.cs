using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Prog5_1C_Clase2_2025.Models
{
    public class Persona
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("NombreCompleto")]
        public string Nombre { get; set; }
        public int Nota { get; set; }

        public Persona(int id, string nombre, int nota)
        {
            Id = id;
            Nombre = nombre;
            Nota = nota;
        }
    }
}
