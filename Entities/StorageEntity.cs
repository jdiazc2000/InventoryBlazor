using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class StorageEntity
    {
        [Key]
        [StringLength(50)]
        public string StorageId { get; set; }

        [Required]
        [StringLength(100)]
        public DateTime LastUpdate { get; set; }

        [Required]
        public int PartialQuantity { get; set; }

        //Relación con productos (ProductEntity)
        public ProductEntity Product { get; set; } 
        public string ProductId { get; set; }

        //Relación con bodegas (WarehouseEntity)
        public WareHouseEntity Warehouse { get; set; }
        public string WarehouseId { get; set; }

        //Relación con movimientos (InputOutputEntity)
        public ICollection<InputOutputEntity> InputOutputs { get; set; }
    }
}
