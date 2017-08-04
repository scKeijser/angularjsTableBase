using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Planes101.Models
{
    public class AddFlightVM
    {
        public string StartLoc { get; set; }
        public string EndLoc { get; set; }
        public int PlaneID { get; set; }
        public int[] Passengers { get; set; }
    }
}