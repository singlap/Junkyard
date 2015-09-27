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
    public class YorumController : Controller
    {
        private Context db = new Context();

        // GET: Yorum
        public ActionResult Index()
        {
            var yorums = db.Yorums.Include(y => y.makale).Include(y => y.uye);
            return View(yorums.ToList());
        }

        // GET: Yorum/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Yorum yorum = db.Yorums.Find(id);
            if (yorum == null)
            {
                return HttpNotFound();
            }
            return View(yorum);
        }

        // GET: Yorum/Create
        public ActionResult Create()
        {
            ViewBag.makaleID = new SelectList(db.Makales, "makaleID", "makaleBaslik");
            ViewBag.uyeID = new SelectList(db.Uyes, "uyeID", "uyeAd");
            return View();
        }

        // POST: Yorum/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "yorumID,yorumTarih,YorumOnay,yorumResim,makaleID,uyeID")] Yorum yorum)
        {
            if (ModelState.IsValid)
            {
                db.Yorums.Add(yorum);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.makaleID = new SelectList(db.Makales, "makaleID", "makaleBaslik", yorum.makaleID);
            ViewBag.uyeID = new SelectList(db.Uyes, "uyeID", "uyeAd", yorum.uyeID);
            return View(yorum);
        }

        // GET: Yorum/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Yorum yorum = db.Yorums.Find(id);
            if (yorum == null)
            {
                return HttpNotFound();
            }
            ViewBag.makaleID = new SelectList(db.Makales, "makaleID", "makaleBaslik", yorum.makaleID);
            ViewBag.uyeID = new SelectList(db.Uyes, "uyeID", "uyeAd", yorum.uyeID);
            return View(yorum);
        }

        // POST: Yorum/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "yorumID,yorumTarih,YorumOnay,yorumResim,makaleID,uyeID")] Yorum yorum)
        {
            if (ModelState.IsValid)
            {
                db.Entry(yorum).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.makaleID = new SelectList(db.Makales, "makaleID", "makaleBaslik", yorum.makaleID);
            ViewBag.uyeID = new SelectList(db.Uyes, "uyeID", "uyeAd", yorum.uyeID);
            return View(yorum);
        }

        // GET: Yorum/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Yorum yorum = db.Yorums.Find(id);
            if (yorum == null)
            {
                return HttpNotFound();
            }
            return View(yorum);
        }

        // POST: Yorum/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Yorum yorum = db.Yorums.Find(id);
            db.Yorums.Remove(yorum);
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
