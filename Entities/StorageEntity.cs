using System;
using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class StorageEntity
    {
        [Key]
        [StringLength(50)]
        public string StorageId { get; set; }
        
        public DateTime LastUpdate { get; set; }
        
        [Required]
        public int PartialQuantity { get; set; }
                
        public string ProductId { get; set; }
        
        
        public ProductEntity Product { get; set; }
    }
}
