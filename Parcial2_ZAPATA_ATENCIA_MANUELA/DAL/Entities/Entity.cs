using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Parcial2_ZAPATA_ATENCIA_MANUELA.DAL.Entities
{
    public class Entity
    {
        [Key]
        [Required]
        [Display(Name = "ID boleta")]
        public Guid Id { get; set; }

        [Display(Name = "Fecha de uso de la boleta")]
        public DateTime? UseDate { get; set; }

        

    }
}
