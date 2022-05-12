using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class ProductEntity
    {
        [Key]
        [StringLength(10)]
        public string ProductId { get; set; }

        [Required]
        [StringLength(100)]
        public int ProductName { get; set; }
        
        [StringLength(600)]
        public int ProductDescription { get; set; }
        
        public int TotalQuantity { get; set; }

        public string CategoryId { get; set; }

        public CategoryEntity Category { get; set; }

        public ICollection<StorageEntity> Storages { get; set; }

    }
}
