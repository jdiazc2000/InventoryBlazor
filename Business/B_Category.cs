using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class B_Category
    {
        public static List<CategoryEntity> CategoryList()
        {
            using (var db = new InventaryContext())
            {
                return db.TBCategories.ToList();
            }
        }

        public static void CreateCategory(CategoryEntity objCategoria)
        {
            using (var db = new InventaryContext())
            {
                db.TBCategories.Add(objCategoria);
                db.SaveChanges();
            }
        }

        public static void UpdateCategory(CategoryEntity objCategoria)
        {
            using (var db = new InventaryContext())
            {
                db.TBCategories.Update(objCategoria);
                db.SaveChanges();
            }
        }

        public static void RemoveCategory(CategoryEntity objCategoria)
        {
            using (var db = new InventaryContext())
            {
                db.TBCategories.Remove(objCategoria);
                db.SaveChanges();
            }
        }
    }
}
