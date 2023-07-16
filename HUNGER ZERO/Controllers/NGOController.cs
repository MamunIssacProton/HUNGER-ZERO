using HUNGER_ZERO.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;


namespace HUNGER_ZERO.Controllers
{
    public class NGOController : Controller
    {
        private readonly HUNGEREntities1 _context;

        public NGOController()
        {
            _context = new HUNGEREntities1();
        }

        // GET: NGO
        public ActionResult Index()
        {
            var NGO = _context.NGOes.ToList();
            return View(NGO);
        }

        // GET: NGO/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: NGO/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(NGO NGO)
        {
            if (ModelState.IsValid)
            {
                _context.NGOes.Add(NGO);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(NGO);
        }

        // GET: NGO/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            NGO NGO = _context.NGOes.Find(id);
            if (NGO == null)
            {
                return HttpNotFound();
            }
            return View(NGO);
        }

        // POST: NGO/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(NGO NGO)
        {
            if (ModelState.IsValid)
            {
                _context.Entry(NGO).State = EntityState.Modified;
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(NGO);
        }

        // GET: NGO/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            NGO NGO = _context.NGOes.Find(id);
            if (NGO == null)
            {
                return HttpNotFound();
            }
            return View(NGO);
        }

        // POST: NGO/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            NGO NGO = _context.NGOes.Find(id);
            _context.NGOes.Remove(NGO);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _context.Dispose();
            }
            base.Dispose(disposing);
        }
    }





}