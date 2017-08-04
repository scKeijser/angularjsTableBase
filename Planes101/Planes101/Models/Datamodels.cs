using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Planes101.Models
{
    public class Plane
    {
        public int ID { get; set; }
        public string Type { get; set; }
        public int Capacity { get; set; }
        public ICollection<Flight> Flights { get; set; }
    }

    public class Passenger
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public Flight OnFlight { get; set; }
    }

    public class Flight
    {
        public int ID { get; set; }
        public string StartLoc { get; set; }
        public string EndLoc { get; set; }
        public ICollection<Passenger> Passengers { get; set; }
        public Plane Plane { get; set; }
    }

    public class PlaneContext : DbContext
    {
        public DbSet<Plane> Planes { get; set; }
        public DbSet<Flight> Flight { get; set; }
        public DbSet<Passenger> Passengers { get; set; }
        public PlaneContext() : base("DefaultConnection") { }
    }
}