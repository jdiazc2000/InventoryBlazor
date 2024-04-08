using DataAccess;
using Entities;
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
