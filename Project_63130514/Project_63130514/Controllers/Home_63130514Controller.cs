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
            return View(db.MonAns.ToList());
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }
        public ActionResult Cart()
        {
            return View();
        }
        public ActionResult Checkout()
        {
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
                Session["sdt"] = data2.FirstOrDefault().SoDienThoai;
                Session["email"] = data2.FirstOrDefault().Email;
                Session["diachi"] = data2.FirstOrDefault().DiaChi;
                return RedirectToAction("Index", "Home_63130514");
            }
            ViewBag.error = "Tên đăng nhập hoặc mật khẩu không đúng";
            return View();
        }
        public ActionResult Orders()
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
                    return RedirectToAction("Login" , "Home_63130514");
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
            return View();
        }
        public ActionResult Logout()
        {
            Session.Clear();
            return RedirectToAction("Login");
        }
    }
}