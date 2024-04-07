using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class WareHouseEntity
    {
        [Key]
        [StringLength(50)]
        public string WareHouseId { get; set; }

        [Required]
        [StringLength(100)]
        public string WareHouseName { get; set; }

        [StringLength(100)]
        public string WareHouseAddress { get; set; }

        //Relación con almacenamiento (StorageEntity)
        public ICollection<StorageEntity> Storages { get; set; }
    }
}
