using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Planes101.Models;

namespace Planes101.Controllers
{
    public class ValuesController : ApiController
    {
        private PlaneContext ctx = new PlaneContext();
        // GET api/values
        public IEnumerable<Plane> GetPlanes()
        {
            return ctx.Planes.ToList();
        }

        public IEnumerable<Passenger> GetPassengers()
        {
            return ctx.Passengers.ToList();
        }

        public IEnumerable<Flight> GetFlights()
        {
            return ctx.Flight.ToList();
        }
        [HttpPost]
        public void AddFlight([FromBody]AddFlightVM flightinfo)
        {
            //Convert VM to Models and Save the data
            ctx.SaveChanges();
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
