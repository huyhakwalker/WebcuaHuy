﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Project_63130514.Models;

namespace Project_63130514.Areas.Admin.Controllers
{
    public class MonAnsAdmin_63130514Controller : Controller
    {
        private Project_63130514Entities db = new Project_63130514Entities();

        // GET: Admin/MonAnsAdmin_63130514
        public ActionResult Index()
        {
            return View(db.MonAns.ToList());
        }

        // GET: Admin/MonAnsAdmin_63130514/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MonAn monAn = db.MonAns.Find(id);
            if (monAn == null)
            {
                return HttpNotFound();
            }
            return View(monAn);
        }

        // GET: Admin/MonAnsAdmin_63130514/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/MonAnsAdmin_63130514/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaMonAn,TenMonAn,Gia,AnhMonAn,MoTa,LoaiMonAn")] MonAn monAn)
        {
            if (ModelState.IsValid)
            {
                db.MonAns.Add(monAn);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(monAn);
        }

        // GET: Admin/MonAnsAdmin_63130514/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MonAn monAn = db.MonAns.Find(id);
            if (monAn == null)
            {
                return HttpNotFound();
            }
            return View(monAn);
        }

        // POST: Admin/MonAnsAdmin_63130514/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaMonAn,TenMonAn,Gia,AnhMonAn,MoTa,LoaiMonAn")] MonAn monAn)
        {
            if (ModelState.IsValid)
            {
                db.Entry(monAn).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(monAn);
        }

        // GET: Admin/MonAnsAdmin_63130514/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MonAn monAn = db.MonAns.Find(id);
            if (monAn == null)
            {
                return HttpNotFound();
            }
            return View(monAn);
        }

        // POST: Admin/MonAnsAdmin_63130514/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            MonAn monAn = db.MonAns.Find(id);
            db.MonAns.Remove(monAn);
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
