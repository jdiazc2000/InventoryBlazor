using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class B_Product
    {
        public static List<ProductEntity> ProductList()
        {
            using (var db = new InventaryContext())
            {
                return db.TBProducts.ToList();
            }
        }

        public static ProductEntity ProductById(string id)
        {
            using (var db = new InventaryContext())
            {
                return db.TBProducts.ToList().LastOrDefault(p => p.ProductId == id);
            }
        }

        public static void CreateProduct(ProductEntity objProduct)
        {
            using (var db = new InventaryContext())
            {
                db.TBProducts.Add(objProduct);
                db.SaveChanges();
            }
        }

        public static void UpdateProduct(ProductEntity objProduct)
        {
            using (var db = new InventaryContext())
            {
                db.TBProducts.Update(objProduct);
                db.SaveChanges();
            }
        }

        public static void RemoveProduct(ProductEntity objProduct)
        {
            using (var db = new InventaryContext())
            {
                db.TBProducts.Remove(objProduct);
                db.SaveChanges();
            }
        }

    }
}
