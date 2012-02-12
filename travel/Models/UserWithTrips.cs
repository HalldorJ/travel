using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace travel.Models
{
    public class UserWithTrips
    {
        public Users User { get; set; }
        public List<Trip> Trips { get; set; }
    }
}