using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace Parcial2_ZAPATA_ATENCIA_MANUELA.DAL.Entities
{
    public class ConcertDB
    {
        [Key]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public Guid id { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public DateTime? UseDate { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public bool IsUsed  { get; set; } = false;

        [Display(Name = "Nombre de portería")]
        [MaxLength(10)]
        [Required (ErrorMessage = "El campo {0} es obligatorio")]
        public string? EntranceGate { get; set; }

    }
}
