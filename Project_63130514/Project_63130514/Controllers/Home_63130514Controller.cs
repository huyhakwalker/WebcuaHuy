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
    public class Home_63130514Controller : Controller
    {
        private Project_63130514Entities db = new Project_63130514Entities();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Cart()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Checkout()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(string taikhoan, string password)
        {

            var data = db.NhanViens.Where(s => s.Taikhoannv.Equals(taikhoan) && s.Matkhaunv.Equals(password));
            if (data.Count() > 0)
            {
                //add session
                Session["name"] = data.FirstOrDefault().TenNhanVien;
                Session["taikhoan"] = data.FirstOrDefault().Taikhoannv;
                Session["id"] = data.FirstOrDefault().MaNhanVien;
                return RedirectToAction("Index", "Admin/NhanViensAdmin_63130514");
            }
            var data2 = db.KhachHangs.Where(s => s.Taikhoan.Equals(taikhoan) && s.Matkhau.Equals(password));
            if (data2.Count() > 0)
            {
                //add session
                Session["name"] = data2.FirstOrDefault().TenKhachHang;
                Session["taikhoan"] = data2.FirstOrDefault().Taikhoan;
                Session["id"] = data2.FirstOrDefault().MaKhachHang;
                return RedirectToAction("Index", "Home");
            }
            ViewBag.error = "Tên đăng nhập hoặc mật khẩu không đúng";
            return View();
        }
        public ActionResult Orders()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult UserProfile()
        {
            return View();
        }
        public ActionResult Register()
        {
            return View();
        }

        //POST: Register
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register(KhachHang _user)
        {
            if (ModelState.IsValid)
            {
                var check = db.KhachHangs.FirstOrDefault(s => s.Taikhoan == _user.Taikhoan);
                if (check == null)
                {
                    db.Configuration.ValidateOnSaveEnabled = false;
                    db.KhachHangs.Add(_user);
                    db.SaveChanges();
                    Session["TenKhachHang"] = _user.TenKhachHang;
                    Session["Taikhoan"] = _user.Taikhoan;
                    Session["id"] = _user.MaKhachHang;
                    ViewBag.SuccessMessage = "Đăng ký thành công!";
                    return RedirectToAction("Login" , "Home");
                }
                else
                {
                    ViewBag.error = "Tai khoan already exists";
                    return View();
                }
            }
            return View();
        }
        public ActionResult Search()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Update_address()
        {
            return View();
        }
        public ActionResult Update_profile()
        {
            return View();
        }
        public ActionResult Logout()
        {
            Session.Clear();
            return RedirectToAction("Login");
        }
    }
}