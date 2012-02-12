using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using travel.Models;


namespace travel.Controllers
{
    // þetta er sett til þess að geta vista html i gagnagrunninn
    [ValidateInput(false)]
    public class TripController : Controller
    {
        //
        // tengjum okkur við repository
        Repository db = new Repository();
       


        public ActionResult Index(int id)
        {
            
            var users = db.GetUsers();
            var tripstype = db.GetAllTripByTripID(id);
            var triplist =  tripstype.OrderByDescending(a => a.UserId);
            return View(users);
        }
        
        /// <summary>
        /// Trip/Test/1
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>

        public ActionResult Test(int id)
        {

            var users = db.GetUsersByType(id);
            return View(users);
        }


        public ActionResult Prufa(int id)
        {

            var users = db.GetUsers();
            var tripstype = db.GetAllTripByTripID(id);
            var triplist = tripstype.OrderByDescending(a => a.Users.UserId).ToList();

            var model = new TripModel
            {
                Trip = triplist,
                Users = users
            };

            return View(model);
        }


        //
        // GET: /Trip/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Trip/Create

        public ActionResult Create()
        {

            
            return View();
        } 

        //
        // POST: /Trip/Create

        [HttpPost]
        public ActionResult Create(Trip trip)
        {
            try
            {
                // TODO: Add insert logic here
                db.AddTrip(trip);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        
        //
        // GET: /Trip/Edit/5

        public ActionResult Edit(int id)
        {
            Trip trip = db.GetTrip(id);
            return View(trip);
        }

        //
        // POST: /Trip/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, Trip trip)
        {
            try
            {
                trip.IDTrip = id;
                db.UpdateTrip(trip);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Trip/Delete/5
 
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Trip/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
 
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
