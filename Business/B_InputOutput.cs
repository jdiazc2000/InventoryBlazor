using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class B_InputOutput
    {
        public static List<InputOutputEntity> InputOutputList()
        {
            using (var db = new InventaryContext())
            {
                return db.TBInputOutputs.ToList();
            }
        }

        public static void CreateInputOutput(InputOutputEntity objInputOutput)
        {
            using (var db = new InventaryContext())
            {
                db.TBInputOutputs.Add(objInputOutput);
                db.SaveChanges();
            }
        }

        public static void UpdateInputOutput(InputOutputEntity objInputOutput)
        {
            using (var db = new InventaryContext())
            {
                db.TBInputOutputs.Update(objInputOutput);
                db.SaveChanges();
            }
        }

        public static void RemoveInputOutput(InputOutputEntity objInputOutput)
        {
            using (var db = new InventaryContext())
            {
                db.TBInputOutputs.Remove(objInputOutput);
                db.SaveChanges();
            }
        }


    }
}
