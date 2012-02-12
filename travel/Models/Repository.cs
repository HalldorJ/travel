using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using travel.Models;

namespace travel.Models
{
    public class Repository : travel.Models.IRepository
    {
        aspnetEntities db = new aspnetEntities();

        public List<Trip> GetAllTrips()
        {
            return db.Trip.ToList();
        }

        public List<Trip> GetAllTripByTripID(int id)
        {

            return db.Trip.Where(d => d.IDTripType == id).ToList();
        }

        public IEnumerable<UserWithTrips> GetUsersByType(int type)
        {
            return db.Trip.Where(t => t.IDTripType == type).GroupBy(t => t.Users).ToList().Select(i =>
                new UserWithTrips
                {
                    User = i.Key,
                    Trips = i.ToList()
                });
        }


        /// <summary>
        /// Sækir trip by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Trip GetTrip(int id)
        {
            return db.Trip.SingleOrDefault(d => d.IDTrip == id);
        }

        public IQueryable<Users> GetUsers() {
            return db.Users;
        }



        public void UpdateTrip(Trip trip) {
            var original = db.Trip.SingleOrDefault(m => m.IDTrip == trip.IDTrip);
            if (original != null) {
                original.Name = trip.Name;
                original.Includes = trip.Includes;
                original.Minimum = trip.Minimum;
                original.Operation = trip.Operation;
                original.PickupTime = trip.PickupTime;
                original.Price = trip.Price;
                db.SaveChanges();
            }
        
        }


        public void AddTrip(Trip trip) {

            db.Trip.AddObject(trip);
            db.SaveChanges();
        }


        /// <summary>
        /// get all trips types  Jeppaferðir, Gönguferðir.....
        /// </summary>
        public List<TripType> GetTripsTypeList()
        {
           return db.TripType.ToList();   
        }

        /// <summary>
        /// sækjum oll tip sem hafa id sem tripid
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public TripType GetTripsTypeByID(int id)
        {
            return db.TripType.SingleOrDefault(d => d.IDTripType == id);
        
        }

    }
}