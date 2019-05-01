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
            ViewBag.GenreSearchParm = String.IsNullOrEmpty(searchParams) ? "search_Genre" : "";
            ViewBag.DifficultySearchParm = String.IsNullOrEmpty(searchParams) ? "search_Difficulty" : "";
            ViewBag.YearSearchParm = String.IsNullOrEmpty(searchParams) ? "search_Year" : "";

            string currentUserId = User.Identity.GetUserId();
            ApplicationUser currentUser = db.Users.FirstOrDefault(x => x.Id == currentUserId);

            if (!String.IsNullOrEmpty(searchParams))
            {
                var d = db.Pieces.ToList().Where(x => x.User == currentUser);
                switch (sortOrder)
                {
                    //Check URL for search type
                    case "search_Genre":
                        d = d.Where(m => m.Genre.ToLower().Contains(searchParams.ToLower()));
                        break;

                    case "search_Difficulty":
                        d = d.Where(m => m.Difficulty.ToLower().Contains(searchParams.ToLower()));
                        break;
                    case "search_Year":
                        d = d.Where(m => m.Year.ToString().ToLower().Contains(searchParams.ToLower()));
                        break;
                    //Default to name if none found.
                    default:
                        d = d.Where(m => m.PieceName.ToLower().Contains(searchParams.ToLower()));
                        break;
                }

                return View(d.ToList());
            }
            return View(db.Pieces.ToList().Where(x => x.User == currentUser));
        }

        // GET: Pieces/Details/5
        public ActionResult Details(int? id)
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

        // GET: Pieces/Create
        public ActionResult Create()
        {
            Piece _piece = new Piece();
            return View(_piece);
        }

        // POST: Pieces/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,PieceName,PieceSubName,Artist,Genre,Year,Difficulty,Description")] Piece piece)
        {
            if (ModelState.IsValid)
            {
                string currentUserId = User.Identity.GetUserId();
                ApplicationUser currentUser = db.Users.FirstOrDefault(x => x.Id == currentUserId);
                piece.User = currentUser;
                db.Pieces.Add(piece);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(piece);
        }

        // GET: Pieces/Edit/5
        public ActionResult Edit(int? id)
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

        // POST: Pieces/Edit/
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,PieceName,PieceSubName,Artist,Genre,Year,Difficulty,Description")] Piece piece)
        {
            if (ModelState.IsValid)
            {
                db.Entry(piece).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(piece);
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
