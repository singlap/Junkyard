using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BlogSitesiV._1.Data;
using BlogSitesiV._1.Data.Model;

namespace BlogSitesiV._1.Controllers
{
    public class MakaleController : Controller
    {
        private Context db = new Context();

        // GET: Makale
        public ActionResult Index()
        {
            var makales = db.Makales.Include(m => m.kategori);
            return View(makales.ToList());
        }

        // GET: Makale/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Makale makale = db.Makales.Find(id);
            if (makale == null)
            {
                return HttpNotFound();
            }
            return View(makale);
        }

        // GET: Makale/Create
        public ActionResult Create()
        {
            ViewBag.kategoriID = new SelectList(db.Kategoris, "kategoriID", "kategoriAd");
            return View();
        }

        // POST: Makale/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "makaleID,makaleBaslik,makaleOzet,makaleIcerik,makaleResim,makaleOkunma,makaleYorumSayisi,kategoriID")] Makale makale)
        {
            if (ModelState.IsValid)
            {
                db.Makales.Add(makale);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.kategoriID = new SelectList(db.Kategoris, "kategoriID", "kategoriAd", makale.kategoriID);
            return View(makale);
        }

        // GET: Makale/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Makale makale = db.Makales.Find(id);
            if (makale == null)
            {
                return HttpNotFound();
            }
            ViewBag.kategoriID = new SelectList(db.Kategoris, "kategoriID", "kategoriAd", makale.kategoriID);
            return View(makale);
        }

        // POST: Makale/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "makaleID,makaleBaslik,makaleOzet,makaleIcerik,makaleResim,makaleOkunma,makaleYorumSayisi,kategoriID")] Makale makale)
        {
            if (ModelState.IsValid)
            {
                db.Entry(makale).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.kategoriID = new SelectList(db.Kategoris, "kategoriID", "kategoriAd", makale.kategoriID);
            return View(makale);
        }

        // GET: Makale/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Makale makale = db.Makales.Find(id);
            if (makale == null)
            {
                return HttpNotFound();
            }
            return View(makale);
        }

        // POST: Makale/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Makale makale = db.Makales.Find(id);
            db.Makales.Remove(makale);
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
