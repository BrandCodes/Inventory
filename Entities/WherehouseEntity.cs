using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class WherehouseEntity
    {
        [Key]
        [StringLength(50)]
        public string WherehouseId { get; set; }
        
        [Required]
        [StringLength(100)]
        public string WherehouseName { get; set; }
        
        [Required]
        [StringLength(200)]
        public string WherehouseAddress { get; set; }
    }
}
