﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class TrainReservationSystemEntities1 : DbContext
    {
        public TrainReservationSystemEntities1()
            : base("name=TrainReservationSystemEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Car> Cars { get; set; }
        public virtual DbSet<History> Histories { get; set; }
        public virtual DbSet<LogIn> LogIns { get; set; }
        public virtual DbSet<Passenger> Passengers { get; set; }
        public virtual DbSet<Seat> Seats { get; set; }
        public virtual DbSet<Train> Trains { get; set; }
    }
}
