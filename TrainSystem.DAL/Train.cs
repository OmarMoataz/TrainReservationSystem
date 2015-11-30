//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TrainSystem.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Train
    {
        public Train()
        {
            this.Cars = new HashSet<Car>();
            this.Histories = new HashSet<History>();
        }
    
        public long ID { get; set; }
        public string StartingStation { get; set; }
        public string EndingStation { get; set; }
        public string DepartureDate { get; set; }
        public string ArrivalDate { get; set; }
        public long NumberOfCars { get; set; }
        public long AvailableSeats { get; set; }
    
        public virtual ICollection<Car> Cars { get; set; }
        public virtual ICollection<History> Histories { get; set; }
    }
}