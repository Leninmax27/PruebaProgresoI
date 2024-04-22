using System.ComponentModel.DataAnnotations;

namespace PruebaProgresoI.Models
{
    public class LCando
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "El precio es requerido.")]
        [Range(0.01, 10000.00, ErrorMessage = "El precio debe estar entre 0.01 y 10000.00.")]
        public decimal Precio { get; set; }
        [Required(ErrorMessage = "El nombre es obligatorio.")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "El nombre debe tener entre 3 y 100 caracteres.")]
        public String Nombre { get; set; }
        public bool EstaActivo { get; set; }
        
        public DateTime Fecha { get; set; }


      
        public Carrera Carrera { get; set; }

    }
}
