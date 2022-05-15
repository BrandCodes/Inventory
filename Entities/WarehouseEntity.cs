using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class WarehouseEntity
    {
        [Key]
        [StringLength(maximumLength: 50)]
        public string WarehouseId { get; set; }
        
        [Required]
        [StringLength(100)]
        public string WarehouseName { get; set; }
        
        [Required]
        [StringLength(200)]
        public string WarehouseAddress { get; set; }

        public ICollection<StorageEntity> Storages { get; set; }
    }
}
