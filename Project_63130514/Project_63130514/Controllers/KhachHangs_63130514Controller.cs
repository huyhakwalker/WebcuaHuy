using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Project_63130514.Models;

namespace Project_63130514.Controllers
{
    public class KhachHangs_63130514Controller : Controller
    {
        Project_63130514Entities db = new Project_63130514Entities();
        // GET: KhachHangs_63130514/Details/5
        public ActionResult Details(int? id)
        {
            var objProduct = db.KhachHangs.Where(n => n.MaKhachHang == id).FirstOrDefault();
            return View(objProduct);
        }

        // GET: KhachHangs_63130514/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            KhachHang khachHang = db.KhachHangs.Find(id);
            if (khachHang == null)
            {
                return HttpNotFound();
            }
            return View(khachHang);
        }

        // POST: KhachHangs_63130514/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaKhachHang,Taikhoan,Matkhau,TenKhachHang,SoDienThoai,Email,DiaChi")] KhachHang khachHang)
        {
            if (ModelState.IsValid)
            {
                db.Entry(khachHang).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Login", "Home_63130514");
            }
            return View(khachHang);
        }
    }
}
