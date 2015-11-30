using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainSystem.DAL;
namespace TrainSystem.BLL
{
    static public class PassengerHandling
    {
       static public bool ReserveChair(int ID, int passportID, string name) {
            TrainReservationSystemEntities1 db = new TrainReservationSystemEntities1();
           var seat =  db.Seats.Where(p => p.ID == ID).FirstOrDefault();
           if (seat != null)
           {
               if (seat.Available == true)
               {
                   seat.Available = false;
                   seat.Car.Train.AvailableSeats --;
                   Passenger PP = new Passenger();
                   var p = db.Passengers.Where(t => t.PassportNumber == passportID).FirstOrDefault();
                   if (p == null)
                   {
                       PP.PassportNumber = passportID;
                       PP.Name = name;
                       db.Passengers.Add(PP);
                       db.SaveChanges();
                   }
                   seat.PassengerPassport = passportID;
                   db.Histories.Add(new History{PassportNumber=passportID,TrainID=seat.Car.TrainID});

                  // db.SaveChanges();
                   return true;
               }
               else
                   return false;
           }
            return true;
        }
        static public bool CancelChairReservation(int ID, int passportID)
        {
            TrainReservationSystemEntities1 db = new TrainReservationSystemEntities1();
            var seat = db.Seats.Where(p => p.ID == ID).FirstOrDefault();
            if (seat == null)
                return false;
            else {
                   seat.Available = false;
                   seat.Car.Train.AvailableSeats ++;
                   seat.PassengerPassport =0;
                   db.Histories.Remove(new History{PassportNumber=passportID,TrainID=seat.Car.TrainID});
                   db.SaveChanges();
                return true;
            }
            
        }
        public static List<History> GetHistory()
        {
            var db = new TrainReservationSystemEntities1();
            return db.Histories.ToList();
        }

    }
}
