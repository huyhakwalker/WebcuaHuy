using System;
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
    public class DonHangsAdmin_63130514Controller : Controller
    {
        private Project_63130514Entities db = new Project_63130514Entities();

        // GET: Admin/DonHangsAdmin_63130514
        public ActionResult Index()
        {
            var donHangs = db.DonHangs.Include(d => d.KhachHang);
            return View(donHangs.ToList());
        }
        public ActionResult Duyet(int? id)
        {
            var donHang = db.DonHangs.Find(id);
            if (donHang != null)
            {
                donHang.TinhTrang = 1; // Đặt tình trạng là "Đã duyệt"
                db.SaveChanges();
            }

            return RedirectToAction("Index");
        }
        public ActionResult Huy(int? id)
        {
            var donHang = db.DonHangs.Find(id);
            if (donHang != null)
            {
                donHang.TinhTrang = 2; // Đặt tình trạng là "Đã hủy"
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }
        public ActionResult DoanhThu()
        {
            var donHangs = db.DonHangs.Where(d => d.TinhTrang == 1).ToList();
            ViewBag.donHangs = donHangs;
            return View(donHangs);
        }
    }
}
