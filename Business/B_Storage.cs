using DataAccess;
using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class B_Storage
    {
        public static List<StorageEntity> StorageList()
        {
            using (var db = new InventaryContext())
            {
                return db.TBStorages.ToList();
            }
        }

        public static void CreateStorage(StorageEntity objStorage)
        {
            using (var db = new InventaryContext())
            {
                db.TBStorages.Add(objStorage);
                db.SaveChanges();
            }
        }

        public static bool IsProductInWareHouse(string IdStorage)
        {
            using (var db = new InventaryContext())
            {
                var product = db.TBStorages.ToList().Where(id => id.StorageId == IdStorage);
                return product.Any();
            }
        }

        public static List<StorageEntity> StorageProductsByWarehouse(string IdWherehouse)
        {
            using (var db = new InventaryContext())
            {
                return db.TBStorages.Include(s => s.Product).Include(s => s.Warehouse).Where(v => v.WarehouseId == IdWherehouse).ToList();
            }
        }

        public static void UpdateStorage(StorageEntity objStorage)
        {
            using (var db = new InventaryContext())
            {
                db.TBStorages.Update(objStorage);
                db.SaveChanges();
            }
        }

        public static void RemoveStorage(StorageEntity objStorage)
        {
            using (var db = new InventaryContext())
            {
                db.TBStorages.Remove(objStorage);
                db.SaveChanges();
            }
        }
    }
}
