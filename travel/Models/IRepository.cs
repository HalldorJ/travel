using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace travel.Models
{
    public interface IRepository
    {
        List<Trip> GetAllTrips();
        Trip GetTrip(int id);
        List<TripType> GetTripsTypeList();
        List<Trip> GetAllTripByTripID(int id);
       
    }
}