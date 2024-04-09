using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class B_Warehouse
    {
        public static List<WareHouseEntity> WareHousesList()
        {
            using (var db = new InventaryContext())
            {
                return db.TBWareHouses.ToList();
            }
        }

        public static void CreateWarehouse(WareHouseEntity objWareHouse)
        {
            using (var db = new InventaryContext())
            {
                db.TBWareHouses.Add(objWareHouse);
                db.SaveChanges();
            }
        }

        public static void UpdateWarehouse(WareHouseEntity objWareHouse)
        {
            using (var db = new InventaryContext())
            {
                db.TBWareHouses.Update(objWareHouse);
                db.SaveChanges();
            }
        }

        public static void RemoveWarehouse(WareHouseEntity objWareHouse)
        {
            using (var db = new InventaryContext())
            {
                db.TBWareHouses.Remove(objWareHouse);
                db.SaveChanges();
            }
        }
    }
}
