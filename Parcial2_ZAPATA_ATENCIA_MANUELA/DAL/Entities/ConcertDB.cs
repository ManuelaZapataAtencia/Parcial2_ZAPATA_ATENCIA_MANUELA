using System.ComponentModel.DataAnnotations;

namespace Parcial2_ZAPATA_ATENCIA_MANUELA.DAL.Entities
{
    public class ConcertDB : Entity
    {
      
        [Display(Name = "¿Ya fue usada la boleta?")]
        public bool IsUsed { get; set; } = false;

        [Display(Name = "Nombre de portería")]
        [MaxLength(10)]
        public string? EntranceGate { get; set; }

    }
}
