using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainSystem.DAL;
namespace TrainSystem.BLL
{
    static public class TrainHandling
    {
        static public void AddNewTrain(string from, string to, string startDate, string endDate, int numberofCars)
        {
            TrainReservationSystemEntities1 db = new TrainReservationSystemEntities1();
            Train train = new Train()
            {
                NumberOfCars = numberofCars,
                ArrivalDate = endDate,
                DepartureDate = startDate,
                StartingStation = from,
                EndingStation = to,
                AvailableSeats = numberofCars * 24
            };
            db.Trains.Add(train);
            db.SaveChanges();
            for (int i = 0; i < numberofCars; i++)
            {
                var car = new Car() { Number = i + 1, TrainID = train.ID };
                db.Cars.Add(car);
                db.SaveChanges();
                for (int j = 0; j < 24; j++)
                {
                    var seat = new Seat() { Available = true, CarID = car.ID, Coordinates = j.ToString() };
                    db.Seats.Add(seat);
                    db.SaveChanges();
                }
            }
            
        }

        static public bool RemoveTrain(int id)
        {
            TrainReservationSystemEntities1 db = new TrainReservationSystemEntities1();
            var temp = db.Trains.Where(p => p.ID == id).FirstOrDefault();
            if (temp == null)
                return false;
            else
            {
                db.Trains.Remove(temp);
                db.SaveChanges();
                return true;

            }

        }

        static public bool EditTrain(int id, string from, string to, string startDate, string endDate, int numberofCars)
        {
            TrainReservationSystemEntities1 db = new TrainReservationSystemEntities1();

            var temp = db.Trains.Where(p => p.ID == id).FirstOrDefault();
            if (temp == null)
                return false;
            else
            {
                temp.ID = id;
                temp.NumberOfCars = numberofCars;
                temp.StartingStation = from;
                temp.EndingStation = to;
                temp.DepartureDate = startDate;
                temp.ArrivalDate = endDate;
                db.SaveChanges();
                return true;
            }


        }
        static public List<Train> ViewTrains()
        {
            TrainReservationSystemEntities1 db = new TrainReservationSystemEntities1();
            var list = db.Trains.Where(pt => pt.AvailableSeats != 0).ToList();
            return list;
        }
        static public List<Train> ViewAllTrains()
        {
            TrainReservationSystemEntities1 db = new TrainReservationSystemEntities1();
            var list = db.Trains.ToList();
            return list;
        }
        static public Train GetTrainById(int id)
        {
            TrainReservationSystemEntities1 db = new TrainReservationSystemEntities1();
            return db.Trains.Where(p => p.ID == id).FirstOrDefault();
        }

    }
}
