using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Parcial2_ZAPATA_ATENCIA_MANUELA.DAL.Entities
{
    public class Entity
    {
        [Key]
        [Required]
        public Guid Id { get; set; }
        public DateTime? UseDate { get; set; }
    }
}
