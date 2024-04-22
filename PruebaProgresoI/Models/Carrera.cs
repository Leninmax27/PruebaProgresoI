using System.ComponentModel.DataAnnotations;

namespace PruebaProgresoI.Models
{
    public class Carrera
    {
        public int CarreraID { get; set; }
        [Required(ErrorMessage = "El nombre de la carrera es obligatorio.")]
        [StringLength(100, MinimumLength = 5, ErrorMessage = "El nombre de la carrera debe tener entre 5 y 100 caracteres.")]
        public string NombreCarrera { get; set; }
        [Required(ErrorMessage = "El campus es obligatorio.")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "El nombre del campus debe tener entre 3 y 50 caracteres.")]
        public string campus {  get; set; }

        public int Nsemestres { get; set; }
    }
}
