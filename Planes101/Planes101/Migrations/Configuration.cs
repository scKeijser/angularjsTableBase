namespace Planes101.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Planes101.Models;
    internal sealed class Configuration : DbMigrationsConfiguration<Planes101.Models.PlaneContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Planes101.Models.PlaneContext context)
        {
            Plane plane1 = new Plane { Capacity = 100, Type = "Charter" };
            Plane plane2 = new Plane { Capacity = 100, Type = "Charter" };
            Plane plane3 = new Plane { Capacity = 100, Type = "Charter" };
            Passenger pass1 = new Passenger { Name = "Tobaz Kesjer" };
            Passenger pass2 = new Passenger { Name = "Tintin Ekman" };
            Passenger pass3 = new Passenger { Name = "Martin Låd" };
            Passenger pass4 = new Passenger { Name = "Salt Salt" };

            context.Planes.Add(plane1);
            context.Planes.Add(plane2);
            context.Planes.Add(plane3);
            context.Passengers.Add(pass1);
            context.Passengers.Add(pass2);
            context.Passengers.Add(pass3);
            context.Passengers.Add(pass4);

            context.SaveChanges();
        }
    }
}
