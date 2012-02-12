using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace travel.Models
{
    public class TripModel
    {
        public IEnumerable<Trip> Trip { get; set; }
        public IEnumerable <TripType> TripType { get; set; }
        public IEnumerable<Users> Users { get; set; }
     
    }

    public class UsersModel {
        public IEnumerable<Users> Users { get; set; }
    }


   
    
}