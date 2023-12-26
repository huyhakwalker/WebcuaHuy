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
    public class ChiTietDonHangsAdmin_63130514Controller : Controller
    {
        private Project_63130514Entities db = new Project_63130514Entities();
        public ActionResult Details(int? id)
        {
            var abc = db.ChiTietDonHangs.Where(n => n.MaDonHang == id).FirstOrDefault();
            return View(abc);
        }
    }
}
