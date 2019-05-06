using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SheetMusic.Models;
using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security.Provider;

namespace SheetMusic.Controllers
{
    public class PiecesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();



        // GET: Pieces
        public ActionResult Index(string searchParams, string sortOrder)
        {
            return View();
        }

        // GET: Pieces/Details/5
        public ActionResult Details()
        {
            return View();
        }

        // GET: Pieces/Create
        public ActionResult Create()
        {
            return View();
        }


        // GET: Pieces/Edit/5
        public ActionResult Edit()
        {
            return View();
        }


        // GET: Pieces/Delete/
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Piece piece = db.Pieces.Find(id);
            if (piece == null)
            {
                return HttpNotFound();
            }
            return View(piece);
        }

        // POST: Pieces/Delete/
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Piece piece = db.Pieces.Find(id);
            db.Pieces.Remove(piece);
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
