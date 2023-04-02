using System.ComponentModel.DataAnnotations;

namespace Parcial2_ZAPATA_ATENCIA_MANUELA.DAL.Entities
{
    public class ConcertDB : Entity
    {

        public bool IsUsed { get; set; } = false;

        [Display(Name = "Nombre de portería")]
        [MaxLength(10)]
        public string? EntranceGate { get; set; }

    }
}
