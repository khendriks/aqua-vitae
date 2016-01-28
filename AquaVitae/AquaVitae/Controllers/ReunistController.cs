using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AquaVitae.Models;
using AquaVitae.DataAccessLayer;

namespace AquaVitae.Controllers
{
    public class ReunistController : Controller
    {
        private AquaVitaeContext db = new AquaVitaeContext();

        // GET: Reunist
        public ActionResult Index()
        {
            return View(db.Reunisten.ToList());
        }

        // GET: Reunist/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Reunist reunist = db.Reunisten.Find(id);
            if (reunist == null)
            {
                return HttpNotFound();
            }
            return View(reunist);
        }

        // GET: Reunist/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Reunist/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Voornaam,Achternaam,GeboorteDatum,Corpsjaar,Telefoonnummer,Email,Login,Password")] Reunist reunist)
        {
            if (ModelState.IsValid)
            {
                db.Reunisten.Add(reunist);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(reunist);
        }

        // GET: Reunist/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Reunist reunist = db.Reunisten.Find(id);
            if (reunist == null)
            {
                return HttpNotFound();
            }
            return View(reunist);
        }

        // POST: Reunist/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Voornaam,Achternaam,GeboorteDatum,Corpsjaar,Telefoonnummer,Email,Login,Password")] Reunist reunist)
        {
            if (ModelState.IsValid)
            {
                db.Entry(reunist).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(reunist);
        }

        // GET: Reunist/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Reunist reunist = db.Reunisten.Find(id);
            if (reunist == null)
            {
                return HttpNotFound();
            }
            return View(reunist);
        }

        // POST: Reunist/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Reunist reunist = db.Reunisten.Find(id);
            db.Reunisten.Remove(reunist);
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
