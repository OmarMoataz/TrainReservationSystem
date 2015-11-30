using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainSystem.DAL;
namespace TrainSystem.BLL
{
   static public class Login
    {
      static  public bool Loging(string name, string password, bool type)
        {
            TrainReservationSystemEntities1 db = new TrainReservationSystemEntities1();
            var user = db.LogIns.Where(p => p.Password == password && p.Username == name && p.Type == type).FirstOrDefault();
            if (user == null)
                return false;
            else 
            return true;
        }
    }
}
