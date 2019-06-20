using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using RedyFitness2.Models;

namespace RedyFitness2.Controllers
{
    public class WorkoutModelsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: WorkoutModels
        public ActionResult Index()
        {
            return View(db.WorkoutModels.ToList());
        }

        // GET: WorkoutModels/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            WorkoutModel workoutModel = db.WorkoutModels.Find(id);
            if (workoutModel == null)
            {
                return HttpNotFound();
            }
            return View(workoutModel);
        }

        // GET: WorkoutModels/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: WorkoutModels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,maxReps,maxWeight,Name,Notes,Date")] WorkoutModel workoutModel)
        {
            if (ModelState.IsValid)
            {
                db.WorkoutModels.Add(workoutModel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(workoutModel);
        }

        // GET: WorkoutModels/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            WorkoutModel workoutModel = db.WorkoutModels.Find(id);
            if (workoutModel == null)
            {
                return HttpNotFound();
            }
            return View(workoutModel);
        }

        // POST: WorkoutModels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,maxReps,maxWeight,Name,Notes,Date")] WorkoutModel workoutModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(workoutModel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(workoutModel);
        }

        // GET: WorkoutModels/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            WorkoutModel workoutModel = db.WorkoutModels.Find(id);
            if (workoutModel == null)
            {
                return HttpNotFound();
            }
            return View(workoutModel);
        }

        // POST: WorkoutModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            WorkoutModel workoutModel = db.WorkoutModels.Find(id);
            db.WorkoutModels.Remove(workoutModel);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
